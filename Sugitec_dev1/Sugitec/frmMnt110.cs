using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sugitec.Common;
using Sugitec.Logics;
namespace Sugitec
{
    public partial class frmMnt110 : frmBase
    {

        #region"Define"

        //更新か新規か判定、初期値は新規
        bool updMode = false;

        #endregion

        #region"Property"


        #endregion

        #region"Event"

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmMnt110()
        {
            InitializeComponent();

            //機能コードを設定
            this.FeaturesCD = FEATURES.MNT110;

        }

        /// <summary>
        ///初回起動時、DataGridViewの初期化を行う。
        /// </summary>
        private void frmMnt110_Load(object sender, EventArgs e)
        {
            try
            {
                updMode = false;
                dgv.SuspendLayout();
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = null;

                dgv.Columns["dgv_del"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["dgv_ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["dgv_name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv.Columns["dgv_initial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv.Columns["dgv_birthday"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["dgv_sex"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["dgv_zip"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["dgv_TEL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["dgv_mobileTEL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgv.Columns[0].Width = 60;
                dgv.Columns[1].Width = 80;
                dgv.Columns[2].Width = 150;
                dgv.Columns[3].Width = 90;
                dgv.Columns[4].Width = 80;
                dgv.Columns[5].Width = 50;
                dgv.Columns[6].Width = 90;
                dgv.Columns[7].Width = 100;
                dgv.Columns[8].Width = 100;
                dgv.Columns[9].Width = 120;
                CLRData();
                SetComboList();
                GetData();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgv.ResumeLayout(true);
            }
        }

        /// <summary>
        /// クリアボタン
        /// 現在編集中のデータを初期化する。
        /// </summary>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            try
            {
                CLRData();
                txt_ID.Enabled = true;
                updMode = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// DataGridViewセルクリック
        /// </summary>
        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                // ヘッダーのダブルクリック時には抜ける
                if (e.RowIndex < 0) return;

                txt_ID.Text = dgv["dgv_ID", e.RowIndex].Value.ToString();
                txt_name.Text = dgv["dgv_name", e.RowIndex].Value.ToString();
                txt_initial.Text = dgv["dgv_initial", e.RowIndex].Value.ToString();
                dtp_birthday.Value = dgv["dgv_Birthday", e.RowIndex].Value.ToDateEx();
                txt_zipcd.Text = dgv["dgv_zip", e.RowIndex].Value.ToString();
                txt_TelNo.Text = dgv["dgv_TEL", e.RowIndex].Value.ToString();
                txt_mobileNo.Text = dgv["dgv_mobileTEL", e.RowIndex].Value.ToString();
                txt_ID.Enabled = false;
                if (dgv["dgv_sex", e.RowIndex].Value.ToString() == "男")
                {
                    rd_male.Checked = true;
                }
                else if (dgv["dgv_sex", e.RowIndex].Value.ToString() == "女")
                {
                    rd_female.Checked = true;
                }
                txt_Address1.Text = dgv["dgv_Address1", e.RowIndex].Value.ToString();
                txt_Address2.Text = dgv["dgv_Address2", e.RowIndex].Value.ToString();
                cmb_belongs.SelectedValue = dgv["dgv_belongs", e.RowIndex].Value.ToString();
                cmb_GROUPCD.SelectedValue = dgv["dgv_GROUPCD", e.RowIndex].Value.ToString();
                updMode = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 氏名　連絡先ボタン
        /// </summary>
        private void btnCopy1_Click(object sender, EventArgs e)
        {
            try
            {
                //必須チェック
                if (!this.ChkInput(true)) return;

                //コピーする文字列を構築
                StringBuilder Str = new StringBuilder();

                Str.AppendFormat("フルネームですが　{0}（○○○○　○○○○）\n", txt_name.Text);
                Str.Append("になります。\n");
                Str.Append("連絡先は下記になります。\n");
                Str.AppendFormat("{0}\n", txt_mobileNo.Text);

                //クリップボードに構成文字列をコピー
                Clipboard.SetText(Str.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///詳細ボタン
        /// </summary>
        private void btncopy2_Click(object sender, EventArgs e)
        {
            try
            {
                //必須チェック
                if (!this.ChkInput(false,true)) return;

                //コピーする文字列を構築
                StringBuilder Str = new StringBuilder();

                Str.AppendFormat("\t■名前：{0}", txt_initial.Text);
                //年齢を算出
                if (rd_male.Checked)
                {
                    Str.AppendFormat(" (男性・{0}歳) \n"
                        , (int)Math.Floor((double)((Convert.ToInt64(DateTime.Today.ToString("yyyyMMdd"))
                            - Convert.ToInt64(dtp_birthday.Value.ToStringEx())) / 10000)));
                }
                if (rd_female.Checked)
                {
                    Str.AppendFormat(" (女性・{0}歳) \n"
                        , (int)Math.Floor((double)((Convert.ToInt64(DateTime.Today.ToString("yyyyMMdd"))
                            - Convert.ToInt64(dtp_birthday.Value.ToStringEx())) / 10000)));
                }
                Str.AppendFormat("\t■最寄駅：○○線　○○駅\n");
                Str.AppendFormat("\t■面談：○○\n");
                Str.AppendFormat("\t■稼働日：○○\n");
                Str.AppendFormat("\t■希望金額：○○\n");
                Str.AppendFormat("\t■契約形態：○○\n");
                Str.AppendFormat("\t■営業状況：○○\n");
                Str.AppendFormat("\t■スキル：\n");
                Str.AppendFormat("\tOS：○○\n");
                Str.AppendFormat("\tその他：○○\n");
                Str.AppendFormat("\t言語：○○\n");
                Str.AppendFormat("\t■工程：○○\n");
                Str.AppendFormat("\t■備考：\n");

                //クリップボードに構成文字列をコピー
                Clipboard.SetText(Str.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///確定ボタン押下、更新モード時はUPDATE、挿入モード時はINSERTを行う。
        /// </summary>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
				//必須入力チェック
				if(!this.ChkInput()) return;

                dtoMnt110 dto = new dtoMnt110();
                dto.ID = txt_ID.Text;
                dto.Name = txt_name.Text;
                dto.Initial = txt_initial.Text;
                dto.BirthDay = dtp_birthday.Value.ToStringEx();
                if (cmb_belongs.SelectedIndex == -1)
                {
                    dto.Belongs_KBN = string.Empty;
                }else
                {
                    dto.Belongs_KBN = cmb_belongs.SelectedValue.ToString();
                }
                if (cmb_GROUPCD.SelectedIndex == -1)
                {
                    dto.Group_CODE = string.Empty;
                }
                else
                {
                    dto.Group_CODE = cmb_GROUPCD.SelectedValue.ToString();
                }
                
                if (txt_zipcd.Text.Trim()=="-")
                {
                    dto.post = string.Empty;
                }
                else
                {
                    dto.post = txt_zipcd.Text;
                }
                dto.Home_TEL = txt_TelNo.Text;
                dto.Mobile_TEL = txt_mobileNo.Text;
                dto.Address1 = txt_Address1.Text;
                dto.Address2 = txt_Address2.Text;
                dto.SYNC_FLG = (int)clsDefine.OperatingStatus;
                dto.TIMESTAMP = DateTime.Now.ToString("yyyyMMddHHmmss");
                if (rd_male.Checked == true)
                {
                    dto.SEX = 0;
                }
                else
                {
                    dto.SEX = 1;
                }

                using (srvMnt110 srv = new srvMnt110())
                {
                    if (updMode == true)
                    {
                        srv.Update(dto);
                    }
                    else
                    {
                        srv.Insert(dto);
                    }
                }

                CLRData();
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 削除ボタン押下、削除チェックボックスにチェックが入っている行のデータの削除フラグを立てる。
        /// </summary>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                //  DataGridVieのデータをDataTableへ格納
                DataTable dt = new DataTable();
                dt = (DataTable)dgv.DataSource;

                //　選択チェック 具体的には,DataGeridView からチェックフラグを探しに行きます
                foreach (DataRow row in dt.Rows)
                {
                    //  チェックボックスの入った行を探し、ひとつでもあればtrue
                    if (row[0].ToString() == "1")
                    {
                        //実行確認
                        if (MessageBox.Show("削除します。よろしいですか？",
                            base.FeatureNM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                        //サービス
                        using (srvMnt110 srv = new srvMnt110())
                        {
                            srv.delete(dt);
                        }
                        // DataGrid 再表示
                        GetData();
                        CLRData();
                        return;
                    }
                }

				//チェックがひとつも入っていなければ警告を表示	
				MessageBox.Show("チェックボックスにチェックがありません",
									base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
            {
                MessageBox.Show(ex.Message, base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 画面を終了する
        /// </summary>
        private void Cmd_End_Click(object sender, EventArgs e)
        {

            Close();
        }

        #endregion

        #region"Method"

		/// <summary>
		/// 入力項目の必須チェックを行います
		/// </summary>
        /// <param name="IsClipBoardCopy">クリップボードにコピーするかどうか</param>
		/// <returns> true：正常、false：異常 </returns>
		private Boolean ChkInput(Boolean IsClipBoardCopy1 = false, Boolean IsClipBoardCopy2 = false)
		{
            //クリップボード（氏名　連絡先ボタン）にコピーする場合は含める
            if (!IsClipBoardCopy1)
            {
                //氏名
                if (string.IsNullOrEmpty(txt_name.Text))
                {
                    MessageBox.Show(label2.Text + "が未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            //クリップボード（両方）にコピーする場合は除外する
            if (!IsClipBoardCopy1 || !IsClipBoardCopy2)
            {
                //技術者ID
                if (string.IsNullOrEmpty(txt_ID.Text))
                {
                    MessageBox.Show(label1.Text + "が未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            //クリップボード（氏名　連絡先ボタン）にコピーする場合
            if (IsClipBoardCopy1)
            {
                //電話番号
                if (string.IsNullOrEmpty(txt_mobileNo.Text))
                {
                    MessageBox.Show(label9.Text + "が未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            //クリップボード（詳細ボタン）にコピーする場合
            if (IsClipBoardCopy2)
            {
                //イニシャル
                if (string.IsNullOrEmpty(txt_initial.Text))
                {
                    MessageBox.Show(label3.Text + "が未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //生年月日
                if (dtp_birthday.Value == null)
                {
                    MessageBox.Show(label10.Text + "が未入力です", base.FeatureNM, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            //正常終了
            return true;
		}

        /// <summary>
        /// フォームに入力中のデータを空にし、更新モードから新規データ挿入に移行する。
        /// </summary>
        private void CLRData()
        {
            try
            {
                txt_ID.Text = string.Empty;
                txt_initial.Clear(); 
                txt_name.Clear();
                txt_Address1.Clear();
                txt_Address2.Clear();
                txt_TelNo.Text = string.Empty;
                txt_mobileNo.Text = string.Empty;
                txt_zipcd.Text = string.Empty;
                cmb_belongs.SelectedIndex=-1;
                cmb_GROUPCD.SelectedIndex = -1;
                dtp_birthday.Value = null;
                rd_male.Checked = true;
                rd_female.Checked = false;
                txt_ID.Enabled = true;
                updMode = false;
            }
            catch
            {
                throw;
            }

        }

        /// <summary>
        /// データを取得する。
        /// </summary>
        private void GetData()
        {
            try
            {
                dgv.SuspendLayout();
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = null;
                DataTable getdt = new DataTable();
                using (srvMnt110 srv = new srvMnt110())
                {
                    getdt = srv.Select();
                }
                SetData(getdt);
            }
            catch
            {
                throw;
            }
            finally
            {
                dgv.ResumeLayout(true);
            }

        }

        /// <summary>
        /// 取得したデータをDataGridViewの列と関連付けする。
        /// </summary>
        /// <param name="dt">データ取得済みのデータテーブル</param>
        private void SetData (DataTable dt)
        {
            try
            {
                dgv.DataSource = dt;
                dgv.Columns["dgv_ID"].DataPropertyName = "ID";
                dgv.Columns["dgv_name"].DataPropertyName = "NAME";
                dgv.Columns["dgv_initial"].DataPropertyName = "INITIAL";
                dgv.Columns["dgv_Birthday"].DataPropertyName = "BIRTHDAY";
                dgv.Columns["dgv_sex"].DataPropertyName = "SEX";
                dgv.Columns["dgv_zip"].DataPropertyName = "POST";
                dgv.Columns["dgv_TEL"].DataPropertyName = "HOME_TEL";
                dgv.Columns["dgv_mobileTEL"].DataPropertyName ="MOBILE_TEL";
                dgv.Columns["dgv_belongs"].DataPropertyName = "BELONGS_KBN";
                dgv.Columns["dgv_GROUPCD"].DataPropertyName = "GROUP_CODE";
                dgv.Columns["dgv_Address1"].DataPropertyName = "ADDRESS1";
                dgv.Columns["dgv_Address2"].DataPropertyName = "ADDRESS2";
                dgv.Columns["dgv_del"].DataPropertyName = "chkDel";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 各コンボボックスのリストを設定
        /// </summary>
        private void SetComboList()
        {
            try
            {
                //サービス
                using (srvMnt110 srv = new srvMnt110())
                {
                    //所属区分取得
                    cmb_belongs.DataSource = srv.GetCodeM("M01");
                    cmb_belongs.ValueMember = "CODE";
                    cmb_belongs.DisplayMember = "CONTENT";
                    cmb_belongs.SelectedIndex = -1;

                    //グループコード取得
                    cmb_GROUPCD.DataSource = srv.GetGroupCdM();
                    cmb_GROUPCD.ValueMember = "GROUP_CODE";
                    cmb_GROUPCD.DisplayMember = "GROUP_NAME";
                    cmb_GROUPCD.SelectedIndex = -1;
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

    