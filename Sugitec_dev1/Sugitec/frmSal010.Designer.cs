namespace Sugitec
{
    partial class frmSal010
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCal = new System.Windows.Forms.Button();
			this.btnClr = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblOrderNo = new System.Windows.Forms.Label();
			this.lblOrderEnd = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.lblOrderStart = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.lblActuarialKbn = new System.Windows.Forms.Label();
			this.lblProjectNm = new System.Windows.Forms.Label();
			this.lblCustomerCd = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblCustomerNm = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtSaleYm = new Sugitec.Common.ucYMTextbox();
			this.label10 = new System.Windows.Forms.Label();
			this.lblEngineerNm = new System.Windows.Forms.Label();
			this.btnEngineer = new System.Windows.Forms.Button();
			this.txtEngineerId = new Sugitec.Common.ucNumTextBox();
			this.dtpEndYmd = new Sugitec.Common.ctlDateTimePickerEx();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.dtpStartYmd = new Sugitec.Common.ctlDateTimePickerEx();
			this.nudOperationTime = new Sugitec.Common.ucNumUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblLackTime = new System.Windows.Forms.Label();
			this.lblOverTime = new System.Windows.Forms.Label();
			this.lblBaseTime = new System.Windows.Forms.Label();
			this.lblBaseAmount = new System.Windows.Forms.Label();
			this.lblSubtractAmount = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblOrverAmount = new System.Windows.Forms.Label();
			this.lblBaseRate = new System.Windows.Forms.Label();
			this.lblOrverRate = new System.Windows.Forms.Label();
			this.lblSubtractRate = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.lblSalesAmount = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.btnDel = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.lblTotalAmount = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.lblTaxAmount = new System.Windows.Forms.Label();
			this.lblTaxRate = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.lblSaleNo = new System.Windows.Forms.Label();
			this.btnExpense = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Pink;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(537, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "売上№";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.GreenYellow;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(26, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "売上年月";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCal
			// 
			this.btnCal.Location = new System.Drawing.Point(204, 136);
			this.btnCal.Name = "btnCal";
			this.btnCal.Size = new System.Drawing.Size(94, 25);
			this.btnCal.TabIndex = 14;
			this.btnCal.Text = "計算";
			this.btnCal.UseVisualStyleBackColor = true;
			this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
			// 
			// btnClr
			// 
			this.btnClr.Location = new System.Drawing.Point(491, 477);
			this.btnClr.Name = "btnClr";
			this.btnClr.Size = new System.Drawing.Size(94, 34);
			this.btnClr.TabIndex = 21;
			this.btnClr.Text = "クリア";
			this.btnClr.UseVisualStyleBackColor = true;
			this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(591, 477);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(94, 34);
			this.btnEnd.TabIndex = 22;
			this.btnEnd.Text = "終了";
			this.btnEnd.UseVisualStyleBackColor = true;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(292, 477);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(94, 34);
			this.btnOk.TabIndex = 19;
			this.btnOk.Text = "確定";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.lblOrderNo);
			this.panel1.Controls.Add(this.lblOrderEnd);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.lblOrderStart);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.lblActuarialKbn);
			this.panel1.Controls.Add(this.lblProjectNm);
			this.panel1.Controls.Add(this.lblCustomerCd);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.lblCustomerNm);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Location = new System.Drawing.Point(12, 175);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(673, 142);
			this.panel1.TabIndex = 16;
			// 
			// lblOrderNo
			// 
			this.lblOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblOrderNo.Location = new System.Drawing.Point(88, 12);
			this.lblOrderNo.Name = "lblOrderNo";
			this.lblOrderNo.Size = new System.Drawing.Size(68, 20);
			this.lblOrderNo.TabIndex = 1;
			this.lblOrderNo.Text = "88888888";
			this.lblOrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblOrderEnd
			// 
			this.lblOrderEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblOrderEnd.Location = new System.Drawing.Point(202, 110);
			this.lblOrderEnd.Name = "lblOrderEnd";
			this.lblOrderEnd.Size = new System.Drawing.Size(81, 20);
			this.lblOrderEnd.TabIndex = 12;
			this.lblOrderEnd.Text = "yyyy/MM/dd";
			this.lblOrderEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(172, 110);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(25, 20);
			this.label17.TabIndex = 11;
			this.label17.Text = "～";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblOrderStart
			// 
			this.lblOrderStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblOrderStart.Location = new System.Drawing.Point(88, 110);
			this.lblOrderStart.Name = "lblOrderStart";
			this.lblOrderStart.Size = new System.Drawing.Size(81, 20);
			this.lblOrderStart.TabIndex = 10;
			this.lblOrderStart.Text = "yyyy/MM/dd";
			this.lblOrderStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.GreenYellow;
			this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label15.Location = new System.Drawing.Point(13, 110);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(68, 20);
			this.label15.TabIndex = 9;
			this.label15.Text = "期間";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblActuarialKbn
			// 
			this.lblActuarialKbn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblActuarialKbn.Location = new System.Drawing.Point(88, 85);
			this.lblActuarialKbn.Name = "lblActuarialKbn";
			this.lblActuarialKbn.Size = new System.Drawing.Size(568, 20);
			this.lblActuarialKbn.TabIndex = 8;
			this.lblActuarialKbn.Text = "精算８８８８８８８８";
			this.lblActuarialKbn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblProjectNm
			// 
			this.lblProjectNm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblProjectNm.Location = new System.Drawing.Point(88, 59);
			this.lblProjectNm.Name = "lblProjectNm";
			this.lblProjectNm.Size = new System.Drawing.Size(568, 20);
			this.lblProjectNm.TabIndex = 6;
			this.lblProjectNm.Text = "案件名８８８８８８８８８８８８８８８８８８８８８８８８８８";
			this.lblProjectNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCustomerCd
			// 
			this.lblCustomerCd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCustomerCd.Location = new System.Drawing.Point(88, 36);
			this.lblCustomerCd.Name = "lblCustomerCd";
			this.lblCustomerCd.Size = new System.Drawing.Size(68, 20);
			this.lblCustomerCd.TabIndex = 3;
			this.lblCustomerCd.Text = "88888888";
			this.lblCustomerCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.GreenYellow;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(13, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "受注№";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.GreenYellow;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Location = new System.Drawing.Point(13, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "案件名";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.GreenYellow;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(13, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "得意先";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCustomerNm
			// 
			this.lblCustomerNm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCustomerNm.Location = new System.Drawing.Point(162, 36);
			this.lblCustomerNm.Name = "lblCustomerNm";
			this.lblCustomerNm.Size = new System.Drawing.Size(494, 20);
			this.lblCustomerNm.TabIndex = 4;
			this.lblCustomerNm.Text = "得意先名８８８８８８８８８８８８８８８８８８８８８８８８８８";
			this.lblCustomerNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.GreenYellow;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label12.Location = new System.Drawing.Point(13, 85);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(68, 20);
			this.label12.TabIndex = 7;
			this.label12.Text = "精算区分";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtSaleYm
			// 
			this.txtSaleYm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtSaleYm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtSaleYm.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtSaleYm.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSaleYm.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtSaleYm.Location = new System.Drawing.Point(101, 50);
			this.txtSaleYm.Name = "txtSaleYm";
			this.txtSaleYm.OldValue = null;
			this.txtSaleYm.Size = new System.Drawing.Size(96, 20);
			this.txtSaleYm.TabIndex = 3;
			this.txtSaleYm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSaleYm.Validating += new System.ComponentModel.CancelEventHandler(this.txtSaleYm_Validating);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.GreenYellow;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.Location = new System.Drawing.Point(26, 79);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 20);
			this.label10.TabIndex = 4;
			this.label10.Text = "技術者";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblEngineerNm
			// 
			this.lblEngineerNm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblEngineerNm.Location = new System.Drawing.Point(258, 79);
			this.lblEngineerNm.Name = "lblEngineerNm";
			this.lblEngineerNm.Size = new System.Drawing.Size(275, 20);
			this.lblEngineerNm.TabIndex = 7;
			this.lblEngineerNm.Text = "技術者名８８８８８８";
			this.lblEngineerNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnEngineer
			// 
			this.btnEngineer.Location = new System.Drawing.Point(204, 77);
			this.btnEngineer.Name = "btnEngineer";
			this.btnEngineer.Size = new System.Drawing.Size(48, 23);
			this.btnEngineer.TabIndex = 6;
			this.btnEngineer.TabStop = false;
			this.btnEngineer.Text = "検索";
			this.btnEngineer.UseVisualStyleBackColor = true;
			this.btnEngineer.Click += new System.EventHandler(this.btnEngineer_Click);
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
			this.txtEngineerId.Location = new System.Drawing.Point(101, 79);
			this.txtEngineerId.MaxLength = 8;
			this.txtEngineerId.Name = "txtEngineerId";
			this.txtEngineerId.OldText = null;
			this.txtEngineerId.Size = new System.Drawing.Size(96, 20);
			this.txtEngineerId.TabIndex = 5;
			this.txtEngineerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtEngineerId.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.Left;
			this.txtEngineerId.Validating += new System.ComponentModel.CancelEventHandler(this.txtEngineerId_Validating);
			// 
			// dtpEndYmd
			// 
			this.dtpEndYmd.BackColor = System.Drawing.SystemColors.Window;
			this.dtpEndYmd.Location = new System.Drawing.Point(274, 110);
			this.dtpEndYmd.Name = "dtpEndYmd";
			this.dtpEndYmd.Size = new System.Drawing.Size(136, 20);
			this.dtpEndYmd.TabIndex = 11;
			this.dtpEndYmd.Value = new System.DateTime(2017, 4, 27, 16, 32, 58, 672);
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(243, 109);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(25, 20);
			this.label14.TabIndex = 10;
			this.label14.Text = "～";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.GreenYellow;
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label13.Location = new System.Drawing.Point(26, 110);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(68, 20);
			this.label13.TabIndex = 8;
			this.label13.Text = "期間";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpStartYmd
			// 
			this.dtpStartYmd.BackColor = System.Drawing.SystemColors.Window;
			this.dtpStartYmd.Location = new System.Drawing.Point(101, 110);
			this.dtpStartYmd.Name = "dtpStartYmd";
			this.dtpStartYmd.NullValue = "";
			this.dtpStartYmd.Size = new System.Drawing.Size(136, 20);
			this.dtpStartYmd.TabIndex = 9;
			this.dtpStartYmd.Value = new System.DateTime(2017, 4, 27, 16, 32, 58, 674);
			// 
			// nudOperationTime
			// 
			this.nudOperationTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.nudOperationTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nudOperationTime.DecimalPlaces = 2;
			this.nudOperationTime.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.nudOperationTime.ForeColor = System.Drawing.SystemColors.WindowText;
			this.nudOperationTime.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.nudOperationTime.Location = new System.Drawing.Point(101, 140);
			this.nudOperationTime.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
			this.nudOperationTime.Name = "nudOperationTime";
			this.nudOperationTime.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.nudOperationTime.Size = new System.Drawing.Size(96, 20);
			this.nudOperationTime.TabIndex = 13;
			this.nudOperationTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nudOperationTime.ThousandsSeparator = true;
			this.nudOperationTime.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.GreenYellow;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Location = new System.Drawing.Point(26, 138);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 20);
			this.label7.TabIndex = 12;
			this.label7.Text = "稼働時間";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.lblLackTime, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblOverTime, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblBaseTime, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblBaseAmount, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblSubtractAmount, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label11, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label18, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblOrverAmount, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblBaseRate, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblOrverRate, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblSubtractRate, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label21, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblSalesAmount, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.label22, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label19, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label23, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.label25, 4, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 326);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 109);
			this.tableLayoutPanel1.TabIndex = 17;
			// 
			// lblLackTime
			// 
			this.lblLackTime.BackColor = System.Drawing.Color.White;
			this.lblLackTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblLackTime.ForeColor = System.Drawing.Color.Red;
			this.lblLackTime.Location = new System.Drawing.Point(403, 28);
			this.lblLackTime.Margin = new System.Windows.Forms.Padding(0);
			this.lblLackTime.Name = "lblLackTime";
			this.lblLackTime.Size = new System.Drawing.Size(133, 26);
			this.lblLackTime.TabIndex = 7;
			this.lblLackTime.Text = "88";
			this.lblLackTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblOverTime
			// 
			this.lblOverTime.BackColor = System.Drawing.Color.White;
			this.lblOverTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblOverTime.Location = new System.Drawing.Point(269, 28);
			this.lblOverTime.Margin = new System.Windows.Forms.Padding(0);
			this.lblOverTime.Name = "lblOverTime";
			this.lblOverTime.Size = new System.Drawing.Size(133, 26);
			this.lblOverTime.TabIndex = 6;
			this.lblOverTime.Text = "88";
			this.lblOverTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblBaseTime
			// 
			this.lblBaseTime.BackColor = System.Drawing.Color.White;
			this.lblBaseTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblBaseTime.Location = new System.Drawing.Point(135, 28);
			this.lblBaseTime.Margin = new System.Windows.Forms.Padding(0);
			this.lblBaseTime.Name = "lblBaseTime";
			this.lblBaseTime.Size = new System.Drawing.Size(133, 26);
			this.lblBaseTime.TabIndex = 5;
			this.lblBaseTime.Text = "160～200";
			this.lblBaseTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblBaseAmount
			// 
			this.lblBaseAmount.BackColor = System.Drawing.Color.White;
			this.lblBaseAmount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblBaseAmount.Location = new System.Drawing.Point(135, 82);
			this.lblBaseAmount.Margin = new System.Windows.Forms.Padding(0);
			this.lblBaseAmount.Name = "lblBaseAmount";
			this.lblBaseAmount.Size = new System.Drawing.Size(133, 26);
			this.lblBaseAmount.TabIndex = 13;
			this.lblBaseAmount.Text = "888,888,888";
			this.lblBaseAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblSubtractAmount
			// 
			this.lblSubtractAmount.BackColor = System.Drawing.Color.White;
			this.lblSubtractAmount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblSubtractAmount.ForeColor = System.Drawing.Color.Red;
			this.lblSubtractAmount.Location = new System.Drawing.Point(403, 82);
			this.lblSubtractAmount.Margin = new System.Windows.Forms.Padding(0);
			this.lblSubtractAmount.Name = "lblSubtractAmount";
			this.lblSubtractAmount.Size = new System.Drawing.Size(133, 26);
			this.lblSubtractAmount.TabIndex = 15;
			this.lblSubtractAmount.Text = "888,888,888";
			this.lblSubtractAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.GreenYellow;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label9.Location = new System.Drawing.Point(269, 1);
			this.label9.Margin = new System.Windows.Forms.Padding(0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(133, 26);
			this.label9.TabIndex = 1;
			this.label9.Text = "超過";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.GreenYellow;
			this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label11.Location = new System.Drawing.Point(403, 1);
			this.label11.Margin = new System.Windows.Forms.Padding(0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(133, 26);
			this.label11.TabIndex = 2;
			this.label11.Text = "控除";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.GreenYellow;
			this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label18.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label18.Location = new System.Drawing.Point(537, 1);
			this.label18.Margin = new System.Windows.Forms.Padding(0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(135, 26);
			this.label18.TabIndex = 3;
			this.label18.Text = "合計";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.BackColor = System.Drawing.Color.GreenYellow;
			this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label8.Location = new System.Drawing.Point(135, 1);
			this.label8.Margin = new System.Windows.Forms.Padding(0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(133, 26);
			this.label8.TabIndex = 0;
			this.label8.Text = "基本";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblOrverAmount
			// 
			this.lblOrverAmount.BackColor = System.Drawing.Color.White;
			this.lblOrverAmount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblOrverAmount.Location = new System.Drawing.Point(269, 82);
			this.lblOrverAmount.Margin = new System.Windows.Forms.Padding(0);
			this.lblOrverAmount.Name = "lblOrverAmount";
			this.lblOrverAmount.Size = new System.Drawing.Size(133, 26);
			this.lblOrverAmount.TabIndex = 14;
			this.lblOrverAmount.Text = "888,888,888";
			this.lblOrverAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblBaseRate
			// 
			this.lblBaseRate.BackColor = System.Drawing.Color.White;
			this.lblBaseRate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblBaseRate.Location = new System.Drawing.Point(135, 55);
			this.lblBaseRate.Margin = new System.Windows.Forms.Padding(0);
			this.lblBaseRate.Name = "lblBaseRate";
			this.lblBaseRate.Size = new System.Drawing.Size(133, 26);
			this.lblBaseRate.TabIndex = 9;
			this.lblBaseRate.Text = "@1,000,000";
			this.lblBaseRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblOrverRate
			// 
			this.lblOrverRate.BackColor = System.Drawing.Color.White;
			this.lblOrverRate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblOrverRate.Location = new System.Drawing.Point(269, 55);
			this.lblOrverRate.Margin = new System.Windows.Forms.Padding(0);
			this.lblOrverRate.Name = "lblOrverRate";
			this.lblOrverRate.Size = new System.Drawing.Size(133, 26);
			this.lblOrverRate.TabIndex = 10;
			this.lblOrverRate.Text = "@1,000,000";
			this.lblOrverRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblSubtractRate
			// 
			this.lblSubtractRate.BackColor = System.Drawing.Color.White;
			this.lblSubtractRate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblSubtractRate.ForeColor = System.Drawing.Color.Red;
			this.lblSubtractRate.Location = new System.Drawing.Point(403, 55);
			this.lblSubtractRate.Margin = new System.Windows.Forms.Padding(0);
			this.lblSubtractRate.Name = "lblSubtractRate";
			this.lblSubtractRate.Size = new System.Drawing.Size(133, 26);
			this.lblSubtractRate.TabIndex = 11;
			this.lblSubtractRate.Text = "@1,000,000";
			this.lblSubtractRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.GreenYellow;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label5.Location = new System.Drawing.Point(1, 55);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 26);
			this.label5.TabIndex = 8;
			this.label5.Text = "単価";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.GreenYellow;
			this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label21.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label21.Location = new System.Drawing.Point(1, 28);
			this.label21.Margin = new System.Windows.Forms.Padding(0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(133, 26);
			this.label21.TabIndex = 4;
			this.label21.Text = "時間";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSalesAmount
			// 
			this.lblSalesAmount.BackColor = System.Drawing.Color.White;
			this.lblSalesAmount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblSalesAmount.Location = new System.Drawing.Point(537, 82);
			this.lblSalesAmount.Margin = new System.Windows.Forms.Padding(0);
			this.lblSalesAmount.Name = "lblSalesAmount";
			this.lblSalesAmount.Size = new System.Drawing.Size(135, 26);
			this.lblSalesAmount.TabIndex = 16;
			this.lblSalesAmount.Text = "888,888,888";
			this.lblSalesAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.GreenYellow;
			this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label22.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label22.Location = new System.Drawing.Point(1, 82);
			this.label22.Margin = new System.Windows.Forms.Padding(0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(133, 26);
			this.label22.TabIndex = 12;
			this.label22.Text = "金額";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.GreenYellow;
			this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label19.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label19.Location = new System.Drawing.Point(1, 1);
			this.label19.Margin = new System.Windows.Forms.Padding(0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(133, 26);
			this.label19.TabIndex = 17;
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.White;
			this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label23.Location = new System.Drawing.Point(537, 28);
			this.label23.Margin = new System.Windows.Forms.Padding(0);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(135, 26);
			this.label23.TabIndex = 18;
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.White;
			this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label25.Location = new System.Drawing.Point(537, 55);
			this.label25.Margin = new System.Windows.Forms.Padding(0);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(135, 26);
			this.label25.TabIndex = 19;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(20, 165);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(74, 20);
			this.label20.TabIndex = 15;
			this.label20.Text = "受注情報";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(391, 477);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(94, 34);
			this.btnDel.TabIndex = 20;
			this.btnDel.Text = "削除";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel2.ColumnCount = 5;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.Controls.Add(this.lblTotalAmount, 4, 0);
			this.tableLayoutPanel2.Controls.Add(this.label24, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblTaxAmount, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblTaxRate, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.label16, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 442);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(673, 28);
			this.tableLayoutPanel2.TabIndex = 18;
			// 
			// lblTotalAmount
			// 
			this.lblTotalAmount.AutoSize = true;
			this.lblTotalAmount.BackColor = System.Drawing.Color.White;
			this.lblTotalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTotalAmount.Location = new System.Drawing.Point(537, 1);
			this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(0);
			this.lblTotalAmount.Name = "lblTotalAmount";
			this.lblTotalAmount.Size = new System.Drawing.Size(135, 26);
			this.lblTotalAmount.TabIndex = 4;
			this.lblTotalAmount.Text = "888,888,888";
			this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.BackColor = System.Drawing.Color.GreenYellow;
			this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label24.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label24.Location = new System.Drawing.Point(403, 1);
			this.label24.Margin = new System.Windows.Forms.Padding(0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(133, 26);
			this.label24.TabIndex = 3;
			this.label24.Text = "合計金額（税込）";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTaxAmount
			// 
			this.lblTaxAmount.AutoSize = true;
			this.lblTaxAmount.BackColor = System.Drawing.Color.White;
			this.lblTaxAmount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTaxAmount.Location = new System.Drawing.Point(269, 1);
			this.lblTaxAmount.Margin = new System.Windows.Forms.Padding(0);
			this.lblTaxAmount.Name = "lblTaxAmount";
			this.lblTaxAmount.Size = new System.Drawing.Size(133, 26);
			this.lblTaxAmount.TabIndex = 2;
			this.lblTaxAmount.Text = "888,888,888";
			this.lblTaxAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTaxRate
			// 
			this.lblTaxRate.AutoSize = true;
			this.lblTaxRate.BackColor = System.Drawing.Color.White;
			this.lblTaxRate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTaxRate.Location = new System.Drawing.Point(135, 1);
			this.lblTaxRate.Margin = new System.Windows.Forms.Padding(0);
			this.lblTaxRate.Name = "lblTaxRate";
			this.lblTaxRate.Size = new System.Drawing.Size(133, 26);
			this.lblTaxRate.TabIndex = 1;
			this.lblTaxRate.Text = "8%";
			this.lblTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.GreenYellow;
			this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label16.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label16.Location = new System.Drawing.Point(1, 1);
			this.label16.Margin = new System.Windows.Forms.Padding(0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(133, 26);
			this.label16.TabIndex = 0;
			this.label16.Text = "消費税";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSaleNo
			// 
			this.lblSaleNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblSaleNo.Location = new System.Drawing.Point(611, 51);
			this.lblSaleNo.Name = "lblSaleNo";
			this.lblSaleNo.Size = new System.Drawing.Size(69, 19);
			this.lblSaleNo.TabIndex = 1;
			this.lblSaleNo.Text = "88888888";
			this.lblSaleNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnExpense
			// 
			this.btnExpense.Location = new System.Drawing.Point(12, 477);
			this.btnExpense.Name = "btnExpense";
			this.btnExpense.Size = new System.Drawing.Size(94, 34);
			this.btnExpense.TabIndex = 23;
			this.btnExpense.Text = "経費登録";
			this.btnExpense.UseVisualStyleBackColor = true;
			this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
			// 
			// frmSal010
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(697, 543);
			this.Controls.Add(this.btnExpense);
			this.Controls.Add(this.lblSaleNo);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.nudOperationTime);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dtpEndYmd);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.dtpStartYmd);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.lblEngineerNm);
			this.Controls.Add(this.btnEngineer);
			this.Controls.Add(this.txtEngineerId);
			this.Controls.Add(this.txtSaleYm);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.btnClr);
			this.Controls.Add(this.btnCal);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "frmSal010";
			this.Text = "frmSal010";
			this.Load += new System.EventHandler(this.frmSal010_Load);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.btnCal, 0);
			this.Controls.SetChildIndex(this.btnClr, 0);
			this.Controls.SetChildIndex(this.btnEnd, 0);
			this.Controls.SetChildIndex(this.btnOk, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.txtSaleYm, 0);
			this.Controls.SetChildIndex(this.txtEngineerId, 0);
			this.Controls.SetChildIndex(this.btnEngineer, 0);
			this.Controls.SetChildIndex(this.lblEngineerNm, 0);
			this.Controls.SetChildIndex(this.label10, 0);
			this.Controls.SetChildIndex(this.dtpStartYmd, 0);
			this.Controls.SetChildIndex(this.label13, 0);
			this.Controls.SetChildIndex(this.label14, 0);
			this.Controls.SetChildIndex(this.dtpEndYmd, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.nudOperationTime, 0);
			this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
			this.Controls.SetChildIndex(this.label20, 0);
			this.Controls.SetChildIndex(this.btnDel, 0);
			this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
			this.Controls.SetChildIndex(this.lblSaleNo, 0);
			this.Controls.SetChildIndex(this.btnExpense, 0);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private Common.ucYMTextbox txtSaleYm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblEngineerNm;
        private System.Windows.Forms.Button btnEngineer;
        private Common.ucNumTextBox txtEngineerId;
        private System.Windows.Forms.Label lblActuarialKbn;
        private System.Windows.Forms.Label lblProjectNm;
        private System.Windows.Forms.Label lblCustomerCd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCustomerNm;
        private Common.ctlDateTimePickerEx dtpEndYmd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private Common.ctlDateTimePickerEx dtpStartYmd;
        private Common.ucNumUpDown nudOperationTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblOrverAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBaseRate;
        private System.Windows.Forms.Label lblOrverRate;
        private System.Windows.Forms.Label lblSubtractRate;
        private System.Windows.Forms.Label lblOrderEnd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblOrderStart;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblLackTime;
        private System.Windows.Forms.Label lblOverTime;
        private System.Windows.Forms.Label lblBaseTime;
        private System.Windows.Forms.Label lblBaseAmount;
        private System.Windows.Forms.Label lblSubtractAmount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblSalesAmount;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblSaleNo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Button btnExpense;
	}
}