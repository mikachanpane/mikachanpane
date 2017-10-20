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
    public partial class frmMnt040 : frmBase
    {

        #region"Define"

        ///<summary>入力モード</summary>
        private InputMode Mode;
        /// <summary>一覧の列（列挙）</summary>
        private enum enDgvTaxRate : int
        {
            /// <summary>削除フラグ</summary>
            dgv_del = 0,
            /// <summary>コード</summary>
            dgv_taxCod,
            /// <summary>開始日</summary>
            dgv_launch,
            /// <summary>税率</summary>
            dgv_taxRate,
            /// <summary>有効</summary>
            dgv_valid
        }

        #endregion

        #region"Event"
        public frmMnt040()
        {
            InitializeComponent();
            try
            {
                //機能コードを設定
                this.FeaturesCD = FEATURES.MNT040;

                //DataGridViewの初期設定
                InitGridView();

                //画面項目クリア
                ClearScreenItem(true);

                //一覧表を取得しDataGridViewに設定
                SetDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// DataGridViewセルクリック 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_KbnList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // ヘッダークリック時には抜ける
                if (e.RowIndex < 0) return;

                //クリックした行の情報を入力エリアに表示（黄色のテキストボックス）
                // 以下  enum順
                DataGridViewRow row = dgv_KbnList.Rows[e.RowIndex];
                lblCode.Text = row.Cells[(int)enDgvTaxRate.dgv_taxCod].Value.ToString();
                dtpStartYmd.Value = dgv_KbnList["dgv_StartYmd", e.RowIndex].Value.ToDateEx();
                nudTaxRate.Value = row.Cells[(int)enDgvTaxRate.dgv_taxRate].Value.ToDecimalEx();
                chkValid.Checked = Convert.ToBoolean(row.Cells[(int)enDgvTaxRate.dgv_valid].Value);
                //モードを更新に変更
                Mode = InputMode.Upd;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///確定ボタン押下、更新モード時はUPDATE、挿入モード時はINSERTを行う。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                //必須入力チェック
                if (!ChkInput()) return;
                dtoMnt040 dto = new dtoMnt040();
                dto.CODE = lblCode.Text;//自動採番
                dto.START_YMD = dtpStartYmd.Value.ToStringEx();
                dto.TAX_RATE = nudTaxRate.Text.ToDecimalEx();
                dto.SYNC_FLG = (int)clsDefine.OperatingStatus;
                dto.TIMESTAMP = DateTime.Now.ToString("yyyyMMddhhmmss");
                if (chkValid.Checked == true)
                {
                    dto.VALID_FLG = 1;
                }
                else
                {
                    dto.VALID_FLG = 0;
                }

                using (srvMnt040 srv = new srvMnt040())
                {
                    if (Mode == InputMode.Upd)
                    {
                        srv.Update(dto);
                    }
                    else
                    {
                        srv.Insert(dto);
                    }
                }
                // 画面項目クリア
                ClearScreenItem();

                //一覧表を再取得しDataGridViewに設定
                SetDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 削除ボタン押下、削除チェックボックスにチェックが入っている行のデータの削除フラグを立てる。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DEL_Click(object sender, EventArgs e)
        {
            try
            {
                //  DataGridVieのデータをDataTableへ格納
                DataTable dt = new DataTable();
                dt = (DataTable)dgv_KbnList.DataSource;

                //　選択チェック 具体的には,DataGeridView からチェックフラグを探しに行きます
                foreach (DataRow row in dt.Rows)
                {
                    //  チェックボックスの入った行を探し、ひとつでもあればtrue
                    if (row[0].ToString() == "1")
                    {
                        //実行確認
                        if (MessageBox.Show("削除します。よろしいですか？",
                            base.FeatureNM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                        //サービス
                        using (srvMnt040 srv = new srvMnt040())
                        {
                            srv.Delete(dt);
                        }
                        // DataGrid 再表示
                        SetDataGridView();
                        ClearScreenItem();
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
        /// 現在編集中のデータを初期化する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CLR_Click(object sender, EventArgs e)
        {
            try
            {
                ClearScreenItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 画面を終了する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_End_Click(object sender, EventArgs e)
        {
            Close();
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
                dgv_KbnList.AutoGenerateColumns = false;
                //データソースを解除
                dgv_KbnList.DataSource = null;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 画面項目をクリア
        /// </summary>
        /// <param name="isGridClear">DataGridViewをクリア対象に含むか</param>
        private void ClearScreenItem(bool isGridClear = false)
        {
            try
            {
                //各コントロールをクリア
                lblCode.Text = string.Empty;
                dtpStartYmd.Value = null;
                nudTaxRate.Value = 0;
                chkValid.Checked = false;

                //指定時のみDataGridViewをクリア
                if (isGridClear)
                {
                    dgv_KbnList.DataSource = null;
                }

                //モードを追加に変更
                Mode = InputMode.Add;

            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 税率Mを取得しDataGridViewに設定
        /// </summary>
        private void SetDataGridView()
        {
            try
            {
                //サービス
                using (srvMnt040 srv = new srvMnt040())
                {
                    //　DataGridView のデータ取得
                    dgv_KbnList.AutoGenerateColumns = false;
                    dgv_KbnList.DataSource = srv.Select();

                    // データチェック
                    if (dgv_KbnList.Rows.Count == 0)
                    {
                        MessageBox.Show("データ件数が０件です",
                            base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // DataGridView へのデータバインド
                    dgv_KbnList.Columns[(int)enDgvTaxRate.dgv_del].DataPropertyName = "SEL0";
                    dgv_KbnList.Columns[(int)enDgvTaxRate.dgv_taxCod].DataPropertyName = "CODE";
                    dgv_KbnList.Columns[(int)enDgvTaxRate.dgv_launch].DataPropertyName = "START_YMD";
                    dgv_KbnList.Columns[(int)enDgvTaxRate.dgv_taxRate].DataPropertyName = "TAX_RATE";
                    dgv_KbnList.Columns[(int)enDgvTaxRate.dgv_valid].DataPropertyName = "VALID_FLG";

                    // 追加モードへ移行
                    Mode = InputMode.Add;

                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 入力項目のチェックを行う
        /// </summary>
        /// <returns></returns>
        private bool ChkInput()
        {
            try
            {
                if(dtpStartYmd.Value == null)
                {
                    MessageBox.Show("開始日付が未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (nudTaxRate.Value < 1)
                {
                    MessageBox.Show("税率が未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
