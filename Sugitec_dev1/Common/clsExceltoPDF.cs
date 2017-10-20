using System;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Sugitec.Common
{
    /// <summary>
    /// Excelファイルを保存する機能を提供します。
    /// </summary>
    public class clsExceltoPDF : IDisposable
    {
        /// <summary> ExcelApplication </summary>
        private dynamic xlApp = null;
        /// <summary> workbooks </summary>
        private dynamic xlBooks = null;
        /// <summary> workbook </summary>
        private dynamic xlBook = null;
        /// <summary> WorkSheets </summary>
        private dynamic xlSheets = null;
        /// <summary> WorkSheet </summary>
        private dynamic xlSheet = null;

        ///// <summary> ExcelApplication </summary>
        //private Application xlApp = null;
        ///// <summary> WorkBooks </summary>
        //private Workbooks xlBooks = null;
        ///// <summary> WorkBook </summary>
        //private Workbook xlBook = null;
        ///// <summary> WorkSheets </summary>
        //private Sheets xlSheets = null;
        ///// <summary> WorkSheet </summary>
        //private Worksheet xlSheet = null;


        #region "IDisposable Support"

        private bool disposedValue = false; // 重複する呼び出しを検出するには

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // マネージ状態を破棄します (マネージ オブジェクト)。
                }

                // COMを開放
                ReleaseXlsComObject(EnumReleaseType.App);
                disposedValue = true;
            }
        }

        ~clsExceltoPDF()
        {
            // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
            Dispose(false);
        }

        public void Dispose()
        {
            // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
            Dispose(true);
            // 上のファイナライザーがオーバーライドされる場合は、次の行のコメントを解除してください。
            GC.SuppressFinalize(this);
        }

        #endregion

        #region "コンストラクタ"

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public clsExceltoPDF()
        {
            try
            {
                //レジストリからExcel.Applicationオブジェクトの型を取得
                Type t = Type.GetTypeFromProgID("Excel.Application");
                if (t == null)
                {
                    throw new Exception("Excelがインストールされていません");
                }
                //Excelオブジェクトのインスタンスを生成
                xlApp = Activator.CreateInstance(t);
                //不可視
                xlApp.Visible = false;
                //メッセージを非表示
                xlApp.DisplayAlerts = false;
                //Workbooksオブジェクトを取得
                xlBooks = xlApp.Workbooks;
            }
            catch (Exception)
            {
                throw;
            } 
        }

        /// <summary>
        /// コンストラクタ(既存ファイルを開く)
        /// </summary>
        /// <param name="FilePathName">ファイル名（フルパス）</param>
        public clsExceltoPDF(string FilePathName)  
        {
            try
            {
                //レジストリからExcel.Applicationオブジェクトの型を取得
                Type t = Type.GetTypeFromProgID("Excel.Application");
                if (t == null)
                {
                    throw new Exception("Excelがインストールされていません");
                }
                //Excelオブジェクトのインスタンスを生成
                xlApp = Activator.CreateInstance(t);
                //不可視
                xlApp.Visible = false;
                //メッセージを非表示
                xlApp.DisplayAlerts = false;
                //Workbooksオブジェクトを取得
                xlBooks = xlApp.Workbooks;
                //既存Bookを開く
                BookOpen(FilePathName);

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// コンストラクタ（既存ファイルを開き指定したシートを選択する）
        /// </summary>
        /// <param name="FilePath">ファイル名（フルパス）</param>
        /// <param name="SheetNo">シート№</param>
        public clsExceltoPDF(string FilePath, int SheetNo)
        {
            try
            {
                //レジストリからExcel.Applicationオブジェクトの型を取得
                Type t = Type.GetTypeFromProgID("Excel.Application");
                if (t == null)
                {
                    throw new Exception("Excelがインストールされていません");
                }
                //Excelオブジェクトのインスタンスを生成
                xlApp = Activator.CreateInstance(t);
                //不可視
                xlApp.Visible = false;
                //メッセージを非表示
                xlApp.DisplayAlerts = false;
                //Workbooksオブジェクトを取得
                xlBooks = xlApp.Workbooks;
                //既存Bookを開く
                BookOpen(FilePath);
                //シートを選択する
                SheetSelect(SheetNo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// コンストラクタ（既存ファイルを開き指定したシートを選択する）
        /// </summary>
        /// <param name="FilePath">ファイル名（フルパス）</param>
        /// <param name="SheetName">シート名</param>
        public clsExceltoPDF(string FilePath, string SheetName)
        {
            try
            {
                //レジストリからExcel.Applicationオブジェクトの型を取得
                Type t = Type.GetTypeFromProgID("Excel.Application");
                if (t == null)
                {
                    throw new Exception("Excelがインストールされていません");
                }
                //Excelオブジェクトのインスタンスを生成
                xlApp = Activator.CreateInstance(t);
                //不可視
                xlApp.Visible = false;
                //メッセージを非表示
                xlApp.DisplayAlerts = false;
                //Workbooksオブジェクトを取得
                xlBooks = xlApp.Workbooks;
                //既存Bookを開く
                BookOpen(FilePath);
                //シートを選択する
                SheetSelect(SheetName);

            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region "COM解放"

        ///<summary>
        /// ReleaseExcelComObjectメソッドの引数用
        /// </summary>
        /// <remarks></remarks>
        private enum EnumReleaseType
        {
            Sheet,
            Sheets,
            Book,
            WorkBooks,
            App,
        }

        /// <summary>
        /// COMオブジェクトの解放処理
        /// </summary>
        /// <remarks></remarks>
        private void ReleaseXlsComObject(EnumReleaseType ReleaseType)
        {
            try
            {
                // worksheet解放
                if (xlSheet != null)
                {
                    Marshal.ReleaseComObject((object)xlSheet);
                    xlSheet = null;
                }

                if (ReleaseType <= EnumReleaseType.Sheet)
                {
                    return;
                }

                // worksheets解放
                if (xlSheets != null)
                {
                    Marshal.ReleaseComObject(xlSheets);
                    xlSheets = null;
                }

                if (ReleaseType <= EnumReleaseType.Sheets)
                {
                    return;
                }
                // workbook解放
                if (xlBook != null)
                {
                    Marshal.ReleaseComObject((object)xlBook);
                    xlBook = null;
                }
                if (ReleaseType <= EnumReleaseType.Book)
                {
                    return;
                }

                // workBooks解放
                if (xlBooks != null)
                {
                    Marshal.ReleaseComObject(xlBooks);
                    xlBooks = null;
                }
                if (ReleaseType <= EnumReleaseType.WorkBooks)
                {
                    return;
                }

                // application解放
                if (xlApp != null)
                {
                    try
                    {
                        // アラートを戻す
                        //xlApp.DisplayAlerts = True
                        xlApp.Quit();
                    }
                    finally
                    {
                        Marshal.ReleaseComObject(xlApp);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region "Excelアプリケーション操作"

        /// <summary>
        /// Excelのバージョンを取得する
        /// </summary>
        /// <returns></returns>
        public string xlAppVersion
        {
            get { return xlApp.Version; }
        }

        /// <summary>
        /// Excelの可視化を取得、設定する
        /// </summary>
        /// <returns></returns>
        public bool xlAppVisible
        {
            get { return xlApp.Visible; }
            set{ xlApp.Visible = value; }
        }

        /// <summary>
        /// Excelの確認メッセージの表示、非表示を取得、設定する
        /// </summary>
        /// <returns></returns>
        public bool xlAppDisplayAlerts
        {
            get { return xlApp.DisplayAlerts; }
            set { xlApp.DisplayAlerts = value; }
        }

        #endregion

        #region "Book操作"

        /// <summary>
        /// 新規Bookを開く
        /// </summary>
        /// <returns></returns>
        public void BookOpen()
        {
            try
            {
                //既にBookが開いていれば開放
                if (xlBook != null)
                {
                    ReleaseXlsComObject(EnumReleaseType.Book);
                }

                //Bookを追加
                xlBook = xlBooks.Add();
                xlSheets = xlBook.Sheets;
            }
            catch (Exception)
            {

                throw;
            }            
        }

        /// <summary>
        /// 既存Bookを開く
        /// </summary>
        /// <param name="FilePath">ファイル名（フルパス）</param>
        /// <returns></returns>
        public void BookOpen(string FilePath)
        {
            try
            {
                //存在チェック
                if (!System.IO.File.Exists(FilePath))
                {
                    throw new Exception("指定したファイルが存在しません。");
                }

                //既にBookが開いていれば開放
                if (xlBook != null)
                {
                    ReleaseXlsComObject(EnumReleaseType.Book);
                }

                //Bookを開く
                xlBook = xlBooks.Open(FilePath);

                xlSheets = xlBook.Sheets;

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Bookを上書き保存する
        /// </summary>
        /// <param name="isClosed">True：ファイルを閉じる</param>
        /// <returns></returns>
        public void BookSave(bool isClosed  = false)
        {

            try
            {
                //Bookが開いていなければエラー
                if (xlBook == null)
                {
                    return;
                }

                xlBook.Save();

                if (isClosed)
                {
                    BookClose();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Bookを閉じる
        /// </summary>
        /// <returns></returns>
        public void BookClose()
        {
            try
            {
                ReleaseXlsComObject(EnumReleaseType.Book);
            }
            catch (Exception)
            {

                throw;
            }
        }

        # endregion

        #region "Sheet操作"

        /// <summary>
        /// シートを選択する
        /// </summary>
        /// <param name="SheetNm">シート名</param>
        /// <returns></returns>
        public void SheetSelect(string SheetNm)
        {
            try
            {
                //Bookが開いていなければエラー
                if (xlBook == null)
                {
                    throw new Exception("Bookが開いていません。");
                }
                //シートが存在しなければエラー
                if (!SheetPresenceCheck(SheetNm))
                {
                    throw new Exception("Sheetが存在しません。");
                }
                //既にSheetが選択されていれば開放
                if (xlSheet != null)
                    {
                        ReleaseXlsComObject(EnumReleaseType.Sheet);
                    }

                object[] parameters = new object[1];
                parameters[0] = SheetNm;
                xlSheet = xlSheets.GetType().InvokeMember("Item", BindingFlags.GetProperty, null, xlSheets, parameters);

            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// シートを選択する
        /// </summary>
        /// <param name="SheetNo">シート番号（1～）</param>
        /// <returns></returns>
        public void SheetSelect(int SheetNo)
        {
            try
            {
                //Bookが開いていなければエラー
                if (xlBook == null)
                {
                    throw new Exception("Bookが開いていません。");
                }
                //シートが存在しなければエラー
                if (!SheetPresenceCheck(SheetNo))
                {
                    throw new Exception("Sheetが存在しません。");
                }
                //既にSheetが選択されていれば開放
                if (xlSheet != null)
                {
                    ReleaseXlsComObject(EnumReleaseType.Sheet);
                }

                object[] parameters = new object[1];
                parameters[0] = SheetNo;
                xlSheet = xlSheets.GetType().InvokeMember("Item", BindingFlags.GetProperty, null, xlSheets, parameters);

            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// シートの存在チェック
        /// </summary>
        /// <param name="SheetNo">シート番号（1～）</param>
        /// <returns></returns>
        private bool SheetPresenceCheck(int SheetNo)
        {
            try
            {
                //シート数を取得
                int SheetMax = xlSheets.Count;

                //シート番号が1～シート数以外ならエラー
                if (SheetNo <= 0 || SheetNo > SheetMax)
                {
                    return false;
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// シートの存在チェック
        /// </summary>
        /// <param name="SheetNm">シート名</param>
        /// <returns></returns>
        public bool SheetPresenceCheck(string SheetNm)
        {
            try
            {

                foreach (dynamic tmpSheet in xlSheets)
                {
                    if (SheetNm.ToLower() == tmpSheet.Name.ToLower())
                    {
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(tmpSheet);
                        return true;

                    }
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(tmpSheet);
                }

                return false;

            }
            catch (Exception)
            {

                throw;
            }

        }

        #endregion

        #region "PDF保存"

        /// <summary>
        /// 開いてるBookをPDFとして保存します。
        /// </summary>
        /// <param name="saveAsPathName">保存するPDFのパス付きファイル名。</param>
        /// <remarks>
        /// <para>Excel 2007がインストールされている必要があります。</para>
        /// <para>Office 2007のSP2、またはPDF保存アドインがインストールされている必要があります。</para>
        /// </remarks>
        public void BookSaveAsPdf(string saveAsPathName)
        {
            try
            {
                //保存するファイル名が空白の場合、エラー
                if (string.IsNullOrEmpty(saveAsPathName))
                {
                    throw new Exception("保存するファイル名が未入力です。");
                }
                //Bookが開いていなければエラー
                if (xlBook == null)
                {
                    throw new Exception("Bookが開いていません。");
                }
                //PDFを出力
                xlBook.ExportAsFixedFormat(0, saveAsPathName, 0, true, true, Type.Missing, Type.Missing, false, Type.Missing);

            }
            catch (Exception)
            {
                throw;
            }  
        }

        /// <summary>
        /// 開いてるBookの選択中シートをPDFとして保存します。
        /// </summary>
        /// <param name="saveAsPathName">保存するPDFのパス付きファイル名。</param>
        /// <remarks>
        /// <para>Excel 2007がインストールされている必要があります。</para>
        /// <para>Office 2007のSP2、またはPDF保存アドインがインストールされている必要があります。</para>
        /// </remarks>
        public void SheetSaveAsPdf(string saveAsPathName)
        {
            try
            {
                //保存するファイル名が空白の場合、エラー
                if (string.IsNullOrEmpty(saveAsPathName))
                {
                    throw new Exception("保存するファイル名が未入力です。");
                }
                //Bookが開いていなければエラー
                if (xlBook == null)
                {
                    throw new Exception("Bookが開いていません。");
                }
                //シートが未選択ならエラー
                if (xlSheet == null)
                {
                    throw new Exception("Sheetが選択されていません。");
                }
                //PDFを出力
                xlSheet.ExportAsFixedFormat(0, saveAsPathName, 0, true, true, Type.Missing, Type.Missing, false, Type.Missing);

            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region "印刷"

        /// <summary>
        /// 開いてるBookを印刷します。
        /// </summary>
        public void BookPrint()
        {
            try
            {
                //Bookが開いていなければエラー
                if (xlBook == null)
                {
                    throw new Exception("Bookが開いていません。");
                }

                //印刷
                xlBook.PrintOut();

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 開いてるBookの選択中シートを印刷します。
        /// </summary>
        public void SheetPrint()
        {
            try
            {
                //Bookが開いていなければエラー
                if (xlBook == null)
                {
                    throw new Exception("Bookが開いていません。");
                }
                //シートが未選択ならエラー
                if (xlSheet == null)
                {
                    throw new Exception("Sheetが選択されていません。");
                }
                //印刷
                xlSheet.PrintOut();

            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

    }


}