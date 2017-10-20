using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sugitec.Common;
using System.IO;

namespace Sugitec.Logics
{
    /// <summary>
    /// データ同期サービスクラス
    /// </summary>
    public class srvDat010
    {

        /// <summary>
        /// テーブル同期処理(Local＞ONLINE)
        /// </summary>
        /// <param name="tablename">同期するテーブル名</param>
        /// <param name="Pkey">主キーリスト</param>
        public void SyncData(string tablename, List<string> Pkey)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                //ローカルＤＢからを取得
                DataTable cllocal = new DataTable();
                sb.Clear();
                sb.AppendFormat("SELECT * FROM {0} WHERE SYNC_FLG = {1}", tablename, OperatStatus.OFFLINE);
                using (clsDB clDB = new clsDB(OperatStatus.OFFLINE))
                {
                    cllocal = clDB.ExecuteSelect(sb.ToString());
                }
                if (cllocal.Rows.Count == 0)
                {
                    return;
                }

                //ローカルＤＢからサーバＤＢへ更新
                using (clsDB svDB = new clsDB(OperatStatus.ONLINE))
                {
                    int Mode;
                    List<string> CD = new List<string>();
                    foreach (DataRow ror in cllocal.Rows)
                    {
                        CD.Clear();
                        CD.Add(ror[Pkey[0]].ToString());
                        for (int idx = 1; idx < Pkey.Count; idx++)
                        {
                            CD.Add(ror[Pkey[idx]].ToString());
                        }

                        //サーバのテーブル情報を取得しチェック
                        Mode = svDB.selectTransaction(tablename, Pkey, CD, ror["TIME_STAMP"].ToString());

                        //存在しなければ追加、存在しかつローカル側が新しい場合更新する
                        if (Mode == 1)
                        {
                            sb.Clear();
                            sb.AppendFormat("INSERT INTO {0} VALUES (", tablename);

                            foreach (DataColumn col in ror.Table.Columns)
                            {

                                //同期フラグはオンライン固定、数値型は'で囲まない、それ以外は''で囲む
                                switch (col.DataType.ToString())
                                {
                                    case "String":
                                    case "string":
                                        sb.AppendFormat("   {0} ,", ror[col.ColumnName].ToString());
                                        break;

                                    default:

                                        if (col.ColumnName == "SYNC_FLG")
                                        {
                                            sb.AppendFormat("   {0},", OperatStatus.ONLINE);
                                        }
                                        else
                                        {
                                            sb.AppendFormat("   {0},", (int)ror[col.ColumnName]);
                                        }
                                        break;
                                }
                            }

                            sb.Length = sb.Length - 1;
                            sb.Append(")");

                        }
                        else if (Mode == 2)
                        {
                            sb.Clear();

                            sb.AppendFormat("UPDATE {0} SET", tablename);

                            foreach (DataColumn col in ror.Table.Columns)
                            {
                                if (Pkey.IndexOf(col.ColumnName) != -1)
                                {
                                    continue;
                                }

                                //同期フラグはオンライン固定、数値型は'で囲まない、それ以外は''で囲む
                                switch (col.DataType.ToString())
                                {
                                    case "String":
                                    case "string":
                                        sb.AppendFormat("   {0} = '{1}',", col.ColumnName, ror[col.ColumnName].ToString());
                                        break;

                                    default:

                                        if (col.ColumnName == "SYNC_FLG")
                                        {
                                            sb.AppendFormat("   {0} = {1},", col.ColumnName, OperatStatus.ONLINE);
                                        }
                                        else
                                        {
                                            sb.AppendFormat("   {0} = {1},", col.ColumnName, ror[col.ColumnName].ToString());
                                        }
                                        break;
                                }

                            }
                            sb.Length = sb.Length - 1;
                            sb.AppendFormat("     WHERE {0} = '{1}'", Pkey[0], ror[Pkey[0]].ToString());
                            for (int idx = 1; idx < Pkey.Count; idx++)
                            {
                                sb.AppendFormat("    AND = {0} = '{1}'", Pkey[idx], ror[Pkey[idx]].ToString());
                            }

                        }

                        svDB.ExecuteAction(sb.ToString());
                    }

                    //コミット
                    svDB.TrnCommit();
                }


            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// テーブル同期処理(ONLINE＞Local)
        /// </summary>
        /// <param name="tablename">同期するテーブル名</param>
        /// <param name="Pkey">主キーリスト</param>
        public void SrvToLocal(string tablename, List<string> Pkey)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                //オンラインＤＢからを取得
                DataTable onlData = new DataTable();
                sb.Clear();
                sb.AppendFormat("SELECT * FROM {0}", tablename);
                using (clsDB SvDB = new clsDB(OperatStatus.ONLINE))
                {
                    onlData = SvDB.ExecuteSelect(sb.ToString());
                }
                if (onlData.Rows.Count == 0)
                {
                    return;
                }

