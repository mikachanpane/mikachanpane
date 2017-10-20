using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sugitec.Common;

namespace Sugitec.Logics
{
    public class dtoRec020
    {
        public string CusCode="";
        public string CusCodeFrm="";
        public string CusCodeTo="";
        public string RecYM="";
        public string RecYMFrm="";
        public string RecYMTo="";
        public bool CusArea = false;
        public bool RecArea = false;
        public int Deposit = 0;

        public void Clear()
        {
            CusCode = "";
            CusCodeFrm = "";
            CusCodeTo = "";
            RecYM = "";
            RecYMFrm = "";
            RecYMTo = "";

        }
    }
}
