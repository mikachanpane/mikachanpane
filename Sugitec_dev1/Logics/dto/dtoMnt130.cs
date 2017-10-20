using Sugitec.Common;

namespace Sugitec.Logics
{
	public class dtoMnt130
	{
		/// <summary>得意先コード</summary>
		public string CustomerCode = string.Empty;

		/// <summary>担当者コード</summary>
		public string ConCod = string.Empty;

		/// <summary>氏名</summary>
		public string ConName = string.Empty;

		/// <summary>部署</summary>
		public string Section = string.Empty;

		/// <summary>削除フラグ</summary>
		public int Delflg = 0;

		/// <summary>同期フラグ</summary>
		public int SynFlg = 0;

		/// <summary>タイムスタンプ</summary>
		public string TimeSta = string.Empty;
	}
}
