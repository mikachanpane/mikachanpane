using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sugitec.Common;


namespace Sugitec.Logics
{
    /// <summary>
    /// 税率Mサービスクラス
    /// </summary>
    public class srvMnt040 : srvBase
    {
        /// <summary>
        /// 税率Mを取得
        /// </summary>
        /// <returns>取得結果のDataTable</returns>
        public DataTable Select()
        {
            try
            {
                //SQL文を構築
                StringBuilder Sql = new StringBuilder();

                //  SELECT
                Sql.Append("SELECT 0 as SEL0, CODE, " );
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    Sql.Append("IIF(START_YMD = '','',FORMAT(CONVERT(DateTime,START_YMD),'yyyy/MM/dd')) AS START_YMD ");
                }
                else
                {
                    Sql.Append("FORMAT(START_YMD,'@@@@/@@/@@') AS START_YMD ");
                }   
                
                Sql.Append(", TAX_RATE, VALID_FLG, SYNC_FLG, TIME_STAMP");
                // FROM
                Sql.Append(" FROM M_TAX");
                // WHERE
                Sql.Append(" WHERE DEL_FLG = 0");
                //結果を取得
                return base.ExecuteSelect(Sql.ToString());
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 税率Mを追加
        /// </summary>
        /// <param name="dto">Mnt040用のDTO</param>
        public void Insert(dtoMnt040 dto)
        {
            try
            {
                //SQL文を構築
                System.Text.StringBuilder Sql = new StringBuilder();
                dto.CODE = base.NumberingTax().PadLeft(2,'0');
                Sql.Append("INSERT INTO M_TAX (CODE,START_YMD,TAX_RATE,VALID_FLG,DEL_FLG,SYNC_FLG,TIME_STAMP)");
                Sql.Append(" VALUES (");
                Sql.Append(" '").Append(dto.CODE).Append("',");
                Sql.Append(" '").Append(dto.START_YMD).Append("',");
                Sql.Append(" '").Append(dto.TAX_RATE).Append("',");
                Sql.Append(" '").Append(dto.VALID_FLG).Append("',");
                Sql.Append(" '").Append(0).Append("',");
                Sql.Append(" '").Append(dto.SYNC_FLG).Append("',");
                Sql.Append(" '").Append(dto.TIMESTAMP).Append("' )");

                //更新を実行
                ExecuteAction(Sql.ToString());
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 税率Mを更新
        /// </summary>
        /// <param name="dto">Mnt040用のDTO</param>
        public void Update(dtoMnt040 dto)
        {
            try
            {
                //SQL文を構築
                System.Text.StringBuilder Sql = new StringBuilder();

                // UPDATA テーブル名を設定
                Sql.Append("UPDATE M_TAX");
                //  SET
                Sql.AppendFormat(" SET START_YMD = '{0}'", dto.START_YMD);
                Sql.AppendFormat(", TAX_RATE = '{0}'", dto.TAX_RATE);
                Sql.AppendFormat(", VALID_FLG = {0}", dto.VALID_FLG);
                Sql.AppendFormat(", SYNC_FLG = {0}", dto.SYNC_FLG);
                Sql.AppendFormat(",TIME_STAMP = '").Append(dto.TIMESTAMP).Append("'");
                //  WHERE ※主キーを設定
                Sql.AppendFormat(" WHERE CODE =  '{0}'", dto.CODE);

                //更新を実行
                ExecuteAction(Sql.ToString());
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 税率Mを削除
        /// </summary>
        /// <param name="dt">データテーブル</param>
        public void Delete(DataTable dt)
        {
            try
            {
                List<string> SqlList = new List<string>();
                StringBuilder Sql = new StringBuilder();

                //削除対象のSQLを構築
                foreach (DataRow row in dt.Rows)
                {
                    //  チェックボックスの入った行を探す
                    if (row[0].ToString() == "1")
                    {
                        Sql.Clear();
                        // UPDATE テーブル名を設定
                        Sql.Append("UPDATE M_TAX");
                        // SET
                        Sql.AppendFormat(" SET DEL_FLG = '1'");
                        //WHERE
                        Sql.AppendFormat(" WHERE CODE = '{0}'", row[1].ToString());
                        SqlList.Add(Sql.ToString());
                    }
                }

                //更新を実行
                ExecuteAction(SqlList);
            }
            catch
            {
                throw;
            }
        }
    }
}
