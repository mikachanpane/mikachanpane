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
	public partial class frmReq020 : frmBase
	{
		#region”　Field　”

		#endregion

		#region"  Define  "

		public enum enDgvResult : int
		{
			/// <summary>選</summary>
			dgv_Sel = 0,
			/// <summary>請求年月</summary>
			dgv_BillingYM,
			/// <summary>請求No.</summary>
			dgv_RequestNo,
			/// <summary>枝番</summary>
			dgv_SubNo,
			/// <summary>得意先</summary>
			dgv_CusNm,
			/// <summary>案件名 </summary>
			dgv_PrjNm,
			/// <summary>技術者</summary>
			dgv_EngNm,
			/// <summary>請求金額</summary>
			dgv_BillingAmt,
			/// <summary>請求書</summary>
			dgv_Publish,
			/// <summary>売上No.</summary>
			dgv_SalesNo,
			/// <summary>受注No.</summary>
			dgv_OrderNo = 11
		}

		#endregion

		#region"  Property  "

		#endregion

		#region"  Event  "

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public frmReq020()
		{
			InitializeComponent();

			try
			{
				//機能コードを設定
				FeaturesCD = FEATURES.REQ020;

				//各コンボボックスのリストを作成
				//得意先
				this.SetComboBoxList(cmbCus.Name);
				//技術者
				this.SetComboBoxList(cmbEng.Name);

                //EXCEL2007以前（未インストール含む）の場合はPDF出力、印刷は使用不可
                if (clsDefine.isOutPdfOrPrint)
                {
                    rdoPdf.Enabled = true;
                    rdoPrint.Enabled = true;
                }
                else
                {
                    rdoPdf.Enabled = false;
                    rdoPrint.Enabled = false;
                }

                //各コントロールの初期設定
                InitControl();

				//DataGridViewの初期設定
				InitGridView();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

        /// <summary>
        /// 請求書発行ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void btnOut_Click(object sender, EventArgs e)
		{
			try
			{
				//データ件数チェック
				if (dgv_Result.Rows.Count <= 0)
				{
					MessageBox.Show("データが存在しません",
						base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				
				//行が選択されているかをチェック
				DataTable dt = (DataTable)dgv_Result.DataSource;
                DataRow[] dr = dt.Select("SEL0 = 1");
                if (dr.Length == 0)
                {
                    MessageBox.Show("対象が選択されていません", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //出力確認
                string OutFolder = "";
                FileOutput OutType = FileOutput.PRINTER;
                if (rdoExcel.Checked || rdoPdf.Checked)
                {
                    OutType = rdoExcel.Checked ? FileOutput.EXCEL : FileOutput.PDF;

                    //出力先を指定
                    using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                    {
                        //上部に表示する説明テキストを指定する
                        fbd.Description = "保存先のフォルダを指定してください。";
                        //ルートフォルダを指定する
                        fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
                        //ユーザーが新しいフォルダを作成できるようにする
                        fbd.ShowNewFolderButton = true;
                        //ダイアログを表示する
                        if (fbd.ShowDialog(this) != DialogResult.OK)
                        {
                            return;
                        }
                        OutFolder = fbd.SelectedPath + @"\";
                    }
                }
                else
                {
                    OutType = FileOutput.PRINTER;
                    if (MessageBox.Show("請求書を発行します。よろしいですか？", base.FeatureNM, 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                }

                //請求書発行
                using (srvReq020 srv = new srvReq020())
                {
                    srv.OutputInvoice(dt, OutFolder, OutType);
                }

                MessageBox.Show("請求書を発行しました。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSearch_Click(btnSearch, e);

            }
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnMore_Click(object sender, EventArgs e)
		{
			try
			{
				//行が選択されているかをチェック
				DataTable dt = new DataTable();
				dt = (DataTable)dgv_Result.DataSource;
				foreach(DataRow row in dt.Rows)
				{
					if(row[0].ToString() == "1")
					{
						//サービス
						using(srvReq020 srv = new srvReq020()) { }
						return;
					}
				}

				//エラー処理
				MessageBox.Show("行を選択して下さい",
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        /// <summary>
        /// 検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				//必須チェック
				if(!this.ChkInput()) return;

				//DTOに移送
				dtoReq020 dtoreq020 = new dtoReq020();
				//ラジオボタン：請求年月（個別）
				if(rdoReq1.Checked)
				{
					dtoreq020.mtbBillingYm = mtbBillingYm.Text;
				}
				//ラジオボタン：請求年月（範囲）
				if(rdoReq2.Checked)
				{
					dtoreq020.mtbBillingYmF = mtbBillingYmF.Text;
					dtoreq020.mtbBillingYmT = mtbBillingYmT.Text;
				}
				//ラジオボタン：得意先（個別）
				if(rdoCus1.Checked)
				{
					dtoreq020.cmbCus = cmbCus.SelectedValue.ToString();
				}
				//ラジオボタン：得意先（範囲）
				if(rdoCus2.Checked)
				{
					dtoreq020.txtCusF = txtCusF.Text;
					dtoreq020.txtCusT = txtCusT.Text;
				}
				//ラジオボタン：技術者（個別）
				if(rdoCus1.Checked)
				{
					dtoreq020.cmbEng = cmbEng.SelectedValue.ToString();
				}
				//ラジオボタン：技術者（範囲）
				if(rdoCus2.Checked)
				{
					dtoreq020.txtEngF = txtEngF.Text;
					dtoreq020.txtEngT = txtEngT.Text;
				}

				//請求締め日
				dtoreq020.txtSime = txtSime.Text;

				//ラジオボタン：全て、発行済み、未発行
				if(rdoBillAll.Checked) dtoreq020.PUBLISH_FLG = string.Empty;

				if(rdoBillUnpublished.Checked) dtoreq020.PUBLISH_FLG = "0";

				if(rdoBillIssued.Checked) dtoreq020.PUBLISH_FLG = "1";

				//サービス
				using(srvReq020 srv = new srvReq020())
				{
					//DataGridViewの表示項目を取得
					dgv_Result.DataSource = srv.Select(dtoreq020);

					//DataGridViewにデータバインド
					this.SetGridView();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        /// <summary>
        /// クリアボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClr_Click(object sender, EventArgs e)
		{
			try
			{

                //画面初期化
                InitControl();

				//DataGridView
				dgv_Result.DataSource = null;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        /// <summary>
        /// 終了ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region"  Method  "

		/// <summary>
		/// 必須チェックを行う
		/// </summary>
		/// <returns></returns>
		private bool ChkInput()
		{
			try
			{
				//ラジオボタン（その先のテキストボックス）
				//請求年月が個別指定かつ未入力ならエラー
				if(rdoReq1.Checked && string.IsNullOrEmpty(mtbBillingYm.Text))
				{
					MessageBox.Show("請求年月を入力して下さい",
						base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
				//請求年月が範囲指定かつ未入力ならエラー
				if(rdoReq2.Checked)
				{
					//未入力
					if(string.IsNullOrEmpty(mtbBillingYmF.Text))
					{						
						MessageBox.Show("請求年月範囲を入力して下さい",
							base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
					//整合性
					if(mtbBillingYmF.Text.ToDecimalEx() > mtbBillingYmT.Text.ToDecimalEx())
					{
						MessageBox.Show("請求年月期間が不正です",
							base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}

				}
				//技術者が個別指定かつ未入力ならエラー
				if(rdoEng1.Checked && string.IsNullOrEmpty(cmbEng.Text))
				{
					MessageBox.Show("技術者を入力して下さい",
						base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
				//技術者が範囲指定かつ未入力ならエラー
				if(rdoEng2.Checked)
				{
					//未入力
					if(string.IsNullOrEmpty(txtEngF.Text))
					{
						MessageBox.Show("技術者コードの範囲を入力して下さい",
							base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
					//整合性
					if(txtEngF.Text.ToDecimalEx() > txtEngT.Text.ToDecimalEx())
					{
						MessageBox.Show("技術者コードの範囲が不正です",
							base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}

				}
				//得意先が個別指定かつ未入力ならラー
				if(rdoCus1.Checked && string.IsNullOrEmpty(cmbCus.Text))
				{
					MessageBox.Show("得意先を入力して下さい",
						base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
				//得意先が範囲指定かつ未入力ならエラー
				if(rdoCus2.Checked)
				{
					//未入力
					if(string.IsNullOrEmpty(txtCusF.Text))
					{
						MessageBox.Show("得意先の開始範囲を入力して下さい",
							base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
					//整合性
					if(txtCusF.Text.ToDecimalEx() > txtCusT.Text.ToDecimalEx())
					{
						MessageBox.Show("得意先コードの範囲が不正です",
							base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}

				}

				//正常終了
				return true;

				/// ”没案”： 請求年月が範囲指定の場合 請求年月（From）が未入力ならfalseを返す
				///else if(rdoSal2.Checked == true && string.IsNullOrEmpty(mtbBillingYmF.Text)
				///&& string.IsNullOrEmpty(mtbBillingYmT.Text))
				///{
				///MessageBox.Show("請求年月を入力してください。",
				///base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
				///return false;
				///}
				///得意先が個別指定の場合、得意先用コンボボックスが未選択なら
				///if(rdoCus1.Checked == true && cmbCus.SelectedIndex == -1)
				///{
				///MessageBox.Show("得意先を選択してください。",
				///base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
				///return false;
				///}
				///得意先が範囲指定の場合、得意先（From）が未入力なら
				///else if(rdoCus2.Checked == true && string.IsNullOrEmpty(txtCusF.Text)
				///&& string.IsNullOrEmpty(txtCusT.Text))
				///{
				///MessageBox.Show("得意先を選択してください。",
				///base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
				///return false;
				///}
			}
			catch
			{
				throw;
			}

		}

		/// <summary>
		/// 各コントロールの初期設定
		/// </summary>
		private void InitControl()
		{
			try
			{
				//請求年月
				rdoReq1.Checked = true;
				mtbBillingYm.Text = DateTime.Now.AddMonths(-1).ToString("yyyy/MM");
				mtbBillingYmF.Text = string.Empty;
				mtbBillingYmT.Text = string.Empty;
				//技術者
				rdoEng1.Checked = true;
				cmbEng.SelectedIndex = 0; //データバインド後に0に変更
				txtEngF.Text = string.Empty;
				txtEngT.Text = string.Empty;
				//得意先
				rdoCus1.Checked = true;
				cmbCus.SelectedIndex = 0; //データバインド後に0に変更
				txtCusF.Text = string.Empty;
				txtCusT.Text = string.Empty;
				//締日
				txtSime.Text = string.Empty;
                //請求書
                rdoBillUnpublished.Checked = true;
                //出力形式
                rdoExcel.Checked = true;
            }
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// DataGridViewの初期設定
		/// </summary>
		private void InitGridView()
		{
			try
			{
				//列自動追加を解除
				dgv_Result.AutoGenerateColumns = false;
				//データソースを解除
				dgv_Result.DataSource = null;
				//ヘッダーテキストの位置調整
				//dgv_Result.Columns["dgv_Sel"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				//dgv_Result.Columns["dgv_BillingYM"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				//dgv_Result.Columns["dgv_RequestNo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				//dgv_Result.Columns["dgv_SubNo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				//dgv_Result.Columns["dgv_CusCd"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				//dgv_Result.Columns["dgv_CusNm"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				//dgv_Result.Columns["dgv_PrjNm"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				//dgv_Result.Columns["dgv_EngNm"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				//dgv_Result.Columns["dgv_BillingAmt"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				//dgv_Result.Columns["dgv_Publish"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				//dgv_Result.Columns["dgv_SalesNo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				//dgv_Result.Columns["dgv_OrderNo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				//列の位置調整
				dgv_Result.Columns["dgv_Sel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dgv_Result.Columns["dgv_BillingYM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dgv_Result.Columns["dgv_RequestNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dgv_Result.Columns["dgv_SubNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dgv_Result.Columns["dgv_CusCd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dgv_Result.Columns["dgv_CusNm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
				dgv_Result.Columns["dgv_PrjNm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
				dgv_Result.Columns["dgv_EngNm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
				dgv_Result.Columns["dgv_BillingAmt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dgv_Result.Columns["dgv_Publish"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dgv_Result.Columns["dgv_SalesNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dgv_Result.Columns["dgv_OrderNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				//列の書式設定
				dgv_Result.Columns["dgv_BillingAmt"].DefaultCellStyle.Format = "#,0";
				//列の幅指定
				dgv_Result.Columns["dgv_Sel"].Width = 30;
				dgv_Result.Columns["dgv_BillingYM"].Width = 80;
				dgv_Result.Columns["dgv_RequestNo"].Width = 80;
				dgv_Result.Columns["dgv_SubNo"].Width = 40;
				dgv_Result.Columns["dgv_CusCd"].Width = 100;
				dgv_Result.Columns["dgv_CusNm"].Width = 150;
				dgv_Result.Columns["dgv_PrjNm"].Width = 150;
				dgv_Result.Columns["dgv_EngNm"].Width = 150;
				dgv_Result.Columns["dgv_BillingAmt"].Width = 100;
				dgv_Result.Columns["dgv_Publish"].Width = 100;
				dgv_Result.Columns["dgv_SalesNo"].Width = 80;
				dgv_Result.Columns["dgv_OrderNo"].Width = 80;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// DataGridViewへのデータバインド
		/// </summary>
		private void SetGridView()
		{
			try
			{
				dgv_Result.Columns["dgv_Sel"].DataPropertyName = "SEL0";
				dgv_Result.Columns["dgv_BillingYM"].DataPropertyName = "BILLING_YM";
				dgv_Result.Columns["dgv_RequestNo"].DataPropertyName = "REQUEST_NO";
				dgv_Result.Columns["dgv_SubNo"].DataPropertyName = "REQUEST_SUB_NO";
				dgv_Result.Columns["dgv_CusNm"].DataPropertyName = "CUSNAME";
				dgv_Result.Columns["dgv_PrjNm"].DataPropertyName = "PROJECT_NM";
				dgv_Result.Columns["dgv_EngNm"].DataPropertyName = "ENGNAME";
				dgv_Result.Columns["dgv_BillingAmt"].DataPropertyName = "BILLING_AMOUNT";
				dgv_Result.Columns["dgv_Publish"].DataPropertyName = "SEL1";
				dgv_Result.Columns["dgv_SalesNo"].DataPropertyName = "SALES_NO";
				dgv_Result.Columns["dgv_OrderNo"].DataPropertyName = "ORDER_NO";
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// コンボボックスの表示項目を設定
		/// sectionには、コンボボックス.Nameを送って下さい
		/// </summary>
		private void SetComboBoxList(string section)
		{
			try
			{
				//  サービス
				using(srvReq020 srv = new srvReq020())
				{
					//得意先
					if(section == cmbCus.Name)
					{
						//得意先情報のコンボボックスの表示項目を取得
						DataTable dt = new DataTable();
						dt = srv.SelectCustomerComboBox();

						//"00000000" と "全てを追加"
						DataRow row;
						row = dt.NewRow();
						row[0] = "00000000";
						row[1] = "全て";
						dt.Rows.InsertAt(row, 0);

						//データバインド
						cmbCus.DataSource = dt;
						cmbCus.ValueMember = "CUSTOMER_CD";
						cmbCus.DisplayMember = "NAME";
						cmbCus.SelectedIndex = -1;
					}

					//技術者
					if(section == cmbEng.Name)
					{
						//技術者情報のコンボボックスの表示項目を取得
						DataTable dt = new DataTable();
						dt = srv.SelectEngineerComboBox();

						//"00000000" と "全てを追加"
						DataRow row;
						row = dt.NewRow();
						row[0] = "00000000";
						row[1] = "全て";
						dt.Rows.InsertAt(row, 0);

						//データバインド
						cmbEng.DataSource = dt;
						cmbEng.ValueMember = "ENGINEER_ID";
						cmbEng.DisplayMember = "NAME";
						cmbEng.SelectedIndex = -1;
					}					
				}
			}
			catch
			{
				throw;
			}
		}

		#endregion
	}
}