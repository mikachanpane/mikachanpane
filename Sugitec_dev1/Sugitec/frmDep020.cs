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
    public partial class frmDep020 : frmBase
    {

        /// <summary>イベント制御用スイッチ</summary>
        bool EvnSw = false;

        /// <summary>得意先コード</summary>
        string CusCD = string.Empty;
        
        #region"Event"

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="ReqNo"></param>
        /// <param name="ReqSubNo"></param>
        public frmDep020(string ReqNo, string ReqSubNo)
        {
            try
            {
                InitializeComponent();

                //機能コードを設定
                FeaturesCD = FEATURES.DEP020;

                //DataGridViewの初期設定
                InitGridView();

                //請求№を画面にセット
                lblReqNo.Text = ReqNo;
                lblReqSubNo.Text = ReqSubNo;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /// <summary>
        /// 画面ロード時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDep020_Load(object sender, EventArgs e)
        {
            try
            {

                EvnSw = false;

                //差額理由コンボの作成
                using (srvDep020 srv = new srvDep020())
                {
                    DataTable dt = srv.GetCodeM("D01");
                    cmbDiffNm.DataSource = dt;
                    cmbDiffNm.ValueMember = "CODE";
                    cmbDiffNm.DisplayMember = "CONTENT";
                }

                //データを取得し表示する
                InitDisp();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                EvnSw = true;
            }


        }

        /// <summary>
        /// 追加ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //キャンセルの場合、回収の追加は出来ない
                if (chkCancel.Checked)
                {
                    MessageBox.Show("キャンセルの為、回収情報の追加は出来ません。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //frmDep021からの受取り用
                dtoDep021 dto = new dtoDep021();

                //対象外入金№リストを作成
                List<string> RecList = new List<string>();
                foreach (DataGridViewRow row in dgvList.Rows)
                {
                    RecList.Add(row.Cells["dgv_RecNo"].Value.ToString());
                }

                //frmDep021を開く
                using (frmDep021 frm = new frmDep021(CusCD, lblBilYm.Text.Replace("/", ""), labDepRcvAmt.Text.ToDecimalEx(), RecList))
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    //frmDep021から結果を受取る    
                    dto = frm.RetDtoDep021;
                }

                //受取った結果を回収一覧に追加
                DataTable dt = (DataTable)dgvList.DataSource;
                DataRow NewDataRow = dt.NewRow();
                NewDataRow["RECEIPT_NO"] = dto.RECEIPT_NO;
                NewDataRow["RECEIPT_YMD"] = dto.RECEIPT_YMD;
                NewDataRow["CASH"] = dto.CASH;
                NewDataRow["TRANSFER_FEES"] = dto.TRANSFER_FEES;
                NewDataRow["DEPOSIT"] = dto.DEPOSIT;
                NewDataRow["BILL"] = dto.BILL;
                NewDataRow["DEPOSIT_NO"] = string.Empty;
                NewDataRow["DEL"] = 0;
                NewDataRow["ORG_CASH"] = 0;
                NewDataRow["ORG_TRANSFER_FEES"] = 0;
                NewDataRow["ORG_DEPOSIT"] = 0;
                NewDataRow["ORG_BILL"] = 0;
                dt.Rows.Add(NewDataRow);
                dgvList.DataSource = dt;

                //回収金額、回収残高を再計算
                CalcAmount();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 訂正ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpd_Click(object sender, EventArgs e)
        {
            try
            {
                //キャンセルの場合、回収の訂正は出来ない
                if (chkCancel.Checked)
                {
                    MessageBox.Show("キャンセルの為、回収情報の訂正は出来ません。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //回収情報の未選択チェック
                if (dgvList.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0)
                {
                    MessageBox.Show("回収情報が選択されていません。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //選択された回収情報を取得
                DataTable dt = (DataTable)dgvList.DataSource;
                DataRow[] SelDataRow = dt.Select(string.Format("RECEIPT_NO = '{0}'", dgvList.SelectedRows[0].Cells["dgv_RecNo"].Value.ToString()));

                //選択された回収情報の削除チェック
                if (SelDataRow[0]["DEL"].ToIntlEx() == 1)
                {
                    MessageBox.Show("削除対象の為、訂正できません。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //frmDep021からの受取り用
                dtoDep021 dto = new dtoDep021();

                //frmDep021を開く
                using (frmDep021 frm = new frmDep021(SelDataRow[0], labDepRcvAmt.Text.ToDecimalEx()))
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    //frmDep021から結果を受取る    
                    dto = frm.RetDtoDep021;
                }

                //受取った結果を回収一覧に追加
                int RowIdx = dt.Rows.IndexOf(SelDataRow[0]);
                dt.Rows[RowIdx]["CASH"] = dto.CASH;
                dt.Rows[RowIdx]["TRANSFER_FEES"] = dto.TRANSFER_FEES;
                dt.Rows[RowIdx]["DEPOSIT"] = dto.DEPOSIT;
                dt.Rows[RowIdx]["BILL"] = dto.BILL;
                //dt.Rows[RowIdx]["ORG_CASH"] = dto.CASH;
                //dt.Rows[RowIdx]["ORG_TRANSFER_FEES"] = dto.TRANSFER_FEES;
                //dt.Rows[RowIdx]["ORG_DEPOSIT"] = dto.DEPOSIT;
                //dt.Rows[RowIdx]["ORG_BILL"] = dto.BILL;

                //回収金額、回収残高を再計算
                CalcAmount();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 差額、値引きの値確定時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiffAndDiscountAmt_ValueValidated(object sender, EventArgs e)
        {
            try
            {
                CalcAmount();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// CurrentCellDirtyStateChangedイベントハンドラ・チェックボックスの即時反映
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

            try
            {
                if (EvnSw == false) return;

                //削除チェックボックスのON、OFFを即時反映する
                //if ((dgvList.CurrentCell.ColumnIndex == 7) && dgvList.IsCurrentCellDirty)

                if ((dgvList.CurrentCellAddress.X == 7) && dgvList.IsCurrentCellDirty)

                {
                    //コミットする
                    dgvList.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// CellValueChangedイベントハンドラ・チェックボックスのON、OFFで消込可能額を計算する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (EvnSw == false) return;

                //削除チェックボックスのON、OFFで消込可能額を計算する
                if (e.ColumnIndex == 7)
                {
                    //回収金額、回収残高を計算
                    CalcAmount();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// キャンセル
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCancel_Click(object sender, EventArgs e)
        {

            try
            {
                if (!chkCancel.Checked)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendLine("キャンセルにチェックし確定すると");
                    msg.AppendLine("入力した差額、値引、回収情報等が");
                    msg.AppendLine("全て取消され、全額キャンセルとなります。");
                    msg.AppendLine("キャンセルして宜しいですか？");
                    if (MessageBox.Show(msg.ToString(), base.FeatureNM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }

                chkCancel.Checked = !chkCancel.Checked;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 確定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {

            try
            {
                if (chkCancel.Checked)
                {
                    //キャンセル処理
                    using (srvDep020 srv = new srvDep020())
                    {

                    }

                }
                else
                {
                    //回収処理
                    using (srvDep020 srv = new srvDep020())
                    {

                    }

                }

                DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// クリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClr_Click(object sender, EventArgs e)
        {
            try
            {
                InitDisp();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            try
            {
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
                dgvList.AutoGenerateColumns = false;
                //データソースを解除
                dgvList.DataSource = null;
                //列の位置調整
                dgv_RecNo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_RecYmd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Cash.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Fees.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Deposit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Bill.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_DepNo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Del.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //列の書式設定
                dgv_Cash.DefaultCellStyle.Format = "#,0";
                dgv_Fees.DefaultCellStyle.Format = "#,0";
                dgv_Deposit.DefaultCellStyle.Format = "#,0";
                dgv_Bill.DefaultCellStyle.Format = "#,0";
                //列の幅指定
                dgv_RecNo.Width = 98;
                dgv_RecYmd.Width = 98;
                dgv_Cash.Width = 98;
                dgv_Fees.Width = 98;
                dgv_Deposit.Width = 98;
                dgv_Bill.Width = 98;
                dgv_DepNo.Width = 100;
                dgv_Del.Width = 40;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 初期データの取得と表示
        /// </summary>
        private void InitDisp()
        {
            try
            {
                //DTOのインスタンスを作成
                dtoDep020 dto = new dtoDep020();

                //画面表示用データを取得
                using (srvDep020 srv = new srvDep020())
                {
                    dto = srv.GetDep020Data(lblReqNo.Text, lblReqSubNo.Text);
                }

                //画面にセット
                CusCD = dto.CUSCD;
                lblBilYm.Text = dto.BILLING_YM;
                lblCusNm.Text = dto.CUSNAME;
                lblEngNm.Text = dto.ENGNAME;
                lblTraYmd.Text = dto.TRANSFER_YMD;
                lblBillAmt.Text = dto.BILLING_AMOUNT.ToAmountEx();
                labDepRcvAmt.Text = dto.DEPOSIT_RECV_AMOUNT.ToAmountEx();
                lblCash.Text = dto.CASH.ToAmountEx();
                lblFees.Text = dto.TRANSFER_FEES.ToAmountEx();
                lblDeposit.Text = dto.DEPOSIT.ToAmountEx();
                lblBill.Text = dto.BILL.ToAmountEx();
                nmDiffAmt.Value = dto.DIFFERENCE;
                cmbDiffNm.SelectedValue = dto.DIFF_REASONS_CD;
                nmDiscount.Value = dto.DISCOUNT;
                chkCancel.Checked = dto.CANCEL;
                dgvList.DataSource = dto.DEPOSIT_LIST;
                dgv_RecNo.DataPropertyName = "RECEIPT_NO";
                dgv_RecYmd.DataPropertyName = "RECEIPT_YMD";
                dgv_Cash.DataPropertyName = "CASH";
                dgv_Fees.DataPropertyName = "TRANSFER_FEES";
                dgv_Deposit.DataPropertyName = "DEPOSIT";
                dgv_Bill.DataPropertyName = "BILL";
                dgv_DepNo.DataPropertyName = "DEPOSIT_NO";
                dgv_Del.DataPropertyName = "DEL";

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 回収金額、回収残高を計算
        /// </summary>
        private void CalcAmount()
        {
            try
            {

                //各回収金額の集計
                DataTable dt = (DataTable)dgvList.DataSource;
                decimal tCash = 0;
                decimal tFees = 0;
                decimal tDeposit = 0;
                decimal tBill = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["DEL"].ToString() == "0")
                    {
                        tCash += row["CASH"].ToDecimalEx();
                        tFees += row["TRANSFER_FEES"].ToDecimalEx();
                        tDeposit += row["DEPOSIT"].ToDecimalEx();
                        tBill += row["BILL"].ToDecimalEx();
                    }
                }

                //回収残高の計算
                decimal TmpDepRcvAmt = lblBillAmt.Text.ToDecimalEx()
                                     - (tCash + tFees + tDeposit + tBill + nmDiffAmt.Value + nmDiscount.Value);

                //計算結果を画面に設定
                labDepRcvAmt.Text = TmpDepRcvAmt.ToAmountEx();
                lblCash.Text= tCash.ToAmountEx();
                lblFees.Text= tFees.ToAmountEx();
                lblDeposit.Text= tDeposit.ToAmountEx();
                lblBill.Text= tBill.ToAmountEx();

                if (TmpDepRcvAmt < 0)
                {
                    labDepRcvAmt.ForeColor = Color.Red;
                }
                else
                {
                    labDepRcvAmt.ForeColor = SystemColors.WindowText;
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
