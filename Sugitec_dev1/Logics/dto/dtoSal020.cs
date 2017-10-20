using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sugitec.Common;

namespace Sugitec.Logics
{
    public class dtoSal020
    {
        /// <summary>受注番号</summary>
        public string Ord;
        /// <summary>技術者ID</summary>
        public string EngID;
        /// <summary>顧客コード</summary>
        public string CusCD;

        /// <summary>年月検索範囲</summary>
        public bool YMArea;
        /// <summary>売上年月</summary>
        public string srcSaleYM;
        /// <summary>売上年月～</summary>
        public string srcSaleYMf;
        /// <summary>～売上年月</summary>
        public string srcSaleYMt;

        /// <summary>技術者検索範囲</summary>
        public bool IDArea;
        /// <summary>技術者ID</summary>
        public string srcEngID;
        /// <summary>技術者ID～</summary>
        public string srcEngIDf;
        /// <summary>～技術者ID</summary>
        public string srcEngIDt;

        /// <summary>顧客検索範囲</summary>
        public bool CDArea;
        /// <summary>顧客コード</summary>
        public string srcCUSCD;
        /// <summary>顧客コード～~</summary>
        public string srcCUSCDf;
        /// <summary>～顧客コード</summary>
        public string srcCUSCDt;

        /// <summary>締日</summary>
        public int srcSHIMEBI;


        public void Clear()
        {
            Ord = "";
            EngID = "";
            CusCD = "";
            YMArea = false;
            srcSaleYM = "";
            srcSaleYMf = "";
            srcSaleYMt = "";
            srcEngIDt = "";
            CDArea = false;
            srcCUSCD = "";
            srcCUSCDf = "";
            srcCUSCDt = "";
            srcSHIMEBI = 0;
        }

    }
}