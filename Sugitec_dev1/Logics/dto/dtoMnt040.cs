using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sugitec.Logics
{
    /// <summary>
    /// MNT040用DTO
    /// </summary>
    public class dtoMnt040
    {
        /// <summary>コード</summary>
        public string CODE;
        /// <summary>開始年月日</summary>
        public string START_YMD;
        /// <summary>税率</summary>
        public decimal TAX_RATE;
        /// <summary>有効</summary>
        public int VALID_FLG;
        /// <summary>削除フラグ</summary>
        public int DEL_FLG;
        /// <summary>同期フラグ</summary>
        public int SYNC_FLG;
        /// <summary>タイムスタンプ</summary>
        public string TIMESTAMP;
    }
}
