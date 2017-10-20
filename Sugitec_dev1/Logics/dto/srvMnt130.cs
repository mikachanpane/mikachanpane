using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Sugitec;
using Sugitec.Common;

namespace Sugitec.Logics
{
	/// <summary>
	/// 
	/// </summary>
	public class srvMnt130 : srvBase
	{
		/// <summary>
		/// 得意先担当者Mへの追加をします
		/// </summary>
		/// <param name="dto">frmMnt130のテキストボックス</param>
		public void Insert(dtoMnt130 dto)
		{
			try
			{
				//SQL文を構築
				System.Text.StringBuilder Sql = new StringBuilder();
								
				Sql.Append("INSERT INTO M_CONTACT");
				Sql.Append(" (          CUSTOMER_CODE");
				Sql.Append(",           CONTACT_NAME");
				Sql.Append(",           CONTACT_CODE");
				Sql.Append(",           [SECTION]");
				Sql.Append(",           DEL_FLG");
				Sql.Append(",           SYNC_FLG");
				Sql.Append(",           TIME_STAMP ) ");
				Sql.Append(" VALUES");
				Sql.Append(" (");
				Sql.AppendFormat("  '{0}'"	, dto.CustomerCode);
				Sql.AppendFormat(", '{0}'"	, dto.ConName);
				Sql.AppendFormat(", '{0}'"	, dto.ConCod);
				Sql.AppendFormat(", '{0}'"	, dto.Section);
				Sql.AppendFormat(", {0}"	, dto.Delflg);
				Sql.AppendFormat(", {0}"	, dto.SynFlg);
				Sql.AppendFormat(", '{0}'"	, dto.TimeSta);
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
		/// 得意先担当者Mの更新をします
		/// </summary>
		/// <param name="dto">frmMnt130用のテキストボックス</param>
		public void Update(dtoMnt130 dto)
		{
			try
			{
				//SQL文を構築
				System.Text.StringBuilder Sql = new StringBuilder();

				Sql.Append("      UPDATE M_CONTACT");
				Sql.Append("      SET ");
				Sql.AppendFormat("       CONTACT_NAME = '{0}' ", dto.ConName);
				Sql.AppendFormat(",      [SECTION] = '{0}'      ", dto.Section);
				Sql.AppendFormat(",      DEL_FLG = {0}        ", dto.Delflg);
				Sql.AppendFormat(",      SYNC_FLG = {0}       ", dto.SynFlg);
				Sql.AppendFormat(",      TIME_STAMP = '{0}'   ", dto.TimeSta);
				Sql.AppendFormat(" Where CONTACT_CODE = '{0}' ", dto.ConCod);

				//アクションクエリ
				ExecuteAction(Sql.ToString());
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 得意先担当者Mの削除をします（0→1へにする論理削除）
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
					//  チェックボックスの入った行のCODE を探す
					if(row[0].ToString() == "1")
					{
						Sql.Clear();												
						Sql.AppendFormat(" UPDATE  M_CONTACT");						
						Sql.AppendFormat(" SET     DEL_FLG = 1");						// WHERE
						Sql.AppendFormat(" WHERE   CONTACT_CODE = '{0}'", row["CONTACT_CODE"].ToString());

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
		/// 得意先担当者Mを取得します（DataGridView用）
		/// </summary>
		/// <param name="dto">frmMnt130のテキストボックス</param>
		/// <returns>DataGridView.DataSource用</returns>
		public DataTable SelectCustomerM(string cusCode)
		{
			//SQL構築
			StringBuilder Sql = new StringBuilder();

			Sql.Append("       Select");
			Sql.Append("               0 As SEL0");
			Sql.Append(",              CUSTOMER_CODE");
			Sql.Append(",              CONTACT_CODE");
			Sql.Append(",              [SECTION]");	
			Sql.Append(",              CONTACT_NAME");
			Sql.Append("       From    M_CONTACT");
			Sql.Append("       Where   DEL_FLG = 0");
			if(!string.IsNullOrEmpty(cusCode))
			{
				Sql.AppendFormat(" And     CUSTOMER_CODE = '{0}'", cusCode);
			}

			return base.ExecuteSelect(Sql.ToString());
		}

		/// <summary>
		/// コンボボックスのための得意先Mのコードと名称を全て取得します
		/// </summary>
		/// <returns>M_CUSTOMER.CODE、M_CUSTOMER.NAME</returns>
		public DataTable SelectComboBox()
		{
			//SQL構築
			StringBuilder Sql = new StringBuilder();

			Sql.Append(" Select");
			Sql.Append("            CODE");
			Sql.Append(",           NAME");
			Sql.Append(" From       M_CUSTOMER");
			Sql.Append(" Order By	NAME");

			//選択クエリ
			return base.ExecuteSelect(Sql.ToString());
		}

		/// <summary>
		/// 主キーが重複していないかチェックします
		/// </summary>
		/// <param name="pkey">検索対象の主キー</param>
		/// <returns>pkeyが存在していれば返ります</returns>
		public DataTable ChkPkey(string pkey)
		{
			try
			{
				//SQL構築
				StringBuilder Sql = new StringBuilder();

				Sql.Append("       Select");
				Sql.Append("              CONTACT_CODE");
				Sql.Append("       From   M_CONTACT");
				Sql.AppendFormat(" Where  CONTACT_CODE = '{0}'", pkey);

				//選択クエリ
				return base.ExecuteSelect(Sql.ToString());
			}
			catch
			{
				throw;
			}
		}
	}
}
