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

        /// <summary>
        /// コード区分Ｍの取得
        /// </summary>
        /// <param name="kbn">カテゴリ区分</param>
        /// <returns>内容</returns>
        public DataTable GetCodeM(string kbn)
        {
            //SQL構築
            StringBuilder Sql = new StringBuilder();

            Sql.AppendFormat("SELECT ");
            Sql.AppendFormat("    CODE ");
            Sql.AppendFormat("   ,CONTENT ");
            Sql.AppendFormat("  FROM M_CODE AS COD ");
            Sql.AppendFormat(" WHERE KBN  = '{0}' ", kbn);
            Sql.AppendFormat("   AND CODE <> '00' ");
            Sql.AppendFormat(" ORDER BY  CODE ");

            //選択クエリ
            return base.ExecuteSelect(Sql.ToString());
        }

        /// <summary>
        /// 画面表示用データを取得
        /// </summary>
        /// <param name="ReqNo">請求№</param>
        /// <param name="ReqSubNo">枝番</param>
        /// <returns></returns>
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

                // 請求№
                dto.REQUEST_NO = ReqNo;
                // 枝番
                dto.REQUEST_SUB_NO = ReqSubNo;
                // 請求年月
                dto.BILLING_YM = DrReq["BILLING_YM"].ToString();
                // 振込指定日
                dto.TRANSFER_YMD = DrReq["TRANSFER_YMD"].ToString();
                // 得意先コード
                dto.CUSCD = DrReq["CUSTOMER_CD"].ToString();
                // 得意先名
                dto.CUSNAME = DrReq["CUSNAME"].ToString();
                // 技術者名
                dto.ENGNAME = DrReq["ENGNAME"].ToString();
                // 請求金額
                dto.BILLING_AMOUNT = DrReq["BILLING_AMOUNT"].ToDecimalEx();
                // 回収残高
                dto.DEPOSIT_RECV_AMOUNT = DrReq["DEPOSIT_RECV_AMOUNT"].ToDecimalEx();
                // 現金
                dto.CASH = DrReq["CASH"].ToDecimalEx();
                // 手数料
                dto.TRANSFER_FEES = DrReq["TRANSFER_FEES"].ToDecimalEx();
                // 預金
                dto.DEPOSIT = DrReq["DEPOSIT"].ToDecimalEx();
                // 手形
                dto.BILL = DrReq["BILL"].ToDecimalEx();
                // 差額
                dto.DIFFERENCE = DrReq["DIFFERENCE"].ToDecimalEx();
                // 差額理由
                dto.DIFF_REASONS_CD = DrReq["DIFF_REASONS_CD"].ToString();
                // 値引き
                dto.DISCOUNT = DrReq["DISCOUNT"].ToDecimalEx();
                // キャンセル
                dto.CANCEL = DrReq["CANCEL"].ToDecimalEx() > 0 ? true :  false;
                // 回収一覧
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
                Sql.Append("   ,DTL.CUSTOMER_CD ");
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
                Sql.AppendFormat("   ,CASH AS ORG_CASH ");
                Sql.AppendFormat("   ,TRANSFER_FEES AS ORG_TRANSFER_FEES ");
                Sql.AppendFormat("   ,DEPOSIT AS ORG_DEPOSIT ");
                Sql.AppendFormat("   ,BILL AS ORG_BILL ");
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

        public void Cancela()
        {


        }


    }
}
