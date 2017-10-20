namespace Sugitec
{
    partial class frmDisplay
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgv_result = new Sugitec.Common.ctlDataGridViewEx();
			this.panel1 = new System.Windows.Forms.Panel();
			this.gbxStat = new System.Windows.Forms.GroupBox();
			this.btnAllSeach = new System.Windows.Forms.Button();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.rdoPubY = new System.Windows.Forms.RadioButton();
			this.rdoPubN = new System.Windows.Forms.RadioButton();
			this.btnSearch = new System.Windows.Forms.Button();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.rdoFinY = new System.Windows.Forms.RadioButton();
			this.rdoFinN = new System.Windows.Forms.RadioButton();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.rdoBillY = new System.Windows.Forms.RadioButton();
			this.rdoBillN = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.rdoSalY = new System.Windows.Forms.RadioButton();
			this.rdoSalN = new System.Windows.Forms.RadioButton();
			this.gbxCus = new System.Windows.Forms.GroupBox();
			this.cmbCus = new System.Windows.Forms.ComboBox();
			this.rdoCus2 = new System.Windows.Forms.RadioButton();
			this.rdoCus1 = new System.Windows.Forms.RadioButton();
			this.txtCusT = new Sugitec.Common.ucNumTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCusF = new Sugitec.Common.ucNumTextBox();
			this.gbxEng = new System.Windows.Forms.GroupBox();
			this.cmbEng = new System.Windows.Forms.ComboBox();
			this.rdoEng2 = new System.Windows.Forms.RadioButton();
			this.rdoEng1 = new System.Windows.Forms.RadioButton();
			this.txtEngT = new Sugitec.Common.ucNumTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEngF = new Sugitec.Common.ucNumTextBox();
			this.gbxOrder = new System.Windows.Forms.GroupBox();
			this.mtbSallYm = new Sugitec.Common.ucYMTextbox();
			this.mtbSallYmT = new Sugitec.Common.ucYMTextbox();
			this.mtbSallYmF = new Sugitec.Common.ucYMTextbox();
			this.rdoOrd2 = new System.Windows.Forms.RadioButton();
			this.rdoOrd1 = new System.Windows.Forms.RadioButton();
			this.label14 = new System.Windows.Forms.Label();
			this.btnClr = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			this.dgv_orderYm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_orderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_salNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_reqNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_cusNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_engNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_sal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_req = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_pub = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
			this.panel1.SuspendLayout();
			this.gbxStat.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.gbxCus.SuspendLayout();
			this.gbxEng.SuspendLayout();
			this.gbxOrder.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv_result
			// 
			this.dgv_result.AllowUserToAddRows = false;
			this.dgv_result.AllowUserToDeleteRows = false;
			this.dgv_result.AllowUserToResizeRows = false;
			this.dgv_result.ColumnHeaderBorderStyle = Sugitec.Common.ctlDataGridViewEx.HeaderCellBorderStyle.SingleLine;
			this.dgv_result.ColumnHeaderRowCount = 1;
			this.dgv_result.ColumnHeaderRowHeight = 17;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_result.ColumnHeadersHeight = 22;
			this.dgv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_orderYm,
            this.dgv_orderNo,
            this.dgv_salNo,
            this.dgv_reqNum,
            this.dgv_cusNm,
            this.dgv_engNm,
            this.dgv_sal,
            this.dgv_req,
            this.dgv_pub,
            this.dgv_fin});
			this.dgv_result.Cursor = System.Windows.Forms.Cursors.Default;
			this.dgv_result.Location = new System.Drawing.Point(14, 174);
			this.dgv_result.Name = "dgv_result";
			this.dgv_result.ReadOnly = true;
			this.dgv_result.RowHeadersVisible = false;
			this.dgv_result.RowTemplate.Height = 21;
			this.dgv_result.Size = new System.Drawing.Size(1048, 317);
			this.dgv_result.TabIndex = 63;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.gbxStat);
			this.panel1.Controls.Add(this.gbxCus);
			this.panel1.Controls.Add(this.gbxEng);
			this.panel1.Controls.Add(this.gbxOrder);
			this.panel1.Location = new System.Drawing.Point(14, 44);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1048, 124);
			this.panel1.TabIndex = 64;
			// 
			// gbxStat
			// 
			this.gbxStat.Controls.Add(this.btnAllSeach);
			this.gbxStat.Controls.Add(this.groupBox7);
			this.gbxStat.Controls.Add(this.btnSearch);
			this.gbxStat.Controls.Add(this.groupBox8);
			this.gbxStat.Controls.Add(this.groupBox6);
			this.gbxStat.Controls.Add(this.groupBox4);
			this.gbxStat.Location = new System.Drawing.Point(795, 1);
			this.gbxStat.Name = "gbxStat";
			this.gbxStat.Size = new System.Drawing.Size(248, 118);
			this.gbxStat.TabIndex = 11;
			this.gbxStat.TabStop = false;
			this.gbxStat.Text = "状態区分";
			// 
			// btnAllSeach
			// 
			this.btnAllSeach.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnAllSeach.Location = new System.Drawing.Point(11, 92);
			this.btnAllSeach.Name = "btnAllSeach";
			this.btnAllSeach.Size = new System.Drawing.Size(73, 22);
			this.btnAllSeach.TabIndex = 11;
			this.btnAllSeach.Text = "全てを表示";
			this.btnAllSeach.UseVisualStyleBackColor = true;
			this.btnAllSeach.Click += new System.EventHandler(this.btnAllStateSeach_Click);
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.rdoPubY);
			this.groupBox7.Controls.Add(this.rdoPubN);
			this.groupBox7.Location = new System.Drawing.Point(121, 15);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(64, 75);
			this.groupBox7.TabIndex = 9;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "請求書";
			// 
			// rdoPubY
			// 
			this.rdoPubY.AutoSize = true;
			this.rdoPubY.Location = new System.Drawing.Point(6, 42);
			this.rdoPubY.Name = "rdoPubY";
			this.rdoPubY.Size = new System.Drawing.Size(39, 17);
			this.rdoPubY.TabIndex = 3;
			this.rdoPubY.Text = "済";
			this.rdoPubY.UseVisualStyleBackColor = true;
			// 
			// rdoPubN
			// 
			this.rdoPubN.AutoSize = true;
			this.rdoPubN.Checked = true;
			this.rdoPubN.Location = new System.Drawing.Point(6, 19);
			this.rdoPubN.Name = "rdoPubN";
			this.rdoPubN.Size = new System.Drawing.Size(39, 17);
			this.rdoPubN.TabIndex = 2;
			this.rdoPubN.TabStop = true;
			this.rdoPubN.Text = "未";
			this.rdoPubN.UseVisualStyleBackColor = true;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(103, 92);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(139, 22);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "検索";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.rdoFinY);
			this.groupBox8.Controls.Add(this.rdoFinN);
			this.groupBox8.Location = new System.Drawing.Point(191, 15);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(49, 75);
			this.groupBox8.TabIndex = 10;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "回収";
			// 
			// rdoFinY
			// 
			this.rdoFinY.AutoSize = true;
			this.rdoFinY.Location = new System.Drawing.Point(6, 42);
			this.rdoFinY.Name = "rdoFinY";
			this.rdoFinY.Size = new System.Drawing.Size(39, 17);
			this.rdoFinY.TabIndex = 3;
			this.rdoFinY.Text = "済";
			this.rdoFinY.UseVisualStyleBackColor = true;
			// 
			// rdoFinN
			// 
			this.rdoFinN.AutoSize = true;
			this.rdoFinN.Checked = true;
			this.rdoFinN.Location = new System.Drawing.Point(6, 19);
			this.rdoFinN.Name = "rdoFinN";
			this.rdoFinN.Size = new System.Drawing.Size(39, 17);
			this.rdoFinN.TabIndex = 2;
			this.rdoFinN.TabStop = true;
			this.rdoFinN.Text = "未";
			this.rdoFinN.UseVisualStyleBackColor = true;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.rdoBillY);
			this.groupBox6.Controls.Add(this.rdoBillN);
			this.groupBox6.Location = new System.Drawing.Point(66, 15);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(49, 75);
			this.groupBox6.TabIndex = 8;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "請求";
			// 
			// rdoBillY
			// 
			this.rdoBillY.AutoSize = true;
			this.rdoBillY.Location = new System.Drawing.Point(6, 42);
			this.rdoBillY.Name = "rdoBillY";
			this.rdoBillY.Size = new System.Drawing.Size(39, 17);
			this.rdoBillY.TabIndex = 3;
			this.rdoBillY.Text = "済";
			this.rdoBillY.UseVisualStyleBackColor = true;
			// 
			// rdoBillN
			// 
			this.rdoBillN.AutoSize = true;
			this.rdoBillN.Checked = true;
			this.rdoBillN.Location = new System.Drawing.Point(6, 19);
			this.rdoBillN.Name = "rdoBillN";
			this.rdoBillN.Size = new System.Drawing.Size(39, 17);
			this.rdoBillN.TabIndex = 2;
			this.rdoBillN.TabStop = true;
			this.rdoBillN.Text = "未";
			this.rdoBillN.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.rdoSalY);
			this.groupBox4.Controls.Add(this.rdoSalN);
			this.groupBox4.Location = new System.Drawing.Point(11, 14);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(49, 75);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "売上";
			// 
			// rdoSalY
			// 
			this.rdoSalY.AutoSize = true;
			this.rdoSalY.Location = new System.Drawing.Point(6, 42);
			this.rdoSalY.Name = "rdoSalY";
			this.rdoSalY.Size = new System.Drawing.Size(39, 17);
			this.rdoSalY.TabIndex = 3;
			this.rdoSalY.Text = "済";
			this.rdoSalY.UseVisualStyleBackColor = true;
			// 
			// rdoSalN
			// 
			this.rdoSalN.AutoSize = true;
			this.rdoSalN.Checked = true;
			this.rdoSalN.Location = new System.Drawing.Point(6, 19);
			this.rdoSalN.Name = "rdoSalN";
			this.rdoSalN.Size = new System.Drawing.Size(39, 17);
			this.rdoSalN.TabIndex = 2;
			this.rdoSalN.TabStop = true;
			this.rdoSalN.Text = "未";
			this.rdoSalN.UseVisualStyleBackColor = true;
			// 
			// gbxCus
			// 
			this.gbxCus.Controls.Add(this.cmbCus);
			this.gbxCus.Controls.Add(this.rdoCus2);
			this.gbxCus.Controls.Add(this.rdoCus1);
			this.gbxCus.Controls.Add(this.txtCusT);
			this.gbxCus.Controls.Add(this.label2);
			this.gbxCus.Controls.Add(this.txtCusF);
			this.gbxCus.Location = new System.Drawing.Point(279, 1);
			this.gbxCus.Name = "gbxCus";
			this.gbxCus.Size = new System.Drawing.Size(252, 100);
			this.gbxCus.TabIndex = 2;
			this.gbxCus.TabStop = false;
			this.gbxCus.Text = "得意先";
			// 
			// cmbCus
			// 
			this.cmbCus.FormattingEnabled = true;
			this.cmbCus.Location = new System.Drawing.Point(45, 24);
			this.cmbCus.Name = "cmbCus";
			this.cmbCus.Size = new System.Drawing.Size(197, 21);
			this.cmbCus.TabIndex = 1;
			// 
			// rdoCus2
			// 
			this.rdoCus2.AutoSize = true;
			this.rdoCus2.Location = new System.Drawing.Point(15, 57);
			this.rdoCus2.Name = "rdoCus2";
			this.rdoCus2.Size = new System.Drawing.Size(14, 13);
			this.rdoCus2.TabIndex = 2;
			this.rdoCus2.TabStop = true;
			this.rdoCus2.UseVisualStyleBackColor = true;
			// 
			// rdoCus1
			// 
			this.rdoCus1.AutoSize = true;
			this.rdoCus1.Location = new System.Drawing.Point(15, 27);
			this.rdoCus1.Name = "rdoCus1";
			this.rdoCus1.Size = new System.Drawing.Size(14, 13);
			this.rdoCus1.TabIndex = 0;
			this.rdoCus1.TabStop = true;
			this.rdoCus1.UseVisualStyleBackColor = true;
			// 
			// txtCusT
			// 
			this.txtCusT.BackColor = System.Drawing.SystemColors.Window;
			this.txtCusT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtCusT.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericCode;
			this.txtCusT.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtCusT.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCusT.Format = null;
			this.txtCusT.IllegalCharacter = null;
			this.txtCusT.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtCusT.Location = new System.Drawing.Point(161, 54);
			this.txtCusT.MaxLength = 8;
			this.txtCusT.Name = "txtCusT";
			this.txtCusT.OldText = null;
			this.txtCusT.Size = new System.Drawing.Size(81, 20);
			this.txtCusT.TabIndex = 5;
			this.txtCusT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCusT.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.Left;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(132, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "～";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCusF
			// 
			this.txtCusF.BackColor = System.Drawing.SystemColors.Window;
			this.txtCusF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtCusF.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericCode;
			this.txtCusF.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtCusF.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCusF.Format = null;
			this.txtCusF.IllegalCharacter = null;
			this.txtCusF.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtCusF.Location = new System.Drawing.Point(45, 54);
			this.txtCusF.MaxLength = 8;
			this.txtCusF.Name = "txtCusF";
			this.txtCusF.OldText = null;
			this.txtCusF.Size = new System.Drawing.Size(81, 20);
			this.txtCusF.TabIndex = 3;
			this.txtCusF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtCusF.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.Left;
			// 
			// gbxEng
			// 
			this.gbxEng.Controls.Add(this.cmbEng);
			this.gbxEng.Controls.Add(this.rdoEng2);
			this.gbxEng.Controls.Add(this.rdoEng1);
			this.gbxEng.Controls.Add(this.txtEngT);
			this.gbxEng.Controls.Add(this.label4);
			this.gbxEng.Controls.Add(this.txtEngF);
			this.gbxEng.Location = new System.Drawing.Point(537, 1);
			this.gbxEng.Name = "gbxEng";
			this.gbxEng.Size = new System.Drawing.Size(252, 100);
			this.gbxEng.TabIndex = 1;
			this.gbxEng.TabStop = false;
			this.gbxEng.Text = "技術者";
			// 
			// cmbEng
			// 
			this.cmbEng.FormattingEnabled = true;
			this.cmbEng.Location = new System.Drawing.Point(45, 24);
			this.cmbEng.Name = "cmbEng";
			this.cmbEng.Size = new System.Drawing.Size(187, 21);
			this.cmbEng.TabIndex = 1;
			// 
			// rdoEng2
			// 
			this.rdoEng2.AutoSize = true;
			this.rdoEng2.Location = new System.Drawing.Point(15, 57);
			this.rdoEng2.Name = "rdoEng2";
			this.rdoEng2.Size = new System.Drawing.Size(14, 13);
			this.rdoEng2.TabIndex = 2;
			this.rdoEng2.TabStop = true;
			this.rdoEng2.UseVisualStyleBackColor = true;
			// 
			// rdoEng1
			// 
			this.rdoEng1.AutoSize = true;
			this.rdoEng1.Location = new System.Drawing.Point(15, 27);
			this.rdoEng1.Name = "rdoEng1";
			this.rdoEng1.Size = new System.Drawing.Size(14, 13);
			this.rdoEng1.TabIndex = 0;
			this.rdoEng1.TabStop = true;
			this.rdoEng1.UseVisualStyleBackColor = true;
			// 
			// txtEngT
			// 
			this.txtEngT.BackColor = System.Drawing.SystemColors.Window;
			this.txtEngT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtEngT.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericCode;
			this.txtEngT.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtEngT.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtEngT.Format = null;
			this.txtEngT.IllegalCharacter = null;
			this.txtEngT.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtEngT.Location = new System.Drawing.Point(161, 54);
			this.txtEngT.MaxLength = 8;
			this.txtEngT.Name = "txtEngT";
			this.txtEngT.OldText = null;
			this.txtEngT.Size = new System.Drawing.Size(81, 20);
			this.txtEngT.TabIndex = 5;
			this.txtEngT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtEngT.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.Left;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(132, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "～";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtEngF
			// 
			this.txtEngF.BackColor = System.Drawing.SystemColors.Window;
			this.txtEngF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtEngF.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericCode;
			this.txtEngF.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtEngF.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtEngF.Format = null;
			this.txtEngF.IllegalCharacter = null;
			this.txtEngF.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtEngF.Location = new System.Drawing.Point(45, 54);
			this.txtEngF.MaxLength = 8;
			this.txtEngF.Name = "txtEngF";
			this.txtEngF.OldText = null;
			this.txtEngF.Size = new System.Drawing.Size(81, 20);
			this.txtEngF.TabIndex = 3;
			this.txtEngF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtEngF.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.Left;
			// 
			// gbxOrder
			// 
			this.gbxOrder.Controls.Add(this.mtbSallYm);
			this.gbxOrder.Controls.Add(this.mtbSallYmT);
			this.gbxOrder.Controls.Add(this.mtbSallYmF);
			this.gbxOrder.Controls.Add(this.rdoOrd2);
			this.gbxOrder.Controls.Add(this.rdoOrd1);
			this.gbxOrder.Controls.Add(this.label14);
			this.gbxOrder.Location = new System.Drawing.Point(3, 1);
			this.gbxOrder.Name = "gbxOrder";
			this.gbxOrder.Size = new System.Drawing.Size(270, 100);
			this.gbxOrder.TabIndex = 0;
			this.gbxOrder.TabStop = false;
			this.gbxOrder.Text = "受注期間";
			// 
			// mtbSallYm
			// 
			this.mtbSallYm.BackColor = System.Drawing.SystemColors.Window;
			this.mtbSallYm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mtbSallYm.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.mtbSallYm.ForeColor = System.Drawing.SystemColors.WindowText;
			this.mtbSallYm.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.mtbSallYm.Location = new System.Drawing.Point(40, 24);
			this.mtbSallYm.Name = "mtbSallYm";
			this.mtbSallYm.OldValue = null;
			this.mtbSallYm.Size = new System.Drawing.Size(97, 20);
			this.mtbSallYm.TabIndex = 1;
			this.mtbSallYm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// mtbSallYmT
			// 
			this.mtbSallYmT.BackColor = System.Drawing.SystemColors.Window;
			this.mtbSallYmT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mtbSallYmT.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.mtbSallYmT.ForeColor = System.Drawing.SystemColors.WindowText;
			this.mtbSallYmT.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.mtbSallYmT.Location = new System.Drawing.Point(166, 54);
			this.mtbSallYmT.Name = "mtbSallYmT";
			this.mtbSallYmT.OldValue = null;
			this.mtbSallYmT.Size = new System.Drawing.Size(97, 20);
			this.mtbSallYmT.TabIndex = 5;
			this.mtbSallYmT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// mtbSallYmF
			// 
			this.mtbSallYmF.BackColor = System.Drawing.SystemColors.Window;
			this.mtbSallYmF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mtbSallYmF.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.mtbSallYmF.ForeColor = System.Drawing.SystemColors.WindowText;
			this.mtbSallYmF.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.mtbSallYmF.Location = new System.Drawing.Point(40, 54);
			this.mtbSallYmF.Name = "mtbSallYmF";
			this.mtbSallYmF.OldValue = null;
			this.mtbSallYmF.Size = new System.Drawing.Size(97, 20);
			this.mtbSallYmF.TabIndex = 3;
			this.mtbSallYmF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// rdoOrd2
			// 
			this.rdoOrd2.AutoSize = true;
			this.rdoOrd2.Location = new System.Drawing.Point(11, 57);
			this.rdoOrd2.Name = "rdoOrd2";
			this.rdoOrd2.Size = new System.Drawing.Size(14, 13);
			this.rdoOrd2.TabIndex = 2;
			this.rdoOrd2.TabStop = true;
			this.rdoOrd2.UseVisualStyleBackColor = true;
			// 
			// rdoOrd1
			// 
			this.rdoOrd1.AutoSize = true;
			this.rdoOrd1.Location = new System.Drawing.Point(11, 27);
			this.rdoOrd1.Name = "rdoOrd1";
			this.rdoOrd1.Size = new System.Drawing.Size(14, 13);
			this.rdoOrd1.TabIndex = 0;
			this.rdoOrd1.TabStop = true;
			this.rdoOrd1.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(141, 54);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(20, 20);
			this.label14.TabIndex = 4;
			this.label14.Text = "～";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnClr
			// 
			this.btnClr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClr.Location = new System.Drawing.Point(870, 497);
			this.btnClr.Name = "btnClr";
			this.btnClr.Size = new System.Drawing.Size(93, 43);
			this.btnClr.TabIndex = 65;
			this.btnClr.Text = "クリア";
			this.btnClr.UseVisualStyleBackColor = true;
			this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEnd.Location = new System.Drawing.Point(969, 497);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(93, 43);
			this.btnEnd.TabIndex = 66;
			this.btnEnd.Text = "終了";
			this.btnEnd.UseVisualStyleBackColor = true;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// dgv_orderYm
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dgv_orderYm.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_orderYm.HeaderText = "受注期間";
			this.dgv_orderYm.Name = "dgv_orderYm";
			this.dgv_orderYm.ReadOnly = true;
			// 
			// dgv_orderNo
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dgv_orderNo.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_orderNo.HeaderText = "受注No.";
			this.dgv_orderNo.Name = "dgv_orderNo";
			this.dgv_orderNo.ReadOnly = true;
			this.dgv_orderNo.Width = 70;
			// 
			// dgv_salNo
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dgv_salNo.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_salNo.HeaderText = "売上No";
			this.dgv_salNo.Name = "dgv_salNo";
			this.dgv_salNo.ReadOnly = true;
			this.dgv_salNo.Width = 70;
			// 
			// dgv_reqNum
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dgv_reqNum.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgv_reqNum.HeaderText = "請求No";
			this.dgv_reqNum.Name = "dgv_reqNum";
			this.dgv_reqNum.ReadOnly = true;
			this.dgv_reqNum.Width = 70;
			// 
			// dgv_cusNm
			// 
			this.dgv_cusNm.HeaderText = "得意先名";
			this.dgv_cusNm.Name = "dgv_cusNm";
			this.dgv_cusNm.ReadOnly = true;
			this.dgv_cusNm.Width = 150;
			// 
			// dgv_engNm
			// 
			this.dgv_engNm.HeaderText = "技術者名";
			this.dgv_engNm.Name = "dgv_engNm";
			this.dgv_engNm.ReadOnly = true;
			this.dgv_engNm.Width = 150;
			// 
			// dgv_sal
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.dgv_sal.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgv_sal.HeaderText = "売上状態";
			this.dgv_sal.Name = "dgv_sal";
			this.dgv_sal.ReadOnly = true;
			// 
			// dgv_req
			// 
			this.dgv_req.HeaderText = "請求状態";
			this.dgv_req.Name = "dgv_req";
			this.dgv_req.ReadOnly = true;
			// 
			// dgv_pub
			// 
			this.dgv_pub.HeaderText = "請求書";
			this.dgv_pub.Name = "dgv_pub";
			this.dgv_pub.ReadOnly = true;
			// 
			// dgv_fin
			// 
			this.dgv_fin.HeaderText = "回収状態";
			this.dgv_fin.Name = "dgv_fin";
			this.dgv_fin.ReadOnly = true;
			// 
			// frmDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1074, 572);
			this.Controls.Add(this.btnClr);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgv_result);
			this.Name = "frmDisplay";
			this.Text = "frmDisplay";
			this.Controls.SetChildIndex(this.dgv_result, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.btnEnd, 0);
			this.Controls.SetChildIndex(this.btnClr, 0);
			((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
			this.panel1.ResumeLayout(false);
			this.gbxStat.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.gbxCus.ResumeLayout(false);
			this.gbxCus.PerformLayout();
			this.gbxEng.ResumeLayout(false);
			this.gbxEng.PerformLayout();
			this.gbxOrder.ResumeLayout(false);
			this.gbxOrder.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Common.ctlDataGridViewEx dgv_result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoSalY;
        private System.Windows.Forms.RadioButton rdoSalN;
        private System.Windows.Forms.GroupBox gbxCus;
        private System.Windows.Forms.RadioButton rdoCus2;
        private System.Windows.Forms.RadioButton rdoCus1;
        private Common.ucNumTextBox txtCusT;
        private System.Windows.Forms.Label label2;
        private Common.ucNumTextBox txtCusF;
        private System.Windows.Forms.GroupBox gbxEng;
        private System.Windows.Forms.ComboBox cmbEng;
        private System.Windows.Forms.RadioButton rdoEng2;
        private System.Windows.Forms.RadioButton rdoEng1;
        private Common.ucNumTextBox txtEngT;
        private System.Windows.Forms.Label label4;
        private Common.ucNumTextBox txtEngF;
        private System.Windows.Forms.GroupBox gbxOrder;
        public Common.ucYMTextbox mtbSallYm;
        private Common.ucYMTextbox mtbSallYmT;
        private Common.ucYMTextbox mtbSallYmF;
        private System.Windows.Forms.RadioButton rdoOrd2;
        private System.Windows.Forms.RadioButton rdoOrd1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.GroupBox gbxStat;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rdoPubY;
        private System.Windows.Forms.RadioButton rdoPubN;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton rdoFinY;
        private System.Windows.Forms.RadioButton rdoFinN;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rdoBillY;
        private System.Windows.Forms.RadioButton rdoBillN;
        private System.Windows.Forms.ComboBox cmbCus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_reqNo;
        private System.Windows.Forms.Button btnAllSeach;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_orderYm;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_orderNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_salNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_reqNum;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_cusNm;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_engNm;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_sal;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_req;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_pub;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_fin;
	}
}