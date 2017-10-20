using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sugitec.Common;
using Sugitec.Logics;
using System.Data;
using System.IO;
using ClosedXML.Excel;

namespace Sugitec.Logics
{
   public class srvInq100 : srvBase
    {
        /// <summary>
        /// 売上取得
        /// </summary>
        /// <param name="nowyear">今年度</param>
        /// <param name="beforyear">前年度</param>
        /// <returns></returns>
        public DataTable SelectSales(int nowyear,int beforeyear)
        {
            //本体
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            decimal nowamount=0;
            decimal beforeamount = 0;
            decimal Taxamount = 0;
            decimal compare = 0;
            decimal Diff = 0;
            DataTable retDt = new DataTable();
            DataTable dt = new DataTable();
            DataRow dr;
            string getYM="";

            try
            {
                retDt.Columns.Add("Now", typeof(Decimal));
                retDt.Columns.Add("Tax", typeof(Decimal));
                retDt.Columns.Add("Before", typeof(Decimal));
                retDt.Columns.Add("Compare", typeof(Decimal));
                retDt.Columns.Add("Different", typeof(Decimal));                
        
                int Mon = 3;
                while (true)
                {
                 
                    getYM = nowyear.ToString()+Mon.ToString().PadLeft(2,'0');

                    sb.Append("         Select SUM(SALES_AMOUNT) AS SALES ,SUM(TAX_AMOUNT) AS TAX  FROM T_SALES");
                    sb.AppendFormat("   WHERE SALES_YM = '{0}'",getYM);

                    dt= base.ExecuteSelect(sb.ToString());
                    sb.Length = 0;

                    nowamount = dt.Rows[0]["SALES"].ToDecimalEx();
                    Taxamount = dt.Rows[0]["TAX"].ToDecimalEx();

                    getYM = beforeyear.ToString() + Mon.ToString().PadLeft(2, '0');
                                    
                    sb.Append("         Select SUM(SALES_AMOUNT) AS SALES  FROM T_SALES");
                    sb.AppendFormat("   WHERE SALES_YM = '{0}'", getYM);

                    dt = base.ExecuteSelect(sb.ToString());
                    sb.Length = 0;
                    beforeamount = dt.Rows[0]["SALES"].ToDecimalEx();

                    if (beforeamount == 0)
                    {
                        compare = 0;
                    }
                    else
                    {
                        compare = (nowamount / beforeamount) * 100;
                    }

                    Diff = decimal.Subtract(nowamount, beforeamount);

                    dr = retDt.NewRow();
                    dr["Now"] = nowamount;
                    dr["Tax"] = Taxamount;
                    dr["Before"] = beforeamount;
                    dr["Compare"] = compare;
                    dr["Different"] = Diff;

                    retDt.Rows.Add(dr);


                    Mon += 1;
                    if (Mon == 13) { Mon = 1;
                        nowyear += 1;
                        beforeyear += 1;
                    }

                    if (Mon == 3) { break; }
                }




                return retDt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        /// <summary>
        /// Excel出力処理
        /// </summary>
        /// <param name="fot">出力対象</param>
        /// <param name="outFolder">出力先フォルダ</param>
        /// <param name="dt">集計されたデータテーブル</param>
        /// <param name="year">年度</param>
        public void outputBook(FileOutput fot,string outFolder, DataTable dt,int year)
        {
            try
            {
                decimal nowvalue = 0;
                decimal beforevalue = 0;
                decimal tax = 0;

                //テンプレートファイル
                string tmpbook = clsDefine.Year_Path() + "年度別売上対比表.xlsx";
                //保存ファイル名
                string filepath = (fot == FileOutput.EXCEL ? outFolder : Path.GetTempPath()) + string.Format("{0}年度売上対比表.xlsx",year);

                using (ClosedXML.Excel.XLWorkbook workbook = new ClosedXML.Excel.XLWorkbook(tmpbook, ClosedXML.Excel.XLEventTracking.Disabled))
                {
                    int rowcnt = 0;
                    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("ja-JP", true);
                    culture.DateTimeFormat.Calendar = new System.Globalization.JapaneseCalendar();

                    DateTime target = new DateTime(year, 3, 1);
                    string result = target.ToString("ggyy年M月d日", culture);
                    //シート番号を指定してシートを取得
                    ClosedXML.Excel.IXLWorksheet sheet = workbook.Worksheet(1);
                    int Mon = 3;
                    int idx = 0;
                    while (true)
                    {
                        sheet.Cell("A" + (4 + idx)).SetValue(target.ToString("ggyy年", culture) + Mon + "月").ToString();

                        Mon += 1;
                        idx += 1;

                        if (Mon == 13)
                        {
                            Mon = 1;
                            target = new DateTime(year + 1, 3, 1);
                        }

                        if (Mon == 3) { break; }
                    }


                    //シート名を指定してシートを取得
                    sheet = workbook.Worksheet("Data");
                    foreach (DataRow dr in dt.Rows)
                    {
                        sheet.Cell("B" + (2 + rowcnt)).Value = dr["Now"].ToDecimalEx();
                        sheet.Cell("B" + (14 + rowcnt)).Value = dr["Before"].ToDecimalEx();
                        sheet.Cell("B" + (26 + rowcnt)).Value = (dr["Compare"].ToDecimalEx()) / 100;
                        sheet.Cell("B" + (38 + rowcnt)).Value = dr["Different"].ToDecimalEx();


                        nowvalue += dr["Now"].ToDecimalEx();
                        beforevalue += dr["Before"].ToDecimalEx();
                        tax += dr["TAX"].ToDecimalEx();
                        rowcnt += 1;
                    }
                    sheet.Cell("B50").Value = nowvalue;
                    sheet.Cell("B51").Value = beforevalue;



                    sheet.Cell("B52").Value = tax;
                    sheet.Cell("B53").Value = nowvalue + tax;

                    workbook.SaveAs(filepath);
                }

                //作成したExcelBookのPDF出力または印刷を行う
                if (fot != FileOutput.EXCEL)
                {
                    //シート番号を指定してExcelをオープン
                    using (clsExceltoPDF xlMng = new clsExceltoPDF(filepath,1))
                    {

                        //一旦、保存する
                        xlMng.BookSave();

                        //PDF出力、又は印刷を行う
                        if (fot == FileOutput.PDF)
                        {
                            string PdfFile = outFolder + string.Format("{0}年度売上対比表.pdf", year);
                            //シートをPDF出力
                            xlMng.SheetSaveAsPdf(PdfFile);
                        }
                        else
                        {
                            //シートを印刷
                            xlMng.SheetPrint();
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                File.Delete(Path.GetTempPath() + string.Format("{0}年度売上対比表.xlsx", year));
            }

        }

    }
}
