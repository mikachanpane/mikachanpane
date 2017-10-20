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

    public partial class frmRec010 : frmBase
    {
        DataTable CUSTable = new DataTable();
        DataTable DiffTable = new DataTable();
        string Record_No = "";
        bool EvnSw = false;

        #region"Event"

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="Migration"></param>
        public frmRec010(FEATURES FCD,string recNo="")
        {
            try
            {
                InitializeComponent();

                //機能コードを設定
                FeaturesCD = FCD;
                Record_No = recNo;

                using (srvRec010 svc = new srvRec010())
                {
                    CUSTable = svc.SelectCus(FCD);
                    DiffTable = svc.SelectDiffCd();
                }

                //DataGridViewの初期設定
                InitGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 終了ボタンクリック
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
        private void frmRec010_Load(object sender, EventArgs e)
        {
            try
            {
                EvnSw = false;
                dgv_result.SuspendLayout();
                //得意先情報
                cmbCus.DataSource = CUSTable;
                cmbCus.ValueMember = "CUSTOMER_CD";
                cmbCus.DisplayMember = "NAME";
                //クリア処理
                CLR();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgv_result.ResumeLayout(true);
                dgv_result.Refresh();
                EvnSw = true;
            }
        }

        /// <summary>
        /// 検索ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCus.SelectedIndex == -1)
                {
                    MessageBox.Show("得意先を選択してください。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cMboxYM.Text == "")
                {
                    MessageBox.Show("年月を入力してください。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (srvRec010 svc = new srvRec010())
                {
                    dgv_result.SuspendLayout();

                    DataTable dtMain = new DataTable();
                    if(dgv_result.DataSource == null)
                    {
                        dtMain = svc.SelectRequest(cmbCus.SelectedValue.ToString(), cMboxYM.Text);
                    }
                    else
                    {
                        dtMain = (DataTable)dgv_result.DataSource;
                        DataTable dtTmp = svc.SelectRequest(cmbCus.SelectedValue.ToString(), cMboxYM.Text);
                        dtMain.Merge(dtTmp, true);
                    }
                    setData(dtMain);
                    dgv_result.ResumeLayout(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// クリア処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CLR()
        {
            try
            {
                if (FeaturesCD == FEATURES.REC010)
                {
                    cmbCus.SelectedIndex = -1;
                    dgv_result.DataSource = null;
                    nmBill.Value = 0;
                    nmCash.Value = 0;
                    nmDeposit.Value = 0;
                    nmFees.Value = 0;
                    cMboxYM.Text = "";
                    dtpBill_YMD.Value = null;
                    dtpReciptYMD.Value = null;
                    lblDepBill.Text = "0";
                    lblDepCash.Text = "0";
                    lblDepDeposit.Text = "0";
                    lblDepFees.Text = "0";
                }
                else
                {
                    ReadReceipt();
                }

                //消込可能額の文字色を変更
                ColorChg();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 確定ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCus.SelectedIndex == -1)
                {
                    MessageBox.Show("得意先が選択されていません。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dtpReciptYMD.Value == null)
                {
                    MessageBox.Show("入金日が入力されていません。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (lblDepCash.Text.ToDecimalEx() < 0)
                {
                    MessageBox.Show("現金（振込）の合計が入金額を超えています。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (lblDepFees.Text.ToDecimalEx() < 0)
                {
                    MessageBox.Show("振込手数料の合計が入金額を超えています。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (lblDepDeposit.Text.ToDecimalEx() < 0)
                {
                    MessageBox.Show("預金の合計が入金額を超えています。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (lblDepBill.Text.ToDecimalEx() < 0)
                {
                    MessageBox.Show("手形の合計が入金額を超えています。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt = (DataTable)dgv_result.DataSource;

                if (dgv_result.DataSource != null)
                {
                    //各行毎のチェック
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["SEL"].ToString() == "0")
                        {
                            continue;
                        }

                        //回収金額の計
                        Decimal sumRecoveryAmt = row["CASH"].ToDecimalEx()
                                               + row["BILL"].ToDecimalEx() 
                                               + row["DEPOSIT"].ToDecimalEx()
                                               + row["TRANSFER_FEES"].ToDecimalEx();

                        //回収金額以外の計
                        Decimal sumOtherAmt = row["DIFFERENCE"].ToDecimalEx()
                                            + row["DISCOUNT"].ToDecimalEx();

                        //回収合計額
                        Decimal TotalAmt = sumRecoveryAmt + sumOtherAmt;

                        //回収残高
                        Decimal Recv_Amt = row["DEPOSIT_RECV_AMOUNT"].ToDecimalEx();

                        //回収合計額がゼロかつキャンセルが未チェックの場合はエラー
                        if (row["CANCEL"].ToString() == "0" && TotalAmt == 0)
                        {
                            MessageBox.Show("請求番号" + row["REQUEST_NO"].ToString() +
                                "・枝番" + row["REQUEST_SUB_NO"].ToString() + "の回収金額、値引、差額、キャンセルが入力されていません。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        //キャンセル時に回収金額がゼロ以上の場合はエラー
                        if (row["CANCEL"].ToString() == "1" && TotalAmt > 0)
                        {
                            MessageBox.Show("請求番号" + row["REQUEST_NO"].ToString() +
                                "・枝番" + row["REQUEST_SUB_NO"].ToString() + "の回収金額、値引、差額とキャンセルが同時に入力されています。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        //回収金額がゼロで値引き、差額がゼロ以上の場合はエラー
                        if (sumRecoveryAmt == 0 && sumOtherAmt > 0)
                        {
                            MessageBox.Show("請求番号" + row["REQUEST_NO"].ToString() +
                                "・枝番" + row["REQUEST_SUB_NO"].ToString() + "の回収金額がゼロで値引、差額が入力されています。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        //差額がゼロ以上で差額理由が未入力の場合はエラー
                        if (sumRecoveryAmt == 0 && sumOtherAmt > 0)
                        {
                            MessageBox.Show("請求番号" + row["REQUEST_NO"].ToString() +
                                "・枝番" + row["REQUEST_SUB_NO"].ToString() + "の差額理由が入力されていません。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        //回収金額＋差額＋値引が回収残額を超えたらエラー
                        if (TotalAmt > Recv_Amt)
                        {
                            MessageBox.Show("請求番号" + row["REQUEST_NO"].ToString() +
                                "・枝番" + row["REQUEST_SUB_NO"].ToString() + "の回収金額が回収残額を超えています。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }


                dtoRec010 dto = new dtoRec010();
                dto.RecNo = Record_No;
                dto.CusCd = cmbCus.SelectedValue.ToString();
                dto.ReciptYMD = dtpReciptYMD.Value.ToStringEx();
                dto.cash = nmCash.Value;
                dto.bill = nmBill.Value;
                dto.deposit = nmDeposit.Value;
                dto.Fees = nmFees.Value;
                dto.BillYMD = dtpBill_YMD.Value.ToStringEx();
                dto.DepCash = lblDepCash.Text.ToDecimalEx();
                dto.DepBill = lblDepBill.Text.ToDecimalEx();
                dto.DepDeposit = lblDepDeposit.Text.ToDecimalEx();
                dto.DepFees = lblDepFees.Text.ToDecimalEx();
                dto.TIMESTAMP = DateTime.Now.ToString("yyyyMMddHHmmss");
                dto.syncFlf = (int)clsDefine.OperatingStatus;
                dto.ReqList = dt;

                //入力画面ではINSERT,編集画面ではUPDATEを行う。
                using (srvRec010 svc = new srvRec010())
                {
                    svc.UpdData(dto);
                }

				//ユーザーに更新したことを知らせる
				MessageBox.Show("データを登録しました。"
					,base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Information);

				///DialogResult = DialogResult.OK;
				///this.Close();
			}
			catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// EditingControlShowingイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_result_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //表示されているコントロールがDataGridViewTextBoxEditingControlか調べる
            if (e.Control is DataGridViewTextBoxEditingControl)
            {
                DataGridView dgv = (DataGridView)sender;

                //編集のために表示されているコントロールを取得
                DataGridViewTextBoxEditingControl tb =
                    (DataGridViewTextBoxEditingControl)e.Control;

                //イベントハンドラを削除
                tb.KeyPress -=
                    new KeyPressEventHandler(dataGridViewTextBox_KeyPress);

                //該当する列にイベントを設定する
                if (dgv.CurrentCell.OwningColumn.Name == "dgv_Cash" || dgv.CurrentCell.OwningColumn.Name == "dgv_Difference" ||
                    dgv.CurrentCell.OwningColumn.Name == "dgv_Bill" || dgv.CurrentCell.OwningColumn.Name == "dgv_Deposit" ||
                    dgv.CurrentCell.OwningColumn.Name == "dgv_Discount" || dgv.CurrentCell.OwningColumn.Name == "dgv_Transferfees")
                {
                    //KeyPressイベントハンドラを追加
                    tb.KeyPress +=
                        new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
                }
            }
        }

        /// <summary>
        /// DataGridViewに表示されているテキストボックスのKeyPressイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //数字しか入力できないようにする
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        //
        /// <summary>
        /// CellValidatingイベントハンドラ・誤入力検出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_result_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            //新しい行のセルでなく、セルの内容が変更されている時だけ検証する
            if (e.RowIndex == dgv.NewRowIndex || !dgv.IsCurrentCellDirty)
            {
                return;
            }
            decimal tmp = 0;

            //該当するセルが空白か数値以外が入力されたか確認
            if ((dgv.Columns[e.ColumnIndex].Name == "dgv_Cash" || dgv.Columns[e.ColumnIndex].Name == "dgv_Bill" ||
                 dgv.Columns[e.ColumnIndex].Name == "dgv_Deposit" || dgv.Columns[e.ColumnIndex].Name == "dgv_Discount" || 
                 dgv.Columns[e.ColumnIndex].Name == "dgv_Difference" || dgv.Columns[e.ColumnIndex].Name == "dgv_Transferfees") &&
                (e.FormattedValue.ToString() == "" || Decimal.TryParse(e.FormattedValue.ToString(), out tmp) == false))
            {
                //空白or文字列の場合入力した値をキャンセルして元に戻す
                dgv.CancelEdit();
                e.Cancel = true;
            }
        }

        /// <summary>
        /// CellValidatedイベントハンドラ・回収金額欄の入力時、消込可能額を計算する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_result_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //選択列の場合、消込可能額を計算する
            if (e.ColumnIndex >= 7 || e.ColumnIndex <= 10)
            {
                CalcDepAmt();
            }
        }
        
        /// <summary>
        /// CurrentCellDirtyStateChangedイベントハンドラ・チェックボックスの即時反映
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_result_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (EvnSw == false) return;

            //チェックボックスのON、OFFを即時反映する
            if ((dgv_result.CurrentCellAddress.X == 0) && dgv_result.IsCurrentCellDirty)
            {
                //コミットする
                dgv_result.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        /// <summary>
        /// CellValueChangedイベントハンドラ・チェックボックスのON、OFFで消込可能額を計算する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_result_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (EvnSw == false) return;

            //チェックボックスのON、OFFで消込可能額を計算する
            if (e.ColumnIndex == 0)
            {
                CalcDepAmt();
            }
        }

        /// <summary>
        /// Validatedイベントハンドラ・入金額（現金、手数料、預金、手形）の入力時、消込可能額を計算する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecoveryAmt_Validated(object sender, EventArgs e)
        {
            CalcDepAmt();
        }

        /// <summary>
        /// CellMouseDoubleClickイベントハンドラ・入金額（現金、手数料、預金、手形、差額、値引）のダブルクリック時、テンキーを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_result_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if ((e.ColumnIndex >= 7 && e.ColumnIndex <= 11) || e.ColumnIndex == 13)
            {
                using (frmTenKey ftk = new frmTenKey(8, false, 8, 0))
                {
                    DialogResult ret = ftk.ShowDialog();
                    if (ret == DialogResult.OK)
                    {
                        dgv_result[e.ColumnIndex, e.RowIndex].Value = ftk.inputNum.ToDecimalEx();
                    }

                }

            }

        }

        #endregion

        #region"Method"

        /// <summary>
        /// 各コントロールの初期設定
        /// </summary>
        private void InitControl()
        {
            try
            {   cmbCus.SelectedIndex = -1; 
                dgv_result.DefaultCellStyle.NullValue = 0;
                dgv_result.DefaultCellStyle.DataSourceNullValue = "0";
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
                dgv_result.AutoGenerateColumns = false;
                //データソースを解除
                dgv_result.DataSource = null;

                //列の位置調整
                dgv_result.Columns["dgv_Sel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_result.Columns["dgv_BillingYm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_result.Columns["dgv_RequestNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_result.Columns["dgv_ReqSubNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_result.Columns["dgv_TransferYmd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_result.Columns["dgv_BillingAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_result.Columns["dgv_Recv"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_result.Columns["dgv_Cash"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_result.Columns["dgv_Bill"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_result.Columns["dgv_Deposit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_result.Columns["dgv_Transferfees"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_result.Columns["dgv_Discount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_result.Columns["dgv_Cancel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_result.Columns["dgv_Diff"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_result.Columns["dgv_Difference"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //列の書式設定
                dgv_result.Columns["dgv_BillingAmount"].DefaultCellStyle.Format = "#,0";
                dgv_result.Columns["dgv_Recv"].DefaultCellStyle.Format = "#,0";
                dgv_result.Columns["dgv_Cash"].DefaultCellStyle.Format = "#,0";
                dgv_result.Columns["dgv_Bill"].DefaultCellStyle.Format = "#,0";
                dgv_result.Columns["dgv_Deposit"].DefaultCellStyle.Format = "#,0";
                dgv_result.Columns["dgv_Transferfees"].DefaultCellStyle.Format = "#,0";
                dgv_result.Columns["dgv_Discount"].DefaultCellStyle.Format = "#,0";
                dgv_result.Columns["dgv_Difference"].DefaultCellStyle.Format = "#,0";
                //列の幅指定
                dgv_result.Columns["dgv_Sel"].Width = 35;
                dgv_result.Columns["dgv_BillingYm"].Width = 75;
                dgv_result.Columns["dgv_RequestNo"].Width = 75;
                dgv_result.Columns["dgv_ReqSubNo"].Width = 40;
                dgv_result.Columns["dgv_TransferYmd"].Width = 90;
                dgv_result.Columns["dgv_BillingAmount"].Width = 100;
                dgv_result.Columns["dgv_Recv"].Width = 100;
                dgv_result.Columns["dgv_Cash"].Width = 100;
                dgv_result.Columns["dgv_Bill"].Width = 80;
                dgv_result.Columns["dgv_Deposit"].Width = 80;
                dgv_result.Columns["dgv_Transferfees"].Width = 80;
                dgv_result.Columns["dgv_Discount"].Width = 100;
                dgv_result.Columns["dgv_Diff"].Width = 100;
                dgv_result.Columns["dgv_Cancel"].Width = 50;
                dgv_result.Columns["dgv_Difference"].Width = 100;

                //差異理由コンボを作成
                dgv_Diff.DataSource = DiffTable;
                dgv_Diff.ValueMember = "CODE";
                dgv_Diff.DisplayMember = "CONTENT";

                //if (FeaturesCD == FEATURES.REC021)
                //{
                //    dgv_result.Columns["dgv_Sel"].ReadOnly = true;
                //}

            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 取得したデータを設定する
        /// </summary>
        /// <param name="dt"></param>
        private void setData(DataTable dt)
        {
            try
            {
                dgv_result.SuspendLayout();
                dgv_result.DataSource = null;
                dgv_result.DataSource = dt;
                dgv_Sel.DataPropertyName = "SEL";
                dgv_BillingYm.DataPropertyName = "BILLING_YM";
                dgv_RequestNo.DataPropertyName = "REQUEST_NO";
                dgv_ReqSubNo.DataPropertyName = "REQUEST_SUB_NO";
                dgv_TransferYmd.DataPropertyName = "TRANSFER_YMD";
                dgv_BillingAmount.DataPropertyName = "BILLING_AMOUNT";
                dgv_Recv.DataPropertyName = "DEPOSIT_RECV_AMOUNT";
                dgv_Cash.DataPropertyName = "CASH";
                dgv_Bill.DataPropertyName = "BILL";
                dgv_Deposit.DataPropertyName = "DEPOSIT";
                dgv_Transferfees.DataPropertyName = "TRANSFER_FEES";
                dgv_Discount.DataPropertyName = "DISCOUNT";
                dgv_Cancel.DataPropertyName = "CANCEL";
                dgv_Diff.DataPropertyName = "DIFF_REASONS_CD";
                dgv_Difference.DataPropertyName = "DIFFERENCE";
            }
            catch (Exception ex)
            {
                throw ex;
            }finally
            {
                dgv_result.ResumeLayout(true);
            }

        }

        /// <summary>
        /// クリアボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            CLR();
        }

        /// <summary>
        /// 編集時入金・明細情報取得
        /// </summary>
        public void ReadReceipt()
        {
            try
            {
                DataTable dtRec = new DataTable();
                DataTable dtReq = new DataTable();
                using (srvRec010 svc = new srvRec010())
                {
                    //入金情報を取得
                    dtRec = svc.SelectReceipt(Record_No);
                    //請求明細情報を取得
                    dtReq = svc.SelectRequest(Record_No);
                }
                //入金情報を表示
                lblRecNo.Text = dtRec.Rows[0]["RECEIPT_NO"].ToString();
                cmbCus.SelectedValue = dtRec.Rows[0]["CUSTOMER_CD"].ToString();
                dtpReciptYMD.Value = dtRec.Rows[0]["RECEIPT_YMD"].ToDateEx();
                nmCash.Value = dtRec.Rows[0]["CASH"].ToDecimalEx();
                nmBill.Value = dtRec.Rows[0]["BILL"].ToDecimalEx();
                nmDeposit.Value = dtRec.Rows[0]["DEPOSIT"].ToDecimalEx();
                nmFees.Value = dtRec.Rows[0]["TRANSFER_FEES"].ToDecimalEx();
                dtpBill_YMD.Value = dtRec.Rows[0]["BILL_YMD"].ToDateEx();
                lblDepCash.Text = dtRec.Rows[0]["DEP_CASH"].ToAmountEx();
                lblDepBill.Text = dtRec.Rows[0]["DEP_BILL"].ToAmountEx();
                lblDepDeposit.Text = dtRec.Rows[0]["DEP_DEPOSIT"].ToAmountEx();
                lblDepFees.Text = dtRec.Rows[0]["DEP_TRANSFER_FEES"].ToAmountEx();

                //回収対象一覧を表示
                setData(dtReq);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //cMboxYM.Enabled = false;
                //btnSearch.Enabled = false;
                cmbCus.Enabled = false;
            }
        }

        /// <summary>
        /// 消込可能額を計算し表示する
        /// </summary>
        private void CalcDepAmt()
        {
            try
            {

                //回収金額を集計
                DataTable dt = (DataTable)dgv_result.DataSource;
                Decimal DepCash = 0;
                Decimal DepBill = 0;
                Decimal DepDeposit = 0;
                Decimal DepFees = 0;
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["SEL"].ToString() == "1")
                        {
                            DepCash += row["CASH"].ToDecimalEx();
                            DepBill += row["BILL"].ToDecimalEx();
                            DepDeposit += row["DEPOSIT"].ToDecimalEx();
                            DepFees += row["TRANSFER_FEES"].ToDecimalEx();
                        }
                    }
                }

                //計算結果を表示
                lblDepCash.Text = (nmCash.Value - DepCash).ToAmountEx();
                lblDepBill.Text = (nmBill.Value - DepBill).ToAmountEx();
                lblDepDeposit.Text = (nmDeposit.Value - DepDeposit).ToAmountEx();
                lblDepFees.Text = (nmFees.Value - DepFees).ToAmountEx();

                //消込可能額の文字色を変更
                ColorChg();

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 消込可能額の文字色を変更
        /// </summary>
        private void ColorChg()
        {
            try
            {
                if (lblDepCash.Text.ToDecimalEx() < 0)
                {
                    lblDepCash.ForeColor = Color.Red;
                }
                else
                {
                    lblDepCash.ForeColor = SystemColors.ControlText;
                }

                if (lblDepBill.Text.ToDecimalEx() < 0)
                {
                    lblDepBill.ForeColor = Color.Red;
                }
                else
                {
                    lblDepBill.ForeColor = SystemColors.ControlText;
                }

                if (lblDepDeposit.Text.ToDecimalEx() < 0)
                {
                    lblDepDeposit.ForeColor = Color.Red;
                }
                else
                {
                    lblDepDeposit.ForeColor = SystemColors.ControlText;
                }

                if (lblDepFees.Text.ToDecimalEx() < 0)
                {
                    lblDepFees.ForeColor = Color.Red;
                }
                else
                {
                    lblDepFees.ForeColor = SystemColors.ControlText;
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
