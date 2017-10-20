using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sugitec.Logics
{
    /// <summary>
    /// frmXXXのDTO
    /// </summary>
    public class dtoDisplay
    {
        /// <summary>売上日</summary>
        public string OrderYm = string.Empty;

        /// <summary>受注期間(開始日)</summary>
        public string OrderYmF = string.Empty;

        /// <summary>受注期間(終了日)</summary>
        public string OrderYmT = string.Empty;
        
        /// <summary>得意先コード</summary>
        public string CusCd = string.Empty;

        /// <summary>得意先コード(開始)</summary>
        public string CusCdF = string.Empty;

        /// <summary>得意先コード(終了)</summary>
        public string CusCdT = string.Empty;

        /// <summary>技術者コード</summary>
        public string EngId = string.Empty;

        /// <summary>技術者コード(開始)</summary>
        public string EngIdF = string.Empty;

        /// <summary>技術者コード(終了)</summary>
        public string EngIdT = string.Empty;

        /// <summary>売上状態 </summary>
        public string SalAmSta = string.Empty;

        /// <summary>請求フラグ</summary>
        public string BillFlg = string.Empty;

        /// <summary>回収フラグ</summary>
        public string FinFlg = string.Empty;

        /// <summary>請求書発行フラグ</summary>
        public string PubFlg = string.Empty;
    }
}
