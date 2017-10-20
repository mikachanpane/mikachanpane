using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sugitec.Common;
using Sugitec.Logics;
using System.Data;

namespace Sugitec.Logics
{
   public class srvRec010:srvBase

    {
        /// <summary>
        /// 明細情報取得（新規）
        /// </summary>
        /// <param name="CusCD">得意先コード</param>
        /// <param name="ReqYm">請求年月</param>
        /// <returns></returns>
        public DataTable SelectRequest(string CusCD, string ReqYm)
        {
            //本体
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("SELECT ");
                sb.AppendFormat("   0  AS SEL ");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.AppendFormat("  ,IIF(DTL.BILLING_YM = '','',FORMAT(CONVERT(DateTime,DTL.BILLING_YM + '01'),'yyyy/MM')) AS BILLING_YM ");
                    sb.AppendFormat("  ,IIF(DTL.TRANSFER_YMD = '','',FORMAT(CONVERT(DateTime,DTL.TRANSFER_YMD),'yyyy/MM/dd')) AS TRANSFER_YMD ");
                    sb.AppendFormat("  ,CONVERT(DECIMAL,0) AS CASH ");
                    sb.AppendFormat("  ,CONVERT(DECIMAL,0) AS BILL ");
                    sb.AppendFormat("  ,CONVERT(DECIMAL,0) AS DEPOSIT ");
                    sb.AppendFormat("  ,CONVERT(DECIMAL,0) AS TRANSFER_FEES ");
                }
                else
                {
                    sb.AppendFormat("  ,FORMAT(DTL.BILLING_YM,'@@@@/@@') AS BILLING_YM ");
                    sb.AppendFormat("  ,FORMAT(DTL.TRANSFER_YMD,'@@@@/@@/@@') AS TRANSFER_YMD ");
                    sb.AppendFormat("  ,CCur(0) AS CASH ");
                    sb.AppendFormat("  ,CCur(0) AS BILL ");
                    sb.AppendFormat("  ,CCur(0) AS DEPOSIT ");
                    sb.AppendFormat("  ,CCur(0) AS TRANSFER_FEES ");
                }
                sb.AppendFormat("  ,DTL.REQUEST_NO ");
                sb.AppendFormat("  ,DTL.REQUEST_SUB_NO ");
                sb.AppendFormat("  ,DTL.BILLING_AMOUNT ");
                sb.AppendFormat("  ,DTL.DISCOUNT ");
                sb.AppendFormat("  ,IIF(DTL.CANCEL = 0, 0, 1) AS CANCEL  ");
                sb.AppendFormat("  ,DTL.DEPOSIT_AMOUNT ");
                sb.AppendFormat("  ,DTL.DEPOSIT_RECV_AMOUNT ");
                sb.AppendFormat("  ,DTL.DIFFERENCE ");
                sb.AppendFormat("  ,DTL.DIFF_REASONS_CD ");
                sb.AppendFormat("  ,'' AS DEPOSIT_NO ");
                sb.AppendFormat("  ,0  AS SEL_OLD ");
                sb.AppendFormat("  FROM T_REQUEST_DTL AS DTL ");
                sb.AppendFormat(" WHERE DTL.CUSTOMER_CD = '{0}'", CusCD);
                sb.AppendFormat("   AND DTL.BILLING_YM >= '{0}' ", ReqYm);
                sb.AppendFormat("   AND DTL.FINISH_FLG = 0 ");
                sb.AppendFormat("   AND DTL.DEL_FLG = 0 ");
                sb.Append("ORDER BY DTL.BILLING_YM,DTL.REQUEST_NO,DTL.REQUEST_SUB_NO");

