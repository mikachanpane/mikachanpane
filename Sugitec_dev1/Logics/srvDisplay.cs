using System;
using System.Text;
using System.Data;

using Sugitec;
using Sugitec.Common;

namespace Sugitec.Logics
{
    /// <summary>
    /// frm○○○のサービス
    /// </summary>
    public class srvDisplay
                        : srvBase
    {
        #region

        /// <summary>
        /// DataGridViewに表示するデータを取得します
        /// </summary>
        /// <param name="dto">dto○○○</param>
        /// <returns>dgv_result.DataSource</returns>
        public DataTable SelectGridView(dtoDisplay dto)
        {
            try
            {
                //Sqlを構築
                StringBuilder Sql = new StringBuilder();

				//ACCESS
				if (clsDefine.OperatingStatus == OperatStatus.OFFLINE)
				{
					Sql.Append(" SELECT ");
					Sql.Append("            T_MAIN.ORDER_NO AS 受注No ");
					Sql.Append(" 		  , SAL.SALES_NO AS 売上No ");
					Sql.Append(" 		  , SAL.SALES_AMOUNT");
					Sql.Append("          ,  FORMAT(SAL.SALES_YM, '@@@@/@@') AS 売上年月");
					Sql.Append(" 		  , REQD.REQUEST_NO AS 請求No");
					Sql.Append(" 		  , CUS.NAME AS 得意先名");
					Sql.Append(" 		  , ENG.NAME AS 技術者名");
					Sql.Append(" 		  , FORMAT(T_MAIN.CONTENT, '@@@@/@@') AS 受注日");
					Sql.Append("          , iif(SAL.SALES_AMOUNT IS NOT NULL, '登録済', '') AS 売上状態");
					Sql.Append("          , iif(SAL.BILLING_FLG = 1, '計算済', '') AS 請求状態");
					Sql.Append("          , iif(REQD.FINISH_FLG = 1, '回収済', '') AS 回収状態");
					Sql.Append("          , iif(REQD.PUBLISH_FLG = 1, '発行済', '') AS 請求書");
					Sql.Append(" FROM((((");
					Sql.Append("    (");
					Sql.Append(" 	select");
					Sql.Append(" 				 ORD.ORDER_NO");
					Sql.Append(" 			   , ORD.CUSTOMER_CD");
					Sql.Append(" 			   , ORD.ENGINEER_ID");
					Sql.Append(" 			   , COD.CONTENT");
					Sql.Append(" 	From ( T_ORDER ORD");
					Sql.Append("    INNER JOIN");
					Sql.Append(" 			  M_CODE COD ON");
					Sql.Append(" 			       ( MID(ORD.START_YMD, 1, 6) <= COD.CONTENT");
					Sql.Append(" 		        AND  MID(ORD.END_YMD, 1, 6) >= COD.CONTENT");
					Sql.Append(" 		        AND  COD.KBN = 'X01') )");
					Sql.Append("    ) AS T_MAIN");
					Sql.Append("  Left JOIN T_SALES SAL ON ( T_MAIN.ORDER_NO = SAL.ORDER_NO");
					Sql.Append(" 						AND  T_MAIN.CONTENT = SAL.SALES_YM ) )");
					Sql.Append("  Left Join    T_REQUEST_DTL REQD ON ( T_MAIN.ORDER_NO = REQD.ORDER_NO");
					Sql.Append(" 								  AND  T_MAIN.CONTENT = REQD.BILLING_YM) )");
					Sql.Append("  Left JOIN    M_CUSTOMER CUS ON T_MAIN.CUSTOMER_CD = CUS.CODE )");
					Sql.Append("  Left JOIN    M_ENGINEER ENG ON T_MAIN.ENGINEER_ID = ENG.ID )");
					Sql.Append("  WHERE        0 = 0");
				}
				//SQLSever
				if (clsDefine.OperatingStatus == OperatStatus.ONLINE)
				{
					Sql.Append(" SELECT");
					Sql.Append("             ORD.ORDER_NO AS 受注No");
					Sql.Append("           , SAL.SALES_NO AS 売上No");
					Sql.Append("           , FORMAT(CONVERT(DateTime,SAL.SALES_YM + '01'),'yyyy/MM') AS 売上年月");
					Sql.Append("           , REQD.REQUEST_NO AS 請求No");
					Sql.Append("           , CUS.NAME AS 得意先名");
					Sql.Append("           , ENG.NAME AS 技術者名");
					Sql.Append("           , FORMAT(CONVERT(DateTime,COD.CONTENT + '01'),'yyyy/MM') AS 受注日");
					Sql.Append("           , iif(SAL.SALES_AMOUNT IS NOT NULL, '登録済', '') AS 売上状態");
					Sql.Append("           , iif(SAL.BILLING_FLG = 1, '計算済', '') AS 請求状態");
					Sql.Append("           , iif(REQD.FINISH_FLG = 1, '回収済', '') AS 回収状態");
					Sql.Append("           , iif(REQD.PUBLISH_FLG = 1, '発行済', '') AS 請求書");
					Sql.Append("  FROM(((((");
					Sql.Append("             T_ORDER AS ORD");
					Sql.Append("  INNER JOIN");
					Sql.Append("             M_CODE COD ");
					Sql.Append("       ON    (SUBSTRING(ORD.START_YMD, 1, 6) <= COD.CONTENT");
					Sql.Append("       AND   SUBSTRING(ORD.END_YMD, 1, 6) >= COD.CONTENT");
					Sql.Append("       AND   COD.KBN = 'X01'))");
					Sql.Append("  Left JOIN  T_SALES SAL ");
					Sql.Append("         ON  (ORD.ORDER_NO = SAL.ORDER_NO");
					Sql.Append("  AND        SAL.SALES_YM = COD.CONTENT))");
					Sql.Append("  Left Join  T_REQUEST_DTL REQD ON ( ORD.ORDER_NO = REQD.ORDER_NO AND REQD.BILLING_YM = COD.CONTENT ) )");
					Sql.Append("  Left JOIN  M_CUSTOMER CUS ON ORD.CUSTOMER_CD = CUS.CODE )");
					Sql.Append("  Left JOIN  M_ENGINEER ENG ON ORD.ENGINEER_ID = ENG.ID )");
					Sql.Append("  WHERE      0 = 0");
				}

                //個別指定の場合：受注年月
                if (!string.IsNullOrEmpty(dto.OrderYm))
                {
                    Sql.AppendFormat("      And     COD.CONTENT = '{0}'"
                                    , dto.OrderYm);
                }
                //範囲指定の場合：受注年月
                if (!string.IsNullOrEmpty(dto.OrderYmF) 
                    || !string.IsNullOrEmpty(dto.OrderYmT))
                {

                    Sql.AppendFormat("      And     COD.CONTENT >= '{0}'" +
                                    "       And     COD.CONTENT <= '{1}'"
                                    , dto.OrderYmF, dto.OrderYmT);
                }

                //得意先
                //個別指定の場合（全ての場合はスルー）
                if (!string.IsNullOrEmpty(dto.CusCd) 
                    && dto.CusCd != "00000000")
                {
                    Sql.AppendFormat("      And     ORD.CUSTOMER_CD = '{0}'"
                                        , dto.CusCd);
                }
                //範囲指定の場合
                if (!string.IsNullOrEmpty(dto.CusCdF)
                    || !string.IsNullOrEmpty(dto.CusCdT))
                {
                    Sql.AppendFormat("      And     ORD.CUSTOMER_CD >= '{0}'" +
                                        "   And     ORD.CUSTOMER_CD <= '{1}'"
                                        , dto.CusCdF, dto.CusCdT);
                }

                //技術者
                //個別指定の場合（全ての場合はスルー）
                if (!string.IsNullOrEmpty(dto.EngId)
                    && dto.EngId != "00000000")
                {
                    Sql.AppendFormat("      And     ORD.ENGINEER_ID = '{0}'"
                                        , dto.EngId);
                }
                //範囲指定の場合
                if (!string.IsNullOrEmpty(dto.EngIdF)
                    || !string.IsNullOrEmpty(dto.EngIdT))
                {
                    Sql.AppendFormat("      And     ORD.ENGINEER_ID >= '{0}'" +
                                        "   And     ORD.ENGINEER_ID <= '{1}'"
                                        , dto.EngIdF, dto.EngIdT);
                }

                //売上金額（売上テーブル）False＝全て表示
                if (!string.IsNullOrEmpty(dto.SalAmSta))
                {
                    //存在する
                    if (dto.SalAmSta == "1")
                    {
                        Sql.AppendFormat("      And	    SAL.SALES_AMOUNT IS NOT NULL");
                    }
                    //存在しない
                    if (dto.SalAmSta == "0")
                    {
                        Sql.AppendFormat("      And     SAL.SALES_AMOUNT IS NULL");
                    }
                }
                //請求フラグ（売上テーブル）False = 全て表示
                if (!string.IsNullOrEmpty(dto.BillFlg))
                {
                    //計算済
                    if (dto.BillFlg == "1")
                    {
                        Sql.AppendFormat("      And     SAL.BILLING_FLG = 1");
                    }
                    //未計算
                    if (dto.BillFlg == "0")
                    {
                        Sql.AppendFormat("      And      ( SAL.BILLING_FLG IS NULL OR SAL.BILLING_FLG = 0 )");
                    }
                }
                //回収フラグ（請求明細）False = 全て表示
                if (!string.IsNullOrEmpty(dto.FinFlg))
                {
                    //回収済
                    if (dto.FinFlg == "1")
                    {
                        Sql.Append("            And   ( ");
                        Sql.Append("                    REQD.FINISH_FLG = 1");
                       // Sql.Append("                    And   CONVERT(varchar, SAL.SALES_AMOUNT) IS NOT NULL");
                        //Sql.Append("                    And   CONVERT(varchar, SAL.BILLING_FLG) IS NOT NULL ");
                        Sql.Append("                    )");    
                    }
                    //未回収
                    if (dto.FinFlg == "0") 
                    {
                        Sql.Append("            And   ( REQD.FINISH_FLG IS NULL OR REQD.FINISH_FLG = 0 ) ");
                    } 
                }
                //請求書発行フラグ（請求明細）False = 全て表示
                if (!string.IsNullOrEmpty(dto.PubFlg))
                {
                    //発行済
                    if (dto.PubFlg == "1")
                    {
                        Sql.Append("            And   ( ");
                        Sql.Append("                    REQD.PUBLISH_FLG = 1");
                            //"And   CONVERT(varchar, SAL.SALES_AMOUNT) IS NOT NULL");
                       // Sql.Append("                    And   CONVERT(varchar, SAL.BILLING_FLG) IS NOT NULL ");
                        Sql.Append("                    )");
                    }
                    //未発行
                    if (dto.PubFlg == "0")
                    {
                        Sql.AppendFormat("      And   ( REQD.PUBLISH_FLG IS NULL OR REQD.PUBLISH_FLG = 0 ) ");
                    }                    
                }

                Sql.Append("  ORDER BY");
                Sql.Append("           ORD.ORDER_NO");
                Sql.Append("         , COD.CONTENT");

                //選択クエリ実行
                return base.ExecuteSelect(Sql.ToString());
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// 得意先情報のコンボボックスの表示項目を返します
        /// </summary>
        /// <returns>得意先コンボボックス</returns>
        public DataTable SelectCustomerComboBox()
        {
            try
            {
                //  SQLを構築
                StringBuilder Sql = new StringBuilder();

                Sql.AppendFormat(" Select		S.CUSTOMER_CD, C.NAME");
                Sql.AppendFormat(" From			T_SALES  As S");
                Sql.AppendFormat(" Inner Join	M_CUSTOMER As C");
                Sql.AppendFormat(" On			S.CUSTOMER_CD = C.CODE");
                Sql.AppendFormat(" Where		S.DEL_FLG     = 0");
                Sql.AppendFormat(" Group By		S.CUSTOMER_CD, C.NAME");
                Sql.AppendFormat(" Order By		S.CUSTOMER_CD");

                //  選択クエリ
                return base.ExecuteSelect(Sql.ToString());
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 技術者情報のコンボボックスの表示項目を返します
        /// </summary>
        /// <returns>技術者コンボボックス</returns>
        public DataTable SelectEngineerComboBox()
        {
            try
            {
                //  SQLを構築
                StringBuilder Sql = new StringBuilder();

                Sql.Append(" Select");
                Sql.Append("			S.ENGINEER_ID, E.NAME");
                Sql.Append(" From");
                Sql.Append("			T_SALES As S");
                Sql.Append(" Inner Join");
                Sql.Append("			M_ENGINEER As E");
                Sql.Append(" On");
                Sql.Append("			S.ENGINEER_ID = E.ID");
                Sql.Append(" Where		S.DEL_FLG     = 0");
                Sql.Append(" Group By");
                Sql.Append("			S.ENGINEER_ID, E.NAME");
                Sql.Append(" Order By");
                Sql.Append("			S.ENGINEER_ID");

                //  選択クエリ
                return base.ExecuteSelect(Sql.ToString());
            }
            catch
            {
                throw;
            }
        }

		/// <summary>
		/// 一時的に受注期間のタイムテーブルを生成
		/// </summary>
		public void InsertTimeTable()
		{
			try
			{
				//T_ORDERの中のフィールド：開始期間、終了期間 を取得
				//SQL構築
				StringBuilder Sql0 = new StringBuilder();
				Sql0.Append(" SELECT ");
				Sql0.Append("         START_YMD");
				Sql0.Append("        , END_YMD");
				Sql0.Append(" FROM   T_ORDER");
				//選択クエリ実行
				DataTable dt = base.ExecuteSelect(Sql0.ToString());

				//SELECT文結果から期間の最小値、最大値を集計し、DataTime型に変換
				DateTime from = DateTime.Parse(dt.Select("START_YMD = MIN(START_YMD)")[0][0].ToString().Substring(0, 4)
												+ "/"
												+ dt.Select("START_YMD = MIN(START_YMD)")[0][0].ToString().Substring(4, 2));

				DateTime To = DateTime.Parse(dt.Select("END_YMD = MAX(END_YMD)")[0][1].ToString().Substring(0, 4)
												+ "/"
												+ dt.Select("END_YMD = MAX(END_YMD)")[0][1].ToString().Substring(4, 2));

				//受注期間内で1か月ずつ加算し、INSERT文を実行
				int code = 1;
				for (DateTime Ym = from; Ym <= To; Ym = Ym.AddMonths(1) , code++)
				{
					//SQLを構築
					StringBuilder Sql = new StringBuilder();
					Sql.Append(" INSERT INTO ");
					Sql.Append("              M_CODE");
					Sql.Append("            (   KBN");
					Sql.Append("              , CODE");
					Sql.Append("              , CONTENT");
					Sql.Append("            )");
					Sql.AppendFormat(" VALUES( ");
					Sql.Append("                'X01'");
					Sql.AppendFormat("        , '{0}'", code);
					Sql.AppendFormat("        , '{0}'", Ym.ToString("yyyyMM"));
					Sql.Append("            )");

					//アクションクエリ実行（強制ロールバック）
					base.ExecuteAction(Sql.ToString(), false);
				}
			}
			catch 
			{
				throw;
			}
		}

        #endregion

    }
}
