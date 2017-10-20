﻿using System;
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
    public partial class ctlDataGridViewEx : DataGridView
    {

        /// <summary>
        /// コンストラクタ
        /// </summary>
        //public ctlDataGridViewEx()
        //{
        //    InitializeComponent();

        //    //行の新規追加を禁止
        //    base.AllowUserToAddRows = false;
        //    //行の削除を禁止
        //    base.AllowUserToDeleteRows = false;
        //    //行ヘッダーを非表示
        //    base.RowHeadersVisible = false;

        //}

        private MyCollection _item = null;

        /// 
        /// 列ヘッダに表示するCellを設定します
        /// 
        /// 
        /// 
        /// 
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Category("列ヘッダのカスタマイズ")]
        [Description("列ヘッダに表示するCellを設定します")]
        public MyCollection HeaderCells
        {
            get { return _item; }
        }

        internal void OnCollectionChanged()
        {
            this.Invalidate();
        }

        /// 
        /// コレクションの設定
        /// 
        /// 
        public class MyCollection : System.Collections.ObjectModel.Collection<HeaderCell>
        {

            private ctlDataGridViewEx _parent;

            internal MyCollection(ctlDataGridViewEx parent)
            {
                _parent = parent;
            }

            protected override void ClearItems()
            {
                base.ClearItems();
                _parent.OnCollectionChanged();
            }

            protected override void InsertItem(int index, HeaderCell item)
            {
                base.InsertItem(index, item);
                _parent.OnCollectionChanged();
            }

            protected override void RemoveItem(int index)
            {
                base.RemoveItem(index);
                _parent.OnCollectionChanged();
            }

            protected override void SetItem(int index, HeaderCell item)
            {
                base.SetItem(index, item);
                _parent.OnCollectionChanged();
            }

        }

        private int _columnHeaderRowCount = 1;
        /// 
        /// 列ヘッダーの行数を設定します
        /// 
        /// 
        /// 
        /// 
        [Category("列ヘッダのカスタマイズ")]
        [Description("列ヘッダに表示する行を設定します")]
        public int ColumnHeaderRowCount
        {
            get { return _columnHeaderRowCount; }
            set
            {
                _columnHeaderRowCount = value;

                if (value == 0)
                {
                    _columnHeaderRowCount = 1;
                }

                base.ColumnHeadersHeight = value * ColumnHeaderRowHeight + 2;
                base.Refresh();
            }
        }

        private int _columnHeaderRowHeight = 17;
        // 
        /// 列ヘッダに表示する行の高さ
        /// 
        /// 
        /// 
        /// 
        [Category("列ヘッダのカスタマイズ")]
        [Description("列ヘッダに表示する行の高さを設定します")]
        public int ColumnHeaderRowHeight
        {
            get { return _columnHeaderRowHeight; }
            set
            {
                _columnHeaderRowHeight = value;

                base.ColumnHeadersHeight = value * ColumnHeaderRowCount + 2;
                base.Refresh();
            }
        }

        /// 
        /// 列ヘッダーの境界線の種類
        /// 
        /// 
        public enum HeaderCellBorderStyle
        {
            SingleLine = 0,
            DoubleLine = 1
        }

        private HeaderCellBorderStyle _columnHeaderBorderStyle = HeaderCellBorderStyle.SingleLine;
        /// 
        /// 列ヘッダーの線種
        /// 
        /// 
        /// 
        /// 
        [Category("列ヘッダのカスタマイズ")]
        [Description("列ヘッダに線種を設定します")]
        public HeaderCellBorderStyle ColumnHeaderBorderStyle
        {
            get { return _columnHeaderBorderStyle; }
            set
            {
                _columnHeaderBorderStyle = value;
                base.Refresh();
            }
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        public ctlDataGridViewEx():base()
        {
            //この呼び出しは、コンポーネント デザイナーで必要です。
            InitializeComponent();

            this._item = new MyCollection(this);
            base.DoubleBuffered = true;

            //行の新規追加を禁止
            base.AllowUserToAddRows = false;
            //行の削除を禁止
            base.AllowUserToDeleteRows = false;
            //行ヘッダーを非表示
            base.RowHeadersVisible = false;
            //行サイズの変更を禁止
            base.AllowUserToResizeRows = false;

        }

        /// 再描画をするとき
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            try
            {


                //---------------------------------------------------------------------------------------------------------
                //ヘッダーセルの描画
                //---------------------------------------------------------------------------------------------------------

                //ヘッダーの行の高さの取得
                int rowHeight = base.ColumnHeadersHeight;

                if (this.ColumnHeaderRowCount > 0)
                {
                    rowHeight = base.ColumnHeadersHeight / this.ColumnHeaderRowCount;
                }

                //線の太さ
                int lineWidth = 1;

                for (int i = 0; i <= ColumnCount - 1; i++)
                {

                    for (int j = 0; j <= this.ColumnHeaderRowCount - 1; j++)
                    {

                        //グッリドの線
                        Pen gridPen = new Pen(base.GridColor);

                        //背景色
                        SolidBrush backBrash = new SolidBrush(base.ColumnHeadersDefaultCellStyle.BackColor);

                        //くぼみ線
                        SolidBrush whiteBrash = new SolidBrush(Color.White);

                        try
                        {
                            //列ヘッダーの描画領域
                            Rectangle rect = base.GetCellDisplayRectangle(i, -1, true);

                            //列ヘッダーの描画領域の底部の座標を保存
                            int btm = rect.Bottom;

                            //セルの描画領域のY座標
                            switch (base.BorderStyle)
                            {
                                case BorderStyle.None:
                                    rect.Y = rowHeight * j;
                                    break;
                                case BorderStyle.FixedSingle:
                                    rect.Y = rowHeight * j + lineWidth;
                                    break;
                                case BorderStyle.Fixed3D:
                                    rect.Y = rowHeight * j + (lineWidth * 2);
                                    break;
                            }

                            //セルの描画領域のX座標
                            rect.X -= lineWidth;

                            //セルの描画領域の高さ
                            rect.Height = rowHeight;

                            //最下行の場合高さを調整
                            if (j == this.ColumnHeaderRowCount - 1)
                            {
                                rect.Height = btm - rect.Y - lineWidth;
                            }

                            //セルを囲む線の描画
                            e.Graphics.DrawRectangle(gridPen, rect);


                            //セルの背景色の領域
                            rect.Y += lineWidth;
                            rect.X += lineWidth;
                            rect.Height -= lineWidth;
                            rect.Width -= lineWidth;

                            //背景色の描画
                            if (ColumnHeaderBorderStyle != HeaderCellBorderStyle.DoubleLine)
                            {
                                //Single線の場合
                                e.Graphics.FillRectangle(backBrash, rect);
                            }
                            else
                            {
                                //くぼみ線の場合
                                //rect.Width -= lineWidth
                                e.Graphics.FillRectangle(whiteBrash, rect);
                                rect.Y += lineWidth;
                                rect.X += lineWidth;
                                rect.Height -= lineWidth;
                                rect.Width -= lineWidth;

                                e.Graphics.FillRectangle(backBrash, rect);
                            }

                            //見出しを最下列に表示
                            if (j == this.ColumnHeaderRowCount - 1)
                            {
                                string text = base.Columns[i].HeaderText;

                                if (base.SortedColumn != null && object.ReferenceEquals(base.SortedColumn, this.Columns[i]))
                                {
                                    if (base.SortOrder == SortOrder.Ascending)
                                    {
                                        text = text + " ▼";
                                    }
                                    else if (base.SortOrder == SortOrder.Descending)
                                    {
                                        text = text + " ▲";
                                    }
                                }

                                TextFormatFlags formatFlg = GetTextFormatFlags(base.ColumnHeadersDefaultCellStyle.Alignment, base.ColumnHeadersDefaultCellStyle.WrapMode);

                                TextRenderer.DrawText(e.Graphics, text, base.ColumnHeadersDefaultCellStyle.Font, rect, base.ColumnHeadersDefaultCellStyle.ForeColor, formatFlg);
                            }

                        }
                        finally
                        {
                            //リソースの解放
                            gridPen.Dispose();
                            backBrash.Dispose();
                            whiteBrash.Dispose();
                        }
                    }
                }

                //---------------------------------------------------------------------------------------------------------
                //ヘッダーのセル結合
                //---------------------------------------------------------------------------------------------------------
                //ヘッダーセル定義の処理
                for (int i = 0; i <= this.HeaderCells.Count - 1; i++)
                {

                    //セルの結合の開始行がヘッダーの行数より大きい場合は除外
                    if (HeaderCells[i].Row > this.ColumnHeaderRowCount - 1)
                    {
                        continue;
                    }

                    //セルの結合の開始列の列インデックスが列数より大きい場合は除外
                    if (HeaderCells[i].Column > base.ColumnCount - 1)
                    {
                        continue;
                    }

                    //描画領域の設定
                    Rectangle rect = Rectangle.Empty;

                    //結合する列中のソート状態
                    string sortText = string.Empty;

                    //結合するセルの各列の幅を取得し描画領域の幅を決める、ソートされている列の場合Textに表示するソート方向の設定
                    for (int j = this.HeaderCells[i].Column; j <= this.HeaderCells[i].Column + this.HeaderCells[i].ColumnSpan - 1; j++)
                    {

                        //列が画面に表示されていない場合は処理しない
                        if (base.Columns[j].Displayed == false)
                        {
                            continue;
                        }

                        //列ヘッダーの領域の幅
                        if (rect.IsEmpty)
                        {
                            //結合するセルの開始列の場合
                            rect = base.GetCellDisplayRectangle(j, -1, true);
                        }
                        else
                        {
                            //結合するセルの2列目以降の場合
                            rect.Width += base.GetCellDisplayRectangle(j, -1, true).Width;
                        }


                        //ソート列の場合
                        if (HeaderCells[i].SortVisible == true && base.SortedColumn != null && object.ReferenceEquals(base.SortedColumn, base.Columns[j]))
                        {
                            if (base.SortOrder == SortOrder.Ascending)
                            {
                                sortText = " ▼";
                            }
                            else if (base.SortOrder == SortOrder.Descending)
                            {
                                sortText = " ▲";
                            }
                        }

                    }

                    //結合するセルが画面中に無い場合
                    if (rect == null)
                    {
                        continue;
                    }

                    //結合する行がヘッダー行数より大きい場合
                    int rowSapn = this.HeaderCells[i].RowSpan;
                    if (rowSapn > ColumnHeaderRowCount)
                    {
                        rowSapn = ColumnHeaderRowCount;
                    }

                    //列ヘッダーの描画領域の底部の座標を保存
                    int btm = rect.Bottom;

                    //結合するセルの描画領域のY座標
                    switch (base.BorderStyle)
                    {
                        case BorderStyle.None:
                            rect.Y = rowHeight * (this.HeaderCells[i].Row);
                            break;
                        case BorderStyle.FixedSingle:
                            rect.Y = rowHeight * (this.HeaderCells[i].Row) + lineWidth;
                            break;
                        case BorderStyle.Fixed3D:
                            rect.Y = rowHeight * (this.HeaderCells[i].Row) + (lineWidth * 2);
                            break;
                    }

                    //結合するセルの描画領域のX座標
                    rect.X -= lineWidth;

                    //結合するセルの描画領域の高さ
                    rect.Height = rowHeight * rowSapn;

                    //最下行の場合は描画領域の高さを調整する
                    if (this.HeaderCells[i].Row + rowSapn == this.ColumnHeaderRowCount)
                    {
                        rect.Height = btm - rect.Y - lineWidth;
                    }

                    //グッリドの線
                    Pen gridPen = new Pen(base.GridColor);

                    //背景色の取得
                    System.Drawing.Color backgroundColor = base.ColumnHeadersDefaultCellStyle.BackColor;
                    //セルの背景色が設定されている場合
                    if (!(this.HeaderCells[i].BackgroundColor == Color.Empty))
                    {
                        backgroundColor = this.HeaderCells[i].BackgroundColor;
                    }

                    //背景色
                    SolidBrush backBrash = new SolidBrush(backgroundColor);

                    //くぼみ線
                    SolidBrush whiteBrash = new SolidBrush(Color.White);

                    try
                    {

                        //枠線の描画
                        e.Graphics.DrawRectangle(gridPen, rect);


                        //結合セルの背景色の描画領域の設定
                        rect.Y += lineWidth;
                        rect.X += lineWidth;
                        rect.Height -= lineWidth;
                        rect.Width -= lineWidth;


                        //背景色の描画
                        if (ColumnHeaderBorderStyle == HeaderCellBorderStyle.SingleLine)
                        {
                            //Singleの場合
                            e.Graphics.FillRectangle(backBrash, rect);
                        }
                        else
                        {
                            //くぼみ線の場合
                            e.Graphics.FillRectangle(whiteBrash, rect);
                            rect.Y += lineWidth;
                            rect.X += lineWidth;
                            rect.Height -= lineWidth;
                            rect.Width -= lineWidth;

                            e.Graphics.FillRectangle(backBrash, rect);
                        }


                        //テキストの描画
                        System.Drawing.Color foreColor = base.ColumnHeadersDefaultCellStyle.ForeColor;
                        if (!(this.HeaderCells[i].ForeColor == Color.Empty))
                        {
                            foreColor = this.HeaderCells[i].ForeColor;
                        }

                        TextFormatFlags formatFlg = GetTextFormatFlags(this.HeaderCells[i].TextAlign, this.HeaderCells[i].WrapMode);

                        TextRenderer.DrawText(e.Graphics, this.HeaderCells[i].Text + sortText, base.ColumnHeadersDefaultCellStyle.Font, rect, foreColor, formatFlg);

                    }
                    finally
                    {
                        //リソースの解放
                        gridPen.Dispose();
                        backBrash.Dispose();
                        whiteBrash.Dispose();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        /// <summary>
        /// 指定のスタイルから描写するテキストのスタイルを取得する
        /// </summary>
        /// <param name="alignment">テキストのスタイル</param>
        /// <param name="wrapMode">折り返</param>
        /// <remarks>描写するテキストのスタイル</remarks>
        private TextFormatFlags GetTextFormatFlags(DataGridViewContentAlignment alignment, DataGridViewTriState wrapMode)
        {
            try
            {
                //'文字の描画
                TextFormatFlags formatFlg = TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis;

                //表示位置
                switch (alignment)
                {
                    case DataGridViewContentAlignment.BottomCenter:
                        formatFlg = TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter | TextFormatFlags.EndEllipsis;
                        break;
                    case DataGridViewContentAlignment.BottomLeft:
                        formatFlg = TextFormatFlags.Bottom | TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
                        break;
                    case DataGridViewContentAlignment.BottomRight:
                        formatFlg = TextFormatFlags.Bottom | TextFormatFlags.Right | TextFormatFlags.EndEllipsis;
                        break;
                    case DataGridViewContentAlignment.MiddleCenter:
                        formatFlg = TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter | TextFormatFlags.EndEllipsis;
                        break;
                    case DataGridViewContentAlignment.MiddleLeft:
                        formatFlg = TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
                        break;
                    case DataGridViewContentAlignment.MiddleRight:
                        formatFlg = TextFormatFlags.VerticalCenter | TextFormatFlags.Right | TextFormatFlags.EndEllipsis;
                        break;
                    case DataGridViewContentAlignment.TopCenter:
                        formatFlg = TextFormatFlags.Top | TextFormatFlags.HorizontalCenter | TextFormatFlags.EndEllipsis;
                        break;
                    case DataGridViewContentAlignment.TopLeft:
                        formatFlg = TextFormatFlags.Top | TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
                        break;
                    case DataGridViewContentAlignment.TopRight:
                        formatFlg = TextFormatFlags.Top | TextFormatFlags.Right | TextFormatFlags.EndEllipsis;
                        break;
                }


                //折り返し
                switch (wrapMode)
                {
                    case DataGridViewTriState.False:
                        break;
                    case DataGridViewTriState.NotSet:
                        break;
                    case DataGridViewTriState.True:
                        formatFlg = formatFlg | TextFormatFlags.WordBreak;
                        break;
                }

                return formatFlg;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// セルを結合する対象の列の描画領域の無効化
        /// </summary>
        /// <remarks></remarks>
        private void InvalidateUnitColumns()
        {
            try
            {

                Rectangle hRect = base.DisplayRectangle;
                hRect.Height = base.ColumnHeadersHeight + 1;
                base.Invalidate(hRect);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// スクロールが実行されたとき
        /// </summary>
        /// <param name="e"></param>
        /// <remarks></remarks>
        protected override void OnScroll(System.Windows.Forms.ScrollEventArgs e)
        {
            base.OnScroll(e);

            try
            {
                InvalidateUnitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// サイズが変更されたとき
        /// </summary>
        /// <param name="e"></param>
        /// <remarks></remarks>
        protected override void OnSizeChanged(System.EventArgs e)
        {
            base.OnSizeChanged(e);

            try
            {
                InvalidateUnitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        /// <summary>
        /// 列の幅が変更されたとき
        /// </summary>
        /// <param name="e"></param>
        /// <remarks></remarks>
        protected override void OnColumnWidthChanged(System.Windows.Forms.DataGridViewColumnEventArgs e)
        {
            base.OnColumnWidthChanged(e);

            try
            {
                InvalidateUnitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 行の境界線がダブルクリックされた時
        /// </summary>
        /// <param name="e"></param>
        /// <remarks></remarks>
        protected override void OnRowDividerDoubleClick(System.Windows.Forms.DataGridViewRowDividerDoubleClickEventArgs e)
        {
            base.OnRowDividerDoubleClick(e);

            try
            {
                //行ヘッダーの境界線がダブルクリックされたへっだーの高さを整える
                if (e.RowIndex == -1)
                {
                    base.ColumnHeadersHeight = this.ColumnHeaderRowCount * this.ColumnHeaderRowHeight + 2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// マウスのボタンが押された時
        /// </summary>
        /// <param name="e"></param>
        /// <remarks></remarks>
        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);

            try
            {
                //列幅、行高を調整するドラグ線を見えるようにするためにダブルバッファを解除する
                base.DoubleBuffered = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// マウスのボタンが離された時
        /// </summary>
        /// <param name="e"></param>
        /// <remarks></remarks>
        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseUp(e);

            try
            {
                //OnMouseDownイベントで解除されたダブルバッファを適用する
                base.DoubleBuffered = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

    public class HeaderCell
    {
        private int _row;
        /// 
        /// 行
        /// 
        /// 
        /// 
        /// 
        [Category("セル位置")]
        [Description("行")]
        public int Row
        {
            get { return _row; }
            set { _row = value; }
        }

        private int _column;
        /// 
        /// 列
        /// 
        /// 
        /// 
        /// 
        [Category("セル位置")]
        [Description("列")]
        public int Column
        {
            get { return _column; }
            set { _column = value; }
        }

        private int _rowSpan = 1;
        /// 
        /// 結合する行数
        /// 
        /// 
        /// 
        /// 
        [Category("セル結合")]
        [Description("行数")]
        public int RowSpan
        {
            get { return _rowSpan; }
            set { _rowSpan = value; }
        }

        private int _columnSpan = 1;
        /// 
        /// 結合する列数
        /// 
        /// 
        /// 
        /// 
        [Category("セル結合")]
        [Description("列数")]
        public int ColumnSpan
        {
            get { return _columnSpan; }
            set { _columnSpan = value; }
        }

        private System.Drawing.Color _backgroundColor = Color.Empty;
        /// 
        /// セルの背景色
        /// 
        /// 
        /// 
        /// 
        [Category("表示")]
        [Description("セルの背景色")]
        public System.Drawing.Color BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; }
        }

        private System.Drawing.Color _foreColor = Color.Empty;
        /// 
        /// テキストの文字色
        /// 
        /// 
        /// 
        /// 
        [Category("表示")]
        [Description("テキストの文字色")]
        public System.Drawing.Color ForeColor
        {
            get { return _foreColor; }
            set { _foreColor = value; }
        }


        private string _text;
        /// 
        /// セルに関連付けられたテキスト
        /// 
        /// 
        /// 
        /// 
        [Category("表示")]
        [Description("セルに関連付けられたテキストです")]
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private DataGridViewContentAlignment _textAlign;
        /// 
        /// 結合されたセル内でのテキストの位置
        /// 
        /// 
        /// 
        /// 
        [Category("表示")]
        [Description("結合されたセル内のテキストの位置を決定します")]
        public DataGridViewContentAlignment TextAlign
        {
            get { return _textAlign; }
            set { _textAlign = value; }
        }

        private DataGridViewTriState _wrapMode = DataGridViewTriState.NotSet;
        /// 
        /// セルに含まれるテキスト形式の内容が 1 行に収まらないほど長い場合に、次の行に折り返されるか、
        /// 切り捨てられるかを示す値を取得または設定する
        /// 
        /// 
        /// 
        /// 
        [Category("表示")]
        [Description("セル内のテキストが一行に収まらない場合にテキストを折り返す")]
        public DataGridViewTriState WrapMode
        {
            get { return _wrapMode; }
            set { _wrapMode = value; }
        }

        private bool _sortVisible;
        /// 
        /// 結合されている列に並び替えがある場合に並び替えの方向を表示する
        /// 
        /// 
        /// 
        /// 
        [Category("表示")]
        [Description("結合されている列に並び替えがある場合に並び替えの方向を表示する")]
        public bool SortVisible
        {
            get { return _sortVisible; }
            set { _sortVisible = value; }
        }
    }

}
