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
    public partial class frmRec020 : frmBase
    {

        #region"Define"
        dtoRec020 dto=new dtoRec020();
        #endregion

        #region"Property"

        #endregion

        #region"Event"

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="Migration"></param>
        public frmRec020()
        {

            try
            {
                InitializeComponent();

                //機能コードを設定
                FeaturesCD = FEATURES.REC020;

                //各コンボボックスのリストを作成
                MakeComboList();

                //各コントロールの初期設定
                InitControl();

                //DataGridViewの初期設定
                InitGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                SearchValueSet();

                using (srvRec020 svc = new srvRec020())
                {
                    dgv_Result.SuspendLayout();
                    SetData(svc.SelectRec(dto));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgv_Result.ResumeLayout(true);
            }
        }

        /// <summary>
        /// 編集ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Result.CurrentCell == null)
                {
                    MessageBox.Show("対象データが選択されていません", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idx = dgv_Result.CurrentCell.RowIndex;
                if (dgv_Result["dgv_ReceiptNo", idx].Value.ToString() == "")
                {
                    MessageBox.Show("変更対象の入金データが登録されていません", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult dr = DialogResult.Cancel;
                using (frmRec010 frm = new frmRec010(FEATURES.REC021, recNo: dgv_Result["dgv_ReceiptNo", idx].Value.ToString()))
                {
                    dr = frm.ShowDialog();
                }
                if (dr == DialogResult.OK)
                {
                    SearchValueSet();
                    using (srvRec020 svc = new srvRec020())
                    {
                        dgv_Result.SuspendLayout();
                        SetData(svc.SelectRec(dto));
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClr_Click(object sender, EventArgs e)
        {
            try
            {
                InitControl();
                dgv_Result.DataSource = null;
                dto.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
        /// 初期処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRec020_Load(object sender, EventArgs e)
        {
            cmbCus.SelectedIndex = 0;
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
                DataTable CUSTable = new DataTable();

                using (srvRec020 srv = new srvRec020())
                {
                   CUSTable = srv.SelectCus();
                }

                //得意先
                DataRow row;
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
                //得意先
                rdoCus1.Checked = true;
                cmbCus.SelectedIndex = -1; //TODO データバインド後に0に変更
                txtCusF.Text = string.Empty;
                txtCusT.Text = string.Empty;
                //入金年月
                rdoSal1.Checked = true;
                mtbReceiptYm.Text= DateTime.Now.AddMonths(-3).ToString("yyyy/MM");
                mtbReceiptYmF.Text = string.Empty;
                mtbReceiptYmT.Text = string.Empty;
                //消込可能額
                rdoAll.Checked = true;
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
                dgv_Result.Columns["dgv_CusCd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_CusNm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_Result.Columns["dgv_ReceiptYmd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_ReceiptNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_Cash"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_Bill"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_Deposit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_TransFees"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_BillYmd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Result.Columns["dgv_DepCash"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_DepBill"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_DepDeposit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Result.Columns["dgv_DepTransFees"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //列の書式設定
                dgv_Result.Columns["dgv_Cash"].DefaultCellStyle.Format = "#,0";
                dgv_Result.Columns["dgv_Bill"].DefaultCellStyle.Format = "#,0";
                dgv_Result.Columns["dgv_Deposit"].DefaultCellStyle.Format = "#,0";
                dgv_Result.Columns["dgv_TransFees"].DefaultCellStyle.Format = "#,0";
                dgv_Result.Columns["dgv_DepCash"].DefaultCellStyle.Format = "#,0";
                dgv_Result.Columns["dgv_DepBill"].DefaultCellStyle.Format = "#,0";
                dgv_Result.Columns["dgv_DepDeposit"].DefaultCellStyle.Format = "#,0";
                dgv_Result.Columns["dgv_DepTransFees"].DefaultCellStyle.Format = "#,0";
                //列の幅指定
                dgv_Result.Columns["dgv_CusCd"].Width = 100;
                dgv_Result.Columns["dgv_CusNm"].Width = 200;
                dgv_Result.Columns["dgv_ReceiptYmd"].Width = 90;
                dgv_Result.Columns["dgv_ReceiptNo"].Width = 80;
                dgv_Result.Columns["dgv_Cash"].Width = 90;
                dgv_Result.Columns["dgv_Bill"].Width = 90;
                dgv_Result.Columns["dgv_Deposit"].Width = 90;
                dgv_Result.Columns["dgv_TransFees"].Width = 90;
                dgv_Result.Columns["dgv_BillYmd"].Width = 90;
                dgv_Result.Columns["dgv_DepCash"].Width = 90;
                dgv_Result.Columns["dgv_DepBill"].Width = 90;
                dgv_Result.Columns["dgv_DepDeposit"].Width = 90;
                dgv_Result.Columns["dgv_DepTransFees"].Width = 90;
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
                dgv_ReceiptNo.DataPropertyName = "RECEIPT_NO";
                dgv_ReceiptYmd.DataPropertyName = "RECEIPT_YMD";
                dgv_Bill.DataPropertyName = "BILL";
                dgv_BillYmd.DataPropertyName = "BILL_YMD";
                dgv_Cash.DataPropertyName = "CASH";
                dgv_Deposit.DataPropertyName = "DEPOSIT";
                dgv_TransFees.DataPropertyName = "TRANSFER_FEES";
                dgv_CusCd.DataPropertyName = "CUSTOMER_CD";
                dgv_CusNm.DataPropertyName = "NAME";
                dgv_DepBill.DataPropertyName = "DEP_BILL";
                dgv_DepCash.DataPropertyName = "DEP_CASH";
                dgv_DepDeposit.DataPropertyName = "DEP_DEPOSIT";
                dgv_DepTransFees.DataPropertyName = "DEP_TRANSFER_FEES";

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

        /// <summary>
        /// 検索値セット
        /// </summary>
        private void SearchValueSet()
        {

            try
            {
                dto.Clear();
                if (rdoCus1.Checked == true)
                {
                    dto.CusArea = false;
                    dto.CusCode = cmbCus.SelectedValue.ToString();
                }
                else
                {
                    dto.CusArea = true;
                    dto.CusCodeFrm = txtCusF.Text;
                    dto.CusCodeFrm = txtCusT.Text;
                }

                if (rdoSal1.Checked == true)
                {
                    dto.RecArea = false;
                    dto.RecYM = mtbReceiptYm.Text;
                }
                else
                {
                    dto.RecArea = true;
                    dto.RecYMFrm = mtbReceiptYmF.Text;
                    dto.RecYMTo = mtbReceiptYmT.Text;
                }
                if (rdoAri.Checked)
                {
                    dto.Deposit = 1;
                }
                else if (rdoNasi.Checked)
                {
                    dto.Deposit = 2;
                }
                else
                {
                    dto.Deposit = 0;
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
