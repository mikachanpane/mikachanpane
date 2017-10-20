using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sugitec.Common;
using System.Data;


namespace Sugitec.Logics
{
    /// <summary>
    /// コード区分Mサービスクラス
    /// </summary>
    public class srvMnt030 : srvBase
    {
        /// <summary>
        /// コード区分マスタの区分を取得（CODE="00"のみ取得）
        /// </summary>
        /// <returns>取得結果のDataTable</returns>
        public DataTable KbnSelect()
        {
            try
            {
                //SQL文を構築
                StringBuilder Sql = new StringBuilder();

                Sql.AppendFormat("SELECT 0 as SEL0, KBN, CONTENT");
                // FROM
                Sql.Append(" FROM M_CODE");
                // WHERE
                Sql.Append(" WHERE DEL_FLG = 0");
                   // AND
                Sql.Append(" AND CODE = '00'");
                //結果を取得
                return base.ExecuteSelect(Sql.ToString());
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// コード区分マスタのコードを取得（CODE="00"以外を取得）
        /// </summary>
        /// <returns>取得結果のDataTable</returns>
        /// <param name="kbn">区分</param>
        public DataTable CodeSelect(string kbn)
        {
            try
            {
                //SQL文を構築
                StringBuilder Sql = new StringBuilder();

                Sql.AppendFormat("SELECT 0 as SEL0, CODE, CONTENT");
                // FROM
                Sql.Append(" FROM M_CODE");
                // WHERE
                Sql.Append(" WHERE DEL_FLG = 0");
                // AND
                Sql.Append(" AND NOT CODE = '00'");
                // AND
                Sql.Append(" AND KBN = '");
                Sql.Append(kbn);
                Sql.Append("'");
                //結果を取得
                return base.ExecuteSelect(Sql.ToString());
            }
            catch
            {
                throw;
            }
        }


        /// <summary>
        /// コード区分Mの追加
        /// </summary>
        /// <param name="dto">Mnt030用のDTO</param>
        public void Insert(dtoMnt030 dto)
        {
            try
            {
                //主キーの重複チェック
                System.Text.StringBuilder Sql = new StringBuilder();
                if(dto.Code == "00")
                {
                    Sql.AppendFormat("SELECT KBN");
                    // FROM
                    Sql.Append(" FROM M_CODE");
                    // WHERE
                    Sql.Append(" WHERE CODE = '00'");
                    // AND
                    Sql.Append(" AND KBN = '");
                    Sql.Append(dto.Kbn);
                    Sql.Append("'");
                    DataTable dt = base.ExecuteSelect(Sql.ToString());
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("この区分は、すでに存在しています", "コード区分登録", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    Sql.AppendFormat("SELECT CODE");
                    // FROM
                    Sql.Append(" FROM M_CODE");
                    // WHERE
                    Sql.Append(" WHERE CODE = '");
                    Sql.Append(dto.Code);
                    Sql.Append("'");
                    // AND
                    Sql.Append(" AND KBN = '");
                    Sql.Append(dto.Kbn);
                    Sql.Append("'");
                    DataTable dt = base.ExecuteSelect(Sql.ToString());
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("このコードは、すでに存在しています", "コード区分登録", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                
                //SQL文を構築
                Sql.Clear();
                Sql.AppendFormat("INSERT INTO M_CODE (KBN,CODE,CONTENT,DEL_FLG,SYNC_FLG,TIME_STAMP)");
                Sql.AppendFormat(" VALUES (");
                Sql.AppendFormat(" '").Append(dto.Kbn).Append("',");
                Sql.AppendFormat(" '").Append(dto.Code).Append("',");
                Sql.AppendFormat(" '").Append(dto.Content).Append("',");
                Sql.AppendFormat(" '").Append(dto.DEL_FLG).Append("',");
                Sql.AppendFormat(" '").Append(dto.SYNC_FLG).Append("',");
                Sql.AppendFormat(" '").Append(dto.TIMESTAMP).Append("' )");

                //更新を実行
                base.ExecuteAction(Sql.ToString());
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// コード区分Mの更新
        /// </summary>
        /// <param name="dto">Mnt030用のDTO</param>
        public void Update(dtoMnt030 dto, String str)
        {
            try
            {
                //SQL文を構築
                System.Text.StringBuilder Sql = new StringBuilder();

                Sql.Append("Update M_CODE SET ");           
                
                if (str == "")
                {
                    
                    Sql.AppendFormat(" CONTENT = '{0}' ", dto.Content);
                    Sql.AppendFormat(",SYNC_FLG = {0} ", dto.SYNC_FLG);
                    Sql.AppendFormat(",TIME_STAMP = '").Append(dto.TIMESTAMP).Append("'");
                    Sql.AppendFormat(" WHERE KBN = '{0}' ", dto.Kbn);
                    Sql.AppendFormat(" AND CODE = '{0}' ", dto.Code);
                }
                else
                {
                    Sql.AppendFormat(" CONTENT = '{0}' ", dto.Content);
                    Sql.AppendFormat(",SYNC_FLG = {0} ", dto.SYNC_FLG);
                    Sql.AppendFormat(",TIME_STAMP = '").Append(dto.TIMESTAMP).Append("'");
                    Sql.AppendFormat(" WHERE KBN = '{0}' ", str);
                    Sql.AppendFormat(" AND CODE = '{0}' ", dto.Code);
                }

                //更新を実行
                ExecuteAction(Sql.ToString());
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// コード区分Mの削除 
        /// </summary>
        /// <param name="dt">データテーブル</param>
        public void Delete(DataTable dt, String str)
        {
            try
            {
                List<string> SqlList = new List<string>();
                StringBuilder Sql = new StringBuilder();
                string tmsp = DateTime.Now.ToString("yyyyMMddHHmmss");

                //削除対象のSQLを構築
                foreach (DataRow row in dt.Rows)
                {
                    //  チェックボックスの入った行のCODE を探す
                    if (row[0].ToString() == "1")
                    {
                        Sql.Clear();

                        Sql.AppendFormat("UPDATE M_CODE");
                        Sql.AppendFormat(" SET DEL_FLG = 1 ");
                        Sql.AppendFormat(",SYNC_FLG = {0} ", (int)clsDefine.OperatingStatus);
                        Sql.AppendFormat(",TIME_STAMP = '{0}' ", tmsp);
                        if (str == "")
                        {
                            Sql.AppendFormat(" WHERE KBN = '{0}' ", row[1].ToString());
                        }
                        else
                        {
                            Sql.AppendFormat(" WHERE KBN = '{0}' ", str);
                            Sql.AppendFormat(" AND CODE = '{0}' ", row[1].ToString());
                        }
                        
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
