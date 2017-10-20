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
    public partial class frmSal010 : frmBase
    {

        #region"Define"

        /// <summary>受注No</summary>
        private string _OrderNo = string.Empty;
        /// <summary>売上No</summary>
        private string _SalesNo = string.Empty;
        /// <summary>売上年月</summary>
        private string _SalesYm = string.Empty;
        /// <summary>ステータス</summary>
        private int _Status = 0;

        #endregion

        #region"Property"


        #endregion

        #region"Event"

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="FCD">機能コード</param>
        /// <param name="OSNo">受注№ Or 売上№</param>
        public frmSal010(FEATURES FCD, string OSNo = "",string SalesYm = "")
        {
            InitializeComponent();
            try
            {
                //機能コードを設定
                FeaturesCD = FCD;
                _SalesYm = SalesYm;
                if (FCD == FEATURES.SAL010)
                {
                    _OrderNo = OSNo;
                    _SalesNo = string.Empty;
                }
                else
                {
                    _OrderNo = string.Empty;
                    _SalesNo = OSNo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 初回読み込み処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSal010_Load(object sender, EventArgs e)
        {
            try
            {
                OrderCLR();
                SaleCLR();
                inputCLR();
                if (FeaturesCD == FEATURES.SAL010)
                {
                    btnDel.Enabled = false;
                    if (_OrderNo != "")
                    {
                        using (srvSal010 service = new srvSal010())
                        {
                            DataTable getdt = service.SelectOrder(_OrderNo);
                            SetData(getdt);
                        }
                        txtEngineerId.Enabled = false;
                        btnEngineer.Enabled = false;
                    }
                }
                else
                {
                    ediDataget();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		/// <summary>
		///	経費登録ボタン
		/// </summary>
		private void btnExpense_Click(object sender, EventArgs e)
		{
			try
			{
				//frmSal030へ画面遷移
				using (frmSal030 frm = new frmSal030())
				{
					//設定：
					//受注No
					frm.OrderNo = lblOrderNo.Text;
					//得意先名
					frm.CusName = lblCustomerNm.Text;
					//技術者名
					frm.EngName = lblEngineerNm.Text;

					//画面遷移
					frm.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// 計算ボタン押下
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                Calc();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 確定ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                //計算処理
                if (Calc())
                {
                    StringBuilder Msg = new StringBuilder();
                    switch (_Status)
                    {
                        case 3:
                            Msg.AppendLine("請求書発行済みの為、請求データの再計算");
                            Msg.AppendLine("及び、請求書の再発行が必要になります");
                            break;

                        case 2:
                            Msg.AppendLine("請求計算済みの為、請求データの再計算が必要になります");
                            break;
                    }
                    Msg.Append("更新して宜しいですか？");

                    if (MessageBox.Show(Msg.ToString(), base.FeatureNM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }

                dtoSal010 dto = new dtoSal010();
                dto.SALE_NO = lblSaleNo.Text;
                dto.baseAmount = lblBaseAmount.Text.ToDecimalEx();
                dto.Ov_amount = lblOrverAmount.Text.ToDecimalEx();
                dto.Sub_amount = lblSubtractAmount.Text.ToDecimalEx();
                dto.CusID = lblCustomerCd.Text;
                dto.EngId = txtEngineerId.Text;
                dto.startYMD = dtpStartYmd.Value.ToStringEx();
                dto.endYMD = dtpEndYmd.Value.ToStringEx();
                dto.ORDER_NO = lblOrderNo.Text;
                dto.OPTime = nudOperationTime.Value;
                dto.overTime = lblOverTime.Text.ToDecimalEx();
                dto.lackTime = lblLackTime.Text.ToDecimalEx();
                dto.Ov_amount = lblOrverAmount.Text.ToDecimalEx();
                dto.Sub_amount = lblSubtractAmount.Text.ToDecimalEx();
                dto.Sale_Amount = lblSalesAmount.Text.ToDecimalEx();
                dto.Tax_Rate = lblTaxRate.Text.ToDecimalEx();
                dto.Tax_Amount = lblTaxAmount.Text.ToDecimalEx();
                dto.Bill_FLG = 0;
                dto.DEL_FLG = 0;
                dto.SaleYMD = txtSaleYm.Text;
                dto.SYNC_FLG = (int)clsDefine.OperatingStatus;
                dto.TIMESTAMP = DateTime.Now.ToString("yyyyMMddHHmmss");
                if (FeaturesCD == FEATURES.SAL010)
                {
                    using (srvSal010 service = new srvSal010())
                    {
                        service.insertSale(dto);
                    }
                    if (_OrderNo == "")
                    {
                        string tmpYMD = txtSaleYm.Text;
                        OrderCLR();
                        SaleCLR();
                        inputCLR();
                        txtSaleYm.Text = tmpYMD;
                        return;
                    }
                }
                else
                {
                    using (srvSal010 service = new srvSal010())
                    {
                        service.UpDate(dto);
                    }
                }
                DialogResult = DialogResult.OK;
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClr_Click(object sender, EventArgs e)
        {
            try
            {
                OrderCLR();
                SaleCLR();
                inputCLR();
                dtoSal010 dto = new dtoSal010();
                if (FeaturesCD == FEATURES.SAL010)
                {
                    if (_OrderNo != "")
                    {
                        using (srvSal010 service = new srvSal010())
                        {
                            DataTable getdt = service.SelectOrder(_OrderNo);
                            SetData(getdt);
                        }
                        txtEngineerId.Enabled = false;
                        btnEngineer.Enabled = false;
                    }
                }
                else
                {
                    ediDataget();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 技術者検索ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEngineer_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmSrc010 frm = new frmSrc010(FEATURES.SRC011))
                {
                    DialogResult result = frm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        txtEngineerId.Text = frm.retCode;
                        lblEngineerNm.Text = frm.retName;
                        SaleCLR();
                        OrderCLR();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 技術者ID入力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEngineerId_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtEngineerId.Text == "")
                {
                    lblEngineerNm.Text = "";
                }
                else
                {
                    using (srvSal010 service = new srvSal010())
                    {
                        DataTable getdt = service.SelectEng(txtEngineerId.Text.PadLeft(8, '0'));
                        if (getdt.Rows.Count > 0)
                        {
                            lblEngineerNm.Text = getdt.Rows[0][0].ToString();
                        }
                        else
                        {
                            MessageBox.Show("入力した技術者が存在しません。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                        }
                    }
                }

                SaleCLR();
                OrderCLR();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 売上年月入力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSaleYm_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtSaleYm.Text == "")
                {
                    SaleCLR();
                    if (_OrderNo == "")
                    {
                        OrderCLR();
                    }
                }
                else
                {
                    if (_OrderNo != "")
                    {
                        using (srvSal010 service = new srvSal010())
                        {
                            DataTable getdt = service.SelectCalc(txtSaleYm.Text, txtEngineerId.Text, _OrderNo);
                            if (getdt.Rows.Count > 0)
                            {
                                SetData(getdt);
                            }
                            else
                            {
                                MessageBox.Show("売上年月が範囲外です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                e.Cancel = true;
                            }
                        }
                    }
                }
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
            Close();
        }

        /// <summary>
        /// 削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {

            try
            {
                StringBuilder Msg = new StringBuilder();
                switch (_Status)
                {
                    case 3:
                        Msg.AppendLine("請求書発行済みの為、請求データの再計算が必要になります");
                        break;

                    case 2:
                        Msg.AppendLine("請求計算済みの為、請求データの再計算が必要になります");
                        break;
                }
                Msg.Append("削除して宜しいですか？");

                if (MessageBox.Show(Msg.ToString(), base.FeatureNM, MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.No)
                {
                    return;
                }

                dtoSal010 dto = new dtoSal010();
                dto.SALE_NO = lblSaleNo.Text;
                dto.SYNC_FLG = (int)clsDefine.OperatingStatus;
                dto.TIMESTAMP = DateTime.Now.ToString("yyyyMMddHHmmss");
                using (srvSal010 srv = new srvSal010())
                {
                    srv.Delete(dto);
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        #endregion

        #region"Method"

        /// <summary>
        /// 受注情報の初期化
        /// </summary>
        private void OrderCLR()
        {
            lblOrderNo.Text = "";
            lblActuarialKbn.Text = "";
            lblCustomerCd.Text = "";
            lblCustomerNm.Text = "";
            lblOrderEnd.Text = "";
            lblOrderStart.Text = "";                        
            lblProjectNm.Text = "";
        }

        /// <summary>
        /// 売上情報初期化
        /// </summary>
        private void SaleCLR()
        {
            lblLackTime.Text = "";
            lblBaseAmount.Text = "";
            lblBaseRate.Text = "";
            lblBaseTime.Text = "";
            lblOrverAmount.Text = "";
            lblOrverRate.Text = "";
            lblOverTime.Text = "";
            lblSalesAmount.Text = "";
            lblSubtractAmount.Text = "";
            lblSubtractRate.Text = "";
            lblTaxAmount.Text = "";
            lblTaxRate.Text = "";
            lblTotalAmount.Text = "";
        }

        /// <summary>
        /// 入力欄の初期化
        /// </summary>
        private　void inputCLR()
        {
            lblSaleNo.Text="";
            lblEngineerNm.Text = "";
            txtSaleYm.Text= _SalesYm;
            txtEngineerId.Text = "";
            nudOperationTime.Value = 0;
            dtpEndYmd.Value = null;
            dtpStartYmd.Value = null;
        }

        /// <summary>
        /// 編集データ取得
        /// </summary>
        private void ediDataget()
        {
            try
            {
                DataTable SalDt = new DataTable();
                DataTable OrdDt = new DataTable();
                using (srvSal010 service = new srvSal010())
                {
                    SalDt = service.SelectSale(_SalesNo);
                    _OrderNo = SalDt.Rows[0]["ORDER_NO"].ToString();
                    OrdDt = service.SelectOrder(_OrderNo);
                    _Status = service.GetStatus(_SalesNo);
                }

                //売上情報を表示
                DataRow SalRow = SalDt.Rows[0];
                lblSaleNo.Text = SalRow["SALES_NO"].ToString();
                txtSaleYm.Text = SalRow["SALES_YM"].ToString();
                nudOperationTime.Value = SalRow["OPERATION_TIME"].ToDecimalEx();
                txtEngineerId.Text = SalRow["ENGINEER_ID"].ToString();
                dtpStartYmd.Value = SalRow["SALES_START_YMD"].ToDateEx();
                dtpEndYmd.Value = SalRow["SALES_END_YMD"].ToDateEx();
                lblBaseAmount.Text = SalRow["BASE_AMOUNT"].ToAmountEx();
                lblOrverAmount.Text = SalRow["ORVER_AMOUNT"].ToAmountEx();
                lblOverTime.Text = SalRow["OVER_TIME"].ToDecimalEx().ToString("#0.00");
                lblLackTime.Text = SalRow["LACK_TIME"].ToDecimalEx().ToString("#0.00");
                lblTaxRate.Text = SalRow["TAX_RATE"].ToAmountEx();
                lblTaxAmount.Text = SalRow["TAX_AMOUNT"].ToAmountEx();
                lblSubtractAmount.Text = SalRow["SUBTRACT_AMOUNT"].ToAmountEx();
                lblSalesAmount.Text = SalRow["SALES_AMOUNT"].ToAmountEx();
                lblTotalAmount.Text = (lblSalesAmount.Text.ToDecimalEx() + lblTaxAmount.Text.ToDecimalEx()).ToAmountEx();

                //受注情報を表示
                SetData(OrdDt);
                DataRow OrdRow = OrdDt.Rows[0];
                if (OrdRow["ACTUARIAL_KBN"].ToString() == "01")
                {
                    lblBaseTime.Text = OrdRow["LOWER_LIMIT"].ToString() + "～" + OrdRow["UPPER_LIMIT"].ToString();
                    lblBaseRate.Text = "@" + OrdRow["BASE_RATE"].ToAmountEx();
                    lblOrverRate.Text = "@" + OrdRow["ORVER_RATE"].ToAmountEx();
                    lblSubtractRate.Text = "@" + OrdRow["SUBTRACT_RATE"].ToAmountEx();
                }
                else if (OrdRow["ACTUARIAL_KBN"].ToString() == "02")
                {
                    lblBaseTime.Text = "月額固定";
                    lblBaseRate.Text = "@" + OrdRow["BASE_RATE"].ToAmountEx();
                    lblOrverRate.Text = "@0";
                    lblSubtractRate.Text = "@0";
                }
                else if (OrdRow["ACTUARIAL_KBN"].ToString() == "03")
                {
                    lblBaseTime.Text = nudOperationTime.Value.ToString("#0.00");
                    lblBaseRate.Text = "@" + OrdRow["BASE_RATE"].ToAmountEx();
                    lblOrverRate.Text = "@0";
                    lblSubtractRate.Text = "@0";
                }
                txtSaleYm.Enabled = false;
                txtEngineerId.Enabled = false;
                btnEngineer.Enabled = false;

                //入金済みの場合は更新不可
                if (_Status == 4)
                {
                    btnOk.Enabled = false;
                    btnDel.Enabled = false;
                    btnClr.Enabled = false;
                    btnCal.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 取得した受注データを画面に表示
        /// </summary>
        /// <param name="dt">データ取得済みのデータテーブル</param>
        private void SetData(DataTable dt)
        {
            try
            {
                DataRow dtRow = dt.Rows[0];
                txtEngineerId.Text= dtRow["ENGINEER_ID"].ToString();
                lblOrderNo.Text = dtRow["ORDER_NO"].ToString();
                lblActuarialKbn.Text = dtRow["CONTENT"].ToString();
                lblCustomerCd.Text = dtRow["CUSTOMER_CD"].ToString();
                lblCustomerNm.Text = dtRow["CUSNAME"].ToString();
                lblEngineerNm.Text = dtRow["ENGNAME"].ToString();
                lblOrderEnd.Text = dtRow["ORDEND_YMD"].ToString();
                lblOrderStart.Text = dtRow["ORDSTART_YMD"].ToString();
                lblProjectNm.Text = dtRow["PROJECT_NM"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 売上データ計算
        /// </summary>
        /// <param name="dt">売上データテーブル</param>
        private void CalcData(DataTable dt)
        {
            try
            {
                DataRow dtRow = dt.Rows[0];
                if (dtRow["ACTUARIAL_KBN"].ToString() == "01")
                {
                    lblBaseAmount.Text = dtRow["BASE_RATE"].ToAmountEx();
                    lblBaseTime.Text = dtRow["LOWER_LIMIT"].ToString() + "～" + dtRow["UPPER_LIMIT"].ToString();
                    lblBaseRate.Text = "@" + dtRow["BASE_RATE"].ToAmountEx();
                    lblOrverRate.Text = "@" + dtRow["ORVER_RATE"].ToAmountEx();
                    lblSubtractRate.Text = "@" + dtRow["SUBTRACT_RATE"].ToAmountEx();
                    if (nudOperationTime.Value - dtRow["UPPER_LIMIT"].ToDecimalEx() > 0)
                    {
                        lblOverTime.Text = (nudOperationTime.Value - dtRow["UPPER_LIMIT"].ToDecimalEx()).ToString("#0.00");
                    }
                    else
                    {
                        lblOverTime.Text = "0.00";
                    }
                    if(dtRow["LOWER_LIMIT"].ToDecimalEx() - nudOperationTime.Value > 0)
                    {
                        lblLackTime.Text = (dtRow["LOWER_LIMIT"].ToDecimalEx() - nudOperationTime.Value).ToString("#0.00");
                    }
                    else
                    {
                        lblLackTime.Text = "0.00";
                    }
                    lblOrverAmount.Text = (lblOverTime.Text.ToDecimalEx() * dtRow["ORVER_RATE"].ToDecimalEx()).ToAmountEx();
                    lblSubtractAmount.Text = (lblLackTime.Text.ToDecimalEx() * dtRow["SUBTRACT_RATE"].ToDecimalEx()).ToAmountEx();

                }
                else if (dtRow["ACTUARIAL_KBN"].ToString() == "02")
                {
                    lblBaseRate.Text = "@" + dtRow["BASE_RATE"].ToAmountEx();
                    lblBaseAmount.Text = dtRow["BASE_RATE"].ToAmountEx();
                    lblBaseTime.Text = "月額固定";
                    lblOverTime.Text = "0.00";
                    lblLackTime.Text = "0.00";
                    lblOrverAmount.Text = "0";
                    lblSubtractAmount.Text = "0";
                    lblSubtractRate.Text = "@0";
                    lblOrverRate.Text = "@0";
                }
                else if (dtRow["ACTUARIAL_KBN"].ToString() == "03")
                {
                    lblBaseTime.Text = nudOperationTime.Value.ToString("#0.00");
                    lblBaseRate.Text = "@" + dtRow["BASE_RATE"].ToAmountEx();
                    lblBaseAmount.Text = (dtRow["BASE_RATE"].ToDecimalEx() * this.nudOperationTime.Value).ToAmountEx();
                    lblOverTime.Text = "0.00";
                    lblLackTime.Text = "0.00";
                    lblOrverAmount.Text = "0";
                    lblSubtractAmount.Text = "0";
                    lblSubtractRate.Text = "@0";
                    lblOrverRate.Text = "@0";
                }

                lblSalesAmount.Text = (lblBaseAmount.Text.ToDecimalEx() + lblOrverAmount.Text.ToDecimalEx() - lblSubtractAmount.Text.ToDecimalEx()).ToAmountEx();
                lblTaxAmount.Text = (lblSalesAmount.Text.ToDecimalEx() * lblTaxRate.Text.ToDecimalEx() / 100).ToAmountEx();
                lblTotalAmount.Text = (lblSalesAmount.Text.ToDecimalEx() + lblTaxAmount.Text.ToDecimalEx()).ToAmountEx();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 計算時処理
        /// </summary>
        private bool Calc()
        {
            try
            {
                if (txtSaleYm.Text == "")
                {
                    MessageBox.Show("売上年月を入力してください", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtEngineerId.Text == "")
                {
                    MessageBox.Show("技術者IDを入力してください", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //受注情報
                DataTable getdt = new DataTable();

                using (srvSal010 service = new srvSal010())
                {
                    //消費税の取得
                    lblTaxRate.Text = service.SelectTAX(txtSaleYm.Text).ToString();

                    //受注データの取得
                    getdt = service.SelectCalc(txtSaleYm.Text, txtEngineerId.Text, _OrderNo);

                }

                //データチェック
                if (getdt.Rows.Count == 0)
                {
                    if (_OrderNo != "")
                    {
                        MessageBox.Show("売上年月が範囲外です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("対象となる受注がありません", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                //重複チェック
                if (FeaturesCD == FEATURES.SAL010)
                {
                    using (srvSal010 service = new srvSal010())
                    {
                        //売上情報の重複チェック
                        if (service.IsDuplicatesSales(txtSaleYm.Text, getdt.Rows[0]["ORDER_NO"].ToString()))
                        {
                            string Msg = string.Format("{0}年{1}月の売上情報は登録済みです", txtSaleYm.Text.LeftEx(4), txtSaleYm.Text.RightEx(2)); 
                            MessageBox.Show(Msg, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }

                if (_OrderNo == "")
                {
                    //受注情報表示
                    SetData(getdt);
                }

                //売上データ計算
                CalcData(getdt);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
