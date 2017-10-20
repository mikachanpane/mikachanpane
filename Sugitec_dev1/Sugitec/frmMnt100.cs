using System;
using System.Data;
using System.Windows.Forms;

using Sugitec.Common;
using Sugitec.Logics;



namespace Sugitec
{
    /// <summary>
    /// 得意先M登録
    /// </summary>
    /// 
    public partial class frmMnt100 : frmBase
    {
        #region"Define"

        ///<summary>入力モード</summary>
        private InputMode Mode;
        
        /// <summary>一覧の列（列挙）</summary>
        private enum enDgvTokuisaki:int
        {
            /// <summary>削除フラグ</summary>
            dgv_del = 0,
            /// <summary>コード</summary>
            dgv_tokCod,
            /// <summary>名称</summary>
            dgv_name,
            /// <summary>かな</summary>
            dgv_kana,
            /// <summary>電話番号</summary>
            dgv_tel,
            /// <summary>FAX番号</summary>
            dgv_fax,
            /// <summary>郵便番号</summary>
            dgv_post,
            /// <summary>住所１</summary>
            dgv_Address1,
			/// <summary>住所２</summary>
			dgv_Address2,
            /// <summary>請求締日</summary>
            dgv_Simebi,
            /// <summary>支払区分</summary>
            dgv_paykbn,
            /// <summary>支払日</summary>
            dgv_payday
            // 10
        }

        #endregion

        #region"Property"

        #endregion

