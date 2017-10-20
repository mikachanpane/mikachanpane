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
    public class dtoMnt100
    {
        /// <summary>コード</summary>
        public string Code;
        /// <summary>名称</summary>
        public string Name;
        /// <summary>かな</summary>
        public string Kana;
		/// <summary>郵便番号</summary>
		public string Post;
        /// <summary>住所１</summary>
        public string Address1;
		/// <summary>住所２</summary>
		public string Address2;
		/// <summary>電話番号</summary>
		public string Tel;
		/// <summary>FAX番号</summary>
		public string FAX;
		/// <summary>請求締日</summary>
		public string Sime;
        /// <summary>支払区分</summary>
        public string Paykbn;
        /// <summary>支払日 </summary>
        public string Payment;
        /// <summary>削除フラグ</summary>
        public string DEL_FLG;
        /// <summary>同期フラグ</summary>
        public int SYNC_FLG;
        /// <summary>タイムスタンプ</summary>
        public string TIME_STAMP;
    }
}
