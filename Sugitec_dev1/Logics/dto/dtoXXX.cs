using System;



namespace Sugitec.Logics
{
	/// <summary>
	/// frmXXXのDTO
	/// </summary>
	public class dtoXXX
	{
		//ラジオボタン
		/// <summary>請求年月（個別指定）</summary>
		public string mtbBillingYm = string.Empty;

		/// <summary>請求年月（範囲指定＿開始）</summary>
		public string mtbBillingYmF = string.Empty;

		/// <summary>請求年月（範囲指定＿終了）</summary>
		public string mtbBillingYmT = string.Empty;

		/// <summary>得意先コード（個別指定）</summary>
		public string cmbCus = string.Empty;

		/// <summary>得意先コード（範囲指定＿開始）</summary>
		public string txtCusF = string.Empty;

		/// <summary>得意先コード（範囲指定＿終了）</summary>
		public string txtCusT = string.Empty;

		/// <summary>技術者コード（個別指定）</summary>
		public string cmbEng = string.Empty;

		/// <summary>技術者コード（範囲指定＿開始）</summary>
		public string txtEngF = string.Empty;

		/// <summary>技術者コード（範囲指定＿終了）</summary>
		public string txtEngT = string.Empty;

		/// <summary>請求書発行フラグ</summary>
		public String PUBLISH_FLG = string.Empty;

		//請求締日
		/// <summary>請求締日</summary>
		public string txtSime = string.Empty;


	}
}
