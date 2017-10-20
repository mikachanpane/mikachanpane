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
    public partial class frmMnt120 : frmBase
    {

        #region"Define"

        ///<summary>入力モード</summary>
        private InputMode Mode;
        /// <summary>一覧の列（列挙）</summary>
        private enum enDgvGroup : int
        {
            /// <summary>削除フラグ</summary>
            dgv_del = 0,
            /// <summary>グループコード</summary>
            dgv_gpCd,
            /// <summary>グループ名</summary>
            dgv_gpNm,
            /// <summary>交通費区分</summary>
            dgv_trvKbn,
            /// <summary>交通費区分名</summary>
            dgv_trvKbnNm,
            /// <summary>日当</summary>
            dgv_perdiem,
            /// <summary>宿泊費</summary>
            dgv_accomodation
        }
        #endregion

        #region"Event"
        public frmMnt120()
        {
            InitializeComponent();
            try
            {
                //機能コードを設定
                this.FeaturesCD = FEATURES.MNT120;

                //DataGridViewの初期設定
                InitGridView();

                //画面項目クリア
                ClearScreenItem(true);

                //コンボボックスを設定
                SetComboList();

                //一覧表を取得しDataGridViewに設定
                SetDataGridView();
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
                dgv_GroupList.AutoGenerateColumns = false;

                //データソースを解除
                dgv_GroupList.DataSource = null;

                //列の位置調整
                dgv_GroupList.Columns[(int)enDgvGroup.dgv_del].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_GroupList.Columns[(int)enDgvGroup.dgv_gpCd].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_GroupList.Columns[(int)enDgvGroup.dgv_gpNm].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_GroupList.Columns[(int)enDgvGroup.dgv_trvKbnNm].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_GroupList.Columns[(int)enDgvGroup.dgv_perdiem].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_GroupList.Columns[(int)enDgvGroup.dgv_accomodation].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                //列の書式設定
                dgv_GroupList.Columns[(int)enDgvGroup.dgv_perdiem].DefaultCellStyle.Format = "#,0";
                dgv_GroupList.Columns[(int)enDgvGroup.dgv_accomodation].DefaultCellStyle.Format = "#,0";

                //列の幅指定
                dgv_GroupList.Columns[(int)enDgvGroup.dgv_del].Width = 40;
                dgv_GroupList.Columns[(int)enDgvGroup.dgv_gpCd].Width = 60;
                dgv_GroupList.Columns[(int)enDgvGroup.dgv_gpNm].Width = 120;
                dgv_GroupList.Columns[(int)enDgvGroup.dgv_trvKbnNm].Width = 100;
                dgv_GroupList.Columns[(int)enDgvGroup.dgv_perdiem].Width = 100;
                dgv_GroupList.Columns[(int)enDgvGroup.dgv_accomodation].Width = 100;
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
                // 各コントロールをクリア
                txt_Cod.Text = String.Empty;
                txt_Name.Text = String.Empty;
                cmb_TrvKbn.SelectedIndex = -1;
                nudperdiem.Value = 0;
                nudaccommodation.Value = 0;

                //指定時のみDataGridViewをクリア
                if (isGridClear)
                {
                    dgv_GroupList.DataSource = null;
                }

                // 追加モードへ移行
                Mode = InputMode.Add;
                txt_Cod.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 所属グループMを取得しDataGridViewに設定
        /// </summary>
        private void SetDataGridView()
        {
            try
            {
                //サービス
                using (srvMnt120 srv = new srvMnt120())
                {
                    //　DataGridView のデータ取得
                    dgv_GroupList.AutoGenerateColumns = false;
                    dgv_GroupList.DataSource = srv.Select();

                    // DataGridView へのデータバインド
                    dgv_GroupList.Columns[(int)enDgvGroup.dgv_del].DataPropertyName = "SEL0";
                    dgv_GroupList.Columns[(int)enDgvGroup.dgv_gpCd].DataPropertyName = "GROUP_CODE";
                    dgv_GroupList.Columns[(int)enDgvGroup.dgv_gpNm].DataPropertyName = "GROUP_NAME";
                    dgv_GroupList.Columns[(int)enDgvGroup.dgv_trvKbn].DataPropertyName = "TRAVEL_KBN";
                    dgv_GroupList.Columns[(int)enDgvGroup.dgv_trvKbnNm].DataPropertyName = "CONTENT";
                    dgv_GroupList.Columns[(int)enDgvGroup.dgv_perdiem].DataPropertyName = "DAILY_ALLOWANCE";
                    dgv_GroupList.Columns[(int)enDgvGroup.dgv_accomodation].DataPropertyName = "ACCOMMODATION";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        /// <summary>
        /// 各コンボボックスのリストを設定
        /// </summary>
        private void SetComboList()
        {
            try
            {
                //サービス
                using (srvMnt120 srv = new srvMnt120())
                {
                    //支払区分取得
                    cmb_TrvKbn.DataSource = srv.GetCodeM("M02");
                    cmb_TrvKbn.ValueMember = "CODE";
                    cmb_TrvKbn.DisplayMember = "CONTENT";
                    cmb_TrvKbn.SelectedIndex = -1;
                }

            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region"Event"

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                //コードの必須チェック
                if (string.IsNullOrEmpty(txt_Cod.Text))
                {
                    MessageBox.Show("コードが未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //名称の必須チェック
                if (string.IsNullOrEmpty(txt_Name.Text))
                {
                    MessageBox.Show("名称が未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dtoMnt120 dto = new dtoMnt120();
                dto.Code = txt_Cod.Text;
                dto.Name = txt_Name.Text;
                if (cmb_TrvKbn.SelectedIndex == -1)
                {
                    dto.KotsuKBN = string.Empty;
                }
                else
                {
                    dto.KotsuKBN = cmb_TrvKbn.SelectedValue.ToString();
                }
                dto.perdiem = nudperdiem.Value;
                dto.accomodation = nudaccommodation.Value;
                dto.SYNC_FLG = (int)clsDefine.OperatingStatus;
                dto.TIMESTAMP = DateTime.Now.ToString("yyyyMMddhhmmss");

                using (srvMnt120 srv = new srvMnt120())
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

        private void btn_DEL_Click(object sender, EventArgs e)
        {
            try
            {
                //  DataGridVieのデータをDataTableへ格納
                DataTable dt = new DataTable();
                dt = (DataTable)dgv_GroupList.DataSource;

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
                        using (srvMnt120 srv = new srvMnt120())
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

        private void btn_End_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_GroupList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // ヘッダークリック時には抜ける
                if (e.RowIndex < 0) return;

                //クリックした行の情報を入力エリアに表示（黄色のテキストボックス）
                // 以下  enum順
                DataGridViewRow row = dgv_GroupList.Rows[e.RowIndex];
                txt_Cod.Text = row.Cells[(int)enDgvGroup.dgv_gpCd].Value.ToString();
                txt_Name.Text = row.Cells[(int)enDgvGroup.dgv_gpNm].Value.ToString();
                cmb_TrvKbn.SelectedValue = row.Cells[(int)enDgvGroup.dgv_trvKbn].Value.ToString();
                nudperdiem.Value = row.Cells[(int)enDgvGroup.dgv_perdiem].Value.ToDecimalEx();
                nudaccommodation.Value = row.Cells[(int)enDgvGroup.dgv_accomodation].Value.ToDecimalEx();
                //モードを更新に変更
                Mode = InputMode.Upd;
                txt_Cod.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
