using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sugitec.Logics
{
	
	/// <summary>
	/// 技術者経歴テーブル用DTO
	/// </summary>
	public class dtoMnt111
	{
		/// <summary>技術者ＩＤ</summary>
		public string ENGINEER_ID=string.Empty;
		/// <summary>連番</summary>
		public int BIO_NO=0;
		/// <summary>開始年月日</summary>
		public string BIO_START_YMD = string.Empty;
		/// <summary>終了年月日</summary>
		public string BIO_END_YMD = string.Empty;
		/// <summary>業種</summary>
		public string BIO_BUS_TYP = string.Empty;
		/// <summary>システム概要</summary>
		public string BIO_OVERVIEW = string.Empty;
		/// <summary>ポジジョン</summary>
		public string BIO_POSITION = string.Empty;
		/// <summary>役割</summary>
		public string BIO_ROLE = string.Empty;
		/// <summary>人数</summary>
		public int BIO_NUM = 0;
		/// <summary>作業内容</summary>
		public int BIO_WORK = 0;
		/// <summary>要件定義</summary>
		public int BIO_RD = 0;
		/// <summary>調査分析</summary>
		public int BIO_SA = 0;
		/// <summary>ＤＢ設計</summary>
		public int BIO_DD = 0;
		/// <summary>基本設計</summary>
		public int BIO_UI = 0;
		/// <summary>詳細設計</summary>
		public int BIO_PS = 0;
		/// <summary>ＰＧ設計</summary>
		public int BIO_PD = 0;
		/// <summary>製造</summary>
		public int BIO_PG = 0;
		/// <summary>単体テスト</summary>
		public int BIO_PT = 0;
		/// <summary>結合テスト</summary>
		public int BIO_IT = 0;
		/// <summary>システムテスト</summary>
		public int BIO_ST = 0;
		/// <summary>障害対応</summary>
		public int BIO_IR = 0;
		/// <summary>システム導入</summary>
		public int BIO_SI = 0;
		/// <summary>開発外社内作業</summary>
		public int BIO_IW = 0;
		/// <summary>その他</summary>
		public int BIO_OTH = 0;
		/// <summary>削除フラグ</summary>
		public int DEL_FLG = 0;
		/// <summary>同期フラグ</summary>
		public int SYNC_FLG = 0;
		/// <summary>タイムスタンプ</summary>
		public string TIMESTAMP = string.Empty;


	}
}
