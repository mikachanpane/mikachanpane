using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sugitec.Common
{

    /// <summary>
    /// ビジネスロジックベースクラス
    /// </summary>
    public class srvBase : clsDBManaeger
    {

        /// <summary>
        /// コンストラクタ
        /// </summary>
        protected srvBase()
        {
            try
            {
                base.DBOpen();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// コンストラクタ（データ同期用）
        /// </summary>
        /// <param name="OPS">動作状態</param>
        public srvBase(OperatStatus OPS)
        {
            try
            {
                base.DBOpen();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 受注№を採番する
        /// </summary>
        /// <param name="OrderYmd">受注日</param>
        /// <returns>受注№した受注№</returns>
        protected string NumberingOrder(string OrderYmd)
        {
            try
            {
                string No1 = OrderYmd.MidEx(2, 4);
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("SELECT MAX(ORDER_NO) AS MAX_ORDER_NO FROM T_ORDER ");
                if(clsDefine.OperatingStatus== OperatStatus.ONLINE)
                {
                    sb.AppendFormat(" WHERE SUBSTRING(ORDER_NO,1,4) = '{0}'", No1);
                }
                else
                {
                    sb.AppendFormat(" WHERE MID(ORDER_NO,1,4) = '{0}'", No1);
                }

                DataTable dt = base.ExecuteSelect(sb.ToString());
                string OrderNo = dt.Rows[0]["MAX_ORDER_NO"].ToString();

                if(string.IsNullOrEmpty(OrderNo))
                {
                    return No1 + "0001";
                }
                else
                {
                    return (OrderNo.ToDecimalEx() + 1).ToString();  
                }
            }
            catch
            {
                throw;
            }        

        }

        /// <summary>
        /// 売上№を採番する
        /// </summary>
        /// <param name="ym">売上年月</param>
        /// <returns>採番した受注№</returns>
        protected string NumberingSales(string SalesYm)
        {
            try
            {
                string No1 = SalesYm.MidEx(2, 4);
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("SELECT MAX(SALES_NO) AS MAX_SALES_NO FROM T_SALES ");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.AppendFormat(" WHERE SUBSTRING(SALES_NO,1,4) = '{0}'", No1);
                }
                else
                {
                    sb.AppendFormat(" WHERE MID(SALES_NO,1,4) = '{0}'", No1);
                }

                DataTable dt = base.ExecuteSelect(sb.ToString());
                string SalesNo = dt.Rows[0]["MAX_SALES_NO"].ToString();

                if (string.IsNullOrEmpty(SalesNo))
                {
                    return No1 + "0001";
                }
                else
                {
                    return (SalesNo.ToDecimalEx() + 1).ToString();
                }
            }
            catch
            {
                throw;
            }

        }

        /// <summary>
        /// 請求№を採番する
        /// </summary>
        /// <param name="ym">請求年月</param>
        /// <returns>採番した請求№</returns>
        protected string NumberingRequest(string BilligYm)
        {
            try
            {
                string No1 = BilligYm.MidEx(2, 4);
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("SELECT MAX(REQUEST_NO) AS MAX_REQUEST_NO FROM T_REQUEST ");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.AppendFormat(" WHERE SUBSTRING(REQUEST_NO,1,4) = '{0}'", No1);
                }
                else
                {
                    sb.AppendFormat(" WHERE MID(REQUEST_NO,1,4) = '{0}'", No1);
                }

                DataTable dt = base.ExecuteSelect(sb.ToString());
                string RequestNo = dt.Rows[0]["MAX_REQUEST_NO"].ToString();

                if (string.IsNullOrEmpty(RequestNo))
                {
                    return No1 + "0001";
                }
                else
                {
                    return (RequestNo.ToDecimalEx() + 1).ToString();
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 入金№を採番する
        /// </summary>
        /// <param name="ym">入金年月日</param>
        /// <returns>採番した入金№</returns>
        protected string NumberingReceipt(string ReceiptYmd)
        {
            try
            {
                string No1 = ReceiptYmd.MidEx(2, 4);
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("SELECT MAX(RECEIPT_NO) AS MAX_RECEIPT_NO FROM T_RECEIPT ");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.AppendFormat(" WHERE SUBSTRING(RECEIPT_NO,1,4) = '{0}'", No1);
                }
                else
                {
                    sb.AppendFormat(" WHERE MID(RECEIPT_NO,1,4) = '{0}'", No1);
                }

                DataTable dt = base.ExecuteSelect(sb.ToString());
                string ReceiptNo = dt.Rows[0]["MAX_RECEIPT_NO"].ToString();

                if (string.IsNullOrEmpty(ReceiptNo))
                {
                    return No1 + "0001";
                }
                else
                {
                    return (ReceiptNo.ToDecimalEx() + 1).ToString();
                }
            }
            catch
            {
                throw;
            }

        }

        /// <summary>
        /// 入金消込№を採番する
        /// </summary>
        /// <returns>採番した入金消込№</returns>
        protected string NumberingDeposit()
        {
            try
            {
                string No1 = DateTime.Now.Year.ToString().Substring(2,2);
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("SELECT MAX(DEPOSIT_NO) AS MAX_DEPOSIT_NO FROM T_DEPOSIT ");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.AppendFormat(" WHERE SUBSTRING(DEPOSIT_NO,1,2) = '{0}'", No1);
                }
                else
                {
                    sb.AppendFormat(" WHERE MID(DEPOSIT_NO,1,2) = '{0}'", No1);
                }

                DataTable dt = base.ExecuteSelect(sb.ToString());
                string DepositNo = dt.Rows[0]["MAX_DEPOSIT_NO"].ToString();

                if (string.IsNullOrEmpty(DepositNo))
                {
                    return No1 + "000001";
                }
                else
                {
                    return (DepositNo.ToDecimalEx() + 1).ToString();
                }
            }
            catch
            {
                throw;
            }

        }


        /// <summary>
        /// 税率№を採番する
        /// </summary>
        /// <param name="CODE">税率№</param>
        /// <returns>採番した税率№</returns>
        protected string NumberingTax()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("SELECT MAX(CODE) AS MAX_CODE FROM M_TAX ");

                DataTable dt = base.ExecuteSelect(sb.ToString());
                string CODE = dt.Rows[0]["MAX_CODE"].ToString();

                if (string.IsNullOrEmpty(CODE))
                {
                    return "01";
                }
                else
                {
                    return (CODE.ToDecimalEx() + 1).ToString();
                }
            }
            catch
            {
                throw;
            }

        }

    }
}
