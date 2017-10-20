using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sugitec.Common;
using Sugitec.Logics;

namespace Sugitec
{
    public partial class frmMnt111 : frmBase
    {

        #region"Define"

        //更新か新規か判定、初期値は新規
        bool updMode = false;

		/// <summary>一覧の列（列挙）</summary>
		private enum enDgvContact : int
		{
			/// <summary>技術者ＩＤ</summary>
			ENGINEER_ID,
			/// <summary>連番</summary>
			BIO_NO = 0,
			/// <summary>開始年月日</summary>
			BIO_START_YMD ,
			/// <summary>終了年月日</summary>
			BIO_END_YMD ,
			/// <summary>業種</summary>
			BIO_BUS_TYP ,
			/// <summary>システム概要</summary>
			BIO_OVERVIEW ,
			/// <summary>ポジジョン</summary>
			BIO_POSITION ,
			/// <summary>役割</summary>
			BIO_ROLE ,
			/// <summary>人数</summary>
			BIO_NUM = 0,
			/// <summary>作業内容</summary>
			BIO_WORK = 0,
			/// <summary>要件定義</summary>
			BIO_RD = 0,
			/// <summary>調査分析</summary>
			BIO_SA = 0,
			/// <summary>ＤＢ設計</summary>
			BIO_DD = 0,
			/// <summary>基本設計</summary>
			BIO_UI = 0,
			/// <summary>詳細設計</summary>
			BIO_PS = 0,
			/// <summary>ＰＧ設計</summary>
			BIO_PD = 0,
			/// <summary>製造</summary>
			BIO_PG = 0,
			/// <summary>単体テスト</summary>
			BIO_PT = 0,
			/// <summary>結合テスト</summary>
			BIO_IT = 0,
			/// <summary>システムテスト</summary>
			BIO_ST = 0,
			/// <summary>障害対応</summary>
			BIO_IR = 0,
			/// <summary>システム導入</summary>
			BIO_SI = 0,
			/// <summary>開発外社内作業</summary>
			BIO_IW = 0,
			/// <summary>その他</summary>
			BIO_OTH = 0,
				/// <summary>削除フラグ</summary>
			DEL_FLG = 0
		}
		#endregion

		#region"Property"
		/// <summary>技術者IDプロパティ</summary>
		protected string prp_EngineerId { set; get; }

		#endregion

