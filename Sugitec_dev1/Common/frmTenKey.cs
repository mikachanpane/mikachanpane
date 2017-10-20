using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//*********************
//2017/06/28 H.Tanaka
//
//*********************
namespace Sugitec.Common
{
    public partial class frmTenKey : Form
    {
        #region"Property"

        /// <summary>入力された数値</summary>
        public string inputNum { get; set; }

        #region"field"
        int _LENMAX = 0;
        int _CARET = 0;
        int _INT_LENMAX = 0;
        int _DECIMAL_LENMAX = 0;
        bool _CLK_buttonComma = false;
        int _COUNT_INT = 0;
        int _COUNT_DEC = 0;
        #endregion

        #endregion
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="CHK_LENMAX">文字列長の入力制限</param>
        /// <param name="CHK_HYPHEN">ハイフン入力可</param>
        /// <param name="INT_LENMAX">コンマ有り整数部の入力制限</param>
        /// <param name="DECIMAL_LENMAX">コンマ有り小数部の入力制限</param>
        public frmTenKey(int CHK_LENMAX = 0, Boolean CHK_HYPHEN = false, int INT_LENMAX = 0,int DECIMAL_LENMAX = 0)
        {
            InitializeComponent();
            _LENMAX = CHK_LENMAX;
            _INT_LENMAX = INT_LENMAX;
            _DECIMAL_LENMAX = DECIMAL_LENMAX;
            if (CHK_HYPHEN == true)//ハイフン
            {
                buttonHyphen.Enabled = true;
            }
            else
            {
                buttonHyphen.Enabled = false;
            }
            if (INT_LENMAX != 0 && DECIMAL_LENMAX != 0)//コンマ有り
            {
                buttonComma.Enabled = true;
            }
            else
            {
                buttonComma.Enabled = false;
            }
        }
        /// <summary>
        /// ボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            push("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            push("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            push("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            push("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            push("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            push("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            push("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            push("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            push("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            push("0");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            inputNum = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            _CARET = 0;
            _CLK_buttonComma = false;
            _COUNT_INT = 0;
            _COUNT_DEC = 0;
        }

        private void buttonHyphen_Click(object sender, EventArgs e)
        {
            push("-");
        }

        private void buttonBS_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && _CARET > 0)//文字列が空でない
            {                                         //かつ　カーソル位置が先頭でなければ実行
                if (textBox1.SelectionLength > 0)//選択部分がある場合
                {
                    int tempCaret = textBox1.SelectionStart;
                    String tempText = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
                    textBox1.Text = tempText;
                    _CARET = tempCaret;
                }
                else
                {
                    String tempText = textBox1.Text.Remove(_CARET - 1, 1);
                    textBox1.Text = tempText;
                    _CARET--;
                }
                bool chk = set_count();
                if (chk == false 
                    && (_INT_LENMAX != 0 && _DECIMAL_LENMAX != 0)
                    && (_INT_LENMAX < textBox1.Text.Length))
                {
                    textBox1.Text = "";
                    _CARET = 0;
                    _CLK_buttonComma = false;
                    _COUNT_INT = 0;
                    _COUNT_DEC = 0;
                }
            }      
        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && _CARET < textBox1.TextLength)   //文字列が空でない
            {                                                               //　かつ　カーソル位置が文末でなければ実行
                if (textBox1.SelectionLength > 0)//選択部分がある場合
                {
                    int tempCaret = textBox1.SelectionStart;
                    String tempText = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
                    textBox1.Text = tempText;
                    _CARET = tempCaret;
                }
                else if(_CARET >_COUNT_INT)//カーソル位置がコンマより後ろ
                    {
                    String tempText = textBox1.Text.Remove(_CARET - 1, 1);
                    textBox1.Text = tempText;
                }
                else
                {
                    String tempText = textBox1.Text.Remove(_CARET, 1);
                    textBox1.Text = tempText;
                }
                bool chk = set_count();
                if (chk == false
                    && (_INT_LENMAX != 0 && _DECIMAL_LENMAX != 0)
                    && (_INT_LENMAX < textBox1.Text.Length))
                {
                    textBox1.Text = "";
                    _CARET = 0;
                    _CLK_buttonComma = false;
                    _COUNT_INT = 0;
                    _COUNT_DEC = 0;
                }
            }
        }

        private void textBox1_MouseDown(object sender, EventArgs e)
        {
            _CARET = textBox1.SelectionStart;
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (_CLK_buttonComma == false && _INT_LENMAX >= textBox1.TextLength && textBox1.TextLength > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, _CARET)
                    + "."
                    + textBox1.Text.Substring(_CARET + textBox1.SelectionLength);
                _CARET++;
                _CLK_buttonComma = true;
            }
        }
        private bool set_count()
        {
            _COUNT_INT = 0;
            _COUNT_DEC = 0;
            bool chk_comma= false;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                string s = textBox1.Text.Substring(i, 1);
                if (s == ".")
                {
                    chk_comma = true;
                }
                    if ((_INT_LENMAX != 0 && _DECIMAL_LENMAX != 0)
                    && (_INT_LENMAX > _COUNT_INT) 
                    && ((s != ".") && chk_comma == false))
                {
                    _COUNT_INT++;
                }
                if ((_INT_LENMAX != 0 && _DECIMAL_LENMAX != 0)
                    && (_DECIMAL_LENMAX > _COUNT_DEC)
                    && ((s != ".") && chk_comma == true))
                {
                    _COUNT_DEC++;
                }
            }
            return chk_comma;
        }
        private void push(string s)//BS/Delete/クリアボタン以外のボタンの処理
        {
            if (
                ((_LENMAX == 0 || _LENMAX > textBox1.TextLength) && _INT_LENMAX == 0)
                || ((_INT_LENMAX > _COUNT_INT)
                    && (_CARET < _INT_LENMAX)
                    && (_COUNT_DEC == 0)
                    && (_CLK_buttonComma == false))
                || ((_INT_LENMAX > _COUNT_INT)
                    && (_CARET < _INT_LENMAX)
                    && (_DECIMAL_LENMAX >= _COUNT_DEC)
                    && (_CLK_buttonComma == true))
                || ((_INT_LENMAX >= _COUNT_INT) && _DECIMAL_LENMAX > _COUNT_DEC && _CLK_buttonComma == true))
            {
                textBox1.Text = textBox1.Text.Substring(0, _CARET)
                    + s
                    + textBox1.Text.Substring(_CARET + textBox1.SelectionLength);
                _CARET++;
                if (((_INT_LENMAX > _COUNT_INT)
                    && (_CARET < _INT_LENMAX)
                    && (_COUNT_DEC == 0)
                    && (_CLK_buttonComma == false))
                || ((_INT_LENMAX > _COUNT_INT)
                    && (_CARET < _INT_LENMAX)
                    && (_DECIMAL_LENMAX >= _COUNT_DEC)
                    && (_CLK_buttonComma == true)))
                {
                    _COUNT_INT++;
                }
                if ((_INT_LENMAX >= _COUNT_INT) && _DECIMAL_LENMAX > _COUNT_DEC && _CLK_buttonComma == true)
                {
                    _COUNT_DEC++;
                }
            }
        }
    }
}
