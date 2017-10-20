using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sugitec.Logics
{
    /// <summary>
    /// テキストボックス用DTO
    /// </summary>
    public class dtoMnt030
    {
        /// <summary>区分</summary>
        public string Kbn;
        /// <summary>コード</summary>
        public string Code;
        /// <summary>内容</summary>
        public string Content;
        /// <summary>削除フラグ</summary>
        public int DEL_FLG;
        /// <summary>同期フラグ</summary>
        public int SYNC_FLG;
        /// <summary>タイムスタンプ</summary>
        public string TIMESTAMP;
    }
}
