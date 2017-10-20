using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sugitec.Common;
using Sugitec.Logics;
using System.Globalization;

namespace Sugitec
{
    public partial class frmInq100 : frmBase
    {
        #region"define"
        Label[] nowlabel;
        Label[] beforelabel;
        Label[] complabel;
        Label[] Updownlabel;
        Label[] DateLabel;
        DataTable Amount;
        int year = 0;
        #endregion

        #region"Event"
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmInq100()
        {
            InitializeComponent();
            InitControl();

            try
            {
                //機能コードを設定
                FeaturesCD = FEATURES.INQ010;

                numYear.Text = DateTime.Now.Year.ToString();

                //EXCEL2007以前（未インストール含む）の場合はPDF出力、印刷は使用不可
                if (clsDefine.isOutPdfOrPrint)
                {
                    btn_PDF.Enabled = true;
                    btn_Printer.Enabled = true;
                }
                else
                {
                    btn_PDF.Enabled = false;
                    btn_Printer.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

    }

        /// <summary>
        /// EXCELに出力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_output_Click(object sender, EventArgs e)
        {
            try {

                if (Amount == null)
                {
                    MessageBox.Show("年度別売上対比データがありません", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //出力確認
                string OutFolder = "";
                FileOutput Output = FileOutput.PRINTER;

                Button btn = (Button)sender;
                if (btn.Name == "btn_Excel" || btn.Name == "btn_PDF")
                {
                    Output = btn.Name == "btn_Excel" ? FileOutput.EXCEL : FileOutput.PDF;

                    //出力先を指定
                    using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                    {
                        //上部に表示する説明テキストを指定する
                        fbd.Description = "保存先のフォルダを指定してください。";
                        //ルートフォルダを指定する
                        fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
                        //ユーザーが新しいフォルダを作成できるようにする
                        fbd.ShowNewFolderButton = true;
                        //ダイアログを表示する
                        if (fbd.ShowDialog(this) != DialogResult.OK)
                        {
                            return;
                        }
                        OutFolder = fbd.SelectedPath + @"\";
                    }
                }
                else
                {
                    Output = FileOutput.PRINTER;
                    if (MessageBox.Show("年度別売上対比表を出力します。よろしいですか？", base.FeatureNM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                }

                //サービス
                using (srvInq100 srv = new srvInq100())
                {
                    srv.outputBook(Output, OutFolder, Amount, year);
                }

                MessageBox.Show("出力しました", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_end_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// データ取得ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Disp_Click(object sender, EventArgs e)
        {
            try
            {
                Amount = null;
                year = numYear.Text.ToIntlEx();
                int now = numYear.Text.ToIntlEx();
                int before = now - 1;
               
                decimal nowvalue = 0;
                decimal beforevalue = 0;
                decimal tax = 0;

                getWareki(year);

                using (srvInq100 svc = new srvInq100())
                {
                  Amount = svc.SelectSales(now, before);
                }

                for (int idx = 0; idx <= Amount.Rows.Count-1; idx++)
                {
                    nowlabel[idx].Text = String.Format("{0:#,0}", Amount.Rows[idx]["Now"]) + "円";
                    beforelabel[idx].Text = String.Format("{0:#,0}", Amount.Rows[idx]["Before"]) + "円";
                    complabel[idx].Text = String.Format("{0:#,0}", Amount.Rows[idx]["Compare"]) + "%";
                    Updownlabel[idx].Text = String.Format("{0:#,0}", Amount.Rows[idx]["Different"]);
                    nowvalue += Amount.Rows[idx]["Now"].ToDecimalEx();
                    beforevalue += Amount.Rows[idx]["Before"].ToDecimalEx();
                    tax += Amount.Rows[idx]["TAX"].ToDecimalEx();
                }
                lblnowAmount.Text =  nowvalue.ToString("#,0.###") + "円";
                lblbeforeAmount.Text =  beforevalue.ToString("#,0.###") + "円";


                lblTax.Text = tax.ToString("#,0.###") + "円"; ;
                lblTaxAmount.Text =(nowvalue + tax).ToString("#,0.###") + "円";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// クリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            for (int idx = 0; idx <= 12-1; idx++)
            {
                nowlabel[idx].Text = "0円";
                beforelabel[idx].Text = "0円"; ;
                complabel[idx].Text = "0%";
                Updownlabel[idx].Text = "0";

            }
            lblnowAmount.Text = "0円";
            lblbeforeAmount.Text = "0円";
            lblTax.Text = "0円";
            lblTaxAmount.Text = "0円";
            getWareki(DateTime.Now.Year);
            Amount = null;
            year = 0;
        }
        #endregion

        #region "Method"
        /// <summary>
        /// 各コントロールの初期設定
        /// </summary>
        private void InitControl()
        {
            try
            {
                nowlabel = (Label[])GetControlArrayByName(this, "lblnow");
                beforelabel = (Label[])GetControlArrayByName(this, "lblbefore");
                complabel = (Label[])GetControlArrayByName(this, "lblcomp");
                Updownlabel = (Label[])GetControlArrayByName(this, "lblUpdown");
                DateLabel = (Label[])GetControlArrayByName(this, "lblDate");

                for (int idx = 0; idx <= 12 - 1; idx++)
                {
                    nowlabel[idx].Text = "0円";
                    beforelabel[idx].Text = "0円"; ;
                    complabel[idx].Text = "0%";
                    Updownlabel[idx].Text = "0";

                }
                lblnowAmount.Text = "0円";
                lblbeforeAmount.Text = "0円";
                lblTax.Text = "0円";
                lblTaxAmount.Text = "0円";

                getWareki(DateTime.Now.Year);
            }
            catch
            {
                throw;
            }
        }


        /// <summary>
        /// 和暦取得
        /// </summary>
        /// <param name="year">年度</param>
        public void getWareki(int year)
        {
            try
            {
                CultureInfo culture = new CultureInfo("ja-JP", true);
                culture.DateTimeFormat.Calendar = new JapaneseCalendar();

                DateTime target = new DateTime(year, 3, 1);
                string result = target.ToString("ggyy年M月d日", culture);

                int Mon = 3;
                int idx = 0;
                while (true)
                {
                    DateLabel[idx].Text = target.ToString("ggyy年", culture) + Mon + "月";

                    Mon += 1;
                    idx += 1;

                    if (Mon == 13)
                    {
                        Mon = 1;
                        target = new DateTime(year + 1, 3, 1);
                    }

                    if (Mon == 3) { break; }
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// コントロールの配列を取得する
        /// </summary>
        /// <param name="frm">コントロールのあるフォーム</param>
        /// <param name="name">後ろの数字を除いたコントロールの名前</param>
        /// <returns>コントロールの配列。
        /// 取得できなかった時はnull(VB.NETではNothing)。</returns>
        public object GetControlArrayByName(Form frm, string name)
        {
            System.Collections.ArrayList ctrs =
                new System.Collections.ArrayList();
            object obj;
            for (int i = 1;
                (obj = FindControlByFieldName(frm, name + i.ToString())) != null;
                i++)
                ctrs.Add(obj);
            if (ctrs.Count == 0)
                return null;
            else
                return ctrs.ToArray(ctrs[0].GetType());
        }

        /// <summary>
        /// フォームに配置されているコントロールを名前で探す
        /// （フォームクラスのフィールドをフィールド名で探す）
        /// </summary>
        /// <param name="frm">コントロールを探すフォーム</param>
        /// <param name="name">コントロール（フィールド）の名前</param>
        /// <returns>見つかった時は、コントロールのオブジェクト。
        /// 見つからなかった時は、null(VB.NETではNothing)。</returns>
        public static object FindControlByFieldName(Form frm, string name)
        {
            System.Type t = frm.GetType();

            System.Reflection.FieldInfo fi = t.GetField(
                name,
                System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.DeclaredOnly);

            if (fi == null)
                return null;

            return fi.GetValue(frm);
        }
        #endregion


    }
}
