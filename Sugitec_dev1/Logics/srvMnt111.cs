using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sugitec.Common;

namespace Sugitec.Logics
{
	/// <summary>
	/// 技術者経歴マスタサービスクラス
	/// ここには基本的にDBの操作を記述してください　内容：取得、追加、更新、削除、取得(コンボボックス)、取得(リストボックス)
	/// </summary>
	public class srvMnt111 : srvBase
	{
		/// <summary>
		/// 技術者経歴マスタへの登録
		/// </summary>
		/// <param name="dto">frmMnt111のテキストボックス</param>
		public void Insert(dtoMnt111 dto)
		{
			try
			{
				//SQL文を構築
				System.Text.StringBuilder Sql = new StringBuilder();

				Sql.Append("INSERT INTO M_BIOGRAPHY");
				Sql.Append(" (          ENGINEER_ID");
				Sql.Append(",           BIO_NO");
				Sql.Append(",           BIO_START_YMD");
				Sql.Append(",           BIO_END_YMD");
				Sql.Append(",           BIO_BUS_TYP");
				Sql.Append(",           BIO_OVERVIEW");
				Sql.Append(",           BIO_POSITION");
				Sql.Append(",           BIO_ROLE");
				Sql.Append(",           BIO_NUM");
				Sql.Append(",           BIO_WORK");
				Sql.Append(",           BIO_RD");
				Sql.Append(",           BIO_SA");
				Sql.Append(",           BIO_DD");
				Sql.Append(",           BIO_UI");
				Sql.Append(",           BIO_PS");
				Sql.Append(",           BIO_PD");
				Sql.Append(",           BIO_PG");
				Sql.Append(",           BIO_PT");
				Sql.Append(",           BIO_IT");
				Sql.Append(",           BIO_IR");
				Sql.Append(",           BIO_SI");
				Sql.Append(",           BIO_IW");
				Sql.Append(",           BIO_OTH");
				Sql.Append(",           DEL_FLG");
				Sql.Append(",           SYNC_FLG");
				Sql.Append(",           TIME_STAMP ) ");
				Sql.Append(" VALUES");
				Sql.Append(" (");
				Sql.AppendFormat("  '{0}'", dto.ENGINEER_ID);
				Sql.AppendFormat(", '{0}'", dto.BIO_NO);
				Sql.AppendFormat(", '{0}'", dto.BIO_START_YMD);
				Sql.AppendFormat(", '{0}'", dto.BIO_END_YMD);
				Sql.AppendFormat(", '{0}'", dto.BIO_BUS_TYP);
				Sql.AppendFormat(", '{0}'", dto.BIO_OVERVIEW);
				Sql.AppendFormat(", '{0}'", dto.BIO_POSITION);
				Sql.AppendFormat(", '{0}'", dto.BIO_ROLE);
				Sql.AppendFormat(", '{0}'", dto.BIO_NUM);
				Sql.AppendFormat(", '{0}'", dto.BIO_WORK);
				Sql.AppendFormat(", '{0}'", dto.BIO_RD);
				Sql.AppendFormat(", '{0}'", dto.BIO_SA);
				Sql.AppendFormat(", '{0}'", dto.BIO_DD);
				Sql.AppendFormat(", '{0}'", dto.BIO_UI);
				Sql.AppendFormat(", '{0}'", dto.BIO_PS);
				Sql.AppendFormat(", '{0}'", dto.BIO_PD);
				Sql.AppendFormat(", '{0}'", dto.BIO_PG);
				Sql.AppendFormat(", '{0}'", dto.BIO_PT);
				Sql.AppendFormat(", '{0}'", dto.BIO_IT);
				Sql.AppendFormat(", '{0}'", dto.BIO_ST);
				Sql.AppendFormat(", '{0}'", dto.BIO_IR);
				Sql.AppendFormat(", '{0}'", dto.BIO_SI);
				Sql.AppendFormat(", '{0}'", dto.BIO_IW);
				Sql.AppendFormat(", '{0}'", dto.BIO_OTH);
				Sql.AppendFormat(", {0}", dto.DEL_FLG);
				Sql.AppendFormat(", {0}", dto.SYNC_FLG);
				Sql.AppendFormat(", '{0}'", dto.TIMESTAMP);
				Sql.Append(")");

				//更新を実行
				ExecuteAction(Sql.ToString());
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 技術者経歴マスタの更新
		/// </summary>
		/// <param name="dto">frmMnt131用のテキストボックス</param>
		public void Update(dtoMnt111 dto)
		{
			try
			{
				//SQL文を構築
				System.Text.StringBuilder Sql = new StringBuilder();

				Sql.Append("      UPDATE M_BIOGRAPHY");
				Sql.Append("      SET ");
				Sql.AppendFormat("       BIO_START_YMD = '{0}' ", dto.BIO_START_YMD);
				Sql.AppendFormat(",      BIO_END_YMD = '{0}'      ", dto.BIO_END_YMD);
				Sql.AppendFormat(",      BIO_BUS_TYP = '{0}' ", dto.BIO_BUS_TYP);
				Sql.AppendFormat(",      BIO_OVERVIEW = '{0}'      ", dto.BIO_OVERVIEW);
				Sql.AppendFormat(",      BIO_POSITION = '{0}' ", dto.BIO_POSITION);
				Sql.AppendFormat(",      BIO_ROLE = '{0}'      ", dto.BIO_ROLE);
				Sql.AppendFormat(",      BIO_NUM = '{0}' ", dto.BIO_NUM);
				Sql.AppendFormat(",      BIO_WORK = '{0}'      ", dto.BIO_WORK);
				Sql.AppendFormat(",      BIO_RD = '{0}' ", dto.BIO_RD);
				Sql.AppendFormat(",      BIO_SA = '{0}'      ", dto.BIO_SA);
				Sql.AppendFormat(",      BIO_DD = '{0}' ", dto.BIO_DD);
				Sql.AppendFormat(",      BIO_UI = '{0}'      ", dto.BIO_UI);
				Sql.AppendFormat("       BIO_PS = '{0}' ", dto.BIO_PS);
				Sql.AppendFormat(",      BIO_PD = '{0}'      ", dto.BIO_PD);
				Sql.AppendFormat(",      BIO_PG = '{0}' ", dto.BIO_PG);
				Sql.AppendFormat(",      BIO_PT = '{0}'      ", dto.BIO_PT);
				Sql.AppendFormat(",      BIO_IT = '{0}' ", dto.BIO_IT);
				Sql.AppendFormat(",      BIO_ST = '{0}'      ", dto.BIO_ST);
				Sql.AppendFormat(",      BIO_IR = '{0}' ", dto.BIO_IR);
				Sql.AppendFormat(",      BIO_SI = '{0}'      ", dto.BIO_SI);
				Sql.AppendFormat(",      BIO_IW = '{0}' ", dto.BIO_IW);
				Sql.AppendFormat(",      BIO_OTH = '{0}'      ", dto.BIO_OTH);
				Sql.AppendFormat(",      DEL_FLG = {0}        ", dto.DEL_FLG);
				Sql.AppendFormat(",      SYNC_FLG = {0}       ", dto.SYNC_FLG);
				Sql.AppendFormat(",      TIME_STAMP = '{0}'   ", dto.TIMESTAMP);
				Sql.AppendFormat(" WHERE ENGINEER_ID = '{0}' ", dto.ENGINEER_ID);

				//アクションクエリ
				ExecuteAction(Sql.ToString());
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 技術者経歴マスタの削除（0→1へにする論理削除）
		/// </summary>
		/// <param name="dt">DataGridView</param>
		public void Delete(DataTable dt)
		{
			try
			{
				List<string> SqlList = new List<string>();
				StringBuilder Sql = new StringBuilder();

				//削除対象のSQLを構築
				foreach(DataRow row in dt.Rows)
				{
					// 引数の
					if(row[0].ToString() == "1")
					{
						Sql.Clear();
						Sql.AppendFormat(" UPDATE  M_BIOGRAPHY");
						Sql.AppendFormat(" SET     DEL_FLG = 1");                       // WHERE
						Sql.AppendFormat(" WHERE   ENGINEER_ID = '{0}'", row["ENGINEER_ID"].ToString());

						//リストを生成
						SqlList.Add(Sql.ToString());
					}
				}

				//更新を実行
				ExecuteAction(SqlList);
			}
			catch
			{
				throw;
			}
		}


		/// <summary>
		///  技術者経歴グリッド用の情報を取得する
		/// </summary>
		/// <param name="EngineerId">技術者コード</param>
		public DataTable SelectEngineerCareerDataGrid(string EngineerId)
		{
			//SQL構築
			//技術者ＩＤが存在するときは、対象の技術者の経歴を表示
			//技術者ＩＤが存在しない場合は、全技術者の1件目のレコードを表示
			StringBuilder Sql = new StringBuilder();

			Sql.Append(" SELECT");
			Sql.Append("            ENGINEER_ID");
			Sql.Append(",           BIO_NO");
			Sql.Append(",           BIO_START_YMD");
			Sql.Append(",           BIO_END_YMD");
			Sql.Append(",           BIO_BUS_TYP");
			Sql.Append(",           BIO_OVERVIEW");
			Sql.Append(",           BIO_POSITION");
			Sql.Append(",           BIO_ROLE");
			Sql.Append(",           BIO_NUM");
			Sql.Append(",           BIO_WORK");
			Sql.Append(",           BIO_RD");
			Sql.Append(",           BIO_SA");
			Sql.Append(",           BIO_DD");
			Sql.Append(",           BIO_UI");
			Sql.Append(",           BIO_PS");
			Sql.Append(",           BIO_PD");
			Sql.Append(",           BIO_PG");
			Sql.Append(",           BIO_PT");
			Sql.Append(",           BIO_IT");
			Sql.Append(",           BIO_IR");
			Sql.Append(",           BIO_SI");
			Sql.Append(",           BIO_IW");
			Sql.Append(",           BIO_OTH");
			Sql.Append(",           BIO_ST");
			Sql.Append(",           BIO_ST");
			Sql.Append(" FROM       M_BIOGRAPHY");
			Sql.Append(" WHERE");
			if(!string.IsNullOrEmpty(EngineerId))
			{
				Sql.AppendFormat(" ENGINEER_ID  = '{0}'", EngineerId);
			}
			else
			{
				Sql.Append(" BIO_NO = '1'");
			}
			Sql.Append(" AND DEL_FLG ='0'");
			Sql.Append(" ORDER BY	BIO_NO");

			//選択クエリ
			return base.ExecuteSelect(Sql.ToString());
		}
		/// <summary>
		/// 技術者コンボ用の情報を取得する
		/// </summary>
		public DataTable SelectEngineerComboBox()
		{
			//SQL構築
			StringBuilder Sql = new StringBuilder();

			Sql.Append(" SELECT");
			Sql.Append("            ID");
			Sql.Append(",           NAME");
			Sql.Append(" FROM       M_ENGINEER");
			Sql.Append(" ORDER BY	NAME");

			//選択クエリ
			return base.ExecuteSelect(Sql.ToString());
		}
		/// <summary>
		/// ポジションコンボ用の情報を取得する
		/// </summary>
		public DataTable SelectPositionComboBox()
		{
			//SQL構築
			StringBuilder Sql = new StringBuilder();

			Sql.Append(" SELECT");
			Sql.Append("            CODE");
			Sql.Append(",           CONTENT");
			Sql.Append(" FROM       M_CODE AS MC");
			Sql.Append(" WHERE      MC.KBN = 'M21'");
			Sql.Append(" ORDER BY	CONTENT");

			//選択クエリ
			return base.ExecuteSelect(Sql.ToString());
		}
		/// <summary>
		/// 役割コンボ用の情報を取得する
		/// </summary>
		public DataTable SelectYakuwariComboBox()
		{
			//SQL構築
			StringBuilder Sql = new StringBuilder();

			Sql.Append(" SELECT");
			Sql.Append("            CODE");
			Sql.Append(",           CONTENT");
			Sql.Append(" FROM       M_CODE AS MC");
			Sql.Append(" WHERE      MC.KBN = 'M22'");
			Sql.Append(" ORDER BY	CONTENT");

			//選択クエリ
			return base.ExecuteSelect(Sql.ToString());
		}

		/// <summary>
		/// ハードリストボックス用の情報を取得する
		/// </summary>
		public DataTable SelectHardListBox()
		{
			//SQL構築
			StringBuilder Sql = new StringBuilder();

			Sql.Append(" SELECT");
			Sql.Append("            CODE");
			Sql.Append(",           CONTENT");
			Sql.Append(" FROM       M_CODE AS MC");
			Sql.Append(" WHERE      MC.KBN = 'M23'");
			Sql.Append(" ORDER BY	CONTENT");

			//選択クエリ
			return base.ExecuteSelect(Sql.ToString());
		}

		/// <summary>
		/// OSリストボックス用の情報を取得する
		/// </summary>
		public DataTable SelectOsListBox()
		{
			//SQL構築
			StringBuilder Sql = new StringBuilder();

			Sql.Append(" SELECT");
			Sql.Append("            CODE");
			Sql.Append(",           CONTENT");
			Sql.Append(" FROM       M_CODE AS MC");
			Sql.Append(" WHERE      MC.KBN = 'M24'");
			Sql.Append(" ORDER BY	CONTENT");

			//選択クエリ
			return base.ExecuteSelect(Sql.ToString());
		}

		/// <summary>
		/// コードリストボックス用の情報を取得する
		/// </summary>
		public DataTable SelectCordListBox()
		{
			//SQL構築
			StringBuilder Sql = new StringBuilder();

			Sql.Append(" SELECT");
			Sql.Append("            CODE");
			Sql.Append(",           CONTENT");
			Sql.Append(" FROM       M_CODE AS MC");
			Sql.Append(" WHERE      MC.KBN = 'M25'");
			Sql.Append(" ORDER BY	CONTENT");

			//選択クエリ
			return base.ExecuteSelect(Sql.ToString());
		}

		/// <summary>
		/// DBリストボックス用の情報を取得する
		/// </summary>
		public DataTable SelectDbListBox()
		{
			//SQL構築
			StringBuilder Sql = new StringBuilder();

			Sql.Append(" SELECT");
			Sql.Append("            CODE");
			Sql.Append(",           CONTENT");
			Sql.Append(" FROM       M_CODE AS MC");
			Sql.Append(" WHERE      MC.KBN = 'M26'");
			Sql.Append(" ORDER BY	CONTENT");

			//選択クエリ
			return base.ExecuteSelect(Sql.ToString());
		}

		/// <summary>
		/// ツールリストボックス用の情報を取得する
		/// </summary>
		public DataTable SelectToolListBox()
		{
			//SQL構築
			StringBuilder Sql = new StringBuilder();

			Sql.Append(" SELECT");
			Sql.Append("            CODE");
			Sql.Append(",           CONTENT");
			Sql.Append(" FROM       M_CODE AS MC");
			Sql.Append(" WHERE      MC.KBN = 'M27'");
			Sql.Append(" ORDER BY	CONTENT");

			//選択クエリ
			return base.ExecuteSelect(Sql.ToString());
		}
	}
}
