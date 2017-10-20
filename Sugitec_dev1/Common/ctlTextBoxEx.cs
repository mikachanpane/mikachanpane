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
    public partial class ctlTextBoxEx : TextBox
    {

        [Category("表示")]
        [Description("フォーカス取得時に設定されていた値")]
        public string OldText { get; set; }

        private bool firstMouseDown = false;

        public ctlTextBoxEx()
        {
            InitializeComponent();
        }

        protected override void OnEnter(System.EventArgs e)
        {
            base.OnEnter(e);

            OldText = base.Text;

            SelectAll();
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

    }
}
