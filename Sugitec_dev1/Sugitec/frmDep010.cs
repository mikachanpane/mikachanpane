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
    /// 回収対象一覧
    /// </summary>
	public partial class frmDep010 : frmBase
	{
        #region ”　Event　”

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmDep010()
        {
            InitializeComponent();

            try
            {
                //設定：
                //機能コードを設定
                base.FeaturesCD = FEATURES.DEP010;

                //コンボボックスを設定
                this.SetComboBox();

                //DataGridView初期化
                this.InitGridView();

                //各コントロール初期化
                this.InitControl();
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //入力チェック
                if (!this.ChkInput()) return;

                //DTOに移送
                dtoDep010 dto = new dtoDep010();
                //請求年月
                dto.ReqYm = txtReqYm.Text;
                //コンボボックス
                dto.CusCode = cmbCus.SelectedValue.ToString();
                //削除フラグ（０）
                dto.DelFlg = "0";
                //ラジオボタン
                //全て
                if (rdoAll.Checked)
                {
                    dto.FinishFlg = string.Empty;                      
                }
                //未回収
                if (rdoNoFin.Checked)
                {
                    dto.FinishFlg = "0";
                }
                //回収済
                if (rdoFin.Checked)
                {
                    dto.FinishFlg = "1";
                }

                //サービス
                using (srvDep010 srv = new srvDep010())
                {
                    //DataGridView表示用データを取得
                    DataTable dt = srv.SelectGridView(dto);

                    //DataGridViewにデータバインド
                    this.SetGridView(dt);
                }

                //データ件数チェック
                if (dgv_result.Rows.Count <= 0)
                {
                    MessageBox.Show("データが存在しません",
                        base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 編集ボタン
        /// </summary>
        private void btnCustom_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_result.CurrentCell == null)
                {
                    MessageBox.Show("対象データが選択されていません", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idx = dgv_result.CurrentCell.RowIndex;
                using (frmDep020 frm = new frmDep020(dgv_result["dgv_reqNo", idx].Value.ToString(), dgv_result["dgv_subNo", idx].Value.ToString()))
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                }

                //再度DataGridView表示
                button1_Click(button1, e);

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
                //各コントロールクリア
                this.ClrControl();
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// /終了ボタン
        /// </summary>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region ”　Method　”

        /// <summary>
        /// 各コントロールをクリアします
        /// </summary>
        private void ClrControl()
        {
            try
            {
                //テキストボックス
                txtReqYm.Text = string.Empty;
                //コンボボックス
                cmbCus.SelectedIndex = -1;
                //ラジオボタン
                rdoAll.Checked = true;
                //DataGridView
                dgv_result.DataSource = null;
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
                //列の位置調整
                dgv_result.Columns["dgv_reqNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_result.Columns["dgv_subNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_result.Columns["dgv_engNm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_result.Columns["dgv_transfYm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_result.Columns["dgv_billAm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_result.Columns["dgv_depAm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_result.Columns["dgv_depRec"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_result.Columns["dgv_diff"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_result.Columns["dgv_diffCd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_result.Columns["dgv_dis"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_result.Columns["dgv_cancel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //列の幅指定
                dgv_result.Columns["dgv_reqNo"].Width = 75;
                dgv_result.Columns["dgv_subNo"].Width = 50;
                dgv_result.Columns["dgv_engNm"].Width = 130;
                dgv_result.Columns["dgv_transfYm"].Width = 100;
                dgv_result.Columns["dgv_billAm"].Width = 105;
                dgv_result.Columns["dgv_depAm"].Width = 105;
                dgv_result.Columns["dgv_depRec"].Width = 105;
                dgv_result.Columns["dgv_diff"].Width = 105;
                dgv_result.Columns["dgv_diffCd"].Width = 100;
                dgv_result.Columns["dgv_dis"].Width = 105;
                dgv_result.Columns["dgv_cancel"].Width = 80;
                //列の書式設定
                dgv_result.Columns["dgv_billAm"].DefaultCellStyle.Format = "#,0";
                dgv_result.Columns["dgv_depAm"].DefaultCellStyle.Format = "#,0";
                dgv_result.Columns["dgv_depRec"].DefaultCellStyle.Format = "#,0";
                dgv_result.Columns["dgv_diff"].DefaultCellStyle.Format = "#,0";
                dgv_result.Columns["dgv_dis"].DefaultCellStyle.Format = "#,0";
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
                //テキストボックス
                txtReqYm.Text = string.Empty;
                //コンボボックス
                cmbCus.SelectedIndex = -1;
                //ラジオボタン
                rdoAll.Checked = true;
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// 入力項目の必須チェックを行います
        /// </summary>
        /// <returns>true；正常終了　false；異常終了</returns>
        private Boolean ChkInput()
        {
            try
            {
                //請求年月
                if (string.IsNullOrEmpty(txtReqYm.Text))
                {
                    MessageBox.Show("請求年月を入力して下さい",
                        base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //得意先
                if (cmbCus.SelectedIndex == -1)
                {
                    MessageBox.Show("得意先が正しく選択されていないか、未入力の状態です",
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
        /// DataGridViewのデータバインドをします
        /// </summary>
        /// <param name="dt">srv.SelectGridView</param>
        private void SetGridView(DataTable dt)
        {
            try
            {
                dgv_result.DataSource = dt;
                dgv_result.Columns["dgv_reqNo"].DataPropertyName = "請求№";
                dgv_result.Columns["dgv_subNo"].DataPropertyName = "枝番";
                dgv_result.Columns["dgv_engNm"].DataPropertyName = "技術者名";
                dgv_result.Columns["dgv_transfYm"].DataPropertyName = "振込指定日";
                dgv_result.Columns["dgv_billAm"].DataPropertyName = "請求金額";
                dgv_result.Columns["dgv_depAm"].DataPropertyName = "回収金額";
                dgv_result.Columns["dgv_depRec"].DataPropertyName = "回収残高";
                dgv_result.Columns["dgv_diff"].DataPropertyName = "差額";
                dgv_result.Columns["dgv_diffCd"].DataPropertyName = "差額理由";
                dgv_result.Columns["dgv_dis"].DataPropertyName = "値引";
                dgv_result.Columns["dgv_cancel"].DataPropertyName = "キャンセル";
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// コンボボックスのリストを設定
        /// </summary>
        private void SetComboBox()
        {
            try
            {
                //サービス
                using (srvDep010 srv = new srvDep010())
                {
                    //支払区分取得
                    cmbCus.DataSource = srv.SelectComboBox();
                    cmbCus.ValueMember = "CODE";
                    cmbCus.DisplayMember = "NAME";
                    cmbCus.SelectedIndex = -1;
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
