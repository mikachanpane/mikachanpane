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
    public partial class frmSrc010 : frmBase
    {
        /// <summary>
        /// 選択されたコード（ＩＤ）
        /// </summary>
        public string retCode { get; set; }

        /// <summary>
        /// 選択された名称（氏名）
        /// </summary>
        public string retName { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="num"></param>
        public frmSrc010(FEATURES FCD)
        {
            InitializeComponent();

            FeaturesCD = FCD;

        }

        /// <summary>
        /// 条件に沿ってデータを検索する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                GetData();
                retCode = string.Empty;
                retName = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// データを取得する。
        /// </summary>
        private void GetData()
        {
            try
            {
                //受け渡しデータを作成
                dtoSrc010 dto = new dtoSrc010();
                dto.CodFrm = num_Codfrm.Text;
                dto.CodTo = num_Codto.Text;
                dto.Name = txt_Name.Text;
                dto.Target = FeaturesCD;

                //サービス
                using (srvSrc010 srv = new srvSrc010())
                {
                    //DataGridViewに設定
                    dgv_result.SuspendLayout();
                    dgv_result.AutoGenerateColumns = false;
                    dgv_result.DataSource = srv.Select(dto);
                    dgv_result.Columns["dgv_ID"].DataPropertyName = "CODE";
                    dgv_result.Columns["dgv_name"].DataPropertyName = "NAME";
                    dgv_result.ResumeLayout(true);
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 選択したデータを返す。未選択の場合は何も返さず閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Select_Click(object sender, EventArgs e)
        {
            if (dgv_result.SelectedRows.Count==0)
            {
                MessageBox.Show("選択されていません", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            if (dgv_result.CurrentCell!=null)
            {
                retCode = dgv_result["dgv_ID", (int)dgv_result.CurrentCell.RowIndex].Value.ToString();
                retName = dgv_result["dgv_Name", (int)dgv_result.CurrentCell.RowIndex].Value.ToString();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            Close();
        }

        /// <summary>
        /// 終了する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            retCode = string.Empty;
            retName = string.Empty;
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }


}