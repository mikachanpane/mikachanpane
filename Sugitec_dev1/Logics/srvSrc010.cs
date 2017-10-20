using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sugitec.Common;
using Sugitec.Logics;
using System.Data;

namespace Sugitec.Logics
{
    public class srvSrc010 : srvBase
    {
        /// <summary>
        /// コード検索(SELECT文発行)
        /// </summary>
        /// <param name="dto">検索条件</param>
        /// <returns>検索結果</returns>
        public DataTable Select(dtoSrc010 dto)
        {
            try {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                string sCode = (string.IsNullOrEmpty(dto.CodFrm)) ? "00000000" : dto.CodFrm;
                string eCode = (string.IsNullOrEmpty(dto.CodTo)) ? "99999999" : dto.CodTo;

                if (dto.Target==FEATURES.SRC010)
                {
                    sb.AppendFormat("Select CODE, NAME FROM M_CUSTOMER ");
                    sb.AppendFormat(" Where DEL_FLG = 0 ");
                    sb.AppendFormat("   And CODE Between '{0}' And '{1}' ", sCode, eCode);
                    if (!string.IsNullOrEmpty(dto.Name))
                    {
                        sb.AppendFormat("   And NAME LIKE '%{0}%'", dto.Name);
                    }
                }
                else
                {
                    sb.AppendFormat("Select ID As CODE, NAME FROM M_ENGINEER ");
                    sb.AppendFormat(" Where DEL_FLG = 0 ");
                    sb.AppendFormat("   And ID Between '{0}' And '{1}' ", sCode, eCode);
                    if (!string.IsNullOrEmpty(dto.Name))
                    {
                        sb.AppendFormat("   And NAME LIKE '%{0}%'", dto.Name);
                    }
                }
                return base.ExecuteSelect(sb.ToString());

            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
