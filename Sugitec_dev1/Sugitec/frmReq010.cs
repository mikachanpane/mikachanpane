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
    public partial class frmReq010 : frmBase
    {

        #region"Define"

        #endregion

        #region"Property"

        #endregion

        #region"Event"

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmReq010()
        {
            InitializeComponent();

            try
            {
                //機能コードを設定
                FeaturesCD = FEATURES.REQ010;

                //画面初期化
                InitDisp();

                //各コンボボックスのリストを作成
                MakeComboList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /// <summary>
        /// 作成ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMak_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtSime.Text == "")
                {
                    MessageBox.Show("対象締日が未入力です。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dtoReq010 dto = new dtoReq010();

                dto.CutOffDay = int.Parse(txtSime.Text);
                dto.CusCode = cmbCus.SelectedValue.ToString();
                dto.SyncFlf = (int)clsDefine.OperatingStatus;
                dto.TimeStamp = DateTime.Now.ToString("yyyyMMddhhmmss");

                using (srvReq010 srv = new srvReq010())
                {
                    srv.MakeReqData(dto);
                }

                MessageBox.Show("請求データの作成が完了しました。", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            Close();
        }

        /// <summary>
        /// 締日検証後
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSime_Validated(object sender, EventArgs e)
        {

            try
            {
                MakeComboList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        #endregion

        #region"Method"

        /// <summary>
        /// 各コンボボックスのリストを作成
        /// </summary>
        private void MakeComboList()
        {
            try
            {
                DataTable CUSTable = new DataTable();

                using (srvReq010 srv = new srvReq010())
                {
                    int Sime = 0;
                    if (!string.IsNullOrEmpty(txtSime.Text))
                    {
                        Sime = int.Parse(txtSime.Text);
                    } 
                    CUSTable = srv.GetCustomer(Sime);
                }

                DataRow row;
                //得意先
                row = CUSTable.NewRow();
                row[0] = "00000000";
                row[1] = "全て";
                CUSTable.Rows.InsertAt(row, 0);
                cmbCus.DataSource = CUSTable;
                cmbCus.ValueMember = "CUSTOMER_CD";
                cmbCus.DisplayMember = "NAME";
                cmbCus.SelectedIndex = 0;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 画面を初期化
        /// </summary>
        private void InitDisp()
        {
            try
            {
                txtSime.Text = string.Empty;
                cmbCus.SelectedIndex = -1;
            }
            catch
            {
                throw;
            }
        }


        #endregion

    }
}
