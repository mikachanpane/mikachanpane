using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sugitec.Logics
{
    public class dtoSal010
    {
        public string SALE_NO = "";
        public string ORDER_NO = "";
        public string SaleYMD = "";
        public string EngId = "";
        public string startYMD = "";
        public string endYMD = "";
        public decimal OPTime = 0;
        public decimal overTime = 0;
        public decimal lackTime = 0;
        public decimal baseAmount = 0;
        public decimal Ov_amount = 0;
        public decimal Sub_amount = 0;
        public decimal Sale_Amount = 0;
        public decimal Tax_Rate = 0;
        public decimal Tax_Amount = 0;
        public string CusID = "";
        public int Bill_FLG = 0;
        public int DEL_FLG = 0;
        public int SYNC_FLG = 0;
        public string TIMESTAMP = "";

        /// <summary>
        /// 初期化
        /// </summary>
        public void clear()
        {
            SALE_NO = "";
            ORDER_NO = "";
            SaleYMD = "";
            EngId = "";
            startYMD = "";
            endYMD = "";
            OPTime = 0;
            overTime = 0;
            lackTime = 0;
            baseAmount = 0;
            Ov_amount = 0;
            Sub_amount = 0;
            Sale_Amount = 0;
            Tax_Rate = 0;
            Tax_Amount = 0;
            CusID = "";
            Bill_FLG = 0;
            DEL_FLG = 0;
            SYNC_FLG = 0;
            TIMESTAMP = "";
        }
    }
}
