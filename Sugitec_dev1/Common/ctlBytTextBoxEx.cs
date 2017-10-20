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
    public partial class ctlBytTextBoxEx : ctlTextBoxEx
    {
        public ctlBytTextBoxEx()
        {
            InitializeComponent();

            this.ImeMode = ImeMode.On;
        }

        #region"MaxLengthをoverride"
        [Category("動作")]
        [Description("コントロールに入力できる最大バイト数を指定します。（全角文字:2Byte、半角文字:1Byte）")]
        public override int MaxLength
        {
            get
            {
                return base.MaxLength;
            }

            set
            {
                base.MaxLength = value;
            }
        }
        #endregion

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        #region　WndProc メソッド (override)

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            const int WM_CHAR = 0x0102;
            const int WM_PASTE = 0x0302;

            switch (m.Msg)
            {
                case WM_CHAR:
                    KeyPressEventArgs eKeyPress = new KeyPressEventArgs((char)(m.WParam.ToInt32()));
                    this.OnChar(eKeyPress);

                    if (eKeyPress.Handled)
                    {
                        return;
                    }
                    break;
                case WM_PASTE:
                    this.OnPaste(new System.EventArgs());
                    return;
            }

            base.WndProc(ref m);
        }

        #endregion

        #region　OnChar メソッド (virtual)

        protected virtual void OnChar(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            System.Text.Encoding sjisEncoding = System.Text.Encoding.GetEncoding("Shift_JIS");
            int textByteCount = sjisEncoding.GetByteCount(this.Text);
            int inputByteCount = sjisEncoding.GetByteCount(e.KeyChar.ToString());
            int selectedTextByteCount = sjisEncoding.GetByteCount(this.SelectedText);

            if ((textByteCount + inputByteCount - selectedTextByteCount) > this.MaxLength)
            {
                e.Handled = true;
            }
        }

        #endregion

        #region　OnPaste メソッド (virtual)

        protected virtual void OnPaste(System.EventArgs e)
        {
            object clipboardText = Clipboard.GetDataObject().GetData(System.Windows.Forms.DataFormats.Text);

            if (clipboardText == null)
            {
                return;
            }

            System.Text.Encoding sjisEncoding = System.Text.Encoding.GetEncoding("Shift_JIS");
            string inputText = clipboardText.ToString();
            int textByteCount = sjisEncoding.GetByteCount(this.Text);
            int inputByteCount = sjisEncoding.GetByteCount(inputText);
            int selectedTextByteCount = sjisEncoding.GetByteCount(this.SelectedText);
            int remainByteCount = this.MaxLength - (textByteCount - selectedTextByteCount);

            if (remainByteCount <= 0)
            {
                return;
            }

            this.SelectedText = inputText.LeftBEx(remainByteCount);
        }

        #endregion
    }
}
