using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sugitec.Logics;
using Sugitec.Common;

namespace Sugitec
{
    /// <summary>
    /// 
    /// </summary>
    public partial class frmDisplay
                                : frmBase
    {
        #region” Property ”
        
        

        #endregion 

        #region” Event ”

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmDisplay()
        {
            InitializeComponent();

            try
            {
                //機能コードを設定

                //コンボボックスを設定
                //得意先
                this.SetComboBox(cmbCus.Name);
                //技術者
                this.SetComboBox(cmbEng.Name);

                //DataGridView初期設定
                this.InitGridView();

                //各コントロールを初期化
                this.InitControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 全てを表示ボタン
        /// </summary>
        private void btnAllStateSeach_Click(object sender, EventArgs e)
        {
            try
            {
                //必須チェック
                if (!this.ChkInput()) return;

                //DTOに移送
                dtoDisplay dto = new dtoDisplay();

                //ラジオボタン：得意先
                //受注年月（個別）
                if (rdoOrd1.Checked)
                {
                    dto.OrderYm = mtbSallYm.Text;
                }
                //受注年月（範囲）
                if (rdoOrd2.Checked)
                {
                    dto.OrderYmF = mtbSallYmF.Text;
                    dto.OrderYmT = mtbSallYmT.Text;
                }
                //得意先（個別）
                if (rdoCus1.Checked)
                {
                    dto.CusCd = cmbCus.SelectedValue.ToString();
                }
                //得意先（範囲）
                if (rdoCus2.Checked)
                {
                    dto.CusCdF = txtCusF.Text;
                    dto.CusCdT = txtCusT.Text;
                }
                //技術者（個別）
                if (rdoCus1.Checked)
                {
                    dto.EngId = cmbEng.SelectedValue.ToString();
                }
                //技術者（範囲）
                if (rdoCus2.Checked)
                {
                    dto.EngIdF = txtEngF.Text;
                    dto.EngIdT = txtEngT.Text;
                }

                //ラジオボタン：状態区分
                //売上状態
                dto.SalAmSta = string.Empty;
                //請求状態
                dto.BillFlg = string.Empty;
                //振込状態
                // dto.TraFlg = string.Empty;
                //請求書状態
                dto.PubFlg = string.Empty;

				//サービス
				using (srvDisplay srv = new srvDisplay())
				{
					//一時的に受注期間のデータテーブルを生成
					srv.InsertTimeTable();

					//データテーブル整形後に、DataGridViewにデータバインド
					this.SetGridView(this.CustomDataTable(srv.SelectGridView(dto)));
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
                //必須チェック
                if (!this.ChkInput()) return;

                //DTOに移送
                dtoDisplay dto = new dtoDisplay();

                //ラジオボタン：得意先
                //受注年月（個別）
                if (rdoOrd1.Checked)
                {
                    dto.OrderYm = mtbSallYm.Text;
                }
                //受注年月（範囲）
                if (rdoOrd2.Checked)
                {
                    dto.OrderYmF = mtbSallYmF.Text;
                    dto.OrderYmT = mtbSallYmT.Text;
                }
                //得意先（個別）
                if (rdoCus1.Checked)
                {
                    dto.CusCd = cmbCus.SelectedValue.ToString();
                }
                //得意先（範囲）
                if (rdoCus2.Checked)
                {
                    dto.CusCdF = txtCusF.Text;
                    dto.CusCdT = txtCusT.Text;
                }
                //技術者（個別）
                if (rdoCus1.Checked)
                {
                    dto.EngId = cmbEng.SelectedValue.ToString();
                }
                //技術者（範囲）
                if (rdoCus2.Checked)
                {
                    dto.EngIdF = txtEngF.Text;
                    dto.EngIdT = txtEngT.Text;
                }

                //ラジオボタン
                //売上状態
                //登録済
                if (rdoSalY.Checked)
                {
                    dto.SalAmSta = "1";
                }
                //未登録
                if (rdoSalN.Checked)
                {
                    dto.SalAmSta = "0";
                }
                //請求状態
                //計算済
                if (rdoBillY.Checked)
                {
                    dto.BillFlg = "1";
                }
                //未計算
                if (rdoBillN.Checked)
                {
                    dto.BillFlg = "0";
                }
                //振込状態
                //振込済
                if (rdoFinY.Checked)
                {
                    dto.FinFlg = "1";
                }
                //未振込
                if (rdoFinN.Checked)
                {
                    dto.FinFlg = "0";
                }
                //請求書状態
                //発行済
                if (rdoPubY.Checked)
                {
                    dto.PubFlg = "1";
                }
                //未発行
                if (rdoPubN.Checked)
                {
                    dto.PubFlg = "0";
                }

				//サービス
				using (srvDisplay srv = new srvDisplay())
				{
					//一時的に受注期間のデータテーブルを生成
					srv.InsertTimeTable();

					//データテーブル整形後にDataGridViewにデータバインド
					this.SetGridView(this.CustomDataTable(srv.SelectGridView(dto), true));
				}
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
                //画面初期化
                InitControl();

                //DataGridView
                dgv_result.DataSource = null;
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

        #region” Method ”

        /// <summary>
        /// 必須チェックを行います
        /// </summary>
        /// <returns></returns>
        private bool ChkInput()
        {
            try
            {
                //ラジオボタン（その先のテキストボックス）
                //受注年月が個別指定かつ未入力ならエラー
                if (rdoOrd1.Checked && string.IsNullOrEmpty(mtbSallYm.Text))
                {
                    MessageBox.Show(gbxOrder.Text + "を入力して下さい",
                        base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //受注年月が範囲指定かつ未入力ならエラー
                if (rdoOrd2.Checked)
                {
                    //未入力
                    if (string.IsNullOrEmpty(mtbSallYmF.Text))
                    {
                        MessageBox.Show(gbxOrder.Text + "の範囲を入力して下さい",
                            base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    //整合性
                    if (mtbSallYmF.Text.ToDecimalEx() > mtbSallYmT.Text.ToDecimalEx())
                    {
                        MessageBox.Show(gbxOrder.Text + "の期間が不正です",
                            base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
                //技術者が個別指定かつ未入力ならエラー
                if (rdoEng1.Checked && string.IsNullOrEmpty(cmbEng.Text))
                {
                    MessageBox.Show(gbxEng.Text + "を入力して下さい",
                        base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //技術者が範囲指定かつ未入力ならエラー
                if (rdoEng2.Checked)
                {
                    //未入力
                    if (string.IsNullOrEmpty(txtEngF.Text))
                    {
                        MessageBox.Show(gbxEng.Text + "コードの範囲を入力して下さい",
                            base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    //整合性
                    if (txtEngF.Text.ToDecimalEx() > txtEngT.Text.ToDecimalEx())
                    {
                        MessageBox.Show(gbxEng.Text + "コードの範囲が不正です",
                            base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
                //得意先が個別指定かつ未入力ならラー
                if (rdoCus1.Checked && string.IsNullOrEmpty(cmbCus.Text))
                {
                    MessageBox.Show(gbxCus.Text + "を入力して下さい",
                        base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //得意先が範囲指定かつ未入力ならエラー
                if (rdoCus2.Checked)
                {
                    //未入力
                    if (string.IsNullOrEmpty(txtCusF.Text))
                    {
                        MessageBox.Show(gbxCus.Text + "コードの開始範囲を入力して下さい",
                            base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    //整合性
                    if (txtCusF.Text.ToDecimalEx() > txtCusT.Text.ToDecimalEx())
                    {
                        MessageBox.Show(gbxCus.Text + "コードの範囲が不正です",
                            base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
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
        /// 各コントロールを初期化します
        /// </summary>
        private void InitControl()
        {
            try
            {
                //売上年月
                rdoOrd1.Checked = true;
                mtbSallYm.Text = DateTime.Now.AddMonths(-1).ToString("yyyy/MM");
                mtbSallYmF.Text = string.Empty;
                mtbSallYmT.Text = string.Empty;
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
                //状態区分
                rdoSalN.Checked = true;
                rdoSalY.Checked = false;
                rdoBillN.Checked = true;
                rdoBillY.Checked = false;
                rdoFinN.Checked = true;
                rdoFinY.Checked = false;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// コンボボックスの表示項目を設定します
        /// </summary>
        /// <param name="section">comboBox.Name</param>
        private void SetComboBox(string section)
        {
            try
            {
                //サービス
                using (srvReq020 srv = new srvReq020())
                {
                    //得意先
                    if (section == cmbCus.Name)
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
                    if (section == cmbEng.Name)
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

        /// <summary>
        /// DataGridViewへのデータバインドをします
        /// </summary>
        /// <param name="dt">service.SelectGridView</param>
        private void SetGridView(DataTable dt)
        {
            try
            {
                dgv_result.DataSource = dt;
                dgv_result.Columns["dgv_orderNo"].DataPropertyName = "受注No";
                dgv_result.Columns["dgv_salNo"].DataPropertyName = "売上No";
                dgv_result.Columns["dgv_reqNum"].DataPropertyName = "請求No";
                dgv_result.Columns["dgv_cusNm"].DataPropertyName = "得意先名";
                dgv_result.Columns["dgv_engNm"].DataPropertyName = "技術者名";
                dgv_result.Columns["dgv_orderYm"].DataPropertyName = "受注日";
                dgv_result.Columns["dgv_sal"].DataPropertyName = "売上状態";
                dgv_result.Columns["dgv_req"].DataPropertyName = "請求状態";
                dgv_result.Columns["dgv_fin"].DataPropertyName = "回収状態";
                dgv_result.Columns["dgv_pub"].DataPropertyName = "請求書";
            }
            catch
            {
                throw;
            }
        }

		/// <summary>
		/// DataTableを整形します
		/// </summary>
		/// <param name="dt">SELECT文結果</param>
		/// <param name="IsStateCheck">状態区分が選択されているか</param>
		/// <returns>整形後DataTable</returns>
		private DataTable CustomDataTable(DataTable dt, Boolean IsStateCheck = false)
		{
			try
			{
				//個別指定されている場合、状態区分をチェックされている場合は何もせずに処理を抜ける
				if (rdoOrd1.Checked || IsStateCheck) return dt;

				//整形
				foreach (DataRow row in dt.Rows)
				{
					//重複行には空文字をセットする
					if (row["売上年月"].ToString() != row["受注日"].ToString())
					{
						row["受注No"] = string.Empty;
						row["得意先名"] = string.Empty;
						row["技術者名"] = string.Empty;
					}
				}

				//整形結果を返却
				return dt;
			}
			catch
			{
				throw;
			}
		}

        /// <summary>
        /// DataGridViewの初期設定をします
        /// </summary>
        private void InitGridView()
        {
            try
            {
                //列自動追加を解除
                dgv_result.AutoGenerateColumns = false;
                //データソースを解除
                dgv_result.DataSource = null;
            }
            catch
            {
                throw;
            }
        }

        #endregion

    }
}
