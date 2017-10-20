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
    public partial class ctlNumericUpDownEx : NumericUpDown
    {

        //private bool firstMouseDown = false;

        public ctlNumericUpDownEx()
        {
            InitializeComponent();
        }

        protected override void OnEnter(System.EventArgs e)
        {
            base.OnEnter(e);
            base.Select(0, base.Text.Length);
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);

            int len = 0;
            int dec = 0;

            if (this.Maximum - System.Math.Floor(this.Maximum) != 0)
            {
                int pos = Maximum.ToString().IndexOf(".");
                len = pos;
                dec = this.Maximum.ToString().Length - (pos + 1);
            }
            else
            {
                len = this.Maximum.ToString().Length;
                dec = 0;
            }

            using (frmTenKey frm = new frmTenKey(this.Maximum.ToString().Length, false, len, dec))
            {
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Decimal inputNum = frm.inputNum.ToDecimalEx();
                    if ((inputNum <= this.Maximum) && (inputNum >= this.Minimum))
                    {
                        base.Value = inputNum;
                    }
                    else if(inputNum < this.Minimum)//最小値未満の場合は最小値を設定
                    {
                        base.Value = this.Minimum;
                    }
                    else if (inputNum > this.Maximum)//最大値を超える場合は最大値を設定
                    {
                        base.Value = this.Maximum;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        //protected override void OnMouseDown(MouseEventArgs e)
        //{
        //    if (firstMouseDown)
        //    {
        //        base.Select(0, base.Value.ToString().Length);
        //        firstMouseDown = false;
        //    }
        //    base.OnMouseDown(e);
        //}

        //protected override void OnMouseEnter(EventArgs e)
        //{
        //    if (!this.Focused)
        //        firstMouseDown = true;
        //    else
        //        firstMouseDown = false;

        //    base.OnMouseEnter(e);
        //}

        //protected override void OnMouseLeave(EventArgs e)
        //{
        //    firstMouseDown = false;
        //    base.OnMouseLeave(e);
        //}

    }
}