                //サーバＤＢからローカルへ同期
                using (clsDB LcDB = new clsDB(OperatStatus.OFFLINE))
                {

                    sb.Clear();
                    sb.AppendFormat("DELETE * FROM {0}", tablename);

                    LcDB.ExecuteAction(sb.ToString());


                    List<string> CD = new List<string>();
                    foreach (DataRow ror in onlData.Rows)
                    {


                        sb.Clear();
                        sb.AppendFormat("INSERT INTO {0} VALUES (", tablename);

                        foreach (DataColumn col in ror.Table.Columns)
                        {

                            //同期フラグはオンライン固定、数値型は'で囲まない、それ以外は''で囲む
                            switch (col.DataType.ToString())
                            {
                                case "String":
                                case "string":
                                    sb.AppendFormat("   {0} ,", ror[col.ColumnName].ToString());
                                    break;

                                default:

                                    //if (col.ColumnName == "SYNC_FLG")
                                    //{
                                    //    sb.AppendFormat("   {0},", OperatStatus.ONLINE);
                                    //}
                                    //else
                                    //{
                                    sb.AppendFormat("   {0},", (int)ror[col.ColumnName]);
                                    //}
                                    break;
                            }
                        }

                        sb.Length = sb.Length - 1;
                        sb.Append(")");

                      
                        LcDB.ExecuteAction(sb.ToString());
                    }

                    //コミット
                    LcDB.TrnCommit();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }


        /// <summary>
        /// ACCDBファイル最適化処理
        /// </summary>
        public void compress()
        {
            try
            {
                Type typJro = Type.GetTypeFromProgID("DAO.DBEngine.120");
                dynamic clsJet;
                string DBpath = System.IO.Directory.GetCurrentDirectory() + "\\Database";                
                clsJet = Activator.CreateInstance(typJro);

                //最適化前DB
                string OldDb = DBpath + "\\Sugitec.accdb";
                //一時DB
                string NewDb = Path.GetTempPath() + "\\temp.accdb";

                clsJet.CompactDatabase(OldDb, NewDb, ";LANGID=0x0411;CP=932;COUNTRY=0", 128);
                //                Console.WriteLine("Finished Compacting Database");


                System.Runtime.InteropServices.Marshal.ReleaseComObject(clsJet);
                clsJet = null;

                //最適化したaccdbを書き戻す
                File.Copy(NewDb, OldDb, true);

            }
            catch
            {
                throw;
            }
            finally
            {
                //一時DBの削除
                System.IO.FileInfo cFileInfo = new System.IO.FileInfo(Path.GetTempPath() + "\\temp.accdb");

                // ファイルが存在しているか判断する
                if (cFileInfo.Exists)
                {
                    // 読み取り専用属性がある場合は、読み取り専用属性を解除する
                    if ((cFileInfo.Attributes & System.IO.FileAttributes.ReadOnly) == System.IO.FileAttributes.ReadOnly)
                    {
                        cFileInfo.Attributes = System.IO.FileAttributes.Normal;
                    }

                    // ファイルを削除する
                    cFileInfo.Delete();
                }
            }
        }






        /// <summary>
        /// データベース操作クラス
        /// </summary>
        private class clsDB : srvBase
        {
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="OPS"></param>
            public clsDB(OperatStatus OPS) : base(OPS)
            {
            }

            /// <summary>
            /// データを取得
            /// </summary>
            /// <param name="Sql">SQL文</param>
            /// <returns>結果</returns>
            public new DataTable ExecuteSelect(string Sql)
            {
                try
                {
                    return base.ExecuteSelect(Sql);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            /// <summary>
            /// アクションクエリ―を実行
            /// </summary>
            /// <param name="Sql">SQL文</param>
            public new void ExecuteAction(string Sql, bool IsAutoCommit = false)
            {
                try
                {
                    base.ExecuteAction(Sql, IsAutoCommit);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            /// <summary>
            /// トランザクションをコミット
            /// </summary>
            public new void TrnCommit()
            {
                try
                {
                    base.TrnCommit();
                }
                catch
                {
                    throw;
                }
            }


            /// <summary>
            /// データ処理の選択
            /// </summary>
            /// <param name="tablename">対象テーブル</param>
            /// <param name="pkey">主キー</param>
            /// <param name="ID">キー番号</param>
            /// <param name="timestamp">タイムスタンプ</param>
            /// <returns>1=追加,2=更新,3=無視</returns>
            public int selectTransaction(string tablename, List<string> Pkey, List<string> CD, string timestamp)
            {
                try
                {
                    int Mode;
                    StringBuilder Sql = new StringBuilder();
                    DataTable dt;

                    Sql.AppendFormat("Select TIME_STAMP FROM {0}", tablename);
                    Sql.AppendFormat(" WHERE {0} = '{1}'", Pkey[0], CD[0]);

                    for (int idx = 1; idx < Pkey.Count; idx++)
                    {
                        Sql.AppendFormat(" AND {0} = '{1}'", Pkey[idx], CD[idx]);
                    }

                    dt = base.ExecuteSelect(Sql.ToString());

                    if (dt.Rows.Count == 0)
                    {
                        Mode = 1;
                    }
                    else if (dt.Rows[0]["TIME_STAMP"].ToDecimalEx() < timestamp.ToDecimalEx())
                    {
                        Mode = 2;
                    }
                    else
                    {
                        Mode = 3;
                    }

                    return Mode;
                }
                catch
                {
                    throw;

                }

            }


        }
    }
}

