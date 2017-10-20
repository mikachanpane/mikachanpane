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
    public partial class frmOrd020 : frmBase
    {

        #region"Define"

        /// <summary>遷移元機能コード</summary>
        private FEATURES _Migration;

        #endregion

        #region"Property"

        /// <summary>選択した受注№</summary>
        public string retOrderNo { get; set; }

        #endregion

        #region"Event"

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="Migration">機能コード</param>
		/// <param name="IsCopyCheck">コピー元選択ボタンから遷移したかどうか</param>
        public frmOrd020(FEATURES Migration, Boolean IsCopyCheck = false)
        {
            InitializeComponent();

            _Migration = Migration;
            retOrderNo = "";

            //機能コードを設定
            FeaturesCD = FEATURES.ORD020;

            //各コンボボックスのリストを作成
            MakeComboList();

            //画面初期化
            CLRData();

            //DataGridViewの初期設定
            InitGridView();

			//コピー元選択ボタンから遷移した場合は、継続ボタン使用不可
			if(IsCopyCheck)
			{
				btnContinue.Enabled = false;
			}
        }

        /// <summary>
        /// 検索
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                GetData();
                dgv_Result.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		/// <summary>
		/// 継続ボタン
		/// </summary>
		private void btnContinue_Click(object sender, EventArgs e)
		{
			try
			{
				//DataGridViewのデータチェック
				if (dgv_Result.Rows.Count <= 0)
				{
					MessageBox.Show("データが存在しません",
						base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				//現在DataGridviewで選択されている行を調べる
				foreach (DataGridViewRow row in dgv_Result.SelectedRows)
				{
					//選択されていれば主キーを設定（受注No.）
					retOrderNo = row.Cells[0].Value.ToString();

					//受注No.、技術者IDを新しい受注画面（ORD010）に渡して継続機能（ORD022）で開く
					using (frmOrd010 frm = new frmOrd010(FCD: FEATURES.ORD022, OrderNo: this.retOrderNo))
					{
						frm.ShowDialog();

						//DialogResult.OKが取得できれば以下を実行し処理を抜ける
						if (frm.DialogResult == DialogResult.OK)
						{
							//再度、検索結果をDataGridViewに表示						
							GetData();

							//先頭行を選択
							this.dgv_Result.Rows[0].Selected = true;

							return;
						}
						//DialogResult.OKが取得できなければなにもせずに処理を抜ける
						return;
					}
				}

				//何も選択されていなければエラー
				MessageBox.Show("対象行を選択してください",
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			catch
			{
				throw;
			}

		}

		/// <summary>
		/// 確定ボタン
		/// </summary>
		private void btnOk_Click(object sender, EventArgs e)
		{
			try
			{
				//DataGridViewのデータチェック
				if (dgv_Result.Rows.Count <= 0)
				{
					MessageBox.Show("データが存在しません",
						base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				//選択行チェック
				if (dgv_Result.CurrentCell != null)
				{
					//選択行をセット
					retOrderNo = (string)dgv_Result["dgv_ordNo", dgv_Result.CurrentCell.RowIndex].Value;

					//DialogResult.OKを設定して画面を閉じる
					if (_Migration == FEATURES.ORD010)
					{
						this.DialogResult = DialogResult.OK;
						Close();
						return;
					}
					else
					{
						//frmOrd010
						using (frmOrd010 frm010 = new frmOrd010(FEATURES.ORD021, OrderNo: retOrderNo))
						{
							//画面遷移
							frm010.ShowDialog();

							//DialogResult.OKが取得できれば以下を実行し処理を抜ける
							if (frm010.DialogResult == DialogResult.OK)
							{
								//再度、検索結果をDataGridViewに表示						
								GetData();

								//先頭行を選択
								this.dgv_Result.Rows[0].Selected = true;

								return;
							}
							//取得できなれば何もせずに処理を抜ける
							return;
						}
					}
				}
				//何も選択されていなければエラー
				MessageBox.Show("対象行を選択してください",
					base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// 終了ボタン
		/// </summary>
		private void btnEnd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Migration == FEATURES.ORD010)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// クリアボタン押下
        /// </summary>
        private void btnClr_Click(object sender, EventArgs e)
        {
            try
            {
                CLRData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region"Method"

        /// <summary>
        /// 各コンボボックスのリストを作成
        /// </summary>
        private void MakeComboList()
        {
            try
            {
                DataTable EngTable = new DataTable();
                DataTable CUSTable = new DataTable();

                using (srvOrd020 srv = new srvOrd020())
                {
                    EngTable = srv.SelectEng();
                    CUSTable = srv.SelectCus();
                }

                DataRow row;
                //技術者
                row = EngTable.NewRow();
                row[0] = "00000000";
                row[1] = "全て";
                EngTable.Rows.InsertAt(row, 0);
                cmbEng.DataSource = EngTable;
                cmbEng.ValueMember = "ENGINEER_ID";
                cmbEng.DisplayMember = "NAME";

                //得意先
                row = CUSTable.NewRow();
                row[0] = "00000000";
                row[1] = "全て";
                CUSTable.Rows.InsertAt(row, 0);
                cmbCus.DataSource = CUSTable;
                cmbCus.ValueMember = "CUSTOMER_CD";
                cmbCus.DisplayMember = "NAME";
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// データを取得する。
        /// </summary>
        private void GetData()
        {
            try
            {
                dtoOrd020 dto = new dtoOrd020();
                dto.OrderNoF = txtOrderNoFrom.Text;
                dto.OrderNoT = txtOrderNoTo.Text;
                dto.OrderStartYmF = mtbSaleYmF.Text;
                dto.OrderStartYmT = mtbSaleYmT.Text;
                dto.CusCode = cmbCus.SelectedValue.ToString();
                dto.CusCodeF = txtCusF.Text;
                dto.CusCodeT = txtCusT.Text;
                dto.EngId = cmbCus.SelectedValue.ToString();
                dto.EngIdF = txtEngF.Text;
                dto.EngIdT = txtEngT.Text;
                dto.PrjName = txtProjectNm.Text;
                dto.CusOrdNo = txtCusOrdNo.Text;

                using (srvOrd020 svc = new srvOrd020())
                {
                    dgv_Result.SuspendLayout();
                    dgv_Result.DataSource = null;
                    DataTable getdt = new DataTable();
                    getdt = svc.Select(dto);
                    SetData(getdt);
                    dgv_Result.ResumeLayout(true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 取得したデータをDataGridViewの列と関連付けする。
        /// </summary>
        /// <param name="dt">選択クエリ結果</param>
        private void SetData(DataTable dt)
        {
            try
            {
                dgv_Result.DataSource = dt;
                dgv_Result.Columns["dgv_ordNo"].DataPropertyName = "ORDER_NO";
                dgv_Result.Columns["dgv_CusOrdNo"].DataPropertyName = "CUSTOMER_ORDER_NO";
                dgv_Result.Columns["dgv_ordYMD"].DataPropertyName = "ORDER_YMD";
                dgv_Result.Columns["dgv_ordPrjnm"].DataPropertyName = "PROJECT_NM";
                dgv_Result.Columns["dgv_OrdCusCd"].DataPropertyName = "CUSTOMER_CD";
                dgv_Result.Columns["dgv_OrdCus"].DataPropertyName = "CUSNAME";
                dgv_Result.Columns["dgv_OrdContTyp"].DataPropertyName = "CONTRACT_TYP";
                dgv_Result.Columns["dgv_OrdEngId"].DataPropertyName = "ENGINEER_ID";
                dgv_Result.Columns["dgv_OrdEngNm"].DataPropertyName = "ENGNAME";
                dgv_Result.Columns["dgv_OrdActkbn"].DataPropertyName = "ACTUARIAL_KBN";
                dgv_Result.Columns["dgv_OrdStrYMD"].DataPropertyName = "START_YMD";
                dgv_Result.Columns["dgv_OrdEndYMD"].DataPropertyName = "END_YMD";
                dgv_Result.Columns["dgv_OrdOlimit"].DataPropertyName = "UPPER_LIMIT";
                dgv_Result.Columns["dgv_OrdUlimit"].DataPropertyName = "LOWER_LIMIT";
                dgv_Result.Columns["dgv_OrdBaseRate"].DataPropertyName = "BASE_RATE";
                dgv_Result.Columns["dvg_OrdOvRate"].DataPropertyName = "ORVER_RATE";
                dgv_Result.Columns["dgv_OrdSubRate"].DataPropertyName = "SUBTRACT_RATE";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 初期化
        /// </summary>
        private void CLRData()
        {
            try
            {
                txtOrderNoFrom.Text = "00000000";
                txtOrderNoTo.Text = "99999999";
                mtbSaleYmF.Text = DateTime.Now.AddMonths(-3).ToString("yyyy/MM"); ;
                mtbSaleYmT.Text = DateTime.Now.AddMonths(3).ToString("yyyy/MM"); ;
                txtCusOrdNo.Text = string.Empty;
                rdoCus1.Checked = true;
                cmbCus.SelectedIndex = 0;
                txtCusF.Text = "00000000";
                txtCusT.Text = "99999999";
                rdoEng1.Checked = true;
                cmbEng.SelectedIndex = 0;
                txtEngF.Text = "00000000";
                txtEngT.Text = "99999999";
                txtProjectNm.Text = string.Empty;
                retOrderNo = string.Empty;
                dgv_Result.SuspendLayout();
                dgv_Result.DataSource = null;
            }
            catch
            {
                throw;
            }
            finally
            {
                dgv_Result.ResumeLayout(true);
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
                dgv_Result.Columns["dgv_ordNo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_CusOrdNo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_ordYMD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_ordPrjnm"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_Result.Columns["dgv_OrdCusCd"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdCus"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_Result.Columns["dgv_OrdContTyp"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdEngId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdEngNm"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_Result.Columns["dgv_OrdActkbn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdStrYMD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdEndYMD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdOlimit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdUlimit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdBaseRate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dvg_OrdOvRate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdSubRate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //列の位置調整
                dgv_Result.Columns["dgv_ordNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_CusOrdNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_ordYMD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_ordPrjnm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_Result.Columns["dgv_OrdCusCd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdCus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_Result.Columns["dgv_OrdContTyp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdEngId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdEngNm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_Result.Columns["dgv_OrdActkbn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdStrYMD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdEndYMD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdOlimit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_OrdUlimit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_OrdBaseRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dvg_OrdOvRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_OrdSubRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //列の書式設定
                dgv_Result.Columns["dgv_OrdBaseRate"].DefaultCellStyle.Format = "#,0";
                dgv_Result.Columns["dvg_OrdOvRate"].DefaultCellStyle.Format = "#,0";
                dgv_Result.Columns["dgv_OrdSubRate"].DefaultCellStyle.Format = "#,0";
                //列の幅指定
                dgv_Result.Columns["dgv_ordNo"].Width = 80;
                dgv_Result.Columns["dgv_CusOrdNo"].Width = 150;
                dgv_Result.Columns["dgv_ordYMD"].Width = 100;
                dgv_Result.Columns["dgv_ordPrjnm"].Width = 200;
                dgv_Result.Columns["dgv_OrdCusCd"].Width = 100;
                dgv_Result.Columns["dgv_OrdCus"].Width = 160;
                dgv_Result.Columns["dgv_OrdContTyp"].Width = 100;
                dgv_Result.Columns["dgv_OrdEngId"].Width = 100;
                dgv_Result.Columns["dgv_OrdEngNm"].Width = 100;
                dgv_Result.Columns["dgv_OrdActkbn"].Width = 100;
                dgv_Result.Columns["dgv_OrdStrYMD"].Width = 100;
                dgv_Result.Columns["dgv_OrdEndYMD"].Width = 100;
                dgv_Result.Columns["dgv_OrdOlimit"].Width = 100;
                dgv_Result.Columns["dgv_OrdUlimit"].Width = 100;
                dgv_Result.Columns["dgv_OrdBaseRate"].Width = 100;
                dgv_Result.Columns["dvg_OrdOvRate"].Width = 100;
                dgv_Result.Columns["dgv_OrdSubRate"].Width = 100;
            }
            catch
            {
                throw;
            }
        }


		#endregion

	}
}
