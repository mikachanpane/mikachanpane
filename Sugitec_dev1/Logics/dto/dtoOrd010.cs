using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sugitec.Common;

namespace Sugitec.Logics
{

    public class dtoOrd010
    {
        /// <summary>受注No.</summary>
        public string ORDER_NO;

        /// <summary>受注日</summary>
        public string ORDER_YMD;

		/// <summary>客先注文番号</summary>
		public string CUSTOMER_ORDER_NO;

		/// <summary>得意先コード</summary>
		public string CUSTOMER_CD;

        /// <summary>得意先担当者</summary>
        public string CONTACT_CODE;

        /// <summary>案件名</summary>
        public string PROJECT_NM;

        /// <summary>作業先名</summary>
        public string WORK_NM;

        /// <summary>作業場所</summary>
        public string WORK_SPACE;

        /// <summary>契約形態</summary>
        public string CONTRACT_TYP;

        /// <summary>帳票ファイル名</summary>
        public string INVOICE_FILE_NM;

        /// <summary>技術者ID</summary>
        public string ENGINEER_ID;

        /// <summary>精算区分</summary>
        public string ACTUARIAL_KBN;

        /// <summary>期間（開始）</summary>
        public string START_YMD;

        /// <summary>期間（終了）</summary>
        public string END_YMD;

        /// <summary>時間幅（上限）</summary>
        public string UPPER_LIMIT;

        /// <summary>時間幅（下限）</summary>
        public string LOWER_LIMIT;

        /// <summary>基本単価</summary>
        public string BASE_RATE;

        /// <summary>超過時単価</summary>
        public string ORVER_RATE;

        /// <summary>減算時単価</summary>
        public string SUBTRACT_RATE;

        /// <summary>案件№</summary>
        public string PROJECT_NO;

        /// <summary>削除フラグ</summary>
        public string DEL_FLG = "0";

        /// <summary>同期フラグ</summary>
        public int SYNC_FLG;

        /// <summary>タイムスタンプ</summary>
        public string TIME_STAMP;
    }
}