                DataTable dt = base.ExecuteSelect(sb.ToString());
                dt.PrimaryKey = new DataColumn[] { dt.Columns["REQUEST_NO"], dt.Columns["REQUEST_SUB_NO"] };

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 明細情報取得（修正）
        /// </summary>
        /// <param name="RecNo">入金№</param>
        /// <returns></returns>
        public DataTable SelectRequest(string RecNo)
        {
            //本体
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("SELECT ");
                sb.AppendFormat("   1  AS SEL ");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.AppendFormat("  ,IIF(DTL.BILLING_YM = '','',FORMAT(CONVERT(DateTime,DTL.BILLING_YM + '01'),'yyyy/MM')) AS BILLING_YM ");
                    sb.AppendFormat("  ,IIF(DTL.TRANSFER_YMD = '','',FORMAT(CONVERT(DateTime,DTL.TRANSFER_YMD),'yyyy/MM/dd')) AS TRANSFER_YMD ");
                }
                else
                {
                    sb.AppendFormat("  ,FORMAT(DTL.BILLING_YM,'@@@@/@@') AS BILLING_YM ");
                    sb.AppendFormat("  ,FORMAT(DTL.TRANSFER_YMD,'@@@@/@@/@@') AS TRANSFER_YMD ");
                }
                sb.AppendFormat("  ,DEP.CASH ");
                sb.AppendFormat("  ,DEP.BILL ");
                sb.AppendFormat("  ,DEP.DEPOSIT ");
                sb.AppendFormat("  ,DEP.TRANSFER_FEES ");
                sb.AppendFormat("  ,DTL.REQUEST_NO ");
                sb.AppendFormat("  ,DTL.REQUEST_SUB_NO ");
                sb.AppendFormat("  ,DTL.BILLING_AMOUNT ");
                sb.AppendFormat("  ,DTL.DISCOUNT ");
                sb.AppendFormat("  ,IIF(DTL.CANCEL = 0, 0, 1) AS CANCEL  ");
                sb.AppendFormat("  ,DTL.DEPOSIT_AMOUNT ");
                sb.AppendFormat("  ,(DTL.DEPOSIT_RECV_AMOUNT ");
                sb.AppendFormat("   + DEP.CASH ");
                sb.AppendFormat("   + DEP.BILL ");
                sb.AppendFormat("   + DEP.DEPOSIT ");
                sb.AppendFormat("   + DEP.TRANSFER_FEES ");
                sb.AppendFormat("   + DTL.DISCOUNT ");
                sb.AppendFormat("   + DTL.CANCEL ");
                sb.AppendFormat("   + DTL.DIFFERENCE ");
                sb.AppendFormat("   ) AS DEPOSIT_RECV_AMOUNT ");
                sb.AppendFormat("  ,DTL.DIFFERENCE ");
                sb.AppendFormat("  ,DTL.DIFF_REASONS_CD ");
                sb.AppendFormat("  ,DEP.DEPOSIT_NO ");
                sb.AppendFormat("   ,1  AS SEL_OLD ");
                sb.AppendFormat("  FROM (SELECT * FROM T_DEPOSIT WHERE RECEIPT_NO = '{0}' AND DEL_FLG = 0) AS DEP ", RecNo);
                sb.AppendFormat("  INNER JOIN T_REQUEST_DTL AS DTL ");
                sb.AppendFormat("     ON DEP.REQUEST_NO = DTL.REQUEST_NO ");
                sb.AppendFormat("    AND DEP.REQUEST_SUB_NO = DTL.REQUEST_SUB_NO ");
                sb.Append("ORDER BY DTL.BILLING_YM,DTL.REQUEST_NO,DTL.REQUEST_SUB_NO");

