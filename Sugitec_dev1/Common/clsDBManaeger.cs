using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
using System.Data;

namespace Sugitec.Common
{
    /// <summary>
    /// データベース操作クラス
    /// </summary>
    public class clsDBManaeger : IDisposable
    {
        /// <summary>データベース操作</summary>
        private IDBManager DB;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal clsDBManaeger()
        {
            //オンライン、オフラインで使用するＤＢを切り替える
            if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
            {
                DB = new clsSVDBManaeger();
            }
            else
            {
                DB = new clsCLDBManaeger();
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal clsDBManaeger(OperatStatus OPS)
        {
            //オンライン、オフラインで使用するＤＢを切り替える
            if (OPS == OperatStatus.ONLINE)
            {
                DB = new clsSVDBManaeger();
            }
            else
            {
                DB = new clsCLDBManaeger();
            }
        }

        /// <summary>
        /// データベースへの接続
        /// </summary>
        internal void DBOpen()
        {
            try
            {
                DB.Open();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// データベースから切断
        /// </summary>
        internal void DBClose()
        {
            try
            {
                DB.Close();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// トランザクションをコミット
        /// </summary>
        protected void TrnCommit()
        {
            try
            {
                DB.Commit();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 選択クエリ―を実行
        /// </summary>
        /// <param name="SqlString">SQL文</param>
        /// <returns>実行結果のデータテーブル</returns>
        protected DataTable ExecuteSelect(string SqlString)
        {
            try
            {
                return DB.ExecuteSelect(SqlString);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// アクションクエリ―を実行
        /// </summary>
        /// <param name="SqlString">SQL文</param>
        /// <param name="IsAutoCommit">自動コミットを行うか</param>
        protected void ExecuteAction(string SqlString, bool IsAutoCommit = true)
        {
            try
            {
                DB.ExecuteAction(SqlString, IsAutoCommit);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// アクションクエリ―を実行
        /// </summary>
        /// <param name="SqlList">複数のSQL文</param>
        /// <param name="IsAutoCommit">自動コミットを行うか</param>
        protected void ExecuteAction(List<string> SqlList, bool IsAutoCommit = true)
        {
            try
            {
                DB.ExecuteAction(SqlList, IsAutoCommit);
            }
            catch
            {
                throw;
            }
        }

        #region IDisposable Support

        private bool disposedValue = false; // 重複する呼び出しを検出するには

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    //マネージ状態を破棄します (マネージ オブジェクト)。
                    DB.Close();
                }

                //アンマネージ リソース (アンマネージ オブジェクト) を解放し、下のファイナライザーをオーバーライドします。
                //大きなフィールドを null に設定します。
                disposedValue = true;
            }
        }

        //上の Dispose(bool disposing) にアンマネージ リソースを解放するコードが含まれる場合にのみ、ファイナライザーをオーバーライドします。
        //~clsDBManaeger()
        //{
        //    // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
        //    Dispose(false);
        //}

        // このコードは、破棄可能なパターンを正しく実装できるように追加されました。
        public void Dispose()
        {
            // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
            Dispose(true);
            // 上のファイナライザーがオーバーライドされる場合は、次の行のコメントを解除してください。
            // GC.SuppressFinalize(this);
        }
        #endregion

        /// <summary>
        /// データベース操作インターフェイス
        /// </summary>
        private interface IDBManager
        {
            /// <summary>
            /// データベースへの接続
            /// </summary>
            void Open();

            /// <summary>
            /// データベースから切断
            /// </summary>
            void Close();

            /// <summary>
            /// トランザクションをコミット
            /// </summary>
            void Commit();

            /// <summary>
            /// 選択クエリ―を実行
            /// </summary>
            /// <param name="SqlString">SQL文</param>
            /// <returns>実行結果のデータテーブル</returns>
            DataTable ExecuteSelect(string SqlString);

            /// <summary>
            /// アクションクエリ―を実行
            /// </summary>
            /// <param name="SqlString">SQL文</param>
            /// <param name="IsAutoCommit">自動コミットを行うか</param>
            void ExecuteAction(string SqlString, bool IsAutoCommit);

            /// <summary>
            /// アクションクエリ―を実行
            /// </summary>
            /// <param name="SqlList">複数のSQL文</param>
            /// <param name="IsAutoCommit">自動コミットを行うか</param>
            void ExecuteAction(List<string> SqlString, bool IsAutoCommit);
        }

        /// <summary>
        /// サーバＤＢ接続用クラス
        /// </summary>
        private class clsSVDBManaeger : IDBManager
        {
            // グローバル変数
            private SqlConnection Con = new SqlConnection();
            private SqlTransaction trn = null;

            //app_configからDB接続のパスワードを取得
            private string ServerName = ConfigurationManager.AppSettings["SV_ServerName"];
            private string UserID = ConfigurationManager.AppSettings["SV_UserId"];
            private string Password = ConfigurationManager.AppSettings["SV_Password"];
            private string DatabaseName = ConfigurationManager.AppSettings["SV_DBName"];

            /// <summary>
            /// SQLServerへの接続
            /// </summary>
            /// <remarks></remarks>
            public void Open()
            {
                try
                {
                    string St = String.Format("Server={0};User ID={1};Password={2};Initial Catalog={3}", ServerName, UserID, Password, DatabaseName);
                    //接続文字列の設定
                    Con.ConnectionString = St;

                    //DBを開く
                    Con.Open();

                }
                catch
                {
                    throw new Exception("SQL Serverへの接続に失敗しました");
                }
            }

            /// <summary>
            /// SQLServerから切断
            /// </summary>
            /// <remarks></remarks>
            public void Close()
            {

                try
                {
                    ///既に開放されている場合はそのまま終わる
                    if (Con == null)
                    {
                        return;
                    }

                    //トランザクションの確認
                    if (trn != null)
                    {
                        //トランザクションが未処理の場合はロールバックする
                        if (trn.Connection != null)
                        {
                            trn.Rollback();
                        }
                        //トランザクションを解放
                        trn.Dispose();
                    }

                    //DBの接続を切断する
                    if (Con.State != System.Data.ConnectionState.Closed)
                    {
                        Con.Close();
                    }

                    //コネクションを解放
                    Con.Dispose();

                }
                catch
                {
                    throw new Exception("SQL Serverからの切断に失敗しました");
                }
            }

            /// <summary>
            /// トランザクションをコミット
            /// </summary>
            public void Commit()
            {
                try
                {
                    if (trn == null || trn.Connection == null)
                    {
                        return;
                    }

                    trn.Commit();

                }
                catch
                {
                    throw new Exception("SQL Serverへのコミットに失敗しました");
                }

            }

            /// <summary>
            /// 選択クエリ―を実行
            /// </summary>
            /// <param name="SqlString">SQL文</param>
            /// <returns>実行結果のデータテーブル</returns>
            public DataTable ExecuteSelect(string SqlString)
            {

                try
                {
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand(SqlString, Con, trn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            //データテーブルにセット
                            da.Fill(dt);
                        }
                        return dt;
                    }
                }
                catch
                {
                    throw new Exception("SQL Serverからのデータ取得に失敗しました");
                }

            }

            /// <summary>
            /// アクションクエリ―を実行
            /// </summary>
            /// <param name="SqlString">SQL文</param>
            public void ExecuteAction(string SqlString, bool IsAutoCommit)
            {
                try
                {
                    if (trn == null || trn.Connection == null)
                    {
                        trn = Con.BeginTransaction();
                    }

                    using (SqlCommand cmd = new SqlCommand(SqlString, Con, trn))
                    {
                        //SQL実行
                        cmd.ExecuteNonQuery();
                    }

                    if (IsAutoCommit)
                    {
                        trn.Commit();
                    }

                }
                catch
                {
                    throw new Exception("SQL Serverへの更新に失敗しました");
                }
            }

            /// <summary>
            /// アクションクエリ―を実行
            /// </summary>
            /// <param name="SqlList">複数のSQL文</param>
            public void ExecuteAction(List<string> SqlList, bool IsAutoCommit)
            {
                try
                {
                    if (trn == null || trn.Connection == null)
                    {
                        trn = Con.BeginTransaction();
                    }

                    foreach (string sql in SqlList)
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, Con, trn))
                        {
                            //SQL実行
                            cmd.ExecuteNonQuery();
                        }
                    }

                    if (IsAutoCommit)
                    {
                        trn.Commit();
                    }
                }
                catch
                {
                    throw new Exception("SQL Serverへの更新に失敗しました");
                }
            }

        }

        /// <summary>
        /// ローカルＤＢ接続用クラス
        /// </summary>
        private class clsCLDBManaeger : IDBManager
        {
            // グローバル変数
            private OleDbConnection Con = new OleDbConnection();
            private OleDbTransaction trn;

            //app_configからDB接続のパスワードを取得
            private string Provider = ConfigurationManager.AppSettings["CL_Provider"];
            private string DBPath = ConfigurationManager.AppSettings["CL_DBPath"];
            private string DBName = ConfigurationManager.AppSettings["CL_DBName"];

            /// <summary>
            /// LocalDBへの接続
            /// </summary>
            /// <remarks></remarks>
            public void Open()
            {
                try
                {
                    string St = String.Format(@"Provider={0}; Data Source={1}\{2}", Provider, DBPath, DBName);
                    //接続文字列の設定
                    Con.ConnectionString = St;

                    //DBを開く
                    Con.Open();

                }
                catch
                {
                    throw new Exception("LocalDBへの接続に失敗しました");
                }
            }

            /// <summary>
            /// LocalDBから切断
            /// </summary>
            /// <remarks></remarks>
            public void Close()
            {

                try
                {
                    ///既に開放されている場合はそのまま終わる
                    if (Con == null)
                    {
                        return;
                    }

                    //トランザクションの確認
                    if (trn != null)
                    {
                        //トランザクションが未処理の場合はロールバックする
                        if (trn.Connection != null)
                        {
                            trn.Rollback();
                        }
                        //トランザクションを解放
                        trn.Dispose();
                    }

                    //DBの接続を切断する
                    if (Con.State != System.Data.ConnectionState.Closed)
                    {
                        Con.Close();
                    }

                    //コネクションを解放
                    Con.Dispose();

                }
                catch
                {
                    throw new Exception("LocalDBからの切断に失敗しました");
                }
            }

            /// <summary>
            /// トランザクションをコミット
            /// </summary>
            public void Commit()
            {
                try
                {
                    if(trn == null || trn.Connection == null)
                    {
                        return;
                    }

                    trn.Commit();

                }
                catch
                {
                    throw new Exception("LocalDBへのコミットに失敗しました");
                }

            }

            /// <summary>
            /// 選択クエリ―を実行
            /// </summary>
            /// <param name="SqlString">SQL文</param>
            /// <returns>実行結果のデータテーブル</returns>
            public DataTable ExecuteSelect(string SqlString)
            {

                try
                {
                    DataTable dt = new DataTable();

                    using (OleDbCommand cmd = new OleDbCommand(SqlString, Con, trn))
                    {
                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            //データテーブルにセット
                            da.Fill(dt);
                        }
                        return dt;
                    }
                }
                catch
                {
                    throw new Exception("LocalDBからのデータ取得に失敗しました");
                }

            }

            /// <summary>
            /// アクションクエリ―を実行
            /// </summary>
            /// <param name="SqlString">SQL文</param>
            /// <param name="IsAutoCommit">自動コミットを行うか</param>
            public void ExecuteAction(string SqlString, bool IsAutoCommit)
            {
                try
                {
                    if (trn == null || trn.Connection == null)
                    {
                        trn = Con.BeginTransaction();
                    }

                    using (OleDbCommand cmd = new OleDbCommand(SqlString, Con, trn))
                    {
                        //SQL実行
                        cmd.ExecuteNonQuery();
                    }

                    if (IsAutoCommit)
                    {
                        trn.Commit();
                    }
                }
                catch
                {
                    throw new Exception("LocalDBへの更新に失敗しました");
                }
            }

            /// <summary>
            /// アクションクエリ―を実行
            /// </summary>
            /// <param name="SqlList">複数のSQL文</param>
            /// <param name="IsAutoCommit">自動コミットを行うか</param>
            public void ExecuteAction(List<string> SqlList, bool IsAutoCommit)
            {
                try
                {
                    if (trn == null || trn.Connection == null)
                    {
                        trn = Con.BeginTransaction();
                    }

                    foreach (string sql in SqlList)
                    {
                        using (OleDbCommand cmd = new OleDbCommand(sql, Con, trn))
                        {
                            //SQL実行
                            cmd.ExecuteNonQuery();
                        }
                    }
                    trn.Commit();
                }
                catch
                {
                    throw new Exception("LocalDBへの更新に失敗しました");
                }
            }

        }

    }

}