using System;
using System.Text;
using System.Data;

using Sugitec.Common;


namespace Sugitec.Logics
{
    /// <summary>
    /// frmDep020のサービス
    /// </summary>
    public class srvDep020 : srvBase
    {

        public dtoDep020 GetDep020Data(string ReqNo, string ReqSubNo)
        {
            try
            {

                
                //請求明細情報の取得
                DataTable DtReq = GetRequestDtl(ReqNo, ReqSubNo);
                DataRow DrReq = DtReq.Rows[0];

                //入金消込情報の取得
                DataTable DtDep = GetDeposit(ReqNo, ReqSubNo);

                //リターン用のDTOを作成
                dtoDep020 dto = new dtoDep020();

                /// <summary> 請求№ </summary>
                dto.REQUEST_NO = ReqNo;
                /// <summary> 枝番 </summary>
                dto.REQUEST_SUB_NO = ReqSubNo;
                /// <summary> 請求年月 </summary>
                dto.BILLING_YM = DrReq["BILLING_YM"].ToString();
                /// <summary> 振込指定日 </summary>
                dto.TRANSFER_YMD = DrReq["TRANSFER_YMD"].ToString();
                /// <summary> 得意先名 </summary>
                dto.CUSNAME = DrReq["CUSNAME"].ToString();
                /// <summary> 技術者名 </summary>
                dto.ENGNAME = DrReq["ENGNAME"].ToString();
                /// <summary> 請求金額 </summary>
                dto.BILLING_AMOUNT = DrReq["BILLING_AMOUNT"].ToDecimalEx();
                /// <summary> 回収残高 </summary>
                dto.DEPOSIT_RECV_AMOUNT = DrReq["DEPOSIT_RECV_AMOUNT"].ToDecimalEx();
                /// <summary> 現金 </summary>
                dto.CASH = DrReq["CASH"].ToDecimalEx();
                /// <summary> 手数料 </summary>
                dto.TRANSFER_FEES = DrReq["TRANSFER_FEES"].ToDecimalEx();
                /// <summary> 預金 </summary>
                dto.DEPOSIT = DrReq["DEPOSIT"].ToDecimalEx();
                /// <summary> 手形 </summary>
                dto.BILL = DrReq["BILL"].ToDecimalEx();
                /// <summary> 差額 </summary>
                dto.DIFFERENCE = DrReq["DIFFERENCE"].ToDecimalEx();
                /// <summary> 差額理由 </summary>
                dto.DIFF_REASONS_CD = DrReq["DIFF_REASONS_CD"].ToString();
                /// <summary> 値引き </summary>
                dto.DISCOUNT = DrReq["DISCOUNT"].ToDecimalEx();
                /// <summary> キャンセル </summary>
                dto.CANCEL = DrReq["CANCEL"].ToDecimalEx() > 0 ? true :  false;
                /// <summary> 回収一覧 </summary>
                dto.DEPOSIT_LIST = DtDep;

                return dto;

            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// 請求明細情報の取得
        /// </summary>
        /// <param name="ReqNo"></param>
        /// <param name="ReqSubNo"></param>
        /// <returns></returns>
        private DataTable GetRequestDtl(string ReqNo, string ReqSubNo)
        {
            try
            {
                //SQL構築
                StringBuilder Sql = new StringBuilder();

                Sql.Append("SELECT");
                Sql.Append("    REQUEST_NO");
                Sql.Append("   ,REQUEST_SUB_NO");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    Sql.Append("   ,IIF(DTL.BILLING_YM = '','',FORMAT(CONVERT(DateTime,DTL.BILLING_YM + '01'), 'yyyy/MM')) AS BILLING_YM ");
                    Sql.Append("   ,IIF(DTL.TRANSFER_YMD = '','',FORMAT(CONVERT(DateTime,DTL.TRANSFER_YMD), 'yyyy/MM/dd')) AS TRANSFER_YMD ");
                }
                else
                {
                    Sql.Append("   ,FORMAT(DTL.BILLING_YM, '@@@@/@@')      AS BILLING_YM ");
                    Sql.Append("   ,FORMAT(DTL.TRANSFER_YMD, '@@@@/@@/@@') AS TRANSFER_YMD ");
                }
                Sql.Append("   ,CUS.NAME AS CUSNAME ");
                Sql.Append("   ,ENG.NAME AS ENGNAME ");
                Sql.Append("   ,DTL.BILLING_AMOUNT ");
                Sql.Append("   ,DTL.DEPOSIT_RECV_AMOUNT ");
                Sql.Append("   ,DTL.CASH ");
                Sql.Append("   ,DTL.TRANSFER_FEES ");
                Sql.Append("   ,DTL.DEPOSIT ");
                Sql.Append("   ,DTL.BILL ");
                Sql.Append("   ,DTL.DIFFERENCE ");
                Sql.Append("   ,DTL.DIFF_REASONS_CD ");
                Sql.Append("   ,DTL.DISCOUNT ");
                Sql.Append("   ,DTL.CANCEL ");
                Sql.Append("  FROM  ((T_REQUEST_DTL AS DTL LEFT JOIN M_ENGINEER AS ENG ");
                Sql.Append("    ON  DTL.ENGINEER_ID = ENG.ID) LEFT JOIN M_CUSTOMER AS CUS ");
                Sql.Append("    ON  DTL.CUSTOMER_CD = CUS.CODE) ");
                Sql.AppendFormat(" WHERE  DTL.REQUEST_NO     = '{0}'", ReqNo);
                Sql.AppendFormat("   AND  DTL.REQUEST_SUB_NO = '{0}'", ReqSubNo);

                //選択クエリ
                return base.ExecuteSelect(Sql.ToString());

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        /// <summary>
        /// 入金消込情報の取得
        /// </summary>
        /// <param name="ReqNo"></param>
        /// <param name="ReqSubNo"></param>
        /// <returns></returns>
        private DataTable GetDeposit(string ReqNo, string ReqSubNo)
        {
            try
            {
                //SQL構築
                StringBuilder Sql = new StringBuilder();

                Sql.AppendFormat("SELECT");
                Sql.AppendFormat("    RECEIPT_NO ");

                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    Sql.Append("   ,IIF(RECEIPT_YMD = '','',FORMAT(CONVERT(DateTime,RECEIPT_YMD), 'yyyy/MM/dd')) AS RECEIPT_YMD ");
                }
                else
                {
                    Sql.Append("   ,FORMAT(RECEIPT_YMD, '@@@@/@@/@@') AS RECEIPT_YMD ");
                }
                Sql.AppendFormat("   ,CASH ");
                Sql.AppendFormat("   ,TRANSFER_FEES ");
                Sql.AppendFormat("   ,DEPOSIT ");
                Sql.AppendFormat("   ,BILL ");
                Sql.AppendFormat("   ,DEPOSIT_NO ");
                Sql.AppendFormat("   ,0 AS DEL ");
                Sql.AppendFormat("  FROM T_DEPOSIT AS DEP ");
                Sql.AppendFormat(" WHERE REQUEST_NO     = '{0}'", ReqNo);
                Sql.AppendFormat("   AND REQUEST_SUB_NO = '{0}'", ReqSubNo);
                Sql.AppendFormat("   AND DEL_FLG        =   0 ");
                Sql.AppendFormat(" ORDER BY RECEIPT_NO ");

                //選択クエリ
                return base.ExecuteSelect(Sql.ToString());

            }
            catch (Exception)
            {

                throw;
            }

        }



    }
}
