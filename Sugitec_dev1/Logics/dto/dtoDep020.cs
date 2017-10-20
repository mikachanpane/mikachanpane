using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sugitec.Logics
{
    /// <summary>
    /// DEP020のDTO
    /// </summary>
    public class dtoDep020
    {
        /// <summary> 請求№ </summary>
        public string REQUEST_NO = string.Empty;
        /// <summary> 枝番 </summary>
        public string REQUEST_SUB_NO = string.Empty;
        /// <summary> 請求年月 </summary>
        public string BILLING_YM = string.Empty;
        /// <summary> 振込指定日 </summary>
        public string TRANSFER_YMD = string.Empty;
        /// <summary> 得意先コード </summary>
        public string CUSCD = string.Empty;
        /// <summary> 得意先名 </summary>
        public string CUSNAME = string.Empty;
        /// <summary> 技術者名 </summary>
        public string ENGNAME = string.Empty;
        /// <summary> 請求金額 </summary>
        public decimal BILLING_AMOUNT = 0;
        /// <summary> 回収残高 </summary>
        public decimal DEPOSIT_RECV_AMOUNT = 0;
        /// <summary> 現金 </summary>
        public decimal CASH = 0;
        /// <summary> 手数料 </summary>
        public decimal TRANSFER_FEES = 0;
        /// <summary> 預金 </summary>
        public decimal DEPOSIT = 0;
        /// <summary> 手形 </summary>
        public decimal BILL = 0;
        /// <summary> 差額 </summary>
        public decimal DIFFERENCE = 0;
        /// <summary> 差額理由 </summary>
        public string DIFF_REASONS_CD = string.Empty;
        /// <summary> 値引き </summary>
        public decimal DISCOUNT = 0;
        /// <summary> キャンセル </summary>
        public bool CANCEL = false;
        /// <summary> 回収一覧 </summary>
        public DataTable DEPOSIT_LIST = new DataTable();

    }
}