        #region"Event"

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmMnt100()
        {
            InitializeComponent();

            try
            {
                //機能コードを設定
                FeaturesCD = FEATURES.MNT100;

                //DataGridViewの初期設定
                InitGridView();

                //画面項目クリア
                ClrContorol(true);

                //コンボボックスを設定
                SetComboList();

                //一覧表を取得しDataGridViewに設定
                SetDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		/// <summary>
		/// DataGridViewセルクリック
		/// </summary>
		private void dgv_TokSaki_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				//ヘッダーのクリック時には抜ける
				if(e.RowIndex < 0) return;

				//クリックした行の情報を入力エリアに表示（黄色のテキストボックス）
				// 以下  enum順
				DataGridViewRow row = dgv_TokSaki.Rows[e.RowIndex];
				txt_Cod.Text = row.Cells[(int)enDgvTokuisaki.dgv_tokCod].Value.ToString();
				txt_Name.Text = row.Cells[(int)enDgvTokuisaki.dgv_name].Value.ToString();
				txt_Kana.Text = row.Cells[(int)enDgvTokuisaki.dgv_kana].Value.ToString();
				txt_Phone.Text = row.Cells[(int)enDgvTokuisaki.dgv_tel].Value.ToString();
				txt_Fax.Text = row.Cells[(int)enDgvTokuisaki.dgv_fax].Value.ToString();
				txt_ZIP.Text =	row.Cells[(int)enDgvTokuisaki.dgv_post].Value.ToString();
				txt_Address1.Text =	row.Cells[(int)enDgvTokuisaki.dgv_Address1].Value.ToString();
				txt_Address2.Text = row.Cells[(int)enDgvTokuisaki.dgv_Address2].Value.ToString();
				txt_Sime.Text = row.Cells[(int)enDgvTokuisaki.dgv_Simebi].Value.ToString();
				cmb_PayKbn.Text = row.Cells[(int)enDgvTokuisaki.dgv_paykbn].Value.ToString();
				txt_Payment.Text = row.Cells[(int)enDgvTokuisaki.dgv_payday].Value.ToString();

				//Key項目を使用不可にする
				txt_Cod.Enabled = false;
				//担当者登録ボタンを使用可能にする
				btnContent.Enabled = true;

				//モードを更新に変更
				this.Mode = InputMode.Upd;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// 担当者別登録ボタン
		/// </summary>
		private void btnContent_Click(object sender, EventArgs e)
		{
			try
			{
				//担当者登録画面遷移（更新モードを知らせ、担当者コードを送る）
				using(frmMnt130 frm = new frmMnt130(txt_Cod.Text))
				{
					frm.ShowDialog();

					//遷移先（frmMnt130）からDialogResult.OKが取得できればDataGridViewに再表示
					if(frm.DialogResult == DialogResult.OK)
					{
						//再度、検索結果をDataGridViewに表示						
						this.SetDataGridView();

						//先頭行を選択
						this.dgv_TokSaki.Rows[0].Selected = true;
					}
					//そうじゃなければ何もしない
				}
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
				if(!(Mode == InputMode.Add || Mode == InputMode.Upd))
				{
					MessageBox.Show("動作に失敗しました", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				//必須入力チェック
				if(!ChkInput()) return;

				//主キー重複チェック（追加モード時のみ行う）
				if(this.Mode == InputMode.Add)
				{
					using(srvMnt100 srv = new srvMnt100())
					{
						if(srv.ChkPkey(txt_Cod.Text).Rows.Count > 0)
						{
							MessageBox.Show("このコードは既に存在しています"	
								, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;

						}
					}
				}

				//画面項目をDTOに移送
				dtoMnt100 dto = new dtoMnt100();
				dto.Code = txt_Cod.Text;
				dto.Name = txt_Name.Text;
				dto.Sime = txt_Sime.Text;
				dto.Paykbn = cmb_PayKbn.SelectedValue.ToString();
				dto.Payment = txt_Payment.Text;
				dto.Kana = txt_Kana.Text;
				dto.Tel = txt_Phone.Text;
				dto.FAX = txt_Fax.Text;
				dto.Post = txt_ZIP.Text;
				dto.Address1 = txt_Address1.Text;
				dto.Address2 = txt_Address2.Text;
				dto.SYNC_FLG = (int)clsDefine.OperatingStatus;
				dto.TIME_STAMP = DateTime.Now.ToString("yyyyMMddhhmmss");

				//サービス
				using(srvMnt100 srv = new srvMnt100())
				{
					switch(this.Mode)
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
				this.ClrContorol(true);

				//一覧表を再取得しDataGridViewに設定
				this.SetDataGridView();
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
                dt = (DataTable)dgv_TokSaki.DataSource;

                //選択チェック 具体的には,DataGeridView からチェックフラグを探しに行きます
                foreach (DataRow row in dt.Rows)
                {
                    //チェックボックスの入った行を探し、ひとつでもあればtrue
                    if (row[0].ToString() == "1")
                    {

                        //実行確認
                        if (MessageBox.Show("削除します。よろしいですか？",
                            base.FeatureNM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                        
                        //サービス
                        using (srvMnt100 srv = new srvMnt100())
                        {
							//削除用Update文
                            srv.Delete(dt);

							//DataGridView再表示
							this.SetDataGridView();

							//各コントロールを初期化
							this.ClrContorol();
							return;
						}
                    }
                }

				//一行もチェックが入っていなければ、メッセージで警告		
				MessageBox.Show("チェックボックスにチェックがありません",
									base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                this.ClrContorol();
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
                dgv_TokSaki.AutoGenerateColumns = false;
                //データソースを解除
                dgv_TokSaki.DataSource = null;
                //ヘッダーテキストの位置調整
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_del].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_tokCod].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_name].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_Simebi].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_paykbn].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_payday].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //列の位置調整
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_del].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_tokCod].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_name].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_Simebi].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_paykbn].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_payday].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //列の幅指定
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_del].Width = 60;
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_tokCod].Width = 80;
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_name].Width = 400;
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_Simebi].Width = 88;
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_paykbn].Width = 86;
                dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_payday].Width = 74;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 画面項目をクリア
        /// </summary>
        /// <param name="isGridClear">DataGridViewをクリア対象に含むか</param>
        private void ClrContorol(bool isGridClear = false)
        {
            try
            {
                //各コントロールをクリア
                txt_Cod.Text = string.Empty;
                txt_Name.Text = string.Empty;
                txt_Kana.Text = string.Empty;
                txt_Phone.Text = string.Empty;
                txt_Fax.Text = string.Empty;
                txt_ZIP.Text = string.Empty;
                txt_Address1.Text = string.Empty;
				txt_Address2.Text = string.Empty;
                txt_Sime.Text = string.Empty;
                cmb_PayKbn.SelectedIndex = -1;
                txt_Payment.Text = string.Empty;
				//担当者登録ボタンを使用不可にする
				btnContent.Enabled = false;
                //Key項目を入力可能にする
                txt_Cod.Enabled = true;
                //指定時のみDataGridViewをクリア
                if (isGridClear)
                {
                    dgv_TokSaki.DataSource = null;
				}
                //モードを追加に変更
                Mode = InputMode.Add;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 得意先Mを取得しDaataGridViewに設定
        /// </summary>
        private void SetDataGridView()
        {
            try
            {
                //サービス
                using (srvMnt100 srv = new srvMnt100())
                {
                    //DataGridView のデータ取得
                    dgv_TokSaki.AutoGenerateColumns = false;
                    dgv_TokSaki.DataSource = srv.Select();

                    //データチェック
                    if (dgv_TokSaki.Rows.Count == 0)
                    {
                        MessageBox.Show("データ件数が０件です",
                            base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //DataGridView へのデータバインド
                    dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_del].DataPropertyName       = "SEL0";
                    dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_tokCod].DataPropertyName    = "CODE";
                    dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_name].DataPropertyName      = "NAME";
                    dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_kana].DataPropertyName      = "KANA";
                    dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_tel].DataPropertyName       = "TEL";
                    dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_fax].DataPropertyName       = "FAX";
                    dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_post].DataPropertyName      = "POST";
                    dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_Address1].DataPropertyName   = "ADDRESS1";
					dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_Address2].DataPropertyName = "ADDRESS2";
                    dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_Simebi].DataPropertyName    = "CUTOFF_DAY";
                    dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_paykbn].DataPropertyName    = "CONTENT";
                    dgv_TokSaki.Columns[(int)enDgvTokuisaki.dgv_payday].DataPropertyName    = "PAYMENT_DAY";

                    //追加モードへ移行
                    Mode = InputMode.Add;
                        
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 各コンボボックスのリストを設定
        /// </summary>
        private void SetComboList()
        {

            try
            {
                //サービス
                using (srvMnt100 srv = new srvMnt100())
                {
                    //支払区分取得
                    cmb_PayKbn.DataSource = srv.GetCodeM("A01");
                    cmb_PayKbn.ValueMember = "CODE";
                    cmb_PayKbn.DisplayMember = "CONTENT";
                    cmb_PayKbn.SelectedIndex = -1;
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
        private bool ChkInput()
        {
            try
            {
                //コードの必須チェック
                if (string.IsNullOrEmpty(txt_Cod.Text))
                {
                    MessageBox.Show("コードが未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //名称の必須チェック
                if (string.IsNullOrEmpty(txt_Name.Text))
                {
                    MessageBox.Show("名称が未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //請求絞日の必須チェック
                if (string.IsNullOrEmpty(txt_Sime.Text))
                {
                    MessageBox.Show("請求締日が未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //支払区分の必須チェック
                if (cmb_PayKbn.SelectedIndex == -1)
                {
                    MessageBox.Show("支払区分が正しく選択されていないか、未入力の状態です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //支払日の必須チェック
                if (string.IsNullOrEmpty(txt_Payment.Text))
                {
                    MessageBox.Show("支払日が未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

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
