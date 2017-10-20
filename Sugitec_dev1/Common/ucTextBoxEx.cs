using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.ComponentModel;
using System.Globalization;

namespace Sugitec.Common
{
    public class ucTextBoxEx : TextBox
    {

        #region "Field"

        /// <summary>イベント制御フラグ</summary>
        private bool EventFlg = true;

        /// <summary>入力を受け付ける文字種の定義</summary>
        public enum emCharacterType : int
        {
            /// <summary>全て</summary>
            None = 0,
            /// <summary>数値</summary>
            OnlyNumeric = 1,
            /// <summary>英数</summary>
            OnlyAlphaNumeric = 2,
            /// <summary>英数記</summary>
            OnlyAlphaNumericSymbol = 3,
            /// <summary>半角</summary>
            OnlyNarrow = 4,
            /// <summary>全角</summary>
            OnlyWide = 5,
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
        [DefaultValue(typeof(Type), "None")]
        [Description("入力を受け付ける文字種を指定します。")]
        public emCharacterType xCharacterType { get; set; }

        /// <summary>入力禁止文字</summary>
        [Browsable(true)]
        [Category("その他")]
        [Description("入力を禁止する文字を指定します。")]
        public string xIllegalCharacter { get; set; }

        /// <summary>MaxLengthをByteで行う</summary>
        [Browsable(true)]
        [Category("その他")]
        [DefaultValue(typeof(bool), "false")]
        [Description("MaxLengthをバイト数で制限するかどうかを指定します。")]
        public bool xMaxLengthByByte { get; set; }

        /// <summary>書式フォーマット</summary>
        [Browsable(true)]
        [Category("その他")]
        [Description("表示時に適用される書式指定文字列です。")]
        public string xFormat { get; set; }

        /// <summary>最大桁数までゼロ埋めを行う。（文字種がコードのみ有効）</summary>
        [Browsable(true)]
        [Category("その他")]
        [DefaultValue(typeof(Type), "None")]
        [Description("最大桁数までゼロ埋めを行います。文字種がコードの場合のみ有効です。")]
        public emPaddingType xZeroPadding { get; set; }

        /// <summary>変更前の値（フォーカス取得時に設定されていた値）</summary>
        [Browsable(false)]
        [Category("その他")]
        [Description("変更前の値（フォーカス取得時に設定されていた値）")]
        public string xOldText { get; set; }

        #endregion

        #region "Event"

        /// <summary>
        /// フォーカスを取得時
        /// </summary>
        /// <param name="e"></param>
        /// <remarks></remarks>
        protected override void OnEnter(System.EventArgs e)
        {
            base.OnEnter(e);

            EventFlg = false;

            decimal tmp = 0;

            if (xCharacterType == emCharacterType.OnlyNumeric && 
                !string.IsNullOrEmpty(base.Text) && 
                decimal.TryParse(base.Text, NumberStyles.Any, null,out tmp))
            {
                base.Text = tmp.ToString();
            }

            xOldText = base.Text;

            EventFlg = true;

            base.SelectAll();
        }

        /// <summary>
        /// フォーカスを喪失時
        /// </summary>
        /// <param name="e"></param>
        /// <remarks></remarks>
        protected override void OnValidated(System.EventArgs e)
        {
            EventFlg = false;

            if (xCharacterType == emCharacterType.OnlyNumeric)
            {
                decimal tmp = 0;
                if (decimal.TryParse(base.Text, NumberStyles.Any, null, out tmp))
                {
                    base.Text = tmp.ToString(xFormat);
                }
                else
                {
                    base.Text = string.Empty;
                }
            }

            if (xCharacterType == emCharacterType.OnlyNumericCode && !string.IsNullOrEmpty(base.Text))
            {
                if (xZeroPadding == emPaddingType.Left)
                {
                    base.Text = base.Text.PadLeft(base.MaxLength,'0');
                }
                else if(xZeroPadding == emPaddingType.Right)
                {
                    base.Text = base.Text.PadRight(base.MaxLength, '0');
                }
            }

            EventFlg = true;
            base.OnValidated(e);
    
        }

