namespace Sugitec
{
    partial class frmDep020
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
            this.label13 = new System.Windows.Forms.Label();
            this.lblReqNo = new System.Windows.Forms.Label();
            this.lblReqSubNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBilYm = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nmDiffAmt = new Sugitec.Common.ucNumUpDown();
            this.chkCancel = new System.Windows.Forms.CheckBox();
            this.nmDiscount = new Sugitec.Common.ucNumUpDown();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.labDepRcvAmt = new System.Windows.Forms.Label();
            this.lblBillAmt = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbDiffNm = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.dgvList = new Sugitec.Common.ucDataGridViewEx();
            this.dgv_RecNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_RecYmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_DepNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Del = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblCusNm = new System.Windows.Forms.Label();
            this.lblEngNm = new System.Windows.Forms.Label();
            this.lblTraYmd = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.GreenYellow;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(804, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "請求№";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReqNo
            // 
            this.lblReqNo.BackColor = System.Drawing.Color.Pink;
            this.lblReqNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReqNo.Location = new System.Drawing.Point(893, 58);
            this.lblReqNo.Name = "lblReqNo";
            this.lblReqNo.Size = new System.Drawing.Size(83, 20);
            this.lblReqNo.TabIndex = 8;
            this.lblReqNo.Text = "17041234";
            this.lblReqNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReqSubNo
            // 
            this.lblReqSubNo.BackColor = System.Drawing.Color.Pink;
            this.lblReqSubNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReqSubNo.Location = new System.Drawing.Point(982, 58);
            this.lblReqSubNo.Name = "lblReqSubNo";
            this.lblReqSubNo.Size = new System.Drawing.Size(32, 20);
            this.lblReqSubNo.TabIndex = 9;
            this.lblReqSubNo.Text = "01";
            this.lblReqSubNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.GreenYellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "請求年月";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBilYm
            // 
            this.lblBilYm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBilYm.Location = new System.Drawing.Point(129, 58);
            this.lblBilYm.Name = "lblBilYm";
            this.lblBilYm.Size = new System.Drawing.Size(83, 20);
            this.lblBilYm.TabIndex = 11;
            this.lblBilYm.Text = "2017/04";
            this.lblBilYm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.GreenYellow;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(15, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "得意先";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.GreenYellow;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(15, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "技術者";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.GreenYellow;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(15, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "振込指定日";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.GreenYellow;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(1, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.tableLayoutPanel1.SetRowSpan(this.label8, 2);
            this.label8.Size = new System.Drawing.Size(97, 49);
            this.label8.TabIndex = 15;
            this.label8.Text = "請求金額";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.7451F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.7451F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.Controls.Add(this.nmDiffAmt, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkCancel, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.nmDiscount, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBill, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDeposit, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFees, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCash, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labDepRcvAmt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBillAmt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label18, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label17, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label16, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label15, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbDiffNm, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.label28, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 182);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1004, 87);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // nmDiffAmt
            // 
            this.nmDiffAmt.BackColor = System.Drawing.SystemColors.Window;
            this.nmDiffAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nmDiffAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmDiffAmt.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nmDiffAmt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nmDiffAmt.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.nmDiffAmt.Location = new System.Drawing.Point(592, 59);
            this.nmDiffAmt.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.nmDiffAmt.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmDiffAmt.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.nmDiffAmt.Name = "nmDiffAmt";
            this.nmDiffAmt.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmDiffAmt.Size = new System.Drawing.Size(120, 27);
            this.nmDiffAmt.TabIndex = 32;
            this.nmDiffAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmDiffAmt.ThousandsSeparator = true;
            this.nmDiffAmt.ValueValidated += new System.EventHandler<System.EventArgs>(this.DiffAndDiscountAmt_ValueValidated);
            // 
            // chkCancel
            // 
            this.chkCancel.AutoCheck = false;
            this.chkCancel.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkCancel.Location = new System.Drawing.Point(944, 54);
            this.chkCancel.Name = "chkCancel";
            this.chkCancel.Size = new System.Drawing.Size(56, 29);
            this.chkCancel.TabIndex = 17;
            this.chkCancel.UseVisualStyleBackColor = true;
            this.chkCancel.Click += new System.EventHandler(this.chkCancel_Click);
            // 
            // nmDiscount
            // 
            this.nmDiscount.BackColor = System.Drawing.SystemColors.Window;
            this.nmDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nmDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmDiscount.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nmDiscount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nmDiscount.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.nmDiscount.Location = new System.Drawing.Point(817, 59);
            this.nmDiscount.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.nmDiscount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmDiscount.Size = new System.Drawing.Size(120, 27);
            this.nmDiscount.TabIndex = 17;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmDiscount.ThousandsSeparator = true;
            this.nmDiscount.ValueValidated += new System.EventHandler<System.EventArgs>(this.DiffAndDiscountAmt_ValueValidated);
            // 
            // lblBill
            // 
            this.lblBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBill.Location = new System.Drawing.Point(491, 51);
            this.lblBill.Margin = new System.Windows.Forms.Padding(0);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(97, 35);
            this.lblBill.TabIndex = 18;
            this.lblBill.Text = "999999";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDeposit
            // 
            this.lblDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeposit.Location = new System.Drawing.Point(393, 51);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(97, 35);
            this.lblDeposit.TabIndex = 18;
            this.lblDeposit.Text = "999999";
            this.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFees
            // 
            this.lblFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFees.Location = new System.Drawing.Point(295, 51);
            this.lblFees.Margin = new System.Windows.Forms.Padding(0);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(97, 35);
            this.lblFees.TabIndex = 18;
            this.lblFees.Text = "999999";
            this.lblFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCash
            // 
            this.lblCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCash.Location = new System.Drawing.Point(197, 51);
            this.lblCash.Margin = new System.Windows.Forms.Padding(0);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(97, 35);
            this.lblCash.TabIndex = 18;
            this.lblCash.Text = "999999";
            this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labDepRcvAmt
            // 
            this.labDepRcvAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labDepRcvAmt.Location = new System.Drawing.Point(99, 51);
            this.labDepRcvAmt.Margin = new System.Windows.Forms.Padding(0);
            this.labDepRcvAmt.Name = "labDepRcvAmt";
            this.labDepRcvAmt.Size = new System.Drawing.Size(97, 35);
            this.labDepRcvAmt.TabIndex = 18;
            this.labDepRcvAmt.Text = "999999";
            this.labDepRcvAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBillAmt
            // 
            this.lblBillAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBillAmt.Location = new System.Drawing.Point(1, 51);
            this.lblBillAmt.Margin = new System.Windows.Forms.Padding(0);
            this.lblBillAmt.Name = "lblBillAmt";
            this.lblBillAmt.Size = new System.Drawing.Size(97, 35);
            this.lblBillAmt.TabIndex = 17;
            this.lblBillAmt.Text = "999999";
            this.lblBillAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.GreenYellow;
            this.tableLayoutPanel1.SetColumnSpan(this.label18, 4);
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(197, 1);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(391, 24);
            this.label18.TabIndex = 18;
            this.label18.Text = "回収金額";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.GreenYellow;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(716, 1);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.tableLayoutPanel1.SetRowSpan(this.label17, 2);
            this.label17.Size = new System.Drawing.Size(97, 49);
            this.label17.TabIndex = 24;
            this.label17.Text = "差額理由";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.GreenYellow;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(941, 1);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.tableLayoutPanel1.SetRowSpan(this.label16, 2);
            this.label16.Size = new System.Drawing.Size(62, 49);
            this.label16.TabIndex = 23;
            this.label16.Text = "ｷｬﾝｾﾙ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.GreenYellow;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(814, 1);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.tableLayoutPanel1.SetRowSpan(this.label15, 2);
            this.label15.Size = new System.Drawing.Size(126, 49);
            this.label15.TabIndex = 22;
            this.label15.Text = "値引";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.GreenYellow;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(99, 1);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.tableLayoutPanel1.SetRowSpan(this.label9, 2);
            this.label9.Size = new System.Drawing.Size(97, 49);
            this.label9.TabIndex = 17;
            this.label9.Text = "回収残高";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.GreenYellow;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(197, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "現金";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.GreenYellow;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(295, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "振込手数料";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.GreenYellow;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(393, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "預金";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.GreenYellow;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(491, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 24);
            this.label14.TabIndex = 21;
            this.label14.Text = "手形";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDiffNm
            // 
            this.cmbDiffNm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDiffNm.FormattingEnabled = true;
            this.cmbDiffNm.Location = new System.Drawing.Point(719, 59);
            this.cmbDiffNm.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.cmbDiffNm.Name = "cmbDiffNm";
            this.cmbDiffNm.Size = new System.Drawing.Size(91, 21);
            this.cmbDiffNm.TabIndex = 25;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.GreenYellow;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Location = new System.Drawing.Point(589, 1);
            this.label28.Margin = new System.Windows.Forms.Padding(0);
            this.label28.Name = "label28";
            this.tableLayoutPanel1.SetRowSpan(this.label28, 2);
            this.label28.Size = new System.Drawing.Size(126, 49);
            this.label28.TabIndex = 32;
            this.label28.Text = "差額";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.ColumnHeaderBorderStyle = Sugitec.Common.ucDataGridViewEx.HeaderCellBorderStyle.SingleLine;
            this.dgvList.ColumnHeaderRowCount = 1;
            this.dgvList.ColumnHeaderRowHeight = 20;
            this.dgvList.ColumnHeadersHeight = 22;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_RecNo,
            this.dgv_RecYmd,
            this.dgv_Cash,
            this.dgv_Fees,
            this.dgv_Deposit,
            this.dgv_Bill,
            this.dgv_DepNo,
            this.dgv_Del});
            headerCell1.BackgroundColor = System.Drawing.Color.Empty;
            headerCell1.Column = 0;
            headerCell1.ColumnSpan = 1;
            headerCell1.ForeColor = System.Drawing.Color.Empty;
            headerCell1.Row = 0;
            headerCell1.RowSpan = 1;
            headerCell1.SortVisible = false;
            headerCell1.Text = "入金№";
            headerCell1.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell1.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell2.BackgroundColor = System.Drawing.Color.Empty;
            headerCell2.Column = 1;
            headerCell2.ColumnSpan = 1;
            headerCell2.ForeColor = System.Drawing.Color.Empty;
            headerCell2.Row = 0;
            headerCell2.RowSpan = 1;
            headerCell2.SortVisible = false;
            headerCell2.Text = "入金日";
            headerCell2.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell2.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell3.BackgroundColor = System.Drawing.Color.Empty;
            headerCell3.Column = 2;
            headerCell3.ColumnSpan = 1;
            headerCell3.ForeColor = System.Drawing.Color.Empty;
            headerCell3.Row = 0;
            headerCell3.RowSpan = 1;
            headerCell3.SortVisible = false;
            headerCell3.Text = "現金";
            headerCell3.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell3.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell4.BackgroundColor = System.Drawing.Color.Empty;
            headerCell4.Column = 3;
            headerCell4.ColumnSpan = 1;
            headerCell4.ForeColor = System.Drawing.Color.Empty;
            headerCell4.Row = 0;
            headerCell4.RowSpan = 1;
            headerCell4.SortVisible = false;
            headerCell4.Text = "振込手数料";
            headerCell4.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell4.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell5.BackgroundColor = System.Drawing.Color.Empty;
            headerCell5.Column = 4;
            headerCell5.ColumnSpan = 1;
            headerCell5.ForeColor = System.Drawing.Color.Empty;
            headerCell5.Row = 0;
            headerCell5.RowSpan = 1;
            headerCell5.SortVisible = false;
            headerCell5.Text = "預金";
            headerCell5.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell5.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell6.BackgroundColor = System.Drawing.Color.Empty;
            headerCell6.Column = 5;
            headerCell6.ColumnSpan = 1;
            headerCell6.ForeColor = System.Drawing.Color.Empty;
            headerCell6.Row = 0;
            headerCell6.RowSpan = 1;
            headerCell6.SortVisible = false;
            headerCell6.Text = "手形";
            headerCell6.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell6.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell7.BackgroundColor = System.Drawing.Color.Empty;
            headerCell7.Column = 6;
            headerCell7.ColumnSpan = 1;
            headerCell7.ForeColor = System.Drawing.Color.Empty;
            headerCell7.Row = 0;
            headerCell7.RowSpan = 1;
            headerCell7.SortVisible = false;
            headerCell7.Text = "消込№";
            headerCell7.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell7.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell8.BackgroundColor = System.Drawing.Color.Empty;
            headerCell8.Column = 7;
            headerCell8.ColumnSpan = 1;
            headerCell8.ForeColor = System.Drawing.Color.Empty;
            headerCell8.Row = 0;
            headerCell8.RowSpan = 1;
            headerCell8.SortVisible = false;
            headerCell8.Text = "削除";
            headerCell8.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell8.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.dgvList.HeaderCells.Add(headerCell1);
            this.dgvList.HeaderCells.Add(headerCell2);
            this.dgvList.HeaderCells.Add(headerCell3);
            this.dgvList.HeaderCells.Add(headerCell4);
            this.dgvList.HeaderCells.Add(headerCell5);
            this.dgvList.HeaderCells.Add(headerCell6);
            this.dgvList.HeaderCells.Add(headerCell7);
            this.dgvList.HeaderCells.Add(headerCell8);
            this.dgvList.Location = new System.Drawing.Point(12, 300);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 21;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(748, 180);
            this.dgvList.TabIndex = 17;
            this.dgvList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellValueChanged);
            this.dgvList.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvList_CurrentCellDirtyStateChanged);
            // 
            // dgv_RecNo
            // 
            this.dgv_RecNo.HeaderText = "入金№";
            this.dgv_RecNo.Name = "dgv_RecNo";
            this.dgv_RecNo.ReadOnly = true;
            this.dgv_RecNo.Width = 97;
            // 
            // dgv_RecYmd
            // 
            this.dgv_RecYmd.HeaderText = "入金日";
            this.dgv_RecYmd.Name = "dgv_RecYmd";
            this.dgv_RecYmd.ReadOnly = true;
            this.dgv_RecYmd.Width = 97;
            // 
            // dgv_Cash
            // 
            this.dgv_Cash.HeaderText = "現金";
            this.dgv_Cash.Name = "dgv_Cash";
            this.dgv_Cash.ReadOnly = true;
            this.dgv_Cash.Width = 98;
            // 
            // dgv_Fees
            // 
            this.dgv_Fees.HeaderText = "振込手数料";
            this.dgv_Fees.Name = "dgv_Fees";
            this.dgv_Fees.ReadOnly = true;
            this.dgv_Fees.Width = 98;
            // 
            // dgv_Deposit
            // 
            this.dgv_Deposit.HeaderText = "預金";
            this.dgv_Deposit.Name = "dgv_Deposit";
            this.dgv_Deposit.ReadOnly = true;
            this.dgv_Deposit.Width = 98;
            // 
            // dgv_Bill
            // 
            this.dgv_Bill.HeaderText = "手形";
            this.dgv_Bill.Name = "dgv_Bill";
            this.dgv_Bill.ReadOnly = true;
            this.dgv_Bill.Width = 98;
            // 
            // dgv_DepNo
            // 
            this.dgv_DepNo.HeaderText = "消込№";
            this.dgv_DepNo.Name = "dgv_DepNo";
            this.dgv_DepNo.ReadOnly = true;
            // 
            // dgv_Del
            // 
            this.dgv_Del.FalseValue = "0";
            this.dgv_Del.HeaderText = "削除";
            this.dgv_Del.Name = "dgv_Del";
            this.dgv_Del.TrueValue = "1";
            this.dgv_Del.Width = 40;
            // 
            // lblCusNm
            // 
            this.lblCusNm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCusNm.Location = new System.Drawing.Point(129, 90);
            this.lblCusNm.Name = "lblCusNm";
            this.lblCusNm.Size = new System.Drawing.Size(283, 20);
            this.lblCusNm.TabIndex = 18;
            this.lblCusNm.Text = "あああああああああああああああ";
            this.lblCusNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEngNm
            // 
            this.lblEngNm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEngNm.Location = new System.Drawing.Point(129, 121);
            this.lblEngNm.Name = "lblEngNm";
            this.lblEngNm.Size = new System.Drawing.Size(283, 20);
            this.lblEngNm.TabIndex = 19;
            this.lblEngNm.Text = "いいいいいいいいいいいいいい";
            this.lblEngNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTraYmd
            // 
            this.lblTraYmd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTraYmd.Location = new System.Drawing.Point(129, 151);
            this.lblTraYmd.Name = "lblTraYmd";
            this.lblTraYmd.Size = new System.Drawing.Size(83, 20);
            this.lblTraYmd.TabIndex = 20;
            this.lblTraYmd.Text = "2017/04/01";
            this.lblTraYmd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(719, 502);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 34);
            this.btnOk.TabIndex = 26;
            this.btnOk.Text = "確定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(922, 502);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(94, 34);
            this.btnEnd.TabIndex = 28;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(822, 502);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(94, 34);
            this.btnClr.TabIndex = 27;
            this.btnClr.Text = "クリア";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.GreenYellow;
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label27.Location = new System.Drawing.Point(12, 278);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 20);
            this.label27.TabIndex = 29;
            this.label27.Text = "回収一覧";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(779, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 34);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(779, 340);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(94, 34);
            this.btnUpd.TabIndex = 31;
            this.btnUpd.Text = "訂正";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // frmDep020
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 565);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.lblTraYmd);
            this.Controls.Add(this.lblEngNm);
            this.Controls.Add(this.lblCusNm);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBilYm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblReqSubNo);
            this.Controls.Add(this.lblReqNo);
            this.Controls.Add(this.label13);
            this.Name = "frmDep020";
            this.Text = "frmDep020";
            this.Load += new System.EventHandler(this.frmDep020_Load);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.lblReqNo, 0);
            this.Controls.SetChildIndex(this.lblReqSubNo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblBilYm, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.dgvList, 0);
            this.Controls.SetChildIndex(this.lblCusNm, 0);
            this.Controls.SetChildIndex(this.lblEngNm, 0);
            this.Controls.SetChildIndex(this.lblTraYmd, 0);
            this.Controls.SetChildIndex(this.btnClr, 0);
            this.Controls.SetChildIndex(this.btnEnd, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.label27, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnUpd, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblReqNo;
        private System.Windows.Forms.Label lblReqSubNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBilYm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label labDepRcvAmt;
        private System.Windows.Forms.Label lblBillAmt;
        private System.Windows.Forms.CheckBox chkCancel;
        private Common.ucNumUpDown nmDiscount;
        private System.Windows.Forms.ComboBox cmbDiffNm;
        private Common.ucDataGridViewEx dgvList;
        private System.Windows.Forms.Label lblCusNm;
        private System.Windows.Forms.Label lblEngNm;
        private System.Windows.Forms.Label lblTraYmd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpd;
        private Common.ucNumUpDown nmDiffAmt;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_RecNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_RecYmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_DepNo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_Del;
    }
}