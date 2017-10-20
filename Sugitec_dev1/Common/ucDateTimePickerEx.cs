using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Imaging;

namespace Sugitec.Common
{
    public class ucDateTimePickerEx : DateTimePicker
    {

        /// <summary>NULL値の表示用フォーマット</summary>
        private string NULL_FORMAT = " ";

        /// <summary>表示用フォーマット</summary>
        private string _customFormat;

        /// <summary>Windowsメッセージ（描画）</summary>
        private readonly int WM_PAINT = 0xf;

        #region "イベント"

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ucDateTimePickerEx()
        {
            ///_customFormat = base.CustomFormat;
			this._customFormat = this.CustomFormat;
            IsNull = true;
            this.Format = DateTimePickerFormat.Custom;
            //this.Format = base.Format;
            this.Value = null;
        }

        /// <summary>
        /// キーが押された時、KeyDownイベントの前
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {

            switch (e.KeyCode)
            {
                case System.Windows.Forms.Keys.Delete:
                    //DELETEで入力値のクリア
                    this.Value = null;
                    IsNull = true;
                    break;
                case Keys.Up:
                case Keys.Down:
                case Keys.D0:
                case Keys.D1:
                case Keys.D2:
                case Keys.D3:
                case Keys.D4:
                case Keys.D5:
                case Keys.D6:
                case Keys.D7:
                case Keys.D8:
                case Keys.D9:
                case Keys.NumPad0:
                case Keys.NumPad1:
                case Keys.NumPad2:
                case Keys.NumPad3:
                case Keys.NumPad4:
                case Keys.NumPad5:
                case Keys.NumPad6:
                case Keys.NumPad7:
                case Keys.NumPad8:
                case Keys.NumPad9:
                    //0～9、上下矢印キーの入力で日付入力状態
                    if (IsNull)
                    {
                        base.CustomFormat = _customFormat;
                        IsNull = false;
                    }
                    break;
                default:
                    break;
            }

            base.OnPreviewKeyDown(e);

        }

        /// <summary>
        /// ドロップダウンカレンダーから日付を選択した時
        /// </summary>
        /// <param name="e"></param>
        protected override void OnCloseUp(EventArgs e)
        {
            //ダイアログを閉じると、値が設定されてしまうので、
            //その値が表示されるよう、退避していたフォーマットを
            //セットし、値が表示されるようにする
            base.CustomFormat = _customFormat;
            IsNull = false;
            base.OnCloseUp(e);

        }

        /// <summary>
        /// Windowsからメッセージが送られた時
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            // ↓先に、既定の描画処理をさせる
            base.WndProc(ref m);
            if (m.Msg == this.WM_PAINT)
            {
                this.Redraw();
            }
        }


        #endregion

        #region "プロパティ"

        /// <summary>
        /// コントロールに設定されている値はNULL値か?
        /// </summary>
        public bool IsNull { get; private set; }

        /// <summary>
        /// 表示用フォーマット
        /// </summary>
        public new string CustomFormat
        {
            get { return _customFormat; }

            set
            {
                //フォーマットを退避して保持
                _customFormat = value;
                //親にフォーマットを設定
                base.CustomFormat = value;
				//フォーマットに何らかの文字が入っていればnull状態にはならないはず
				//if (!string.IsNullOrEmpty(value.Trim()))
				if (!string.IsNullOrEmpty(value))
				{
				    IsNull = false;
				}
			}
		}

        /// <summary>
        ///背景色
        /// </summary>
        [Browsable(true)]
        [Category("表示")]
        [Description("コントロール背景色を取得または設定します")]
        [EditorBrowsable()]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        /// <summary>
        /// 値
        /// </summary>
        [Browsable(true)]
        [Category("表示")]
        [Description("コントロールに割り当てられた日付/時刻値を取得または設定します")]
        [EditorBrowsable()]
        public new Nullable<DateTime> Value
        {
            get
            {
                if (IsNull)
                {
                    return null;
                }

                return base.Value;
            }

            set
            {
                if (value == null)
                {
                    //thiaで設定すると退避していた値を壊してしまうのでbaseで設定
                    base.CustomFormat = NULL_FORMAT;
                    IsNull = true;
                }
                else
                {
                    base.Value = (DateTime)value;
                    this.CustomFormat = _customFormat;
					if (!string.IsNullOrEmpty(this.CustomFormat))
					{
						IsNull = false;
					}
					{ IsNull = true; }
                }
            }
        }

        /// <summary>
        /// テキスト
        /// </summary>
        [Browsable(false)]
        [Category("表示")]
        [Description("コントロールに関連付けされているテキストを取得または設定します")]
        public override string Text
        {
            get
            {
                if (IsNull)
                {
                    return "";
                }

                return base.Text;

            }

            set
            {
                try
                {
                    base.Text = value;
                    if (String.IsNullOrEmpty(value.Trim()))
                    {
                        //thisで設定すると退避していた値を壊してしまうのでbaseで設定
                        base.CustomFormat = NULL_FORMAT;
                        IsNull = true;
                    }
                    else
                    {
                        this.CustomFormat = _customFormat;
                        IsNull = false;

                    }
                }
                catch (Exception)
                {
                    //例外(System.FormatExceptionなど)が発生した場合はNULL値扱い
                    base.Text = "";
                    //thisで設定すると退避していた値を壊してしまうのでbaseで設定
                    base.CustomFormat = NULL_FORMAT;
                    IsNull = true;
                }
            }

        }


        #endregion

        #region "メソッド"

        /// <summary>
        /// 再描画（バックカラ―変更用）
        /// </summary>
        private void Redraw()
        {
            // Bitmapを自分の上に描画する
            Size bsz = SystemInformation.Border3DSize;
            using (Graphics g = this.CreateGraphics())
            {
                using (Bitmap bmp = this.GetControlImage())
                {
                    g.DrawImage(bmp, -bsz.Width + 2, -bsz.Height + 2);
                }
            }
        }

        /// <summary>
        /// イメージ（バックカラ―変更用）
        /// </summary>
        /// <returns></returns>
        private Bitmap GetControlImage()
        {
            // 自分自身の画像をBitmapにコピー
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            // Bitmapの背景色をMe.BackColorに変更する
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMap[] cm = { new ColorMap() };
                cm[0].OldColor = SystemColors.Window;
                cm[0].NewColor = this.BackColor;
                ImageAttributes ia = new ImageAttributes();
                ia.SetRemapTable(cm);
                Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
                g.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, ia);
            }

            return bmp;
        }

        #endregion

    }
}
