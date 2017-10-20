using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using Sugitec.Common;

namespace Sugitec.Logics
{
	public class srvReq020
					: srvBase
	{
		/// <summary>
		/// コントロールの指定された条件を受け取って、DataGridViewの表示項目を返します
		/// </summary>
		/// <param name="dto">dtoReq</param>
		/// <returns></returns>
		public DataTable Select(dtoReq020 dto)
		{
			try
			{
				//  SQL構築
				StringBuilder Sql = new StringBuilder();

                Sql.Append(" SELECT ");
                Sql.Append("    0 AS SEL0 ");
                Sql.Append("   ,DTL.REQUEST_NO ");
                Sql.Append("   ,DTL.REQUEST_SUB_NO ");
                Sql.Append("   ,DTL.CUSTOMER_CD ");
                Sql.Append("   ,DTL.SALES_NO ");
                Sql.Append("   ,DTL.ORDER_NO ");
                Sql.Append("   ,DTL.BILLING_AMOUNT ");
                Sql.Append("   ,ORD.PROJECT_NM ");
                Sql.Append("   ,ORD.INVOICE_FILE_NM ");
                Sql.Append("   ,ORD.UPPER_LIMIT ");
                Sql.Append("   ,ORD.LOWER_LIMIT ");
                Sql.Append("   ,ORD.BASE_RATE ");
                Sql.Append("   ,ORD.ORVER_RATE ");
                Sql.Append("   ,ORD.SUBTRACT_RATE ");

                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    Sql.Append("   ,IIF(DTL.BILLING_YM = '','',FORMAT(CONVERT(DateTime,DTL.BILLING_YM + '01'), 'yyyy/MM')) AS BILLING_YM ");
                    Sql.Append("   ,IIF(DTL.TRANSFER_YMD = '','',FORMAT(CONVERT(DateTime,DTL.TRANSFER_YMD), 'yyyy/MM/dd')) AS TRAMSYMD ");
                    Sql.Append("   ,IIF(SAL.START_YMD = '','',FORMAT(CONVERT(DateTime,SAL.START_YMD), 'yyyy/MM/dd')) AS STR_YMD ");
                    Sql.Append("   ,IIF(SAL.END_YMD = '','',FORMAT(CONVERT(DateTime,SAL.END_YMD), 'yyyy/MM/dd')) AS END_YMD ");
                }
                else
                {
                    Sql.Append("   ,FORMAT(DTL.BILLING_YM, '@@@@/@@') AS BILLING_YM ");
                    Sql.Append("   ,FORMAT(DTL.TRANSFER_YMD, '@@@@/@@/@@') AS TRAMSYMD ");
                    Sql.Append("   ,FORMAT(SAL.START_YMD, '@@@@/@@/@@') AS STR_YMD ");
                    Sql.Append("   ,FORMAT(SAL.END_YMD, '@@@@/@@/@@') AS END_YMD ");
                }
                Sql.Append("   ,SAL.OVER_TIME ");
                Sql.Append("   ,SAL.OPERATION_TIME ");
                Sql.Append("   ,SAL.LACK_TIME ");
                Sql.Append("   ,SAL.BASE_AMOUNT ");
                Sql.Append("   ,SAL.ORVER_AMOUNT ");
                Sql.Append("   ,SAL.SALES_AMOUNT ");
                Sql.Append("   ,SAL.SUBTRACT_AMOUNT ");
                Sql.Append("   ,SAL.TAX_RATE ");
                Sql.Append("   ,SAL.TAX_AMOUNT ");
                Sql.Append("   ,ENG.NAME AS ENGNAME ");
                Sql.Append("   ,CUS.NAME AS CUSNAME ");
                Sql.Append("   ,CUS.CUTOFF_DAY ");
                Sql.Append("   ,COD.CONTENT ");
                Sql.Append("    ,IIF(DTL.PUBLISH_FLG=0,'未発行','発行済') AS SEL1");
                Sql.Append("    FROM (((((T_REQUEST_DTL DTL");
                Sql.Append("    INNER JOIN T_SALES AS SAL ON DTL.SALES_NO = SAL.SALES_NO)");
                Sql.Append("    INNER JOIN T_ORDER AS ORD ON SAL.ORDER_NO = ORD.ORDER_NO)");
                Sql.Append("    INNER JOIN M_CODE AS COD ON ( COD.CODE = ORD.CONTRACT_TYP AND COD.KBN='B01'))");
                Sql.Append("    INNER JOIN M_CUSTOMER AS CUS ON ORD.CUSTOMER_CD = CUS.CODE)");
                Sql.Append("    INNER JOIN M_ENGINEER AS ENG ON ORD.ENGINEER_ID = ENG.ID)");

                Sql.AppendFormat("  WHERE ");

                //個別指定の場合：請求年月
                if (!string.IsNullOrEmpty(dto.mtbBillingYm))
				{
					Sql.AppendFormat("              DTL.BILLING_YM = '{0}'"
									, dto.mtbBillingYm);
				}
				//範囲指定の場合：請求年月
				if(!string.IsNullOrEmpty(dto.mtbBillingYmF) 
					|| !string.IsNullOrEmpty(dto.mtbBillingYmT))
				{

					Sql.AppendFormat("              DTL.BILLING_YM >= '{0}'" +
									"       And     DTL.BILLING_YM <= '{1}'"
									, dto.mtbBillingYmF, dto.mtbBillingYmT);
				}

				//個別指定の場合：得意先
				if(!string.IsNullOrEmpty(dto.cmbCus) && dto.cmbCus != "00000000")
				{
					Sql.AppendFormat("      And     ORD.CUSTOMER_CD = '{0}'"
										, dto.cmbCus);
				}
				//範囲指定の場合：得意先
				if(!string.IsNullOrEmpty(dto.txtCusF)
					|| !string.IsNullOrEmpty(dto.txtCusT))
				{
					Sql.AppendFormat("      And     ORD.CUSTOMER_CD >= '{0}'" +
										"   And     ORD.CUSTOMER_CD <= '{1}'"
										, dto.txtCusF, dto.txtCusT);
				}

				//個別指定の場合：技術者
				if(!string.IsNullOrEmpty(dto.cmbEng) && dto.cmbEng != "00000000")
				{
					Sql.AppendFormat("      And     ORD.ENGINEER_ID = '{0}'"
										, dto.cmbEng);
				}
				//範囲指定の場合：技術者
				if(!string.IsNullOrEmpty(dto.txtCusF) || !string.IsNullOrEmpty(dto.txtCusT))
				{
					Sql.AppendFormat("      And     ORD.ENGINEER_ID >= '{0}'" +
										"   And     ORD.ENGINEER_ID <= '{1}'"
										, dto.txtEngF, dto.txtEngT);
				}

				//請求書発行フラグ（False:全て）
				if(!string.IsNullOrEmpty(dto.PUBLISH_FLG))
				{
					//発行済
					if(dto.PUBLISH_FLG == "0")
					{
						Sql.AppendFormat("      And	    DTL.PUBLISH_FLG = 0");
					}
					//未発行
					if(dto.PUBLISH_FLG == "1")
					{
						Sql.AppendFormat("      And     DTL.PUBLISH_FLG = 1");
					}
				}

				//締め日
				if(!string.IsNullOrEmpty(dto.txtSime))
				{
					Sql.AppendFormat("        And     CUS.CUTOFF_DAY = {0}"
										, dto.txtSime);
				}

                Sql.AppendFormat(" ORDER BY DTL.REQUEST_NO, DTL.REQUEST_SUB_NO");

                //選択クエリ
                return ExecuteSelect(Sql.ToString());
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 得意先情報のコンボボックスの表示項目を返します
		/// </summary>
		/// <returns>得意先コンボボックス</returns>
		public DataTable SelectCustomerComboBox()
		{
			try
			{
				//  SQLを構築
				StringBuilder Sql = new StringBuilder();

				Sql.AppendFormat(" Select		S.CUSTOMER_CD, C.NAME");
				Sql.AppendFormat(" From			T_SALES  As S");
				Sql.AppendFormat(" Inner Join	M_CUSTOMER As C");
				Sql.AppendFormat(" On			S.CUSTOMER_CD = C.CODE");
                Sql.AppendFormat(" Where		S.DEL_FLG     = 0");
                Sql.AppendFormat(" Group By		S.CUSTOMER_CD, C.NAME");
				Sql.AppendFormat(" Order By		S.CUSTOMER_CD");

				//  選択クエリ
				return base.ExecuteSelect(Sql.ToString());
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 技術者情報のコンボボックスの表示項目を返します
		/// </summary>
		/// <returns>技術者コンボボックス</returns>
		public DataTable SelectEngineerComboBox()
		{
			try
			{
				//  SQLを構築
				StringBuilder Sql = new StringBuilder();

				Sql.Append(" Select");
				Sql.Append("			S.ENGINEER_ID, E.NAME");
				Sql.Append(" From");
				Sql.Append("			T_SALES As S");
				Sql.Append(" Inner Join");
				Sql.Append("			M_ENGINEER As E");
				Sql.Append(" On");
				Sql.Append("			S.ENGINEER_ID = E.ID");
                Sql.Append(" Where		S.DEL_FLG     = 0");
                Sql.Append(" Group By");
				Sql.Append("			S.ENGINEER_ID, E.NAME");
				Sql.Append(" Order By");
				Sql.Append("			S.ENGINEER_ID");

				//  選択クエリ
				return base.ExecuteSelect(Sql.ToString());
			}
			catch
			{
				throw;
			}
		}

        /// <summary>
        /// 請求書発行処理
        /// </summary>
        /// <param name="dt">一覧表のデータ</param>
        /// <param name="OutFolder">請求書の出力先フォルダ</param>
        /// <param name="OutType">出力形式</param>
        public void OutputInvoice(DataTable dt, string OutFolder, FileOutput OutType)
        {


            //請求書出力データの一覧
            List<clsOutReqData> OutReqDataList = new List<clsOutReqData>();

            try
            {
                //EXCEL出力先のフォルダ
                string ExcelFolder = (OutType == FileOutput.EXCEL ? OutFolder : Path.GetTempPath());

                foreach (DataRow row in dt.Select("SEL0 = 1"))
                {

                    //EXCLファイル名
                    string FileNm = "請求書_" + row["REQUEST_NO"].ToString() + "_" + row["REQUEST_SUB_NO"].ToString();

                    //請求年月日の取得
                    String sTmpPay = row["BILLING_YM"].ToString() + "/01";
                    DateTime dTmpYMD = DateTime.Parse(sTmpPay);
                    int TmpPayDay = row["CUTOFF_DAY"].ToIntlEx();
                    if (TmpPayDay == 99)
                    {
                        TmpPayDay = DateTime.DaysInMonth(dTmpYMD.Year, dTmpYMD.Month);
                    }
                    string Payday = dTmpYMD.Year.ToString() + "/" + dTmpYMD.Month.ToString().PadLeft(2, '0') + "/" + TmpPayDay.ToString().PadLeft(2, '0');

                    //請求書テンプレートを読込みデータをセットして出力
                    using (ClosedXML.Excel.XLWorkbook workbook = new ClosedXML.Excel.XLWorkbook(clsDefine.Invoice_Path() + row["INVOICE_FILE_NM"].ToString()))
                    {
                        //シート名を指定してシートを取得
                        ClosedXML.Excel.IXLWorksheet sheet = workbook.Worksheet("Data");
                        sheet.Cell("B2").Value = row["BILLING_YM"].ToString();
                        sheet.Cell("B3").Value = Payday;
                        sheet.Cell("B4").Value = row["REQUEST_NO"].ToString();
                        sheet.Cell("B5").Value = row["REQUEST_SUB_NO"].ToString();
                        sheet.Cell("B6").Value = row["CUSNAME"].ToString();
                        sheet.Cell("B7").Value = row["TRAMSYMD"].ToString();
                        sheet.Cell("B8").Value = row["PROJECT_NM"].ToString();
                        sheet.Cell("B9").Value = row["CONTENT"].ToString();
                        sheet.Cell("B10").Value = row["ENGNAME"].ToString();
                        sheet.Cell("B11").Value = row["STR_YMD"].ToString();
                        sheet.Cell("B12").Value = row["END_YMD"].ToString();
                        sheet.Cell("B13").Value = row["LOWER_LIMIT"].ToString();
                        sheet.Cell("B14").Value = row["UPPER_LIMIT"].ToString();
                        sheet.Cell("B15").Value = row["BASE_RATE"].ToString();
                        sheet.Cell("B16").Value = row["ORVER_RATE"].ToString();
                        sheet.Cell("B17").Value = row["SUBTRACT_RATE"].ToString();
                        sheet.Cell("B18").Value = row["OPERATION_TIME"].ToString();
                        sheet.Cell("B19").Value = row["LACK_TIME"].ToString();
                        sheet.Cell("B20").Value = row["OVER_TIME"].ToString();
                        sheet.Cell("B21").Value = row["BASE_AMOUNT"].ToString();
                        sheet.Cell("B22").Value = row["ORVER_AMOUNT"].ToString();
                        sheet.Cell("B23").Value = row["SUBTRACT_AMOUNT"].ToString();
                        sheet.Cell("B24").Value = row["SALES_AMOUNT"].ToString();
                        sheet.Cell("B25").Value = row["TAX_RATE"].ToString();
                        sheet.Cell("B26").Value = row["TAX_AMOUNT"].ToString();
                        sheet.Cell("B27").Value = row["BILLING_AMOUNT"].ToString();

                        //EXCELファイルを出力
                        workbook.SaveAs(ExcelFolder + FileNm + ".xlsx");
                    }

                    if (OutType == FileOutput.EXCEL)
                    {
                        //出力形式がEXCELの場合、請求書発行フラグを更新
                        UpdReqDtl(row["REQUEST_NO"].ToString(), row["REQUEST_SUB_NO"].ToString());
                    }
                    else
                    {
                        //出力形式がEXCEL以外の場合、請求書出力データ一覧に登録
                        clsOutReqData ReqData = new clsOutReqData();
                        ReqData.REQ_NO = row["REQUEST_NO"].ToString();
                        ReqData.REQ_SUB_NO = row["REQUEST_SUB_NO"].ToString();
                        ReqData.EXCEL_FILE = ExcelFolder + FileNm + ".xlsx";
                        ReqData.PDF_FILE = OutFolder + FileNm + ".pdf";
                        OutReqDataList.Add(ReqData);
                    }
                }

                //出力形式がEXCEL以外の場合、PDF出力、印刷を行う
                if (OutType != FileOutput.EXCEL)
                {
                    OutPdfOrPrint(OutReqDataList, OutType);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //TEMPファイルを削除
                foreach (clsOutReqData row in OutReqDataList)
                {
                    File.Delete(row.EXCEL_FILE);
                }
            }
        }

        /// <summary>
        /// 請求明細情報の請求書発行フラグを更新
        /// </summary>
        /// <param name="ReqNo"></param>
        /// <param name="ReqSubNo"></param>
        private void UpdReqDtl(string ReqNo, string ReqSubNo)
        {
            try
            {
                StringBuilder Sql = new StringBuilder();
                Sql.AppendFormat("UPDATE T_REQUEST_DTL SET ");
                Sql.AppendFormat("  PUBLISH_FLG = 1 ");
                Sql.AppendFormat(" WHERE REQUEST_NO     = '{0}'", ReqNo);
                Sql.AppendFormat("   AND REQUEST_SUB_NO = '{0}'", ReqSubNo);
                base.ExecuteAction(Sql.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// PDF出力、印刷を行う
        /// </summary>
        /// <param name="ReqList">請求書出力データの一覧</param>
        /// <param name="OutType">出力形式</param>
        private void OutPdfOrPrint(List<clsOutReqData> ReqList, FileOutput OutType)
        {
            try
            {
                //ExcelAppをオープン
                using (clsExceltoPDF xlMng = new clsExceltoPDF())
                {
                    foreach (clsOutReqData row in ReqList)
                    {
                        //Bookを開く
                        xlMng.BookOpen(row.EXCEL_FILE);

                        //Sheetを選択
                        xlMng.SheetSelect(1);

                        //PDF出力、又は印刷を行う
                        if (OutType == FileOutput.PDF)
                        {
                            //シートをPDF出力
                            xlMng.SheetSaveAsPdf(row.PDF_FILE);
                        }
                        else
                        {
                            //シートを印刷
                            xlMng.SheetPrint();
                        }

                        //一旦、保存して閉じる
                        xlMng.BookSave(true);

                        //請求書発行フラグを更新
                        UpdReqDtl(row.REQ_NO, row.REQ_SUB_NO);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 請求書出力データクラス
        /// </summary>
        private class clsOutReqData
        {
            /// <summary> 請求№ </summary>
            public string REQ_NO;
            /// <summary> 請求№枝番 </summary>
            public string REQ_SUB_NO;
            /// <summary> EXCELファイル </summary>
            public string EXCEL_FILE;
            /// <summary> PDFファイル </summary>
            public string PDF_FILE;
        }
    }
}

