using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Sugitec.Common;
using Sugitec.Logics;


namespace Sugitec
{

	/// <summary>
	/// 機能コードORD022を送れるようになっています
	/// </summary>
	public partial class frmOrd010 
                            : frmBase
    {

        #region ”　Field　”

        /// <summary>Ord010のDTO</summary>
        private dtoOrd010 dto010 = new dtoOrd010();
		/// <summary>モードを切替</summary>
		private int Mode;
		/// <summary>クリアボタン押下時用ORD022時DataTable</summary>
		private DataTable ForClrClickData = new DataTable();

		#endregion

		#region”　property　”
		
		#endregion

		#region ”　Define　”

        #endregion

        #region ”  Event   ”

		/// <summary>
		/// コンストラクタ（Ord010、Ord021、Ord022）
		/// </summary>
		/// <param name="FCD">タイトル</param>
		/// <param name="OrderNo">最初は空文字</param>
        public frmOrd010(FEATURES FCD, string OrderNo = "")
		{
            InitializeComponent();
			
            try
            {
				//共通処理：コンボボックスを設定
				//契約形態
				this.SetComboList("B01");

				//精算区分
				this.SetComboList("B10");

                //請求書テンプレートファイル
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(clsDefine.Invoice_Path());
                System.Collections.Generic.IEnumerable<System.IO.FileInfo> files = di.EnumerateFiles("*.xlsx", System.IO.SearchOption.TopDirectoryOnly);
                foreach (System.IO.FileInfo f in files)
                {
                    cmbFileNm.Items.Add(f.Name);
                }

                //機能コード設定
                FeaturesCD = FCD;

				//モード切替
				switch(FCD)
				{
					//新規モード
					case FEATURES.ORD010:
						this.InitOrd010();
						break;

					//変更モード
					case FEATURES.ORD021:
						this.InitOrd021(OrderNo);
						break;

					//継続モード
					case FEATURES.ORD022:
						this.InitOrd022(OrderNo);
						break;

				}
			}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

		/// <summary>
		/// 得意先コード入力チェック
		/// </summary>
		private void txtCustomerCd_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                //入力されているか判定 
                if (string.IsNullOrEmpty(txtCustomerCd.Text))
                {
                    //得意先名をクリア
                    lblCustomerNm.Text = string.Empty;
                    return;
                }

                if (txtCustomerCd.Text.PadLeft(8,'0') == txtCustomerCd.OldText)
                {
                    return;
                }

                //得意先マスタ　を　入力された値で見に行く（サービス）
                using (srvOrd010 srv = new srvOrd010())
                {
					//DTOに移送
					dto010.CUSTOMER_CD = txtCustomerCd.Text.PadLeft(8, '0');

					//サービス
					DataTable dt = new DataTable();
                    dt = srv.SelectM_CUSTOMER(dto010);

                    //なければエラー　あれば、得意先名を表示
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("入力した得意先が存在しません",
                            base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);

						//e.cansel = true; →　フォーカスが移動しない
						e.Cancel = true;
						return;
					}

                    //得意先名表示
                    lblCustomerNm.Text = dt.Rows[0][1].ToString();
                    //担当者コンボを作成
                    SetContactCmbList(dt.Rows[0][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, 
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		/// <summary>
		/// 技術者コード入力チェック
		/// </summary>
        private void txtEngineerId_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                //入力されているか判定　 得意先名もクリア
                if (string.IsNullOrEmpty(txtEngineerId.Text))
                {
                    //技術者をクリア
                    lblEngineerNm.Text = string.Empty;

                    return;
                }

                if (txtEngineerId.Text.PadLeft(8,'0') == txtEngineerId.OldText)
                {
                    return;
                }

                //技術者マスタを入力された値で見に行く（サービス）
                using (srvOrd010 srv = new srvOrd010())
                {
                    //サービス
                    DataTable dt = new DataTable();
                    dt = srv.SelectM_Engineer( txtEngineerId.Text.PadLeft(8,'0'));

                    //なければエラー　あれば、得意先名を表示
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("入力した技術者が存在しません",
                            base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);

						//e.cansel = true; →　フォーカスが移動しない
						e.Cancel = true;

						return;

					}
                    //得意先名表示
                    lblEngineerNm.Text = dt.Rows[0][1].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, 
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		/// <summary>
		/// コピー元選択ボタン
		/// </summary>
		private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
				//受注検索画面（frmOrd020）にFEATURES.ORD010を渡し開く
				using (frmOrd020 frm = new frmOrd020(FEATURES.ORD010,true))
                {
                    //画面を開く
                    frm.ShowDialog();

					//受注検索画面からDialogResult.OKが返された場合、
					if (frm.DialogResult == DialogResult.OK)
                    {
						//受注検索画面の受注№プロパティにセットされている受注№で受注Tを取得し画面に表示する
						using (srvOrd010 srv = new srvOrd010())
                        {
                            //DTO に移送：受注No.
                            dto010.ORDER_NO = frm.retOrderNo;

							//データバインド：
							//受注検索画面の受注№プロパティにセットされている受注№で受注Tを取得し画面に表示する
							DataTable dt = new DataTable();
							dt = srv.SelectAllT_ORDER(this.dto010);
							this.SetCustomerTextbox(dt);
							this.SetEngineerTextbox(dt);

							//画面の受注№は空白をセットする
							lblOrderNo.Text = string.Empty;
						}
                    }
				}
			}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, 
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
		
		/// <summary>
		/// 得意先選択ボタン
		/// </summary>
		private void btnCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                //得意先選択画面（frmSrc010）にFEATURES.SRC010を渡し開く
                using (frmSrc010 frm = new frmSrc010(FEATURES.SRC010))
                {
                    //得意先選択画面
                    frm.ShowDialog();

                    //得意先選択画面からDialogResult.OKが返された場合
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        //得意先選択画面のコードプロパティを画面.得意先コード、名称プロパティを画面.得意先名にセットする
                        this.txtCustomerCd.Text = frm.retCode;
                        this.lblCustomerNm.Text = frm.retName;
                        if (txtCustomerCd.Text != txtCustomerCd.OldText)
                        {
                            //担当者コンボを作成
                            SetContactCmbList(txtCustomerCd.Text);
                            txtCustomerCd.OldText = txtCustomerCd.Text;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

		/// <summary>
		/// 技術者選択ボタン
		/// </summary>
        private void btnEngineer_Click_1(object sender, EventArgs e)
        {
            try
            {
                //技術者選択画面（frmSrc010）にFEATURES.SRC010を渡し開く
                using (frmSrc010 frm = new frmSrc010(FEATURES.SRC011))
                {
                    //技術者選択画面
                    frm.ShowDialog();

                    //技術者選択画面からDialogResult.OKが返された場合
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        //技術者選択画面のコードプロパティを画面.技術者ID、名称プロパティを画面.技術者名にセットする
                        this.txtEngineerId.Text = frm.retCode;
                        this.lblEngineerNm.Text = frm.retName;
                        this.txtEngineerId.OldText = frm.retCode;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, 
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		/// <summary>
		/// 確定ボタン
		/// </summary>
		private void btnOk_Click(object sender, EventArgs e)
        {
			try
			{
				//入力チェック
				if (ChkInput() == false) return;

				//実行確認
				if (MessageBox.Show("更新します。よろしいですか？",
						base.FeatureNM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					return;

				//DTO へ 条件を移送
				//継続機能時じゃなければ主キーを画面.受注No.にする
				if(this.Mode != (int)FEATURES.ORD022)
				{
					dto010.ORDER_NO = lblOrderNo.Text;
				}
				dto010.CUSTOMER_ORDER_NO = txtCustomerOrdNo.Text;
				dto010.CUSTOMER_CD		= txtCustomerCd.Text.ToString();

                if (cmbContact.SelectedIndex == -1)
                {
                    dto010.CONTACT_CODE = string.Empty;
                }
                else
                {
                    dto010.CONTACT_CODE = cmbContact.SelectedValue.ToString();
                }

                dto010.PROJECT_NM		= txtProjectNm.Text;
				dto010.WORK_NM			= txtWorkNm.Text;
				dto010.WORK_SPACE		= txtWorkSpace.Text;
				dto010.ENGINEER_ID		= txtEngineerId.Text;
				dto010.UPPER_LIMIT		= nudUpperLimit.Value.ToString();
				dto010.LOWER_LIMIT		= nudLowerLimit.Value.ToString();
				dto010.BASE_RATE		= nudBaseRate.Value.ToString();
				dto010.ORVER_RATE		= nudOrverRate.Value.ToString();
				dto010.SUBTRACT_RATE	= nudSubtractRate.Value.ToString();
				dto010.PROJECT_NO		= "";       //  無しのまま
				dto010.SYNC_FLG			= (int)Sugitec.Common.OperatStatus.OFFLINE;
				dto010.TIME_STAMP		= DateTime.Now.ToString("yyyyMMddhhmmss");

				//日付を8桁の数値に変換してからDTOへ移送 
				dto010.ORDER_YMD		= dtpOrderYmd.Value.ToStringEx();
				dto010.START_YMD		= dtpStartYmd.Value.ToStringEx();
				dto010.END_YMD			= dtpEndYmd.Value.ToStringEx();				

				//コンボボックスの未選択時処理
				if (cmbContractTyp.SelectedIndex == -1)
				{
					dto010.CONTRACT_TYP = string.Empty;
				}
				else
				{
					dto010.CONTRACT_TYP = cmbContractTyp.SelectedValue.ToString();
				}
				if (cmbActuarialKbn.SelectedIndex == -1)
				{
					dto010.ACTUARIAL_KBN = string.Empty;
				}
				else
				{
					dto010.ACTUARIAL_KBN = cmbActuarialKbn.SelectedValue.ToString();
				}
                if (cmbFileNm.SelectedIndex == -1)
                {
                    dto010.INVOICE_FILE_NM = string.Empty;
                }
                else
                {
                    dto010.INVOICE_FILE_NM = cmbFileNm.SelectedItem.ToString();
                        
                }

                //サービス：検索条件から更新する
                using (srvOrd010 srv = new srvOrd010())
				{
					switch (FeaturesCD)
					{
						//新規モード				
						case FEATURES.ORD010:

							//入力した画面項目を受注Tへ登録する
							srv.Insert(dto010);

							//技術者情報の部分のみクリアする
							this.ClearEngineer();
							break;

						//変更モード
						case FEATURES.ORD021:

							//変更した画面項目を受注Tへ更新する
							srv.UPDATE(dto010);

                            //DialogResult.OKを設定
                            this.DialogResult = DialogResult.OK;

                            //画面を閉じる
                            this.Close();
                            break;

						//継続モード
						case FEATURES.ORD022:
							
							//変更した画面項目を受注Tへ追加する
							srv.Insert(dto010);

							//DialogResult.OKを設定
							this.DialogResult = DialogResult.OK;

							//画面を閉じる
							this.Close();
							break;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

		/// <summary>
		/// 削除ボタン
		/// </summary>
		private void btnDel_Click(object sender, EventArgs e)
		{
			try
			{
				//  受注Tの削除フラグを更新する
				using (srvOrd010 srv = new srvOrd010())
				{
					// サービス
					srv.DELETE(this.dto010);
				}

                //  画面を閉じる
                DialogResult = DialogResult.OK;
                Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// クリアボタン
		/// </summary>
		private void btnClr_Click(object sender, EventArgs e)
		{
			try
			{
				switch (FeaturesCD)
				{
					//新規モード時
					case FEATURES.ORD010:

						//得意先情報のテキストボックスの初期化
						this.ClearCustomer();

						//技術者情報のテキストボックスの初期化
						this.ClearEngineer();
						break;

					//変更モード時
					case FEATURES.ORD021:

						//サービス
						using (srvOrd010 srv = new srvOrd010())
						{
							//受注データの表示（変更前の状態に戻す)
							DataTable dt = new DataTable();
							dt = srv.SelectAllT_ORDER(this.dto010);
							this.SetCustomerTextbox(dt);
							this.SetEngineerTextbox(dt);
						}
						break;

					//継続モード時
					case FEATURES.ORD022:

						//サービス
						using(srvOrd010 srv = new srvOrd010())
						{
							//受注データの表示（変更前の状態に戻す)
							//枠線外
							this.SetCustomerTextbox(this.ForClrClickData);
							//枠線内
							this.SetEngineerTextbox(this.ForClrClickData);
							//受注No.は空
							lblOrderNo.Text = string.Empty;
						}
						break;
				}			
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		/// <summary>
		/// 終了ボタン
		/// </summary>
		private void btnEnd_Click(object sender, EventArgs e)
        {			
            this.Close();
        }

		#endregion

		#region ”　Method　”

		/// <summary>
		/// 必須項目のチェックを行います
		/// </summary>
		/// <returns>true：成功　false：失敗</returns>
		private Boolean ChkInput()
		{
			try
			{
				//受注日の必須チェック
				if (string.IsNullOrEmpty(dtpOrderYmd.Value.ToStringEx()))
				{
					MessageBox.Show("受注日が未入力です", 
						base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

				//得意先の必須チェック
				if (string.IsNullOrEmpty(txtCustomerCd.Text))
				{
					MessageBox.Show("得意先が未入力です",
						base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

				//案件名の必須チェック
				if (string.IsNullOrEmpty(txtProjectNm.Text))
				{
					MessageBox.Show("案件名が未入力です", 
						base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

				//技術者IDの必須チェック
				if (string.IsNullOrEmpty(txtEngineerId.Text))
				{
					MessageBox.Show("技術者IDが未入力です", 
						base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

				//精算区分の必須チェック
				if (cmbActuarialKbn.SelectedIndex == -1)
				{
					MessageBox.Show("精算区分が未入力です", 
						base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
								
				//開始期間の必須チェック
				if (string.IsNullOrEmpty(dtpStartYmd.Value.ToStringEx()))
				{
					MessageBox.Show("開始期間が未入力です",
						base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

				//終了期間の必須チェック
				if (string.IsNullOrEmpty(dtpEndYmd.Value.ToStringEx()))
				{
					MessageBox.Show("終了期間が未入力です",
						base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
				
				//基本単価の必須チェック
				if (string.IsNullOrEmpty(nudBaseRate.Value.ToString()))
				{
					MessageBox.Show("基本単価が未入力です", 
						base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

                //期間の整合性チェック
                if (dtpStartYmd.Value > dtpEndYmd.Value)
                {
                    MessageBox.Show("期間の開始、終了が不正です",
                        base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //時間の整合性チェック
                if (nudLowerLimit.Value > nudUpperLimit.Value)
                {
                    MessageBox.Show("時間幅の下限、上限が不正です",
                        base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //対象技術者が他の受注期間と被っている
                using (srvOrd010 srv = new srvOrd010())
                {
                    dtoOrd010 dto = new dtoOrd010();
                    dto.ORDER_NO = lblOrderNo.Text;
                    dto.ENGINEER_ID = txtEngineerId.Text;
                    dto.START_YMD = dtpStartYmd.Value.ToStringEx();
                    dto.END_YMD = dtpEndYmd.Value.ToStringEx();
                    string Msg = srv.CheckDuring(dto);

                    if (Msg != "")
                    {
                        if (MessageBox.Show(Msg, base.FeatureNM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return false;
                        }
                    }
                }

                //成功
                return true;
			}
			catch
			{
				throw;
			}

		}

		/// <summary>
		/// 新規モード時初期処理をします
		/// </summary>
		private void InitOrd010()
		{
			try
			{
				//削除ボタンを使用不可にする
				btnDel.Enabled = false;

				//画面項目クリア
				this.ClearCustomer();
                this.ClearEngineer();
            }
			catch
			{
				throw;
			}						

		}

		/// <summary> 
		/// 変更モード時初期処理をします
		/// </summary>
		private void InitOrd021(string OrderNo)
		{
			try
			{
				//コピー元選択ボタンを使用不可にする
				btnCopy.Enabled = false;

				//サービス：売上Tを受注№で検索し売上が存在すれば下記、項目を制御する
				using(srvOrd010 srv = new srvOrd010())
				{
					//DTOへ移送：OrderNo
					dto010.ORDER_NO = OrderNo;

					//受注TをOrderNo から取得
					DataTable dt = new DataTable();
					dt = srv.SelectAllT_ORDER(this.dto010);

					//受注No.で売上を検索
					int sales = srv.CheckSales(OrderNo);
					//売上が存在した場合
					if(sales > 0)
					{
						//得意先コード、技術者コード、削除ボタンを使用不可にする
						btnDel.Enabled = false;
						txtCustomerCd.Enabled = false;
						txtEngineerId.Enabled = false;

						//検索ボタン（得意先）、検索ボタン（技術者）を使用不可にする
						btnCustomer.Enabled = false;
						btnEngineer.Enabled = false;

						//請求済の場合
						if(sales > 1)
						{
							//精算区分、期間、時間幅、各単価を使用不可にする
							cmbActuarialKbn.Enabled = false;
							dtpStartYmd.Enabled = false;
							dtpEndYmd.Enabled = false;
							nudLowerLimit.Enabled = false;
							nudUpperLimit.Enabled = false;
							nudBaseRate.Enabled = false;
							nudOrverRate.Enabled = false;
							nudSubtractRate.Enabled = false;
						}
					}

					//遷移元から渡された受注№で受注Tを取得し画面に表示する
					//得意先
					this.SetCustomerTextbox(dt);

					//技術者
					this.SetEngineerTextbox(dt);
				}
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 継続モード時初期処理をします
		/// </summary>
		/// <param name="row">遷移元から渡った主キー（受注No.）</param>
		private void InitOrd022(string OrderNo)
		{
			try
			{
				//継続モードに切り替え
				this.Mode = (int)FEATURES.ORD022;

				//DTOに受注No.（主キー）を移送
				this.dto010.ORDER_NO = OrderNo;

				//サービス
				using(srvOrd010 srv = new srvOrd010())
				{
					//遷移元から渡された主キー（受注No.）から情報を取得し、テキストボックスに表示
					DataTable dt = new DataTable();
					dt = srv.SelectAllT_ORDER(dto010);
					this.SetCustomerTextbox(dt);
					this.SetEngineerTextbox(dt);

					//クリアボタン押下時用にフィールドに保持
					this.ForClrClickData = dt;
				}

				//画面初期処理
				//画面.受注No.は空にする
				lblOrderNo.Text = string.Empty;
				//ボタン（使用不可）
				btnCustomer.Enabled = false;
				btnEngineer.Enabled = false;
				btnCopy.Enabled = false;
				btnDel.Enabled = false;
				//テキストボックス
				//受注日
				dtpOrderYmd.Value = DateTime.Today;
				//枠線外（使用不可）
				txtCustomerCd.Enabled = false;
				//枠線内（使用不可）
				txtEngineerId.Enabled = false;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 各コンボボックスのリストを設定します（データバインド）
		/// 契約形態：KBN = B01 精算区分：KBN = B10
		/// </summary>
		private void SetComboList(string KBN)
		{

			try
			{
				//サービス
				using(srvOrd010 srv = new srvOrd010())
				{
					//契約形態取得
					if(KBN == "B01")
					{
						cmbContractTyp.DataSource = srv.SelectM_CODEComboBox(KBN);
						cmbContractTyp.ValueMember = "CODE";
						cmbContractTyp.DisplayMember = "CONTENT";
						cmbContractTyp.SelectedIndex = -1;
					}

					//精算区分取得
					if(KBN == "B10")
					{
						cmbActuarialKbn.DataSource = srv.SelectM_CODEComboBox(KBN);
						cmbActuarialKbn.ValueMember = "CODE";
						cmbActuarialKbn.DisplayMember = "CONTENT";
						cmbActuarialKbn.SelectedIndex = -1;
					}
				}
            }
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// テキストボックスに得意先情報をデータバインドします
		/// </summary>
		/// <param name="dt">srv.SELECT</param>
		private void SetCustomerTextbox(DataTable dt)
        {
            try
            {
                //テキストボックスに各々データテーブルからデータバインドする
				lblOrderNo.Text					= dt.Rows[0]["ORDER_NO"].ToString();
                dtpOrderYmd.Value				= dt.Rows[0]["ORDER_YMD1"].ToDateEx();
                txtCustomerCd.Text				= dt.Rows[0]["CUSTOMER_CD"].ToString();
                txtCustomerCd.OldText           = dt.Rows[0]["CUSTOMER_CD"].ToString();
                lblCustomerNm.Text				= dt.Rows[0]["CusNAME"].ToString();
                txtProjectNm.Text				= dt.Rows[0]["PROJECT_NM"].ToString();
                txtWorkNm.Text					= dt.Rows[0]["WORK_NM"].ToString();
                txtWorkSpace.Text				= dt.Rows[0]["WORK_SPACE"].ToString();
                cmbContractTyp.SelectedValue	= dt.Rows[0]["CONTRACT_TYP"].ToString();
				txtCustomerOrdNo.Text			= dt.Rows[0]["CUSTOMER_ORDER_NO"].ToString();
                cmbFileNm.Text        = dt.Rows[0]["INVOICE_FILE_NM"].ToString();
                SetContactCmbList(txtCustomerCd.Text);
                cmbContact.SelectedValue = dt.Rows[0]["CONTACT_CODE"].ToString();

            }
            catch
            {
                throw;
            }

        }

		/// <summary>
		/// テキストボックスに技術者情報をデータバインドします
		/// </summary>
		/// <param name="dt">srv.SELECT</param>
		private void SetEngineerTextbox(DataTable dt)
        {
            try
            {
                //技術者情報のテキストボックスへデータバインド
                txtEngineerId.Text				= dt.Rows[0]["ENGINEER_ID"].ToString();
                txtEngineerId.OldText           = dt.Rows[0]["ENGINEER_ID"].ToString();
                lblEngineerNm.Text				= dt.Rows[0]["EngNAME"].ToString();
				cmbActuarialKbn.SelectedValue	= dt.Rows[0]["ACTUARIAL_KBN"].ToString();
                dtpStartYmd.Value				= dt.Rows[0]["START_YMD1"].ToDateEx();
                dtpEndYmd.Value					= dt.Rows[0]["END_YMD1"].ToDateEx();
				nudLowerLimit.Value             = dt.Rows[0]["LOWER_LIMIT"].ToDecimalEx();
				nudUpperLimit.Value             = dt.Rows[0]["UPPER_LIMIT"].ToDecimalEx();
                nudBaseRate.Value               = dt.Rows[0]["BASE_RATE"].ToDecimalEx();
				nudOrverRate.Value              = dt.Rows[0]["ORVER_RATE"].ToDecimalEx();
				nudSubtractRate.Value           = dt.Rows[0]["SUBTRACT_RATE"].ToDecimalEx();

				//継続モードの時は一日加算（開始期間に）
				if(this.Mode == (int)FEATURES.ORD022)
				{
					//開始期間を設定（＋１日）
					DateTime date = new DateTime();
					date = DateTime.Parse(dtpEndYmd.Value.ToStringEx("yyyy/MM/dd"));
					dtpStartYmd.Value = date.AddDays(1);
					
					//終了期間を設定（null）
					dtpEndYmd.Value = null;
				}
			}
			catch
            {
                throw;
            }
        }

		/// <summary>
		/// 技術者情報の部分のみ初期化します
		/// </summary>
		private void ClearEngineer()
		{
			try
			{
				//技術者情報のテキストボックスの初期化
				txtEngineerId.Text				= string.Empty;
                txtEngineerId.OldText           = string.Empty;
                lblEngineerNm.Text				= string.Empty;
				cmbActuarialKbn.SelectedIndex	= -1;
				dtpStartYmd.Value				= null;
				dtpEndYmd.Value					= null;
				nudUpperLimit.Value				= 0;
				nudLowerLimit.Value				= 0;
				nudBaseRate.Value				= 0;
				nudOrverRate.Value				= 0;
				nudSubtractRate.Value			= 0;

			}
			catch
			{
				throw;
			}

		}

        /// <summary>
        /// 得意先情報の部分のみ初期化します
        /// </summary>
        private void ClearCustomer()
        {
			try
			{
				//各コントロールをクリア
				//
				//得意先
				lblOrderNo.Text					= string.Empty;
				dtpOrderYmd.Value				= DateTime.Today;
				txtCustomerCd.Text				= string.Empty;
                txtCustomerCd.OldText           = string.Empty;
                lblCustomerNm.Text              = string.Empty;
				txtProjectNm.Text				= string.Empty;
				txtWorkNm.Text					= string.Empty;
				txtWorkSpace.Text				= string.Empty;
				cmbContractTyp.SelectedIndex	= -1;
				txtCustomerOrdNo.Text			= string.Empty;
                SetContactCmbList(txtCustomerCd.Text);
            }
			catch
			{
				throw;
			}
        }

        /// <summary>
        /// 得意先担当者のコンボを作成
        /// </summary>
        /// <param name="CusCode">得意先コード</param>
        private void SetContactCmbList(string CusCode)
        {
            try
            {
                cmbContact.DataSource = null;
                cmbContact.ValueMember = null;
                cmbContact.DisplayMember = null;
                cmbContact.SelectedIndex = -1;

                if (!string.IsNullOrEmpty(CusCode))
                {
                    using (srvOrd010 srv = new srvOrd010())
                    {
                        cmbContact.Text = "";
                        cmbContact.DataSource = srv.SelectM_CONTACTComboBox(CusCode);
                        cmbContact.ValueMember = "CONTACT_CODE";
                        cmbContact.DisplayMember = "CONTACT_NAME";
                        cmbContact.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }


        #endregion

     }
}