                DataTable dt = base.ExecuteSelect(sb.ToString());
                dt.PrimaryKey = new DataColumn[] { dt.Columns["REQUEST_NO"], dt.Columns["REQUEST_SUB_NO"] };

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 各種データを更新
        /// </summary>
        /// <param name="dto">REC010用DTO</param>
        public void UpdData(dtoRec010 dto)
        {
            try
            {
                //入金情報消込可能額の計算
                CalcDepAmt(ref dto);

                //入金情報の追加、更新
                if (dto.RecNo == "")
                {
                    InsertReceipt(ref dto);
                }
                else
                {
                    UpdateReceipt(dto);
                }

                //入金消込情報の更新
                UpdDeposit(dto);

                List<string> ReqNoList = new List<string>();

                //請求明細情報の更新
                UpdateRequestDtl(dto,ref ReqNoList);

                //請求情報の更新
                UpdateRequest(dto, ReqNoList);

                base.TrnCommit();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///　入金情報INSERT文発行
        /// </summary>
        /// <param name="dto">REC010用DTO</param>
        private void InsertReceipt(ref dtoRec010 dto)
        {

            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO T_RECEIPT VALUES( ");
                dto.RecNo = base.NumberingReceipt(dto.ReciptYMD);
                sb.AppendFormat("'{0}'", dto.RecNo);
                sb.AppendFormat(",'{0}'", dto.CusCd);
                sb.AppendFormat(",'{0}'", dto.ReciptYMD);
                sb.AppendFormat(",{0}", dto.cash);
                sb.AppendFormat(",{0}", dto.bill);
                sb.AppendFormat(",{0}", dto.deposit);
                sb.AppendFormat(",{0}", dto.Fees);
                sb.AppendFormat(",'{0}'", dto.BillYMD);
                sb.AppendFormat(",{0}", dto.DepCash);
                sb.AppendFormat(",{0}", dto.DepBill);
                sb.AppendFormat(",{0}", dto.DepDeposit);
                sb.AppendFormat(",{0}", dto.DepFees);
                sb.Append(",0");
                sb.AppendFormat(",{0}", dto.syncFlf);
                sb.AppendFormat(",'{0}')", dto.TIMESTAMP);
                base.ExecuteAction(sb.ToString(), false);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        ///　入金情報UPDATE文発行
        /// </summary>
        /// <param name="dto">REC010用DTO</param>
        private void UpdateReceipt(dtoRec010 dto)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE T_RECEIPT SET ");
                sb.AppendFormat(" CASH    = {0}", dto.cash);
                sb.AppendFormat(",BILL    = {0}", dto.bill);
                sb.AppendFormat(",DEPOSIT = {0}", dto.deposit);
                sb.AppendFormat(",TRANSFER_FEES = {0}", dto.Fees);
                sb.AppendFormat(",DEP_CASH    = {0}", dto.DepCash);
                sb.AppendFormat(",DEP_BILL    = {0}", dto.DepBill);
                sb.AppendFormat(",DEP_DEPOSIT = {0}", dto.DepDeposit);
                sb.AppendFormat(",DEP_TRANSFER_FEES = {0}", dto.DepFees);
                sb.AppendFormat(",BILL_YMD = '{0}'", dto.BillYMD);
                sb.AppendFormat(",RECEIPT_YMD = '{0}'", dto.ReciptYMD);
                sb.Append(",DEL_FLG = 0");
                sb.AppendFormat(",SYNC_FLG = {0}", dto.syncFlf);
                sb.AppendFormat(",TIME_STAMP ='{0}'", dto.TIMESTAMP);
                sb.AppendFormat(" WHERE RECEIPT_NO = '{0}'", dto.RecNo);
                base.ExecuteAction(sb.ToString(),false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 消込可能額の計算 
        /// </summary>
        /// <param name="dto">REC010用DTO</param>
        private void CalcDepAmt(ref dtoRec010 dto)
        {
            try
            {
                Decimal tlCash = dto.ReqList.Compute("SUM(CASH)", "SEL = 1").ToDecimalEx();
                Decimal tlBill = dto.ReqList.Compute("SUM(BILL)", "SEL = 1").ToDecimalEx();
                Decimal tlDepo = dto.ReqList.Compute("SUM(DEPOSIT)", "SEL = 1").ToDecimalEx();
                Decimal tlTran = dto.ReqList.Compute("SUM(TRANSFER_FEES)", "SEL = 1").ToDecimalEx();

                dto.DepCash = dto.cash - tlCash;
                dto.DepBill = dto.bill - tlBill;
                dto.DepDeposit = dto.deposit - tlTran;
                dto.DepFees = dto.Fees - tlTran;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 入金消込情報の更新
        /// </summary>
        /// <param name="dto">REC010用DTO</param>
        private void UpdDeposit(dtoRec010 dto)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataRow row in dto.ReqList.Rows)
                {

                    sb.Clear();

                    if (row["SEL"].ToString() == "0" && row["SEL_OLD"].ToString() == "0")
                    {
                        continue;
                    }

                    //消込合計額
                    Decimal DepositAmt = row["CASH"].ToDecimalEx() + row["BILL"].ToDecimalEx() + row["DEPOSIT"].ToDecimalEx() + row["TRANSFER_FEES"].ToDecimalEx();

                    if (row["SEL"].ToString() == "1" && row["SEL_OLD"].ToString() == "0" && row["CANCEL"].ToString() == "0")
                    {
                        // 新規（キャンセルを除く）
                        sb.AppendFormat("INSERT INTO T_DEPOSIT VALUES(");
                        sb.AppendFormat(" '{0}'", base.NumberingDeposit());
                        sb.AppendFormat(",'{0}'", dto.RecNo);
                        sb.AppendFormat(",'{0}'", row["REQUEST_NO"].ToString());
                        sb.AppendFormat(",'{0}'", row["REQUEST_SUB_NO"].ToString());
                        sb.AppendFormat(",'{0}'", dto.CusCd);
                        sb.AppendFormat(",'{0}'", dto.ReciptYMD);
                        sb.AppendFormat(", {0} ", row["CASH"].ToDecimalEx());
                        sb.AppendFormat(", {0} ", row["BILL"].ToDecimalEx());
                        sb.AppendFormat(", {0} ", row["DEPOSIT"].ToDecimalEx());
                        sb.AppendFormat(", {0} ", row["TRANSFER_FEES"].ToDecimalEx());
                        sb.AppendFormat(",'{0}'", dto.BillYMD);
                        sb.AppendFormat(", {0} ", DepositAmt);
                        sb.AppendFormat(", {0} ", 0);
                        sb.AppendFormat(", {0} ", dto.syncFlf);
                        sb.AppendFormat(",'{0}'", dto.TIMESTAMP);
                        sb.AppendFormat(")");

                    }
                    else if (row["SEL"].ToString() == "1" && row["SEL_OLD"].ToString() == "1")
                    {
                        // 更新
                        if (row["CANCEL"].ToString() == "0")
                        {
                            //キャンセル以外
                            sb.AppendFormat("UPDATE T_DEPOSIT SET ");
                            sb.AppendFormat(" RECEIPT_YMD    = '{0}'", dto.ReciptYMD);
                            sb.AppendFormat(",CASH           =  {0} ", row["CASH"].ToDecimalEx());
                            sb.AppendFormat(",BILL           =  {0} ", row["BILL"].ToDecimalEx());
                            sb.AppendFormat(",DEPOSIT        =  {0} ", row["DEPOSIT"].ToDecimalEx());
                            sb.AppendFormat(",TRANSFER_FEES  =  {0} ", row["TRANSFER_FEES"].ToDecimalEx());
                            sb.AppendFormat(",BILL_YMD       = '{0}'", dto.BillYMD);
                            sb.AppendFormat(",DEPOSIT_AMOUNT =  {0} ", DepositAmt);
                            sb.AppendFormat(",DEL_FLG        =  {0} ", 0);
                            sb.AppendFormat(",SYNC_FLG       =  {0} ", dto.syncFlf);
                            sb.AppendFormat(",TIME_STAMP     = '{0}'", dto.TIMESTAMP);
                            sb.AppendFormat(" WHERE DEPOSIT_NO = '{0}'", row["DEPOSIT_NO"].ToString());
                        }
                        else
                        {
                            //キャンセル
                            sb.Clear();
                            sb.AppendFormat("UPDATE T_DEPOSIT SET ");
                            sb.AppendFormat(" DEL_FLG    =  {0} ", 1);
                            sb.AppendFormat(",SYNC_FLG   =  {0} ", dto.syncFlf);
                            sb.AppendFormat(",TIME_STAMP = '{0}'", dto.TIMESTAMP);
                            sb.AppendFormat(" WHERE DEPOSIT_NO = '{0}'", row["DEPOSIT_NO"].ToString());
                        }

                    }
                    else if (row["SEL"].ToString() == "0" && row["SEL_OLD"].ToString() == "1")
                    {
                        // 取消
                        sb.AppendFormat("UPDATE T_DEPOSIT SET ");
                        sb.AppendFormat(" DEL_FLG    =  {0} ", 1);
                        sb.AppendFormat(",SYNC_FLG   =  {0} ", dto.syncFlf);
                        sb.AppendFormat(",TIME_STAMP = '{0}'", dto.TIMESTAMP);
                        sb.AppendFormat(" WHERE DEPOSIT_NO = '{0}'", row["DEPOSIT_NO"].ToString());
                    }

                    if (!string.IsNullOrEmpty(sb.ToString()))
                    {
                        base.ExecuteAction(sb.ToString(), false);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }



        }
        
        /// <summary>
        ///　請求明細情報UPDATE文発行
        /// </summary>
        /// <param name="dto">REC010用DTO</param>
        /// <param name="ReqNoList">請求№一覧</param>
        private void UpdateRequestDtl(dtoRec010 dto,ref List<string> ReqNoList)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataRow row in dto.ReqList.Rows)
                {
                    if (row["SEL"].ToString()=="0" && row["SEL_OLD"].ToString() == "0")
                    {
                        continue;
                    }
                    else
                    {
                        //入金消込情報の対象請求明細の集計を取得
                        sb.Clear();
                        sb.AppendFormat(" SELECT ");
                        sb.AppendFormat("     REQUEST_NO ");
                        sb.AppendFormat("    ,REQUEST_SUB_NO ");
                        sb.AppendFormat("    ,SUM(CASH)          AS sumCASH ");
                        sb.AppendFormat("    ,SUM(BILL)          AS sumBILL ");
                        sb.AppendFormat("    ,SUM(DEPOSIT)       AS sumDEPOSIT ");
                        sb.AppendFormat("    ,SUM(TRANSFER_FEES) AS sumTRANSFER_FEES ");
                        sb.AppendFormat("   FROM T_DEPOSIT ");
                        sb.AppendFormat(" WHERE REQUEST_NO     = '{0}' ", row["REQUEST_NO"].ToString());
                        sb.AppendFormat("   AND REQUEST_SUB_NO = '{0}' ", row["REQUEST_SUB_NO"].ToString());
                        sb.AppendFormat("   AND DEL_FLG        =   0 ");
                        sb.AppendFormat("  GROUP BY REQUEST_NO, REQUEST_SUB_NO");
                        DataTable dt = base.ExecuteSelect(sb.ToString());

                        Decimal sumCASH = 0;
                        Decimal sumBILL = 0;
                        Decimal sumDEPOSIT = 0;
                        Decimal sumTRANSFER_FEES = 0;
                        Decimal CanselAmt = row["CANCEL"].ToString() == "0" ? 0 : row["BILLING_AMOUNT"].ToDecimalEx();

                        if (dt.Rows.Count > 0)
                        {
                            sumCASH = dt.Rows[0]["sumCASH"].ToDecimalEx();
                            sumBILL = dt.Rows[0]["sumBILL"].ToDecimalEx();
                            sumDEPOSIT = dt.Rows[0]["sumDEPOSIT"].ToDecimalEx();
                            sumTRANSFER_FEES = dt.Rows[0]["sumTRANSFER_FEES"].ToDecimalEx();
                        }
                        //消込額
                        Decimal DepositAmt = sumCASH + sumBILL + sumDEPOSIT+ sumTRANSFER_FEES
                                           + row["DIFFERENCE"].ToDecimalEx()
                                           + row["DISCOUNT"].ToDecimalEx()
                                           + CanselAmt;
                        //消込残額
                        Decimal DepositRecvAmt = row["BILLING_AMOUNT"].ToDecimalEx() - DepositAmt;
                        //完了フラグ
                        int FinishFlg = 1;
                        if (DepositRecvAmt > 0)
                        {
                            FinishFlg = 0;
                        }

                        //請求明細情報の回収状況を更新
                        sb.Clear();
                        sb.Append("UPDATE T_REQUEST_DTL SET ");
                        sb.AppendFormat(" CASH            = {0}  ", sumCASH);
                        sb.AppendFormat(",BILL            = {0}  ", sumBILL);
                        sb.AppendFormat(",DEPOSIT         = {0}  ", sumDEPOSIT);
                        sb.AppendFormat(",TRANSFER_FEES   = {0}  ", sumTRANSFER_FEES);
                        sb.AppendFormat(",DISCOUNT        = {0}  ", row["DISCOUNT"].ToDecimalEx());
                        sb.AppendFormat(",CANCEL          = {0}  ", CanselAmt);
                        sb.AppendFormat(",DIFFERENCE      = {0}  ", row["DIFFERENCE"].ToDecimalEx());
                        sb.AppendFormat(",DIFF_REASONS_CD ='{0}' ", row["DIFF_REASONS_CD"].ToString());
                        sb.AppendFormat(",DEPOSIT_AMOUNT  = {0}  ", DepositAmt);
                        sb.AppendFormat(",DEPOSIT_RECV_AMOUNT = {0} ", DepositRecvAmt);
                        sb.AppendFormat(",FINISH_FLG      = {0}  ", FinishFlg);
                        sb.AppendFormat(",DEL_FLG         =  0   ");
                        sb.AppendFormat(",SYNC_FLG        = {0}  ", dto.syncFlf);
                        sb.AppendFormat(",TIME_STAMP      ='{0}' ", dto.TIMESTAMP);
                        sb.AppendFormat(" WHERE REQUEST_NO     = '{0}' ", row["REQUEST_NO"].ToString());
                        sb.AppendFormat("   AND REQUEST_SUB_NO = '{0}' ", row["REQUEST_SUB_NO"].ToString());
                        base.ExecuteAction(sb.ToString(),false);

                        if (!ReqNoList.Contains(row["REQUEST_NO"].ToString()))
                        {
                            ReqNoList.Add(row["REQUEST_NO"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///　請求情報UPDATE文発行
        /// </summary>
        /// <param name="dto">REC010用DTO</param>
        /// <param name="ReqNoList">請求№一覧</param>
        private void UpdateRequest(dtoRec010 dto, List<string> ReqNoList)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (string ReqNo in ReqNoList)
                {
                    sb.Clear();
                    sb.AppendFormat(" SELECT ");
                    sb.AppendFormat("     REQUEST_NO ");
                    sb.AppendFormat("    ,SUM(BILLING_AMOUNT) AS sumBILLING_AMOUNT ");
                    sb.AppendFormat("    ,SUM(CASH)           AS sumCASH ");
                    sb.AppendFormat("    ,SUM(BILL)           AS sumBILL ");
                    sb.AppendFormat("    ,SUM(DEPOSIT)        AS sumDEPOSIT ");
                    sb.AppendFormat("    ,SUM(TRANSFER_FEES)  AS sumTRANSFER_FEES ");
                    sb.AppendFormat("    ,SUM(DISCOUNT)       AS sumDISCOUNT ");
                    sb.AppendFormat("    ,SUM(CANCEL)         AS sumCANCEL ");
                    sb.AppendFormat("    ,SUM(DIFFERENCE)     AS sumDIFFERENCE ");
                    sb.AppendFormat("   FROM T_REQUEST_DTL ");
                    sb.AppendFormat("  WHERE REQUEST_NO = '{0}' ", ReqNo);
                    sb.AppendFormat("    AND DEL_FLG    =   0 ");
                    sb.AppendFormat("  GROUP BY REQUEST_NO ");
                    DataTable dt = base.ExecuteSelect(sb.ToString());

                    //消込額
                    Decimal DepositAmt = dt.Rows[0]["sumCASH"].ToDecimalEx()
                                       + dt.Rows[0]["sumBILL"].ToDecimalEx()
                                       + dt.Rows[0]["sumDEPOSIT"].ToDecimalEx()
                                       + dt.Rows[0]["sumTRANSFER_FEES"].ToDecimalEx()
                                       + dt.Rows[0]["sumDISCOUNT"].ToDecimalEx()
                                       + dt.Rows[0]["sumDIFFERENCE"].ToDecimalEx()
                                       + dt.Rows[0]["sumCANCEL"].ToDecimalEx();
                    //消込残額
                    Decimal DepositRecvAmt = dt.Rows[0]["sumBILLING_AMOUNT"].ToDecimalEx() - DepositAmt;
                    //完了フラグ
                    int FinishFlg = 1;
                    if (DepositRecvAmt > 0)
                    {
                        FinishFlg = 0;
                    }

                    sb.Clear();
                    sb.Append("UPDATE T_REQUEST SET ");
                    sb.AppendFormat(" CASH                = {0}  ", dt.Rows[0]["sumCASH"].ToDecimalEx());
                    sb.AppendFormat(",BILL                = {0}  ", dt.Rows[0]["sumBILL"].ToDecimalEx());
                    sb.AppendFormat(",DEPOSIT             = {0}  ", dt.Rows[0]["sumDEPOSIT"].ToDecimalEx());
                    sb.AppendFormat(",TRANSFER_FEES       = {0}  ", dt.Rows[0]["sumTRANSFER_FEES"].ToDecimalEx());
                    sb.AppendFormat(",DISCOUNT            = {0}  ", dt.Rows[0]["sumDISCOUNT"].ToDecimalEx());
                    sb.AppendFormat(",CANCEL              = {0}  ", dt.Rows[0]["sumCANCEL"].ToDecimalEx());
                    sb.AppendFormat(",DEPOSIT_AMOUNT      = {0}  ", DepositAmt);
                    sb.AppendFormat(",DEPOSIT_RECV_AMOUNT = {0}  ", DepositRecvAmt);
                    sb.AppendFormat(",DIFFERENCE          = {0}  ", dt.Rows[0]["sumDIFFERENCE"].ToDecimalEx());
                    sb.AppendFormat(",FINISH_FLG          = {0}  ", FinishFlg);
                    sb.AppendFormat(",SYNC_FLG            = {0}  ", dto.syncFlf);
                    sb.AppendFormat(",TIME_STAMP          ='{0}' ", dto.TIMESTAMP);
                    sb.AppendFormat(" WHERE REQUEST_NO = '{0}' ", ReqNo);
                    base.ExecuteAction(sb.ToString(), false);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 入金情報取得
        /// </summary>
        /// <param name="RecNo">入金№</param>
        public DataTable SelectReceipt(string RecNo)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat(" SELECT ");
                sb.AppendFormat("     RECEIPT_NO ");
                sb.AppendFormat("    ,CUSTOMER_CD ");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.AppendFormat("    ,IIF(RECEIPT_YMD = '','',FORMAT(CONVERT(DateTime,RECEIPT_YMD), 'yyyy/MM/dd')) AS RECEIPT_YMD ");
                    sb.AppendFormat("    ,IIF(BILL_YMD = '','',FORMAT(CONVERT(DateTime,BILL_YMD), 'yyyy/MM/dd')) AS BILL_YMD ");
                }
                else
                {
                    sb.AppendFormat("    ,FORMAT(RECEIPT_YMD, '@@@@/@@/@@') AS RECEIPT_YMD ");
                    sb.AppendFormat("    ,FORMAT(BILL_YMD, '@@@@/@@/@@') AS BILL_YMD ");
                }
                sb.AppendFormat("    ,CASH ");
                sb.AppendFormat("    ,BILL ");
                sb.AppendFormat("    ,DEPOSIT ");
                sb.AppendFormat("    ,TRANSFER_FEES ");
                sb.AppendFormat("    ,DEP_CASH ");
                sb.AppendFormat("    ,DEP_BILL ");
                sb.AppendFormat("    ,DEP_DEPOSIT ");
                sb.AppendFormat("    ,DEP_TRANSFER_FEES ");
                sb.AppendFormat("   FROM T_RECEIPT ");
                sb.AppendFormat("  WHERE RECEIPT_NO  = '{0}'", RecNo);
                return base.ExecuteSelect(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///　得意先Select文発行処理
        /// </summary>
        /// <returns>得意先マスタ抽出結果</returns>
        public DataTable SelectCus(FEATURES FCD)
        {
            //本体
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append("SELECT REC.CUSTOMER_CD,CUS.NAME FROM T_REQUEST_DTL REC ");
                sb.Append(" INNER JOIN M_CUSTOMER CUS ON REC.CUSTOMER_CD = CUS.CODE ");
                sb.Append(" WHERE REC.DEL_FLG = 0 ");
                if(FCD == FEATURES.REC010)
                {
                    sb.Append("   AND REC.FINISH_FLG = 0 ");
                }
                sb.Append(" GROUP BY REC.CUSTOMER_CD,CUS.NAME ORDER BY REC.CUSTOMER_CD");

                return base.ExecuteSelect(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        ///　差異理由Select文発行処理
        /// </summary>
        /// <returns>コード区分マスタ（差異理由）抽出結果</returns>
        public DataTable SelectDiffCd()
        {
            //本体
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append("SELECT CODE,CONTENT FROM M_CODE ");
                sb.Append(" WHERE KBN = 'D01' AND CODE <> '00' ");
                sb.Append(" AND DEL_FLG = 0 ");
                return base.ExecuteSelect(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }









    }
}
