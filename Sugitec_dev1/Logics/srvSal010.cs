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
   public class srvSal010:srvBase
    {

        /// <summary>
        /// 受注データの取得
        /// </summary>
        /// <param name="OrderNo">受注№</param>
        /// <returns>取得したDataTable</returns>
        public DataTable SelectOrder(string OrderNo)
        {
            //本体
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //条件
            System.Text.StringBuilder sb2 = new System.Text.StringBuilder();
            try
            {
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.Append("SELECT ORD.*, CUS.NAME AS CUSNAME, ENG.NAME AS ENGNAME, COD.CONTENT, IIF(ORD.ORDER_YMD = '','',FORMAT(CONVERT(DateTime,ORD.ORDER_YMD), 'yyyy/MM/dd')) AS ORD_YMD ");
                    sb.Append(",IIF(ORD.START_YMD = '','',FORMAT(CONVERT(DateTime,ORD.START_YMD), 'yyyy/MM/dd')) AS ORDSTART_YMD,IIF(ORD.END_YMD = '','',FORMAT(CONVERT(DateTime,ORD.END_YMD), 'yyyy/MM/dd')) AS ORDEND_YMD ");
                }
                else
                {
                    sb.Append("SELECT ORD.*, CUS.NAME AS CUSNAME, ENG.NAME AS ENGNAME, COD.CONTENT, FORMAT(ORD.ORDER_YMD, '@@@@/@@/@@') AS ORD_YMD ");
                    sb.Append(",FORMAT(ORD.START_YMD, '@@@@/@@/@@') AS ORDSTART_YMD,FORMAT(ORD.END_YMD, '@@@@/@@/@@') AS ORDEND_YMD ");
                }                   
                sb.Append("FROM(((T_ORDER ORD LEFT OUTER JOIN ");
                sb.Append("M_CUSTOMER CUS ON ORD.CUSTOMER_CD = CUS.CODE) LEFT OUTER JOIN ");
                sb.Append("M_ENGINEER ENG ON ORD.ENGINEER_ID = ENG.ID) LEFT OUTER JOIN ");
                sb.Append("(SELECT KBN, CODE, CONTENT, DEL_FLG, SYNC_FLG, TIME_STAMP ");
                sb.Append("FROM M_CODE ");
                sb.Append("WHERE(KBN = 'B10')) COD ON ORD.ACTUARIAL_KBN = COD.CODE) ");

                sb2.AppendFormat(" ORD.ORDER_NO = '{0}'",OrderNo);

                sb2.AppendFormat(" AND ORD.DEL_FLG = 0 ");

                sb.Append(" WHERE ").Append(sb2.ToString());

                return base.ExecuteSelect(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 受注データの取得
        /// </summary>
        /// <param name="SalesYM">売上年月</param>
        /// <param name="EngID">技術者ＩＤ</param>
        /// <param name="OrderNo">受注№</param>
        /// <returns>取得したDataTable</returns>
        public DataTable SelectCalc(String SalesYM,String EngID,String OrderNo)
        {

            //本体
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //条件
            System.Text.StringBuilder sb2 = new System.Text.StringBuilder();
            try
            {
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.Append("SELECT ORD.*, CUS.NAME AS CUSNAME, ENG.NAME AS ENGNAME, COD.CONTENT, IIF(ORD.ORDER_YMD = '','',FORMAT(CONVERT(DateTime,ORD.ORDER_YMD), 'yyyy/MM/dd')) AS ORD_YMD ");
                    sb.Append(",IIF(ORD.START_YMD = '','',FORMAT(CONVERT(DateTime,ORD.START_YMD), 'yyyy/MM/dd')) AS ORDSTART_YMD,IIF(ORD.END_YMD = '','',FORMAT(CONVERT(DateTime,ORD.END_YMD), 'yyyy/MM/dd')) AS ORDEND_YMD ");
                }
                else
                {
                    sb.Append("SELECT ORD.*, CUS.NAME AS CUSNAME, ENG.NAME AS ENGNAME, COD.CONTENT, FORMAT(ORD.ORDER_YMD, '@@@@/@@/@@') AS ORD_YMD ");
                    sb.Append(",FORMAT(ORD.START_YMD, '@@@@/@@/@@') AS ORDSTART_YMD,FORMAT(ORD.END_YMD, '@@@@/@@/@@') AS ORDEND_YMD ");
                }
                sb.Append("FROM(((T_ORDER ORD LEFT OUTER JOIN ");
                sb.Append("M_CUSTOMER CUS ON ORD.CUSTOMER_CD = CUS.CODE) LEFT OUTER JOIN ");
                sb.Append("M_ENGINEER ENG ON ORD.ENGINEER_ID = ENG.ID) LEFT OUTER JOIN ");
                sb.Append("(SELECT KBN, CODE, CONTENT, DEL_FLG, SYNC_FLG, TIME_STAMP ");
                sb.Append("FROM M_CODE ");
                sb.Append("WHERE(KBN = 'B10')) COD ON ORD.ACTUARIAL_KBN = COD.CODE) ");
                
                if(clsDefine.OperatingStatus == OperatStatus.OFFLINE)
                {
                    sb2.AppendFormat("'{0}' BETWEEN MID(ORD.START_YMD,1,6) AND MID(ORD.END_YMD,1,6) ", SalesYM);
                }
                else
                {
                    sb2.AppendFormat("'{0}' BETWEEN SUBSTRING(ORD.START_YMD,1,6) AND SUBSTRING(ORD.END_YMD,1,6) ", SalesYM);
                }
                
                if(OrderNo != "")
                {
                    sb2.AppendFormat(" AND ORD.ORDER_NO = '{0}' ", OrderNo);
                }
                else
                {
                    sb2.AppendFormat(" AND ORD.ENGINEER_ID = '{0}' ", EngID);
                }

                sb2.AppendFormat(" AND ORD.DEL_FLG = 0 ");

                sb.Append(" WHERE ").Append(sb2.ToString());

                return base.ExecuteSelect(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 税率取得Select文発行処理
        /// </summary>
        /// <param name="YMD">適用日</param>
        /// <returns>消費税率</returns>
        public Decimal SelectTAX(String YMD)
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            try
            {
                if (YMD.Length == 6)
                {
                    YMD = YMD + "01";
                }

                sb.AppendFormat("SELECT TAX_RATE FROM M_TAX ");
                sb.AppendFormat(" WHERE START_YMD <= '{0}' ",YMD);
                sb.AppendFormat(" ORDER BY START_YMD DESC ");
                DataTable dt =  base.ExecuteSelect(sb.ToString());

                if(dt.Rows.Count==0)
                {
                    return 8;
                } 
                else
                {
                    return dt.Rows[0]["TAX_RATE"].ToDecimalEx();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 技術者取得Select文発行処理
        /// </summary>
        /// <param name="dto">Sal010用dto</param>
        /// <returns></returns>
        public DataTable SelectEng(string EngId)
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            try
            {
                sb.AppendFormat("Select NAME FROM M_ENGINEER WHERE ID = '{0}' AND DEL_FLG = 0 ", EngId);

                return base.ExecuteSelect(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 売上取得Select文発行処理
        /// </summary>
        /// <param name="dto">Sal010用dto</param>
        /// <returns></returns>
        public DataTable SelectSale(String SalesNo)
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            try
            {
                sb.Append("Select ");
                sb.Append("    SALES_NO ");
                sb.Append("   ,ORDER_NO ");
                sb.Append("   ,SALES_YM ");
                sb.Append("   ,OPERATION_TIME ");
                sb.Append("   ,ENGINEER_ID ");
                sb.Append("   ,BASE_AMOUNT ");
                sb.Append("   ,ORVER_AMOUNT ");
                sb.Append("   ,OVER_TIME ");
                sb.Append("   ,LACK_TIME ");
                sb.Append("   ,TAX_RATE ");
                sb.Append("   ,TAX_AMOUNT ");
                sb.Append("   ,SUBTRACT_AMOUNT ");
                sb.Append("   ,SALES_AMOUNT ");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.Append("   ,IIF(SALES.START_YMD = '','',FORMAT(CONVERT(DateTime,SALES.START_YMD), 'yyyy/MM/dd')) AS SALES_START_YMD ");
                    sb.Append("   ,IIF(SALES.END_YMD = '','',FORMAT(CONVERT(DateTime,SALES.END_YMD), 'yyyy/MM/dd')) AS SALES_END_YMD ");
                }
                else
                {
                    sb.Append("   ,FORMAT(SALES.START_YMD, '@@@@/@@/@@') AS SALES_START_YMD ");
                    sb.Append("   ,FORMAT(SALES.END_YMD  , '@@@@/@@/@@') AS SALES_END_YMD ");
                }
                sb.AppendFormat(" FROM T_SALES SALES WHERE SALES_NO = '{0}' AND DEL_FLG = 0 ", SalesNo);
                return base.ExecuteSelect(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        /// <summary>
        /// 売上情報の状態を取得する
        /// </summary>
        /// <param name="SalesNo">売上№</param>
        /// <returns>4：入金済、3：請求書発行済、2：請求計算済、1：売上入力済、99：エラー</returns>
        public int GetStatus(string SalesNo)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(" SELECT ");
                sb.AppendFormat("     SAL.BILLING_FLG ");
                sb.AppendFormat("    ,RDT.DEPOSIT_AMOUNT ");
                sb.AppendFormat("    ,RDT.PUBLISH_FLG ");
                sb.AppendFormat("   FROM T_SALES AS SAL ");
                sb.AppendFormat("   LEFT JOIN (SELECT SALES_NO, PUBLISH_FLG, DEPOSIT_AMOUNT FROM T_REQUEST_DTL WHERE DEL_FLG = 0) AS RDT ");
                sb.AppendFormat("     ON SAL.SALES_NO = RDT.SALES_NO ");
                sb.AppendFormat("  WHERE SAL.SALES_NO = '{0}' ", SalesNo);

                using (DataTable dt = base.ExecuteSelect(sb.ToString()))
                {
                    if (dt.Rows.Count == 0)
                    {
                        //エラー
                        return 99;
                    }
                    if (dt.Rows[0]["DEPOSIT_AMOUNT"].ToDecimalEx() > 0)
                    {
                        //入金済
                        return 4;
                    }
                    else if (dt.Rows[0]["PUBLISH_FLG"].ToIntlEx() == 1)
                    {
                        //請求書発行済
                        return 3;
                    }
                    else if (dt.Rows[0]["BILLING_FLG"].ToIntlEx() == 1)
                    {
                        //請求計算済
                        return 2;
                    }
                    else if (dt.Rows[0]["BILLING_FLG"].ToIntlEx() == 0)
                    {
                        //売上入力済
                        return 1;
                    }
                    else
                    {
                        //エラー
                        return 99;
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        /// <summary>
        /// 売上情報の重複チェック（受注№に対して売上年月が重複していないか）
        /// </summary>
        /// <param name="SalesYm">売上年月</param>
        /// <param name="OrdNo">受注№</param>
        /// <returns>重複あり：True、重複なし：False</returns>
        public bool IsDuplicatesSales(String SalesYm ,String OrdNo)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(" SELECT ");
                sb.AppendFormat("     SALES_NO ");
                sb.AppendFormat("   FROM T_SALES ");
                sb.AppendFormat("  WHERE SALES_YM = '{0}' ", SalesYm);
                sb.AppendFormat("    AND ORDER_NO = '{0}' ", OrdNo);
                sb.AppendFormat("    AND DEL_FLG  = 0 ");

                using (DataTable dt = base.ExecuteSelect(sb.ToString()))
                {
                    if (dt.Rows.Count > 0)
                    {
                        //重複あり
                        return true;
                    }
                    else
                    {
                        //重複なし
                        return false;

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 売上登録SQL発行
        /// </summary>
        /// <param name="dto">Sal010用dto</param>
        /// <returns></returns>
        public void insertSale(dtoSal010 dto)
        {

            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO T_SALES VALUES (");
                sb.AppendFormat(" '{0}'", base.NumberingSales(dto.SaleYMD));
                sb.AppendFormat(",'{0}'", dto.ORDER_NO);
                sb.AppendFormat(",'{0}'", dto.SaleYMD);
                sb.AppendFormat(",'{0}'", dto.startYMD);
                sb.AppendFormat(",'{0}'", dto.endYMD);
                sb.AppendFormat(", {0} ", dto.OPTime);
                sb.AppendFormat(", {0} ", dto.overTime);
                sb.AppendFormat(", {0} ", dto.lackTime);
                sb.AppendFormat(", {0} ", dto.baseAmount);
                sb.AppendFormat(", {0} ", dto.Ov_amount);
                sb.AppendFormat(", {0} ", dto.Sub_amount);
                sb.AppendFormat(", {0} ", dto.Sale_Amount);
                sb.AppendFormat(", {0} ", dto.Tax_Rate);
                sb.AppendFormat(", {0} ", dto.Tax_Amount);
                sb.AppendFormat(",'{0}'", dto.EngId);
                sb.AppendFormat(",'{0}'", dto.CusID);
                sb.AppendFormat(", {0} ", dto.Bill_FLG);
                sb.AppendFormat(", {0} ", dto.DEL_FLG);
                sb.AppendFormat(", {0} ", dto.SYNC_FLG);
                sb.AppendFormat(",'{0}'", dto.TIMESTAMP);
                sb.AppendFormat(")");
                ExecuteAction(sb.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 削除フラグ更新
        /// </summary>
        /// <param name="dto">Sal010用dto</param>
        /// <returns></returns>
        public void Delete(dtoSal010 dto)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("UPDATE T_SALES SET ");
                sb.AppendFormat(" BILLING_FLG    =   0");
                sb.AppendFormat(",DEL_FLG        =   1  ");
                sb.AppendFormat(",SYNC_FLG       =  {0} ", dto.SYNC_FLG);
                sb.AppendFormat(",TIME_STAMP     = '{0}'", dto.TIMESTAMP);
                sb.AppendFormat(" WHERE SALES_NO = '{0}'",dto.SALE_NO);
                ExecuteAction(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// 売上データ更新
        /// </summary>
        /// <param name="dto">Sal010用dto</param>
        /// <returns></returns>
        public void UpDate(dtoSal010 dto)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE T_SALES SET ");
                sb.AppendFormat(" START_YMD       = '{0}'",dto.startYMD);
                sb.AppendFormat(",END_YMD         = '{0}'", dto.endYMD);
                sb.AppendFormat(",OPERATION_TIME  =  {0}", dto.OPTime);
                sb.AppendFormat(",OVER_TIME       =  {0}", dto.overTime);
                sb.AppendFormat(",LACK_TIME       =  {0}", dto.lackTime);
                sb.AppendFormat(",BASE_AMOUNT     =  {0}", dto.baseAmount);
                sb.AppendFormat(",ORVER_AMOUNT    =  {0}", dto.Ov_amount);
                sb.AppendFormat(",SUBTRACT_AMOUNT =  {0}", dto.Sub_amount);
                sb.AppendFormat(",SALES_AMOUNT    =  {0}", dto.Sale_Amount);
                sb.AppendFormat(",TAX_RATE        =  {0}", dto.Tax_Rate);
                sb.AppendFormat(",TAX_AMOUNT      =  {0}", dto.Tax_Amount);
                sb.AppendFormat(",BILLING_FLG     =   0");
                sb.AppendFormat(",DEL_FLG         =   0");
                sb.AppendFormat(",SYNC_FLG        =  {0}", dto.SYNC_FLG);
                sb.AppendFormat(",TIME_STAMP      = '{0}'",dto.TIMESTAMP);
                sb.AppendFormat(" WHERE SALES_NO  = '{0}'",dto.SALE_NO);
                ExecuteAction(sb.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
