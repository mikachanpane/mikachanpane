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

namespace Sugitec
{
    public partial class frmMenu01 : frmBase
    {
        public frmMenu01()
        {
            InitializeComponent();

            //機能コードを設定
            this.FeaturesCD = FEATURES.MENU01;
        }

        private void btnOrd010_Click(object sender, EventArgs e)
        {
            using (frmOrd010 frm = new frmOrd010(FEATURES.ORD010))
            {
                frm.ShowDialog();
            }
        }

        private void btnOrd020_Click(object sender, EventArgs e)
        {
            using (frmOrd020 frm = new frmOrd020(FEATURES.MENU01))
            {
                frm.ShowDialog();
            }
        }

        private void btnRec010_Click(object sender, EventArgs e)
        {
            using (frmRec010 frm = new frmRec010(FEATURES.REC010))
            {
                frm.ShowDialog();
            }
        }

        private void btnRec020_Click(object sender, EventArgs e)
        {
            using (frmRec020 frm = new frmRec020())
            {
                frm.ShowDialog();
            }
        }

        private void btnSal020_Click(object sender, EventArgs e)
        {
            using (frmSal020 frm = new frmSal020())
            {
                frm.ShowDialog();
            }
        }

        private void btnReq010_Click(object sender, EventArgs e)
        {
            using (frmReq010 frm = new frmReq010())
            {
                frm.ShowDialog();
            }

        }

        private void btnReq020_Click(object sender, EventArgs e)
        {
            using (frmReq020 frm = new frmReq020())
            {
                frm.ShowDialog();
            }
        }

        private void btnInq010_Click(object sender, EventArgs e)
        {
            using (frmInq010 frm = new frmInq010())
            {
                frm.ShowDialog();
            }
        }

        private void btnInq100_Click(object sender, EventArgs e)
        {
            using (frmInq100 frm = new frmInq100())
            {
                frm.ShowDialog();
            }
        }

        private void btnMnt100_Click(object sender, EventArgs e)
        {
            using (frmMnt100 frm = new frmMnt100())
            {
                frm.ShowDialog();
            }
        }

        private void btnMnt110_Click(object sender, EventArgs e)
        {
            using (frmMnt110 frm = new frmMnt110())
            {
                frm.ShowDialog();
            }
        }

        private void btnMnt120_Click(object sender, EventArgs e)
        {
            using (frmMnt120 frm = new frmMnt120())
            {
                frm.ShowDialog();
            }
        }

        private void btnMnt130_Click(object sender, EventArgs e)
        {
            using (frmMnt130 frm = new frmMnt130())
            {
                frm.ShowDialog();
            }
        }

        private void btnMnt030_Click(object sender, EventArgs e)
        {
            using (frmMnt030 frm = new frmMnt030())
            {
                frm.ShowDialog();
            }
        }

        private void btnMnt040_Click(object sender, EventArgs e)
        {
            using (frmMnt040 frm = new frmMnt040())
            {
                frm.ShowDialog();
            }
        }

        private void btnDat010_Click(object sender, EventArgs e)
        {

        }

        private void btnOth010_Click(object sender, EventArgs e)
        {
            using (frmOth010 frm = new frmOth010())
            {
                frm.ShowDialog();
            }
        }

        private void btnDep010_Click(object sender, EventArgs e)
        {
            using (frmDep010 frm = new frmDep010())
            {
                frm.ShowDialog();
            }

        }

    }
}
