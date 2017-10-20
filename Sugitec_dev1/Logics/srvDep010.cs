using System;
using System.Text;
using System.Data;

using Sugitec.Common;


namespace Sugitec.Logics
{
    /// <summary>
    /// frmDep010のサービス
    /// </summary>
    public class srvDep010 : srvBase
    {
        /// <summary>
        /// 回収対象一覧をDBから取得します
        /// </summary>
        /// <param name="dto">dtoDep010</param>
        /// <returns>dgv_result.DataSource</returns>
        public DataTable SelectGridView(dtoDep010 dto)
        {
            //SQL構築
            StringBuilder Sql = new StringBuilder();

            Sql.Append(" SELECT");
            Sql.Append("                 REQD.REQUEST_NO AS[請求№] ");
            Sql.Append("               , REQD.REQUEST_SUB_NO AS 枝番 ");
            Sql.Append("               , ENG.NAME AS 技術者名 ");
            if (clsDefine.OperatingStatus == OperatStatus.OFFLINE)
            {
                Sql.Append("               , FORMAT(REQD.TRANSFER_YMD, '@@@@/@@/@@') AS 振込指定日 ");
            }
            else
            {
                Sql.Append("            , IIF(REQD.TRANSFER_YMD = '', '', FORMAT(CONVERT(DateTime, REQD.TRANSFER_YMD), 'yyyy/MM/dd')) As 振込指定日 ");
            }
            Sql.Append("               , REQD.BILLING_AMOUNT AS 請求金額 ");
            Sql.Append("               , REQD.DEPOSIT_AMOUNT AS 回収金額 ");
            Sql.Append("               , REQD.DEPOSIT_RECV_AMOUNT AS 回収残高 ");
            Sql.Append("               , REQD.[DIFFERENCE] AS 差額 ");
            Sql.Append("               , COD.CONTENT AS 差額理由");
            Sql.Append("               , REQD.DISCOUNT AS 値引 ");
            Sql.Append("               , IIF(REQD.CANCEL > 0, 1, 0) AS キャンセル ");
            Sql.Append(" FROM          (( T_REQUEST_DTL REQD ");
            Sql.Append(" LEFT JOIN     M_ENGINEER ENG ON REQD.ENGINEER_ID = ENG.ID) ");
            Sql.Append(" LEFT JOIN     M_CODE COD ON(REQD.DIFF_REASONS_CD = COD.CODE AND COD.KBN = 'D01') ) ");

            //削除フラグ
            Sql.AppendFormat(" WHERE   REQD.DEL_FLG = {0}", dto.DelFlg);
            //請求年月
            if (!string.IsNullOrEmpty(dto.ReqYm))
            {
                Sql.AppendFormat(" AND REQD.BILLING_YM = '{0}'", dto.ReqYm);
            }
            //得意先コード
            if (!string.IsNullOrEmpty(dto.CusCode))
            {
                Sql.AppendFormat(" AND REQD.CUSTOMER_CD = '{0}'", dto.CusCode);
            }
            //完了フラグ
            if (!string.IsNullOrEmpty(dto.FinishFlg))
            {
                Sql.AppendFormat(" AND REQD.FINISH_FLG = {0}", dto.FinishFlg);
            }

            //選択クエリ
            return base.ExecuteSelect(Sql.ToString());
        }

        /// <summary>
        /// コンボボックスのための得意先Mのコードと名称を全て取得します
        /// </summary>
        /// <returns>M_CUSTOMER.CODE、M_CUSTOMER.NAME</returns>
        public DataTable SelectComboBox()
        {
            //SQL構築
            StringBuilder Sql = new StringBuilder();

            Sql.Append("SELECT ");
            Sql.Append("    CODE ");
            Sql.Append("   ,NAME ");
            Sql.Append("  FROM M_CUSTOMER AS CUS ");
            Sql.Append(" WHERE EXISTS( ");
            Sql.Append("       SELECT 'x' FROM T_REQUEST_DTL AS DTL ");
            Sql.Append("        WHERE DTL.CUSTOMER_CD = CUS.CODE) ");

            //選択クエリ
            return base.ExecuteSelect(Sql.ToString());
        }
    }
}
