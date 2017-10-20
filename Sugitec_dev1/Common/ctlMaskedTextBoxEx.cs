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
    public partial class ctlMaskedTextBoxEx : MaskedTextBox
    {

        private bool firstMouseDown = false;

        public ctlMaskedTextBoxEx()
        {
            InitializeComponent();
        }

        protected override void OnEnter(System.EventArgs e)
        {
            SelectAll();
            base.OnEnter(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (firstMouseDown)
            {
                SelectAll();
                firstMouseDown = false;
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (!this.Focused)
                firstMouseDown = true;
            else
                firstMouseDown = false;

            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            firstMouseDown = false;
            base.OnMouseLeave(e);
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            if ((base.Mask == "0000年00月" || base.Mask == "0000/00") && !string.IsNullOrEmpty(base.Text))
            {
                if(base.Text.Length <= 4)
                {
                    e.Cancel = true;
                    return;
                }
                else if(base.Text.IndexOf(" ") > -1 && base.Text.IndexOf(" ") <= 3)
                {
                    e.Cancel = true;
                    return;
                }

                string sYm = string.Empty;
                if (base.Text.Length == 5)
                {
                    sYm = base.Text.LeftEx(4) + "/0" + base.Text.RightEx(1);
                }
                else
                {
                    sYm = base.Text.LeftEx(4) + "/" + base.Text.RightEx(2).Replace(" ", "0");
                }

                DateTime dt = new DateTime();
                if (DateTime.TryParse(sYm + "/01",out dt))
                {
                    base.Text = sYm.Replace("/","");
                    base.OnValidating(e);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                base.OnValidating(e);
            }
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            if ((base.Mask == "0000年00月" || base.Mask == "0000/00"))
            {
                using (frmYm frm = new frmYm(base.Text))
                {
                    DialogResult dr = frm.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        base.Text = frm.retYm;
                    }
                }
            }
            base.OnMouseDoubleClick(e);
        }
    }
}
