using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sugitec.Common;
using System.Data;
using System.IO;
using Sugitec.Logics;

namespace Sugitec.Logics
{
    public class srvOth010 : srvBase
    {
        #region”　Method for SQL　”
        public DataTable SelectEng()
        {
            //本体
            System.Text.StringBuilder Sql = new System.Text.StringBuilder();
            //条件
            try
            {
                Sql.Append("Select 0 AS SEL0, ID,NAME,POST,ADDRESS1,ADDRESS2 FROM M_ENGINEER ");
                Sql.Append(" WHERE DEL_FLG = 0 ");
                Sql.Append("AND BELONGS_KBN = '01'");

                return base.ExecuteSelect(Sql.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectCode(String KBN)
        {
            //本体
            System.Text.StringBuilder Sql = new System.Text.StringBuilder();
            //条件
            try
            {
                Sql.AppendFormat("SELECT 0 as SEL0, CONTENT, 0 as NOC");
                // FROM
                Sql.Append(" FROM M_CODE");
                // WHERE
                Sql.Append(" WHERE DEL_FLG = 0");
                // AND
                Sql.Append(" AND CODE <> '00'");
                // AND
                Sql.Append(" AND KBN = '");
                Sql.Append(KBN);
                Sql.Append("'");

                return base.ExecuteSelect(Sql.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectCustomer()
        {
            //本体
            System.Text.StringBuilder Sql = new System.Text.StringBuilder();
            //条件
            try
            {
                Sql.AppendFormat("SELECT CODE, NAME");
                // FROM
                Sql.Append(" FROM M_CUSTOMER");
                // WHERE
                Sql.Append(" WHERE DEL_FLG = 0");
                return base.ExecuteSelect(Sql.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectContactM(string CustomerCd)
        {
            //本体
            System.Text.StringBuilder Sql = new System.Text.StringBuilder();
            //条件
            try
            {
                Sql.AppendFormat("SELECT CONTACT_CODE, CONTACT_NAME");
                // FROM
                Sql.Append(" FROM M_CONTACT");
                // WHERE
                Sql.Append(" WHERE DEL_FLG = 0");
                // AND
                Sql.Append(" AND CUSTOMER_CODE = '");
                Sql.Append(CustomerCd);
                Sql.Append("'");
                return base.ExecuteSelect(Sql.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectOutside(string CustomerCd, string ContactCd)
        {
            //本体
            System.Text.StringBuilder Sql = new System.Text.StringBuilder();
            //条件
            try
            {
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    Sql.AppendFormat("SELECT A.NAME, A.POST, A.ADDRESS1, A.ADDRESS2, B.SECTION, B.CONTACT_NAME");
                }
                else
                {
                    Sql.AppendFormat("SELECT A.NAME, A.POST, A.ADDRESS1, A.ADDRESS2, [B.SECTION], B.CONTACT_NAME");
                }   
                // FROM
                Sql.Append(" FROM M_CUSTOMER AS A");
                Sql.Append(" INNER JOIN M_CONTACT AS B");
                // ON
                Sql.Append(" ON (A.CODE = B.CUSTOMER_CODE");
                // AND
                Sql.Append(" AND B.CONTACT_CODE = '");
                Sql.Append(ContactCd);
                Sql.Append("')");

                // WHERE
                Sql.Append(" WHERE (A.DEL_FLG = 0");
                // AND
                Sql.Append(" AND A.CODE = '");
                Sql.Append(CustomerCd);
                Sql.Append("')");
                return base.ExecuteSelect(Sql.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        /// <summary>
        /// 社外用送り状を出力
        /// </summary>
        /// <param name="fot">出力対象</param>
        /// <param name="outFolder">出力先フォルダ</param>
        /// <param name="dt">書類一覧</param>
        /// <param name="str1">得意先コード</param>
        /// <param name="str2">担当者コード</param>
        public void MakeSendExcelWorkBook(FileOutput fot, string outFolder,DataTable dt, string str1, string str2)
        {

            string NowDateTime = DateTime.Now.ToString("yyyyMMddHHmmss");

            try
            {
                //テンプレートファイル
                string tmpbook = clsDefine.Other_Path() + "書類送付状.xlsx";
                //保存ファイル名
                string filepath = (fot == FileOutput.EXCEL ? outFolder : Path.GetTempPath()) + @"\書類送付状_" + NowDateTime + ".xlsx";

                //ClosedXMLを使用してEXCELファイルを作成
                using (ClosedXML.Excel.XLWorkbook workbook = new ClosedXML.Excel.XLWorkbook(tmpbook, ClosedXML.Excel.XLEventTracking.Disabled))
                {
                    DataTable getdt = new DataTable();
                    //和暦でDataTimeを文字列に変換する
                    System.Globalization.CultureInfo ci =
                        new System.Globalization.CultureInfo("ja-JP", false);
                    ci.DateTimeFormat.Calendar = new System.Globalization.JapaneseCalendar();
                    //ワークブック（送付状）の1シート目
                    ClosedXML.Excel.IXLWorksheet sheet = workbook.Worksheet(1);
                    SetPublishDay(sheet);
                    getdt = SelectOutside(str1, str2);
                    //郵便番号
                    sheet.Cell("B2").Value = "〒" + getdt.Rows[0][1].ToString();
                    //住所1
                    sheet.Cell("B3").Value = getdt.Rows[0][2].ToString();
                    //住所2
                    sheet.Cell("B4").Value = getdt.Rows[0][3].ToString();
                    //得意先名
                    sheet.Cell("B5").Value = getdt.Rows[0][0].ToString() + "　御中";
                    //担当者名
                    sheet.Cell("B7").Value = getdt.Rows[0][4].ToString() + " " + getdt.Rows[0][5].ToString() + "　様";
                    SetSendList(dt, sheet);
                    //以下、印刷処理に変更予定
                    workbook.SaveAs(filepath);
                }

                //作成したExcelBookのPDF出力または印刷を行う
                if (fot != FileOutput.EXCEL)
                {
                    using (clsExceltoPDF xlMng = new clsExceltoPDF(filepath))
                    {
                        if (fot == FileOutput.PDF)
                        {
                            string PdfFile = outFolder + @"\書類送付状_" + NowDateTime + ".pdf";
                            xlMng.BookSaveAsPdf(PdfFile);
                        }
                        else
                        {
                            xlMng.BookPrint();
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
                File.Delete(Path.GetTempPath() + @"\書類送付状_" + NowDateTime + ".xlsx");
            }
        }

        /// <summary>
        /// 社外用送り状を出力
        /// </summary>
        /// <param name="fot">出力対象</param>
        /// <param name="outFolder">出力先フォルダ</param>
        /// <param name="dt">書類一覧</param>
        /// <param name="dt2">技術者一覧</param>
        public void MakeSendExcelWorkBooks(FileOutput fot, string outFolder, DataTable dt, DataTable dt2)
        {

            string NowDateTime = DateTime.Now.ToString("yyyyMMddHHmmss");

            try
            {
                //テンプレートファイル
                string tmpbook = clsDefine.Other_Path() + "書類送付状.xlsx";
                //保存ファイル名
                string filepath = (fot == FileOutput.EXCEL ? outFolder : Path.GetTempPath()) + @"\書類送付状_" + NowDateTime + ".xlsx";

                //ClosedXMLを使用してEXCELファイルを作成
                using (ClosedXML.Excel.XLWorkbook workbook = new ClosedXML.Excel.XLWorkbook(tmpbook, ClosedXML.Excel.XLEventTracking.Disabled))
                {
                    int i = 1;
                    int count = 0;
                    //和暦でDataTimeを文字列に変換する
                    System.Globalization.CultureInfo ci =
                        new System.Globalization.CultureInfo("ja-JP", false);
                    ci.DateTimeFormat.Calendar = new System.Globalization.JapaneseCalendar();
                    //ワークブック（送付状）の1シート目
                    ClosedXML.Excel.IXLWorksheet sheet = workbook.Worksheet(1);
                    SetPublishDay(sheet);
                    SetSendList(dt, sheet);
                    
                    foreach (DataRow row in dt2.Rows)
                    {
                        if (row[0].ToString() == "1")
                        {
                            count++;
                        }
                    }
                    if(count > 1)
                    {
                        for (i = 1; i < count; i++)
                        {
                            sheet.CopyTo("書類送付状" + (i + 1));
                        }
                    }

                    //社員マスタから選択された社員のデータを取得
                    i = 1;
                    foreach (DataRow row in dt2.Rows)
                    {
                        if (row[0].ToString() == "1")
                        {
                            //郵便番号
                            workbook.Worksheet(i).Cell("B2").Value = "〒" + row[3].ToString();
                            //住所1
                            workbook.Worksheet(i).Cell("B3").Value = row[4].ToString();
                            //住所2
                            workbook.Worksheet(i).Cell("B4").Value = row[5].ToString();
                            //社員の名前
                            workbook.Worksheet(i).Cell("B6").Value = row[2].ToString() + "　様";
                            i++;
                        }
                    }
                    //以下、印刷処理に変更予定
                    workbook.SaveAs(filepath);
                }

                //作成したExcelBookのPDF出力または印刷を行う
                if (fot != FileOutput.EXCEL)
                {
                    using (clsExceltoPDF xlMng = new clsExceltoPDF(filepath))
                    {
                        if (fot == FileOutput.PDF)
                        {
                            string PdfFile = outFolder + @"\書類送付状_" + NowDateTime + ".pdf";
                            xlMng.BookSaveAsPdf(PdfFile);
                        }
                        else
                        {
                            xlMng.BookPrint();
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
                File.Delete(Path.GetTempPath() + @"\書類送付状_" + NowDateTime + ".xlsx");
            }
        }

        private void SetSendList(DataTable dt, ClosedXML.Excel.IXLWorksheet sheet)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == "0")
                {
                    if (i % 2 == 0)
                    {
                        sheet.Cell("C" + (23 + i)).Value = "□";
                        sheet.Cell("D" + (23 + i)).Value = dt.Rows[i][1].ToString();
                        sheet.Cell("M" + (23 + i)).Value = "通";
                    }
                    else
                    {
                        sheet.Cell("N" + (23 + i - 1)).Value = "□";
                        sheet.Cell("O" + (23 + i - 1)).Value = dt.Rows[i][1].ToString();
                        sheet.Cell("X" + (23 + i - 1)).Value = "通";
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        sheet.Cell("C" + (23 + i)).Value = "■";
                        sheet.Cell("D" + (23 + i)).Value = dt.Rows[i][1].ToString();
                        if (dt.Rows[i][2].ToString() == "0")
                        {
                            sheet.Cell("L" + (23 + i)).Value = "1";
                        }
                        else
                        {
                            sheet.Cell("L" + (23 + i)).Value = dt.Rows[i][2].ToString();
                        }
                        
                        sheet.Cell("M" + (23 + i)).Value = "通";
                    }
                    else
                    {
                        sheet.Cell("N" + (23 + i - 1)).Value = "■";
                        sheet.Cell("O" + (23 + i - 1)).Value = dt.Rows[i][1].ToString();
                        if (dt.Rows[i][2].ToString() == "0")
                        {
                            sheet.Cell("W" + (23 + i - 1)).Value = "1";
                        }
                        else
                        {
                            sheet.Cell("W" + (23 + i - 1)).Value = dt.Rows[i][2].ToString();
                        }   
                        sheet.Cell("X" + (23 + i - 1)).Value = "通";
                    }
                }
            }
        }

        private void SetPublishDay(ClosedXML.Excel.IXLWorksheet sheet)//和暦を印字
        {
            DateTime today = System.DateTime.Today;
            int tY = today.Year.ToIntlEx();
            int tM = today.Month.ToIntlEx();
            int tD = today.Day.ToIntlEx();
            if ((tY > 1989)//平成 
                || ((tY == 1989) && (tM == 1) && (tD > 7)))
            {
                string Y = (tY - 1988).ToString();
                if (Y == "1")
                {
                    Y = "元";
                }
                sheet.Cell("V2").Value = "平成" + Y + "年" + tM + "月" + tD + "日";
            }
            else if ((tY > 1926)//昭和 
                || ((tY == 1926) && (tM == 12) && (tD > 24)))
            {
                string Y = (tY - 1925).ToString();
                if (Y == "1")
                {
                    Y = "元";
                }
                sheet.Cell("V2").Value = "昭和" + Y + "年" + tM + "月" + tD + "日";
            }
            else if ((tY > 1912)//大正 
                || ((tY == 1912) && (tM == 7) && (tD > 29)))
            {
                string Y = (tY - 1911).ToString();
                if (Y == "1")
                {
                    Y = "元";
                }
                sheet.Cell("V2").Value = "大正" + Y + "年" + tM + "月" + tD + "日";
            }
            else if ((tY > 1868)//明治
                || ((tY == 1868) && (tM == 1) && (tD > 24)))
            {
                string Y = (tY - 1867).ToString();
                if (Y == "1")
                {
                    Y = "元";
                }
                sheet.Cell("V2").Value = "明治" + Y + "年" + tM + "月" + tD + "日";
            }
        }

    }
}