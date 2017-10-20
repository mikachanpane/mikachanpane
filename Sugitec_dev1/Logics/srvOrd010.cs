using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sugitec.Common;
using Sugitec.Logics;
using System.Data;

namespace Sugitec.Logics
{

    /// <summary>
    /// このクラスでは基本的にSQLを発行してクエリを実行します
    /// </summary>
    public class srvOrd010
                    : srvBase
    {

		/// <summary>
		///　受注Tの更新をかけます
		/// </summary>
		/// <param name="dto">検索条件</param>
		/// <returns>検索結果</returns>
		public void Insert( dtoOrd010 dto )
		{
			try
			{
				//  SQL文を構築
				StringBuilder Sql = new StringBuilder();

				Sql.AppendFormat("INSERT	INTO T_ORDER");			//  Insert
				Sql.AppendFormat(" VALUES");						//  Values
				Sql.AppendFormat(" (");

				Sql.AppendFormat("  '{0}'", base.NumberingOrder(dto.ORDER_YMD));
				Sql.AppendFormat(", '{0}'", dto.ORDER_YMD);
				Sql.AppendFormat(", '{0}'", dto.CUSTOMER_CD);
				Sql.AppendFormat(", '{0}'", dto.CONTACT_CODE);
                Sql.AppendFormat(", '{0}'", dto.CUSTOMER_ORDER_NO);
                Sql.AppendFormat(", '{0}'", dto.PROJECT_NM);
				Sql.AppendFormat(", '{0}'", dto.WORK_NM);
				Sql.AppendFormat(", '{0}'", dto.WORK_SPACE);
				Sql.AppendFormat(", '{0}'", dto.CONTRACT_TYP);
                Sql.AppendFormat(", '{0}'", dto.INVOICE_FILE_NM);
                Sql.AppendFormat(", '{0}'", dto.ENGINEER_ID);
				Sql.AppendFormat(", '{0}'", dto.ACTUARIAL_KBN);
				Sql.AppendFormat(", '{0}'", dto.START_YMD);
				Sql.AppendFormat(", '{0}'", dto.END_YMD);
				Sql.AppendFormat(", {0}",	dto.UPPER_LIMIT);
                Sql.AppendFormat(", {0}",   dto.LOWER_LIMIT);
                Sql.AppendFormat(", {0}",	dto.BASE_RATE);
				Sql.AppendFormat(", {0}",	dto.ORVER_RATE);
				Sql.AppendFormat(", {0}",	dto.SUBTRACT_RATE);
				Sql.AppendFormat(", '{0}'", dto.PROJECT_NO);
				Sql.AppendFormat(", {0}",	dto.DEL_FLG);
				Sql.AppendFormat(", {0}",	dto.SYNC_FLG);
				Sql.AppendFormat(", '{0}'", dto.TIME_STAMP);

				Sql.Append(")");


				//  更新を実行
				ExecuteAction(Sql.ToString());
			}
			catch
			{
				throw;
			}
		}
	
		/// <summary>
		/// 変更した画面項目を受注Tへ更新する
		/// </summary>
		/// <param name="dto">条件</param>
		public void UPDATE( dtoOrd010 dto )
		{
			try
			{
				//  SQL構築
				StringBuilder sql = new StringBuilder();
				
				sql.AppendFormat("Update	T_ORDER");									//  Update								
				sql.AppendFormat(" Set		ORDER_YMD		= '{0}'", dto.ORDER_YMD);   //  Set
				sql.AppendFormat(",			CUSTOMER_ORDER_NO = '{0}'", dto.CUSTOMER_ORDER_NO);
				sql.AppendFormat(",			CUSTOMER_CD		= '{0}'", dto.CUSTOMER_CD);
				sql.AppendFormat(",			CONTACT_CODE	= '{0}'", dto.CONTACT_CODE);
				sql.AppendFormat(",			PROJECT_NM		= '{0}'", dto.PROJECT_NM);
				sql.AppendFormat(",			WORK_NM			= '{0}'", dto.WORK_NM);
				sql.AppendFormat(",			WORK_SPACE		= '{0}'", dto.WORK_SPACE);
				sql.AppendFormat(",			CONTRACT_TYP	= '{0}'", dto.CONTRACT_TYP);
                sql.AppendFormat(",			INVOICE_FILE_NM	= '{0}'", dto.INVOICE_FILE_NM);
                sql.AppendFormat(",			ENGINEER_ID		= '{0}'", dto.ENGINEER_ID);
				sql.AppendFormat(",			ACTUARIAL_KBN	= '{0}'", dto.ACTUARIAL_KBN);
				sql.AppendFormat(",			START_YMD		= '{0}'", dto.START_YMD);
				sql.AppendFormat(",			END_YMD			= '{0}'", dto.END_YMD);
				sql.AppendFormat(",			UPPER_LIMIT		= {0}"	, dto.UPPER_LIMIT);
				sql.AppendFormat(",			LOWER_LIMIT		= {0}"	, dto.LOWER_LIMIT);
				sql.AppendFormat(",			BASE_RATE		= {0}"	, dto.BASE_RATE);
				sql.AppendFormat(",			ORVER_RATE		= {0}"	, dto.ORVER_RATE);
				sql.AppendFormat(",			SUBTRACT_RATE	= {0}"	, dto.SUBTRACT_RATE);
				sql.AppendFormat(",			PROJECT_NO		= '{0}'", dto.PROJECT_NO);
				sql.AppendFormat(",			DEL_FLG			= {0}"	, dto.DEL_FLG);
				sql.AppendFormat(",			SYNC_FLG		= {0}"	, dto.SYNC_FLG);
				sql.AppendFormat(",			TIME_STAMP		= '{0}'", dto.TIME_STAMP);			
				sql.AppendFormat(" Where	ORDER_NO		= '{0}'", dto.ORDER_NO);	//  Where

				// Query
				base.ExecuteAction(sql.ToString());
			}
			catch
			{
				throw;
			}

		}

		/// <summary>
		/// 受注Tの削除フラグを更新します
		/// 論理削除（’０’→’１’）して下さい
		/// </summary>
		/// <param name="dto">主キー</param>
		public void DELETE( dtoOrd010 dto )
		{
			try
			{
				StringBuilder Sql = new StringBuilder();

				//削除対象のSQLを構築
				Sql.Clear();
								
				Sql.AppendFormat("Update	T_ORDER");							// UPDATE								
				Sql.AppendFormat(" Set		DEL_FLG = '1'");					// SET				
				Sql.AppendFormat(" Where	ORDER_NO = '{0}'", dto.ORDER_NO);	// WHERE

				//更新を実行
				ExecuteAction(Sql.ToString());
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 受注No を受け取り、Tを返します 得意先M.得意先名と技術者M.技術者名 も取得します
		/// dto.PROJECT_NO の値を設定してください
		/// </summary>
		/// <returns>検索結果</returns>
		public DataTable SelectAllT_ORDER(dtoOrd010 dto)
		{
			try
			{
				//  SQL構築
				StringBuilder sql = new StringBuilder();

				//  テキストボックスの上から順に原則的に並べてあります 1行目：技術者情報以外　2行目：技術者情報
				sql.Append(" SELECT		");
				sql.Append("		O.ORDER_NO, ");
				sql.Append("		O.CUSTOMER_CD,");
				sql.Append("		O.CUSTOMER_ORDER_NO,");
				sql.Append("		C.NAME As CusNAME,");
				sql.Append("		O.CONTACT_CODE,");
				sql.Append("		O.PROJECT_NM,");
				sql.Append("		O.WORK_NM,");
				sql.Append("		O.WORK_SPACE,");
				sql.Append("		O.CONTRACT_TYP,");
				sql.Append("		O.INVOICE_FILE_NM,");
				sql.Append("		O.ENGINEER_ID,");
				sql.Append("		E.NAME As EngNAME,");
				sql.Append("		O.ACTUARIAL_KBN,");
				sql.Append("		O.LOWER_LIMIT,");
				sql.Append("		O.UPPER_LIMIT,");
				sql.Append("		O.BASE_RATE,");
				sql.Append("		O.ORVER_RATE,");
				sql.Append("		O.SUBTRACT_RATE");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sql.Append(",				IIF(O.ORDER_YMD = '','',FORMAT(CONVERT(DateTime,O.ORDER_YMD),'yyyy/MM/dd')) AS ORDER_YMD1");//  Format
                    sql.Append(",				IIF(O.START_YMD = '','',FORMAT(CONVERT(DateTime,O.START_YMD),'yyyy/MM/dd')) AS START_YMD1");
                    sql.Append(",				IIF(O.END_YMD = '','',FORMAT(CONVERT(DateTime,O.END_YMD),'yyyy/MM/dd')) AS END_YMD1");
                }
                else
                {
                    sql.Append(",				FORMAT(O.ORDER_YMD,'@@@@/@@/@@') AS ORDER_YMD1");//  Format
                    sql.Append(",				FORMAT(O.START_YMD,'@@@@/@@/@@') AS START_YMD1");
                    sql.Append(",				FORMAT(O.END_YMD,'@@@@/@@/@@') AS END_YMD1");
                }
				sql.Append(" FROM			((T_ORDER AS O");							//  From
				sql.Append(" INNER JOIN	M_CUSTOMER AS C");					//  Join
				sql.Append(" ON			O.CUSTOMER_CD = C.CODE)");					//  On
				sql.Append(" INNER JOIN	M_ENGINEER AS E");
				sql.Append(" ON			O.ENGINEER_ID = E.ID)");
				sql.Append(" WHERE		O.DEL_FLG = 0");									//  Where

				//  And
				if (string.IsNullOrEmpty(dto.ORDER_NO))
				{
					sql.Append(" And O.ORDER_NO = ''");
				}
				else
				{
					sql.AppendFormat(" And O.ORDER_NO = '{0}'", dto.ORDER_NO);
				}

				//  選択クエリ
				return base.ExecuteSelect(sql.ToString());
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 受け取った得意先IDからM_CUSTOMER を返します IDを渡して下さい
		/// </summary>
		/// <param name="dto"></param>
		/// <returns>ID、NAME</returns>
		public DataTable SelectM_CUSTOMER( dtoOrd010 dto )
        {
            try
            {
                //  SQL文を構築
                StringBuilder Sql = new StringBuilder();

                Sql.AppendFormat("SELECT	CODE, NAME");						// Select
                Sql.AppendFormat(" FROM		M_CUSTOMER");						// From
                Sql.AppendFormat(" WHERE	CODE = '{0}'", dto.CUSTOMER_CD);	// Where

                //  結果を取得
                return base.ExecuteSelect(Sql.ToString());
            }
            catch
            {
                throw;
            }

        }

        /// <summary>
        /// 技術者コード を受け取り（DTO）、表示内容を返します　コードを渡して下さい
        /// </summary>
        /// <returns>TextBox</returns>
        public DataTable SelectM_Engineer( string id )
        {
			try
			{
				//  SQL文を構築
				StringBuilder Sql = new StringBuilder();
								
				Sql.AppendFormat("SELECT	ID, NAME");            //  SELECT															
				Sql.AppendFormat(" FROM		M_ENGINEER");           // FROM															
				Sql.AppendFormat(" WHERE	ID = '{0}'", id);		// WHERE

				//  結果を取得
				return base.ExecuteSelect(Sql.ToString());
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// コンボボックスの中身を取得します
		/// </summary>
		/// <param name="Kbn"></param>
		/// <returns>ComboBox</returns>
		public DataTable SelectM_CODEComboBox( string section )
        {
            try
            {
                //  SQL文を構築
                StringBuilder Sql = new StringBuilder();
                Sql.AppendFormat("Select	CODE, CONTENT");
                Sql.AppendFormat(" From		M_CODE ");
                Sql.AppendFormat(" Where	KBN  = '{0}'", section);
                Sql.AppendFormat(" And		CODE <> '00'");

                //  結果を取得
                return base.ExecuteSelect(Sql.ToString());

            }
            catch
            {
                throw;
            }

        }

        /// <summary>
        /// 売上情報の存在チェック
        /// </summary>
        /// <param name="Ord_NO">受注№</param>
        /// <returns>0：存在しない、1；存在する、2：請求データ作成済</returns>
        public int CheckSales(string Ord_NO)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("SELECT SALES_NO,BILLING_FLG FROM T_SALES ");
                sb.AppendFormat(" WHERE ORDER_NO = '{0}' ", Ord_NO);
                sb.AppendFormat("   AND DEL_FLG  = 0 ");
                sb.AppendFormat(" ORDER BY BILLING_FLG DESC");
                DataTable dt = base.ExecuteSelect(sb.ToString());

                if (dt.Rows.Count > 0)
                {
                    if(dt.Rows[0]["BILLING_FLG"].ToIntlEx() == 1)
                    {
                        return 2;
                    }
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                throw;
            }
        }

        public string CheckDuring(dtoOrd010 dto)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat(" SELECT ");
                sb.AppendFormat("     O.ORDER_NO ");
                sb.AppendFormat("    ,C.NAME ");
                sb.AppendFormat("    ,O.PROJECT_NM ");
                sb.AppendFormat("    ,O.WORK_NM ");
                if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
                {
                    sb.AppendFormat("    ,IIF(O.START_YMD = '','',FORMAT(CONVERT(DateTime,O.START_YMD),'yyyy/MM/dd')) AS START_YMD ");
                    sb.AppendFormat("    ,IIF(O.END_YMD = '','',FORMAT(CONVERT(DateTime,O.END_YMD),'yyyy/MM/dd'))   AS END_YMD ");
                }
                else
                {
                    sb.AppendFormat("    ,FORMAT(O.START_YMD,'@@@@/@@/@@') AS START_YMD ");
                    sb.AppendFormat("    ,FORMAT(O.END_YMD,'@@@@/@@/@@')   AS END_YMD ");
                }
                sb.AppendFormat("   FROM T_ORDER AS O INNER JOIN M_CUSTOMER C ");
                sb.AppendFormat("     ON O.CUSTOMER_CD = C.CODE ");
                sb.AppendFormat("  WHERE O.DEL_FLG = 0 ");
                sb.AppendFormat("    AND O.ORDER_NO <> '{0}' ", dto.ORDER_NO);
                sb.AppendFormat("    AND O.ENGINEER_ID = '{0}' ", dto.ENGINEER_ID);
                sb.AppendFormat("    AND ('{0}' BETWEEN O.START_YMD AND O.END_YMD ",dto.START_YMD);
                sb.AppendFormat("     OR  '{0}' BETWEEN O.START_YMD AND O.END_YMD) ",dto.END_YMD);
                sb.AppendFormat("  ORDER BY O.ORDER_NO ");

                DataTable dt = base.ExecuteSelect(sb.ToString());

                if (dt.Rows.Count == 0)
                {
                    return string.Empty;
                }

                StringBuilder Msg = new StringBuilder();
                StringBuilder MsgRow = new StringBuilder();

                Msg.AppendLine("対象技術者に対して期間が重複しています。");
                Msg.AppendLine("登録して宜しいですか？");
                Msg.AppendLine("");
                MsgRow.Clear();
                MsgRow.Append("受注№  ");
                //MsgRow.Append("   得意先                        ");
                //MsgRow.Append(" 案件名                        ");
                //MsgRow.Append(" 作業先                        ");
                MsgRow.Append("      期　間");
                Msg.AppendLine(MsgRow.ToString());

                foreach (DataRow row in dt.Rows)
                {
                    MsgRow.Clear();
                    MsgRow.AppendFormat("{0}", row["ORDER_NO"].ToString());
                    //MsgRow.AppendFormat(" {0}", row["NAME"].ToString().PadRight(40, ' ').LeftBEx(30));
                    //MsgRow.AppendFormat(" {0}", row["PROJECT_NM"].ToString().PadRight(40, ' ').LeftBEx(30));
                    //MsgRow.AppendFormat(" {0}", row["WORK_NM"].ToString().PadRight(40, ' ').LeftBEx(30));
                    MsgRow.AppendFormat("   {0}～{1}", row["START_YMD"].ToString(), row["END_YMD"].ToString());
                    Msg.AppendLine(MsgRow.ToString());
                }
                return Msg.ToString();

            }
            catch
            {
                throw;
            }





        }

        public DataTable SelectM_CONTACTComboBox(string CusCode)
        {
            try
            {
                //  SQL文を構築
                StringBuilder Sql = new StringBuilder();
                Sql.AppendFormat("Select	CONTACT_CODE, CONTACT_NAME");
                Sql.AppendFormat(" From		M_CONTACT ");
                Sql.AppendFormat(" Where	CUSTOMER_CODE  = '{0}'", CusCode);

                //  結果を取得
                return base.ExecuteSelect(Sql.ToString());

            }
            catch
            {
                throw;
            }

        }
    }
}