		#region"Event"

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="EngineerId">"技術者ID(Option)"</param>
		public frmMnt111(string EngineerId ="")
        {
            InitializeComponent();

            //機能コードを設定
            this.FeaturesCD = FEATURES.MNT111;
			//コンストラクタ引数の技術者IDの値を技術者IDプロパティにセット
			this.prp_EngineerId = EngineerId;

			try
			{
				//技術者コンボの初期化処理
				cmb_EngineerInit();
				//ポジション、役割コンボの初期化処理
				cmb_PositionYakuwariInit();
				//リストボックスの初期化
				ListBoxInit();
				//技術者経歴グリッドの初期化処理
				dgv_EngineerCareerInit();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			//上記以外の画面項目を初期化
			InitControl();
		}

		/// <summary>
		/// 技術者コンボボックス値変更時
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmb_Engineer_SelectedIndexChanged(object sender, EventArgs e)
		{
				//技術者コンボの入力を可能にする
				cmb_Engineer.Enabled = true;
			//ドロップダウンリストの空白以外を選択したとき
			if(cmb_Engineer.SelectedIndex > -1)
			{
				try
				{
					//コンボボックスで選択されている得意先の担当者を全てDataGridViewに表示
					using(srvMnt111 srv = new srvMnt111())
					{
						//データグリッドの表示処理を行う
						Getdgv_EngineerCareerData();
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			//何も選択されていなければ何もせずに処理を抜ける
			else
			{
				return;
			}
		}

		/// <summary>
		/// 追加ボタン押下処理
		/// </summary>
		private void btn_OK_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// 変更ボタン押下処理
		/// </summary>
		private void btn_Change_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// 削除ボタン押下処理
		/// </summary>
		private void btn_Delete_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// クリアボタン押下処理
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Clear_Click(object sender, EventArgs e)
		{
			//画面項目クリア
			InitControl();

			try
			{
				//リストボックスデータを再取得
				ListBoxInit();
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 終了ボタン押下処理
		/// </summary>
		private void Cmd_End_Click(object sender, EventArgs e)
		{
			//画面を終了する
			Close();
		}

		#endregion

		#region"Method"

		#region"InitFanction"
		/// <summary>
		/// コントロールの初期化処理
		/// </summary>
		private void InitControl()
		{
			//メニュー画面から開いている時
			if(string.IsNullOrEmpty(this.prp_EngineerId))
			{
				//技術者コンボボックスを使用可能にする
				cmb_Engineer.Enabled = true;
			}
			//遷移されて画面が開いている時
			else
			{
				//技術者IDの値をセット
				cmb_Engineer.SelectedValue = this.prp_EngineerId;
				//技術者コンボボックスを使用不可能にする
				cmb_Engineer.Enabled = false;
			}

			//日付テキストの初期化(システム日付をFrom,To共にセット)
			dtp_BirthdayFrom.Value = DateTime.Now;
			dtp_BirthdayTo.Value = DateTime.Now;
			//テキストボックスの初期化
			txt_UserType.Text = string.Empty;
			txt_Gaiyo.Text = string.Empty;
			btxt_Work.Text = string.Empty;
			//人数数値テキストの初期化
			nud_People.Value = 0;
			//各チェックボックスの初期化する
			chk_Yoken.Checked = false;
			chk_Cyosa.Checked = false;
			chk_DbSekei.Checked = false;
			chk_StdSekei.Checked = false;
			chk_DtlSekei.Checked = false;
			chk_Sekei.Checked = false;
			chk_Production.Checked = false;
			chk_Test.Checked = false;
			chk_SogoTest.Checked = false;
			chk_SysTest.Checked = false;
			chk_Syogai.Checked = false;
			chk_SysIntroduction.Checked = false;
			chk_Company.Checked = false;

			////追加モードに変更
			//this.inpMode = InputMode.Add;
		}

		/// <summary>
		/// 技術者コンボの初期化処理
		/// </summary>
		private void cmb_EngineerInit()
		{
			try
			{
				//サービス側からドロップダウンリストに表示するデータを取得する
				//処理終了後サービスクラスのインスタンスを解放する
				using(srvMnt111 srv = new srvMnt111())
				{
					//メニュー画面から遷移した時
					if(string.IsNullOrEmpty(this.prp_EngineerId))
					{
						//技術者情報取得
						cmb_Engineer.DataSource = srv.SelectEngineerComboBox();
						cmb_Engineer.ValueMember = "ID";
						cmb_Engineer.DisplayMember = "NAME";
						//コンボの初期表示は非表示
						cmb_Engineer.SelectedIndex = -1;
					}
					//それ以外（メニュー画面以外から遷移した時）
					else
					{

						//技術者情報取得
						cmb_Engineer.DataSource = srv.SelectEngineerComboBox();
						cmb_Engineer.ValueMember = "ID";
						cmb_Engineer.DisplayMember = "NAME";
						//cmb_Engineer.SelectedIndex = -1;
						//コンボボックスの現在の表示を引数の技術者IDに設定
						cmb_Engineer.SelectedValue = this.prp_EngineerId;
					}
				}
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		///リストボックスの初期化処理
		/// </summary>
		private void ListBoxInit()
		{
			//リストボックスの初期化
			//ハード
			lst_Hard.DataSource = null;
			//OS
			lst_Os.DataSource = null;
			//コード
			lst_Cord.DataSource = null;
			//DB
			lst_Db.DataSource = null;
			//ツール
			lst_Tool.DataSource = null;

			try
			{
				//サービス側からリストに表示するデータを取得する
				//処理終了後サービスクラスのインスタンスを解放する
				using(srvMnt111 srv = new srvMnt111())
				{

					//ハード項目の取得
					lst_Hard.DataSource = srv.SelectHardListBox();
					lst_Hard.ValueMember = "CODE";
					lst_Hard.DisplayMember = "CONTENT";

					//OS情報の取得
					lst_Os.DataSource = srv.SelectOsListBox();
					lst_Os.ValueMember = "CODE";
					lst_Os.DisplayMember = "CONTENT";

					//コード情報の取得
					lst_Cord.DataSource = srv.SelectCordListBox();
					lst_Cord.ValueMember = "CODE";
					lst_Cord.DisplayMember = "CONTENT";

					//DB情報の取得
					lst_Db.DataSource = srv.SelectDbListBox();
					lst_Db.ValueMember = "CODE";
					lst_Db.DisplayMember = "CONTENT";

					//ツール情報の取得
					lst_Tool.DataSource = srv.SelectToolListBox();
					lst_Tool.ValueMember = "CODE";
					lst_Tool.DisplayMember = "CONTENT";

				}
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// ポジション、役職コンボの初期化処理
		/// </summary>
		private void cmb_PositionYakuwariInit()
		{
			try
			{
				//サービス側からドロップダウンリストに表示するデータを取得する
				//処理終了後サービスクラスのインスタンスを解放する
				using(srvMnt111 srv = new srvMnt111())
				{
					//ポジション情報の取得
					cmb_Position.DataSource = srv.SelectPositionComboBox();
					cmb_Position.ValueMember = "CODE";
					cmb_Position.DisplayMember = "CONTENT";
					//コンボの初期表示は非表示
					cmb_Position.SelectedIndex = -1;
					//役割情報の取得
					cmb_Yakuwari.DataSource = srv.SelectYakuwariComboBox();
					cmb_Yakuwari.ValueMember = "CODE";
					cmb_Yakuwari.DisplayMember = "CONTENT";
					//コンボの初期表示は非表示
					cmb_Yakuwari.SelectedIndex = -1;
				}
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// 技術者経歴グリッドの初期化処理
		/// </summary>
		private void dgv_EngineerCareerInit()
		{
			//データソースをバインドする際に、非表示列を自動表示しないようにする
			dgv_EngineerCareer.AutoGenerateColumns = false;
			//データソースの初期化を行う
			dgv_EngineerCareer.DataSource = null;

		}
		/// <summary>
		/// 技術者経歴グリッド用データ取得処理
		/// </summary>
		private void Getdgv_EngineerCareerData()
		{
			//技術者ＩＤをキーにＤＢから技術者経歴情報を取得し、
			//技術者経歴グリッドにデータ表示を行う
			using(srvMnt111 srv = new srvMnt111())
			{
				this.SetDataGridView(srv.SelectEngineerCareerDataGrid(cmb_Engineer.ValueMember));
			}
		}
		/// <summary>
		/// 技術者経歴グリッド用データ表示処理
		/// </summary>
		private Boolean SetDataGridView(DataTable dt)
		{
			try
			{
				//DataGridViewのデータソースに取得データをセット
				dgv_EngineerCareer.DataSource = dt;

				//データ件数チェック
				if(dgv_EngineerCareer.Rows.Count <= 0)
				{
					return false;
				}

				//DataGridView へのデータバインド
				dgv_EngineerCareer.Columns[(int)enDgvContact.ENGINEER_ID].DataPropertyName = "ENGINEER_ID";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_NO].DataPropertyName = "BIO_NO";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_START_YMD].DataPropertyName = "BIO_START_YMD";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_END_YMD].DataPropertyName = "BIO_END_YMD";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_BUS_TYP].DataPropertyName = "BIO_BUS_TYP";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_OVERVIEW].DataPropertyName = "BIO_OVERVIEW";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_POSITION].DataPropertyName = "BIO_POSITION";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_ROLE].DataPropertyName = "BIO_ROLE";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_NUM].DataPropertyName = "BIO_NUM";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_WORK].DataPropertyName = "BIO_WORK";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_RD].DataPropertyName = "BIO_RD";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_SA].DataPropertyName = "BIO_SA";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_DD].DataPropertyName = "BIO_DD";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_UI].DataPropertyName = "BIO_UI";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_PS].DataPropertyName = "BIO_PS";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_PD].DataPropertyName = "BIO_PD";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_PG].DataPropertyName = "BIO_PG";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_PT].DataPropertyName = "BIO_PT";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_IT].DataPropertyName = "BIO_IT";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_ST].DataPropertyName = "BIO_ST";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_IR].DataPropertyName = "BIO_IR";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_SI].DataPropertyName = "BIO_SI";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_IW].DataPropertyName = "BIO_IW";
				dgv_EngineerCareer.Columns[(int)enDgvContact.BIO_OTH].DataPropertyName = "BIO_OTH";

				//データ件数が存在している場合は正常終了
				return true;
			}
			catch
			{
				throw;
			}
		}
		#endregion

		#endregion
	}
}

    