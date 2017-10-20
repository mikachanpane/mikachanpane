namespace Sugitec
{
	partial class frmInq010
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
			if(disposing && (components != null))
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
			this.dgv_Result = new Sugitec.Common.ucDataGridViewEx();
			this.dgv_Cus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Sime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Teki = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_SalYm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_SumSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Depo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_BillY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Transf = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Dis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Cancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Diff = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_DiffContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblSalYm = new System.Windows.Forms.Label();
			this.txtSalYm = new Sugitec.Common.ucYMTextbox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblSalSum = new System.Windows.Forms.Label();
			this.lblCash = new System.Windows.Forms.Label();
			this.lblDepo = new System.Windows.Forms.Label();
			this.lblBill = new System.Windows.Forms.Label();
			this.lblTransf = new System.Windows.Forms.Label();
			this.lblDis = new System.Windows.Forms.Label();
			this.lblCancel = new System.Windows.Forms.Label();
			this.lblDiff = new System.Windows.Forms.Label();
			this.btnClr = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			this.rdoCus = new System.Windows.Forms.RadioButton();
			this.rdoEng = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_Excel = new System.Windows.Forms.Button();
			this.btn_PDF = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv_Result
			// 
			this.dgv_Result.AllowUserToAddRows = false;
			this.dgv_Result.AllowUserToDeleteRows = false;
			this.dgv_Result.AllowUserToResizeRows = false;
			this.dgv_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgv_Result.ColumnHeaderBorderStyle = Sugitec.Common.ucDataGridViewEx.HeaderCellBorderStyle.SingleLine;
			this.dgv_Result.ColumnHeaderRowCount = 2;
			this.dgv_Result.ColumnHeaderRowHeight = 20;
			this.dgv_Result.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.OrangeRed;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_Result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_Result.ColumnHeadersHeight = 42;
			this.dgv_Result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_Cus,
            this.dgv_Sime,
            this.dgv_Teki,
            this.dgv_SalYm,
            this.dgv_SumSal,
            this.dgv_Cash,
            this.dgv_Depo,
            this.dgv_Bill,
            this.dgv_BillY,
            this.dgv_Transf,
            this.dgv_Dis,
            this.dgv_Cancel,
            this.dgv_Diff,
            this.dgv_DiffContent});
			headerCell1.BackgroundColor = System.Drawing.Color.Empty;
			headerCell1.Column = 0;
			headerCell1.ColumnSpan = 1;
			headerCell1.ForeColor = System.Drawing.Color.Empty;
			headerCell1.Row = 0;
			headerCell1.RowSpan = 2;
			headerCell1.SortVisible = false;
			headerCell1.Text = "得意先";
			headerCell1.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell1.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell2.BackgroundColor = System.Drawing.Color.Empty;
			headerCell2.Column = 1;
			headerCell2.ColumnSpan = 1;
			headerCell2.ForeColor = System.Drawing.Color.Empty;
			headerCell2.Row = 0;
			headerCell2.RowSpan = 2;
			headerCell2.SortVisible = false;
			headerCell2.Text = "締";
			headerCell2.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell2.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell3.BackgroundColor = System.Drawing.Color.Empty;
			headerCell3.Column = 3;
			headerCell3.ColumnSpan = 1;
			headerCell3.ForeColor = System.Drawing.Color.Empty;
			headerCell3.Row = 0;
			headerCell3.RowSpan = 2;
			headerCell3.SortVisible = false;
			headerCell3.Text = "入金日";
			headerCell3.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell3.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell4.BackgroundColor = System.Drawing.Color.Empty;
			headerCell4.Column = 4;
			headerCell4.ColumnSpan = 1;
			headerCell4.ForeColor = System.Drawing.Color.Empty;
			headerCell4.Row = 0;
			headerCell4.RowSpan = 2;
			headerCell4.SortVisible = false;
			headerCell4.Text = "売上金額 (税込)";
			headerCell4.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell4.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell5.BackgroundColor = System.Drawing.Color.Empty;
			headerCell5.Column = 5;
			headerCell5.ColumnSpan = 3;
			headerCell5.ForeColor = System.Drawing.Color.Empty;
			headerCell5.Row = 0;
			headerCell5.RowSpan = 1;
			headerCell5.SortVisible = false;
			headerCell5.Text = "入金";
			headerCell5.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell5.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell6.BackgroundColor = System.Drawing.Color.Empty;
			headerCell6.Column = 5;
			headerCell6.ColumnSpan = 1;
			headerCell6.ForeColor = System.Drawing.Color.Empty;
			headerCell6.Row = 1;
			headerCell6.RowSpan = 1;
			headerCell6.SortVisible = false;
			headerCell6.Text = "現金";
			headerCell6.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell6.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell7.BackgroundColor = System.Drawing.Color.Empty;
			headerCell7.Column = 6;
			headerCell7.ColumnSpan = 1;
			headerCell7.ForeColor = System.Drawing.Color.Empty;
			headerCell7.Row = 1;
			headerCell7.RowSpan = 1;
			headerCell7.SortVisible = false;
			headerCell7.Text = "預金";
			headerCell7.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell7.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell8.BackgroundColor = System.Drawing.Color.Empty;
			headerCell8.Column = 7;
			headerCell8.ColumnSpan = 1;
			headerCell8.ForeColor = System.Drawing.Color.Empty;
			headerCell8.Row = 1;
			headerCell8.RowSpan = 1;
			headerCell8.SortVisible = false;
			headerCell8.Text = "手形";
			headerCell8.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell8.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell9.BackgroundColor = System.Drawing.Color.Empty;
			headerCell9.Column = 8;
			headerCell9.ColumnSpan = 1;
			headerCell9.ForeColor = System.Drawing.Color.Empty;
			headerCell9.Row = 0;
			headerCell9.RowSpan = 2;
			headerCell9.SortVisible = false;
			headerCell9.Text = "手形受取日";
			headerCell9.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell9.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell10.BackgroundColor = System.Drawing.Color.Empty;
			headerCell10.Column = 9;
			headerCell10.ColumnSpan = 1;
			headerCell10.ForeColor = System.Drawing.Color.Empty;
			headerCell10.Row = 0;
			headerCell10.RowSpan = 2;
			headerCell10.SortVisible = false;
			headerCell10.Text = "振込手数料";
			headerCell10.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell10.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell11.BackgroundColor = System.Drawing.Color.Empty;
			headerCell11.Column = 10;
			headerCell11.ColumnSpan = 1;
			headerCell11.ForeColor = System.Drawing.Color.Empty;
			headerCell11.Row = 0;
			headerCell11.RowSpan = 2;
			headerCell11.SortVisible = false;
			headerCell11.Text = "値引";
			headerCell11.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell11.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell12.BackgroundColor = System.Drawing.Color.Empty;
			headerCell12.Column = 11;
			headerCell12.ColumnSpan = 1;
			headerCell12.ForeColor = System.Drawing.Color.Empty;
			headerCell12.Row = 0;
			headerCell12.RowSpan = 2;
			headerCell12.SortVisible = false;
			headerCell12.Text = "ｷｬﾝｾﾙ";
			headerCell12.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell12.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell13.BackgroundColor = System.Drawing.Color.Empty;
			headerCell13.Column = 12;
			headerCell13.ColumnSpan = 1;
			headerCell13.ForeColor = System.Drawing.Color.Empty;
			headerCell13.Row = 0;
			headerCell13.RowSpan = 2;
			headerCell13.SortVisible = false;
			headerCell13.Text = "差額";
			headerCell13.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell13.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell14.BackgroundColor = System.Drawing.Color.Empty;
			headerCell14.Column = 13;
			headerCell14.ColumnSpan = 1;
			headerCell14.ForeColor = System.Drawing.Color.Empty;
			headerCell14.Row = 0;
			headerCell14.RowSpan = 2;
			headerCell14.SortVisible = false;
			headerCell14.Text = "差額内容";
			headerCell14.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell14.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
			headerCell15.BackgroundColor = System.Drawing.Color.Empty;
			headerCell15.Column = 2;
			headerCell15.ColumnSpan = 1;
			headerCell15.ForeColor = System.Drawing.Color.Empty;
			headerCell15.Row = 0;
			headerCell15.RowSpan = 2;
			headerCell15.SortVisible = false;
			headerCell15.Text = "技術者";
			headerCell15.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			headerCell15.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
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
			this.dgv_Result.HeaderCells.Add(headerCell13);
			this.dgv_Result.HeaderCells.Add(headerCell14);
			this.dgv_Result.HeaderCells.Add(headerCell15);
			this.dgv_Result.Location = new System.Drawing.Point(14, 96);
			this.dgv_Result.Name = "dgv_Result";
			this.dgv_Result.RowHeadersVisible = false;
			this.dgv_Result.RowTemplate.Height = 21;
			this.dgv_Result.Size = new System.Drawing.Size(1232, 389);
			this.dgv_Result.TabIndex = 3;
			// 
			// dgv_Cus
			// 
			this.dgv_Cus.HeaderText = "得意先";
			this.dgv_Cus.Name = "dgv_Cus";
			this.dgv_Cus.Width = 160;
			// 
			// dgv_Sime
			// 
			this.dgv_Sime.HeaderText = "絞";
			this.dgv_Sime.Name = "dgv_Sime";
			this.dgv_Sime.Width = 30;
			// 
			// dgv_Teki
			// 
			this.dgv_Teki.HeaderText = "技術者";
			this.dgv_Teki.Name = "dgv_Teki";
			this.dgv_Teki.Width = 80;
			// 
			// dgv_SalYm
			// 
			this.dgv_SalYm.HeaderText = "入金日";
			this.dgv_SalYm.Name = "dgv_SalYm";
			this.dgv_SalYm.Width = 80;
			// 
			// dgv_SumSal
			// 
			this.dgv_SumSal.HeaderText = "売上金額（税込）";
			this.dgv_SumSal.Name = "dgv_SumSal";
			this.dgv_SumSal.Width = 120;
			// 
			// dgv_Cash
			// 
			this.dgv_Cash.HeaderText = "現金";
			this.dgv_Cash.Name = "dgv_Cash";
			// 
			// dgv_Depo
			// 
			this.dgv_Depo.HeaderText = "預金";
			this.dgv_Depo.Name = "dgv_Depo";
			this.dgv_Depo.Width = 70;
			// 
			// dgv_Bill
			// 
			this.dgv_Bill.HeaderText = "手形";
			this.dgv_Bill.Name = "dgv_Bill";
			this.dgv_Bill.Width = 70;
			// 
			// dgv_BillY
			// 
			this.dgv_BillY.HeaderText = "手形受取日";
			this.dgv_BillY.Name = "dgv_BillY";
			this.dgv_BillY.Width = 80;
			// 
			// dgv_Transf
			// 
			this.dgv_Transf.HeaderText = "振込手数料";
			this.dgv_Transf.Name = "dgv_Transf";
			this.dgv_Transf.Width = 80;
			// 
			// dgv_Dis
			// 
			this.dgv_Dis.HeaderText = "値引";
			this.dgv_Dis.Name = "dgv_Dis";
			this.dgv_Dis.Width = 80;
			// 
			// dgv_Cancel
			// 
			this.dgv_Cancel.HeaderText = "キャンセル";
			this.dgv_Cancel.Name = "dgv_Cancel";
			this.dgv_Cancel.Width = 80;
			// 
			// dgv_Diff
			// 
			this.dgv_Diff.HeaderText = "差額";
			this.dgv_Diff.Name = "dgv_Diff";
			this.dgv_Diff.Width = 80;
			// 
			// dgv_DiffContent
			// 
			this.dgv_DiffContent.HeaderText = "差額内容";
			this.dgv_DiffContent.Name = "dgv_DiffContent";
			// 
			// lblSalYm
			// 
			this.lblSalYm.AutoSize = true;
			this.lblSalYm.Location = new System.Drawing.Point(124, 60);
			this.lblSalYm.Name = "lblSalYm";
			this.lblSalYm.Size = new System.Drawing.Size(21, 13);
			this.lblSalYm.TabIndex = 12;
			this.lblSalYm.Text = "度";
			// 
			// txtSalYm
			// 
			this.txtSalYm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtSalYm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtSalYm.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtSalYm.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSalYm.Location = new System.Drawing.Point(24, 56);
			this.txtSalYm.Name = "txtSalYm";
			this.txtSalYm.OldValue = null;
			this.txtSalYm.Size = new System.Drawing.Size(94, 20);
			this.txtSalYm.TabIndex = 1;
			this.txtSalYm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// btnSearch
			// 
			this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnSearch.FlatAppearance.BorderSize = 100;
			this.btnSearch.Location = new System.Drawing.Point(163, 48);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(108, 35);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "検索";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.GreenYellow;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(4, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(185, 44);
			this.label1.TabIndex = 13;
			this.label1.Text = "合計";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSalSum
			// 
			this.lblSalSum.AutoSize = true;
			this.lblSalSum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblSalSum.Location = new System.Drawing.Point(196, 1);
			this.lblSalSum.Name = "lblSalSum";
			this.lblSalSum.Size = new System.Drawing.Size(113, 44);
			this.lblSalSum.TabIndex = 15;
			this.lblSalSum.Text = "0";
			this.lblSalSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCash
			// 
			this.lblCash.AutoSize = true;
			this.lblCash.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCash.Location = new System.Drawing.Point(316, 1);
			this.lblCash.Name = "lblCash";
			this.lblCash.Size = new System.Drawing.Size(93, 44);
			this.lblCash.TabIndex = 17;
			this.lblCash.Text = "0";
			this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDepo
			// 
			this.lblDepo.AutoSize = true;
			this.lblDepo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDepo.Location = new System.Drawing.Point(416, 1);
			this.lblDepo.Name = "lblDepo";
			this.lblDepo.Size = new System.Drawing.Size(63, 44);
			this.lblDepo.TabIndex = 19;
			this.lblDepo.Text = "0";
			this.lblDepo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblBill
			// 
			this.lblBill.AutoSize = true;
			this.lblBill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblBill.Location = new System.Drawing.Point(486, 1);
			this.lblBill.Name = "lblBill";
			this.lblBill.Size = new System.Drawing.Size(63, 44);
			this.lblBill.TabIndex = 21;
			this.lblBill.Text = "0";
			this.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTransf
			// 
			this.lblTransf.AutoSize = true;
			this.lblTransf.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTransf.Location = new System.Drawing.Point(636, 1);
			this.lblTransf.Name = "lblTransf";
			this.lblTransf.Size = new System.Drawing.Size(73, 44);
			this.lblTransf.TabIndex = 23;
			this.lblTransf.Text = "0";
			this.lblTransf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDis
			// 
			this.lblDis.AutoSize = true;
			this.lblDis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDis.Location = new System.Drawing.Point(716, 1);
			this.lblDis.Name = "lblDis";
			this.lblDis.Size = new System.Drawing.Size(73, 44);
			this.lblDis.TabIndex = 25;
			this.lblDis.Text = "0";
			this.lblDis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCancel
			// 
			this.lblCancel.AutoSize = true;
			this.lblCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCancel.Location = new System.Drawing.Point(796, 1);
			this.lblCancel.Name = "lblCancel";
			this.lblCancel.Size = new System.Drawing.Size(73, 44);
			this.lblCancel.TabIndex = 27;
			this.lblCancel.Text = "0";
			this.lblCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDiff
			// 
			this.lblDiff.AutoSize = true;
			this.lblDiff.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDiff.Location = new System.Drawing.Point(876, 1);
			this.lblDiff.Name = "lblDiff";
			this.lblDiff.Size = new System.Drawing.Size(73, 44);
			this.lblDiff.TabIndex = 29;
			this.lblDiff.Text = "0";
			this.lblDiff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnClr
			// 
			this.btnClr.Location = new System.Drawing.Point(1054, 41);
			this.btnClr.Name = "btnClr";
			this.btnClr.Size = new System.Drawing.Size(93, 43);
			this.btnClr.TabIndex = 32;
			this.btnClr.Text = "クリア";
			this.btnClr.UseVisualStyleBackColor = true;
			this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(1153, 40);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(93, 43);
			this.btnEnd.TabIndex = 33;
			this.btnEnd.Text = "終了";
			this.btnEnd.UseVisualStyleBackColor = true;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// rdoCus
			// 
			this.rdoCus.AutoSize = true;
			this.rdoCus.Checked = true;
			this.rdoCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.rdoCus.Location = new System.Drawing.Point(21, 17);
			this.rdoCus.Name = "rdoCus";
			this.rdoCus.Size = new System.Drawing.Size(90, 22);
			this.rdoCus.TabIndex = 30;
			this.rdoCus.TabStop = true;
			this.rdoCus.Text = "得意先別";
			this.rdoCus.UseVisualStyleBackColor = true;
			// 
			// rdoEng
			// 
			this.rdoEng.AutoSize = true;
			this.rdoEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.rdoEng.Location = new System.Drawing.Point(130, 17);
			this.rdoEng.Name = "rdoEng";
			this.rdoEng.Size = new System.Drawing.Size(147, 22);
			this.rdoEng.TabIndex = 31;
			this.rdoEng.Text = "得意先・担当者別";
			this.rdoEng.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox1.Controls.Add(this.rdoCus);
			this.groupBox1.Controls.Add(this.rdoEng);
			this.groupBox1.Location = new System.Drawing.Point(281, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(306, 51);
			this.groupBox1.TabIndex = 38;
			this.groupBox1.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 13;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.lblSalSum, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblCash, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblDepo, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblBill, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblTransf, 8, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblDiff, 11, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblDis, 9, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblCancel, 10, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(173, 488);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1073, 46);
			this.tableLayoutPanel1.TabIndex = 39;
			// 
			// btn_Excel
			// 
			this.btn_Excel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btn_Excel.FlatAppearance.BorderSize = 6;
			this.btn_Excel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btn_Excel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_Excel.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_Excel.Location = new System.Drawing.Point(593, 41);
			this.btn_Excel.Name = "btn_Excel";
			this.btn_Excel.Size = new System.Drawing.Size(137, 43);
			this.btn_Excel.TabIndex = 40;
			this.btn_Excel.Text = "Excel発行";
			this.btn_Excel.Click += new System.EventHandler(this.btn_output_Click);
			// 
			// btn_PDF
			// 
			this.btn_PDF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btn_PDF.FlatAppearance.BorderSize = 6;
			this.btn_PDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btn_PDF.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_PDF.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_PDF.Location = new System.Drawing.Point(736, 41);
			this.btn_PDF.Name = "btn_PDF";
			this.btn_PDF.Size = new System.Drawing.Size(137, 43);
			this.btn_PDF.TabIndex = 41;
			this.btn_PDF.Text = "PDF発行";
			this.btn_PDF.Click += new System.EventHandler(this.btn_output_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnPrint.FlatAppearance.BorderSize = 6;
			this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnPrint.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnPrint.Location = new System.Drawing.Point(879, 41);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(137, 43);
			this.btnPrint.TabIndex = 42;
			this.btnPrint.Text = "印刷";
			this.btnPrint.Click += new System.EventHandler(this.btn_output_Click);
			// 
			// frmInq010
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1258, 565);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.btn_PDF);
			this.Controls.Add(this.btn_Excel);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnClr);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.lblSalYm);
			this.Controls.Add(this.txtSalYm);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.dgv_Result);
			this.Name = "frmInq010";
			this.Text = "INQ010";
			this.Controls.SetChildIndex(this.dgv_Result, 0);
			this.Controls.SetChildIndex(this.btnSearch, 0);
			this.Controls.SetChildIndex(this.txtSalYm, 0);
			this.Controls.SetChildIndex(this.lblSalYm, 0);
			this.Controls.SetChildIndex(this.btnEnd, 0);
			this.Controls.SetChildIndex(this.btnClr, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
			this.Controls.SetChildIndex(this.btn_Excel, 0);
			this.Controls.SetChildIndex(this.btn_PDF, 0);
			this.Controls.SetChildIndex(this.btnPrint, 0);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Common.ucDataGridViewEx dgv_Result;
		private System.Windows.Forms.Label lblSalYm;
		public Common.ucYMTextbox txtSalYm;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblSalSum;
		private System.Windows.Forms.Label lblCash;
		private System.Windows.Forms.Label lblDepo;
		private System.Windows.Forms.Label lblBill;
		private System.Windows.Forms.Label lblTransf;
		private System.Windows.Forms.Label lblDis;
		private System.Windows.Forms.Label lblCancel;
		private System.Windows.Forms.Label lblDiff;
		private System.Windows.Forms.Button btnClr;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.RadioButton rdoCus;
		private System.Windows.Forms.RadioButton rdoEng;
		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Cus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Sime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Teki;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_SalYm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_SumSal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Depo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_BillY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Transf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Dis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Diff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_DiffContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_PDF;
        private System.Windows.Forms.Button btnPrint;
    }
}