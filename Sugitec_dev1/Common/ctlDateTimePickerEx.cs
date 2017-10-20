using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sugitec.Common
{
    public partial class ctlDateTimePickerEx : DateTimePicker
    {

        #region "フィールド"
        /// <summary>
        ///未入力状態かのフラグ
        /// </summary>
        private bool isNull;

        /// <summary>
        ///フォーム内でフォーカスが遷移したかのフラグ
        /// </summary>
        /// <remarks>OnValidatingで設定されます</remarks>
        #endregion
        private bool isInFormLeave = true;

        #region "プロパティ変数"
        /// <summary>
        ///入力時のValue
        /// </summary>
        /// <remarks>OnEnter時の値を保持しています</remarks>
        private System.DateTime? _OnEnterValue = null;
        public System.DateTime? OnEnterValue
        {
            get { return _OnEnterValue; }
        }

        /// <summary>
        ///背景色
        /// </summary>
        [Browsable(true)]
        [EditorBrowsable()]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        /// <summary>
        ///DateTimePickerFormat
        /// </summary>
        private DateTimePickerFormat _format = DateTimePickerFormat.Long;
        /// <summary>
        ///CustomFormat文字列
        /// </summary>
        private string _formatAsString = string.Empty;
        /// <summary>
        ///CustomFormat文字列
        /// </summary>
        private string FormatAsString
        {
            get { return _formatAsString; }
            set
            {
                _formatAsString = value;
                base.CustomFormat = value;
            }
        }

        /// <summary>
        ///CustomFormat
        /// </summary>
        public new string CustomFormat { get; set; }

        /// <summary>
        ///未入力時の表示文字列
        /// </summary>
        [Browsable(true)]
        [Category("Behavior")]
        [Description("未入力時の表示文字列")]
        [DefaultValue(" ")]
        public string NullValue { get; set; }

        /// <summary>
        ///必須入力とするか
        /// </summary>
        [Browsable(true)]
        [Category("Behavior")]
        [Description("必須入力とするか")]
        [DefaultValue(true)]
        public bool MustInput { get; set; }

        #endregion
        #region "パブリックプロパティ"

        /// <summary>
        /// コントロールに割り当てられた日付/時刻値を取得または設定します
        /// </summary>
        public new DateTime? Value
        {
            get
            {
                if (isNull)
                {
                    return null;
                }
                else
                {
                    return base.Value;
                }
            }
            set
            {
                if (value == null)
                {
                    SetToNullValue();
                    base.Value = DateTime.Now;
                }
                else
                {
                    SetToDateTimeValue();
                    base.Value = Convert.ToDateTime(value);
                }
            }
        }



        /// <summary>
        /// コントロールに表示される日付と時刻の書式を取得または設定します
        /// </summary>
        [Browsable(true)]
        [DefaultValue(DateTimePickerFormat.Long), TypeConverter(typeof(Enum))]
        public new DateTimePickerFormat Format
        {
            get { return _format; }
            set
            {
                _format = value;
                SetFormat();
                OnFormatChanged(EventArgs.Empty);
            }
        }




        private readonly int WM_PAINT = 0xf;
    private System.Windows.Forms.Timer withEventsField_Timer1 = new System.Windows.Forms.Timer();
    private System.Windows.Forms.Timer Timer1
    {
        get { return withEventsField_Timer1; }
        set
        {
            if (withEventsField_Timer1 != null)
            {
                withEventsField_Timer1.Tick -= Timer1_Tick;
            }
            withEventsField_Timer1 = value;
            if (withEventsField_Timer1 != null)
            {
                withEventsField_Timer1.Tick += Timer1_Tick;
            }
        }
    }

    public ctlDateTimePickerEx():base()
    {
            // this.Timer1.Interval = 100;
            // ← 適宜修正してください
            //this.Timer1.Start()
            base.Format = DateTimePickerFormat.Custom;
            NullValue = " ";
            MustInput = true;
            Format = DateTimePickerFormat.Long;
        }

    protected override void WndProc(ref System.Windows.Forms.Message m)
    {
        // ↓先に、既定の描画処理をさせる
        base.WndProc(ref m);
        if (m.Msg == this.WM_PAINT)
        {
            this.Redraw();
        }
    }

    public Bitmap GetControlImage()
    {
        // 自分自身の画像をBitmapにコピー
        Bitmap bmp = new Bitmap(this.Width, this.Height);
        this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
        // Bitmapの背景色をMe.BackColorに変更する
        using (Graphics g = Graphics.FromImage(bmp))
        {
            System.Drawing.Imaging.ColorMap[] cm = { new System.Drawing.Imaging.ColorMap() };
            cm[0].OldColor = SystemColors.Window;
            cm[0].NewColor = this.BackColor;
            System.Drawing.Imaging.ImageAttributes ia = new System.Drawing.Imaging.ImageAttributes();
            ia.SetRemapTable(cm);
            Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
            g.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, ia);
        }

        return bmp;
    }

        /// <summary>
        /// 現在のDateTimePickerFormatの応じて書式を設定します
        /// </summary>
        private void SetFormat()
        {
            CultureInfo ci = Thread.CurrentThread.CurrentCulture;
            DateTimeFormatInfo dtf = ci.DateTimeFormat;
            switch (_format)
            {
                case DateTimePickerFormat.Long:
                    FormatAsString = dtf.LongDatePattern;
                    break; 

                case DateTimePickerFormat.Short:
                    FormatAsString = dtf.ShortDatePattern;
                    break; 

                case DateTimePickerFormat.Time:
                    FormatAsString = dtf.ShortTimePattern;
                    break; 

                case DateTimePickerFormat.Custom:
                    FormatAsString = this.CustomFormat;
                    break; 

            }
        }

        /// <summary>
        /// 未入力状態に設定します
        /// </summary>
        private void SetToNullValue()
        {
            isNull = true;
            base.CustomFormat = (NullValue == null || NullValue == string.Empty) ? " " : "'" + NullValue + "'";
        }

        /// <summary>
        /// 未入力状態から値保持状態へ変更する
        /// </summary>
        private void SetToDateTimeValue()
        {
            if (isNull)
            {
                SetFormat();
                isNull = false;
                base.OnValueChanged(new EventArgs());
            }
        }
        #endregion


        private void Timer1_Tick(object sender, System.EventArgs e)
    {
        // ↓をコメントアウトしても、背景色が変更されますか？（Yesなら、タイマー不要）
        //this.Redraw();
    }

    private void Redraw()
    {
        // Bitmapを自分の上に描画する
        Size bsz = SystemInformation.Border3DSize;
        using (Graphics g = this.CreateGraphics())
        {
            using (Bitmap bmp = this.GetControlImage())
            {
                g.DrawImage(bmp, -bsz.Width +2, -bsz.Height +2);
            }
        }
    }



        /// <summary>
        /// OnLeaveイベント
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLeave(EventArgs e)
        {
            //一桁入力対応（DateTimePickerで1桁入力しTabキーで移動すると入力値が取得できない<.NET Frameworkのバグ>）
            //最小化時に下記対応をするとアクティブが変わらずイベントが狂ってしまうので最小化時はコントロールの再設定を行わない
            //最小家時に変更検知が走りValidatingでキャンセルを行うと、フォーカスの移り先のフォームのイベントが正常に行われないが、コントロールのバグの為妥協する
            if (this.FindForm().MdiParent == null)
            {
                //MDIフォームでない場合（ダイアログ）
                this.FindForm().ActiveControl = this.FindForm().ActiveControl;
            }
            else
            {
                //MDIフォームの場合
                if (object.ReferenceEquals(this.FindForm().MdiParent.ActiveMdiChild, this.FindForm()) && this.FindForm().WindowState != FormWindowState.Minimized)
                {
                    this.FindForm().ActiveControl = this.FindForm().ActiveControl;
                }
            }

            base.OnLeave(e);
            //   this.BackColor = ConstsDefine.NormalColor;
        }

        /// <summary>
        /// OnEnterイベント
        /// </summary>
        /// <param name="e"></param>
        protected override void OnEnter(EventArgs e)
        {
            if (isInFormLeave)
                _OnEnterValue = this.Value;
            base.OnEnter(e);
            // this.BackColor = ConstsDefine.FocusColor;
        }

        /// <summary>
        /// OnValidatingイベント
        /// </summary>
        /// <param name="e"></param>
        /// <remarks></remarks>
        protected override void OnValidating(CancelEventArgs e)
        {
            //OnValidating内はOnEnterIndexValueの値を変更しない
            isInFormLeave = false;
            base.OnValidating(e);
            isInFormLeave = true;

            //キャンセル時は自フォームをアクティブにする
            if (e.Cancel)
            {
                this.FindForm().Activate();
                this.Focus();
            }
        }

        /// <summary>
        /// OnCloseUpイベント
        /// </summary>
        /// <param name="eventargs"></param>
        protected override void OnCloseUp(EventArgs eventargs)
        {
            //日付が選択された場合、未入力状態から値保持状態へ変更する
            if (Control.MouseButtons == MouseButtons.None)
            {
                if (isNull)
                {
                    SetToDateTimeValue();
                    isNull = false;
                }
            }
            base.OnCloseUp(eventargs);
        }

        /// <summary>
        /// OnKeyUpイベント
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyUp(KeyEventArgs e)
        {
            //任意入力の場合
            if (MustInput == false)
            {
                if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                {
                    this.Value = null;
                    OnValueChanged(KeyEventArgs.Empty);
                }
            }
            base.OnKeyUp(e);
        }

        /// <summary>
        /// OnKeyPressイベント
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //ブランク状態で数値が押下された場合
            if (isNull && ('0' < e.KeyChar && e.KeyChar < '9'))
            {
                isNull = false;
                SetFormat();
                //年度入力状態にさせる
                SendKeys.SendWait("{Right}");
            }
            base.OnKeyPress(e);
        }




    }
}
