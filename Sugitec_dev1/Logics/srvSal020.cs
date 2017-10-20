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
   public class srvSal020:srvBase
    {

        /// <summary>
        ///　得意先Select文発行処理
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>Sal010用dto</returns>
        public DataTable SelectCus()
        {
            //本体
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            try
            {
                sb.Append("Select ORD.CUSTOMER_CD,CUS.NAME FROM T_ORDER ORD ");
                sb.Append("INNER JOIN M_CUSTOMER CUS ON ORD.CUSTOMER_CD = CUS.CODE ");
                sb.Append(" WHERE CUS.DEL_FLG = 0 ");
                sb.Append("GROUP BY ORD.CUSTOMER_CD,CUS.NAME ORDER BY ORD.CUSTOMER_CD");


                return base.ExecuteSelect(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 技術者取得Select文発行処理
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public DataTable SelectEng()
        {

            //本体
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //条件
            try
            {
                sb.Append("Select ORD.ENGINEER_ID,ENG.NAME FROM T_ORDER ORD ");
                sb.Append("INNER JOIN M_ENGINEER ENG ON ORD.ENGINEER_ID = ENG.ID ");
                sb.Append(" WHERE ENG.DEL_FLG = 0 ");
                sb.Append("GROUP BY ORD.ENGINEER_ID,ENG.NAME ORDER BY ORD.ENGINEER_ID");

                return base.ExecuteSelect(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Select文発行処理
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public DataTable Select(dtoSal020 dto)
        {

            //本体
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //条件
            System.Text.StringBuilder sb2 = new System.Text.StringBuilder();

            try
            {


                sb.Append("Select ORD.* , CUS.NAME AS CUSNAME ,ENG.NAME AS ENGNAME ,ORD.START_YMD AS ORDSTART_YMD,ORD.END_YMD AS ORDEND_YMD, SAL.* "); 
                sb.Append(" FROM(((T_ORDER AS ORD  LEFT JOIN T_SALES AS SAL ON ORD.ORDER_NO = SAL.ORDER_NO)");
                sb.Append("INNER JOIN M_ENGINEER AS ENG ON ORD.ENGINEER_ID = ENG.ID)");
                sb.Append("INNER JOIN  M_CUSTOMER AS CUS ON ORD.CUSTOMER_CD = CUS.CODE )");

                if (dto.YMArea == false)
                {
                    if (clsDefine.OperatingStatus == OperatStatus.OFFLINE)
                    {
                        sb2.AppendFormat(" '{0}' BETWEEN MID(ORD.START_YMD,1,6) AND MID(ORD.END_YMD,1,6) ", dto.srcSaleYM);
                    }
                    else
                    {
                        sb2.AppendFormat(" '{0}' BETWEEN SUBSTRING(ORD.START_YMD,1,6) AND SUBSTRING(ORD.END_YMD,1,6) ", dto.srcSaleYM);
                    }
                    sb2.AppendFormat(" AND SAL.SALES_YM = '{0}'",dto.srcSaleYM);
                }
                else
                {
                    sb2.Append("SAL.SALES_YM >= '").Append(dto.srcSaleYMf).Append("' ");
                    sb2.Append(" AND ");
                    sb2.Append("SAL.SALES_YM <= '").Append(dto.srcSaleYMt).Append("' ");
                }

                if (dto.srcEngID != "00000000"){
                    sb2.Append(" AND ");
                    if (dto.IDArea == false)
                    {
                        sb2.Append("SAL.ENGINEER_ID = '").Append(dto.srcEngID).Append("' ");
                    }
                    else
                    {
                        sb2.Append("SAL.ENGINEER_ID >= '").Append(dto.srcEngIDf).Append("' ");
                        sb2.Append(" AND ");
                        sb2.Append("SAL.ENGINEER_ID <= '").Append(dto.srcEngIDt).Append("' ");
                    }
                }

                if (dto.srcCUSCD != "00000000")
                {
                    sb2.Append(" AND ");

                    if (dto.CDArea == false)
                    {
                        sb2.Append("SAL.CUSTOMER_CD = '").Append(dto.srcCUSCD).Append("' ");
                    }
                    else
                    {
                        sb2.Append("SAL.CUSTOMER_CD >= '").Append(dto.srcCUSCDf).Append("' ");
                        sb2.Append(" AND ");
                        sb2.Append("SAL.CUSTOMER_CD <= '").Append(dto.srcCUSCDt).Append("' ");
                    }
                }
                sb2.Append(" AND ");

                sb2.Append("CUS.CUTOFF_DAY = ").Append(dto.srcSHIMEBI);

                sb2.Append(" AND ");

                sb2.Append("SAL.DEL_FLG = 0");

                sb.Append(" WHERE ").Append(sb2.ToString());

                return base.ExecuteSelect(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Select文発行処理
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public DataTable Select2(dtoSal020 dto)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("SELECT ");
                sb.AppendFormat("  ORD.ORDER_NO ");
                sb.AppendFormat(" ,ORD.PROJECT_NM ");
                sb.AppendFormat(" ,ORD.CUSTOMER_CD ");
                sb.AppendFormat(" ,ORD.CUSNAME  ");
                sb.AppendFormat(" ,ORD.ENGINEER_ID ");
                sb.AppendFormat(" ,ORD.ENGNAME ");
                sb.AppendFormat(" ,ORD.START_YMD ");
                sb.AppendFormat(" ,ORD.END_YMD ");
                sb.AppendFormat(" ,SAL.SALES_NO ");
                sb.AppendFormat(" ,SAL.SALES_YM ");
                sb.AppendFormat(" ,SAL.SALES_AMOUNT ");
                sb.AppendFormat(" ,SAL.STATUS ");
                sb.AppendFormat("FROM ");
                sb.AppendFormat("( ");
                sb.AppendFormat("SELECT ");
                sb.AppendFormat("  ORD.ORDER_NO ");
                sb.AppendFormat(" ,ORD.PROJECT_NM ");
                sb.AppendFormat(" ,ORD.CUSTOMER_CD ");
                sb.AppendFormat(" ,CUS.NAME AS CUSNAME ");
                sb.AppendFormat(" ,ORD.ENGINEER_ID ");
                sb.AppendFormat(" ,ENG.NAME AS ENGNAME ");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.AppendFormat(" ,IIF(ORD.START_YMD = '','',FORMAT(CONVERT(DateTime,ORD.START_YMD),'yyyy/MM/dd')) AS START_YMD ");
                    sb.AppendFormat(" ,IIF(ORD.END_YMD = '','',FORMAT(CONVERT(DateTime,ORD.END_YMD),'yyyy/MM/dd')) AS END_YMD ");
                }
                else
                {
                    sb.AppendFormat(" ,FORMAT(ORD.START_YMD,'@@@@/@@/@@') AS START_YMD ");
                    sb.AppendFormat(" ,FORMAT(ORD.END_YMD,'@@@@/@@/@@') AS END_YMD ");
                }
                sb.AppendFormat("  FROM ((T_ORDER AS ORD ");
                sb.AppendFormat(" INNER JOIN M_ENGINEER AS ENG ON  ORD.ENGINEER_ID = ENG.ID) ");
                sb.AppendFormat(" INNER JOIN M_CUSTOMER AS CUS ON  ORD.CUSTOMER_CD = CUS.CODE) ");
                if (dto.YMArea == false)
                {
                    if (clsDefine.OperatingStatus == OperatStatus.OFFLINE)
                    {
                        sb.AppendFormat(" WHERE '{0}' BETWEEN MID(ORD.START_YMD,1,6) AND MID(ORD.END_YMD,1,6) ", dto.srcSaleYM);
                    }
                    else
                    {
                        sb.AppendFormat(" WHERE '{0}' BETWEEN SUBSTRING(ORD.START_YMD,1,6) AND SUBSTRING(ORD.END_YMD,1,6) ", dto.srcSaleYM);
                    }
                }
                else
                {
                    if (clsDefine.OperatingStatus == OperatStatus.OFFLINE)
                    {
                        sb.AppendFormat(" WHERE ('{0}' BETWEEN MID(ORD.START_YMD,1,6) AND MID(ORD.END_YMD,1,6) ", dto.srcSaleYMf);
                        sb.AppendFormat("    OR  '{0}' BETWEEN MID(ORD.START_YMD,1,6) AND MID(ORD.END_YMD,1,6)) ", dto.srcSaleYMt);
                        //sb.AppendFormat(" WHERE (MID(ORD.START_YMD,1,6) BETWEEN '{0}' AND '{1}'  ", dto.srcSaleYMf, dto.srcSaleYMt);
                        //sb.AppendFormat("    OR  MID(ORD.END_YMD,1,6)   BETWEEN '{0}' AND '{1}') ", dto.srcSaleYMf, dto.srcSaleYMt);
                    }
                    else
                    {
                        sb.AppendFormat(" WHERE (SUBSTRING(ORD.START_YMD,1,6) BETWEEN '{0}' AND '{1}'  ", dto.srcSaleYMf, dto.srcSaleYMt);
                        sb.AppendFormat("    OR  SUBSTRING(ORD.END_YMD,1,6)   BETWEEN '{0}' AND '{1}') ", dto.srcSaleYMf, dto.srcSaleYMt);
                    }
                }
                if (dto.srcEngID != "00000000")
                {
                    if (dto.IDArea == false)
                    {
                        sb.AppendFormat(" AND ORD.ENGINEER_ID = '{0}'",dto.srcEngID);
                    }
                    else
                    {
                        sb.AppendFormat(" AND ORD.ENGINEER_ID >= '{0}'" ,dto.srcEngIDf);
                        sb.AppendFormat(" AND ORD.ENGINEER_ID <= '{0}'",dto.srcEngIDt);
                    }
                }
                if (dto.srcCUSCD != "00000000")
                {
                    if (dto.CDArea == false)
                    {
                        sb.AppendFormat(" AND ORD.CUSTOMER_CD = '{0}'",dto.srcCUSCD);
                    }
                    else
                    {
                        sb.AppendFormat(" AND ORD.CUSTOMER_CD >= '{0}'",dto.srcCUSCDf);
                        sb.AppendFormat(" AND ORD.CUSTOMER_CD <= '{0}'",dto.srcCUSCDt);
                    }
                }
                if (dto.srcSHIMEBI != 0)
                {
                    sb.AppendFormat(" AND CUS.CUTOFF_DAY = {0}",dto.srcSHIMEBI);
                }
                sb.AppendFormat(" AND ORD.DEL_FLG = 0 ");
                sb.AppendFormat(") AS ORD ");
                sb.AppendFormat("LEFT JOIN ");
                sb.AppendFormat("( ");
                sb.AppendFormat("SELECT ");
                sb.AppendFormat("  SAL.SALES_NO ");
                sb.AppendFormat(" ,SAL.ORDER_NO ");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.AppendFormat(" ,IIF(SAL.SALES_YM = '','',FORMAT(CONVERT(DateTime,SAL.SALES_YM + '01'),'yyyy/MM')) AS SALES_YM ");
                }
                else
                {
                    sb.AppendFormat(" ,FORMAT(SAL.SALES_YM,'@@@@/@@') AS SALES_YM ");
                }
                sb.AppendFormat(" ,SAL.SALES_AMOUNT ");
                if (clsDefine.OperatingStatus == OperatStatus.OFFLINE)
                {
                    sb.AppendFormat(" ,SWITCH (RDT.DEPOSIT_AMOUNT>0,'入金済' ");
                    sb.AppendFormat("         ,RDT.PUBLISH_FLG=1,'請求書発行済' ");
                    sb.AppendFormat("         ,SAL.BILLING_FLG=1,'請求計算済' ");
                    sb.AppendFormat("         ,SAL.BILLING_FLG=0,'' ");
                    sb.AppendFormat("         ,True,'') AS STATUS ");
                }
                else
                {
                    sb.AppendFormat(" ,(CASE ");
                    sb.AppendFormat("   WHEN RDT.DEPOSIT_AMOUNT>0 THEN '入金済' ");
                    sb.AppendFormat("   WHEN RDT.PUBLISH_FLG=1 THEN '請求書発行済' ");
                    sb.AppendFormat("   WHEN SAL.BILLING_FLG=1 THEN '請求計算済' ");
                    sb.AppendFormat("   WHEN SAL.BILLING_FLG=0 THEN '' ");
                    sb.AppendFormat("   ELSE '' END) AS STATUS ");
                }
                sb.AppendFormat(" FROM T_SALES AS SAL ");
                sb.AppendFormat(" LEFT JOIN (SELECT SALES_NO, PUBLISH_FLG, DEPOSIT_AMOUNT FROM T_REQUEST_DTL WHERE DEL_FLG = 0) AS RDT ");
                sb.AppendFormat("   ON SAL.SALES_NO = RDT.SALES_NO ");

                if (dto.YMArea == false)
                {
                    sb.AppendFormat(" WHERE SAL.SALES_YM = '{0}'", dto.srcSaleYM);
                }
                else
                {
                    sb.AppendFormat(" WHERE SAL.SALES_YM >= '{0}'",dto.srcSaleYMf);
                    sb.AppendFormat("   AND SAL.SALES_YM <= '{0}'",dto.srcSaleYMt);
                }
                sb.AppendFormat(" AND SAL.DEL_FLG = 0 ");
                sb.AppendFormat(") AS SAL ON ORD.ORDER_NO = SAL.ORDER_NO ");

                sb.AppendFormat(" ORDER BY ORD.ORDER_NO, SAL.SALES_NO");

                return base.ExecuteSelect(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
