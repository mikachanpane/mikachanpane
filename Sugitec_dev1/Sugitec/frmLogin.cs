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
    public partial class frmLogin : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
            
            DialogResult = DialogResult.Cancel;

            //画面項目の初期化
            txt_User.Text = string.Empty;
            txt_Pass.Text = string.Empty;
            rdoLocal.Checked = true;
            chkSync.Checked = false;
            rdoSync1.Checked = false;
            rdoSync2.Checked = false;
            rdoSync3.Checked = false;

            //コントロールの制御
            if (!clsDefine.IsServerCon())
            {
                rdoServer.Enabled = false;
                chkSync.Enabled = false;
                rdoSync1.Enabled = false;
                rdoSync2.Enabled = false;
                rdoSync3.Enabled = false;
            }

            //  エクセルのバージョンを取得し共通クラスに設定
            try
            {
                using (clsExceltoPDF exl = new clsExceltoPDF())
                {
                    string sVer = exl.xlAppVersion;

                    clsDefine.ExcelVersion = double.Parse(sVer);
                }

            }
            catch (Exception)
            {
                clsDefine.ExcelVersion = 0;
            }

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            //動作状態を設定
            if (rdoLocal.Checked)
            {
                clsDefine.SetOpStat(OperatStatus.OFFLINE);
            }
            else
            {
                clsDefine.SetOpStat(OperatStatus.ONLINE);
            }

            //データの同期を行う







            //画面を閉じる
            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
