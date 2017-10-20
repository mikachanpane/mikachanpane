namespace Sugitec
{
    partial class frmRec010
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
			Sugitec.Common.HeaderCell headerCell13 = new Sugitec.Common.HeaderCell();
			Sugitec.Common.HeaderCell headerCell14 = new Sugitec.Common.HeaderCell();
			Sugitec.Common.HeaderCell headerCell15 = new Sugitec.Common.HeaderCell();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgv_result = new Sugitec.Common.ucDataGridViewEx();
			this.dgv_Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dgv_BillingYm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_RequestNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_ReqSubNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_TransferYmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_BillingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Recv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Transferfees = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Difference = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Diff = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dgv_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Cancel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.btnEnd = new System.Windows.Forms.Button();
			this.cmbCus = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cMboxYM = new Sugitec.Common.ucYMTextbox();
			this.nmCash = new Sugitec.Common.ucNumUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpReciptYMD = new Sugitec.Common.ctlDateTimePickerEx();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.nmBill = new Sugitec.Common.ucNumUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.nmDeposit = new Sugitec.Common.ucNumUpDown();
			this.dtpBill_YMD = new Sugitec.Common.ctlDateTimePickerEx();
			this.label7 = new System.Windows.Forms.Label();
			this.lblRecNo = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.nmFees = new Sugitec.Common.ucNumUpDown();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label16 = new System.Windows.Forms.Label();
			this.lblDepBill = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.lblDepCash = new System.Windows.Forms.Label();
			this.lblDepDeposit = new System.Windows.Forms.Label();
			this.lblDepFees = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv_result
			// 
			this.dgv_result.AllowUserToAddRows = false;
			this.dgv_result.AllowUserToDeleteRows = false;
			this.dgv_result.AllowUserToResizeRows = false;
			this.dgv_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_result.ColumnHeaderBorderStyle = Sugitec.Common.ucDataGridViewEx.HeaderCellBorderStyle.SingleLine;
			this.dgv_result.ColumnHeaderRowCount = 2;
			this.dgv_result.ColumnHeaderRowHeight = 20;
			this.dgv_result.ColumnHeadersHeight = 42;
			this.dgv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_Sel,
            this.dgv_BillingYm,
            this.dgv_RequestNo,
            this.dgv_ReqSubNo,
            this.dgv_TransferYmd,
            this.dgv_BillingAmount,
            this.dgv_Recv,
            this.dgv_Cash,
            this.dgv_Transferfees,
            this.dgv_Deposit,
            this.dgv_Bill,
            this.dgv_Difference,
            this.dgv_Diff,
            this.dgv_Discount,
            this.dgv_Cancel});
			headerCell1.BackgroundColor = System.Drawing.Color.Empty;
			headerCell1.Column = 0;
			headerCell1.ColumnSpan = 1;
			headerCell1.ForeColor = System.Drawing.Color.Empty;
			headerCell1.Row = 0;
			headerCell1.RowSpan = 2;
			headerCell1.SortVisible = false;
			headerCell1.Text = "選";
			headerCell1.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell1.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell2.BackgroundColor = System.Drawing.Color.Empty;
			headerCell2.Column = 1;
			headerCell2.ColumnSpan = 1;
			headerCell2.ForeColor = System.Drawing.Color.Empty;
			headerCell2.Row = 0;
			headerCell2.RowSpan = 2;
			headerCell2.SortVisible = false;
			headerCell2.Text = "請求年月";
			headerCell2.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell2.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell3.BackgroundColor = System.Drawing.Color.Empty;
			headerCell3.Column = 2;
			headerCell3.ColumnSpan = 2;
			headerCell3.ForeColor = System.Drawing.Color.Empty;
			headerCell3.Row = 0;
			headerCell3.RowSpan = 2;
			headerCell3.SortVisible = false;
			headerCell3.Text = "請求番号";
			headerCell3.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell3.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell4.BackgroundColor = System.Drawing.Color.Empty;
			headerCell4.Column = 4;
			headerCell4.ColumnSpan = 1;
			headerCell4.ForeColor = System.Drawing.Color.Empty;
			headerCell4.Row = 0;
			headerCell4.RowSpan = 2;
			headerCell4.SortVisible = false;
			headerCell4.Text = "振込指定日";
			headerCell4.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell4.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell5.BackgroundColor = System.Drawing.Color.Empty;
			headerCell5.Column = 5;
			headerCell5.ColumnSpan = 1;
			headerCell5.ForeColor = System.Drawing.Color.Empty;
			headerCell5.Row = 0;
			headerCell5.RowSpan = 2;
			headerCell5.SortVisible = false;
			headerCell5.Text = "請求金額";
			headerCell5.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell5.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell6.BackgroundColor = System.Drawing.Color.Empty;
			headerCell6.Column = 6;
			headerCell6.ColumnSpan = 1;
			headerCell6.ForeColor = System.Drawing.Color.Empty;
			headerCell6.Row = 0;
			headerCell6.RowSpan = 2;
			headerCell6.SortVisible = false;
			headerCell6.Text = "回収残額";
			headerCell6.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell6.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell7.BackgroundColor = System.Drawing.Color.Empty;
			headerCell7.Column = 7;
			headerCell7.ColumnSpan = 1;
			headerCell7.ForeColor = System.Drawing.Color.Empty;
			headerCell7.Row = 1;
			headerCell7.RowSpan = 1;
			headerCell7.SortVisible = false;
			headerCell7.Text = "現金（振込）";
			headerCell7.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell7.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell8.BackgroundColor = System.Drawing.Color.Empty;
			headerCell8.Column = 8;
			headerCell8.ColumnSpan = 1;
			headerCell8.ForeColor = System.Drawing.Color.Empty;
			headerCell8.Row = 1;
			headerCell8.RowSpan = 1;
			headerCell8.SortVisible = false;
			headerCell8.Text = "振込手数料";
			headerCell8.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell8.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell9.BackgroundColor = System.Drawing.Color.Empty;
			headerCell9.Column = 9;
			headerCell9.ColumnSpan = 1;
			headerCell9.ForeColor = System.Drawing.Color.Empty;
			headerCell9.Row = 1;
			headerCell9.RowSpan = 1;
			headerCell9.SortVisible = false;
			headerCell9.Text = "預金";
			headerCell9.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell9.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell10.BackgroundColor = System.Drawing.Color.Empty;
			headerCell10.Column = 10;
			headerCell10.ColumnSpan = 1;
			headerCell10.ForeColor = System.Drawing.Color.Empty;
			headerCell10.Row = 1;
			headerCell10.RowSpan = 1;
			headerCell10.SortVisible = false;
			headerCell10.Text = "手形";
			headerCell10.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell10.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell11.BackgroundColor = System.Drawing.Color.Empty;
			headerCell11.Column = 11;
			headerCell11.ColumnSpan = 1;
			headerCell11.ForeColor = System.Drawing.Color.Empty;
			headerCell11.Row = 0;
			headerCell11.RowSpan = 2;
			headerCell11.SortVisible = false;
			headerCell11.Text = "差額";
			headerCell11.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell11.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell12.BackgroundColor = System.Drawing.Color.Empty;
			headerCell12.Column = 12;
			headerCell12.ColumnSpan = 1;
			headerCell12.ForeColor = System.Drawing.Color.Empty;
			headerCell12.Row = 0;
			headerCell12.RowSpan = 2;
			headerCell12.SortVisible = false;
			headerCell12.Text = "差額理由";
			headerCell12.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell12.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell13.BackgroundColor = System.Drawing.Color.Empty;
			headerCell13.Column = 13;
			headerCell13.ColumnSpan = 1;
			headerCell13.ForeColor = System.Drawing.Color.Empty;
			headerCell13.Row = 0;
			headerCell13.RowSpan = 2;
			headerCell13.SortVisible = false;
			headerCell13.Text = "値引";
			headerCell13.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell13.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell14.BackgroundColor = System.Drawing.Color.Empty;
			headerCell14.Column = 14;
			headerCell14.ColumnSpan = 1;
			headerCell14.ForeColor = System.Drawing.Color.Empty;
			headerCell14.Row = 0;
			headerCell14.RowSpan = 2;
			headerCell14.SortVisible = false;
			headerCell14.Text = "ｷｬﾝｾﾙ";
			headerCell14.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell14.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell15.BackgroundColor = System.Drawing.Color.Empty;
			headerCell15.Column = 7;
			headerCell15.ColumnSpan = 4;
			headerCell15.ForeColor = System.Drawing.Color.Empty;
			headerCell15.Row = 0;
			headerCell15.RowSpan = 1;
			headerCell15.SortVisible = false;
			headerCell15.Text = "回収金額";
			headerCell15.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell15.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			this.dgv_result.HeaderCells.Add(headerCell1);
			this.dgv_result.HeaderCells.Add(headerCell2);
			this.dgv_result.HeaderCells.Add(headerCell3);
			this.dgv_result.HeaderCells.Add(headerCell4);
			this.dgv_result.HeaderCells.Add(headerCell5);
			this.dgv_result.HeaderCells.Add(headerCell6);
			this.dgv_result.HeaderCells.Add(headerCell7);
			this.dgv_result.HeaderCells.Add(headerCell8);
			this.dgv_result.HeaderCells.Add(headerCell9);
			this.dgv_result.HeaderCells.Add(headerCell10);
			this.dgv_result.HeaderCells.Add(headerCell11);
			this.dgv_result.HeaderCells.Add(headerCell12);
			this.dgv_result.HeaderCells.Add(headerCell13);
			this.dgv_result.HeaderCells.Add(headerCell14);
			this.dgv_result.HeaderCells.Add(headerCell15);
			this.dgv_result.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.dgv_result.Location = new System.Drawing.Point(12, 201);
			this.dgv_result.Name = "dgv_result";
			this.dgv_result.RowHeadersVisible = false;
			this.dgv_result.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgv_result.RowTemplate.Height = 21;
			this.dgv_result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgv_result.Size = new System.Drawing.Size(1225, 327);
			this.dgv_result.TabIndex = 12;
			this.dgv_result.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_result_CellMouseDoubleClick);
			this.dgv_result.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_result_CellValidated);
			this.dgv_result.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_result_CellValidating);
			this.dgv_result.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_result_CellValueChanged);
			this.dgv_result.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_result_CurrentCellDirtyStateChanged);
			this.dgv_result.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_result_EditingControlShowing);
			// 
			// dgv_Sel
			// 
			this.dgv_Sel.FalseValue = "0";
			this.dgv_Sel.HeaderText = "選";
			this.dgv_Sel.Name = "dgv_Sel";
			this.dgv_Sel.TrueValue = "1";
			this.dgv_Sel.Width = 35;
			// 
			// dgv_BillingYm
			// 
			this.dgv_BillingYm.HeaderText = "請求年月";
			this.dgv_BillingYm.Name = "dgv_BillingYm";
			this.dgv_BillingYm.ReadOnly = true;
			this.dgv_BillingYm.Width = 75;
			// 
			// dgv_RequestNo
			// 
			this.dgv_RequestNo.HeaderText = "請求番号";
			this.dgv_RequestNo.Name = "dgv_RequestNo";
			this.dgv_RequestNo.ReadOnly = true;
			this.dgv_RequestNo.Width = 75;
			// 
			// dgv_ReqSubNo
			// 
			this.dgv_ReqSubNo.HeaderText = "枝番";
			this.dgv_ReqSubNo.Name = "dgv_ReqSubNo";
			this.dgv_ReqSubNo.ReadOnly = true;
			this.dgv_ReqSubNo.Width = 40;
			// 
			// dgv_TransferYmd
			// 
			this.dgv_TransferYmd.HeaderText = "振込指定日";
			this.dgv_TransferYmd.Name = "dgv_TransferYmd";
			this.dgv_TransferYmd.ReadOnly = true;
			this.dgv_TransferYmd.Width = 90;
			// 
			// dgv_BillingAmount
			// 
			dataGridViewCellStyle1.Format = "#,0";
			dataGridViewCellStyle1.NullValue = "0";
			this.dgv_BillingAmount.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_BillingAmount.HeaderText = "請求金額";
			this.dgv_BillingAmount.Name = "dgv_BillingAmount";
			this.dgv_BillingAmount.ReadOnly = true;
			this.dgv_BillingAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dgv_Recv
			// 
			this.dgv_Recv.HeaderText = "回収残額";
			this.dgv_Recv.Name = "dgv_Recv";
			this.dgv_Recv.ReadOnly = true;
			// 
			// dgv_Cash
			// 
			dataGridViewCellStyle2.Format = "#,0";
			dataGridViewCellStyle2.NullValue = "0";
			this.dgv_Cash.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_Cash.HeaderText = "現金";
			this.dgv_Cash.Name = "dgv_Cash";
			this.dgv_Cash.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dgv_Transferfees
			// 
			dataGridViewCellStyle3.Format = "#,0";
			dataGridViewCellStyle3.NullValue = "0";
			this.dgv_Transferfees.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_Transferfees.HeaderText = "振込手数料";
			this.dgv_Transferfees.Name = "dgv_Transferfees";
			this.dgv_Transferfees.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_Transferfees.Width = 80;
			// 
			// dgv_Deposit
			// 
			dataGridViewCellStyle4.Format = "#,0";
			dataGridViewCellStyle4.NullValue = "0";
			this.dgv_Deposit.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_Deposit.HeaderText = "預金";
			this.dgv_Deposit.Name = "dgv_Deposit";
			this.dgv_Deposit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_Deposit.Width = 80;
			// 
			// dgv_Bill
			// 
			dataGridViewCellStyle5.Format = "#,0";
			dataGridViewCellStyle5.NullValue = "0";
			this.dgv_Bill.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgv_Bill.HeaderText = "手形";
			this.dgv_Bill.Name = "dgv_Bill";
			this.dgv_Bill.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_Bill.Width = 80;
			// 
			// dgv_Difference
			// 
			this.dgv_Difference.HeaderText = "差額";
			this.dgv_Difference.Name = "dgv_Difference";
			// 
			// dgv_Diff
			// 
			this.dgv_Diff.HeaderText = "差異理由";
			this.dgv_Diff.Name = "dgv_Diff";
			this.dgv_Diff.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dgv_Discount
			// 
			dataGridViewCellStyle6.Format = "#,0";
			dataGridViewCellStyle6.NullValue = "0";
			this.dgv_Discount.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgv_Discount.HeaderText = "値引";
			this.dgv_Discount.Name = "dgv_Discount";
			this.dgv_Discount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dgv_Cancel
			// 
			this.dgv_Cancel.HeaderText = "ｷｬﾝｾﾙ";
			this.dgv_Cancel.Name = "dgv_Cancel";
			this.dgv_Cancel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_Cancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dgv_Cancel.Width = 50;
			// 
			// btnEnd
			// 
			this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEnd.Location = new System.Drawing.Point(1143, 534);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(93, 43);
			this.btnEnd.TabIndex = 15;
			this.btnEnd.Text = "終了";
			this.btnEnd.UseVisualStyleBackColor = true;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// cmbCus
			// 
			this.cmbCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.cmbCus.FormattingEnabled = true;
			this.cmbCus.Location = new System.Drawing.Point(100, 46);
			this.cmbCus.Name = "cmbCus";
			this.cmbCus.Size = new System.Drawing.Size(273, 21);
			this.cmbCus.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.GreenYellow;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(16, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "得意先";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.GreenYellow;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(178, 175);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "請求年月";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cMboxYM
			// 
			this.cMboxYM.BackColor = System.Drawing.SystemColors.Window;
			this.cMboxYM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.cMboxYM.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cMboxYM.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cMboxYM.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cMboxYM.Location = new System.Drawing.Point(262, 175);
			this.cMboxYM.Name = "cMboxYM";
			this.cMboxYM.OldValue = null;
			this.cMboxYM.Size = new System.Drawing.Size(99, 20);
			this.cMboxYM.TabIndex = 9;
			this.cMboxYM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// nmCash
			// 
			this.nmCash.BackColor = System.Drawing.SystemColors.Window;
			this.nmCash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nmCash.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nmCash.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.nmCash.ForeColor = System.Drawing.SystemColors.WindowText;
			this.nmCash.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.nmCash.Location = new System.Drawing.Point(162, 30);
			this.nmCash.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.nmCash.Name = "nmCash";
			this.nmCash.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.nmCash.Size = new System.Drawing.Size(151, 19);
			this.nmCash.TabIndex = 6;
			this.nmCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nmCash.ThousandsSeparator = true;
			this.nmCash.Validated += new System.EventHandler(this.RecoveryAmt_Validated);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.GreenYellow;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(393, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "入金日";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpReciptYMD
			// 
			this.dtpReciptYMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.dtpReciptYMD.Location = new System.Drawing.Point(477, 46);
			this.dtpReciptYMD.Name = "dtpReciptYMD";
			this.dtpReciptYMD.Size = new System.Drawing.Size(142, 20);
			this.dtpReciptYMD.TabIndex = 4;
			this.dtpReciptYMD.Value = null;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.GreenYellow;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(159, 1);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 25);
			this.label4.TabIndex = 1;
			this.label4.Text = "現金（振込）";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.GreenYellow;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(633, 1);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(157, 25);
			this.label5.TabIndex = 4;
			this.label5.Text = "手形";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nmBill
			// 
			this.nmBill.BackColor = System.Drawing.SystemColors.Window;
			this.nmBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nmBill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nmBill.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.nmBill.ForeColor = System.Drawing.SystemColors.WindowText;
			this.nmBill.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.nmBill.Location = new System.Drawing.Point(636, 30);
			this.nmBill.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.nmBill.Name = "nmBill";
			this.nmBill.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.nmBill.Size = new System.Drawing.Size(151, 19);
			this.nmBill.TabIndex = 9;
			this.nmBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nmBill.ThousandsSeparator = true;
			this.nmBill.Validated += new System.EventHandler(this.RecoveryAmt_Validated);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.GreenYellow;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(475, 1);
			this.label6.Margin = new System.Windows.Forms.Padding(0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(157, 25);
			this.label6.TabIndex = 3;
			this.label6.Text = "預金";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nmDeposit
			// 
			this.nmDeposit.BackColor = System.Drawing.SystemColors.Window;
			this.nmDeposit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nmDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nmDeposit.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.nmDeposit.ForeColor = System.Drawing.SystemColors.WindowText;
			this.nmDeposit.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.nmDeposit.Location = new System.Drawing.Point(478, 30);
			this.nmDeposit.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.nmDeposit.Name = "nmDeposit";
			this.nmDeposit.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.nmDeposit.Size = new System.Drawing.Size(151, 19);
			this.nmDeposit.TabIndex = 8;
			this.nmDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nmDeposit.ThousandsSeparator = true;
			this.nmDeposit.Validated += new System.EventHandler(this.RecoveryAmt_Validated);
			// 
			// dtpBill_YMD
			// 
			this.dtpBill_YMD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtpBill_YMD.Location = new System.Drawing.Point(794, 30);
			this.dtpBill_YMD.Name = "dtpBill_YMD";
			this.dtpBill_YMD.Size = new System.Drawing.Size(154, 20);
			this.dtpBill_YMD.TabIndex = 10;
			this.dtpBill_YMD.Value = null;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.GreenYellow;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(791, 1);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(160, 25);
			this.label7.TabIndex = 5;
			this.label7.Text = "手形受取日";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRecNo
			// 
			this.lblRecNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblRecNo.Location = new System.Drawing.Point(869, 45);
			this.lblRecNo.Name = "lblRecNo";
			this.lblRecNo.Size = new System.Drawing.Size(100, 20);
			this.lblRecNo.TabIndex = 6;
			this.lblRecNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Pink;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(785, 47);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(78, 20);
			this.label8.TabIndex = 5;
			this.label8.Text = "入金№";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.GreenYellow;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Location = new System.Drawing.Point(317, 1);
			this.label9.Margin = new System.Windows.Forms.Padding(0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(157, 25);
			this.label9.TabIndex = 2;
			this.label9.Text = "振込手数料";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nmFees
			// 
			this.nmFees.BackColor = System.Drawing.SystemColors.Window;
			this.nmFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nmFees.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nmFees.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.nmFees.ForeColor = System.Drawing.SystemColors.WindowText;
			this.nmFees.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.nmFees.Location = new System.Drawing.Point(320, 30);
			this.nmFees.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.nmFees.Name = "nmFees";
			this.nmFees.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.nmFees.Size = new System.Drawing.Size(151, 19);
			this.nmFees.TabIndex = 7;
			this.nmFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nmFees.ThousandsSeparator = true;
			this.nmFees.Validated += new System.EventHandler(this.RecoveryAmt_Validated);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(408, 164);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(93, 33);
			this.btnSearch.TabIndex = 11;
			this.btnSearch.Text = "検索";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.Location = new System.Drawing.Point(1044, 534);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(93, 43);
			this.btnClear.TabIndex = 14;
			this.btnClear.Text = "クリア";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSubmit.Location = new System.Drawing.Point(945, 534);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(93, 43);
			this.btnSubmit.TabIndex = 13;
			this.btnSubmit.Text = "確定";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Controls.Add(this.label16, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblDepBill, 4, 2);
			this.tableLayoutPanel1.Controls.Add(this.label15, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblDepCash, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblDepDeposit, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblDepFees, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label7, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.nmCash, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.nmBill, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.nmDeposit, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.nmFees, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.dtpBill_YMD, 5, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 76);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(952, 79);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.GreenYellow;
			this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label16.Location = new System.Drawing.Point(4, 53);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(151, 25);
			this.label16.TabIndex = 17;
			this.label16.Text = "消込可能額";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDepBill
			// 
			this.lblDepBill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDepBill.Location = new System.Drawing.Point(633, 53);
			this.lblDepBill.Margin = new System.Windows.Forms.Padding(0);
			this.lblDepBill.Name = "lblDepBill";
			this.lblDepBill.Size = new System.Drawing.Size(157, 25);
			this.lblDepBill.TabIndex = 19;
			this.lblDepBill.Text = "999999";
			this.lblDepBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.GreenYellow;
			this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label15.Location = new System.Drawing.Point(4, 27);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(151, 25);
			this.label15.TabIndex = 16;
			this.label15.Text = "入金額";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDepCash
			// 
			this.lblDepCash.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDepCash.Location = new System.Drawing.Point(159, 53);
			this.lblDepCash.Margin = new System.Windows.Forms.Padding(0);
			this.lblDepCash.Name = "lblDepCash";
			this.lblDepCash.Size = new System.Drawing.Size(157, 25);
			this.lblDepCash.TabIndex = 16;
			this.lblDepCash.Text = "999999";
			this.lblDepCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDepDeposit
			// 
			this.lblDepDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDepDeposit.Location = new System.Drawing.Point(475, 53);
			this.lblDepDeposit.Margin = new System.Windows.Forms.Padding(0);
			this.lblDepDeposit.Name = "lblDepDeposit";
			this.lblDepDeposit.Size = new System.Drawing.Size(157, 25);
			this.lblDepDeposit.TabIndex = 18;
			this.lblDepDeposit.Text = "999999";
			this.lblDepDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDepFees
			// 
			this.lblDepFees.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDepFees.Location = new System.Drawing.Point(317, 53);
			this.lblDepFees.Margin = new System.Windows.Forms.Padding(0);
			this.lblDepFees.Name = "lblDepFees";
			this.lblDepFees.Size = new System.Drawing.Size(157, 25);
			this.lblDepFees.TabIndex = 17;
			this.lblDepFees.Text = "999999";
			this.lblDepFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(367, 179);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 13);
			this.label10.TabIndex = 10;
			this.label10.Text = "以降";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Cyan;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Location = new System.Drawing.Point(12, 175);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(159, 20);
			this.label11.TabIndex = 16;
			this.label11.Text = "回収対象一覧";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmRec010
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1248, 602);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblRecNo);
			this.Controls.Add(this.dtpReciptYMD);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cMboxYM);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbCus);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.dgv_result);
			this.Name = "frmRec010";
			this.Text = "frmRec010";
			this.Load += new System.EventHandler(this.frmRec010_Load);
			this.Controls.SetChildIndex(this.dgv_result, 0);
			this.Controls.SetChildIndex(this.btnEnd, 0);
			this.Controls.SetChildIndex(this.cmbCus, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.cMboxYM, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.dtpReciptYMD, 0);
			this.Controls.SetChildIndex(this.lblRecNo, 0);
			this.Controls.SetChildIndex(this.label8, 0);
			this.Controls.SetChildIndex(this.btnSearch, 0);
			this.Controls.SetChildIndex(this.btnClear, 0);
			this.Controls.SetChildIndex(this.btnSubmit, 0);
			this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
			this.Controls.SetChildIndex(this.label10, 0);
			this.Controls.SetChildIndex(this.label11, 0);
			((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Sugitec.Common.ucDataGridViewEx dgv_result;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ComboBox cmbCus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Common.ucYMTextbox cMboxYM;
        private Common.ucNumUpDown nmCash;
        private System.Windows.Forms.Label label3;
        private Common.ctlDateTimePickerEx dtpReciptYMD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Common.ucNumUpDown nmBill;
        private System.Windows.Forms.Label label6;
        private Common.ucNumUpDown nmDeposit;
        private Common.ctlDateTimePickerEx dtpBill_YMD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRecNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Common.ucNumUpDown nmFees;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDepBill;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDepCash;
        private System.Windows.Forms.Label lblDepDeposit;
        private System.Windows.Forms.Label lblDepFees;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_BillingYm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_RequestNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ReqSubNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_TransferYmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_BillingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Recv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Transferfees;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Difference;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgv_Diff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Discount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_Cancel;
    }
}