using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

using Sugitec.Common;
using Sugitec.Logics;



namespace Sugitec
{
	public partial class frmInq010 : frmBase
	{
		#region”　Event　”

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public frmInq010()
		{
			InitializeComponent();

			try
			{
				//機能コードをセット：INQ010
				base.FeaturesCD = FEATURES.INQ010;

				//DataGridView初期設定
				this.InitGridView();

                //EXCEL2007以前（未インストール含む）の場合はPDF出力、印刷は使用不可
                if (clsDefine.isOutPdfOrPrint)
                {
                    btn_PDF.Enabled = true;
                    btnPrint.Enabled = true;
                }
                else
                {
                    btn_PDF.Enabled = false;
                    btnPrint.Enabled = false;
                }
            }
            catch (Exception ex)
			{
				MessageBox.Show(ex.Message,
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// 検索ボタン
		/// </summary>
		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				//入力チェック
				if(!this.ChkInput()) return;

				//サービス
				using(srvInq010 srv = new srvInq010())
				{
					//DTOに移送
					dtoInq010 dto = new dtoInq010();
					dto.SALES_YM = txtSalYm.Text;

					//得意先別の場合
					DataTable dt = new DataTable();
					if(rdoCus.Checked)
					{
						//再度DataGridView初期化
						this.InitGridView();

						//DataGridView用データ
						dt = srv.SelectCus(dto);

						//データがなければ終了する 合計値もクリアする
						if(dt.Rows.Count <= 0)
						{
							//パネルの初期化
							this.ClrPanel();
							return;
						}

						//DataGridViewへデータバインド	
						this.SetGridView(dt);

						//パネルの表示
						this.SetPanel(dt);
					}
					//担当者別の場合
					if(rdoEng.Checked)
					{
						//再度DataGridView初期化
						this.InitGridView(true);

						//DataGridView用データ
						dt = srv.SelectEng(dto);

						//データがなければユーザーに知らせ、終了する 合計値もクリアする
						if(dt.Rows.Count <= 0)
						{
							MessageBox.Show("データが0件です",
								base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Warning);

							//パネルの初期化
							this.ClrPanel(true);
							return;
						}

						//DataGridViewへデータバインド					
						this.SetGridView(dt);

						//パネルの表示
						this.SetPanel(dt, true);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        /// <summary>
        /// EXCELに出力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_output_Click(object sender, EventArgs e)
        {
            try
            {
                //必須入力チェック
                if (!this.ChkInput(true)) return;

                //出力確認
                string OutFolder = "";
                FileOutput Output = FileOutput.PRINTER;

                Button btn = (Button)sender;
				if (btn.Name == "btn_Excel" || btn.Name == "btn_PDF")
				{
					Output = btn.Name == "btn_Excel" ? FileOutput.EXCEL : FileOutput.PDF;

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
						if (fbd.ShowDialog(this) != DialogResult.OK) return;
						OutFolder = fbd.SelectedPath + @"\";
					}
				}
				else
				{
					Output = FileOutput.PRINTER;
					if (MessageBox.Show("売上帳を出力します。よろしいですか？",
							base.FeatureNM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
						return;
				}

                //サービス
                using (srvInq010 srv = new srvInq010())
                {
                    //売上帳出力（ClosedXML 出力）
                    if (srv.MakeMonthlyExcelWookBook((DataTable)dgv_Result.DataSource, Output , OutFolder, txtSalYm.Text))
                    {
                        MessageBox.Show("売上帳を出力しました",
                            base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// クリアボタン
        /// </summary>
        private void btnClr_Click(object sender, EventArgs e)
		{
			try
			{
				//各コントロールを初期化
				this.InitControl();
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
		private void btnEnd_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region”　Method　”

		/// <summary>
		/// 各コントロールの初期化をします
		/// </summary>
		private void InitControl()
		{
			try
			{
				//DataGridViewのデータソースを解除
				dgv_Result.DataSource = null;
				//入金年月のテキストボックス
				txtSalYm.Text = string.Empty;
				//ラジオボタン：得意先別を選択
				rdoCus.Checked = true;
				//合計欄
				lblSalSum.Text = "0";
				lblCash.Text = "0";
				lblDepo.Text = "0";
				lblBill.Text = "0";
				lblTransf.Text = "0";
				lblDis.Text = "0";
				lblDiff.Text = "0";
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// DataGridViewの初期設定をします
		/// </summary>
		/// <param name="IsEngineerCheck">摘要行を表示するか</param>
		private void InitGridView(Boolean IsEngineerCheck = false)
		{
			try
			{
				//列自動追加を解除
				dgv_Result.AutoGenerateColumns = false;
				//データソースを解除
				dgv_Result.DataSource = null;

                //列の位置調整
                dgv_Result.Columns["dgv_Cus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_Result.Columns["dgv_Sime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_Teki"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_Result.Columns["dgv_SalYm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_SumSal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_Cash"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_Depo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_Bill"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_BillY"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_Transf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_Dis"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_Cancel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_Diff"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_DiffContent"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                //列の書式設定
                dgv_Result.Columns["dgv_SumSal"].DefaultCellStyle.Format = "#,0";
				dgv_Result.Columns["dgv_Cash"].DefaultCellStyle.Format = "#,0";
				dgv_Result.Columns["dgv_Depo"].DefaultCellStyle.Format = "#,0";
				dgv_Result.Columns["dgv_Bill"].DefaultCellStyle.Format = "#,0";
				dgv_Result.Columns["dgv_Cancel"].DefaultCellStyle.Format = "#,0";
				dgv_Result.Columns["dgv_Transf"].DefaultCellStyle.Format = "#,0";
				dgv_Result.Columns["dgv_Dis"].DefaultCellStyle.Format = "#,0";
				dgv_Result.Columns["dgv_Diff"].DefaultCellStyle.Format = "#,0";
				//列の幅指定：担当者別の場合適用
				if(IsEngineerCheck)
				{
					dgv_Result.Columns["dgv_Cus"].Width = 160;
					dgv_Result.Columns["dgv_Sime"].Width = 30;
					dgv_Result.Columns["dgv_Teki"].Width = 80;
					dgv_Result.Columns["dgv_SalYm"].Width = 80;
					dgv_Result.Columns["dgv_SumSal"].Width = 120;
					dgv_Result.Columns["dgv_Cash"].Width = 100;
					dgv_Result.Columns["dgv_Depo"].Width = 70;
					dgv_Result.Columns["dgv_Bill"].Width = 70;
					dgv_Result.Columns["dgv_BillY"].Width = 80;
					dgv_Result.Columns["dgv_Transf"].Width = 80;
					dgv_Result.Columns["dgv_Dis"].Width = 80;
					dgv_Result.Columns["dgv_Cancel"].Width = 80;
					dgv_Result.Columns["dgv_Diff"].Width = 80;
					dgv_Result.Columns["dgv_DiffContent"].Width = 100;
					//摘要行を表示する
					//dgv_Result.Columns["dgv_Teki"].Visible = true;
				}
				//列の幅指定：得意先別の場合適用
				else
				{
					dgv_Result.Columns["dgv_Cus"].Width = 160;
					dgv_Result.Columns["dgv_Sime"].Width = 30;
					dgv_Result.Columns["dgv_Teki"].Width = 80;
					dgv_Result.Columns["dgv_SalYm"].Width = 80;
					dgv_Result.Columns["dgv_SumSal"].Width = 120;
					dgv_Result.Columns["dgv_Cash"].Width = 100;
					dgv_Result.Columns["dgv_Depo"].Width = 70;
					dgv_Result.Columns["dgv_Bill"].Width = 70;
					dgv_Result.Columns["dgv_BillY"].Width = 80;
					dgv_Result.Columns["dgv_Transf"].Width = 80;
					dgv_Result.Columns["dgv_Dis"].Width = 80;
					dgv_Result.Columns["dgv_Cancel"].Width = 80;
					dgv_Result.Columns["dgv_Diff"].Width = 80;
					dgv_Result.Columns["dgv_DiffContent"].Width = 100;
					//摘要行を非表示にする
					//dgv_Result.Columns["dgv_Teki"].Visible = false;
				}
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// パネルの中のラベルをクリアします
		/// </summary>
		/// <param name="IsEngineerCheck">担当者別がチェックされているか</param>
		private void ClrPanel(Boolean IsEngineerCheck = false)
		{
			lblSalSum.Text = "0";
			lblCash.Text = "0";
			lblDepo.Text = "0";
			lblBill.Text = "0";
			lblTransf.Text = "0";
			lblDis.Text = "0";
			lblDiff.Text = "0";
		}

		/// <summary>
		/// 入力チェックを行います
		/// </summary>
		/// <param name="isGridClear">DataGridViewを対象に含めるか</param>
		/// <returns>OK：true、NG：false</returns>
		private Boolean ChkInput(Boolean isGridCheck = false)
		{
			try
			{
				//DataGridViewのデータが0件の時エラー
				if(isGridCheck)
				{
					if(this.dgv_Result.Rows.Count <= 0)
					{
						MessageBox.Show("データが0件の場合はデータ出力ができません",
							base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}

				//テキストボックス
				//売上年月
				if(txtSalYm.Text == string.Empty)
				{
					MessageBox.Show("売上年月を入力して下さい",
						base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		/// <summary>
		/// DataGridViewへのデータバインドをします
		/// データバインドする前に、DataTableを整形します
		/// </summary>
		/// <param name="dt">サービスから返るDataTable</param>
		/// <param name="IsEngineerCheck">摘要行を表示するか</param>
		private void SetGridView(DataTable dt)
		{
			try
			{
				//DataTableの整形
				foreach(DataRow row in dt.Rows)
				{
					//差額を計算する
					row["差額"] = row["売上金額"].ToDecimalEx()
									- (row["現金"].ToDecimalEx() + row["預金"].ToDecimalEx() + row["手形"].ToDecimalEx()
										+ row["振込手数料"].ToDecimalEx() + row["値引"].ToDecimalEx() + row["キャンセル"].ToDecimalEx());

					//締め日：99なら末日に変更
					if(row["締"].ToString() == "99")
					{
						row["締"] = DateTime.DaysInMonth(Convert.ToInt32(txtSalYm.Text.Substring(0, 4)),
																	Convert.ToInt32(txtSalYm.Text.Substring(4)));
					}
				}
				//データバインド
				dgv_Result.DataSource = dt;
				dgv_Result.Columns["dgv_Cus"].DataPropertyName = "得意先";
				dgv_Result.Columns["dgv_Sime"].DataPropertyName = "締";
				dgv_Result.Columns["dgv_Teki"].DataPropertyName = "摘要";
				dgv_Result.Columns["dgv_SalYm"].DataPropertyName = "入金日";
				dgv_Result.Columns["dgv_SumSal"].DataPropertyName = "売上金額";
				dgv_Result.Columns["dgv_Cash"].DataPropertyName = "現金";
				dgv_Result.Columns["dgv_Depo"].DataPropertyName = "預金";
				dgv_Result.Columns["dgv_Bill"].DataPropertyName = "手形";
				dgv_Result.Columns["dgv_BillY"].DataPropertyName = "手形受取日";
				dgv_Result.Columns["dgv_Transf"].DataPropertyName = "振込手数料";
				dgv_Result.Columns["dgv_Dis"].DataPropertyName = "値引";
				dgv_Result.Columns["dgv_Cancel"].DataPropertyName = "キャンセル";
				dgv_Result.Columns["dgv_Diff"].DataPropertyName = "差額";
				dgv_Result.Columns["dgv_DiffContent"].DataPropertyName = "差額理由";
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// DataGridViewの下のラベルに各項目の合計値を設定します
		/// </summary>
		/// <param name="dt">DataGridView.DataSource</param>
		/// <param name="IsEngineerCheck">担当者別に表示するか</param>
		private void SetPanel(DataTable dt, Boolean IsEngineerCheck = false)
		{
			try
			{
				//DataGridViewの下のラベルに各項目の合計値を設定します
				lblSalSum.Text = dt.Compute("Sum(売上金額)", "").ToAmountEx();
				lblCash.Text = dt.Compute("SUM(現金)", "").ToAmountEx();
				lblDepo.Text = dt.Compute("Sum(預金)", "").ToAmountEx();
				lblBill.Text = dt.Compute("Sum(手形)", "").ToAmountEx();
				lblTransf.Text = dt.Compute("Sum(振込手数料)", "").ToAmountEx();
				lblDis.Text = dt.Compute("Sum(値引)", "").ToAmountEx();
				lblCancel.Text = dt.Compute("Sum(キャンセル)", "").ToAmountEx();
				lblDiff.Text = dt.Compute("Sum(差額)", "").ToAmountEx();
			}
			catch
			{
				throw;
			}
		}

        #endregion                
    }
}
