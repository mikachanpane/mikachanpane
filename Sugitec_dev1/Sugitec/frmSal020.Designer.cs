namespace Sugitec
{
    partial class frmSal020
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
            Sugitec.Common.HeaderCell headerCell1 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell2 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell3 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell4 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell5 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell6 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell7 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell8 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell9 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell10 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell11 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell12 = new Sugitec.Common.HeaderCell();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSime = new Sugitec.Common.ucNumTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCus = new System.Windows.Forms.ComboBox();
            this.rdoCus2 = new System.Windows.Forms.RadioButton();
            this.rdoCus1 = new System.Windows.Forms.RadioButton();
            this.txtCusT = new Sugitec.Common.ucNumTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCusF = new Sugitec.Common.ucNumTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEng = new System.Windows.Forms.ComboBox();
            this.rdoEng2 = new System.Windows.Forms.RadioButton();
            this.rdoEng1 = new System.Windows.Forms.RadioButton();
            this.txtEngT = new Sugitec.Common.ucNumTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEngF = new Sugitec.Common.ucNumTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbSaleYm = new Sugitec.Common.ucYMTextbox();
            this.mtbSaleYmT = new Sugitec.Common.ucYMTextbox();
            this.mtbSaleYmF = new Sugitec.Common.ucYMTextbox();
            this.rdoSal2 = new System.Windows.Forms.RadioButton();
            this.rdoSal1 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgv_Result = new Sugitec.Common.ucDataGridViewEx();
            this.dgv_OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_PrjNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_CusCd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_CusNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EngId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EngNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_OrdStartYMD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_OrdEndYMD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_SalesNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_SalesYM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_SalesAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSime);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 116);
            this.panel1.TabIndex = 0;
            // 
            // txtSime
            // 
            this.txtSime.BackColor = System.Drawing.SystemColors.Window;
            this.txtSime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtSime.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericCode;
            this.txtSime.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSime.Format = null;
            this.txtSime.IllegalCharacter = null;
            this.txtSime.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtSime.Location = new System.Drawing.Point(881, 12);
            this.txtSime.MaxLength = 2;
            this.txtSime.Name = "txtSime";
            this.txtSime.OldText = null;
            this.txtSime.Size = new System.Drawing.Size(43, 20);
            this.txtSime.TabIndex = 4;
            this.txtSime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSime.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.Left;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.GreenYellow;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(831, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "締日";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(929, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "(末日：99)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbCus);
            this.groupBox3.Controls.Add(this.rdoCus2);
            this.groupBox3.Controls.Add(this.rdoCus1);
            this.groupBox3.Controls.Add(this.txtCusT);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtCusF);
            this.groupBox3.Location = new System.Drawing.Point(561, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "得意先";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "得意先";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCus
            // 
            this.cmbCus.FormattingEnabled = true;
            this.cmbCus.Location = new System.Drawing.Point(45, 24);
            this.cmbCus.Name = "cmbCus";
            this.cmbCus.Size = new System.Drawing.Size(187, 21);
            this.cmbCus.TabIndex = 1;
            // 
            // rdoCus2
            // 
            this.rdoCus2.AutoSize = true;
            this.rdoCus2.Location = new System.Drawing.Point(15, 57);
            this.rdoCus2.Name = "rdoCus2";
            this.rdoCus2.Size = new System.Drawing.Size(14, 13);
            this.rdoCus2.TabIndex = 2;
            this.rdoCus2.UseVisualStyleBackColor = true;
            // 
            // rdoCus1
            // 
            this.rdoCus1.AutoSize = true;
            this.rdoCus1.Checked = true;
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
            this.txtCusT.Location = new System.Drawing.Point(153, 54);
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
            this.label2.Location = new System.Drawing.Point(130, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbEng);
            this.groupBox2.Controls.Add(this.rdoEng2);
            this.groupBox2.Controls.Add(this.rdoEng1);
            this.groupBox2.Controls.Add(this.txtEngT);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEngF);
            this.groupBox2.Location = new System.Drawing.Point(298, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "技術者";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.GreenYellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "技術者";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbEng
            // 
            this.cmbEng.FormattingEnabled = true;
            this.cmbEng.Location = new System.Drawing.Point(45, 24);
            this.cmbEng.Name = "cmbEng";
            this.cmbEng.Size = new System.Drawing.Size(189, 21);
            this.cmbEng.TabIndex = 1;
            // 
            // rdoEng2
            // 
            this.rdoEng2.AutoSize = true;
            this.rdoEng2.Location = new System.Drawing.Point(15, 57);
            this.rdoEng2.Name = "rdoEng2";
            this.rdoEng2.Size = new System.Drawing.Size(14, 13);
            this.rdoEng2.TabIndex = 2;
            this.rdoEng2.UseVisualStyleBackColor = true;
            // 
            // rdoEng1
            // 
            this.rdoEng1.AutoSize = true;
            this.rdoEng1.Checked = true;
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
            this.txtEngT.Location = new System.Drawing.Point(153, 54);
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
            this.label4.Location = new System.Drawing.Point(130, 54);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mtbSaleYm);
            this.groupBox1.Controls.Add(this.mtbSaleYmT);
            this.groupBox1.Controls.Add(this.mtbSaleYmF);
            this.groupBox1.Controls.Add(this.rdoSal2);
            this.groupBox1.Controls.Add(this.rdoSal1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "売上年月";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.GreenYellow;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "売上年月";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbSaleYm
            // 
            this.mtbSaleYm.BackColor = System.Drawing.SystemColors.Window;
            this.mtbSaleYm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mtbSaleYm.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mtbSaleYm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mtbSaleYm.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.mtbSaleYm.Location = new System.Drawing.Point(44, 24);
            this.mtbSaleYm.Name = "mtbSaleYm";
            this.mtbSaleYm.OldValue = null;
            this.mtbSaleYm.Size = new System.Drawing.Size(95, 20);
            this.mtbSaleYm.TabIndex = 1;
            this.mtbSaleYm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mtbSaleYmT
            // 
            this.mtbSaleYmT.BackColor = System.Drawing.SystemColors.Window;
            this.mtbSaleYmT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mtbSaleYmT.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mtbSaleYmT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mtbSaleYmT.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.mtbSaleYmT.Location = new System.Drawing.Point(162, 54);
            this.mtbSaleYmT.Name = "mtbSaleYmT";
            this.mtbSaleYmT.OldValue = null;
            this.mtbSaleYmT.Size = new System.Drawing.Size(95, 20);
            this.mtbSaleYmT.TabIndex = 5;
            this.mtbSaleYmT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mtbSaleYmF
            // 
            this.mtbSaleYmF.BackColor = System.Drawing.SystemColors.Window;
            this.mtbSaleYmF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mtbSaleYmF.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mtbSaleYmF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mtbSaleYmF.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.mtbSaleYmF.Location = new System.Drawing.Point(44, 54);
            this.mtbSaleYmF.Name = "mtbSaleYmF";
            this.mtbSaleYmF.OldValue = null;
            this.mtbSaleYmF.Size = new System.Drawing.Size(95, 20);
            this.mtbSaleYmF.TabIndex = 3;
            this.mtbSaleYmF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rdoSal2
            // 
            this.rdoSal2.AutoSize = true;
            this.rdoSal2.Location = new System.Drawing.Point(15, 57);
            this.rdoSal2.Name = "rdoSal2";
            this.rdoSal2.Size = new System.Drawing.Size(14, 13);
            this.rdoSal2.TabIndex = 2;
            this.rdoSal2.UseVisualStyleBackColor = true;
            // 
            // rdoSal1
            // 
            this.rdoSal1.AutoSize = true;
            this.rdoSal1.Checked = true;
            this.rdoSal1.Location = new System.Drawing.Point(15, 27);
            this.rdoSal1.Name = "rdoSal1";
            this.rdoSal1.Size = new System.Drawing.Size(14, 13);
            this.rdoSal1.TabIndex = 0;
            this.rdoSal1.TabStop = true;
            this.rdoSal1.UseVisualStyleBackColor = true;
            this.rdoSal1.CheckedChanged += new System.EventHandler(this.rdoSal1_CheckedChanged);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(142, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "～";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(831, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 43);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgv_Result
            // 
            this.dgv_Result.AllowUserToAddRows = false;
            this.dgv_Result.AllowUserToDeleteRows = false;
            this.dgv_Result.AllowUserToResizeRows = false;
            this.dgv_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Result.ColumnHeaderBorderStyle = Sugitec.Common.ucDataGridViewEx.HeaderCellBorderStyle.SingleLine;
            this.dgv_Result.ColumnHeaderRowCount = 1;
            this.dgv_Result.ColumnHeaderRowHeight = 20;
            this.dgv_Result.ColumnHeadersHeight = 22;
            this.dgv_Result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_OrderNo,
            this.dgv_PrjNm,
            this.dgv_CusCd,
            this.dgv_CusNm,
            this.dgv_EngId,
            this.dgv_EngNm,
            this.dgv_OrdStartYMD,
            this.dgv_OrdEndYMD,
            this.dgv_SalesNo,
            this.dgv_SalesYM,
            this.dgv_SalesAmt,
            this.dgv_Status});
            headerCell1.BackgroundColor = System.Drawing.Color.Empty;
            headerCell1.Column = 0;
            headerCell1.ColumnSpan = 1;
            headerCell1.ForeColor = System.Drawing.Color.Empty;
            headerCell1.Row = 0;
            headerCell1.RowSpan = 1;
            headerCell1.SortVisible = false;
            headerCell1.Text = "受注№";
            headerCell1.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell1.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell2.BackgroundColor = System.Drawing.Color.Empty;
            headerCell2.Column = 1;
            headerCell2.ColumnSpan = 1;
            headerCell2.ForeColor = System.Drawing.Color.Empty;
            headerCell2.Row = 0;
            headerCell2.RowSpan = 1;
            headerCell2.SortVisible = false;
            headerCell2.Text = "案件名";
            headerCell2.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerCell2.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell3.BackgroundColor = System.Drawing.Color.Empty;
            headerCell3.Column = 2;
            headerCell3.ColumnSpan = 1;
            headerCell3.ForeColor = System.Drawing.Color.Empty;
            headerCell3.Row = 0;
            headerCell3.RowSpan = 1;
            headerCell3.SortVisible = false;
            headerCell3.Text = "得意先コード";
            headerCell3.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            headerCell3.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell4.BackgroundColor = System.Drawing.Color.Empty;
            headerCell4.Column = 3;
            headerCell4.ColumnSpan = 1;
            headerCell4.ForeColor = System.Drawing.Color.Empty;
            headerCell4.Row = 0;
            headerCell4.RowSpan = 1;
            headerCell4.SortVisible = false;
            headerCell4.Text = "得意先";
            headerCell4.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerCell4.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell5.BackgroundColor = System.Drawing.Color.Empty;
            headerCell5.Column = 4;
            headerCell5.ColumnSpan = 1;
            headerCell5.ForeColor = System.Drawing.Color.Empty;
            headerCell5.Row = 0;
            headerCell5.RowSpan = 1;
            headerCell5.SortVisible = false;
            headerCell5.Text = "技術者コード";
            headerCell5.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            headerCell5.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell6.BackgroundColor = System.Drawing.Color.Empty;
            headerCell6.Column = 5;
            headerCell6.ColumnSpan = 1;
            headerCell6.ForeColor = System.Drawing.Color.Empty;
            headerCell6.Row = 0;
            headerCell6.RowSpan = 1;
            headerCell6.SortVisible = false;
            headerCell6.Text = "技術者";
            headerCell6.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerCell6.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell7.BackgroundColor = System.Drawing.Color.Empty;
            headerCell7.Column = 6;
            headerCell7.ColumnSpan = 1;
            headerCell7.ForeColor = System.Drawing.Color.Empty;
            headerCell7.Row = 0;
            headerCell7.RowSpan = 1;
            headerCell7.SortVisible = false;
            headerCell7.Text = "開始期間";
            headerCell7.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell7.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell8.BackgroundColor = System.Drawing.Color.Empty;
            headerCell8.Column = 7;
            headerCell8.ColumnSpan = 1;
            headerCell8.ForeColor = System.Drawing.Color.Empty;
            headerCell8.Row = 0;
            headerCell8.RowSpan = 1;
            headerCell8.SortVisible = false;
            headerCell8.Text = "終了期間";
            headerCell8.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell8.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell9.BackgroundColor = System.Drawing.Color.Empty;
            headerCell9.Column = 8;
            headerCell9.ColumnSpan = 1;
            headerCell9.ForeColor = System.Drawing.Color.Empty;
            headerCell9.Row = 0;
            headerCell9.RowSpan = 1;
            headerCell9.SortVisible = false;
            headerCell9.Text = "売上№";
            headerCell9.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell9.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell10.BackgroundColor = System.Drawing.Color.Empty;
            headerCell10.Column = 9;
            headerCell10.ColumnSpan = 1;
            headerCell10.ForeColor = System.Drawing.Color.Empty;
            headerCell10.Row = 0;
            headerCell10.RowSpan = 1;
            headerCell10.SortVisible = false;
            headerCell10.Text = "売上年月";
            headerCell10.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell10.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell11.BackgroundColor = System.Drawing.Color.Empty;
            headerCell11.Column = 10;
            headerCell11.ColumnSpan = 1;
            headerCell11.ForeColor = System.Drawing.Color.Empty;
            headerCell11.Row = 0;
            headerCell11.RowSpan = 1;
            headerCell11.SortVisible = false;
            headerCell11.Text = "売上金額";
            headerCell11.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell11.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell12.BackgroundColor = System.Drawing.Color.Empty;
            headerCell12.Column = 11;
            headerCell12.ColumnSpan = 1;
            headerCell12.ForeColor = System.Drawing.Color.Empty;
            headerCell12.Row = 0;
            headerCell12.RowSpan = 1;
            headerCell12.SortVisible = false;
            headerCell12.Text = "ステータス";
            headerCell12.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell12.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.dgv_Result.HeaderCells.Add(headerCell1);
            this.dgv_Result.HeaderCells.Add(headerCell2);
            this.dgv_Result.HeaderCells.Add(headerCell3);
            this.dgv_Result.HeaderCells.Add(headerCell4);
            this.dgv_Result.HeaderCells.Add(headerCell5);
            this.dgv_Result.HeaderCells.Add(headerCell6);
            this.dgv_Result.HeaderCells.Add(headerCell7);
            this.dgv_Result.HeaderCells.Add(headerCell8);
            this.dgv_Result.HeaderCells.Add(headerCell9);
            this.dgv_Result.HeaderCells.Add(headerCell10);
            this.dgv_Result.HeaderCells.Add(headerCell11);
            this.dgv_Result.HeaderCells.Add(headerCell12);
            this.dgv_Result.Location = new System.Drawing.Point(12, 174);
            this.dgv_Result.Name = "dgv_Result";
            this.dgv_Result.RowHeadersVisible = false;
            this.dgv_Result.RowTemplate.Height = 21;
            this.dgv_Result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Result.Size = new System.Drawing.Size(1044, 275);
            this.dgv_Result.TabIndex = 1;
            // 
            // dgv_OrderNo
            // 
            this.dgv_OrderNo.HeaderText = "受注№";
            this.dgv_OrderNo.Name = "dgv_OrderNo";
            this.dgv_OrderNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_PrjNm
            // 
            this.dgv_PrjNm.HeaderText = "案件名";
            this.dgv_PrjNm.Name = "dgv_PrjNm";
            this.dgv_PrjNm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_CusCd
            // 
            this.dgv_CusCd.HeaderText = "得意先コード";
            this.dgv_CusCd.Name = "dgv_CusCd";
            this.dgv_CusCd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_CusCd.Visible = false;
            // 
            // dgv_CusNm
            // 
            this.dgv_CusNm.HeaderText = "得意先";
            this.dgv_CusNm.Name = "dgv_CusNm";
            this.dgv_CusNm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_EngId
            // 
            this.dgv_EngId.HeaderText = "技術者ID";
            this.dgv_EngId.Name = "dgv_EngId";
            this.dgv_EngId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_EngId.Visible = false;
            // 
            // dgv_EngNm
            // 
            this.dgv_EngNm.HeaderText = "技術者";
            this.dgv_EngNm.Name = "dgv_EngNm";
            this.dgv_EngNm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_OrdStartYMD
            // 
            this.dgv_OrdStartYMD.HeaderText = "開始期間";
            this.dgv_OrdStartYMD.Name = "dgv_OrdStartYMD";
            this.dgv_OrdStartYMD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_OrdEndYMD
            // 
            this.dgv_OrdEndYMD.HeaderText = "終了期間";
            this.dgv_OrdEndYMD.Name = "dgv_OrdEndYMD";
            this.dgv_OrdEndYMD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_SalesNo
            // 
            this.dgv_SalesNo.HeaderText = "売上№";
            this.dgv_SalesNo.Name = "dgv_SalesNo";
            this.dgv_SalesNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_SalesYM
            // 
            this.dgv_SalesYM.HeaderText = "売上年月";
            this.dgv_SalesYM.Name = "dgv_SalesYM";
            this.dgv_SalesYM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_SalesAmt
            // 
            this.dgv_SalesAmt.HeaderText = "売上金額";
            this.dgv_SalesAmt.Name = "dgv_SalesAmt";
            this.dgv_SalesAmt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_Status
            // 
            this.dgv_Status.HeaderText = "ステータス";
            this.dgv_Status.Name = "dgv_Status";
            // 
            // btnUpd
            // 
            this.btnUpd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpd.Location = new System.Drawing.Point(765, 455);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(93, 43);
            this.btnUpd.TabIndex = 3;
            this.btnUpd.Text = "編集";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(963, 455);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(93, 43);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnClr
            // 
            this.btnClr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClr.Location = new System.Drawing.Point(864, 456);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(93, 43);
            this.btnClr.TabIndex = 4;
            this.btnClr.Text = "クリア";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(666, 455);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新規";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmSal020
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 528);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.dgv_Result);
            this.Controls.Add(this.panel1);
            this.Name = "frmSal020";
            this.Text = "frmSal020";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dgv_Result, 0);
            this.Controls.SetChildIndex(this.btnUpd, 0);
            this.Controls.SetChildIndex(this.btnEnd, 0);
            this.Controls.SetChildIndex(this.btnClr, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Common.ucNumTextBox txtEngT;
        private System.Windows.Forms.Label label4;
        private Common.ucNumTextBox txtEngF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSearch;
        private Common.ucDataGridViewEx dgv_Result;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnClr;
        private Common.ucYMTextbox mtbSaleYmT;
        private Common.ucYMTextbox mtbSaleYmF;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbCus;
        private System.Windows.Forms.RadioButton rdoCus2;
        private System.Windows.Forms.RadioButton rdoCus1;
        private Common.ucNumTextBox txtCusT;
        private System.Windows.Forms.Label label2;
        private Common.ucNumTextBox txtCusF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbEng;
        private System.Windows.Forms.RadioButton rdoEng2;
        private System.Windows.Forms.RadioButton rdoEng1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Common.ucYMTextbox mtbSaleYm;
        private System.Windows.Forms.RadioButton rdoSal2;
        private System.Windows.Forms.RadioButton rdoSal1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdd;
        private Common.ucNumTextBox txtSime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_PrjNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_CusCd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_CusNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EngId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EngNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_OrdStartYMD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_OrdEndYMD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_SalesNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_SalesYM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_SalesAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}