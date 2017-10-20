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
    public partial class frmDep021 : frmBase
    {

        #region "Field”

        /// <summary>処理モード</summary>
        private InputMode Mode = InputMode.Dsp;
        /// <summary>得意先コード</summary>
        private string _CusCd = string.Empty;
        /// <summary>請求年月</summary>
        private string _BillYm = string.Empty;
        /// <summary>回収残高</summary>
        private decimal _DepRcvAmt = 0;
        /// <summary>回収情報</summary>
        private DataRow _DepRow = null;
        /// <summary>入金№リスト</summary>
        private List<string> _RecNoList = new List<string>();

        #endregion

        #region "Property"

        /// <summary>
        /// 確定した回収情報
        /// </summary>
        public dtoDep021 RetDtoDep021 { get; private set; }

        #endregion

        #region"Event"

        /// <summary>
        /// コンストラクタ（追加処理）
        /// </summary>
        /// <param name="CusCD">得意先コード</param>
        /// <param name="BillYm">請求年月</param>
        /// <param name="DepRcvAmt">回収残高</param>
        /// <param name="RecNoList">入金№リスト</param>
        public frmDep021(string CusCD, string BillYm ,decimal DepRcvAmt,List<string> RecNoList)
        {
            try
            {
                InitializeComponent();

                //機能コードを設定
                FeaturesCD = FEATURES.DEP021;

                Mode = InputMode.Add;
                _CusCd = CusCD;
                _BillYm = BillYm;
                _DepRcvAmt = DepRcvAmt;
                _RecNoList = RecNoList;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// コンストラクタ（訂正処理）
        /// </summary>
        /// <param name="DepRow">回収情報</param>
        /// <param name="DepRcvAmt">回収残高</param>
        public frmDep021(DataRow DepRow, decimal DepRcvAmt)
        {
            try
            {
                InitializeComponent();

                //機能コードを設定
                FeaturesCD = FEATURES.DEP021;

                Mode = InputMode.Upd;
                _DepRow = DepRow;
                _DepRcvAmt = DepRcvAmt;

                txtRecYm.Enabled = false;
                btnSearch.Enabled = false;


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
                //DataGridViewの初期設定
                InitGridView();

                if (Mode == InputMode.Add)
                {
                    //追加処理
                    txtRecYm.Text = _BillYm;
                    lblDepRcvAmt.Text = _DepRcvAmt.ToAmountEx();
                    txtCash.Value = 0;
                    txtFees.Value = 0;
                    txtDeposit.Value = 0;
                    txtBill.Value = 0;
                }
                else
                {
                    //訂正処理
                    DataTable RecDt = new DataTable();
                    using (srvDep021 srv = new srvDep021())
                    {
                        RecDt = srv.GetReceipt(_DepRow["RECEIPT_NO"].ToString());
                    }
                    SetDataGrid(RecDt);

                    //入金消込情報を画面にセット
                    lblDepRcvAmt.Text = _DepRcvAmt.ToAmountEx();
                    txtCash.Value = _DepRow["CASH"].ToDecimalEx();
                    txtFees.Value = _DepRow["TRANSFER_FEES"].ToDecimalEx();
                    txtDeposit.Value = _DepRow["DEPOSIT"].ToDecimalEx();
                    txtBill.Value = _DepRow["BILL"].ToDecimalEx();
                }

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
                //入力チェック
                if (string.IsNullOrEmpty(txtRecYm.Text))
                {
                    MessageBox.Show("入金年月を入力して下さい", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //入金情報を取得
                DataTable dt = new DataTable();
                using (srvDep021 srv = new srvDep021())
                {
                    dt = srv.GetReceipt(txtRecYm.Text,_CusCd, _RecNoList);                        
                }

                //入金情報を一覧にバインド
                SetDataGrid(dt);

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
            try
            {
                this.Close();

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
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                //入力チェック
                if (!InputChk())
                {
                    return;
                }

                //返却情報の設定
                dtoDep021 dto = new dtoDep021();
                foreach (DataGridViewRow r in dgvList.SelectedRows)
                {
                    //現金（振込）のチェック
                    dto.RECEIPT_NO = r.Cells["dgv_RecNo"].Value.ToString();
                    dto.RECEIPT_YMD = r.Cells["dgv_RecYmd"].Value.ToString();
                }
                dto.CASH = txtCash.Value;
                dto.TRANSFER_FEES = txtFees.Value;
                dto.DEPOSIT = txtDeposit.Value;
                dto.BILL = txtBill.Value;
                dto.DEPOSIT_RECV_AMOUNT = lblDepRcvAmt.Text.ToDecimalEx();

                RetDtoDep021 = dto;

                DialogResult = DialogResult.OK;

                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 回収金額の値確定時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_ValueValidated(object sender, EventArgs e)
        {

            try
            {
                //回収残高の計算
                CalcDepRcvAmt();
                //回収可能金額の計算
                CalcDepAmt();

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
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 入金情報をデータグリッドへセット
        /// </summary>
        /// <param name="dt">入金情報</param>
        private void SetDataGrid(DataTable dt)
        {
            try
            {
                dgvList.DataSource = dt;
                dgv_RecNo.DataPropertyName = "RECEIPT_NO";
                dgv_RecYmd.DataPropertyName = "RECEIPT_YMD";
                dgv_Cash.DataPropertyName = "DEP_CASH";
                dgv_Fees.DataPropertyName = "DEP_TRANSFER_FEES";
                dgv_Deposit.DataPropertyName = "DEP_DEPOSIT";
                dgv_Bill.DataPropertyName = "DEP_BILL";
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns></returns>
        private bool InputChk()
        {
            try
            {
                //入金情報の未選択チェック
                if (dgvList.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0)
                {
                    MessageBox.Show("入金情報が選択されていません。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //回収残高
                decimal TmpDepRcvAmt = 0;
                if (Mode == InputMode.Add)
                {
                    TmpDepRcvAmt = _DepRcvAmt;
                }
                else
                {
                    TmpDepRcvAmt = _DepRcvAmt + _DepRow["ORG_CASH"].ToDecimalEx() + _DepRow["ORG_TRANSFER_FEES"].ToDecimalEx()
                                 + _DepRow["ORG_DEPOSIT"].ToDecimalEx() + _DepRow["ORG_BILL"].ToDecimalEx();
                }
                //回収金額
                decimal TmpDepAmt = txtCash.Value + txtFees.Value + txtDeposit.Value + txtBill.Value;
                //回収金額の入力チェック
                if (TmpDepAmt == 0)
                {
                    MessageBox.Show("回収金額が入力されていません。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //回収残高と回収金額のチェック
                if (TmpDepAmt > TmpDepRcvAmt)
                {
                    MessageBox.Show("回収金額が回収残高を超えています。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //入金額と回収金額のチェック
                foreach (DataGridViewRow r in dgvList.SelectedRows)
                {
                    //現金（振込）のチェック
                    if (txtCash.Value > r.Cells["dgv_Cash"].Value.ToDecimalEx() + _DepRow["ORG_CASH"].ToDecimalEx())
                    {
                        MessageBox.Show("現金（振込）が回収可能額を超えています。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    //振込手数料のチェック
                    if (txtFees.Value > r.Cells["dgv_Fees"].Value.ToDecimalEx() + _DepRow["ORG_TRANSFER_FEES"].ToDecimalEx())
                    {
                        MessageBox.Show("振込手数料が回収可能額を超えています。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    //預金のチェック
                    if (txtDeposit.Value > r.Cells["dgv_Deposit"].Value.ToDecimalEx() + _DepRow["ORG_DEPOSIT"].ToDecimalEx())
                    {
                        MessageBox.Show("預金が回収可能額を超えています。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    //手形のチェック
                    if (txtBill.Value > r.Cells["dgv_Bill"].Value.ToDecimalEx() + _DepRow["ORG_BILL"].ToDecimalEx())
                    {
                        MessageBox.Show("手形が回収可能額を超えています。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                return true;

            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// 回収残高を計算
        /// </summary>
        private void CalcDepRcvAmt()
        {
            try
            {

                //更新モードにより元の回収残高を計算
                decimal TmpDepRcvAmt = 0;
                if (Mode == InputMode.Add)
                {
                    TmpDepRcvAmt = _DepRcvAmt;
                }
                else
                {
                    TmpDepRcvAmt = _DepRcvAmt + _DepRow["ORG_CASH"].ToDecimalEx() + _DepRow["ORG_TRANSFER_FEES"].ToDecimalEx()
                                 + _DepRow["ORG_DEPOSIT"].ToDecimalEx() + _DepRow["ORG_BILL"].ToDecimalEx();
                }

                //元の回収残高から今回分を引く
                TmpDepRcvAmt = TmpDepRcvAmt - (txtCash.Value + txtFees.Value + txtDeposit.Value + txtBill.Value);

                //回収残高を表示
                lblDepRcvAmt.Text = TmpDepRcvAmt.ToAmountEx();

                if (TmpDepRcvAmt < 0)
                {
                    lblDepRcvAmt.ForeColor = Color.Red;
                }
                else
                {
                    lblDepRcvAmt.ForeColor = SystemColors.WindowText;
                }

            }
            catch (Exception)
            {

                throw;
            }


        }

        /// <summary>
        /// 回収可能金額の計算
        /// </summary>
        private void CalcDepAmt()
        {
            try
            {
                DataTable dt = (DataTable)dgvList.DataSource;
                if (Mode == InputMode.Add)
                {
                    dt.Rows[0]["DEP_CASH"] = dt.Rows[0]["ORG_CASH"].ToDecimalEx() - txtCash.Value;
                    dt.Rows[0]["DEP_TRANSFER_FEES"] = dt.Rows[0]["ORG_TRANSFER_FEES"].ToDecimalEx() - txtFees.Value;
                    dt.Rows[0]["DEP_DEPOSIT"] = dt.Rows[0]["ORG_DEPOSIT"].ToDecimalEx() - txtDeposit.Value;
                    dt.Rows[0]["DEP_BILL"] = dt.Rows[0]["ORG_BILL"].ToDecimalEx() - txtBill.Value;
                }
                else
                {
                    dt.Rows[0]["DEP_CASH"] = (dt.Rows[0]["ORG_CASH"].ToDecimalEx() + _DepRow["ORG_CASH"].ToDecimalEx()) - txtCash.Value;
                    dt.Rows[0]["DEP_TRANSFER_FEES"] = (dt.Rows[0]["ORG_TRANSFER_FEES"].ToDecimalEx() + _DepRow["ORG_TRANSFER_FEES"].ToDecimalEx()) - txtFees.Value;
                    dt.Rows[0]["DEP_DEPOSIT"] = (dt.Rows[0]["ORG_DEPOSIT"].ToDecimalEx() + _DepRow["ORG_DEPOSIT"].ToDecimalEx()) - txtDeposit.Value;
                    dt.Rows[0]["DEP_BILL"] = (dt.Rows[0]["ORG_BILL"].ToDecimalEx() + _DepRow["ORG_BILL"].ToDecimalEx()) - txtBill.Value;
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