        /// <summary>
        /// テキストボックス内のテキストを変更時
        /// </summary>
        /// <param name="e"></param>
        /// <remarks></remarks>
        protected override void OnTextChanged(System.EventArgs e)
        {

            base.OnTextChanged(e);

            if (!EventFlg) { return; }

            if (string.IsNullOrEmpty(base.Text)) { return; }

            int selectionIndex = base.SelectionStart;
            string patternOK = "";

            switch (xCharacterType)
            {
                case ucTextBoxEx.emCharacterType.OnlyNumeric:
                    if (base.Focused)
                    {
                        patternOK = "^[0-9.-]+$";
                    }
                    else
                    {
                        patternOK = "^[0-9,.-]+$";
                    }
                    break;
                case ucTextBoxEx.emCharacterType.OnlyAlphaNumeric:
                    patternOK = "^[a-zA-Z0-9]+$";
                    break;
                case ucTextBoxEx.emCharacterType.OnlyAlphaNumericSymbol:
                    patternOK = "^[a-zA-Z0-9!-/:-@¥[-`{-~]+$";
                    break;
                case ucTextBoxEx.emCharacterType.OnlyNarrow:
                    patternOK = "^[ -~｡-ﾟ]+$";
                    break;
                case ucTextBoxEx.emCharacterType.OnlyWide:
                    patternOK = "^[^ -~｡-ﾟ]+$";
                    break;
                case ucTextBoxEx.emCharacterType.OnlyNumericCode:
                    patternOK = "^[0-9]+$";
                    break;
                case ucTextBoxEx.emCharacterType.OnlyNumericSymbol:
                    patternOK = "^[0-9-]+$";
                    break;
                default:
                    patternOK = "";
                    break;
            }

            string patternNG = "";
            
            if (!string.IsNullOrEmpty(xIllegalCharacter))
            {
                patternNG = "^[" + xIllegalCharacter + "]+$";
            }

            Regex regexOK = new Regex(patternOK);
            Regex regexNG = new Regex(patternNG);
            Regex regexWide = new Regex("^[^ -~｡-ﾟ]+$");
            StringBuilder sb = new StringBuilder();
            int size = 0;


            for (int i = 0; i < base.Text.Length; i++)
            {
                string s = base.Text.Substring(i, 1);
                bool isError = false;

                //指定された文字種に合致しない場合は入力不可
                if (!string.IsNullOrEmpty(patternOK) && !regexOK.IsMatch(s))
                {
                    isError = true;
                }

                //禁則文字に合致する場合は入力不可
                if (!string.IsNullOrEmpty(patternNG) && regexNG.IsMatch(s))
                {
                    isError = true;
                }

                //文字種が数値の場合
                if (xCharacterType == emCharacterType.OnlyNumeric)
                {
                    //既にピリオドがある場合はピリオドは入力不可
                    if (s == "." && sb.ToString().IndexOf(".") != -1)
                    {
                        isError = true;
                    }

                    //先頭以外はハイフンは入力不可
                    if (s == "-" && sb.ToString().Length > 0)
                    {
                        isError = true;
                    }
                }

                //MaxLengthバイト数制限チェック
                if (xMaxLengthByByte)
                {
                    if (regexWide.IsMatch(s))
                    {
                        size += 2;
                    }
                    else
                    {
                        size += 1;
                    }

                    if (size > base.MaxLength)
                    {
                        isError = true;
                    }
                }

                //エラー無しの場合
                if (!isError)
                {
                    sb.Append(s);
                }
            }

            base.Text = sb.ToString();

            if (selectionIndex > base.Text.Length)
            {
                base.SelectionStart = base.Text.Length;
            }
        }

        #endregion

    }
}
