using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

using Sugitec.Common;
using Sugitec.Logics;



namespace Sugitec
{
	/// <summary>
	/// 得意先担当者M登録
	/// </summary>
	/// 
	public partial class frmMnt130 : frmBase
	{
		#region"Define"

		/// <summary>一覧の列（列挙）</summary>
		private enum enDgvContact : int
		{
			/// <summary>削除フラグ</summary>
			dgv_del = 0,
			/// <summary>得意先コード</summary>
			dgv_cusCd,
			/// <summary>コード</summary>
			dgv_conCD,
			/// <summary>部署</summary>
			dgv_section,
			/// <summary>氏名</summary>
			dgv_conName = 4

		}

		#endregion

		#region"Property"

		/// <summary>遷移元から渡った得意先コードを取得、設定します</summary>
		protected string cusCd { set; get; }
		
		///<summary>現在の入力モードを取得、設定します</summary>
		protected InputMode inpMode { set; get; }

		#endregion

		#region"Event"

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="CusName">遷移した得意先名（初期値は空文字）</param>
		public frmMnt130(string cusCode = "")
        {
            InitializeComponent();

            try
            {
				//設定：
				//機能コード
				base.FeaturesCD = FEATURES.MNT130;
				//得意先コード
				this.cusCd = cusCode;
				this.inpMode = InputMode.Add;

				//DataGridViewの初期設定
				this.InitGridView();

				//画面項目を初期化
				this.InitControl();

				//コンボボックスを設定
				this.SetComboList(cusCode);

				////一覧表を取得しDataGridViewに設定
				//using(srvMnt130 srv = new srvMnt130())
				//{
				//	this.SetDataGridView(srv.SelectCustomerM(this.cusCd));
				//}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		/// <summary>
		/// コンボボックスの項目選択時
		/// </summary>
		private void cmb_Cus_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				//Key項目（得意先担当者コード）を入力可能にする
				txt_ConCod.Enabled = true;

				if(cmb_Cus.SelectedIndex > -1)
				{
					//コンボボックスで選択されている得意先の担当者を全てDataGridViewに表示
					using(srvMnt130 srv = new srvMnt130())
					{
						this.SetDataGridView(srv.SelectCustomerM(cmb_Cus.SelectedValue.ToString()));
					}
				}
				//何も選択されていなければ何もせずに処理を抜ける
				else
					return;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// DataGridViewセルクリック
		/// </summary>
		private void dgv_contact_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				//ヘッダーのクリック時には抜ける
				if(e.RowIndex < 0) return;

				//クリックした行の情報を入力エリアに表示（黄色のテキストボックス）
				// 以下  enum順
				DataGridViewRow row = dgv_contact.Rows[e.RowIndex];
				txt_ConCod.Text = row.Cells[(int)enDgvContact.dgv_conCD].Value.ToString();
				txt_ConName.Text = row.Cells[(int)enDgvContact.dgv_conName].Value.ToString();
				txt_Section.Text = row.Cells[(int)enDgvContact.dgv_section].Value.ToString();
				cmb_Cus.SelectedValue = row.Cells[(int)enDgvContact.dgv_cusCd].Value.ToString();

				//Key項目（得意先担当者コード）を入力不可にする
				txt_ConCod.Enabled = false;

				//更新モードに設定する
				this.inpMode = InputMode.Upd;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		/// <summary>
		/// 確定ボタン
		/// </summary>
		private void btn_OK_Click(object sender, EventArgs e)
		{
			try
			{
				//モードチェック
				if(!(this.inpMode == InputMode.Add || this.inpMode == InputMode.Upd))
				{
					MessageBox.Show("動作に失敗しました", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				//必須入力チェック
				if(!ChkInput()) return;

				//主キー重複チェック：追加モード時のみ有効
				if(this.inpMode == InputMode.Add)
				{
					using(srvMnt130 srv = new srvMnt130())
					{
						if(srv.ChkPkey(txt_ConCod.Text).Rows.Count > 0)
						{
							MessageBox.Show("このコードは既に存在しています"
								, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
					}
				}

				//画面項目をDTOに移送
				dtoMnt130 dto = new dtoMnt130();
				dto.CustomerCode = this.cusCd;
				dto.ConCod = txt_ConCod.Text;
				dto.ConName = txt_ConName.Text;
				dto.Section = txt_Section.Text;
				dto.SynFlg = (int)clsDefine.OperatingStatus;
				dto.TimeSta = DateTime.Now.ToString("yyyyMMddHHmmss");
				//コンボボックス
				dto.CustomerCode = cmb_Cus.SelectedValue.ToString();

				//サービス
				using(srvMnt130 srv = new srvMnt130())
				{
					switch(this.inpMode)
					{
						//追加
						case InputMode.Add:
							srv.Insert(dto);
							break;
						//更新
						case InputMode.Upd:
							srv.Update(dto);
							break;
					}
				}

				//画面項目クリア
				this.InitControl(false, false);

				//サービス
				using(srvMnt130 srv = new srvMnt130())
				{
					//一覧表を再取得しDataGridViewに設定
					this.SetDataGridView(srv.SelectCustomerM(cmb_Cus.SelectedValue.ToString()));
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        /// <summary>
        /// 削除ボタン
        /// </summary>
        private void btn_DEL_Click(object sender, EventArgs e)
        {
            try
            {
                //DataGridVieのデータをDataTableへ格納
                DataTable dt = new DataTable();
                dt = (DataTable)dgv_contact.DataSource;

                //チェックボックスが選択されているかをチェック
                foreach (DataRow row in dt.Rows)
                {
					if(row[0].ToString() == "1")
					{
						//実行確認
						if(MessageBox.Show("削除します。よろしいですか？",
							base.FeatureNM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
							return;

						//サービス
						using(srvMnt130 srv = new srvMnt130())
						{
							//削除用UPDATE文
							srv.Delete(dt);

							//DataGridView再表示（コンボボックスで選択されているレコード）
							this.SetDataGridView(srv.SelectCustomerM(cmb_Cus.SelectedValue.ToString()));
						}

						//各コントロールを初期化
						this.InitControl(false, false);

						//チェックボックスにチェックが入っていれば処理を抜ける
						return;
					}
				}

				//一行もチェックが入っていなければ、メッセージで警告		
				MessageBox.Show("チェックボックスにチェックがありません",
									base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// クリアボタン
        /// </summary>
        private void btn_CLR_Click(object sender, EventArgs e)
        {
            try
            {
				//画面項目クリア
				this.InitControl(false,false);
			}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 終了ボタン
        /// </summary>
        private void btn_End_Click(object sender, EventArgs e)
        {
            try
            {
                //画面を閉じる
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region"Method"

        /// <summary>
        /// DataGridViewの初期設定
        /// </summary>
        private void InitGridView()
        {
            try
            {
                //列自動追加を解除
                dgv_contact.AutoGenerateColumns = false;
                //データソースを解除
                dgv_contact.DataSource = null;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 画面項目の初期設定
        /// </summary>
		/// <param name="mode">入力モード</param>
        /// <param name="isGridClear">DataGridViewをクリア対象に含むか</param>
		/// <param name="isCmbBoxClear">コンボボックスをクリア対象に含むか</param>
        private void InitControl(bool isGridClear = false, bool isCmbBoxClear = true)
        {
			try
			{
				//指定時のみDataGridViewをクリア
				if(isGridClear)
				{
					dgv_contact.DataSource = null;
				}

				//メインメニューから画面が開いている時
				if(string.IsNullOrEmpty(this.cusCd))
				{
					//コンボボックスを使用不可にする
					cmb_Cus.Enabled = true;
					//指定時のみコンボボックスを未選択にする
					if(isCmbBoxClear)
					{
						//コンボボックスを未選択状態にする
						cmb_Cus.SelectedIndex = -1;
					}
				}
				//遷移されて画面が開いている時
				else
				{
					//コンボボックスを使用可能にする
					cmb_Cus.Enabled = false;
				}

				//Key項目（得意先担当者コード）を入力可能にする
				txt_ConCod.Enabled = true;

				//テキストボックス
				txt_ConCod.Text = string.Empty;
				txt_ConName.Text = string.Empty;
				txt_Section.Text = string.Empty;

				//追加モードに変更
				this.inpMode = InputMode.Add;
			}
			catch
			{
				throw;
			}
        }

        /// <summary>
        /// 得意先担当者Mを取得しDataGridViewに設定
        /// </summary>
		/// <param name="dto">移送後のDTO</param>
		/// <returns>データ件数が０件ならfalseを返す</returns>
        private Boolean SetDataGridView(DataTable dt)
        {
			try
			{
				//DataGridView のデータ取得
				dgv_contact.AutoGenerateColumns = false;
				dgv_contact.DataSource = dt;

				//データ件数チェック
				if(dgv_contact.Rows.Count <= 0)
				{
					return false;
				}

				//DataGridView へのデータバインド
				dgv_contact.Columns[(int)enDgvContact.dgv_del].DataPropertyName = "SEL0";
				dgv_contact.Columns[(int)enDgvContact.dgv_conCD].DataPropertyName = "CONTACT_CODE";
				dgv_contact.Columns[(int)enDgvContact.dgv_section].DataPropertyName = "SECTION";
				dgv_contact.Columns[(int)enDgvContact.dgv_conName].DataPropertyName = "CONTACT_NAME";
				dgv_contact.Columns[(int)enDgvContact.dgv_cusCd].DataPropertyName = "CUSTOMER_CODE";

				//データ件数が存在している場合は正常終了
				return true;
			}
			catch
			{
				throw;
			}
        }

        /// <summary>
        /// コンボボックスのリストを設定
        /// </summary>
        private void SetComboList(string code)
        {
			try
			{
				//サービス
				using(srvMnt130 srv = new srvMnt130())
				{
					//画面が遷移されてきた場合
					if(!string.IsNullOrEmpty(this.cusCd))
					{
						//支払区分取得
						cmb_Cus.DataSource = srv.SelectComboBox();
						cmb_Cus.ValueMember = "CODE";
						cmb_Cus.DisplayMember = "NAME";
						cmb_Cus.SelectedIndex = -1;
						//コンボボックスの現在の表示を得意先コードに設定
						cmb_Cus.SelectedValue = code;
					}
					//それ以外（追加モードと更新モード時）
					else
					{
						//支払区分取得
						cmb_Cus.DataSource = srv.SelectComboBox();
						cmb_Cus.ValueMember = "CODE";
						cmb_Cus.DisplayMember = "NAME";
						cmb_Cus.SelectedIndex = -1;
					}
				}
			}
			catch
			{
				throw;
			}            
        }

        /// <summary>
        /// 入力項目のチェックを行う
        /// </summary>
        /// <returns></returns>
        private Boolean ChkInput()
        {
            try
            {
				//コンボボックスの必須チェック
				if(cmb_Cus.SelectedIndex == -1)
				{
					MessageBox.Show("支払区分が正しく選択されていないか、未入力の状態です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
				//コードの必須チェック
				if (string.IsNullOrEmpty(txt_ConCod.Text))
                {
                    MessageBox.Show("担当者コードが未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //氏名の必須チェック
                if (string.IsNullOrEmpty(txt_ConName.Text))
                {
                    MessageBox.Show("氏名が未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

				//正常終了
				return true;
            }
            catch
            {
                throw;
            }
        }

		#endregion
	}
}
