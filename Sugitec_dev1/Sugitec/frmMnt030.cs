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
    public partial class frmMnt030 : frmBase
    {

        #region"Define"

        /// <summary>一覧の列（列挙）</summary>
        public enum enDgvKbnList : int
        {
            /// <summary>削除フラグ</summary>
            dgv_del = 0,
            /// <summary>区分</summary>
            dgv_kbn,
            /// <summary>コード</summary>
            dgv_Cod,
            /// <summary>名称</summary>
            dgv_Contents
        }
        #endregion

        public frmMnt030()
        {
            InitializeComponent();

            //機能コードを設定
            this.FeaturesCD = FEATURES.MNT030;

            //DataGridViewの初期設定
            InitGridView();

            //画面項目クリア
            ClearScreenItem(true);

            //一覧表を取得しDataGridViewに設定
            SetDataGridView();
        }


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
                dgv_CodeList.AutoGenerateColumns = false;
                //データソースを解除
                dgv_KbnList.DataSource = null;
                dgv_CodeList.DataSource = null;
                //ヘッダーテキストの位置調整
                //列の位置調整
                //列の幅指定
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
                txt_Kbn.Text = String.Empty;
                txt_KbnNm.Text = String.Empty;
                lbl_Kbn.Text = String.Empty;
                lbl_KbnNm.Text = String.Empty;
                txt_Code.Text = String.Empty;
                txt_CodeNm.Text = String.Empty;

                //Key項目を入力可能にする
                txt_Kbn.ReadOnly = false;

                //指定時のみDataGridViewをクリア
                if (isGridClear)
                {
                    dgv_KbnList.DataSource = null;
                }

            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 得意先Mを取得しDataGridViewに設定
        /// </summary>
        private void SetDataGridView()
        {
            try
            {
                //サービス
                using (srvMnt030 srv = new srvMnt030())
                {
                    //　DataGridView のデータ取得
                    dgv_KbnList.AutoGenerateColumns = false;
                    dgv_KbnList.DataSource = srv.KbnSelect();

                    // データチェック
                    if (dgv_KbnList.Rows.Count == 0)
                    {
                        MessageBox.Show("データ件数が０件です",
                            base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // DataGridView へのデータバインド
                    dgv_KbnList.Columns[(int)enDgvKbnList.dgv_del].DataPropertyName = "SEL0";
                    dgv_KbnList.Columns[(int)enDgvKbnList.dgv_kbn].DataPropertyName = "KBN";
                    dgv_KbnList.Columns[(int)enDgvKbnList.dgv_Contents - 1].DataPropertyName = "CONTENT";

                }
            }
            catch
            {
                throw;
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
                // ヘッダーのダブルクリック時には抜ける
                if (e.RowIndex < 0) return;
                //クリックした行の情報を入力エリアに表示（黄色のテキストボックス）
                // 以下  enum順
                DataGridViewRow row = dgv_KbnList.Rows[e.RowIndex];
                txt_Kbn.Text = row.Cells[(int)enDgvKbnList.dgv_kbn].Value.ToString();
                txt_KbnNm.Text = row.Cells[(int)enDgvKbnList.dgv_Contents - 1].Value.ToString();

                //サービス
                using (srvMnt030 srv = new srvMnt030())
                {
                    //　DataGridView のデータ取得
                    dgv_CodeList.AutoGenerateColumns = false;
                    dgv_CodeList.DataSource = srv.CodeSelect(txt_Kbn.Text);

                    // データチェック
                    if (dgv_CodeList.Rows.Count != 0)
                    {
                        // DataGridView へのデータバインド
                        dgv_CodeList.Columns[(int)enDgvKbnList.dgv_del].DataPropertyName = "SEL0";
                        dgv_CodeList.Columns[(int)enDgvKbnList.dgv_Cod - 1].DataPropertyName = "CODE";
                        dgv_CodeList.Columns[(int)enDgvKbnList.dgv_Contents - 1].DataPropertyName = "CONTENT";
                    }
                    // ラベルの表示
                    lbl_Kbn.Text = txt_Kbn.Text;
                    lbl_KbnNm.Text = txt_KbnNm.Text;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_CodeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // ヘッダーのダブルクリック時には抜ける
                if (e.RowIndex < 0) return;
                //クリックした行の情報を入力エリアに表示（黄色のテキストボックス）
                // 以下  enum順
                DataGridViewRow row = dgv_CodeList.Rows[e.RowIndex];
                if (txt_Kbn.Text != String.Empty) lbl_Kbn.Text = txt_Kbn.Text;
                if (txt_KbnNm.Text != String.Empty) lbl_KbnNm.Text = txt_KbnNm.Text;
                txt_Code.Text = row.Cells[(int)enDgvKbnList.dgv_Cod - 1].Value.ToString();
                txt_CodeNm.Text = row.Cells[(int)enDgvKbnList.dgv_Contents - 1].Value.ToString();
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
        #endregion
        private void buttonKBNDEL_Click(object sender, EventArgs e)
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
                        using (srvMnt030 srv = new srvMnt030())
                        {
                            srv.Delete(dt,"");
                        }                        
                        //画面項目クリア
                        ClearScreenItem(true);
                        // DataGrid 再表示
                        SetDataGridView();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCDDEL_Click(object sender, EventArgs e)
        {
            try
            {
                //  DataGridVieのデータをDataTableへ格納
                DataTable dt = new DataTable();
                dt = (DataTable)dgv_CodeList.DataSource;

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
                        using (srvMnt030 srv = new srvMnt030())
                        {
                            srv.Delete(dt, lbl_Kbn.Text);

                            // DataGrid 再表示
                            //　DataGridView のデータ取得
                            dgv_CodeList.AutoGenerateColumns = false;
                            dgv_CodeList.DataSource = srv.CodeSelect(lbl_Kbn.Text);

                            // ラベルの表示
                            lbl_Kbn.Text = txt_Kbn.Text;
                            lbl_KbnNm.Text = txt_KbnNm.Text;

                            // DataGridView へのデータバインド
                            dgv_CodeList.Columns[(int)enDgvKbnList.dgv_del].DataPropertyName = "SEL0";
                            dgv_CodeList.Columns[(int)enDgvKbnList.dgv_Cod - 1].DataPropertyName = "CODE";
                            dgv_CodeList.Columns[(int)enDgvKbnList.dgv_Contents - 1].DataPropertyName = "CONTENT";

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void buttonKBNADD_Click(object sender, EventArgs e)
        {
            try
            {
                if(ChkInput(true) == false)
                {
                    MessageBox.Show("黄色のテキストボックスは必須項目ですから、値を入力して下さい", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dtoMnt030 dto = new dtoMnt030();
                dto.Kbn = txt_Kbn.Text;
                dto.Code = "00";
                dto.Content = txt_KbnNm.Text;
                dto.SYNC_FLG = (int)clsDefine.OperatingStatus;
                dto.TIMESTAMP = DateTime.Now.ToString("yyyyMMddHHmmss");
                using (srvMnt030 srv = new srvMnt030())
                {
                    srv.Insert(dto);
                }
                //画面項目クリア
                ClearScreenItem(true);
                // DataGrid 再表示
                SetDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCDADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChkInput() == false)
                {
                    MessageBox.Show("黄色のテキストボックスは必須項目ですから、値を入力して下さい", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dtoMnt030 dto = new dtoMnt030();
                dto.Kbn = lbl_Kbn.Text;
                dto.Code = txt_Code.Text;
                dto.Content = txt_CodeNm.Text;
                dto.SYNC_FLG = (int)clsDefine.OperatingStatus;
                dto.TIMESTAMP = DateTime.Now.ToString("yyyyMMddHHmmss");
                using (srvMnt030 srv = new srvMnt030())
                {
                    srv.Insert(dto);
                    // DataGrid 再表示
                    //　DataGridView のデータ取得
                    dgv_CodeList.AutoGenerateColumns = false;
                    dgv_CodeList.DataSource = srv.CodeSelect(lbl_Kbn.Text);

                    // データチェック
                    if (dgv_CodeList.Rows.Count == 0)
                    {
                        MessageBox.Show("データ件数が０件です",
                            base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // ラベルの表示
                    lbl_Kbn.Text = txt_Kbn.Text;
                    lbl_KbnNm.Text = txt_KbnNm.Text;

                    // DataGridView へのデータバインド
                    dgv_CodeList.Columns[(int)enDgvKbnList.dgv_del].DataPropertyName = "SEL0";
                    dgv_CodeList.Columns[(int)enDgvKbnList.dgv_Cod - 1].DataPropertyName = "CODE";
                    dgv_CodeList.Columns[(int)enDgvKbnList.dgv_Contents - 1].DataPropertyName = "CONTENT";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonKBNUPD_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChkInput(true) == false)
                {
                    MessageBox.Show("黄色のテキストボックスは必須項目ですから、値を入力して下さい", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dtoMnt030 dto = new dtoMnt030();
                dto.Kbn = txt_Kbn.Text;
                dto.Code = "00";
                dto.Content = txt_KbnNm.Text;
                dto.SYNC_FLG = (int)clsDefine.OperatingStatus;
                dto.TIMESTAMP = DateTime.Now.ToString("yyyyMMddHHmmss");
                using (srvMnt030 srv = new srvMnt030())
                {
                    srv.Update(dto,"");
                }
                //画面項目クリア
                ClearScreenItem(true);
                // DataGrid 再表示
                SetDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCDUPD_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChkInput() == false)
                {
                    MessageBox.Show("黄色のテキストボックスは必須項目ですから、値を入力して下さい", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dtoMnt030 dto = new dtoMnt030();
                dto.Kbn = lbl_Kbn.Text;
                dto.Code = txt_Code.Text;
                dto.Content = txt_CodeNm.Text;
                dto.SYNC_FLG = (int)clsDefine.OperatingStatus;
                dto.TIMESTAMP = DateTime.Now.ToString("yyyyMMddHHmmss");
                using (srvMnt030 srv = new srvMnt030())
                {
                    srv.Update(dto,lbl_Kbn.Text);
                    // DataGrid 再表示
                    //　DataGridView のデータ取得
                    dgv_CodeList.AutoGenerateColumns = false;
                    dgv_CodeList.DataSource = srv.CodeSelect(lbl_Kbn.Text);

                    // データチェック
                    if (dgv_CodeList.Rows.Count == 0)
                    {
                        MessageBox.Show("データ件数が０件です",
                            base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // ラベルの表示
                    lbl_Kbn.Text = txt_Kbn.Text;
                    lbl_KbnNm.Text = txt_KbnNm.Text;

                    // DataGridView へのデータバインド
                    dgv_CodeList.Columns[(int)enDgvKbnList.dgv_del].DataPropertyName = "SEL0";
                    dgv_CodeList.Columns[(int)enDgvKbnList.dgv_Cod - 1].DataPropertyName = "CODE";
                    dgv_CodeList.Columns[(int)enDgvKbnList.dgv_Contents - 1].DataPropertyName = "CONTENT";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 入力項目のチェックを行う
        /// </summary>
        /// <returns></returns>
        private bool ChkInput(bool KBN = false)
        {
            try
            {
                if (KBN)
                {
                    if (string.IsNullOrEmpty(txt_Kbn.Text))
                    {
                        MessageBox.Show("区分が未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (string.IsNullOrEmpty(txt_KbnNm.Text))
                    {
                        MessageBox.Show("区分名が未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txt_Code.Text))
                    {
                        MessageBox.Show("コードが未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (string.IsNullOrEmpty(txt_CodeNm.Text))
                    {
                        MessageBox.Show("コード名が未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }                             
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
