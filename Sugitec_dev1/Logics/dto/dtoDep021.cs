using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sugitec.Logics
{
    /// <summary>
    /// DEP021のDTO
    /// </summary>
    public class dtoDep021
    {
        /// <summary> 入金№ </summary>
        public string RECEIPT_NO = string.Empty;
        /// <summary> 入金日 </summary>
        public string RECEIPT_YMD = string.Empty;
        /// <summary> 現金 </summary>
        public decimal CASH = 0;
        /// <summary> 手数料 </summary>
        public decimal TRANSFER_FEES = 0;
        /// <summary> 預金 </summary>
        public decimal DEPOSIT = 0;
        /// <summary> 手形 </summary>
        public decimal BILL = 0;
        /// <summary> 回収残高 </summary>
        public decimal DEPOSIT_RECV_AMOUNT = 0;

    }
}
