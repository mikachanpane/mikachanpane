using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;

namespace Sugitec.Common
{
    /// <summary>
    /// 数字とバックスペース以外の入力を無効にしたTextBox
    /// </summary>
    public partial class ctlNumTextBoxEx : ctlTextBoxEx
    {
        private const int WM_PASTE = 0x302;

        [SecurityPermission(SecurityAction.Demand,Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_PASTE)
            {
                IDataObject iData = Clipboard.GetDataObject();
                //文字列がクリップボードにあるか
                if (iData != null && iData.GetDataPresent(DataFormats.Text))
                {
                    string clipStr = (string)iData.GetData(DataFormats.Text);

                    //数値以外か入力可能文字以外があればキャンセル
                    if (string.IsNullOrEmpty(AllowKeyChars))
                    {
                        if (!System.Text.RegularExpressions.Regex.IsMatch(clipStr, @"^[0-9]+$"))
                        {
                            return;
                        }
                    }
                    else
                    {
                        if (!System.Text.RegularExpressions.Regex.IsMatch(clipStr, string.Format(@"^[0-9,{0}]+$",AllowKeyChars)))
                        {
                            return;
                        }
                    }
                }
            }

            base.WndProc(ref m);
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ctlNumTextBoxEx()
        {
            //IMEを無効にする
            base.ImeMode = ImeMode.Disable;
            
        }

        /// <summary>
        /// ImeMode
        /// </summary>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new ImeMode ImeMode
        {
            get { return base.ImeMode; }
            set { }
        }

        [Category("動作")]
        [Description("数字以外で入力が可能な文字を指定します")]
        public string AllowKeyChars { get; set; }

        [Category("動作")]
        [DefaultValue(false)]
        [Description("最大桁数まで左ゼロ埋めを行います")]
        public bool ZeroPading { get; set; }

        /// <summary>
        /// OnKeyPress
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            //バックスペースが入力された時はキャンセルしない
            if (e.KeyChar == '\b')
            {
                return;
            }

            //数字が入力された時はキャンセルしない
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            
            //数字以外が入力された時に入力可能文字が空白の場合はキャンセルする
            if (string.IsNullOrEmpty(AllowKeyChars))
            {
                e.Handled = true;
                return;
            }

            //数字以外が入力された時に入力可能文字に一致しない場合はキャンセルする
            if (AllowKeyChars.IndexOf(e.KeyChar) < 0 )
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// OnValidated
        /// </summary>
        /// <param name="e"></param>
        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
            if (ZeroPading && !string.IsNullOrEmpty(base.Text))
            {
                base.Text = base.Text.PadLeft(MaxLength, '0');
            }

        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);

            bool chkHyphen = false;
            if (this.AllowKeyChars == "-")
            {
                chkHyphen = true;
            }
            using (frmTenKey frm = new frmTenKey(this.MaxLength, chkHyphen))
            {
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    base.Text = frm.inputNum;
                }
            }
        }
    }
}

