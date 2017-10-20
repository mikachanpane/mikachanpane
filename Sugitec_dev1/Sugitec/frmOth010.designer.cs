namespace Sugitec
{
	partial class frmOth010
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
            Sugitec.Common.HeaderCell headerCell1 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell2 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell3 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell4 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell5 = new Sugitec.Common.HeaderCell();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.rdoOutside = new System.Windows.Forms.RadioButton();
            this.rdoIntside = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlCus = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCus = new System.Windows.Forms.ComboBox();
            this.dgvEngList = new Sugitec.Common.ucDataGridViewEx();
            this.dgvEng_Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvEng_EngID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEng_EngName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvList = new Sugitec.Common.ucDataGridViewEx();
            this.dgvDoc_Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvDoc_Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDoc_NOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnlCus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(588, 50);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 42);
            this.btnPrint.TabIndex = 32;
            this.btnPrint.Text = "印刷";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(687, 49);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(93, 43);
            this.btnEnd.TabIndex = 33;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // rdoOutside
            // 
            this.rdoOutside.AutoSize = true;
            this.rdoOutside.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoOutside.Location = new System.Drawing.Point(21, 17);
            this.rdoOutside.Name = "rdoOutside";
            this.rdoOutside.Size = new System.Drawing.Size(74, 22);
            this.rdoOutside.TabIndex = 30;
            this.rdoOutside.Text = "社外用";
            this.rdoOutside.UseVisualStyleBackColor = true;
            this.rdoOutside.CheckedChanged += new System.EventHandler(this.rdoOutside_CheckedChanged);
            // 
            // rdoIntside
            // 
            this.rdoIntside.AutoSize = true;
            this.rdoIntside.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoIntside.Location = new System.Drawing.Point(130, 17);
            this.rdoIntside.Name = "rdoIntside";
            this.rdoIntside.Size = new System.Drawing.Size(74, 22);
            this.rdoIntside.TabIndex = 31;
            this.rdoIntside.Text = "社内用";
            this.rdoIntside.UseVisualStyleBackColor = true;
            this.rdoIntside.CheckedChanged += new System.EventHandler(this.rdoIntside_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rdoOutside);
            this.groupBox1.Controls.Add(this.rdoIntside);
            this.groupBox1.Location = new System.Drawing.Point(18, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 51);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // pnlCus
            // 
            this.pnlCus.Controls.Add(this.label2);
            this.pnlCus.Controls.Add(this.cmbCon);
            this.pnlCus.Controls.Add(this.label1);
            this.pnlCus.Controls.Add(this.cmbCus);
            this.pnlCus.Location = new System.Drawing.Point(18, 102);
            this.pnlCus.Name = "pnlCus";
            this.pnlCus.Size = new System.Drawing.Size(361, 86);
            this.pnlCus.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "担当者";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCon
            // 
            this.cmbCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbCon.FormattingEnabled = true;
            this.cmbCon.Location = new System.Drawing.Point(100, 40);
            this.cmbCon.Name = "cmbCon";
            this.cmbCon.Size = new System.Drawing.Size(217, 21);
            this.cmbCon.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "得意先";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCus
            // 
            this.cmbCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbCus.FormattingEnabled = true;
            this.cmbCus.Location = new System.Drawing.Point(100, 13);
            this.cmbCus.Name = "cmbCus";
            this.cmbCus.Size = new System.Drawing.Size(217, 21);
            this.cmbCus.TabIndex = 4;
            this.cmbCus.SelectedIndexChanged += new System.EventHandler(this.cmbCus_SelectedIndexChanged);
            // 
            // dgvEngList
            // 
            this.dgvEngList.AllowUserToAddRows = false;
            this.dgvEngList.AllowUserToDeleteRows = false;
            this.dgvEngList.AllowUserToResizeRows = false;
            this.dgvEngList.ColumnHeaderBorderStyle = Sugitec.Common.ucDataGridViewEx.HeaderCellBorderStyle.SingleLine;
            this.dgvEngList.ColumnHeaderRowCount = 1;
            this.dgvEngList.ColumnHeaderRowHeight = 20;
            this.dgvEngList.ColumnHeadersHeight = 22;
            this.dgvEngList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvEng_Sel,
            this.dgvEng_EngID,
            this.dgvEng_EngName});
            headerCell1.BackgroundColor = System.Drawing.Color.Empty;
            headerCell1.Column = 0;
            headerCell1.ColumnSpan = 1;
            headerCell1.ForeColor = System.Drawing.Color.Empty;
            headerCell1.Row = 0;
            headerCell1.RowSpan = 1;
            headerCell1.SortVisible = false;
            headerCell1.Text = "選";
            headerCell1.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell1.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell2.BackgroundColor = System.Drawing.Color.Empty;
            headerCell2.Column = 1;
            headerCell2.ColumnSpan = 1;
            headerCell2.ForeColor = System.Drawing.Color.Empty;
            headerCell2.Row = 0;
            headerCell2.RowSpan = 1;
            headerCell2.SortVisible = false;
            headerCell2.Text = "ＩＤ";
            headerCell2.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell2.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell3.BackgroundColor = System.Drawing.Color.Empty;
            headerCell3.Column = 2;
            headerCell3.ColumnSpan = 1;
            headerCell3.ForeColor = System.Drawing.Color.Empty;
            headerCell3.Row = 0;
            headerCell3.RowSpan = 1;
            headerCell3.SortVisible = false;
            headerCell3.Text = "氏名";
            headerCell3.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell3.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.dgvEngList.HeaderCells.Add(headerCell1);
            this.dgvEngList.HeaderCells.Add(headerCell2);
            this.dgvEngList.HeaderCells.Add(headerCell3);
            this.dgvEngList.Location = new System.Drawing.Point(18, 102);
            this.dgvEngList.Name = "dgvEngList";
            this.dgvEngList.RowHeadersVisible = false;
            this.dgvEngList.RowTemplate.Height = 21;
            this.dgvEngList.Size = new System.Drawing.Size(361, 427);
            this.dgvEngList.TabIndex = 0;
            // 
            // dgvEng_Sel
            // 
            this.dgvEng_Sel.FalseValue = "0";
            this.dgvEng_Sel.HeaderText = "選";
            this.dgvEng_Sel.Name = "dgvEng_Sel";
            this.dgvEng_Sel.TrueValue = "1";
            this.dgvEng_Sel.Width = 40;
            // 
            // dgvEng_EngID
            // 
            this.dgvEng_EngID.HeaderText = "ＩＤ";
            this.dgvEng_EngID.Name = "dgvEng_EngID";
            this.dgvEng_EngID.ReadOnly = true;
            this.dgvEng_EngID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEng_EngID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvEng_EngName
            // 
            this.dgvEng_EngName.HeaderText = "氏名";
            this.dgvEng_EngName.Name = "dgvEng_EngName";
            this.dgvEng_EngName.ReadOnly = true;
            this.dgvEng_EngName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEng_EngName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvEng_EngName.Width = 200;
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
            this.dgvDoc_Sel,
            this.dgvDoc_Content,
            this.dgvDoc_NOC});
            headerCell4.BackgroundColor = System.Drawing.Color.Empty;
            headerCell4.Column = 0;
            headerCell4.ColumnSpan = 1;
            headerCell4.ForeColor = System.Drawing.Color.Empty;
            headerCell4.Row = 0;
            headerCell4.RowSpan = 1;
            headerCell4.SortVisible = false;
            headerCell4.Text = "選";
            headerCell4.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell4.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell5.BackgroundColor = System.Drawing.Color.Empty;
            headerCell5.Column = 1;
            headerCell5.ColumnSpan = 1;
            headerCell5.ForeColor = System.Drawing.Color.Empty;
            headerCell5.Row = 0;
            headerCell5.RowSpan = 1;
            headerCell5.SortVisible = false;
            headerCell5.Text = "資料名";
            headerCell5.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell5.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.dgvList.HeaderCells.Add(headerCell4);
            this.dgvList.HeaderCells.Add(headerCell5);
            this.dgvList.Location = new System.Drawing.Point(399, 102);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 21;
            this.dgvList.Size = new System.Drawing.Size(381, 427);
            this.dgvList.TabIndex = 40;
            // 
            // dgvDoc_Sel
            // 
            this.dgvDoc_Sel.FalseValue = "0";
            this.dgvDoc_Sel.HeaderText = "選";
            this.dgvDoc_Sel.Name = "dgvDoc_Sel";
            this.dgvDoc_Sel.TrueValue = "1";
            this.dgvDoc_Sel.Width = 40;
            // 
            // dgvDoc_Content
            // 
            this.dgvDoc_Content.HeaderText = "資料名";
            this.dgvDoc_Content.Name = "dgvDoc_Content";
            this.dgvDoc_Content.ReadOnly = true;
            this.dgvDoc_Content.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoc_Content.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvDoc_Content.Width = 280;
            // 
            // dgvDoc_NOC
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvDoc_NOC.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoc_NOC.HeaderText = "部数";
            this.dgvDoc_NOC.Name = "dgvDoc_NOC";
            this.dgvDoc_NOC.Width = 40;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(390, 50);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(93, 43);
            this.btnExcel.TabIndex = 41;
            this.btnExcel.Text = "Excel出力";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(489, 49);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(93, 43);
            this.btnPdf.TabIndex = 42;
            this.btnPdf.Text = "PDF出力";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // frmOth010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 565);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.dgvEngList);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlCus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEnd);
            this.Name = "frmOth010";
            this.Text = "OTH010";
            this.Controls.SetChildIndex(this.btnEnd, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlCus, 0);
            this.Controls.SetChildIndex(this.dgvList, 0);
            this.Controls.SetChildIndex(this.btnExcel, 0);
            this.Controls.SetChildIndex(this.dgvEngList, 0);
            this.Controls.SetChildIndex(this.btnPdf, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlCus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.RadioButton rdoOutside;
		private System.Windows.Forms.RadioButton rdoIntside;
		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlCus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCus;
        private Common.ucDataGridViewEx dgvEngList;
        private Common.ucDataGridViewEx dgvList;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvEng_Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEng_EngID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEng_EngName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvDoc_Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDoc_Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDoc_NOC;
        private System.Windows.Forms.Button btnPdf;
    }
}