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
    /// 得意先Mサービスクラス
    /// ここには基本的にDBの操作を記述してください　内容：取得、追加、更新、削除、取得(コンボボックス)
    /// </summary>
    public class srvMnt100 : srvBase
    {
        /// <summary>
        /// 得意先Mの取得
        /// DataGridView、テキストボックス に必要なデータを取得します
        /// 削除フラグが”1”の行は除外します
        /// </summary>
        /// <returns>取得結果のDataTable</returns>
        public DataTable Select()
        {
            try
            {
                //SQL文を構築
                StringBuilder Sql = new StringBuilder();

				Sql.Append(" SELECT	    0 as SEL0");
				Sql.Append(",           A.CODE");
				Sql.Append(",           A.NAME");
				Sql.Append(",           A.KANA");
				Sql.Append(",           A.TEL");
				Sql.Append(",           A.FAX");
				Sql.Append(",           A.POST");
				Sql.Append(",           A.ADDRESS1");
				Sql.Append(",			A.ADDRESS2");
				Sql.Append(",           A.CUTOFF_DAY");
				Sql.Append(",           A.PAYMENT_KBN");
				Sql.Append(",           A.PAYMENT_DAY");
				Sql.Append(",           B.CONTENT");
                Sql.Append(" FROM       M_CUSTOMER AS A");
                Sql.Append(" INNER JOIN M_CODE AS B");
                Sql.Append(" ON (       A.PAYMENT_KBN = B.CODE");
                Sql.Append(" AND        B.KBN = 'A01' )");
                Sql.Append(" WHERE      A.DEL_FLG = 0");
				Sql.Append(" Order By   A.CODE");

                //選択クエリ
                return base.ExecuteSelect(Sql.ToString());
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 得意先Mの追加
        /// テキストボックスの中身を全て追加し、更新します
        /// </summary>
        /// <param name="dto">Mnt100用のDTO</param>
        public void Insert(dtoMnt100 dto)
        {
            try
            {
                //SQL文を構築
                System.Text.StringBuilder Sql = new StringBuilder();

                //  INSERT
                Sql.Append("INSERT INTO M_CUSTOMER");
				Sql.Append("          ( CODE");
				Sql.Append(",           NAME");
				Sql.Append(",           KANA");
				Sql.Append(",           POST");
				Sql.Append(",           ADDRESS1");
				Sql.Append(",           ADDRESS2");
				Sql.Append(",           TEL");
				Sql.Append(",           FAX");
				Sql.Append(",           CUTOFF_DAY");
				Sql.Append(",           PAYMENT_KBN");
				Sql.Append(",           PAYMENT_DAY");
				Sql.Append(",           DEL_FLG");
				Sql.Append(",           SYNC_FLG");
				Sql.Append(",           TIME_STAMP  ) ");
				Sql.Append(" VALUES");
				Sql.Append(" (");
                Sql.AppendFormat("  '{0}'", dto.Code);
                Sql.AppendFormat(", '{0}'", dto.Name);
                Sql.AppendFormat(", '{0}'", dto.Kana);
                Sql.AppendFormat(", '{0}'", dto.Post);
                Sql.AppendFormat(", '{0}'", dto.Address1);
				Sql.AppendFormat(", '{0}'", dto.Address2);
                Sql.AppendFormat(", '{0}'", dto.Tel);
                Sql.AppendFormat(", '{0}'", dto.FAX);
                Sql.AppendFormat(", '{0}'", dto.Sime);
                Sql.AppendFormat(", '{0}'", dto.Paykbn);
                Sql.AppendFormat(", '{0}'", dto.Payment);
                Sql.AppendFormat(", '0'");                 //　削除フラグ
                Sql.AppendFormat(", {0}", dto.SYNC_FLG);
                Sql.AppendFormat(",'{0}'", dto.TIME_STAMP);
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
        /// 得意先Mの更新
        /// テキストボックスの中身を使ってください 無ければ空文字で発行されます
        /// 修正したい行を修正し、更新します
        /// </summary>
        /// <param name="dto">Mnt100用のDTO</param>
        public void Update(dtoMnt100 dto)
        {
            try
            {
                //SQL文を構築
                System.Text.StringBuilder Sql = new StringBuilder();

                Sql.Append("       UPDATE     M_CUSTOMER");
				Sql.AppendFormat(" SET        NAME = '{0}'       ", dto.Name);
				Sql.AppendFormat(",           KANA = '{0}'       ", dto.Kana);
				Sql.AppendFormat(",           ADDRESS1 = '{0}'   ", dto.Address1);
				Sql.AppendFormat(",           ADDRESS2 = '{0}'   ", dto.Address2);
				Sql.AppendFormat(",           TEL = '{0}'        ", dto.Tel);
				Sql.AppendFormat(",           FAX = '{0}'        ", dto.FAX);
				Sql.AppendFormat(",           CUTOFF_DAY = '{0}' ", dto.Sime);
				Sql.AppendFormat(",           PAYMENT_KBN = '{0}'", dto.Paykbn);
				Sql.AppendFormat(",           PAYMENT_DAY = '{0}'", dto.Payment);
				Sql.Append("      ,           DEL_FLG = 0");
				Sql.AppendFormat(",           SYNC_FLG = {0}     ", dto.SYNC_FLG);
				Sql.AppendFormat(",           TIME_STAMP = '{0}' ", dto.TIME_STAMP);

				//整形
				//Masked text box の中身 "   -" → "" へ修正
				if(dto.Post.Trim() == "-")
				{
					Sql.AppendFormat(",       POST = ''");
				}
				else
				{
					Sql.AppendFormat(",       POST = '{0}'", dto.Post);
				}
				Sql.AppendFormat("  WHERE     CODE =  '{0}'", dto.Code);

                //更新を実行
                ExecuteAction(Sql.ToString());
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 得意先Mの削除 
        /// ０→1に削除フラグを変更する論理削除を実行します
        /// </summary>
        /// <param name="dt">データテーブル</param>
        public void Delete(DataTable dt)
        {
            try
            {
                List<string> SqlList = new List<string>();
                StringBuilder Sql = new StringBuilder();

                //削除対象のSQLを構築
                foreach (DataRow row in dt.Rows)
                {
                    //  チェックボックスの入った行のCODE を探す
                    if (row[0].ToString() == "1")
                    {
                        Sql.Clear();

                        // UPDATE
                        Sql.AppendFormat("UPDATE M_CUSTOMER");
                        // SET
                        Sql.AppendFormat(" SET DEL_FLG = '1'");
                        // WHERE
                        Sql.AppendFormat(" WHERE CODE = '{0}'", row[1].ToString());

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
        /// コード区分Mの取得
        /// コンボボックスに表示させたい区分をDataTable型で取得する拡張機能です
        /// </summary>
        /// <param name="DataKbn">カテゴリ区分</param>
        /// <returns>取得結果のDataTable</returns>
        public DataTable GetCodeM(string Kbn)
        {
            try
            {
                //SQL文を構築
                StringBuilder Sql = new StringBuilder();
                Sql.AppendFormat("Select CODE, CONTENT");
                Sql.AppendFormat("  From M_CODE ");
                Sql.AppendFormat(" Where KBN  = '{0}'",Kbn);
                Sql.AppendFormat("   And CODE <> '00'");

                //結果を取得
                return base.ExecuteSelect(Sql.ToString());

            }
            catch
            {
                throw;
            }
        }

		/// <summary>
		/// 得意先Mの主キーが重複していないかチェックします
		/// </summary>
		/// <param name="pkey">検索対象の主キー（txt_Cod）</param>
		/// <returns>pkeyが存在していれば返ります</returns>
		public DataTable ChkPkey(string pkey)
		{
			try
			{
				//SQL構築
				StringBuilder Sql = new StringBuilder();

				Sql.Append("       Select");
				Sql.Append("              CODE");
				Sql.Append("       From   M_CUSTOMER");
				Sql.AppendFormat(" Where  CODE = '{0}'", pkey);

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
