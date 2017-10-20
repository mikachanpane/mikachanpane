using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sugitec.Common;
using System.Data;

namespace Sugitec.Logics
{
   public class srvReq010 :srvBase
    {
        /// <summary>
        ///　受注データに存在する得意先の一覧を取得
        /// </summary>
        /// <param name="CutoffDay">締日</param>
        /// <returns>検索結果</returns>
        public DataTable GetCustomer(int CutoffDay)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("SELECT ORD.CUSTOMER_CD,CUS.NAME ");
                sb.AppendFormat("  FROM T_ORDER ORD ");
                sb.AppendFormat(" INNER JOIN M_CUSTOMER CUS ON ORD.CUSTOMER_CD = CUS.CODE ");
                sb.AppendFormat(" WHERE ORD.DEL_FLG = 0 ");
                sb.AppendFormat("   AND CUS.DEL_FLG = 0 ");
                sb.AppendFormat("   AND CUS.CUTOFF_DAY = {0} ", CutoffDay);
                sb.AppendFormat(" GROUP BY ORD.CUSTOMER_CD, CUS.NAME ");
                sb.AppendFormat(" ORDER BY ORD.CUSTOMER_CD ");
                return base.ExecuteSelect(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 請求データ作成処理
        /// </summary>
        /// <param name="dto">Req010用のDTO</param>
        /// <returns></returns>
        public void MakeReqData(dtoReq010 dto)
        {
            try
            {
                //売上情報削除分の請求情報と請求明細情報を削除    
                DelRequest(dto);

                //請求情報の作成
                MakeRequest(dto);

                //請求明細情報の作成
                MakeRequestDtl2(dto);

                //売上情報の請求フラグを更新
                UpdSales(dto);

                //請求情報の完了フラグを更新
                UpdRequestFinish(dto);

                //コミット
                base.TrnCommit();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #region "売上情報削除分の請求情報と請求明細情報を削除"

        /// <summary>
        /// 売上情報削除分の請求情報と請求明細情報を削除
        /// </summary>
        /// <param name="dto">Req010用のDTO</param>
        /// <returns></returns>
        private void DelRequest(dtoReq010 dto)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                //売上情報の削除分を抽出
                sb.AppendFormat("SELECT ");
                sb.AppendFormat("    D.REQUEST_NO ");
                sb.AppendFormat("   ,D.REQUEST_SUB_NO ");
                sb.AppendFormat("  FROM ");
                sb.AppendFormat("    (  ");
                sb.AppendFormat("    SELECT ");
                sb.AppendFormat("        SAL.SALES_NO ");
                sb.AppendFormat("      FROM M_CUSTOMER AS CUS INNER JOIN T_SALES AS SAL ");
                sb.AppendFormat("        ON (CUS.CODE = SAL.CUSTOMER_CD AND SAL.DEL_FLG = 1) ");
                sb.AppendFormat("     WHERE CUS.CUTOFF_DAY  = {0} ", dto.CutOffDay);
                if (dto.CusCode != "00000000")
                {
                    sb.AppendFormat("       AND CUS.CODE = '{0}' ", dto.CusCode);
                }
                sb.AppendFormat("    ) AS M ");
                sb.AppendFormat("    INNER JOIN T_REQUEST_DTL AS D ");
                sb.AppendFormat("       ON (M.SALES_NO = D.SALES_NO AND D.DEL_FLG = 0) ");
                sb.AppendFormat(" ORDER BY D.REQUEST_NO,D.REQUEST_SUB_NO");
                DataTable dt = base.ExecuteSelect(sb.ToString());

                //請求明細情報を削除
                List<string> ReqNoList = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    sb.Clear();
                    sb.AppendFormat("UPDATE T_REQUEST_DTL SET ");
                    sb.AppendFormat("    DEL_FLG  =  1 ");
                    sb.AppendFormat("   ,SYNC_FLG = {0} ", dto.SyncFlf);
                    sb.AppendFormat("   ,TIME_STAMP = '{0}' ", dto.TimeStamp);
                    sb.AppendFormat(" WHERE REQUEST_NO     = '{0}' ", row["REQUEST_NO"].ToString());
                    sb.AppendFormat("   AND REQUEST_SUB_NO = '{0}' ", row["REQUEST_SUB_NO"].ToString());
                    base.ExecuteAction(sb.ToString(), false);

                    if (!ReqNoList.Contains(row["REQUEST_NO"].ToString()))
                    {
                        ReqNoList.Add(row["REQUEST_NO"].ToString());
                    }
                }
                
                //請求情報の削除
                foreach (string ReqNo in ReqNoList)
                {
                    sb.Clear();
                    sb.AppendFormat("SELECT REQUEST_NO,REQUEST_SUB_NO ");
                    sb.AppendFormat("  FROM T_REQUEST_DTL ");
                    sb.AppendFormat(" WHERE REQUEST_NO = '{0}' ", ReqNo);
                    sb.AppendFormat("   AND DEL_FLG    =  0 ");
                    DataTable dtc = base.ExecuteSelect(sb.ToString());
                    if (dtc.Rows.Count == 0)
                    {
                        sb.Clear();
                        sb.AppendFormat("UPDATE T_REQUEST SET ");
                        sb.AppendFormat("    DEL_FLG       =   1 ");
                        sb.AppendFormat("   ,SYNC_FLG      =  {0} ", dto.SyncFlf);
                        sb.AppendFormat("   ,TIME_STAMP    = '{0}' ", dto.TimeStamp);
                        sb.AppendFormat(" WHERE REQUEST_NO = '{0}' ", ReqNo);
                        base.ExecuteAction(sb.ToString(), false);
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region "請求情報"

        /// <summary>
        /// 請求情報を作成
        /// </summary>
        /// <param name="dto">Req010用のDTO</param>
        /// <returns></returns>
        private void MakeRequest(dtoReq010 dto)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("SELECT ");
                sb.AppendFormat("    M.SALES_YM          AS SAL_YM ");
                sb.AppendFormat("   ,M.CUSTOMER_CD       AS COS_CD ");
                sb.AppendFormat("   ,M.PAYMENT_KBN       AS PAY_KB ");
                sb.AppendFormat("   ,M.PAYMENT_DAY       AS PAY_DAY ");
                sb.AppendFormat("   ,R.REQUEST_NO        AS REQ_NO ");
                sb.AppendFormat("   ,SUM(S.SALES_AMOUNT) AS SAL_AMT ");
                sb.AppendFormat("   ,SUM(S.TAX_AMOUNT)   AS TAX_AMT ");
                sb.AppendFormat("  FROM ");
                sb.AppendFormat("    ((( ");
                sb.AppendFormat("    SELECT ");
                sb.AppendFormat("        SAL.SALES_YM ");
                sb.AppendFormat("       ,SAL.CUSTOMER_CD ");
                sb.AppendFormat("       ,CUS.PAYMENT_KBN ");
                sb.AppendFormat("       ,CUS.PAYMENT_DAY ");
                sb.AppendFormat("      FROM M_CUSTOMER AS CUS ");
                sb.AppendFormat("           INNER JOIN T_SALES AS SAL ");
                sb.AppendFormat("             ON CUS.CODE = SAL.CUSTOMER_CD ");
                sb.AppendFormat("     WHERE CUS.CUTOFF_DAY  = {0} ",dto.CutOffDay);
                if (dto.CusCode != "00000000")
                {
                    sb.AppendFormat("       AND CUS.CODE = '{0}' ", dto.CusCode);
                }
                sb.AppendFormat("       AND SAL.BILLING_FLG = 0 ");
                //sb.AppendFormat("       AND SAL.DEL_FLG = 0 ");
                sb.AppendFormat("     GROUP BY SAL.SALES_YM,SAL.CUSTOMER_CD,CUS.PAYMENT_KBN,CUS.PAYMENT_DAY ");
                sb.AppendFormat("    ) AS M ");
                sb.AppendFormat("    INNER JOIN T_SALES AS S ");
                sb.AppendFormat("      ON (M.SALES_YM = S.SALES_YM AND M.CUSTOMER_CD = S.CUSTOMER_CD AND S.DEL_FLG = 0) ");
                sb.AppendFormat("    ) ");
                sb.AppendFormat("    LEFT  JOIN (SELECT BILLING_YM,CUSTOMER_CD,REQUEST_NO  FROM T_REQUEST WHERE FINISH_FLG = 0 AND DEL_FLG = 0) AS R ");
                sb.AppendFormat("      ON S.SALES_YM = R.BILLING_YM AND S.CUSTOMER_CD = R.CUSTOMER_CD ");
                sb.AppendFormat("    ) ");
                sb.AppendFormat(" GROUP BY M.SALES_YM,M.CUSTOMER_CD,R.REQUEST_NO,M.PAYMENT_KBN,M.PAYMENT_DAY ");
                sb.AppendFormat(" ORDER BY M.SALES_YM,M.CUSTOMER_CD ");
                DataTable dt = base.ExecuteSelect(sb.ToString());

                foreach (DataRow row in dt.Rows)
                {
                    if (row["REQ_NO"].ToString() == "")
                    {
                        InsRequest(row,dto);
                    }
                    else
                    {
                        UpdRequest(row,dto);
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 請求情報の追加
        /// </summary>
        /// <param name="row">対象データ</param>
        /// <param name="dto">Req010用のDTO</param>
        private void InsRequest(DataRow row, dtoReq010 dto)
        {
            try
            {
                //請求年月
                String BillYM = row["SAL_YM"].ToString();
                //支払区分
                String PayKbn = row["PAY_KB"].ToString();
                //支払日
                int PayDay = row["PAY_DAY"].ToIntlEx();
                //振込指定日
                String TransYmd = CalcTranYmd(BillYM, PayDay, PayKbn);
                //請求金額
                Decimal BillAmt = row["SAL_AMT"].ToDecimalEx() + row["TAX_AMT"].ToDecimalEx();
                //請求№
                String ReqNo = base.NumberingRequest(BillYM);

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("INSERT INTO T_REQUEST ");
                sb.AppendFormat("(");
                sb.AppendFormat(" REQUEST_NO");
                sb.AppendFormat(",BILLING_YM");
                sb.AppendFormat(",CUSTOMER_CD");
                sb.AppendFormat(",TRANSFER_YMD");
                sb.AppendFormat(",BILLING_AMOUNT");
                sb.AppendFormat(",CASH");
                sb.AppendFormat(",BILL");
                sb.AppendFormat(",DEPOSIT");
                sb.AppendFormat(",TRANSFER_FEES");
                sb.AppendFormat(",DISCOUNT");
                sb.AppendFormat(",CANCEL");
                sb.AppendFormat(",DEPOSIT_AMOUNT");
                sb.AppendFormat(",DEPOSIT_RECV_AMOUNT");
                sb.AppendFormat(",DIFFERENCE");
                sb.AppendFormat(",DIFF_REASONS_CD");
                sb.AppendFormat(",FINISH_FLG");
                sb.AppendFormat(",DEL_FLG");
                sb.AppendFormat(",SYNC_FLG");
                sb.AppendFormat(",TIME_STAMP");
                sb.AppendFormat(") VALUES (");
                sb.AppendFormat(" '{0}'", ReqNo);  
                sb.AppendFormat(",'{0}'", BillYM);  
                sb.AppendFormat(",'{0}'", row["COS_CD"].ToString());
                sb.AppendFormat(",'{0}'", TransYmd);
                sb.AppendFormat(",{0}", BillAmt);
                sb.AppendFormat(",{0}",0);
                sb.AppendFormat(",{0}",0);
                sb.AppendFormat(",{0}",0);
                sb.AppendFormat(",{0}",0);
                sb.AppendFormat(",{0}",0);
                sb.AppendFormat(",{0}",0);
                sb.AppendFormat(",{0}", 0);
                sb.AppendFormat(",{0}", BillAmt);
                sb.AppendFormat(",{0}", 0);
                sb.AppendFormat(",'{0}'","");
                sb.AppendFormat(",{0}", 0);
                sb.AppendFormat(",{0}", 0);
                sb.AppendFormat(",{0}", dto.SyncFlf);
                sb.AppendFormat(",'{0}'", dto.TimeStamp);
                sb.AppendFormat(")");
                base.ExecuteAction(sb.ToString(),false);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 請求情報の更新
        /// </summary>
        /// <param name="row">対象データ</param>
        /// <param name="dto">Req010用のDTO</param>
        private void UpdRequest(DataRow row, dtoReq010 dto)
        {
            try
            {
                //請求金額
                Decimal BillAmt = row["SAL_AMT"].ToDecimalEx() + row["TAX_AMT"].ToDecimalEx();

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("UPDATE T_REQUEST SET ");
                sb.AppendFormat(" BILLING_AMOUNT = {0}", BillAmt);
                sb.AppendFormat(",DEPOSIT_RECV_AMOUNT = {0} - DEPOSIT_AMOUNT ", BillAmt);
                sb.AppendFormat(",SYNC_FLG = {0} ", dto.SyncFlf);
                sb.AppendFormat(",TIME_STAMP = '{0}' ",dto.TimeStamp);
                sb.AppendFormat(" WHERE REQUEST_NO = '{0}' ", row["REQ_NO"].ToString());
                base.ExecuteAction(sb.ToString(),false);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 振込指定日を算出
        /// </summary>
        /// <param name="ReqYm">請求年月日</param>
        /// <param name="PayDay">支払日</param>
        /// <param name="PayKbn">支払区分</param>
        /// <returns></returns>
        private String CalcTranYmd(string ReqYm,int PayDay,string PayKbn)
        {
            try
            {
                //請求年月の月初を設定
                String   sTmpPay = ReqYm.LeftEx(4) + "/" + ReqYm.RightEx(2) + "/01";
                DateTime dTmpYMD = DateTime.Parse(sTmpPay);

                //加算する月数を算出
                int addMon = 0;
                switch (PayKbn)
                {
                    case "02":
                        addMon = 1;
                        break;
                    case "03":
                        addMon = 2;
                        break;
                    default:
                        addMon = 0;
                        break;
                }

                //請求年月の月初に月数を加算
                dTmpYMD = dTmpYMD.AddMonths(addMon);

                //支払日を設定
                int TmpPayDay = PayDay;
                if (PayDay == 99)
                {
                    TmpPayDay = DateTime.DaysInMonth(dTmpYMD.Year, dTmpYMD.Month);
                }

                //振込指定日を算出
                string TranYmd = dTmpYMD.Year.ToString() + dTmpYMD.Month.ToString().PadLeft(2,'0') + TmpPayDay.ToString().PadLeft(2,'0');

                return TranYmd;
            }
            catch
            {
                throw;
            }

        }

        #endregion

        #region "請求明細情報"

        /// <summary>
        /// 請求明細情報を作成
        /// </summary>
        /// <param name="dto">Req010用のDTO</param>
        /// <returns></returns>
        private void MakeRequestDtl2(dtoReq010 dto)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("SELECT ");
                sb.AppendFormat("    M.SALES_YM         AS SAL_YM ");
                sb.AppendFormat("   ,M.CUSTOMER_CD      AS CUS_CD ");
                sb.AppendFormat("   ,M.ENGINEER_ID      AS ENG_ID ");
                sb.AppendFormat("   ,M.SALES_NO         AS SAL_NO ");
                sb.AppendFormat("   ,M.ORDER_NO         AS ORD_NO ");
                sb.AppendFormat("   ,M.SALES_AMOUNT     AS SAL_AMT ");
                sb.AppendFormat("   ,M.TAX_AMOUNT       AS TAX_AMT ");
                sb.AppendFormat("   ,R.REQUEST_NO       AS R_REQ_NO ");
                sb.AppendFormat("   ,R.MAX_SUB_NO       AS R_MAX_SUB_NO ");
                sb.AppendFormat("   ,R.TRANSFER_YMD     AS R_TRANSFER_YMD ");
                sb.AppendFormat("   ,D.REQUEST_NO       AS D_REQ_NO ");
                sb.AppendFormat("   ,D.REQUEST_SUB_NO   AS D_REQ_SUB_NO ");
                sb.AppendFormat("  FROM ");
                sb.AppendFormat("    ((( ");
                sb.AppendFormat("    SELECT ");
                sb.AppendFormat("        SAL.SALES_YM ");
                sb.AppendFormat("       ,SAL.CUSTOMER_CD ");
                sb.AppendFormat("       ,SAL.ENGINEER_ID ");
                sb.AppendFormat("       ,SAL.SALES_NO ");
                sb.AppendFormat("       ,SAL.ORDER_NO ");
                sb.AppendFormat("       ,SAL.SALES_AMOUNT ");
                sb.AppendFormat("       ,SAL.TAX_AMOUNT ");
                sb.AppendFormat("      FROM M_CUSTOMER AS CUS ");
                sb.AppendFormat("           INNER JOIN T_SALES AS SAL ");
                sb.AppendFormat("           ON CUS.CODE = SAL.CUSTOMER_CD ");
                sb.AppendFormat("     WHERE CUS.CUTOFF_DAY  = {0} ", dto.CutOffDay);
                if (dto.CusCode != "00000000")
                {
                    sb.AppendFormat("       AND SAL.CUSTOMER_CD = '{0}' ", dto.CusCode);
                }
                sb.AppendFormat("       AND SAL.BILLING_FLG = 0 ");
                sb.AppendFormat("       AND SAL.DEL_FLG     = 0 ");
                sb.AppendFormat("    ) AS M ");
                sb.AppendFormat("    INNER JOIN ");
                sb.AppendFormat("    ( ");
                sb.AppendFormat("     SELECT ");
                sb.AppendFormat("         R.BILLING_YM ");
                sb.AppendFormat("        ,R.CUSTOMER_CD ");
                sb.AppendFormat("        ,R.REQUEST_NO ");
                sb.AppendFormat("        ,R.TRANSFER_YMD ");
                sb.AppendFormat("        ,MAX(D.REQUEST_SUB_NO) AS MAX_SUB_NO ");
                sb.AppendFormat("       FROM T_REQUEST AS R LEFT JOIN T_REQUEST_DTL AS D ");
                sb.AppendFormat("         ON R.REQUEST_NO = D.REQUEST_NO ");
                sb.AppendFormat("      WHERE R.FINISH_FLG = 0 ");
                sb.AppendFormat("        AND R.DEL_FLG    = 0 ");
                sb.AppendFormat("      GROUP BY R.BILLING_YM,R.CUSTOMER_CD,R.REQUEST_NO,R.TRANSFER_YMD ");
                sb.AppendFormat("    ) AS R ");
                sb.AppendFormat("    ON M.SALES_YM = R.BILLING_YM AND M.CUSTOMER_CD = R.CUSTOMER_CD ");
                sb.AppendFormat("    ) ");
                sb.AppendFormat("    LEFT JOIN  T_REQUEST_DTL AS D ");
                sb.AppendFormat("    ON M.SALES_NO = D.SALES_NO ");
                sb.AppendFormat("    ) ");
                sb.AppendFormat(" ORDER BY M.SALES_YM,M.CUSTOMER_CD,R.REQUEST_NO,M.SALES_NO ");
                DataTable dt = base.ExecuteSelect(sb.ToString());

                string blkReqNo = string.Empty;
                int sudNo = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (blkReqNo != row["R_REQ_NO"].ToString())
                    {
                        blkReqNo = row["R_REQ_NO"].ToString();
                        sudNo = row["R_MAX_SUB_NO"].ToIntlEx();
                    }

                    if (row["D_REQ_NO"].ToString() == "")
                    {
                        //枝番を算出
                        sudNo += 1;
                        //請求明細を作成
                        InsRequestDtl(row, dto, sudNo);
                    }
                    else
                    {
                        //請求明細を更新
                        UpdRequestDtl(row, dto);
                    }

                    ////売上情報の請求フラグを更新
                    //UpdSales(row, dto);
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 請求明細情報の追加
        /// </summary>
        /// <param name="row">対象データ</param>
        /// <param name="dto">Req010用のDTO</param>
        /// <param name="subNo">枝番</param>
        private void InsRequestDtl(DataRow row, dtoReq010 dto, int subNo)
        {
            try
            {
                //請求金額
                Decimal BillAmt = row["SAL_AMT"].ToDecimalEx() + row["TAX_AMT"].ToDecimalEx();

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("INSERT INTO T_REQUEST_DTL ");
                sb.AppendFormat("(");
                sb.AppendFormat(" REQUEST_NO");
                sb.AppendFormat(",REQUEST_SUB_NO");
                sb.AppendFormat(",BILLING_YM");
                sb.AppendFormat(",CUSTOMER_CD");
                sb.AppendFormat(",ENGINEER_ID");
                sb.AppendFormat(",TRANSFER_YMD");
                sb.AppendFormat(",SALES_NO");
                sb.AppendFormat(",ORDER_NO");
                sb.AppendFormat(",BILLING_AMOUNT");
                sb.AppendFormat(",REMARKS");
                sb.AppendFormat(",PUBLISH_FLG");
                sb.AppendFormat(",CASH");
                sb.AppendFormat(",BILL");
                sb.AppendFormat(",DEPOSIT");
                sb.AppendFormat(",TRANSFER_FEES");
                sb.AppendFormat(",DISCOUNT");
                sb.AppendFormat(",CANCEL");
                sb.AppendFormat(",DEPOSIT_AMOUNT");
                sb.AppendFormat(",DEPOSIT_RECV_AMOUNT");
                sb.AppendFormat(",DIFFERENCE");
                sb.AppendFormat(",DIFF_REASONS_CD");
                sb.AppendFormat(",FINISH_FLG");
                sb.AppendFormat(",DEL_FLG");
                sb.AppendFormat(",SYNC_FLG");
                sb.AppendFormat(",TIME_STAMP");
                sb.AppendFormat(") VALUES (");
                sb.AppendFormat(" '{0}'", row["R_REQ_NO"].ToString());
                sb.AppendFormat(",'{0}'", subNo.ToString().PadLeft(2,'0'));
                sb.AppendFormat(",'{0}'", row["SAL_YM"].ToString());
                sb.AppendFormat(",'{0}'", row["CUS_CD"].ToString());
                sb.AppendFormat(",'{0}'", row["ENG_ID"].ToString());
                sb.AppendFormat(",'{0}'", row["R_TRANSFER_YMD"].ToString());
                sb.AppendFormat(",'{0}'", row["SAL_NO"].ToString());
                sb.AppendFormat(",'{0}'", row["ORD_NO"].ToString());
                sb.AppendFormat(",{0}", BillAmt);
                sb.AppendFormat(",'{0}'", "");
                sb.AppendFormat(",{0}", 0);
                sb.AppendFormat(",{0}", 0);
                sb.AppendFormat(",{0}", 0);
                sb.AppendFormat(",{0}", 0);
                sb.AppendFormat(",{0}", 0);
                sb.AppendFormat(",{0}", 0);
                sb.AppendFormat(",{0}", 0);
                sb.AppendFormat(",{0}", 0);
                sb.AppendFormat(",{0}", BillAmt);
                sb.AppendFormat(",{0}", 0);
                sb.AppendFormat(",'{0}'", "");
                sb.AppendFormat(",{0}", 0);
                sb.AppendFormat(",{0}", 0);
                sb.AppendFormat(",{0}", dto.SyncFlf);
                sb.AppendFormat(",'{0}'", dto.TimeStamp);
                sb.AppendFormat(")");
                base.ExecuteAction(sb.ToString(),false);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 請求明細情報の更新
        /// </summary>
        /// <param name="row">対象データ</param>
        /// <param name="dto">Req010用のDTO</param>
        private void UpdRequestDtl(DataRow row, dtoReq010 dto)
        {
            try
            {
                //請求金額
                Decimal BillAmt = row["SAL_AMT"].ToDecimalEx() + row["TAX_AMT"].ToDecimalEx();

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("UPDATE T_REQUEST_DTL SET ");
                sb.AppendFormat(" BILLING_AMOUNT = {0} ", BillAmt);
                sb.AppendFormat(",DEPOSIT_RECV_AMOUNT = {0} - DEPOSIT_AMOUNT ", BillAmt);
                sb.AppendFormat(",PUBLISH_FLG = 0 ");
                sb.AppendFormat(",SYNC_FLG = {0} ",dto.SyncFlf);
                sb.AppendFormat(",TIME_STAMP = '{0}' ", dto.TimeStamp);
                sb.AppendFormat(" WHERE REQUEST_NO = '{0}' ", row["D_REQ_NO"].ToString());
                sb.AppendFormat("   AND REQUEST_SUB_NO = '{0}' ", row["D_REQ_SUB_NO"].ToString());
                base.ExecuteAction(sb.ToString(),false);
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region "売上情報"

        /// <summary>
        /// 売上情報の更新
        /// </summary>
        /// <param name="dto">Req010用のDTO</param>
        private void UpdSales(dtoReq010 dto)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("SELECT ");
                sb.AppendFormat("    SAL.SALES_NO ");
                sb.AppendFormat("  FROM M_CUSTOMER AS CUS INNER JOIN T_SALES AS SAL ");
                sb.AppendFormat("    ON  CUS.CODE     = SAL.CUSTOMER_CD ");
                sb.AppendFormat(" WHERE CUS.CUTOFF_DAY  = {0} ", dto.CutOffDay);
                sb.AppendFormat("   AND SAL.BILLING_FLG = 0 ");
                if (dto.CusCode != "00000000")
                {
                    sb.AppendFormat("   AND SAL.CUSTOMER_CD = '{0}' ", dto.CusCode);
                }
                DataTable dt = base.ExecuteSelect(sb.ToString());

                foreach (DataRow row in dt.Rows)
                {
                    sb.Clear();
                    sb.AppendFormat("UPDATE T_SALES SET ");
                    sb.AppendFormat(" BILLING_FLG =   1 ");
                    sb.AppendFormat(",SYNC_FLG    =  {0}  ", dto.SyncFlf);
                    sb.AppendFormat(",TIME_STAMP  = '{0}' ", dto.TimeStamp);
                    sb.AppendFormat(" WHERE SALES_NO = '{0}' ", row["SALES_NO"].ToString());
                    base.ExecuteAction(sb.ToString(), false);
                }

            }
            catch
            {
                throw;
            }

        }

        #endregion

        #region "請求情報の完了フラグを更新"

        /// <summary>
        /// 請求情報の消込残額がゼロの場合、完了を更新
        /// </summary>
        /// <param name="dto">Req010用のDTO</param>
        private void UpdRequestFinish(dtoReq010 dto)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("UPDATE T_REQUEST SET ");
                sb.AppendFormat(" FINISH_FLG =   1 ");
                sb.AppendFormat(",SYNC_FLG   =  {0} ", dto.SyncFlf);
                sb.AppendFormat(",TIME_STAMP = '{0}' ", dto.TimeStamp);
                sb.AppendFormat(" WHERE DEPOSIT_RECV_AMOUNT = 0 ");
                base.ExecuteAction(sb.ToString(), false);
            }
            catch
            {
                throw;
            }
        }



        #endregion


    }
}
