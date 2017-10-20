using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Sugitec.Common
{
    public partial class ucNumTextBox : UserControl
    {

        #region "Field"

        /// <summary>入力を受け付ける文字種の定義</summary>
        public enum emCharacterType : int
        {
            /// <summary>数値</summary>
            OnlyNumeric = 1,
            /// <summary>コード（数値のみ）</summary>
            OnlyNumericCode = 6,
            /// <summary>数値記号</summary>
            OnlyNumericSymbol = 7
        }

        /// <summary>パディングを行う方向の定義</summary>
        public enum emPaddingType : int
        {
            /// <summary>しない</summary>
            None = 0,
            /// <summary>左</summary>
            Left = 1,
            /// <summary>右</summary>
            Right = 2
        }

        #endregion

        #region "Property"

        /// <summary>入力を受け付ける文字種</summary>
        [Browsable(true)]
        [Category("その他")]
        [DefaultValue(typeof(Type), "OnlyNumeric")]
        [Description("入力を受け付ける文字種を指定します。")]
        public emCharacterType CharacterType
        {
            get
            {
                if (txtInput.xCharacterType == ucTextBoxEx.emCharacterType.OnlyNumeric ||
                    txtInput.xCharacterType == ucTextBoxEx.emCharacterType.OnlyNumericCode ||
                    txtInput.xCharacterType == ucTextBoxEx.emCharacterType.OnlyNumericSymbol)
                {
                    return (emCharacterType)txtInput.xCharacterType;
                }
                else
                {
                    return emCharacterType.OnlyNumeric;
                }
            }

            set { txtInput.xCharacterType = (ucTextBoxEx.emCharacterType)value; }
        }

        /// <summary>入力禁止文字</summary>
        [Browsable(true)]
        [Category("その他")]
        [Description("入力を禁止する文字を指定します。")]
        public string IllegalCharacter
        {
            get { return txtInput.xIllegalCharacter; }

            set { txtInput.xIllegalCharacter = value; }
        }

        /// <summary>書式フォーマット</summary>
        [Browsable(true)]
        [Category("その他")]
        [Description("表示時に適用される書式指定文字列です。")]
        public string Format
        {
            get { return txtInput.xFormat; }


            set { txtInput.xFormat = value; }
        }

        /// <summary>最大桁数までゼロ埋めを行う。（文字種がコードのみ有効）</summary>
        [Browsable(true)]
        [Category("その他")]
        [DefaultValue(typeof(Type), "None")]
        [Description("最大桁数までゼロ埋めを行います。文字種がコードの場合のみ有効です。")]
        public emPaddingType ZeroPadding
        {
            get { return (emPaddingType)txtInput.xZeroPadding; }


            set { txtInput.xZeroPadding = (ucTextBoxEx.emPaddingType)value; }
        }

        /// <summary>変更前の値（フォーカス取得時に設定されていた値）</summary>
        [Browsable(false)]
        [Category("その他")]
        [Description("変更前の値（フォーカス取得時に設定されていた値）")]
        public string OldText
        {
            get { return txtInput.xOldText; }


            set { txtInput.xOldText = value; }
        }

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(Type), "Window")]
        [Description("背景色です。")]
        public new Color BackColor
        {
            get { return txtInput.BackColor; }
            set { txtInput.BackColor = value; }
        }

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(Type), "Fixed3D")]
        [Description("境界線スタイルを示します。")]
        public new BorderStyle BorderStyle
        {
            get { return txtInput.BorderStyle; }
            set { txtInput.BorderStyle = value; }
        }

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(Type), "ＭＳ ゴシック, 9.75pt")]
        [Description("テキストを表示するフォントです。")]
        public new Font Font
        {
            get { return txtInput.Font; }
            set
            {
                txtInput.Font = value;
                //位置とサイズを調整
                MyResize();
            }
        }

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(Type), "WindowText")]
        [Description("前景色です。")]
        public new Color ForeColor
        {
            get { return txtInput.ForeColor; }
            set { txtInput.ForeColor = value; }
        }

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(Type), "Right")]
        [Description("テキストの配置を示します。")]
        public HorizontalAlignment TextAlign
        {
            get { return txtInput.TextAlign; }
            set { txtInput.TextAlign = value; }
        }

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(string), "")]
        [Description("コントロールに関連付けられているテキストです。")]
        public new string Text
        {
            get { return txtInput.Text; }
            set { txtInput.Text = value; }
        }

        [Browsable(true)]
        [Category("動作")]
        [DefaultValue(typeof(int), "32767")]
        [Description("最大値を示します。")]
        public int MaxLength
        {
            get { return txtInput.MaxLength; }
            set { txtInput.MaxLength = value; }
        }

        #endregion

        #region "Event"

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ucNumTextBox()
        {
            InitializeComponent();

            //位置とサイズを調整
            MyResize();

        }

        /// <summary>
        /// サイズ変更
        /// </summary>
        /// <param name="e"></param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            //位置とサイズを調整
            MyResize();

        }

        /// <summary>
        /// テキストボックスとボタンの位置を調整
        /// </summary>
        private void MyResize()
        {
            //テキストボックスの幅をボタン分削減する
            txtInput.Width = this.Width - txtInput.Height;

            //ボタンの位置、サイズを調整
            btnTenkey.Top = txtInput.Top;
            btnTenkey.Height = txtInput.Height;
            btnTenkey.Width = txtInput.Height;
            btnTenkey.Left = txtInput.Width;

        }

        /// <summary>
        /// テンキーボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTenkey_Click(object sender, EventArgs e)
        {

            bool chkHyphen = false;
            if (CharacterType == emCharacterType.OnlyNumericSymbol)
            {
                chkHyphen = true;
            }
            using (frmTenKey frm = new frmTenKey(txtInput.MaxLength, chkHyphen))
            {
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    SetText(frm.inputNum);
                }
            }
        }

        /// <summary>
        /// テンキーからの値をコントロールにセットする
        /// </summary>
        /// <param name="inText">テンキーからの値</param>
        private void SetText(string inText)
        {
            if (CharacterType == emCharacterType.OnlyNumeric)
            {
                //文字種が数値の場合
                decimal tmp = 0;
                if (decimal.TryParse(inText, NumberStyles.Any, null, out tmp))
                {
                    Text = tmp.ToString(Format);
                }
                else
                {
                    Text = string.Empty;
                }
            }

            else if (CharacterType == emCharacterType.OnlyNumericCode && !string.IsNullOrEmpty(inText) && MaxLength <= 20)
            {
                //文字種がコードの場合
                if (ZeroPadding == emPaddingType.Left)
                {
                    Text = inText.PadLeft(MaxLength, '0');
                }
                else if (ZeroPadding == emPaddingType.Right)
                {
                    Text = inText.PadRight(MaxLength, '0');
                }
            }
            else
            {
                //上記以外の場合
                Text = inText;
            }
        }

        /// <summary>
        /// フォーカスを取得時
        /// </summary>
        /// <param name="e"></param>
        /// <remarks></remarks>
        protected override void OnEnter(System.EventArgs e)
        {
            base.OnEnter(e);

            OldText = txtInput.Text;

        }

        #endregion

    }
}
