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
    public partial class ucNumUpDown : UserControl
    {

        #region "Property"

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(Type), "Window")]
        [Description("背景色です。")]
        public new Color BackColor
        {
            get { return numInput.BackColor; }
            set { numInput.BackColor = value; }
        }

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(Type), "Fixed3D")]
        [Description("境界線スタイルを示します。")]
        public new BorderStyle BorderStyle
        {
            get { return numInput.BorderStyle; }
            set { numInput.BorderStyle = value; }
        }

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(Type), "ＭＳ ゴシック, 9.75pt")]
        [Description("テキストを表示するフォントです。")]
        public new Font Font
        {
            get { return numInput.Font; }
            set
            {
                numInput.Font = value;
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
            get { return numInput.ForeColor; }
            set { numInput.ForeColor = value; }
        }

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(Type), "Right")]
        [Description("テキストの配置を示します。")]
        public HorizontalAlignment TextAlign
        {
            get { return numInput.TextAlign; }
            set { numInput.TextAlign = value; }
        }

        [Browsable(true)]
        [Category("表示")]
        [DefaultValue(typeof(decimal), "0")]
        [Description("現在の値です。")]
        public decimal Value
        {
            get { return numInput.Value; }
            set { numInput.Value = value; }
        }

        [Browsable(true)]
        [Category("データ")]
        [DefaultValue(typeof(int), "0")]
        [Description("表示する小数点以下の桁数を示します。")]
        public int DecimalPlaces
        {
            get { return numInput.DecimalPlaces; }
            set { numInput.DecimalPlaces = value; }
        }

        [Browsable(true)]
        [Category("データ")]
        [DefaultValue(typeof(decimal), "99999999")]
        [Description("最大値を示します。")]
        public decimal Maximum
        {
            get { return numInput.Maximum; }
            set { numInput.Maximum = value; }
        }

        [Browsable(true)]
        [Category("データ")]
        [DefaultValue(typeof(decimal), "0")]
        [Description("最小値を示します。")]
        public decimal Minimum
        {
            get { return numInput.Minimum; }
            set { numInput.Minimum = value; }
        }

        [Browsable(true)]
        [Category("データ")]
        [DefaultValue(typeof(bool), "false")]
        [Description("３桁ごとに区切り記号を挿入するかを示します。")]
        public bool ThousandsSeparator
        {
            get { return numInput.ThousandsSeparator; }
            set { numInput.ThousandsSeparator = value; }
        }

        [Browsable(false)]
        [Description("変更前の値（フォーカス取得時に設定されていた値）")]
        public decimal OldValue { get; set; }

        #endregion

        #region "Event"

        public event EventHandler<EventArgs> ValueValidated;

        /// <summary> 
        /// テキストボックス、テンキーで値が確定された場合に発生します 
        /// </summary> 
        /// <param name="e"></param> 
        [Browsable(true)]
        [Description("テキストボックス、テンキーで値が確定されたときに発生するイベントです")]
        protected virtual void OnValueValidated(EventArgs e)
        {
            ValueValidated?.Invoke(this, e);
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ucNumUpDown()
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
            numInput.Width = this.Width - numInput.Height;

            //ボタンの位置、サイズを調整
            btnTenkey.Top = numInput.Top;
            btnTenkey.Height = numInput.Height;
            btnTenkey.Width = numInput.Height;
            btnTenkey.Left = numInput.Width;

        }

        /// <summary>
        /// テンキーボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTenkey_Click(object sender, EventArgs e)
        {

            //小数部の桁数
            int decimals = numInput.DecimalPlaces;
            //整数部の桁数
            int integers = numInput.Maximum.ToString().Length - (decimals==0 ? 0 : decimals + 1);
            //全体の桁数
            int allLength = integers + decimals + 1;

            ///テンキーを表示
            using (frmTenKey frm = new frmTenKey(allLength, false, integers, decimals))
            {
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Decimal inputNum = frm.inputNum.ToDecimalEx();
                    if ((inputNum <= numInput.Maximum) && (inputNum >= numInput.Minimum))
                    {
                        numInput.Value = inputNum;
                    }
                    else if (inputNum < numInput.Minimum)
                    {
                        //最小値未満の場合は最小値を設定
                        numInput.Value = numInput.Minimum;
                    }
                    else if (inputNum > numInput.Maximum)
                    {
                        //最大値を超える場合は最大値を設定
                        numInput.Value = numInput.Maximum;
                    }
                    else
                    {
                        return;
                    }

                    OnValueValidated(EventArgs.Empty);
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

            OldValue = numInput.Value;

        }

        #endregion

        /// <summary>
        /// テキストボックスの値検証後
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numInput_Validated(object sender, EventArgs e)
        {
            OnValueValidated(EventArgs.Empty);
        }
    }
}
