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
    /// 交通費精算書Mサービスクラス
    /// </summary>
    public class srvSal030
							: srvBase
	{
        /// <summary>
        /// 交通費精算情報MをDataGridView用に取得します
        /// </summary>
        /// <returns>取得結果のDataTable</returns>
        public DataTable SelectGridView()
        {
            try
            {
                //SQL文を構築
                StringBuilder Sql = new StringBuilder();

				Sql.Append(" SELECT	    0 as SEL0");
				if (clsDefine.OperatingStatus == OperatStatus.OFFLINE)
				{
					Sql.Append(",           CDATE(FORMAT(ACCRUAL_YMD,'@@@@/@@/@@')) AS 計上日");
				}
				else
				{
					Sql.Append(",           CONVERT(DateTime,ACCRUAL_YMD) AS 計上日");
				}
				Sql.Append(",           EX.EXPENSE_CD AS 経費項目コード");
				Sql.Append(",           EX.KINGAKU AS 金額");
				Sql.Append(",           EX.BIKO1 AS 備考1");
				Sql.Append(",           EX.BIKO2 AS 備考2");
				Sql.Append(",           EX.ORDER_NO　AS 受注No");
				Sql.Append(",           EX.TAX_KBN AS 税区分");
				Sql.Append(",           EX.BILLING_FLG AS 請求フラグ");
				Sql.Append(",           COD.CONTENT AS 区分");
                Sql.Append(" FROM       ( T_EXPENSE AS EX");
                Sql.Append(" INNER JOIN M_CODE AS COD");
                Sql.Append(" ON (       EX.EXPENSE_CD = COD.CODE");
                Sql.Append(" AND        COD.KBN = 'M10' ) )");
                Sql.Append(" WHERE      EX.DEL_FLG = 0");
				if (clsDefine.OperatingStatus == OperatStatus.OFFLINE)
				{
					Sql.Append(" AND        START_YMD <> ''");
				}
				Sql.Append(" Order By   EX.EXPENSE_CD");

                //選択クエリ実行
                return base.ExecuteSelect(Sql.ToString());
            }
            catch
            {
                throw;
            }
        }

		/// <summary>
		/// 交通費精算情報Mに追加します
		/// </summary>
		/// <param name="dto">frmSal030のDTO</param>
		public string Insert(dtoSal030 dto)
		{
			try
			{
					//SQL文を構築
					StringBuilder Sql = new StringBuilder();

					Sql.Append("INSERT INTO T_EXPENSE");
					Sql.Append("          ( ORDER_NO");
					Sql.Append(",           ACCRUAL_YMD");
					Sql.Append(",           EXPENSE _CD");
					Sql.Append(",           KINGAKU");
					Sql.Append(",           TAX_KBN");
					Sql.Append(",           BIKO1");
					Sql.Append(",           BIKO2");
					Sql.Append(",           BILLING_FLG");
					Sql.Append(",           DEL_FLG");
					Sql.Append(",           SYNC_FLG");
					Sql.Append(",           TIME_STAMP  ) ");
					Sql.Append(" VALUES");
					Sql.Append(" (");
					Sql.AppendFormat("  '{0}'", dto.ORDER_NO);
					Sql.AppendFormat(", '{0}'", dto.ACCRUAL_YMD);
					Sql.AppendFormat(", '{0}'", dto.EXPENSE_CD);
					Sql.AppendFormat(", '{0}'", dto.KINGAKU);
					Sql.AppendFormat(", '{0}'", dto.TAX_KBN);
					Sql.AppendFormat(", '{0}'", dto.BIKO1);
					Sql.AppendFormat(", '{0}'", dto.BIKO2);
					Sql.AppendFormat(", '{0}'", dto.BILLING_FLG);
					Sql.AppendFormat(", '{0}'", dto.DEL_FLG);
					Sql.AppendFormat(", '{0}'", dto.SYNC_FLG);
					Sql.AppendFormat(", '{0}'", dto.TIME_STAMP);
					Sql.Append(")");

				//SQL文を返却
				return Sql.ToString();
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 交通費精算情報Mのを更新します
		/// </summary>
		/// <param name="dto">Mnt100用のDTO</param>
		public string Update(dtoSal030 dto)
        {
			try
			{
				//SQL文を構築
				StringBuilder Sql = new StringBuilder();

				Sql.Append("       UPDATE T_EXPENSE");
				Sql.AppendFormat(" SET        ORDER_NO = '{0}'     ", dto.ORDER_NO);
				Sql.AppendFormat(",           ACCRUAL_YMD = '{0}'  ", dto.ACCRUAL_YMD);
				Sql.AppendFormat(",           EXPENSE_CD = '{0}'   ", dto.EXPENSE_CD);
				Sql.AppendFormat(",           KINGAKU = '{0}'      ", dto.KINGAKU);
				Sql.AppendFormat(",           TAX_KBN = '{0}'      ", dto.TAX_KBN);
				Sql.AppendFormat(",           BIKO1 = '{0}'        ", dto.BIKO1);
				Sql.AppendFormat(",           BIKO2 = '{0}'        ", dto.BIKO2);
				Sql.AppendFormat(",           BILLING_FLG = '{0}'  ", dto.BILLING_FLG);
				Sql.AppendFormat(",           DEL_FLG = {0}        ", dto.DEL_FLG);
				Sql.AppendFormat(",           SYNC_FLG = {0}       ", dto.SYNC_FLG);
				Sql.AppendFormat(",           TIME_STAMP = '{0}'   ", dto.TIME_STAMP);
				Sql.AppendFormat("  WHERE     ORDER_NO =  '{0}'    ", dto.ORDER_NO);

				//SQL文を返却
				return Sql.ToString();
			}
			catch
			{
				throw;
			}
        }

		/// <summary>
		/// 交通費精算情報Mの削除(0→1に論理削除)
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
                        Sql.AppendFormat("UPDATE T_EXPENSE");
                        // SET
                        Sql.AppendFormat(" SET DEL_FLG = '1'");
                        // WHERE
                        Sql.AppendFormat(" WHERE EXPENSE_CD = '{0}'", row["dgv_ym"].ToString());

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
        /// コード区分Mからの取得
        /// </summary>
        /// <param name="DataKbn">カテゴリ区分</param>
        /// <returns>取得結果のDataTable</returns>
        public DataTable SelectCodeM(string Kbn)
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
		/// 交通費精算情報Mの主キーが重複していないかチェックします
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
				Sql.Append("       From   T_EXPENSE");
				Sql.AppendFormat(" Where  CODE = '{0}'", pkey);

				//選択クエリ
				return base.ExecuteSelect(Sql.ToString());
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 主キーの存在の有無からSQL文(メソッド)の切り替えを行い、SQLを構築します
		/// </summary>
		/// <param name="dtoList">DTOのList</param>
		public void ChangeSQL(List<dtoSal030> dtoList)
		{
			//複数のSQL文のListを構築
			List<string> sqlList = new List<string>();

			//DTOListからSQLを構築
			foreach (dtoSal030 dto in dtoList)
			{
				//主キー重複チェック結果からメソッドの切り替え
				if (this.ChkPkey(dto.ACCRUAL_YMD).Rows.Count > 0)
				{
					//存在すればUPDATE文を構築
					sqlList.Add(this.Update(dto));
				}
				else
				{
					//存在しなければINSERT文を構築
					sqlList.Add(this.Insert(dto));
				}
			}

			//複数アクションクエリ実行
			base.ExecuteAction(sqlList);
		}

		/// <summary>
		/// テスト用メソッド
		/// </summary>
		/// <param name="switch_on">1：START_YMD,'@@@@/@@/@@'2：TAX_RATE</param>
		/// <returns></returns>
		public DataTable TestSelect(double switch_on)
		{
			try
			{
				//SQL構築
				StringBuilder Sql = new StringBuilder();

				switch (switch_on)
				{
					case 1:
						Sql.Append("Select CDATE(FORMAT(START_YMD,'@@@@/@@/@@')) AS A" +
							"       FROM   T_ORDER" +
							"       WHERE  START_YMD <> ''");
						break;

					case 1.5:
						Sql.Append(" SELECT CONVERT(DATETIME,START_YMD) AS A");
						Sql.Append(" FROM   T_ORDER");
						Sql.Append(" WHERE  START_YMD <> '' ");
						break;

					case 2 :
						Sql.Append("SELECT   " +
										"  CODE" +
										", CONVERT(VARCHAR, TAX_RATE) + '%' AS 税区分" +
									"FROM    M_TAX");
						break;
				}

				//選択クエリ実行
				return base.ExecuteSelect(Sql.ToString());
			}
			catch 
			{
				throw;
			}
		}
	}
}
