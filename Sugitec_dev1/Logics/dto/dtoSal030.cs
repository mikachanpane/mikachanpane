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
    public class dtoSal030
	{
		/// <summary>受注№</summary>
		public string ORDER_NO;
		/// <summary>計上年月日</summary>
		public string ACCRUAL_YMD;
		/// <summary>経費項目コード</summary>
		public string EXPENSE_CD;
		/// <summary>金額</summary>
		public string KINGAKU;
		/// <summary>税区分</summary>
		public string TAX_KBN;
		/// <summary>備考１</summary>
		public string BIKO1;
		/// <summary>備考２</summary>
		public string BIKO2;
		/// <summary>請求フラグ</summary>
		public string BILLING_FLG;
        /// <summary>削除フラグ</summary>
        public string DEL_FLG;
        /// <summary>同期フラグ</summary>
        public string SYNC_FLG;
        /// <summary>タイムスタンプ</summary>
        public string TIME_STAMP;
    }
}
