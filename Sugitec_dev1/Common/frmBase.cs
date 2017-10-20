using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sugitec.Common
{
    public partial class frmBase : Form
    {

        /// <summary>機能コード</summary>
        private FEATURES _FeaturesCD;

        /// <summary>コンストラクタ</summary>
        protected frmBase()
        {
            InitializeComponent();

            if(clsDefine.OperatingStatus == OperatStatus.ONLINE)
            {
                lblTitle.BackColor = Color.Orange;
                statusStrip1.Items["toolStripStatusLabel1"].Text = "サーバ処理";
       
            }
            else
            {
                lblTitle.BackColor = Color.Aqua;
                statusStrip1.Items["toolStripStatusLabel1"].Text = "ローカル処理";
            }
        }

        /// <summary>
        /// 機能コードの取得と設定を行う
        /// </summary>
        protected FEATURES FeaturesCD
        {
            get
            {
                return _FeaturesCD;
            }
            set
            {
                _FeaturesCD = value;
                //機能IDを取得し画面タイトルに設定
                this.Text = clsDefine.GetFeatureID(_FeaturesCD);
                //機能名を取得しタイトルラベルに設定
                this.lblTitle.Text = clsDefine.GetFeatureNM(_FeaturesCD);

            }
        }

        /// <summary>
        /// 機能名を取得
        /// </summary>
        protected string FeatureNM
        {
            get
            {
                return lblTitle.Text;
            }
        }

    }
}
