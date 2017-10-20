using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Sugitec.Common
{

    /// <summary>動作状態（列挙）</summary>
    public enum OperatStatus : int
    {
        OFFLINE = 1,
        ONLINE  = 0
    }

    /// <summary>機能コード（列挙）</summary>
    public enum FEATURES:int
    {
        /// <summary>ログイン</summary>
        LOGIN = 0,
        /// <summary>メインメニュー</summary>
        MENU01 = 1,
        /// <summary>システム設定</summary>
        MNT000 = 10,
        /// <summary>ユーザー登録</summary>
        MNT010 = 11,
        /// <summary>各種マスタ取込み</summary>
        MNT020 = 12,
        /// <summary>コード区分登録</summary>
        MNT030 = 13,
        /// <summary>消費税率登録</summary>
        MNT040 = 14,
        /// <summary>得意先登録</summary>
        MNT100 = 21,
        /// <summary>技術者登録</summary>
        MNT110 = 22,
        /// <summary>技術者経歴登録</summary>
        MNT111 = 23,
        /// <summary>所属グループ登録</summary>
        MNT120 = 24,
        /// <summary>得意先担当者登録</summary>
        MNT130 = 25,
        /// <summary>受注情報新規登録</summary>
        ORD010 = 31,
        /// <summary>受注情報検索</summary>
        ORD020 = 32,
        /// <summary>受注情報変更</summary>
        ORD021 = 33,
        /// <summary>受注情報継続登録</summary>
        ORD022 = 34,
        /// <summary>売上情報新規登録</summary>
        SAL010 = 41,
        /// <summary>売上情報検索</summary>
        SAL020 = 42,
        /// <summary>売上情報変更</summary>
        SAL021 = 43,
        /// <summary>経費入力</summary>
        SAL030 = 45,
        /// <summary>請求情報作成</summary>
        REQ010 = 51,
        /// <summary>請求情報検索</summary>
        REQ020 = 52,
        /// <summary>請求情報変更</summary>
        REQ021 = 53,
        /// <summary>入金情報新規登録</summary>
        REC010 = 61,
        /// <summary>入金情報検索</summary>
        REC020 = 62,
        /// <summary>入金情報変更</summary>
        REC021 = 63,
        /// <summary>回収対象検索</summary>
        DEP010 = 70,
        /// <summary>回収情報登録</summary>
        DEP020 = 72,
        /// <summary>消込み追加・訂正</summary>
        DEP021 = 73,
        /// <summary>月別売上帳照会</summary>
        INQ010 = 81,
        /// <summary>年度別売上対比表照会</summary>
        INQ100 = 91,
        /// <summary>得意先選択</summary>
        SRC010 = 100,
        /// <summary>技術者選択</summary>
        SRC011 = 101,
        /// <summary>データ同期</summary>
        DAT010 = 200,
        /// <summary>送付状発行</summary>
        OTH010 = 900,
    }

    /// <summary>入力モード（列挙）</summary>
    public enum InputMode : int
    {
        /// <summary>表示</summary>
        Dsp = 0,
        /// <summary>追加</summary>
        Add,
        /// <summary>更新</summary>
        Upd,
        /// <summary>削除</summary>
        Del
    }

    /// <summary>検索対象（列挙）</summary>
    public enum Search : int
    {
        /// <summary>得意先</summary>
        CUSTOMER = 0,
        /// <summary>技術者</summary>
        ENGINEER,
        /// <summary>受注</summary>
        ORDER
    }

    /// <summary>出力対象（列挙）</summary>
    public enum FileOutput : int
    {
        /// <summary>エクセル</summary>
        EXCEL = 0,
        /// <summary>PDF</summary>
        PDF,
        /// <summary>プリンター</summary>
        PRINTER
    }

    /// <summary>共通クラス</summary>
    public static class clsDefine
    {
        /// <summary>機能ID</summary>
        private static Dictionary<FEATURES, string> FEATURES_ID = new Dictionary<FEATURES, string>()
        {
            {FEATURES.LOGIN ,"LOGIN"},
            {FEATURES.MENU01,"MENU01"},
            {FEATURES.MNT000,"MNT000"},
            {FEATURES.MNT010,"MNT010"},
            {FEATURES.MNT020,"MNT020"},
            {FEATURES.MNT030,"MNT030"},
            {FEATURES.MNT040,"MNT040"},
            {FEATURES.MNT100,"MNT100"},
            {FEATURES.MNT110,"MNT110"},
            {FEATURES.MNT111,"MNT111"},
            {FEATURES.MNT120,"MNT120"},
            {FEATURES.MNT130,"MNT130"},
            {FEATURES.ORD010,"ORD010"},
            {FEATURES.ORD020,"ORD020"},
            {FEATURES.ORD021,"ORD021"},
            {FEATURES.ORD022,"ORD022"},
            {FEATURES.SAL010,"SAL010"},
            {FEATURES.SAL020,"SAL020"},
            {FEATURES.SAL021,"SAL021"},
            {FEATURES.SAL030,"SAL030"},
            {FEATURES.REQ010,"REQ010"},
            {FEATURES.REQ020,"REQ020"},
            {FEATURES.REQ021,"REQ021"},
            {FEATURES.REC010,"REC010"},
            {FEATURES.REC020,"REC020"},
            {FEATURES.REC021,"REC021"},
            {FEATURES.SRC010,"SRC010"},
            {FEATURES.SRC011,"SRC010"},
            {FEATURES.INQ010,"INQ010"},
            {FEATURES.INQ100,"INQ100"},
            {FEATURES.DAT010,"DAT010"},
            {FEATURES.OTH010,"OTH010"},
            {FEATURES.DEP010,"DEP010"},
            {FEATURES.DEP020,"DEP020"},
            {FEATURES.DEP021,"DEP021"},
        };

        /// <summary>機能名</summary>
        private static Dictionary<FEATURES, string> FEATURES_NM = new Dictionary<FEATURES, string>()
        {
            {FEATURES.LOGIN ,"ログイン"},
            {FEATURES.MENU01,"メインメニュー"},
            {FEATURES.MNT000,"システム設定"},
            {FEATURES.MNT010,"ユーザー登録"},
            {FEATURES.MNT020,"各種マスタ取込み"},
            {FEATURES.MNT030,"コード区分登録"},
            {FEATURES.MNT040,"消費税率登録"},
            {FEATURES.MNT100,"得意先登録"},
            {FEATURES.MNT110,"技術者登録"},
            {FEATURES.MNT111,"技術者経歴登録"},
            {FEATURES.MNT120,"所属グループ登録"},
            {FEATURES.MNT130,"得意先担当者登録"},
            {FEATURES.ORD010,"受注情報新規登録"},
            {FEATURES.ORD020,"受注情報検索"},
            {FEATURES.ORD021,"受注情報変更"},
            {FEATURES.ORD022,"受注情報継続登録"},
            {FEATURES.SAL010,"売上情報新規登録"},
            {FEATURES.SAL020,"売上情報検索"},
            {FEATURES.SAL021,"売上情報変更"},
            {FEATURES.REQ010,"請求締め処理"},
            {FEATURES.REQ020,"請求書発行"},
            {FEATURES.REQ021,"請求情報変更"},
            {FEATURES.SAL030,"経費入力"},
            {FEATURES.REC010,"入金情報新規登録"},
            {FEATURES.REC020,"入金情報検索"},
            {FEATURES.REC021,"入金情報変更"},
            {FEATURES.SRC010,"得意先選択"},
            {FEATURES.SRC011,"技術者選択"},
            {FEATURES.INQ010,"月別売上帳照会"},
            {FEATURES.INQ100,"年度別売上対比表照会"},
            {FEATURES.DAT010,"データ同期"},
            {FEATURES.OTH010,"送付状発行"},
            {FEATURES.DEP010,"回収対象検索"},
            {FEATURES.DEP020,"回収情報登録"},
            {FEATURES.DEP021,"消込み追加・訂正"},
        };

        /// <summary>
        /// 機能IDを取得
        /// </summary>
        /// <param name="code">機能コード</param>
        /// <returns>機能ID</returns>
        public static string GetFeatureID(FEATURES code)
        {
            return FEATURES_ID[code];
        }

        /// <summary>
        /// 機能名を取得
        /// </summary>
        /// <param name="code">機能コード</param>
        /// <returns>機能名</returns>
        public static string GetFeatureNM(FEATURES code)
        {
            return FEATURES_NM[code];
        }

        /// <summary>動作状態</summary>
        public static OperatStatus OperatingStatus { get; private set; }

        /// <summary>
        /// 動作状態を設定
        /// </summary>
        /// <param name="value">動作状態</param>
        public static void SetOpStat(OperatStatus value)
        {
            OperatingStatus = value;
        }

        /// <summary>
        /// 請求書テンプレートのパス
        /// </summary>
        /// <returns></returns>
        public static string Invoice_Path()
        {
            return ConfigurationManager.AppSettings["TMP_INVOICE_PATH"];
        }

        /// <summary>
        /// 月次帳票テンプレートのパス
        /// </summary>
        /// <returns></returns>
        public static string Monthly_Path()
        {
            return ConfigurationManager.AppSettings["TMP_MONTHLY_PATH"];
        }

        /// <summary>
        /// 年次帳票テンプレートのパス
        /// </summary>
        /// <returns></returns>
        public static string Year_Path()
        {
            return ConfigurationManager.AppSettings["TMP_YEAR_PATH"];
        }

        /// <summary>
        /// その他テンプレートのパス
        /// </summary>
        /// <returns></returns>
        public static string Other_Path()
        {
            return ConfigurationManager.AppSettings["TMP_OTHER_PATH"];
        }

        /// <summary>
        /// サーバへの接続が可能かをチェックします
        /// </summary>
        /// <returns>True：接続可能、False：接続不可</returns>
        public static bool IsServerCon()
        {
            //サーバへの接続確認
            //Pingオブジェクトの作成
            System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
            try
            {
                //app_configからサーバ名を取得
                string ServerName = ConfigurationManager.AppSettings["SV_ServerName"];
                //PINGを送信
                System.Net.NetworkInformation.PingReply reply = p.Send(ServerName);
                //結果を取得
                if (reply.Status != System.Net.NetworkInformation.IPStatus.Success)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                p.Dispose();
            }

            //データベースへの接続確認
            SqlConnection Con = new SqlConnection();
            try
            {
                //app_configからDB接続のパスワードを取得
                string ServerName = ConfigurationManager.AppSettings["SV_ServerName"];
                string UserID = ConfigurationManager.AppSettings["SV_UserId"];
                string Password = ConfigurationManager.AppSettings["SV_Password"];
                string DatabaseName = ConfigurationManager.AppSettings["SV_DBName"];
                string St = String.Format("Server={0};User ID={1};Password={2};Initial Catalog={3};Connect Timeout=5", ServerName, UserID, Password, DatabaseName);
                //接続文字列の設定
                Con.ConnectionString = St;

                //DBを開く
                Con.Open();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (Con != null)
                {
                    //DBの接続を切断する
                    if (Con.State != System.Data.ConnectionState.Closed)
                    {
                        Con.Close();
                    }
                    //コネクションを解放
                    Con.Dispose();
                }
            }
        }

        /// <summary>
        /// エクセルのバージョン
        /// </summary>
        public static double ExcelVersion { get; set; }

        /// <summary>
        /// ＰＤＦ出力、印刷が可能か
        /// </summary>
        public static bool isOutPdfOrPrint
        {
            get
            {
                //Excel2007以前（未インストール含む）の場合はＰＤＦ出力、印刷は不可
                if (ExcelVersion < 12.0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

    }
}
