namespace Sugitec
{
    partial class frmMnt111
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.txt_UserType = new Sugitec.Common.ctlBytTextBoxEx();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.dgv_EngineerCareer = new Sugitec.Common.ucDataGridViewEx();
			this.ENGINEER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BIO_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BIO_START_YMD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BIO_END_YMD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BIO_BUS_TYP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BIO_OVERVIEW = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BIO_POSITION = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.BIO_ROLE = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.BIO_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BIO_WORK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BIO_RD = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BIO_SA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BIO_DD = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BIO_UI = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BIO_PS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BIO_PD = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BIO_PG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BIO_PT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BIO_IT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BIO_ST = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BIO_IR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BIO_SI = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BIO_IW = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BIO_OTH = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.btn_Ok = new System.Windows.Forms.Button();
			this.btn_Clear = new System.Windows.Forms.Button();
			this.Cmd_End = new System.Windows.Forms.Button();
			this.dtp_BirthdayFrom = new Sugitec.Common.ctlDateTimePickerEx();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.cmb_Engineer = new System.Windows.Forms.ComboBox();
			this.dtp_BirthdayTo = new Sugitec.Common.ctlDateTimePickerEx();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_Gaiyo = new Sugitec.Common.ctlBytTextBoxEx();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cmb_Position = new System.Windows.Forms.ComboBox();
			this.cmb_Yakuwari = new System.Windows.Forms.ComboBox();
			this.nud_People = new Sugitec.Common.ucNumUpDown();
			this.btxt_Work = new Sugitec.Common.ctlBytTextBoxEx();
			this.label8 = new System.Windows.Forms.Label();
			this.lst_Hard = new System.Windows.Forms.CheckedListBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lst_Os = new System.Windows.Forms.CheckedListBox();
			this.btn_Change = new System.Windows.Forms.Button();
			this.lst_Cord = new System.Windows.Forms.CheckedListBox();
			this.lst_Db = new System.Windows.Forms.CheckedListBox();
			this.lst_Tool = new System.Windows.Forms.CheckedListBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.chk_Yoken = new System.Windows.Forms.CheckBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.chk_Cyosa = new System.Windows.Forms.CheckBox();
			this.chk_DbSekei = new System.Windows.Forms.CheckBox();
			this.chk_StdSekei = new System.Windows.Forms.CheckBox();
			this.chk_DtlSekei = new System.Windows.Forms.CheckBox();
			this.chk_Sekei = new System.Windows.Forms.CheckBox();
			this.grp_Program = new System.Windows.Forms.GroupBox();
			this.chk_Test = new System.Windows.Forms.CheckBox();
			this.chk_Production = new System.Windows.Forms.CheckBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.chk_SogoTest = new System.Windows.Forms.CheckBox();
			this.chk_SysTest = new System.Windows.Forms.CheckBox();
			this.chk_Syogai = new System.Windows.Forms.CheckBox();
			this.chk_SysIntroduction = new System.Windows.Forms.CheckBox();
			this.label28 = new System.Windows.Forms.Label();
			this.chk_Company = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_EngineerCareer)).BeginInit();
			this.grp_Program.SuspendLayout();
			this.SuspendLayout();
			// 
			// txt_UserType
			// 
			this.txt_UserType.ImeMode = System.Windows.Forms.ImeMode.On;
			this.txt_UserType.Location = new System.Drawing.Point(108, 101);
			this.txt_UserType.Multiline = true;
			this.txt_UserType.Name = "txt_UserType";
			this.txt_UserType.OldText = null;
			this.txt_UserType.Size = new System.Drawing.Size(379, 20);
			this.txt_UserType.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.GreenYellow;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(11, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "業種";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.GreenYellow;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(11, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "技術者";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.GreenYellow;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.Location = new System.Drawing.Point(11, 72);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(91, 20);
			this.label10.TabIndex = 6;
			this.label10.Text = "生年月日";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgv_EngineerCareer
			// 
			this.dgv_EngineerCareer.AllowUserToAddRows = false;
			this.dgv_EngineerCareer.AllowUserToDeleteRows = false;
			this.dgv_EngineerCareer.AllowUserToResizeRows = false;
			this.dgv_EngineerCareer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_EngineerCareer.ColumnHeaderBorderStyle = Sugitec.Common.ucDataGridViewEx.HeaderCellBorderStyle.SingleLine;
			this.dgv_EngineerCareer.ColumnHeaderRowCount = 1;
			this.dgv_EngineerCareer.ColumnHeaderRowHeight = 20;
			this.dgv_EngineerCareer.ColumnHeadersHeight = 22;
			this.dgv_EngineerCareer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ENGINEER_ID,
            this.BIO_NO,
            this.BIO_START_YMD,
            this.BIO_END_YMD,
            this.BIO_BUS_TYP,
            this.BIO_OVERVIEW,
            this.BIO_POSITION,
            this.BIO_ROLE,
            this.BIO_NUM,
            this.BIO_WORK,
            this.BIO_RD,
            this.BIO_SA,
            this.BIO_DD,
            this.BIO_UI,
            this.BIO_PS,
            this.BIO_PD,
            this.BIO_PG,
            this.BIO_PT,
            this.BIO_IT,
            this.BIO_ST,
            this.BIO_IR,
            this.BIO_SI,
            this.BIO_IW,
            this.BIO_OTH});
			this.dgv_EngineerCareer.Location = new System.Drawing.Point(12, 355);
			this.dgv_EngineerCareer.Name = "dgv_EngineerCareer";
			this.dgv_EngineerCareer.RowHeadersVisible = false;
			this.dgv_EngineerCareer.RowTemplate.Height = 21;
			this.dgv_EngineerCareer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgv_EngineerCareer.Size = new System.Drawing.Size(1298, 308);
			this.dgv_EngineerCareer.TabIndex = 24;
			// 
			// ENGINEER_ID
			// 
			this.ENGINEER_ID.HeaderText = "技術者ID";
			this.ENGINEER_ID.Name = "ENGINEER_ID";
			this.ENGINEER_ID.Visible = false;
			// 
			// BIO_NO
			// 
			this.BIO_NO.HeaderText = "連番";
			this.BIO_NO.Name = "BIO_NO";
			this.BIO_NO.ReadOnly = true;
			// 
			// BIO_START_YMD
			// 
			this.BIO_START_YMD.HeaderText = "開始年月日";
			this.BIO_START_YMD.Name = "BIO_START_YMD";
			// 
			// BIO_END_YMD
			// 
			this.BIO_END_YMD.HeaderText = "終了年月日";
			this.BIO_END_YMD.Name = "BIO_END_YMD";
			// 
			// BIO_BUS_TYP
			// 
			this.BIO_BUS_TYP.HeaderText = "業種";
			this.BIO_BUS_TYP.Name = "BIO_BUS_TYP";
			// 
			// BIO_OVERVIEW
			// 
			this.BIO_OVERVIEW.HeaderText = "システム概要";
			this.BIO_OVERVIEW.Name = "BIO_OVERVIEW";
			// 
			// BIO_POSITION
			// 
			this.BIO_POSITION.HeaderText = "ポジション";
			this.BIO_POSITION.Name = "BIO_POSITION";
			// 
			// BIO_ROLE
			// 
			this.BIO_ROLE.HeaderText = "役割";
			this.BIO_ROLE.Name = "BIO_ROLE";
			// 
			// BIO_NUM
			// 
			this.BIO_NUM.HeaderText = "人数";
			this.BIO_NUM.Name = "BIO_NUM";
			// 
			// BIO_WORK
			// 
			this.BIO_WORK.HeaderText = "作業内容";
			this.BIO_WORK.Name = "BIO_WORK";
			// 
			// BIO_RD
			// 
			this.BIO_RD.HeaderText = "要件定義";
			this.BIO_RD.Name = "BIO_RD";
			// 
			// BIO_SA
			// 
			this.BIO_SA.HeaderText = "調査分析";
			this.BIO_SA.Name = "BIO_SA";
			// 
			// BIO_DD
			// 
			this.BIO_DD.HeaderText = "DB設計";
			this.BIO_DD.Name = "BIO_DD";
			// 
			// BIO_UI
			// 
			this.BIO_UI.HeaderText = "基本設計";
			this.BIO_UI.Name = "BIO_UI";
			// 
			// BIO_PS
			// 
			this.BIO_PS.HeaderText = "詳細設計";
			this.BIO_PS.Name = "BIO_PS";
			// 
			// BIO_PD
			// 
			this.BIO_PD.HeaderText = "PG設計";
			this.BIO_PD.Name = "BIO_PD";
			// 
			// BIO_PG
			// 
			this.BIO_PG.HeaderText = "製造";
			this.BIO_PG.Name = "BIO_PG";
			// 
			// BIO_PT
			// 
			this.BIO_PT.HeaderText = "単体テスト";
			this.BIO_PT.Name = "BIO_PT";
			// 
			// BIO_IT
			// 
			this.BIO_IT.HeaderText = "結合テスト";
			this.BIO_IT.Name = "BIO_IT";
			// 
			// BIO_ST
			// 
			this.BIO_ST.HeaderText = "システムテスト";
			this.BIO_ST.Name = "BIO_ST";
			// 
			// BIO_IR
			// 
			this.BIO_IR.HeaderText = "障害対応";
			this.BIO_IR.Name = "BIO_IR";
			// 
			// BIO_SI
			// 
			this.BIO_SI.HeaderText = "システム導入";
			this.BIO_SI.Name = "BIO_SI";
			// 
			// BIO_IW
			// 
			this.BIO_IW.HeaderText = "開発外社内作業";
			this.BIO_IW.Name = "BIO_IW";
			// 
			// BIO_OTH
			// 
			this.BIO_OTH.HeaderText = "その他";
			this.BIO_OTH.Name = "BIO_OTH";
			// 
			// btn_Ok
			// 
			this.btn_Ok.Location = new System.Drawing.Point(915, 313);
			this.btn_Ok.Name = "btn_Ok";
			this.btn_Ok.Size = new System.Drawing.Size(75, 36);
			this.btn_Ok.TabIndex = 20;
			this.btn_Ok.Text = "追加";
			this.btn_Ok.UseVisualStyleBackColor = true;
			this.btn_Ok.Click += new System.EventHandler(this.btn_OK_Click);
			// 
			// btn_Clear
			// 
			this.btn_Clear.Location = new System.Drawing.Point(1158, 313);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new System.Drawing.Size(75, 36);
			this.btn_Clear.TabIndex = 21;
			this.btn_Clear.Text = "クリア";
			this.btn_Clear.UseVisualStyleBackColor = true;
			this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
			// 
			// Cmd_End
			// 
			this.Cmd_End.Location = new System.Drawing.Point(1239, 313);
			this.Cmd_End.Name = "Cmd_End";
			this.Cmd_End.Size = new System.Drawing.Size(72, 36);
			this.Cmd_End.TabIndex = 23;
			this.Cmd_End.Text = "終了";
			this.Cmd_End.UseVisualStyleBackColor = true;
			this.Cmd_End.Click += new System.EventHandler(this.Cmd_End_Click);
			// 
			// dtp_BirthdayFrom
			// 
			this.dtp_BirthdayFrom.Location = new System.Drawing.Point(108, 73);
			this.dtp_BirthdayFrom.Name = "dtp_BirthdayFrom";
			this.dtp_BirthdayFrom.Size = new System.Drawing.Size(141, 20);
			this.dtp_BirthdayFrom.TabIndex = 7;
			this.dtp_BirthdayFrom.Value = new System.DateTime(2017, 5, 9, 14, 12, 41, 590);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(1077, 313);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(75, 36);
			this.btn_Delete.TabIndex = 22;
			this.btn_Delete.Text = "削除";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// cmb_Engineer
			// 
			this.cmb_Engineer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.cmb_Engineer.FormattingEnabled = true;
			this.cmb_Engineer.Location = new System.Drawing.Point(109, 46);
			this.cmb_Engineer.Name = "cmb_Engineer";
			this.cmb_Engineer.Size = new System.Drawing.Size(190, 21);
			this.cmb_Engineer.TabIndex = 32;
			this.cmb_Engineer.SelectedIndexChanged += new System.EventHandler(this.cmb_Engineer_SelectedIndexChanged);
			// 
			// dtp_BirthdayTo
			// 
			this.dtp_BirthdayTo.Location = new System.Drawing.Point(282, 73);
			this.dtp_BirthdayTo.Name = "dtp_BirthdayTo";
			this.dtp_BirthdayTo.Size = new System.Drawing.Size(141, 20);
			this.dtp_BirthdayTo.TabIndex = 33;
			this.dtp_BirthdayTo.Value = new System.DateTime(2017, 5, 9, 14, 12, 41, 590);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(255, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 13);
			this.label3.TabIndex = 34;
			this.label3.Text = "～";
			// 
			// txt_Gaiyo
			// 
			this.txt_Gaiyo.ImeMode = System.Windows.Forms.ImeMode.On;
			this.txt_Gaiyo.Location = new System.Drawing.Point(108, 127);
			this.txt_Gaiyo.Multiline = true;
			this.txt_Gaiyo.Name = "txt_Gaiyo";
			this.txt_Gaiyo.OldText = null;
			this.txt_Gaiyo.Size = new System.Drawing.Size(378, 20);
			this.txt_Gaiyo.TabIndex = 36;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.GreenYellow;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(11, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 20);
			this.label4.TabIndex = 35;
			this.label4.Text = "概要";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.GreenYellow;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Location = new System.Drawing.Point(11, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 20);
			this.label5.TabIndex = 37;
			this.label5.Text = "ポジション";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.GreenYellow;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Location = new System.Drawing.Point(245, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 20);
			this.label6.TabIndex = 38;
			this.label6.Text = "役割";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.GreenYellow;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Location = new System.Drawing.Point(481, 160);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(91, 20);
			this.label7.TabIndex = 39;
			this.label7.Text = "人数";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmb_Position
			// 
			this.cmb_Position.FormattingEnabled = true;
			this.cmb_Position.Location = new System.Drawing.Point(108, 160);
			this.cmb_Position.Name = "cmb_Position";
			this.cmb_Position.Size = new System.Drawing.Size(121, 21);
			this.cmb_Position.TabIndex = 40;
			// 
			// cmb_Yakuwari
			// 
			this.cmb_Yakuwari.FormattingEnabled = true;
			this.cmb_Yakuwari.Location = new System.Drawing.Point(342, 159);
			this.cmb_Yakuwari.Name = "cmb_Yakuwari";
			this.cmb_Yakuwari.Size = new System.Drawing.Size(121, 21);
			this.cmb_Yakuwari.TabIndex = 41;
			// 
			// nud_People
			// 
			this.nud_People.BackColor = System.Drawing.SystemColors.Window;
			this.nud_People.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nud_People.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.nud_People.ForeColor = System.Drawing.SystemColors.WindowText;
			this.nud_People.Location = new System.Drawing.Point(578, 159);
			this.nud_People.Name = "nud_People";
			this.nud_People.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.nud_People.Size = new System.Drawing.Size(80, 21);
			this.nud_People.TabIndex = 42;
			this.nud_People.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nud_People.ThousandsSeparator = true;
			// 
			// btxt_Work
			// 
			this.btxt_Work.ImeMode = System.Windows.Forms.ImeMode.On;
			this.btxt_Work.Location = new System.Drawing.Point(109, 192);
			this.btxt_Work.Multiline = true;
			this.btxt_Work.Name = "btxt_Work";
			this.btxt_Work.OldText = null;
			this.btxt_Work.Size = new System.Drawing.Size(378, 20);
			this.btxt_Work.TabIndex = 44;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.GreenYellow;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(11, 191);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 20);
			this.label8.TabIndex = 43;
			this.label8.Text = "作業内容";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lst_Hard
			// 
			this.lst_Hard.FormattingEnabled = true;
			this.lst_Hard.Location = new System.Drawing.Point(11, 243);
			this.lst_Hard.Name = "lst_Hard";
			this.lst_Hard.Size = new System.Drawing.Size(226, 64);
			this.lst_Hard.TabIndex = 45;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.GreenYellow;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Location = new System.Drawing.Point(11, 220);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(91, 20);
			this.label9.TabIndex = 46;
			this.label9.Text = "ハード";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.GreenYellow;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Location = new System.Drawing.Point(245, 220);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(91, 20);
			this.label11.TabIndex = 48;
			this.label11.Text = "ＯＳ";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lst_Os
			// 
			this.lst_Os.FormattingEnabled = true;
			this.lst_Os.Location = new System.Drawing.Point(245, 243);
			this.lst_Os.Name = "lst_Os";
			this.lst_Os.Size = new System.Drawing.Size(226, 64);
			this.lst_Os.TabIndex = 47;
			// 
			// btn_Change
			// 
			this.btn_Change.Location = new System.Drawing.Point(996, 313);
			this.btn_Change.Name = "btn_Change";
			this.btn_Change.Size = new System.Drawing.Size(75, 36);
			this.btn_Change.TabIndex = 49;
			this.btn_Change.Text = "変更";
			this.btn_Change.UseVisualStyleBackColor = true;
			this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
			// 
			// lst_Cord
			// 
			this.lst_Cord.FormattingEnabled = true;
			this.lst_Cord.Location = new System.Drawing.Point(477, 243);
			this.lst_Cord.Name = "lst_Cord";
			this.lst_Cord.Size = new System.Drawing.Size(226, 64);
			this.lst_Cord.TabIndex = 50;
			// 
			// lst_Db
			// 
			this.lst_Db.FormattingEnabled = true;
			this.lst_Db.Location = new System.Drawing.Point(709, 243);
			this.lst_Db.Name = "lst_Db";
			this.lst_Db.Size = new System.Drawing.Size(226, 64);
			this.lst_Db.TabIndex = 51;
			// 
			// lst_Tool
			// 
			this.lst_Tool.FormattingEnabled = true;
			this.lst_Tool.Location = new System.Drawing.Point(941, 243);
			this.lst_Tool.Name = "lst_Tool";
			this.lst_Tool.Size = new System.Drawing.Size(224, 64);
			this.lst_Tool.TabIndex = 52;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.GreenYellow;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label12.Location = new System.Drawing.Point(477, 220);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(91, 20);
			this.label12.TabIndex = 53;
			this.label12.Text = "言語";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.GreenYellow;
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label13.Location = new System.Drawing.Point(709, 220);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(91, 20);
			this.label13.TabIndex = 54;
			this.label13.Text = "ＤＢ";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.GreenYellow;
			this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label14.Location = new System.Drawing.Point(943, 219);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(91, 20);
			this.label14.TabIndex = 55;
			this.label14.Text = "ツール";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chk_Yoken
			// 
			this.chk_Yoken.AutoSize = true;
			this.chk_Yoken.Location = new System.Drawing.Point(774, 103);
			this.chk_Yoken.Name = "chk_Yoken";
			this.chk_Yoken.Size = new System.Drawing.Size(15, 14);
			this.chk_Yoken.TabIndex = 56;
			this.chk_Yoken.UseVisualStyleBackColor = true;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.GreenYellow;
			this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label15.Location = new System.Drawing.Point(677, 100);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(91, 20);
			this.label15.TabIndex = 57;
			this.label15.Text = "要件定義";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.GreenYellow;
			this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label17.Location = new System.Drawing.Point(794, 100);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(91, 20);
			this.label17.TabIndex = 59;
			this.label17.Text = "調査分析";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.GreenYellow;
			this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label18.Location = new System.Drawing.Point(909, 100);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(91, 20);
			this.label18.TabIndex = 60;
			this.label18.Text = "ＤＢ設計";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.GreenYellow;
			this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label19.Location = new System.Drawing.Point(1026, 100);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(91, 20);
			this.label19.TabIndex = 61;
			this.label19.Text = "基本設計";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.GreenYellow;
			this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label20.Location = new System.Drawing.Point(1143, 99);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(91, 20);
			this.label20.TabIndex = 62;
			this.label20.Text = "詳細設計";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.GreenYellow;
			this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label21.Location = new System.Drawing.Point(121, 31);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(91, 20);
			this.label21.TabIndex = 63;
			this.label21.Text = "製造";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.GreenYellow;
			this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label22.Location = new System.Drawing.Point(6, 30);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(91, 20);
			this.label22.TabIndex = 64;
			this.label22.Text = "設計";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.GreenYellow;
			this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label23.Location = new System.Drawing.Point(236, 30);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(91, 20);
			this.label23.TabIndex = 65;
			this.label23.Text = "テスト";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.GreenYellow;
			this.label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label24.Location = new System.Drawing.Point(677, 191);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(91, 20);
			this.label24.TabIndex = 66;
			this.label24.Text = "結合テスト";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chk_Cyosa
			// 
			this.chk_Cyosa.AutoSize = true;
			this.chk_Cyosa.Location = new System.Drawing.Point(888, 102);
			this.chk_Cyosa.Name = "chk_Cyosa";
			this.chk_Cyosa.Size = new System.Drawing.Size(15, 14);
			this.chk_Cyosa.TabIndex = 68;
			this.chk_Cyosa.UseVisualStyleBackColor = true;
			// 
			// chk_DbSekei
			// 
			this.chk_DbSekei.AutoSize = true;
			this.chk_DbSekei.Location = new System.Drawing.Point(1005, 102);
			this.chk_DbSekei.Name = "chk_DbSekei";
			this.chk_DbSekei.Size = new System.Drawing.Size(15, 14);
			this.chk_DbSekei.TabIndex = 69;
			this.chk_DbSekei.UseVisualStyleBackColor = true;
			// 
			// chk_StdSekei
			// 
			this.chk_StdSekei.AutoSize = true;
			this.chk_StdSekei.Location = new System.Drawing.Point(1122, 102);
			this.chk_StdSekei.Name = "chk_StdSekei";
			this.chk_StdSekei.Size = new System.Drawing.Size(15, 14);
			this.chk_StdSekei.TabIndex = 70;
			this.chk_StdSekei.UseVisualStyleBackColor = true;
			// 
			// chk_DtlSekei
			// 
			this.chk_DtlSekei.AutoSize = true;
			this.chk_DtlSekei.Location = new System.Drawing.Point(1240, 103);
			this.chk_DtlSekei.Name = "chk_DtlSekei";
			this.chk_DtlSekei.Size = new System.Drawing.Size(15, 14);
			this.chk_DtlSekei.TabIndex = 71;
			this.chk_DtlSekei.UseVisualStyleBackColor = true;
			// 
			// chk_Sekei
			// 
			this.chk_Sekei.AutoSize = true;
			this.chk_Sekei.Location = new System.Drawing.Point(101, 35);
			this.chk_Sekei.Name = "chk_Sekei";
			this.chk_Sekei.Size = new System.Drawing.Size(15, 14);
			this.chk_Sekei.TabIndex = 72;
			this.chk_Sekei.UseVisualStyleBackColor = true;
			// 
			// grp_Program
			// 
			this.grp_Program.Controls.Add(this.chk_Test);
			this.grp_Program.Controls.Add(this.chk_Production);
			this.grp_Program.Controls.Add(this.label16);
			this.grp_Program.Controls.Add(this.label22);
			this.grp_Program.Controls.Add(this.chk_Sekei);
			this.grp_Program.Controls.Add(this.label21);
			this.grp_Program.Controls.Add(this.label23);
			this.grp_Program.Location = new System.Drawing.Point(673, 127);
			this.grp_Program.Name = "grp_Program";
			this.grp_Program.Size = new System.Drawing.Size(361, 55);
			this.grp_Program.TabIndex = 73;
			this.grp_Program.TabStop = false;
			this.grp_Program.Text = "プログラム";
			// 
			// chk_Test
			// 
			this.chk_Test.AutoSize = true;
			this.chk_Test.Location = new System.Drawing.Point(334, 32);
			this.chk_Test.Name = "chk_Test";
			this.chk_Test.Size = new System.Drawing.Size(15, 14);
			this.chk_Test.TabIndex = 74;
			this.chk_Test.UseVisualStyleBackColor = true;
			// 
			// chk_Production
			// 
			this.chk_Production.AutoSize = true;
			this.chk_Production.Location = new System.Drawing.Point(215, 34);
			this.chk_Production.Name = "chk_Production";
			this.chk_Production.Size = new System.Drawing.Size(15, 14);
			this.chk_Production.TabIndex = 73;
			this.chk_Production.UseVisualStyleBackColor = true;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.GreenYellow;
			this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label16.Location = new System.Drawing.Point(4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(91, 20);
			this.label16.TabIndex = 82;
			this.label16.Text = "プログラム";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.GreenYellow;
			this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label25.Location = new System.Drawing.Point(794, 192);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(109, 20);
			this.label25.TabIndex = 74;
			this.label25.Text = "システムテスト";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.GreenYellow;
			this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label26.Location = new System.Drawing.Point(929, 192);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(91, 20);
			this.label26.TabIndex = 75;
			this.label26.Text = "障害対応";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.GreenYellow;
			this.label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label27.Location = new System.Drawing.Point(1047, 191);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(103, 20);
			this.label27.TabIndex = 76;
			this.label27.Text = "システム導入";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chk_SogoTest
			// 
			this.chk_SogoTest.AutoSize = true;
			this.chk_SogoTest.Location = new System.Drawing.Point(774, 195);
			this.chk_SogoTest.Name = "chk_SogoTest";
			this.chk_SogoTest.Size = new System.Drawing.Size(15, 14);
			this.chk_SogoTest.TabIndex = 75;
			this.chk_SogoTest.UseVisualStyleBackColor = true;
			// 
			// chk_SysTest
			// 
			this.chk_SysTest.AutoSize = true;
			this.chk_SysTest.Location = new System.Drawing.Point(909, 195);
			this.chk_SysTest.Name = "chk_SysTest";
			this.chk_SysTest.Size = new System.Drawing.Size(15, 14);
			this.chk_SysTest.TabIndex = 77;
			this.chk_SysTest.UseVisualStyleBackColor = true;
			// 
			// chk_Syogai
			// 
			this.chk_Syogai.AutoSize = true;
			this.chk_Syogai.Location = new System.Drawing.Point(1026, 195);
			this.chk_Syogai.Name = "chk_Syogai";
			this.chk_Syogai.Size = new System.Drawing.Size(15, 14);
			this.chk_Syogai.TabIndex = 78;
			this.chk_Syogai.UseVisualStyleBackColor = true;
			// 
			// chk_SysIntroduction
			// 
			this.chk_SysIntroduction.AutoSize = true;
			this.chk_SysIntroduction.Location = new System.Drawing.Point(1156, 195);
			this.chk_SysIntroduction.Name = "chk_SysIntroduction";
			this.chk_SysIntroduction.Size = new System.Drawing.Size(15, 14);
			this.chk_SysIntroduction.TabIndex = 79;
			this.chk_SysIntroduction.UseVisualStyleBackColor = true;
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.GreenYellow;
			this.label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label28.Location = new System.Drawing.Point(1177, 191);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(110, 20);
			this.label28.TabIndex = 80;
			this.label28.Text = "開発外社内作業";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chk_Company
			// 
			this.chk_Company.AutoSize = true;
			this.chk_Company.Location = new System.Drawing.Point(1293, 195);
			this.chk_Company.Name = "chk_Company";
			this.chk_Company.Size = new System.Drawing.Size(15, 14);
			this.chk_Company.TabIndex = 81;
			this.chk_Company.UseVisualStyleBackColor = true;
			// 
			// frmMnt111
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1322, 688);
			this.Controls.Add(this.chk_Company);
			this.Controls.Add(this.label28);
			this.Controls.Add(this.chk_SysIntroduction);
			this.Controls.Add(this.chk_Syogai);
			this.Controls.Add(this.chk_SysTest);
			this.Controls.Add(this.chk_SogoTest);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.grp_Program);
			this.Controls.Add(this.chk_DtlSekei);
			this.Controls.Add(this.chk_StdSekei);
			this.Controls.Add(this.chk_DbSekei);
			this.Controls.Add(this.chk_Cyosa);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.chk_Yoken);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.lst_Tool);
			this.Controls.Add(this.lst_Db);
			this.Controls.Add(this.lst_Cord);
			this.Controls.Add(this.btn_Change);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.lst_Os);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lst_Hard);
			this.Controls.Add(this.btxt_Work);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.nud_People);
			this.Controls.Add(this.cmb_Yakuwari);
			this.Controls.Add(this.cmb_Position);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_Gaiyo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtp_BirthdayTo);
			this.Controls.Add(this.cmb_Engineer);
			this.Controls.Add(this.txt_UserType);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.dtp_BirthdayFrom);
			this.Controls.Add(this.Cmd_End);
			this.Controls.Add(this.btn_Clear);
			this.Controls.Add(this.btn_Ok);
			this.Controls.Add(this.dgv_EngineerCareer);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmMnt111";
			this.Text = "frmMNT111";
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label10, 0);
			this.Controls.SetChildIndex(this.dgv_EngineerCareer, 0);
			this.Controls.SetChildIndex(this.btn_Ok, 0);
			this.Controls.SetChildIndex(this.btn_Clear, 0);
			this.Controls.SetChildIndex(this.Cmd_End, 0);
			this.Controls.SetChildIndex(this.dtp_BirthdayFrom, 0);
			this.Controls.SetChildIndex(this.btn_Delete, 0);
			this.Controls.SetChildIndex(this.txt_UserType, 0);
			this.Controls.SetChildIndex(this.cmb_Engineer, 0);
			this.Controls.SetChildIndex(this.dtp_BirthdayTo, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.txt_Gaiyo, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.cmb_Position, 0);
			this.Controls.SetChildIndex(this.cmb_Yakuwari, 0);
			this.Controls.SetChildIndex(this.nud_People, 0);
			this.Controls.SetChildIndex(this.label8, 0);
			this.Controls.SetChildIndex(this.btxt_Work, 0);
			this.Controls.SetChildIndex(this.lst_Hard, 0);
			this.Controls.SetChildIndex(this.label9, 0);
			this.Controls.SetChildIndex(this.lst_Os, 0);
			this.Controls.SetChildIndex(this.label11, 0);
			this.Controls.SetChildIndex(this.btn_Change, 0);
			this.Controls.SetChildIndex(this.lst_Cord, 0);
			this.Controls.SetChildIndex(this.lst_Db, 0);
			this.Controls.SetChildIndex(this.lst_Tool, 0);
			this.Controls.SetChildIndex(this.label12, 0);
			this.Controls.SetChildIndex(this.label13, 0);
			this.Controls.SetChildIndex(this.label14, 0);
			this.Controls.SetChildIndex(this.chk_Yoken, 0);
			this.Controls.SetChildIndex(this.label15, 0);
			this.Controls.SetChildIndex(this.label17, 0);
			this.Controls.SetChildIndex(this.label18, 0);
			this.Controls.SetChildIndex(this.label19, 0);
			this.Controls.SetChildIndex(this.label20, 0);
			this.Controls.SetChildIndex(this.label24, 0);
			this.Controls.SetChildIndex(this.chk_Cyosa, 0);
			this.Controls.SetChildIndex(this.chk_DbSekei, 0);
			this.Controls.SetChildIndex(this.chk_StdSekei, 0);
			this.Controls.SetChildIndex(this.chk_DtlSekei, 0);
			this.Controls.SetChildIndex(this.grp_Program, 0);
			this.Controls.SetChildIndex(this.label25, 0);
			this.Controls.SetChildIndex(this.label26, 0);
			this.Controls.SetChildIndex(this.label27, 0);
			this.Controls.SetChildIndex(this.chk_SogoTest, 0);
			this.Controls.SetChildIndex(this.chk_SysTest, 0);
			this.Controls.SetChildIndex(this.chk_Syogai, 0);
			this.Controls.SetChildIndex(this.chk_SysIntroduction, 0);
			this.Controls.SetChildIndex(this.label28, 0);
			this.Controls.SetChildIndex(this.chk_Company, 0);
			((System.ComponentModel.ISupportInitialize)(this.dgv_EngineerCareer)).EndInit();
			this.grp_Program.ResumeLayout(false);
			this.grp_Program.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Sugitec.Common.ctlBytTextBoxEx txt_UserType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private Sugitec.Common.ucDataGridViewEx dgv_EngineerCareer;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button Cmd_End;
        private Sugitec.Common.ctlDateTimePickerEx dtp_BirthdayFrom;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ComboBox cmb_Engineer;
        private Common.ctlDateTimePickerEx dtp_BirthdayTo;
        private System.Windows.Forms.Label label3;
        private Common.ctlBytTextBoxEx txt_Gaiyo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Position;
        private System.Windows.Forms.ComboBox cmb_Yakuwari;
        private Common.ucNumUpDown nud_People;
        private Common.ctlBytTextBoxEx btxt_Work;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox lst_Hard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox lst_Os;
        private System.Windows.Forms.Button btn_Change;
		private System.Windows.Forms.CheckedListBox lst_Cord;
		private System.Windows.Forms.CheckedListBox lst_Db;
		private System.Windows.Forms.CheckedListBox lst_Tool;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox chk_Yoken;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.CheckBox chk_Cyosa;
		private System.Windows.Forms.CheckBox chk_DbSekei;
		private System.Windows.Forms.CheckBox chk_StdSekei;
		private System.Windows.Forms.CheckBox chk_DtlSekei;
		private System.Windows.Forms.CheckBox chk_Sekei;
		private System.Windows.Forms.GroupBox grp_Program;
		private System.Windows.Forms.CheckBox chk_Test;
		private System.Windows.Forms.CheckBox chk_Production;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.CheckBox chk_SogoTest;
		private System.Windows.Forms.CheckBox chk_SysTest;
		private System.Windows.Forms.CheckBox chk_Syogai;
		private System.Windows.Forms.CheckBox chk_SysIntroduction;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.CheckBox chk_Company;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.DataGridViewTextBoxColumn ENGINEER_ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn BIO_NO;
		private System.Windows.Forms.DataGridViewTextBoxColumn BIO_START_YMD;
		private System.Windows.Forms.DataGridViewTextBoxColumn BIO_END_YMD;
		private System.Windows.Forms.DataGridViewTextBoxColumn BIO_BUS_TYP;
		private System.Windows.Forms.DataGridViewTextBoxColumn BIO_OVERVIEW;
		private System.Windows.Forms.DataGridViewComboBoxColumn BIO_POSITION;
		private System.Windows.Forms.DataGridViewComboBoxColumn BIO_ROLE;
		private System.Windows.Forms.DataGridViewTextBoxColumn BIO_NUM;
		private System.Windows.Forms.DataGridViewTextBoxColumn BIO_WORK;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BIO_RD;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BIO_SA;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BIO_DD;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BIO_UI;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BIO_PS;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BIO_PD;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BIO_PG;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BIO_PT;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BIO_IT;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BIO_ST;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BIO_IR;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BIO_SI;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BIO_IW;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BIO_OTH;
	}
}