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
    public partial class frmYm : Form
    {

        #region"Property"

        /// <summary>選択した年月</summary>
        public string retYm { get; set; }

        #endregion

        #region"field"
        string _Year = "";
        string _Mon = "";
        Button[] Mbtn = new Button[12];
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="YM">年月</param>
        public frmYm(string YM="")
        {
            InitializeComponent();

            if (YM.Length <= 4)
            {
                _Year = DateTime.Today.Year.ToString().PadLeft(4, '0');
                _Mon = DateTime.Today.Month.ToString().PadLeft(2,'0');
                return;
            }
            else if (YM.IndexOf(" ") > -1 && YM.IndexOf(" ") <= 3)
            {
                _Year = DateTime.Today.Year.ToString().PadLeft(4, '0');
                _Mon = DateTime.Today.Month.ToString().PadLeft(2, '0');
                return;
            }

            string sYm = string.Empty;
            if (YM.Length == 5)
            {
                sYm = YM.LeftEx(4) + "/0" + YM.RightEx(1);
            }
            else
            {
                sYm = YM.LeftEx(4) + "/" + YM.RightEx(2).Replace(" ", "0");
            }

            DateTime dt = new DateTime();
            if (DateTime.TryParse(sYm + "/01", out dt))
            {
                _Year = dt.Year.ToString().PadLeft(4, '0'); 
                _Mon = dt.Month.ToString().PadLeft(2, '0');
            }
            else
            {
                _Year = DateTime.Today.Year.ToString().PadLeft(4, '0');
                _Mon = DateTime.Today.Month.ToString().PadLeft(2, '0');
            }
        }

        /// <summary>
        /// 初期処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmYm_Load(object sender, EventArgs e)
        {

            lbl_year.Text = _Year;

            ColorChenge();

            Mbtn[0] = btn_Jan;
            Mbtn[1] = btn_Feb;
            Mbtn[2] = btn_Mar;
            Mbtn[3] = btn_Apr;
            Mbtn[4] = btn_May;
            Mbtn[5] = btn_jun;
            Mbtn[6] = btn_jul;
            Mbtn[7] = btn_Aug;
            Mbtn[8] = btn_Sep;
            Mbtn[9] = btn_Oct;
            Mbtn[10] = btn_Nov;
            Mbtn[11] = btn_Dec;

            for (int idx = 0; idx < Mbtn.Length; idx++)
            {
                Mbtn[idx].Tag = idx + 1;
                Mbtn[idx].Click += new EventHandler(this.MonButtons_Click);
            }
        }

        /// <summary>
        /// 月ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MonButtons_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string MValue = btn.Tag.ToString();
            string YValue = lbl_year.Text.PadLeft(4, '0'); 

            if (MValue.Length == 1)
            {
                MValue = "0" + MValue;
            }

            retYm = YValue + MValue;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    
        /// <summary>
        /// 前年取得
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_prev_Click(object sender, EventArgs e)
        {
            
            if((Convert.ToInt32(lbl_year.Text) - 1) > 0)
            {
                lbl_year.Text = (Convert.ToInt32(lbl_year.Text) - 1).ToString();
                ColorChenge();
            }
        }

        /// <summary>
        /// 翌年取得
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nxt_Click(object sender, EventArgs e)
        {
            lbl_year.Text = (Convert.ToInt32(lbl_year.Text) + 1).ToString();
            ColorChenge();
        }

        /// <summary>
        /// 月ボタンの背景色変更
        /// </summary>
        private void ColorChenge()
        {

            btn_Jan.BackColor = SystemColors.Control;
            btn_Feb.BackColor = SystemColors.Control;
            btn_Mar.BackColor = SystemColors.Control;
            btn_Apr.BackColor = SystemColors.Control;
            btn_May.BackColor = SystemColors.Control;
            btn_jun.BackColor = SystemColors.Control;
            btn_jul.BackColor = SystemColors.Control;
            btn_Aug.BackColor = SystemColors.Control;
            btn_Sep.BackColor = SystemColors.Control;
            btn_Oct.BackColor = SystemColors.Control;
            btn_Nov.BackColor = SystemColors.Control;
            btn_Dec.BackColor = SystemColors.Control;

            if (lbl_year.Text == _Year)
            {
                switch (_Mon)
                {
                    case "01":
                        btn_Jan.BackColor = Color.Pink;
                        break;

                    case "02":
                        btn_Feb.BackColor = Color.Pink;
                        break;

                    case "03":
                        btn_Mar.BackColor = Color.Pink;
                        break;

                    case "04":
                        btn_Apr.BackColor = Color.Pink;
                        break;

                    case "05":
                        btn_May.BackColor = Color.Pink;
                        break;

                    case "06":
                        btn_jun.BackColor = Color.Pink;
                        break;

                    case "07":
                        btn_jul.BackColor = Color.Pink;
                        break;

                    case "08":
                        btn_Aug.BackColor = Color.Pink;
                        break;

                    case "09":
                        btn_Sep.BackColor = Color.Pink;
                        break;

                    case "10":
                        btn_Oct.BackColor = Color.Pink;
                        break;

                    case "11":
                        btn_Nov.BackColor = Color.Pink;

                        break;
                    case "12":
                        btn_Dec.BackColor = Color.Pink;
                        break;
                }
            }
        }
    }
}
