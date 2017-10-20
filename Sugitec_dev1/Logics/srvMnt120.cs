using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sugitec.Common;
using System.Windows.Forms;
using Sugitec.Logics;
using System.Data;

namespace Sugitec.Logics
{
    public class srvMnt120 : srvBase
    {
        /// <summary>
        /// 所属グループMを取得
        /// </summary>
        /// <returns>取得結果のDataTable</returns>
        public DataTable Select()
        {
            try
            {
                //SQL文を構築
                StringBuilder Sql = new StringBuilder();

                //  SELECT
                Sql.Append("SELECT 0 as SEL0, A.GROUP_CODE, A.GROUP_NAME,");
                Sql.Append(" A.DAILY_ALLOWANCE, A.ACCOMMODATION, A.TRAVEL_KBN, B.CONTENT");
                // FROM
                Sql.Append(" FROM M_GROUP AS A");
                Sql.Append(" LEFT JOIN M_CODE AS B");
                Sql.Append(" ON (B.KBN = 'M02'");
                Sql.Append(" AND A.TRAVEL_KBN = B.CODE)");
                // WHERE
                Sql.Append(" WHERE A.DEL_FLG = 0");
                Sql.Append(" ORDER BY A.GROUP_CODE ");

                //結果を取得
                return base.ExecuteSelect(Sql.ToString());
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 所属グループMを追加
        /// </summary>
        /// <param name="dto">Mnt120用のDTO</param>
        public void Insert(dtoMnt120 dto)
        {
            try
            {
                dto.Code = dto.Code.PadLeft(3, '0');
                //SQL文を構築
                System.Text.StringBuilder Sql = new StringBuilder();
                Sql.Append("SELECT GROUP_CODE");
                Sql.Append(" FROM M_GROUP");
                // WHERE
                Sql.Append(" WHERE GROUP_CODE = '");                
                Sql.Append(dto.Code);
                Sql.Append("'");
                DataTable dt = base.ExecuteSelect(Sql.ToString());
                if (dt.Rows.Count > 0)
                {
                    throw new Exception("このグループコードは、すでに存在しています");
                }
                Sql.Clear();
                Sql.Append("INSERT INTO M_GROUP (GROUP_CODE,GROUP_NAME,TRAVEL_KBN,DAILY_ALLOWANCE,ACCOMMODATION,DEL_FLG,SYNC_FLG,TIME_STAMP)");
                Sql.Append(" VALUES (");
                Sql.Append(" '").Append(dto.Code).Append("',");
                Sql.Append(" '").Append(dto.Name).Append("',");
                Sql.Append(" '").Append(dto.KotsuKBN).Append("',");
                Sql.Append(" '").Append(dto.perdiem).Append("',");
                Sql.Append(" '").Append(dto.accomodation).Append("',");
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
        /// 所属グループMを更新
        /// </summary>
        /// <param name="dto">Mnt120用のDTO</param>
        public void Update(dtoMnt120 dto)
        {
            try
            {
                //SQL文を構築
                System.Text.StringBuilder Sql = new StringBuilder();

                // UPDATA テーブル名を設定
                Sql.Append("UPDATE M_GROUP");
                //  SET
                Sql.AppendFormat(" SET GROUP_NAME = '{0}'", dto.Name);
                Sql.AppendFormat(", TRAVEL_KBN = '{0}'", dto.KotsuKBN);
                Sql.AppendFormat(", DAILY_ALLOWANCE = '{0}'", dto.perdiem);
                Sql.AppendFormat(", ACCOMMODATION = '{0}'", dto.accomodation);
                Sql.AppendFormat(", SYNC_FLG = {0}", dto.SYNC_FLG);
                Sql.AppendFormat(",TIME_STAMP = '").Append(dto.TIMESTAMP).Append("'");
                //  WHERE ※主キーを設定
                Sql.AppendFormat(" WHERE GROUP_CODE =  '{0}'", dto.Code);
                //更新を実行
                ExecuteAction(Sql.ToString());
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 所属グループMを削除
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
                        Sql.Append("UPDATE M_GROUP");
                        // SET
                        Sql.AppendFormat(" SET DEL_FLG = 1");
                        //WHERE
                        Sql.AppendFormat(" WHERE GROUP_CODE = '{0}'", row[1].ToString());
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
        /// <summary>
        /// コード区分Mの取得
        /// コンボボックスに表示させたい区分をDataTable型で取得する拡張機能です
        /// </summary>
        /// <param name="DataKbn">カテゴリ区分</param>
        /// <returns>取得結果のDataTable</returns>
        public DataTable GetCodeM(string Kbn)
        {
            try
            {
                //SQL文を構築
                StringBuilder Sql = new StringBuilder();
                Sql.AppendFormat("Select CODE, CONTENT");
                Sql.AppendFormat("  From M_CODE ");
                Sql.AppendFormat(" Where KBN  = '{0}'", Kbn);
                Sql.AppendFormat("   And CODE <> '00'");

                //結果を取得
                return base.ExecuteSelect(Sql.ToString());

            }
            catch
            {
                throw;
            }
        }
    }
}