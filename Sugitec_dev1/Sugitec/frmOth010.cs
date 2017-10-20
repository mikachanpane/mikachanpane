using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

using Sugitec.Common;
using Sugitec.Logics;



namespace Sugitec
{
	public partial class frmOth010 : frmBase
	{
		#region”　Event　”

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public frmOth010()
		{
			InitializeComponent();

			try
			{
				//機能コードをセット：INQ010
				base.FeaturesCD = FEATURES.OTH010;
                ClearScreenItem();
                //社外文書一覧をデータグリッドビューに表示
                initdgvList("E10");
                //EXCEL2007以前（未インストール含む）の場合はPDF出力、印刷は使用不可
                if (clsDefine.isOutPdfOrPrint)
                {
                    btnPdf.Enabled = true;
                    btnPrint.Enabled = true;
                }
                else
                {
                    btnPdf.Enabled = false;
                    btnPrint.Enabled = false;
                }
            }
            catch (Exception)
			{

			}
		}

        private void ClearScreenItem()
        {
            try
            {
                rdoOutside.Checked = true;
            dgvEngList.DataSource = null;
            dgvList.DataSource = null;
            cmbCus.SelectedIndex = -1;
            cmbCon.SelectedIndex = -1;
            }
            catch
            {
                throw;
            }
        }

        private void rdoOutside_CheckedChanged(object sender, EventArgs e)
        {

                if (rdoOutside.Checked)
            {
                    cmbCon.Visible = true;
                    cmbCus.Visible = true;
                    pnlCus.Visible = true;
                    dgvEngList.DataSource = null;
                    dgvList.DataSource = null;
                    dgvEngList.Visible = false;
                    label1.Visible = true;
                    label2.Visible = true;
                    //コンボボックスに得意先を取得
                    //サービス
                    using (srvOth010 srv = new srvOth010())
                        {
                            //得意先名取得
                            cmbCus.DataSource = srv.SelectCustomer();
                            cmbCus.ValueMember = "CODE";
                            cmbCus.DisplayMember = "NAME";
                            cmbCus.SelectedIndex = -1;
                        }
                //社外文書一覧をデータグリッドビューに表示
                initdgvList("E10");
            }

        }

        private void rdoIntside_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoIntside.Checked)
                {
                    pnlCus.Visible = false;
                    dgvEngList.Visible = true;
                    dgvEngList.DataSource = null;
                    dgvList.DataSource = null;
                    label1.Visible = false;
                    label2.Visible = false;
                    cmbCon.Visible = false;
                    cmbCus.Visible = false;
                    //社員一覧を取得
                    DataTable getdt = new DataTable();
                    using (srvOth010 srv = new srvOth010())
                    {
                        dgvEngList.AutoGenerateColumns = false;
                        getdt = srv.SelectEng();
                        dgvEngList.DataSource = getdt;
                        dgvEngList.Columns[0].DataPropertyName = "SEL0";
                        dgvEngList.Columns[1].DataPropertyName = "ID";
                        dgvEngList.Columns[2].DataPropertyName = "NAME";
                    }
                    //データグリッドビューに社内文書一覧を表示
                    initdgvList("E01");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// 終了ボタン
        /// </summary>
        private void btnEnd_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        /// <summary>
        /// Excel出力ボタン、PDF出力ボタン、印刷ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOut_Click(object sender, EventArgs e)
        {
            //レポートを出力
            try
            {

                //入力チェック
                if (rdoOutside.Checked)
                {
                    if (cmbCus.SelectedIndex == -1)
                    {
                        MessageBox.Show("得意先が未選択です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (cmbCon.SelectedIndex == -1)
                    {
                        MessageBox.Show("担当者が未選択です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    if (dgvEngList.DataSource == null)
                    {
                        return;
                    }
                    DataTable dt = (DataTable)dgvEngList.DataSource;
                    DataRow[] dr = dt.Select("SEL0 = 1");
                    if (dr.Length == 0)
                    {
                        MessageBox.Show("技術者が未選択です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                //出力確認
                string OutFolder = "";
                FileOutput Output = FileOutput.PRINTER;

                Button btn = (Button)sender;
                if (btn.Name == "btnExcel" || btn.Name == "btnPdf")
                {

                    Output = btn.Name == "btnExcel" ? FileOutput.EXCEL : FileOutput.PDF;

                    //出力先を指定
                    using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                    {
                        //上部に表示する説明テキストを指定する
                        fbd.Description = "保存先のフォルダを指定してください。";
                        //ルートフォルダを指定する
                        fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
                        //ユーザーが新しいフォルダを作成できるようにする
                        fbd.ShowNewFolderButton = true;
                        //ダイアログを表示する
                        if (fbd.ShowDialog(this) != DialogResult.OK)
                        {
                            return;
                        }
                        OutFolder = fbd.SelectedPath;
                    }
                }
                else
                {
                    Output = FileOutput.PRINTER;
                    if (MessageBox.Show("送付状を出力します。よろしいですか？", base.FeatureNM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                }

                //サービス
                using (srvOth010 srv = new srvOth010())
                {
                    if (rdoOutside.Checked)
                    {
                        //社外用送付状出力（ClosedXML 出力）
                        srv.MakeSendExcelWorkBook(Output, OutFolder, (DataTable)dgvList.DataSource, 
                                                  cmbCus.SelectedValue.ToString(), cmbCon.SelectedValue.ToString());

                    }
                    else
                    {
                        //社内用送付状出力（ClosedXML 出力）
                        srv.MakeSendExcelWorkBooks(Output, OutFolder, (DataTable)dgvList.DataSource, (DataTable)dgvEngList.DataSource);

                    }

                }
                MessageBox.Show("出力しました", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
			{

                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
}

        private void cmbCus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCus.SelectedIndex >= 0)
            {
                //得意先の担当者を担当者のコンボボックスに格納
                //サービス
                using (srvOth010 srv = new srvOth010())
                {
                    //担当者取得
                    cmbCon.DataSource = srv.SelectContactM(cmbCus.SelectedValue.ToString());
                    cmbCon.ValueMember = "CONTACT_CODE";
                    cmbCon.DisplayMember = "CONTACT_NAME";
                    cmbCon.SelectedIndex = -1;
                }
            }
        }

        private void initdgvList(string str)
        {
            DataTable getdt = new DataTable();
            using (srvOth010 srv = new srvOth010())
            {
                dgvList.AutoGenerateColumns = false;
                getdt = srv.SelectCode(str);
                dgvList.DataSource = getdt;
                dgvList.Columns[0].DataPropertyName = "SEL0";
                dgvList.Columns[1].DataPropertyName = "CONTENT";
                dgvList.Columns[2].DataPropertyName = "NOC";
            }
        }

        #endregion

    }
}
