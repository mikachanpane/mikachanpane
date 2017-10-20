namespace Sugitec
{
    partial class frmOrd010
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
            this.dtpOrderYmd = new Sugitec.Common.ctlDateTimePickerEx();
            this.txtCustomerCd = new Sugitec.Common.ucNumTextBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.lblCustomerNm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProjectNm = new Sugitec.Common.ucTextBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWorkNm = new Sugitec.Common.ucTextBoxEx();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWorkSpace = new Sugitec.Common.ucTextBoxEx();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbContractTyp = new System.Windows.Forms.ComboBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudSubtractRate = new Sugitec.Common.ucNumUpDown();
            this.nudOrverRate = new Sugitec.Common.ucNumUpDown();
            this.nudBaseRate = new Sugitec.Common.ucNumUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nudUpperLimit = new Sugitec.Common.ucNumUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.nudLowerLimit = new Sugitec.Common.ucNumUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpEndYmd = new Sugitec.Common.ctlDateTimePickerEx();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpStartYmd = new Sugitec.Common.ctlDateTimePickerEx();
            this.cmbActuarialKbn = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblEngineerNm = new System.Windows.Forms.Label();
            this.btnEngineer = new System.Windows.Forms.Button();
            this.txtEngineerId = new Sugitec.Common.ucNumTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerOrdNo = new Sugitec.Common.ucTextBoxEx();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.cmbFileNm = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbContact = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpOrderYmd
            // 
            this.dtpOrderYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtpOrderYmd.Location = new System.Drawing.Point(131, 80);
            this.dtpOrderYmd.Name = "dtpOrderYmd";
            this.dtpOrderYmd.Size = new System.Drawing.Size(149, 20);
            this.dtpOrderYmd.TabIndex = 4;
            this.dtpOrderYmd.Value = null;
            // 
            // txtCustomerCd
            // 
            this.txtCustomerCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCustomerCd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCustomerCd.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericCode;
            this.txtCustomerCd.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtCustomerCd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCustomerCd.Format = null;
            this.txtCustomerCd.IllegalCharacter = null;
            this.txtCustomerCd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCustomerCd.Location = new System.Drawing.Point(131, 107);
            this.txtCustomerCd.MaxLength = 8;
            this.txtCustomerCd.Name = "txtCustomerCd";
            this.txtCustomerCd.OldText = null;
            this.txtCustomerCd.Size = new System.Drawing.Size(96, 20);
            this.txtCustomerCd.TabIndex = 6;
            this.txtCustomerCd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerCd.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.Left;
            this.txtCustomerCd.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustomerCd_Validating);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(231, 105);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(48, 23);
            this.btnCustomer.TabIndex = 7;
            this.btnCustomer.TabStop = false;
            this.btnCustomer.Text = "検索";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // lblCustomerNm
            // 
            this.lblCustomerNm.Location = new System.Drawing.Point(288, 107);
            this.lblCustomerNm.Name = "lblCustomerNm";
            this.lblCustomerNm.Size = new System.Drawing.Size(390, 20);
            this.lblCustomerNm.TabIndex = 8;
            this.lblCustomerNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(534, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "受注№";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.GreenYellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "受注日";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.GreenYellow;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(20, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "得意先";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.GreenYellow;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(20, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "担当者";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProjectNm
            // 
            this.txtProjectNm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtProjectNm.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtProjectNm.Location = new System.Drawing.Point(131, 162);
            this.txtProjectNm.MaxLength = 200;
            this.txtProjectNm.Multiline = true;
            this.txtProjectNm.Name = "txtProjectNm";
            this.txtProjectNm.Size = new System.Drawing.Size(547, 34);
            this.txtProjectNm.TabIndex = 12;
            this.txtProjectNm.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.None;
            this.txtProjectNm.xFormat = null;
            this.txtProjectNm.xIllegalCharacter = null;
            this.txtProjectNm.xMaxLengthByByte = true;
            this.txtProjectNm.xOldText = null;
            this.txtProjectNm.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.GreenYellow;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(20, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "案件名";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.GreenYellow;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(20, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "作業先名";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWorkNm
            // 
            this.txtWorkNm.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtWorkNm.Location = new System.Drawing.Point(131, 201);
            this.txtWorkNm.MaxLength = 200;
            this.txtWorkNm.Multiline = true;
            this.txtWorkNm.Name = "txtWorkNm";
            this.txtWorkNm.Size = new System.Drawing.Size(547, 34);
            this.txtWorkNm.TabIndex = 14;
            this.txtWorkNm.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.None;
            this.txtWorkNm.xFormat = null;
            this.txtWorkNm.xIllegalCharacter = null;
            this.txtWorkNm.xMaxLengthByByte = true;
            this.txtWorkNm.xOldText = null;
            this.txtWorkNm.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.GreenYellow;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(20, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "作業場所";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWorkSpace
            // 
            this.txtWorkSpace.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtWorkSpace.Location = new System.Drawing.Point(131, 241);
            this.txtWorkSpace.MaxLength = 200;
            this.txtWorkSpace.Multiline = true;
            this.txtWorkSpace.Name = "txtWorkSpace";
            this.txtWorkSpace.Size = new System.Drawing.Size(547, 34);
            this.txtWorkSpace.TabIndex = 16;
            this.txtWorkSpace.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.None;
            this.txtWorkSpace.xFormat = null;
            this.txtWorkSpace.xIllegalCharacter = null;
            this.txtWorkSpace.xMaxLengthByByte = true;
            this.txtWorkSpace.xOldText = null;
            this.txtWorkSpace.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.GreenYellow;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(20, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "契約形態";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbContractTyp
            // 
            this.cmbContractTyp.FormattingEnabled = true;
            this.cmbContractTyp.Location = new System.Drawing.Point(131, 281);
            this.cmbContractTyp.Name = "cmbContractTyp";
            this.cmbContractTyp.Size = new System.Drawing.Size(181, 21);
            this.cmbContractTyp.TabIndex = 18;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(288, 48);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(101, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.TabStop = false;
            this.btnCopy.Text = "コピー元選択";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(385, 486);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(94, 34);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "削除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(485, 486);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(94, 34);
            this.btnClr.TabIndex = 24;
            this.btnClr.Text = "クリア";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(585, 486);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(94, 34);
            this.btnEnd.TabIndex = 25;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(284, 486);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 34);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "確定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nudSubtractRate);
            this.panel1.Controls.Add(this.nudOrverRate);
            this.panel1.Controls.Add(this.nudBaseRate);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.nudUpperLimit);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.nudLowerLimit);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.dtpEndYmd);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dtpStartYmd);
            this.panel1.Controls.Add(this.cmbActuarialKbn);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblEngineerNm);
            this.panel1.Controls.Add(this.btnEngineer);
            this.panel1.Controls.Add(this.txtEngineerId);
            this.panel1.Location = new System.Drawing.Point(22, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 164);
            this.panel1.TabIndex = 21;
            // 
            // nudSubtractRate
            // 
            this.nudSubtractRate.BackColor = System.Drawing.SystemColors.Window;
            this.nudSubtractRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nudSubtractRate.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudSubtractRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudSubtractRate.Location = new System.Drawing.Point(531, 123);
            this.nudSubtractRate.Name = "nudSubtractRate";
            this.nudSubtractRate.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSubtractRate.Size = new System.Drawing.Size(115, 20);
            this.nudSubtractRate.TabIndex = 19;
            this.nudSubtractRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSubtractRate.ThousandsSeparator = true;
            this.nudSubtractRate.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // nudOrverRate
            // 
            this.nudOrverRate.BackColor = System.Drawing.SystemColors.Window;
            this.nudOrverRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nudOrverRate.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudOrverRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudOrverRate.Location = new System.Drawing.Point(319, 123);
            this.nudOrverRate.Name = "nudOrverRate";
            this.nudOrverRate.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudOrverRate.Size = new System.Drawing.Size(115, 20);
            this.nudOrverRate.TabIndex = 17;
            this.nudOrverRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudOrverRate.ThousandsSeparator = true;
            this.nudOrverRate.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // nudBaseRate
            // 
            this.nudBaseRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nudBaseRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nudBaseRate.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudBaseRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudBaseRate.Location = new System.Drawing.Point(108, 123);
            this.nudBaseRate.Name = "nudBaseRate";
            this.nudBaseRate.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudBaseRate.Size = new System.Drawing.Size(115, 20);
            this.nudBaseRate.TabIndex = 15;
            this.nudBaseRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBaseRate.ThousandsSeparator = true;
            this.nudBaseRate.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.GreenYellow;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(440, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 20);
            this.label20.TabIndex = 18;
            this.label20.Text = "控除単価";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.GreenYellow;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(229, 123);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 20);
            this.label19.TabIndex = 16;
            this.label19.Text = "超過単価";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.GreenYellow;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(10, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 20);
            this.label17.TabIndex = 14;
            this.label17.Text = "基本単価";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudUpperLimit
            // 
            this.nudUpperLimit.BackColor = System.Drawing.SystemColors.Window;
            this.nudUpperLimit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nudUpperLimit.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudUpperLimit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudUpperLimit.Location = new System.Drawing.Point(243, 94);
            this.nudUpperLimit.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudUpperLimit.Name = "nudUpperLimit";
            this.nudUpperLimit.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudUpperLimit.Size = new System.Drawing.Size(91, 20);
            this.nudUpperLimit.TabIndex = 13;
            this.nudUpperLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudUpperLimit.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(205, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "～";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudLowerLimit
            // 
            this.nudLowerLimit.BackColor = System.Drawing.SystemColors.Window;
            this.nudLowerLimit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nudLowerLimit.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudLowerLimit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudLowerLimit.Location = new System.Drawing.Point(108, 94);
            this.nudLowerLimit.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudLowerLimit.Name = "nudLowerLimit";
            this.nudLowerLimit.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudLowerLimit.Size = new System.Drawing.Size(91, 20);
            this.nudLowerLimit.TabIndex = 11;
            this.nudLowerLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLowerLimit.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.GreenYellow;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(10, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "時間幅";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEndYmd
            // 
            this.dtpEndYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtpEndYmd.Location = new System.Drawing.Point(281, 64);
            this.dtpEndYmd.Name = "dtpEndYmd";
            this.dtpEndYmd.Size = new System.Drawing.Size(136, 20);
            this.dtpEndYmd.TabIndex = 9;
            this.dtpEndYmd.Value = null;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(250, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "～";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.GreenYellow;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(10, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "期間";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpStartYmd
            // 
            this.dtpStartYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtpStartYmd.Location = new System.Drawing.Point(108, 64);
            this.dtpStartYmd.Name = "dtpStartYmd";
            this.dtpStartYmd.Size = new System.Drawing.Size(136, 20);
            this.dtpStartYmd.TabIndex = 7;
            this.dtpStartYmd.Value = null;
            // 
            // cmbActuarialKbn
            // 
            this.cmbActuarialKbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbActuarialKbn.FormattingEnabled = true;
            this.cmbActuarialKbn.Location = new System.Drawing.Point(108, 36);
            this.cmbActuarialKbn.Name = "cmbActuarialKbn";
            this.cmbActuarialKbn.Size = new System.Drawing.Size(258, 21);
            this.cmbActuarialKbn.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.GreenYellow;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(10, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "精算区分";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.GreenYellow;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(10, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "技術者";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEngineerNm
            // 
            this.lblEngineerNm.Location = new System.Drawing.Point(268, 9);
            this.lblEngineerNm.Name = "lblEngineerNm";
            this.lblEngineerNm.Size = new System.Drawing.Size(354, 20);
            this.lblEngineerNm.TabIndex = 3;
            this.lblEngineerNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEngineer
            // 
            this.btnEngineer.Location = new System.Drawing.Point(208, 7);
            this.btnEngineer.Name = "btnEngineer";
            this.btnEngineer.Size = new System.Drawing.Size(48, 23);
            this.btnEngineer.TabIndex = 2;
            this.btnEngineer.TabStop = false;
            this.btnEngineer.Text = "検索";
            this.btnEngineer.UseVisualStyleBackColor = true;
            this.btnEngineer.Click += new System.EventHandler(this.btnEngineer_Click_1);
            // 
            // txtEngineerId
            // 
            this.txtEngineerId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtEngineerId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtEngineerId.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericCode;
            this.txtEngineerId.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtEngineerId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEngineerId.Format = null;
            this.txtEngineerId.IllegalCharacter = null;
            this.txtEngineerId.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtEngineerId.Location = new System.Drawing.Point(108, 9);
            this.txtEngineerId.MaxLength = 8;
            this.txtEngineerId.Name = "txtEngineerId";
            this.txtEngineerId.OldText = null;
            this.txtEngineerId.Size = new System.Drawing.Size(96, 20);
            this.txtEngineerId.TabIndex = 1;
            this.txtEngineerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEngineerId.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.Left;
            this.txtEngineerId.Validating += new System.ComponentModel.CancelEventHandler(this.txtEngineerId_Validating);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "客先注文番号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustomerOrdNo
            // 
            this.txtCustomerOrdNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCustomerOrdNo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCustomerOrdNo.Location = new System.Drawing.Point(131, 49);
            this.txtCustomerOrdNo.MaxLength = 20;
            this.txtCustomerOrdNo.Name = "txtCustomerOrdNo";
            this.txtCustomerOrdNo.Size = new System.Drawing.Size(149, 20);
            this.txtCustomerOrdNo.TabIndex = 1;
            this.txtCustomerOrdNo.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.OnlyAlphaNumericSymbol;
            this.txtCustomerOrdNo.xFormat = null;
            this.txtCustomerOrdNo.xIllegalCharacter = null;
            this.txtCustomerOrdNo.xMaxLengthByByte = true;
            this.txtCustomerOrdNo.xOldText = null;
            this.txtCustomerOrdNo.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderNo.Location = new System.Drawing.Point(609, 49);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(69, 20);
            this.lblOrderNo.TabIndex = 27;
            this.lblOrderNo.Text = "88888888";
            this.lblOrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFileNm
            // 
            this.cmbFileNm.FormattingEnabled = true;
            this.cmbFileNm.Location = new System.Drawing.Point(463, 280);
            this.cmbFileNm.Name = "cmbFileNm";
            this.cmbFileNm.Size = new System.Drawing.Size(216, 21);
            this.cmbFileNm.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.GreenYellow;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(347, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "請求書ファイル";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbContact
            // 
            this.cmbContact.FormattingEnabled = true;
            this.cmbContact.Location = new System.Drawing.Point(131, 133);
            this.cmbContact.Name = "cmbContact";
            this.cmbContact.Size = new System.Drawing.Size(258, 21);
            this.cmbContact.TabIndex = 10;
            // 
            // frmOrd010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 550);
            this.Controls.Add(this.cmbContact);
            this.Controls.Add(this.cmbFileNm);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerOrdNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.cmbContractTyp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtWorkSpace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWorkNm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProjectNm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustomerNm);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.txtCustomerCd);
            this.Controls.Add(this.dtpOrderYmd);
            this.Name = "frmOrd010";
            this.Text = "frmOrd010";
            this.Controls.SetChildIndex(this.dtpOrderYmd, 0);
            this.Controls.SetChildIndex(this.txtCustomerCd, 0);
            this.Controls.SetChildIndex(this.btnCustomer, 0);
            this.Controls.SetChildIndex(this.lblCustomerNm, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtProjectNm, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtWorkNm, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtWorkSpace, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.cmbContractTyp, 0);
            this.Controls.SetChildIndex(this.btnCopy, 0);
            this.Controls.SetChildIndex(this.btnDel, 0);
            this.Controls.SetChildIndex(this.btnClr, 0);
            this.Controls.SetChildIndex(this.btnEnd, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.txtCustomerOrdNo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblOrderNo, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.cmbFileNm, 0);
            this.Controls.SetChildIndex(this.cmbContact, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sugitec.Common.ctlDateTimePickerEx dtpOrderYmd;
        private Sugitec.Common.ucNumTextBox txtCustomerCd;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Label lblCustomerNm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Sugitec.Common.ucTextBoxEx txtProjectNm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Sugitec.Common.ucTextBoxEx txtWorkNm;
        private System.Windows.Forms.Label label8;
        private Sugitec.Common.ucTextBoxEx txtWorkSpace;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbContractTyp;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        private Sugitec.Common.ucNumUpDown nudSubtractRate;
        private Sugitec.Common.ucNumUpDown nudOrverRate;
        private Sugitec.Common.ucNumUpDown nudBaseRate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private Sugitec.Common.ucNumUpDown nudUpperLimit;
        private System.Windows.Forms.Label label16;
        private Sugitec.Common.ucNumUpDown nudLowerLimit;
        private System.Windows.Forms.Label label15;
        private Sugitec.Common.ctlDateTimePickerEx dtpEndYmd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private Sugitec.Common.ctlDateTimePickerEx dtpStartYmd;
        private System.Windows.Forms.ComboBox cmbActuarialKbn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblEngineerNm;
        private System.Windows.Forms.Button btnEngineer;
        private Sugitec.Common.ucNumTextBox txtEngineerId;
		private System.Windows.Forms.Label label1;
		private Common.ucTextBoxEx txtCustomerOrdNo;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.ComboBox cmbFileNm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbContact;
    }
}