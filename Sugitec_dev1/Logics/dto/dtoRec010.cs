using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sugitec.Common;
using System.Data;

namespace Sugitec.Logics
{

    public class dtoRec010
    {
        /// <summary>入金№</summary>
        public string RecNo = "";
        /// <summary>得意先コード</summary>
        public string CusCd = "";
        /// <summary>入金日</summary>
        public string ReciptYMD = "";
        /// <summary>現金</summary>
        public decimal cash = 0;
        /// <summary>振込手数料</summary>
        public decimal Fees = 0;
        /// <summary>預金</summary>
        public decimal deposit = 0;
        /// <summary>手形</summary>
        public decimal bill = 0;
        /// <summary>手形受取日</summary>
        public string BillYMD = "";
        /// <summary>現金（消込可能額）</summary>
        public decimal DepCash = 0;
        /// <summary>振込手数料（消込可能額）</summary>
        public decimal DepFees = 0;
        /// <summary>預金（消込可能額）</summary>
        public decimal DepDeposit = 0;
        /// <summary>手形（消込可能額）</summary>
        public decimal DepBill = 0;
        /// <summary>同期フラグ</summary>
        public int syncFlf = 0;
        /// <summary>タイムスタンプ</summary>
        public string TIMESTAMP;
        /// <summary>明細部</summary>
        public DataTable ReqList;

    }
}