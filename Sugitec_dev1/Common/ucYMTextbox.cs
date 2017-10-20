using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sugitec.Common
{
    public partial class ucYMTextbox : UserControl
    {

        #region "Property"

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(Type), "Window")]
        [Description("背景色です。")]
        public new Color BackColor
        {
            get { return masInput.BackColor; }
            set { masInput.BackColor = value; }
        }

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(Type), "Fixed3D")]
        [Description("境界線スタイルを示します。")]
        public new BorderStyle BorderStyle
        {
            get { return masInput.BorderStyle; }
            set { masInput.BorderStyle = value; }
        }

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(Type), "ＭＳ ゴシック, 9.75pt")]
        [Description("テキストを表示するフォントです。")]
        public new Font Font
        {
            get { return masInput.Font; }
            set
            {
                masInput.Font = value;
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
            get { return masInput.ForeColor; }
            set { masInput.ForeColor = value; }
        }

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(Type), "Right")]
        [Description("テキストの配置を示します。")]
        public HorizontalAlignment TextAlign
        {
            get { return masInput.TextAlign; }
            set { masInput.TextAlign = value; }
        }

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(string), "")]
        [Description("コントロールに関連付けられているテキストです。")]
        public new string Text
        {
            get { return masInput.Text; }
            set { masInput.Text = value; }
        }

        [Browsable(false)]
        [Description("変更前の値（フォーカス取得時に設定されていた値）")]
        public string OldValue { get; set; }

        #endregion

        #region "Event"

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ucYMTextbox()
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
            masInput.Width = this.Width - masInput.Height;

            //ボタンの位置、サイズを調整
            btnCalendar.Top = masInput.Top;
            btnCalendar.Height = masInput.Height;
            btnCalendar.Width = masInput.Height;
            btnCalendar.Left = masInput.Width;

        }

        /// <summary>
        /// カレンダーボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            using (frmYm frm = new frmYm(Text))
            {
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Text = frm.retYm;
                }
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

            OldValue = Text;

        }

        /// <summary>
        /// 検証時
        /// </summary>
        /// <param name="e"></param>
        protected override void OnValidating(CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(Text))
            {
                if (Text.Length <= 4)
                {
                    e.Cancel = true;
                    return;
                }
                else if (Text.IndexOf(" ") > -1 && Text.IndexOf(" ") <= 3)
                {
                    e.Cancel = true;
                    return;
                }

                string sYm = string.Empty;
                if (Text.Length == 5)
                {
                    sYm = Text.LeftEx(4) + "/0" + Text.RightEx(1);
                }
                else
                {
                    sYm = Text.LeftEx(4) + "/" + Text.RightEx(2).Replace(" ", "0");
                }

                DateTime dt = new DateTime();
                if (DateTime.TryParse(sYm + "/01", out dt))
                {
                    Text = sYm.Replace("/", "");
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


        #endregion

    }
}
