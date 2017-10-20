using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using Sugitec.Common;


namespace Sugitec.Logics
{
    /// <summary>
    /// frmDep021のサービス
    /// </summary>
    public class srvDep021 : srvBase
    {

        /// <summary>
        /// 指定した入金№の入金情報を取得
        /// </summary>
        /// <param name="RecNo">入金№</param>
        /// <returns></returns>
        public DataTable GetReceipt(string RecNo)
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
                Sql.AppendFormat("   ,DEP_CASH ");
                Sql.AppendFormat("   ,DEP_TRANSFER_FEES ");
                Sql.AppendFormat("   ,DEP_DEPOSIT ");
                Sql.AppendFormat("   ,DEP_BILL ");
                Sql.AppendFormat("   ,DEP_CASH AS ORG_CASH ");
                Sql.AppendFormat("   ,DEP_TRANSFER_FEES AS ORG_TRANSFER_FEES ");
                Sql.AppendFormat("   ,DEP_DEPOSIT AS ORG_DEPOSIT ");
                Sql.AppendFormat("   ,DEP_BILL AS ORG_BILL ");
                Sql.AppendFormat("  FROM T_RECEIPT AS REC ");
                Sql.AppendFormat(" WHERE RECEIPT_NO     = '{0}'", RecNo);

                //選択クエリ
                return base.ExecuteSelect(Sql.ToString());

            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// 入金情報の取得
        /// </summary>
        /// <param name="RecYm">入金年月</param>
        /// <param name="CusCD">得意先コード</param>
        /// <param name="RecNoList">対象外入金№</param>
        /// <returns></returns>
        public DataTable GetReceipt(string RecYm, string CusCD, List<string> RecNoList)
        {
            try
            {
                //対象外入金№を展開
                StringBuilder RecNo = new StringBuilder();
                foreach (string r in RecNoList)
                {
                    RecNo.AppendFormat(",'{0}'", r);
                }

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
                Sql.AppendFormat("   ,DEP_CASH ");
                Sql.AppendFormat("   ,DEP_TRANSFER_FEES ");
                Sql.AppendFormat("   ,DEP_DEPOSIT ");
                Sql.AppendFormat("   ,DEP_BILL ");
                Sql.AppendFormat("  FROM T_RECEIPT AS REC ");
                Sql.AppendFormat(" WHERE CUSTOMER_CD  = '{0}'", CusCD);
                Sql.AppendFormat("   AND RECEIPT_YMD >= '{0}01' ", RecYm);
                Sql.AppendFormat("   AND DEL_FLG      = 0 ");
                Sql.AppendFormat("   AND (DEP_CASH          > 0 ");
                Sql.AppendFormat("    OR  DEP_TRANSFER_FEES > 0 ");
                Sql.AppendFormat("    OR  DEP_DEPOSIT       > 0 ");
                Sql.AppendFormat("    OR  DEP_BILL          > 0)");
                if (RecNo.Length > 0)
                {
                    Sql.AppendFormat("   AND RECEIPT_NO NOT IN ({0}) ", RecNo.Remove(0, 1).ToString());
                }
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
