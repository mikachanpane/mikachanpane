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
    public partial class frmSal020 : frmBase
    {

        #region"Define"
        DataTable EngTable = new DataTable();
        DataTable CUSTable = new DataTable();
        dtoSal020 dto = new dtoSal020();
        #endregion

        #region"Property"

        #endregion

        #region"Event"

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="Migration"></param>
        public frmSal020()
        {
            InitializeComponent();

            //機能コードを設定
            FeaturesCD = FEATURES.SAL020;

            //各コンボボックスのリストを作成
            MakeComboList();

            //各コントロールの初期設定
            InitControl();

            //DataGridViewの初期設定
            InitGridView();

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
                dto.Clear();

                if (rdoSal1.Checked == true)
                {
                    if (mtbSaleYm.Text != "")
                    {

                        dto.YMArea = false;
                        dto.srcSaleYM = mtbSaleYm.Text;
                    }
                    else
                    {
                        MessageBox.Show("年月を入力してください。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (mtbSaleYmF.Text != "" && mtbSaleYmT.Text != "")
                    {
                        dto.YMArea = true;
                        dto.srcSaleYMf = mtbSaleYmF.Text;
                        dto.srcSaleYMt = mtbSaleYmT.Text;
                    }
                    else
                    {
                        MessageBox.Show("年月を入力してください。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (rdoEng1.Checked == true)
                {
                    dto.IDArea = false;
                    dto.srcEngID = cmbEng.SelectedValue.ToString();
                }
                else
                {
                    if (txtEngF.Text != "" && txtEngT.Text != "")
                    {
                        dto.IDArea = true;
                        dto.srcEngIDf = txtEngF.Text;
                        dto.srcEngIDt = txtEngT.Text;
                    }
                    else
                    {
                        MessageBox.Show("技術者IDを入力してください。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (rdoCus1.Checked == true)
                {
                    dto.CDArea = false;
                    dto.srcCUSCD = cmbCus.SelectedValue.ToString();
                }
                else
                {
                    if (txtCusF.Text != "" && txtCusT.Text != "")
                    {
                        dto.CDArea = true;
                        dto.srcCUSCDf = txtCusF.Text;
                        dto.srcCUSCDt = txtCusT.Text;
                    }
                    else
                    {
                        MessageBox.Show("得意先コードを入力してください。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (txtSime.Text == "")
                {
                    dto.srcSHIMEBI = 0;
                }
                else
                {
                    dto.srcSHIMEBI = Convert.ToInt32(txtSime.Text);
                }
                using (srvSal020 srv = new srvSal020())
                {
                    SetData(srv.Select2(dto));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 新規データ作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgv_Result.CurrentCell == null)
            {
                MessageBox.Show("対象データが選択されていません", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int idx = dgv_Result.CurrentCell.RowIndex;
                if (dgv_Result["dgv_SalesNo", idx].Value.ToString() != "")
                {
                    MessageBox.Show("売上データが登録済みです", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (frmSal010 frm = new frmSal010(FEATURES.SAL010, dgv_Result["dgv_OrderNo", idx].Value.ToString(), mtbSaleYm.Text))
                {
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        using (srvSal020 srv = new srvSal020())
                        {
                            SetData(srv.Select2(dto));
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 編集ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (dgv_Result.CurrentCell == null)
            {
                MessageBox.Show("対象データが選択されていません", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int idx = dgv_Result.CurrentCell.RowIndex;
                if (dgv_Result["dgv_SalesNo", idx].Value.ToString() == "")
                {
                    MessageBox.Show("変更対象の売上データが登録されていません", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    using (frmSal010 frm = new frmSal010(FEATURES.SAL021, dgv_Result["dgv_SalesNo", idx].Value.ToString()))
                    {
                        frm.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                        {
                            using (srvSal020 srv = new srvSal020())
                            {
                                SetData(srv.Select2(dto));
                            }
                        }
                    }
                }

            }
        }

        /// <summary>
        /// クリアボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClr_Click(object sender, EventArgs e)
        {

            InitControl();

        }

        /// <summary>
        /// 終了ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 売上年月個別指定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoSal1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton rd = (RadioButton)sender;

                if (rd.Checked)
                {
                    btnAdd.Enabled = true;
                }
                else
                {
                    btnAdd.Enabled = false;
                }
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
                using (srvSal020 srv = new srvSal020())
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
        /// 各コントロールの初期設定
        /// </summary>
        private void InitControl()
        {
            try
            {
                //売上年月
                rdoSal1.Checked = true;
                mtbSaleYm.Text= DateTime.Now.AddMonths(-1).ToString("yyyy/MM");
                mtbSaleYmF.Text = string.Empty;
                mtbSaleYmT.Text = string.Empty;
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
                //データソースを解除
                dgv_Result.DataSource = null;

                btnAdd.Enabled = true;

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
                //列の位置調整
                dgv_Result.Columns["dgv_OrderNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_PrjNm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_Result.Columns["dgv_CusCd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_CusNm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_Result.Columns["dgv_EngId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_EngNm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_Result.Columns["dgv_OrdStartYMD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_OrdEndYMD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_SalesNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_SalesYM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_SalesAmt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //列の書式設定
                dgv_Result.Columns["dgv_SalesAmt"].DefaultCellStyle.Format = "#,0";
                //列の幅指定
                dgv_Result.Columns["dgv_OrderNo"].Width = 70;
                dgv_Result.Columns["dgv_PrjNm"].Width = 200;
                dgv_Result.Columns["dgv_CusCd"].Width = 100;
                dgv_Result.Columns["dgv_CusNm"].Width = 160;
                dgv_Result.Columns["dgv_EngId"].Width = 100;
                dgv_Result.Columns["dgv_EngNm"].Width = 100;
                dgv_Result.Columns["dgv_OrdStartYMD"].Width = 80;
                dgv_Result.Columns["dgv_OrdEndYMD"].Width = 80;
                dgv_Result.Columns["dgv_SalesNo"].Width = 70;
                dgv_Result.Columns["dgv_SalesYM"].Width = 80;
                dgv_Result.Columns["dgv_SalesAmt"].Width = 80;
                dgv_Result.Columns["dgv_Status"].Width = 100;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 検索結果をDatagridViewにセット
        /// </summary>
        /// <param name="dt">取得結果</param>
        private void SetData(DataTable dt)
        {
            try
            {
                dgv_Result.SuspendLayout();
                dgv_Result.DataSource = dt;
                dgv_Result.Columns["dgv_OrderNo"].DataPropertyName = "ORDER_NO";
                dgv_Result.Columns["dgv_PrjNm"].DataPropertyName = "PROJECT_NM";
                dgv_Result.Columns["dgv_CusCd"].DataPropertyName = "CUSTOMER_CD";
                dgv_Result.Columns["dgv_CusNm"].DataPropertyName = "CUSNAME";
                dgv_Result.Columns["dgv_EngId"].DataPropertyName = "ENGINEER_ID";
                dgv_Result.Columns["dgv_EngNm"].DataPropertyName = "ENGNAME";
                dgv_Result.Columns["dgv_OrdStartYMD"].DataPropertyName = "START_YMD";
                dgv_Result.Columns["dgv_OrdEndYMD"].DataPropertyName = "END_YMD";
                dgv_Result.Columns["dgv_SalesNo"].DataPropertyName = "SALES_NO";
                dgv_Result.Columns["dgv_SalesYM"].DataPropertyName = "SALES_YM";
                dgv_Result.Columns["dgv_SalesAmt"].DataPropertyName = "SALES_AMOUNT";
                dgv_Result.Columns["dgv_Status"].DataPropertyName = "STATUS";

                //foreach (DataGridViewRow row in dgv_Result.Rows)
                //{
                //    switch (row.Cells["dgv_Status"].Value.ToIntlEx())
                //    {
                //        case 1:
                //            dgv_Result.Rows[row.Index].DefaultCellStyle.BackColor = Color.MistyRose;
                //            break;
                //        case 2:
                //            dgv_Result.Rows[row.Index].DefaultCellStyle.BackColor = Color.Orange;
                //            break;
                //        case 3:
                //            dgv_Result.Rows[row.Index].DefaultCellStyle.BackColor = Color.Red;
                //            break;
                //        default:
                //            dgv_Result.Rows[row.Index].DefaultCellStyle.BackColor = SystemColors.Window;
                //            break;
                //    }
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dgv_Result.ResumeLayout(true);
            }
        }

        #endregion
    }
}
