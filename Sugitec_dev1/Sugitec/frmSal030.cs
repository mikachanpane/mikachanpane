using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using Sugitec.Common;
using Sugitec.Logics;



namespace Sugitec
{
	/// <summary>
	/// 交通費精算情報M
	/// </summary>
	public partial class frmSal030 : frmBase 
	{
		#region” Define ”

		#endregion

		#region” Property ”

		/// <summary>引き渡された受注No </summary>
		internal string OrderNo { get; set; }
		/// <summary>引き渡された得意先名</summary>
		internal string CusName { get; set; }
		/// <summary>引き渡された技術者名</summary>
		internal string EngName { get; set; }
		/// <summary>TEST</summary>
		private Object Test { get; set; }

		#endregion

		#region ” Event ”

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public frmSal030()
		{
			string test = null;

			if(!string.IsNullOrEmpty(test))
			{
				test.Trim();
			}

			InitializeComponent();

			try
			{
				//機能コードを設定
				FeaturesCD = FEATURES.SAL030;

				//DataGridViewの初期設定
				this.InitGridView();

				//一覧表を取得しDataGridViewに設定
				using (srvSal030 srv = new srvSal030())
				{
					//DataGridViewコンボボックスを設定
					this.SetGridViewComboBox(srv);

					//データバインド
					this.SetGridView(srv.SelectGridView());

					///if (clsDefine.OperatingStatus == OperatStatus.OFFLINE)
					///{
					///	this.SetGridView(srv.TestSelect(1));
					///}
					///else
					///{
					///	this.SetGridView(srv.TestSelect(1.5));
					///}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// 画面遷移後イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmSal030_Load(object sender, EventArgs e)
		{
			try
			{
				//画面項目の初期設定
				this.InitContorol();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// DataGridViewCellフォーカス移動時
		/// </summary>
		private void dgv_expense_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			try
			{
				//DataGridView(sender)
				DataGridView dgv = (DataGridView)sender;
				//DataGridViewRow
				DataGridViewRow row = dgv.Rows[e.RowIndex];

				//列"dgv_ym"の時のみ検証 (空文字はスルー)
				if (e.ColumnIndex != 1
					|| string.IsNullOrEmpty(dgv.Rows[e.RowIndex].Cells["dgv_ym"].Value.ToString()))
					return;

				//選択行の計上日セルに値を入力
				DateTime date = (DateTime)row.Cells["dgv_ym"].Value.ToDateEx();
				row.Cells["dgv_ym"]. = date.ToString("yyyy/MM/dd");

				///日付型に変換可能な8桁入力されている時のみ検証
				///if (row.Cells["dgv_ym"].Value.ToDateEx().ToStringEx("yyyyMMdd").Length >= 8)
				///{
				///	//入力文字列を日付書式に整形後、日付型に変換できるかを調べる
				///	//string ym = string.Format(
				///	//	"{0}/{1}/{2}"
				///	//	, row.Cells["dgv_ym"].EditedFormattedValue.ToString().Substring(0, 4)
				///	//	, row.Cells["dgv_ym"].EditedFormattedValue.ToString().Substring(4, 2)
				///	//	, row.Cells["dgv_ym"].EditedFormattedValue.ToString().Substring(6, 2)
				///	//	);
				///}

				/// DateTime.TryParseExact()
				///DateTime ym = new DateTime();
				///if (DateTime.TryParseExact(row.Cells["dgv_ym"].EditedFormattedValue.ToString()
				///					, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None
				///					, out ym))
				///{
				///	row.Cells["dgv_ym"].Value = ym;
				///}

				///没：日付型に変換できるかを調べる方法
				///StringBuilder ym = new StringBuilder();
				///ym.Append(row.Cells["dgv_ym"].Value.ToString());
				///ym = ym.ToString("yyyy/MM/dd");
				///DateTime outYm = new DateTime();
				///DateTmie.TryParseExact(  ←  おかしな日付書式になる
				///null, System.Globalization.DateTimeStyles.None, out DateTime outYm))
				///dgv_expense.CurrentCell.Value.ToString(), out DateTime result))
				///dgv_expense["dgv_ym",e.RowIndex].Value.ToString(), out DateTime result))
				///変換できれば日付型に整形し、処理を抜ける
				///DateTime date = (DateTime)dgv_expense.Rows[e.RowIndex].Cells["dgv_ym"].EditedFormattedValue.ToDateEx();
				///dgv_expense.Rows[e.RowIndex].Cells["dgv_ym"].Value.
				///row.Cells["dgv_ym"].Value = row.Cells["dgv_ym"].Value.ToString().Substring(0, 10);
				///				/// Infomation for DateTime.TrtyParseExact.
				///if (DateTime.TryParseExact(
				///	"20170707", "yyyyMMdd",
				///	null, System.Globalization.DateTimeStyles.None, out DateTime result0))
				///{
				///	int i;
				///}
				///else
				///{
				///	int i;
				///}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// 確定ボタン
		/// </summary>
		private void btn_OK_Click(object sender, EventArgs e)
		{
			try
			{
				//必須項目チェック
				if (!ChkGridView((DataTable)dgv_expense.DataSource)) return;

				//画面項目をDTOに移送(DTOList)
				List<dtoSal030> dtoList = new List<dtoSal030>();

				//DataGridViewの各行からDTOListを構築
				foreach (DataGridViewRow row in dgv_expense.Rows)
				{
					//画面項目をDTOに移送
					dtoSal030 dto = new dtoSal030();
					dto.ORDER_NO = this.OrderNo;
					dto.ACCRUAL_YMD = row.Cells["dgv_ym"].Value.ToString();
					dto.EXPENSE_CD = row.Cells["dgv_cd"].Value.ToString();
					dto.KINGAKU = row.Cells["dgv_amount"].Value.ToString();
					dto.BIKO1 = row.Cells["dgv_biko1"].Value.ToString();
					dto.BIKO2 = row.Cells["dgv_biko2"].Value.ToString();
					dto.TAX_KBN = row.Cells["dgv_tax"].Value.ToString();
					dto.DEL_FLG = "0";
					dto.SYNC_FLG = clsDefine.OperatingStatus.ToString();
					dto.TIME_STAMP = DateTime.Now.ToString("yyyyMMddhhmmss");

					//Listを構築
					dtoList.Add(dto);
				}

				//サービス
				using (srvSal030 srv = new srvSal030())
				{
					//構築するSQL文(メソッド)を切り替える（主キーで判別）
					srv.ChangeSQL(dtoList);

					//画面項目クリア
					this.InitContorol();

					//一覧表を再取得しDataGridViewに設定
					this.SetGridView(srv.SelectGridView());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// 削除ボタン
		/// </summary>
		private void btn_DEL_Click(object sender, EventArgs e)
		{
			try
			{
				//DataGridViewのデータをDataTableへ格納
				DataTable dt = (DataTable)dgv_expense.DataSource;

				//選択チェック 具体的にはDataGeridView からチェックフラグを探しに行きます
				foreach (DataRow row in dt.Rows)
				{
					//チェックボックスの入った行を探し、ひとつでもあればtrue
					if (row[0].ToString() == "1")
					{
						//実行確認
						if (MessageBox.Show("削除します。よろしいですか？",
								base.FeatureNM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
							return;

						//サービス
						using (srvSal030 srv = new srvSal030())
						{
							//削除用Update文
							srv.Delete(dt);

							//DataGridView再表示
							this.SetGridView(srv.SelectGridView());

							//各コントロールを初期化
							this.InitContorol();
							return;
						}
					}
				}

				//一行もチェックが入っていなければ、メッセージで警告		
				MessageBox.Show("チェックボックスにチェックがありません",
									base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// クリアボタン
		/// </summary>
		private void btn_CLR_Click(object sender, EventArgs e)
		{
			try
			{
				//画面項目クリア
				this.InitContorol();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// 終了ボタン
		/// </summary>
		private void btn_End_Click(object sender, EventArgs e)
		{
			try
			{
				//画面を閉じる
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		#region” Method ”

		/// <summary>
		/// DataGridViewの初期設定をします
		/// </summary>
		private void InitGridView()
		{
			try
			{
				//列自動追加を解除
				dgv_expense.AutoGenerateColumns = false;
				//列の書式設定
				dgv_expense.Columns["dgv_amount"].DefaultCellStyle.Format = "#,0";
				//dgv_expense.Columns["dgv_ym"].DefaultCellStyle.Format = "d";
				//行自動追加を有効
				dgv_expense.AllowUserToAddRows = true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 画面項目の初期設定をします
		/// </summary>
		/// <param name="isGridClear">DataGridViewをクリア対象に含むか</param>
		private void InitContorol()
		{
			try
			{
				//ラベル
				lblCusNm.Text = this.CusName;
				lblEngNm.Text = this.EngName;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// コントロールをクリアします
		/// </summary>
		/// <param name="isGridClear">DataGridViewを対象に含めるか</param>
		private void ClrControl(Boolean isGridClear = false)
		{
			try
			{
				//指定時のみDataGridViewをクリア
				if (isGridClear)
				{
					dgv_expense.DataSource = null;
				}
				//先頭行を選択
				this.dgv_expense.Rows[0].Selected = true;
			}
			catch 
			{
				throw;
			}
		}

		/// <summary>
		/// DataGridViewにデータバインドします
		/// </summary>
		/// <param name="dt">srv.Select()</param>
		private void SetGridView(DataTable dt)
		{
			try
			{
				//DataGridView のデータ取得
				dgv_expense.DataSource = dt;

				//DataGridView へのデータバインド
				dgv_expense.Columns["dgv_del"].DataPropertyName = "SEL0";
				dgv_expense.Columns["dgv_ym"].DataPropertyName = "計上日";
				///dgv_cd.ValueMember = "経費項目コード";
				dgv_expense.Columns["dgv_amount"].DataPropertyName = "金額";
				dgv_expense.Columns["dgv_biko1"].DataPropertyName = "備考1　　　　　　　　　　　　　　　　　　　";
				dgv_expense.Columns["dgv_biko2"].DataPropertyName = "備考2";
				dgv_expense.Columns["dgv_tax"].DataPropertyName = "税区分";

				///TEST
				///dgv_expense.Columns["dgv_ym"].DataPropertyName = "A";
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// DataGridView内のコンボボックスを設定します
		/// </summary>
		/// <param name="service">srvSal030のインスタンス</param>
		private void SetGridViewComboBox(srvSal030 service)
		{
			try
			{
				//税区分取得：カテゴリ区分"M10"
				dgv_cd.DataSource = service.SelectCodeM("M10");
				dgv_cd.ValueMember = "CODE";
				dgv_cd.DisplayMember = "CONTENT";
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// DataGridViewの必須項目チェックを行います
		/// </summary>
		/// <returns></returns>
		private Boolean ChkGridView(DataTable dt)
		{
			try
			{
				//エラーメッセージを設定
				string msg = "を入力してください";

				foreach (DataRow row in dt.Rows)
				{
					//計上年月日
					if (string.IsNullOrEmpty(row["計上年月日"].ToString()))
					{
						MessageBox.Show(dgv_ym.Name + msg,
							base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

					//経費項目コード
					if (string.IsNullOrEmpty(row["経費項目コード"].ToString()))
					{
						MessageBox.Show(dgv_cd.Name + msg,
							base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}

				return true;
			}
			catch
			{
				throw;
			}

		}
	}

	#endregion

}

