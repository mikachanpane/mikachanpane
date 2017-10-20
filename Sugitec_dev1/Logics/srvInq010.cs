using System;
using System.Data;
using System.Text;
using System.Configuration;
using Sugitec.Common;
using ClosedXML;
using ClosedXML.Excel;
using ClosedXML.Attributes;
using ClosedXML.Utils;


namespace Sugitec.Logics
{
	public class srvInq010
					: srvBase
	{

		#region”　Method for SQL　”

		/// <summary>
		/// 売上帳に表示させるDataTableをSelect文で取得します
		/// </summary>
		/// <param name="dto">dtoRep010</param>
		/// <returns>dgv_Result.DataSource</returns>
		public DataTable SelectCus(dtoInq010 dto)
		{
			try
			{
				//SQL構築
				StringBuilder Sql = new StringBuilder();

				//Access
				if(clsDefine.OperatingStatus == OperatStatus.OFFLINE)
				{
					Sql.Append(" Select      CUS.NAME AS 得意先");
					Sql.Append("            , CUS.PAYMENT_DAY AS 締");
					Sql.Append("            , '' AS 摘要");
					Sql.Append("            , FORMAT(DEP.RECEIPT_YMD, '@@@@/@@/@@') As 入金日");
					Sql.Append("            , REQ.BILLING_AMOUNT AS 売上金額");
					Sql.Append("            , REQ.CASH AS 現金");
					Sql.Append("            , REQ.BILL AS 手形");
					Sql.Append("            , REQ.DEPOSIT AS 預金");
					Sql.Append("            , FORMAT(DEP.RECEIPT_YMD, '@@@@/@@/@@') As 手形受取日");
					Sql.Append("            , REQ.TRANSFER_FEES AS 振込手数料");
					Sql.Append("            , REQ.DISCOUNT AS 値引");
					Sql.Append("            , REQ.CANCEL AS キャンセル");
					Sql.Append("            , REQ.DEPOSIT_RECV_AMOUNT As 差額");
					Sql.Append("            , MAX(IIF(ISNULL(COD.CONTENT), '',COD.CONTENT)) As 差額理由 ");
					Sql.Append(" From        (((T_REQUEST REQ");
					Sql.Append(" Inner Join  T_DEPOSIT DEP On REQ.REQUEST_NO = DEP.REQUEST_NO)");
					Sql.Append(" Inner Join  M_CUSTOMER CUS On REQ.CUSTOMER_CD = CUS.CODE )");
					Sql.Append(" Left Join   M_CODE COD On(REQ.DIFF_REASONS_CD = COD.CODE And COD.KBN = 'D01')) ");
					Sql.Append(" Where       REQ.DEL_FLG = 0");
					Sql.AppendFormat(" And   REQ.BILLING_YM = '{0}' ", dto.SALES_YM);
					Sql.Append(" GROUP BY");
					Sql.Append("              CUS.NAME");
					Sql.Append("            , CUS.PAYMENT_DAY");
					Sql.Append("            , DEP.RECEIPT_YMD");
					Sql.Append("            , REQ.BILLING_AMOUNT");
					Sql.Append("            , REQ.CASH");
					Sql.Append("            , REQ.BILL");
					Sql.Append("            , REQ.DEPOSIT");
					Sql.Append("            , DEP.BILL_YMD");
					Sql.Append("            , REQ.TRANSFER_FEES");
					Sql.Append("            , REQ.DISCOUNT");
					Sql.Append("            , REQ.CANCEL");
					Sql.Append("            , REQ.DEPOSIT_RECV_AMOUNT");
				}
				//SQL sever
				else
				{
					Sql.Append(" Select      CUS.NAME AS 得意先");
					Sql.Append("            , CUS.PAYMENT_DAY AS 締");
					Sql.Append("            , '' AS 摘要");
					Sql.Append("            , IIF(DEP.RECEIPT_YMD = '', '', FORMAT(CONVERT(DateTime, DEP.RECEIPT_YMD), 'yyyy/MM/dd')) As 入金日");
					Sql.Append("            , REQ.BILLING_AMOUNT AS 売上金額");
					Sql.Append("            , REQ.CASH AS 現金");
					Sql.Append("            , REQ.BILL AS 手形");
					Sql.Append("            , REQ.DEPOSIT AS 預金");
					Sql.Append("            , IIF(DEP.BILL_YMD = '', '', FORMAT(CONVERT(DateTime, DEP.BILL_YMD), 'yyyy/MM/dd')) As 手形受取日");
					Sql.Append("            , REQ.TRANSFER_FEES AS 振込手数料");
					Sql.Append("            , REQ.DISCOUNT AS 値引");
					Sql.Append("            , REQ.CANCEL AS キャンセル");
					Sql.Append("            , REQ.DEPOSIT_RECV_AMOUNT As 差額");
					Sql.Append("            , MAX(ISNULL(COD.CONTENT, '')) As 差額理由");
					Sql.Append(" From        (((T_REQUEST REQ");
					Sql.Append(" Inner Join  T_DEPOSIT DEP On REQ.REQUEST_NO = DEP.REQUEST_NO)");
					Sql.Append(" Inner Join  M_CUSTOMER CUS On REQ.CUSTOMER_CD = CUS.CODE )");
					Sql.Append(" Left Join   M_CODE COD On(REQ.DIFF_REASONS_CD = COD.CODE And COD.KBN = 'D01')) ");
					Sql.Append(" Where       REQ.DEL_FLG = 0");
					Sql.AppendFormat(" And   REQ.BILLING_YM = '{0}' ", dto.SALES_YM);
					Sql.Append(" GROUP BY");
					Sql.Append("              CUS.NAME");
					Sql.Append("            , CUS.PAYMENT_DAY");
					Sql.Append("            , DEP.RECEIPT_YMD");
					Sql.Append("            , REQ.BILLING_AMOUNT");
					Sql.Append("            , REQ.CASH");
					Sql.Append("            , REQ.BILL");
					Sql.Append("            , REQ.DEPOSIT");
					Sql.Append("            , DEP.BILL_YMD");
					Sql.Append("            , REQ.TRANSFER_FEES");
					Sql.Append("            , REQ.DISCOUNT");
					Sql.Append("            , REQ.CANCEL");
					Sql.Append("            , REQ.DEPOSIT_RECV_AMOUNT");
				}

				//選択クエリ
				return base.ExecuteSelect(Sql.ToString());
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 得意先・担当者別のデータをSelect文で取得します
		/// </summary>
		/// <param name="dto">dtoInq010</param>
		/// <returns>dgv_Result.DataSource</returns>
		public DataTable SelectEng(dtoInq010 dto)
		{
			//SQL構築
			StringBuilder Sql = new StringBuilder();

			//Access
			if(clsDefine.OperatingStatus == OperatStatus.OFFLINE)
			{
				Sql.Append(" Select		 CUS.NAME AS 得意先");
				Sql.Append("            , CUS.PAYMENT_DAY AS 締");
				Sql.Append("            , ENG.NAME AS 摘要");
				Sql.Append("            , FORMAT(DEP.RECEIPT_YMD, '@@@@/@@/@@') As 入金日");
				Sql.Append("            , REQ.BILLING_AMOUNT AS 売上金額");
				Sql.Append("            , REQ.CASH AS 現金");
				Sql.Append("            , REQ.BILL AS 手形");
				Sql.Append("            , REQ.DEPOSIT AS 預金");
				Sql.Append("            , FORMAT(DEP.BILL_YMD, '@@@@/@@/@@') As 手形受取日");
				Sql.Append("            , REQ.TRANSFER_FEES AS 振込手数料");
				Sql.Append("            , REQ.DISCOUNT AS 値引");
				Sql.Append("            , REQ.CANCEL AS キャンセル");
				Sql.Append("            , REQ.DEPOSIT_RECV_AMOUNT As 差額");
				Sql.Append("            , MAX(IIF(ISNULL(COD.CONTENT), '',COD.CONTENT)) As 差額理由 ");
				Sql.Append(" From        ((((T_REQUEST_DTL REQ");
				Sql.Append(" Inner Join  T_DEPOSIT DEP On REQ.REQUEST_NO = DEP.REQUEST_NO) ");
				Sql.Append(" Inner Join  M_ENGINEER ENG On REQ.ENGINEER_ID = ENG.ID) ");
				Sql.Append(" Inner Join  M_CUSTOMER CUS On REQ.CUSTOMER_CD = CUS.CODE ) ");
				Sql.Append(" Left Join   M_CODE COD On(REQ.DIFF_REASONS_CD = COD.CODE And COD.KBN = 'D01')) ");
				Sql.Append(" Where       REQ.DEL_FLG = 0");
				Sql.AppendFormat(" And   REQ.BILLING_YM = '{0}' ", dto.SALES_YM);
				Sql.Append(" GROUP BY");
				Sql.Append("             CUS.NAME");
				Sql.Append("            , CUS.PAYMENT_DAY");
				Sql.Append("            , DEP.RECEIPT_YMD");
				Sql.Append("            , REQ.BILLING_AMOUNT");
				Sql.Append("            , REQ.CASH");
				Sql.Append("            , REQ.BILL");
				Sql.Append("            , REQ.DEPOSIT");
				Sql.Append("            , DEP.BILL_YMD");
				Sql.Append("            , REQ.TRANSFER_FEES");
				Sql.Append("            , REQ.DISCOUNT");
				Sql.Append("            , REQ.CANCEL");
				Sql.Append("            , REQ.DEPOSIT_RECV_AMOUNT");
				Sql.Append("            , ENG.NAME");
			}
			//SQL sever
			else
			{
				Sql.Append(" Select		 CUS.NAME AS 得意先");
				Sql.Append("            , CUS.PAYMENT_DAY AS 締");
				Sql.Append("            , ENG.NAME AS 摘要");
				Sql.Append("            , IIF(DEP.RECEIPT_YMD = '', '', FORMAT(CONVERT(DateTime, DEP.RECEIPT_YMD), 'yyyy/MM/dd')) As 入金日");
				Sql.Append("            , REQ.BILLING_AMOUNT AS 売上金額");
				Sql.Append("            , REQ.CASH AS 現金");
				Sql.Append("            , REQ.BILL AS 手形");
				Sql.Append("            , REQ.DEPOSIT AS 預金");
				Sql.Append("            , IIF(DEP.BILL_YMD = '', '', FORMAT(CONVERT(DateTime, DEP.BILL_YMD), 'yyyy/MM/dd')) As 手形受取日");
				Sql.Append("            , REQ.TRANSFER_FEES AS 振込手数料");
				Sql.Append("            , REQ.DISCOUNT AS 値引");
				Sql.Append("            , REQ.CANCEL AS キャンセル");
				Sql.Append("            , REQ.DEPOSIT_RECV_AMOUNT As 差額");
				Sql.Append("            , MAX(ISNULL(COD.CONTENT, '')) As 差額理由");
				Sql.Append(" From        ((((T_REQUEST_DTL REQ");
				Sql.Append(" Inner Join  T_DEPOSIT DEP On REQ.REQUEST_NO = DEP.REQUEST_NO) ");
				Sql.Append(" Inner Join  M_ENGINEER ENG On REQ.ENGINEER_ID = ENG.ID) ");
				Sql.Append(" Inner Join  M_CUSTOMER CUS On REQ.CUSTOMER_CD = CUS.CODE ) ");
				Sql.Append(" Left Join   M_CODE COD On(REQ.DIFF_REASONS_CD = COD.CODE And COD.KBN = 'D01')) ");
				Sql.Append(" Where       REQ.DEL_FLG = 0");
				Sql.AppendFormat(" And   REQ.BILLING_YM = '{0}' ", dto.SALES_YM);
				Sql.Append(" GROUP BY");
				Sql.Append("             CUS.NAME");
				Sql.Append("            , CUS.PAYMENT_DAY");
				Sql.Append("            , DEP.RECEIPT_YMD");
				Sql.Append("            , REQ.BILLING_AMOUNT");
				Sql.Append("            , REQ.CASH");
				Sql.Append("            , REQ.BILL");
				Sql.Append("            , REQ.DEPOSIT");
				Sql.Append("            , DEP.BILL_YMD");
				Sql.Append("            , REQ.TRANSFER_FEES");
				Sql.Append("            , REQ.DISCOUNT");
				Sql.Append("            , REQ.CANCEL");
				Sql.Append("            , REQ.DEPOSIT_RECV_AMOUNT");
				Sql.Append("            , ENG.NAME");
			}

			//選択クエリ
			return base.ExecuteSelect(Sql.ToString());
		}

		#endregion

		#region”　Method for ClosedXML　”

		/// <summary>
		/// ClosedXMLでセル操作をした後、売上帳を出力します
		/// </summary>
		/// <param name="dt">Select文の実行結果</param>
        /// <param name="fot">押されたボタンが何か</param>
		/// <param name="monthly">ワークシートの年月度</param>
		public Boolean MakeMonthlyExcelWookBook(DataTable dt ,FileOutput fot ,string outFolder , string monthly)
		{
			try
			{
                //テンプレートファイル名を取得
                string TmpSalesList = ConfigurationManager.AppSettings["TMP_SALES_LIST"];
				//保存ファイル名までのパスを設定
				string filepath = (fot == FileOutput.EXCEL ? 
									outFolder :
									System.IO.Path.GetTempPath()) + string.Format("{0}年{1}月度{2}", 
																					monthly.Substring(0, 4), monthly.Substring(4), TmpSalesList);

				//ワークブックを編集：ワークブックを開く
				using (XLWorkbook book = new XLWorkbook(clsDefine.Monthly_Path() + TmpSalesList))
				{
					//ワークブック（月次帳票）の1シート目（売上帳）
					IXLWorksheet sheetMonthly = book.Worksheet("売上帳");

					//セルへ挿入：年月度をA1へ挿入する
					sheetMonthly.Cell(1, 1).Value = monthly.Substring(0, 4) + "年" + monthly.Substring(4) + "月度";

					//セルへ挿入：渡った売上帳用のDataTable
					sheetMonthly.Cell(5, 1).Value = dt.AsEnumerable();

					//行削除：合計のある行まで行削除する
					sheetMonthly.Rows(dt.Rows.Count + 5 + ":100").Delete();

					//ワークブックを保存
					book.SaveAs(filepath);
				}

				///エクセルブックに名前を付けて保存
				///using(System.Windows.Forms.SaveFileDialog sfd = new System.Windows.Forms.SaveFileDialog())
				///{
				///	//はじめのファイル名を指定する
				///	//はじめに「ファイル名」で表示される文字列を指定する
				///	sfd.FileName= string.Format("{0}年{1}月度{2}"
				///		, monthly.Substring(0, 4), monthly.Substring(4), TmpSalesList);
				///
				///	//タイトルを設定する
				///	sfd.Title = "保存先のファイルを選択してください";
				///
				///	//[ファイルの種類]に表示される選択肢を指定する
				///	//指定しない（空の文字列）の時は、現在のディレクトリが表示される
				///	sfd.Filter = "Excelブック(*.xlsx)|*.xlsx|すべてのファイル(*.*)|*.*";
				///
				///	//ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
				///	sfd.RestoreDirectory = true;
				///
				///	//ダイアログを表示する
				///	if(sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				///	{
				///		book.SaveAs(sfd.FileName.ToString());
				///	}
				///}

				//作成したExcelBookのPDF出力または印刷を行う
				if (fot != FileOutput.EXCEL)
				{
					//シート番号を指定してExcelをオープン
					using (clsExceltoPDF xlMng = new clsExceltoPDF(filepath, 1))
					{

						//一旦、保存する
						xlMng.BookSave();

						//PDF出力、又は印刷を行う
						if (fot == FileOutput.PDF)
						{
							//ファイルパス
							string PdfFile = string.Format("{0}{1}年{2}月度{3}.pdf"
								,outFolder , monthly.Substring(0, 4), monthly.Substring(4), TmpSalesList.Replace(".xlsx", ""));

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

                //正常終了
                return true;

				///没 ： 合計を最終行へ挿入：売上金額、現金、預金、手形、振込手数料、値引き、キャンセル
				///DataRow nrow;
				///nrow = dt.NewRow();
				///nrow[0] = "合計";
				///nrow["'売上金額 (税込)'"] = dt.Compute("Sum('売上金額 (税込)')", null).ToString();
				///nrow["'現金'"] = dt.Compute("Sum('現金')", null).ToString();
				///nrow["'預金'"] = dt.Compute("Sum('預金')", null).ToString();
				///nrow["'手形'"] = dt.Compute("Sum('手形')", null).ToString();
				///nrow["'振込手数料'"] = dt.Compute("Sum('振込手数料')", null).ToString();
				///nrow["'値引'"] = dt.Compute("Sum('値引')", null).ToString();
				///nrow["'キャンセル'"] = dt.Compute("Sum('キャンセル')", null).ToString();
				///dt.Rows.Add(nrow);

				///　”没”行削除：行を最終行まで削除し、データテーブルとエクセルの行数を合わせる
				///for(int i = dt.Rows.Count + 5 ; i < 100 ; i++)
				///{
				///}


			}
			catch
			{
				throw;
			}
		}

		#endregion

		/* ”没”

		/// <summary>
		/// 受け取ったワークシートの合計行のセルを書式設定します
		/// </summary>
		/// <param name="sheet">ワークシートのインスタンス</param>
		/// <param name="cell">セルのインスタンス</param>
		/// <param name="rowmax">出力用DataTableのRows.Count</param>
		private XLWorkbook WorkSheetSumCellDesigner(XLWorkbook book, IXLWorksheet sheet, int rowmax, int columnmax)
		{
			try
			{
				//RGB値を設定
				//左側（r1、g1、b1）：黄緑色の様な色	右側（r2、g2、b2）：黄色の様な色
				int r1 = 204, g1 = 255, b1 = 204;
				int r2 = 255, g2 = 255, b2 = 153;

				//最終行の先頭列で、合計のテキストを挿入（A○○：A○○）
				IXLRange rangeSumSal = sheet.Range(string.Format("A{0}", rowmax + 1,
														string.Format("D{0}"), rowmax + 1));
				//セルを結合
				rangeSumSal.Merge();
				rangeSumSal.Value = "合計";

				納品・完了日、入金日セルの結合は以下で行うと手間がかかりません
				//
				//ここにソースコードを記述してください
				//

				//セルをエクセルテンプレートのセルと同じ緑色に塗りつぶす
				IXLCell cellSumSall = sheet.Cell(string.Format("A{0}", rowmax + 1,
														string.Format("D{0}"), rowmax + 1));
				cellSumSall.Style.Fill.BackgroundColor = XLColor.FromArgb(r1, g1, b1);

				//セルをエクセルテンプレートのセルと同じ黄色に塗りつぶす
				for(int index = 0 ; index < columnmax ; index++)
				{
					//現金
					IXLCell cellSumCash = sheet.Cell(rowmax + 1, index);
					cellSumSall.Style.Fill.BackgroundColor = XLColor.FromArgb(r2, g2, b2);

					//預金
					IXLCell cellSumDepositsheet = sheet.Cell(rowmax + 1, index);
					cellSumSall.Style.Fill.BackgroundColor = XLColor.FromArgb(r2, g2, b2);

					//手形
					IXLCell cellSumBill = sheet.Cell(rowmax + 1, index);
					cellSumSall.Style.Fill.BackgroundColor = XLColor.FromArgb(r2, g2, b2);

					//振込手数料
					IXLCell cellSumTransfer = sheet.Cell(rowmax + 1, index);
					cellSumSall.Style.Fill.BackgroundColor = XLColor.FromArgb(r2, g2, b2);

					//値引
					IXLCell cellSumDis = sheet.Cell(rowmax + 1, index);
					cellSumSall.Style.Fill.BackgroundColor = XLColor.FromArgb(r2, g2, b2);

					//キャンセル
					IXLCell cellSumCancel = sheet.Cell(rowmax + 1, index);
					cellSumSall.Style.Fill.BackgroundColor = XLColor.FromArgb(r2, g2, b2);

					//差額
					IXLCell cellDiff = sheet.Cell(rowmax + 1, index);
					cellSumSall.Style.Fill.BackgroundColor = XLColor.FromArgb(r2, g2, b2);	
				}

				//正常終了
				return book;
			}
			catch
			{
				throw;
			}
		}

		*/
	}
}
