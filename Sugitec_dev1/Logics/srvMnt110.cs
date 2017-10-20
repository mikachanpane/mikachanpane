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
    public class srvMnt110 : srvBase
    {
        
        /// <summary>
        /// データ更新(UPDATE文発行)
        /// </summary>
        /// <param name="dto"></param>
        public void Update(dtoMnt110 dto)
        {
            try
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("Update M_ENGINEER SET ");
                sb.AppendFormat(" NAME = '{0}' ", dto.Name);
                sb.AppendFormat(",INITIAL = '{0}' ", dto.Initial);
                sb.AppendFormat(",BIRTHDAY = '{0}' ", dto.BirthDay);
                sb.AppendFormat(",SEX = {0} ",dto.SEX);
                sb.AppendFormat(",POST = '{0}' ", dto.post);
                sb.AppendFormat(",ADDRESS1 = '{0}' ", dto.Address1);
                sb.AppendFormat(",ADDRESS2 = '{0}' ", dto.Address2);
                sb.AppendFormat(",HOME_TEL = '{0}' ", dto.Home_TEL);
                sb.AppendFormat(",MOBILE_TEL = '{0}' ", dto.Mobile_TEL);
                sb.AppendFormat(",BELONGS_KBN = '{0}' ", dto.Belongs_KBN);
                sb.AppendFormat(",GROUP_CODE = '{0}' ", dto.Group_CODE);
                sb.AppendFormat(",SYNC_FLG = {0} ",dto.SYNC_FLG);
                sb.AppendFormat(",TIME_STAMP = '").Append(dto.TIMESTAMP).Append("'");
                sb.Append(" WHERE ID = '").Append(dto.ID).Append("'");

                base.ExecuteAction(sb.ToString());
             }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// データ取得(SELECT文発行)
        /// </summary>
        /// <param name="dt">検索結果を格納するデータテーブル</param>
        /// <returns>検索結果</returns>
        public DataTable Select()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Select '0' as chkDel ");
                sb.Append(",a.ID ");
                sb.Append(",a.NAME ");
                sb.Append(",a.INITIAL ");
                
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.Append(",IIF(a.BIRTHDAY = '','',FORMAT(CONVERT(DateTime,a.BIRTHDAY),'yyyy/MM/dd')) AS BIRTHDAY ");
                    sb.Append(",case a.SEX when 0 then '男' else '女' end SEX ");
                }
                else
                {
                    sb.Append(",FORMAT(a.BIRTHDAY,'@@@@/@@/@@') AS BIRTHDAY ");
                    sb.Append(",iif(a.SEX=0 ,'男' ,'女') AS SEX ");
                }
                sb.Append(",a.POST ");
                sb.Append(",a.ADDRESS1 ");
                sb.Append(",a.ADDRESS2 ");
                sb.Append(",a.HOME_TEL ");
                sb.Append(",a.MOBILE_TEL ");
                sb.Append(",a.BELONGS_KBN ");
                sb.Append(",a.GROUP_CODE ");
                sb.Append(" FROM M_ENGINEER a ");
                sb.Append(" WHERE DEL_FLG = 0");
                
                DataTable dt = base.ExecuteSelect(sb.ToString());
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// データ削除(削除フラグ=1を設定する)
        /// </summary>
        /// <param name="dt">データテーブル</param>
        public void delete(DataTable dt)
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

                        Sql.AppendFormat("UPDATE M_ENGINEER");
                        Sql.AppendFormat(" SET DEL_FLG = 1 ");
                        Sql.AppendFormat(",SYNC_FLG = {0} ", (int)clsDefine.OperatingStatus);
                        Sql.AppendFormat(",TIME_STAMP = '{0}' ",tmsp);
                        Sql.AppendFormat(" WHERE ID = '{0}' ", row[1].ToString());

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
        /// データ挿入(INERT文発行)
        /// </summary>
        /// <param name="dto">入力データ</param>
        public void Insert(dtoMnt110 dto)
        {
            try {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                //SQL文を構築
                sb.Append("SELECT ID");
                sb.Append(" FROM M_ENGINEER");
                // WHERE
                sb.Append(" WHERE ID = '");
                sb.Append(dto.ID);
                sb.Append("'");
                DataTable dt = base.ExecuteSelect(sb.ToString());
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("このIDは、すでに存在しています", "技術者登録", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sb.Clear();
                sb.Append("INSERT INTO M_ENGINEER (ID,NAME,INITIAL,BIRTHDAY,SEX,POST,ADDRESS1,ADDRESS2,HOME_TEL,MOBILE_TEL,BELONGS_KBN,GROUP_CODE,DEL_FLG,SYNC_FLG,TIME_STAMP)");
                sb.Append(" VALUES (");
                sb.Append(" '").Append(dto.ID).Append( "',");
                sb.Append(" '").Append(dto.Name).Append("',");
                sb.Append(" '").Append(dto.Initial).Append("',");
                sb.Append(" '").Append(dto.BirthDay).Append("',");
                sb.Append(" '").Append(dto.SEX).Append("',");
                sb.Append(" '").Append(dto.post).Append("',");
                sb.Append(" '").Append(dto.Address1).Append("',");
                sb.Append(" '").Append(dto.Address2).Append("',");
                sb.Append(" '").Append(dto.Home_TEL).Append("',");
                sb.Append(" '").Append(dto.Mobile_TEL).Append("',");
                sb.Append(" '").Append(dto.Belongs_KBN).Append("',");
                sb.Append(" '").Append(dto.Group_CODE).Append("',");
                sb.Append(" '").Append(dto.DEL_FLG).Append("',");
                sb.Append(" '").Append(dto.SYNC_FLG).Append("',");
                sb.Append(" '").Append(dto.TIMESTAMP).Append("' )");
                base.ExecuteAction(sb.ToString());
            }
                catch (Exception ex)
            {
                throw ex;
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

        /// <summary>
        /// グループコードMの取得
        /// コンボボックスに表示させたい区分をDataTable型で取得する拡張機能です
        /// </summary>
        /// <param name="DataKbn">カテゴリ区分</param>
        /// <returns>取得結果のDataTable</returns>
        public DataTable GetGroupCdM()
        {
            try
            {
                //SQL文を構築
                StringBuilder Sql = new StringBuilder();
                Sql.AppendFormat("Select GROUP_CODE, GROUP_NAME");
                Sql.AppendFormat("  From M_GROUP ");

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
