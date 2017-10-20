using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sugitec.Logics
{
    public class dtoReq010
    {
        /// <summary>請求締日</summary>
        public int CutOffDay = 0;
        /// <summary>得意先</summary>
        public string CusCode = string.Empty;
        /// <summary>同期フラグ</summary>
        public int SyncFlf = 0;
        /// <summary>タイムスタンプ</summary>
        public string TimeStamp = string.Empty;
    }
}
