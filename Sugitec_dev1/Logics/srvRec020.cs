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
    public class srvRec020:srvBase
    {
        /// <summary>
        ///　得意先取得
        /// </summary>
        /// <returns>抽出結果</returns>
        public DataTable SelectCus()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT R.CUSTOMER_CD ");
                sb.Append("      ,C.NAME ");
                sb.Append("  FROM T_RECEIPT AS R INNER JOIN M_CUSTOMER AS C ");
                sb.Append("    ON R.CUSTOMER_CD = C.CODE ");
                sb.Append(" WHERE R.DEL_FLG = 0 ");
                sb.Append(" GROUP BY R.CUSTOMER_CD, C.NAME ");
                sb.Append(" ORDER BY R.CUSTOMER_CD ");
                return base.ExecuteSelect(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///　入金情報取得
        /// </summary>
        /// <param name="dto">Rec020用dto</param>
        /// <returns>抽出結果</returns>
        public DataTable SelectRec(dtoRec020 dto)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("Select ");
                sb.Append("    REC.RECEIPT_NO ");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.Append("    ,IIF(REC.RECEIPT_YMD = '','',FORMAT(CONVERT(DateTime,REC.RECEIPT_YMD),'yyyy/MM/dd')) AS RECEIPT_YMD ");
                    sb.Append("    ,IIF(REC.BILL_YMD = '','',FORMAT(CONVERT(DateTime,REC.BILL_YMD),'yyyy/MM/dd')) AS BILL_YMD ");
                }
                else
                {
                    sb.Append("    ,FORMAT(REC.RECEIPT_YMD,'@@@@/@@/@@') AS RECEIPT_YMD ");
                    sb.Append("    ,FORMAT(REC.BILL_YMD,'@@@@/@@/@@') AS BILL_YMD ");
                }
                sb.Append("   ,REC.BILL ");
                sb.Append("   ,REC.CASH ");
                sb.Append("   ,REC.DEPOSIT ");
                sb.Append("   ,REC.TRANSFER_FEES ");
                sb.Append("   ,REC.DEP_BILL ");
                sb.Append("   ,REC.DEP_CASH ");
                sb.Append("   ,REC.DEP_DEPOSIT ");
                sb.Append("   ,REC.DEP_TRANSFER_FEES ");
                sb.Append("   ,REC.CUSTOMER_CD ");
                sb.Append("   ,CUS.NAME ");
                sb.Append("  From T_RECEIPT REC LEFT JOIN M_CUSTOMER CUS ON CUS.CODE = REC.CUSTOMER_CD");

                sb.Append(" WHERE REC.DEL_FLG = 0 ");

                if (dto.CusArea == false)
                {
                    if (dto.CusCode !=  "00000000")
                    {
                        sb.AppendFormat(" AND  REC.CUSTOMER_CD = '{0}' ", dto.CusCode);
                    }

                }
                else
                {
                    sb.AppendFormat(" AND ( REC.CUSTOMER_CD BETWEEN '{0}' AND '{1}') ", dto.CusCodeFrm,dto.CusCodeTo);
                 
                }

                if (dto.RecArea == false)
                {
                    sb.AppendFormat(" AND  REC.RECEIPT_YMD >= '{0}' ", dto.RecYM + "01");
                }
                else
                {
                    sb.AppendFormat(" AND  REC.RECEIPT_YMD >= '{0}' AND  REC.RECEIPT_YMD < '{1}'  ", dto.RecYMFrm + "01", dto.RecYMTo + "99");
                }

                if (dto.Deposit == 1)
                {
                    sb.Append(" AND (REC.DEP_BILL > 0 ");
                    sb.Append("  OR  REC.DEP_CASH > 0 ");
                    sb.Append("  OR  REC.DEP_DEPOSIT > 0 ");
                    sb.Append("  OR  REC.DEP_TRANSFER_FEES > 0 ");
                    sb.Append("     ) ");
                }
                else if (dto.Deposit == 2)
                {
                    sb.Append(" AND  REC.DEP_BILL = 0 ");
                    sb.Append(" AND  REC.DEP_CASH = 0 ");
                    sb.Append(" AND  REC.DEP_DEPOSIT = 0 ");
                    sb.Append(" AND  REC.DEP_TRANSFER_FEES = 0 ");
                }
                
                sb.Append(" ORDER BY  REC.RECEIPT_NO");
                return base.ExecuteSelect(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
