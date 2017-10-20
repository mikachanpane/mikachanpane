using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sugitec.Common;
using System.Data;

namespace Sugitec.Logics
{
   public class srvOrd020 :srvBase
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
        public DataTable Select(dtoOrd020 dto)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("Select ");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.Append(" IIF(a.ORDER_YMD = '','',FORMAT(CONVERT(DateTime,a.ORDER_YMD),'yyyy/MM/dd')) As ORDER_YMD ");
                }
                else
                {
                    sb.Append(" FORMAT(a.ORDER_YMD,'@@@@/@@/@@') As ORDER_YMD ");
                }                    
                sb.Append(",a.ORDER_NO ");
                sb.Append(",a.CUSTOMER_ORDER_NO ");
                sb.Append(",a.PROJECT_NM ");
                sb.Append(",a.CUSTOMER_CD ");
                sb.Append(",a.CONTRACT_TYP ");
                sb.Append(",a.ENGINEER_ID ");
                sb.Append(",a.ACTUARIAL_KBN ");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.Append(",IIF(a.START_YMD = '','',FORMAT(CONVERT(DateTime,a.START_YMD),'yyyy/MM/dd')) As START_YMD ");
                    sb.Append(",IIF(a.END_YMD = '','',FORMAT(CONVERT(DateTime,a.END_YMD),'yyyy/MM/dd')) As END_YMD ");
                }
                else
                {
                    sb.Append(",FORMAT(a.START_YMD,'@@@@/@@/@@') As START_YMD ");
                    sb.Append(",FORMAT(a.END_YMD,'@@@@/@@/@@') As END_YMD ");
                }
                sb.Append(",a.UPPER_LIMIT ");
                sb.Append(",a.LOWER_LIMIT ");
                sb.Append(",a.BASE_RATE ");
                sb.Append(",a.ORVER_RATE ");
                sb.Append(",a.SUBTRACT_RATE ");
                sb.Append(",b.NAME AS CUSNAME ");
                sb.Append(",c.NAME AS ENGNAME ");
                sb.Append("  From (T_ORDER As a INNER JOIN M_CUSTOMER As b ON a.CUSTOMER_CD = b.CODE) INNER JOIN M_ENGINEER As c ON a.ENGINEER_ID = c.ID");
                sb.Append(" Where (a.DEL_FLG = 0) ");
                
                if (dto.OrderNoF != "")
                {
                    sb.AppendFormat(" AND ('{0}' <= a.ORDER_NO) ", dto.OrderNoF);
                }
                
                if (dto.OrderNoT != "")
                {
                    sb.AppendFormat(" AND (a.ORDER_NO <= '{0}') ", dto.OrderNoT);
                }
                if (dto.OrderStartYmF != "")
                {
                    sb.AppendFormat(" AND ('{0}' <= a.START_YMD) ", dto.OrderStartYmF);
                }

                if (dto.OrderStartYmT != "")
                {
                    sb.AppendFormat(" AND ('{0}' >= a.START_YMD) ", dto.OrderStartYmT);
                }
                if (dto.CusCode != "00000000")
                {
                    sb.AppendFormat(" AND (a.CUSTOMER_CD = '{0}') ", dto.CusCode);
                }
                else
                {
                    if (dto.CusCodeF != "")
                    {
                        sb.AppendFormat(" AND ('{0}' <= a.CUSTOMER_CD) ", dto.CusCodeF);
                    }

                    if (dto.CusCodeT != "")
                    {
                        sb.AppendFormat(" AND (a.CUSTOMER_CD <= '{0}') ", dto.CusCodeT);
                    }
                }
                if (dto.EngId != "00000000")
                {
                    sb.AppendFormat(" AND (a.ENGINEER_ID = '{0}') ", dto.EngId);
                }
                else
                {
                    if (dto.EngIdF != "")
                    {
                        sb.AppendFormat(" AND ('{0}' <= a.ENGINEER_ID) ", dto.EngIdF);
                    }

                    if (dto.EngIdT != "")
                    {
                        sb.AppendFormat(" AND (a.ENGINEER_ID <= '{0}') ", dto.EngIdT);
                    }
                }
                if (dto.PrjName != "")
                {
                    sb.AppendFormat(" AND (a.PROJECT_NM LIKE '%{0}%' ) ", dto.PrjName);
                }
                if (dto.CusOrdNo != "")
                {
                    sb.AppendFormat(" AND (a.CUSTOMER_ORDER_NO LIKE '%{0}%' ) ", dto.CusOrdNo);
                }

                return base.ExecuteSelect(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
