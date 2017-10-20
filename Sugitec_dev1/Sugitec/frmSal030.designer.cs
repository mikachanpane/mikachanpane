namespace Sugitec
{
    partial class frmSal030
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
			this.btn_OK = new System.Windows.Forms.Button();
			this.btn_End = new System.Windows.Forms.Button();
			this.btn_DEL = new System.Windows.Forms.Button();
			this.label01 = new System.Windows.Forms.Label();
			this.dgv_expense = new Sugitec.Common.ucDataGridViewEx();
			this.dgv_del = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dgv_ym = new Sugitec.Common.ucDataGridViewDateColumn();
			this.dgv_cd = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dgv_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_biko1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_biko2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_tax = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.label16 = new System.Windows.Forms.Label();
			this.lblCusNm = new System.Windows.Forms.Label();
			this.lblEngNm = new System.Windows.Forms.Label();
			this.btn_CLR = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_expense)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_OK
			// 
			this.btn_OK.Location = new System.Drawing.Point(295, 68);
			this.btn_OK.Name = "btn_OK";
			this.btn_OK.Size = new System.Drawing.Size(75, 36);
			this.btn_OK.TabIndex = 11;
			this.btn_OK.Text = "確定";
			this.btn_OK.UseVisualStyleBackColor = true;
			this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
			// 
			// btn_End
			// 
			this.btn_End.Location = new System.Drawing.Point(538, 68);
			this.btn_End.Name = "btn_End";
			this.btn_End.Size = new System.Drawing.Size(75, 36);
			this.btn_End.TabIndex = 14;
			this.btn_End.Text = "終了";
			this.btn_End.UseVisualStyleBackColor = true;
			this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
			// 
			// btn_DEL
			// 
			this.btn_DEL.Location = new System.Drawing.Point(376, 68);
			this.btn_DEL.Name = "btn_DEL";
			this.btn_DEL.Size = new System.Drawing.Size(75, 36);
			this.btn_DEL.TabIndex = 12;
			this.btn_DEL.Text = "削除";
			this.btn_DEL.UseVisualStyleBackColor = true;
			this.btn_DEL.Click += new System.EventHandler(this.btn_DEL_Click);
			// 
			// label01
			// 
			this.label01.BackColor = System.Drawing.Color.GreenYellow;
			this.label01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label01.Location = new System.Drawing.Point(12, 45);
			this.label01.Name = "label01";
			this.label01.Size = new System.Drawing.Size(67, 20);
			this.label01.TabIndex = 50;
			this.label01.Text = "得意先名";
			this.label01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgv_expense
			// 
			this.dgv_expense.AllowUserToDeleteRows = false;
			this.dgv_expense.AllowUserToResizeRows = false;
			this.dgv_expense.ColumnHeaderBorderStyle = Sugitec.Common.ucDataGridViewEx.HeaderCellBorderStyle.SingleLine;
			this.dgv_expense.ColumnHeaderRowCount = 1;
			this.dgv_expense.ColumnHeaderRowHeight = 17;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_expense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_expense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_expense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_del,
            this.dgv_ym,
            this.dgv_cd,
            this.dgv_amount,
            this.dgv_biko1,
            this.dgv_biko2,
            this.dgv_tax});
			this.dgv_expense.Location = new System.Drawing.Point(12, 110);
			this.dgv_expense.Name = "dgv_expense";
			this.dgv_expense.RowHeadersVisible = false;
			this.dgv_expense.RowTemplate.Height = 21;
			this.dgv_expense.Size = new System.Drawing.Size(601, 339);
			this.dgv_expense.TabIndex = 62;
			this.dgv_expense.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_expense_CellValidating);
			// 
			// dgv_del
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Format = "d";
			dataGridViewCellStyle2.NullValue = false;
			this.dgv_del.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_del.HeaderText = "削";
			this.dgv_del.Name = "dgv_del";
			this.dgv_del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dgv_del.Width = 30;
			// 
			// dgv_ym
			// 
			this.dgv_ym.CustomFormat = "yyyy/MM/dd";
			this.dgv_ym.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dgv_ym.HeaderText = "計上日";
			this.dgv_ym.InputFormat = "";
			this.dgv_ym.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dgv_ym.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dgv_ym.Name = "dgv_ym";
			this.dgv_ym.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_ym.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dgv_cd
			// 
			dataGridViewCellStyle3.NullValue = null;
			this.dgv_cd.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_cd.HeaderText = "経費項目";
			this.dgv_cd.Name = "dgv_cd";
			this.dgv_cd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_cd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dgv_amount
			// 
			this.dgv_amount.HeaderText = "金額";
			this.dgv_amount.Name = "dgv_amount";
			// 
			// dgv_biko1
			// 
			this.dgv_biko1.HeaderText = "備考１";
			this.dgv_biko1.Name = "dgv_biko1";
			// 
			// dgv_biko2
			// 
			this.dgv_biko2.HeaderText = "備考２";
			this.dgv_biko2.Name = "dgv_biko2";
			this.dgv_biko2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_biko2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// dgv_tax
			// 
			this.dgv_tax.HeaderText = "課税";
			this.dgv_tax.Name = "dgv_tax";
			this.dgv_tax.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_tax.Width = 45;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.GreenYellow;
			this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label16.Location = new System.Drawing.Point(12, 72);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(67, 20);
			this.label16.TabIndex = 51;
			this.label16.Text = "技術者名";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCusNm
			// 
			this.lblCusNm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCusNm.Location = new System.Drawing.Point(85, 45);
			this.lblCusNm.Name = "lblCusNm";
			this.lblCusNm.Size = new System.Drawing.Size(528, 20);
			this.lblCusNm.TabIndex = 63;
			this.lblCusNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEngNm
			// 
			this.lblEngNm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblEngNm.Location = new System.Drawing.Point(85, 72);
			this.lblEngNm.Name = "lblEngNm";
			this.lblEngNm.Size = new System.Drawing.Size(204, 20);
			this.lblEngNm.TabIndex = 64;
			this.lblEngNm.Text = "88888888";
			this.lblEngNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_CLR
			// 
			this.btn_CLR.Location = new System.Drawing.Point(457, 68);
			this.btn_CLR.Name = "btn_CLR";
			this.btn_CLR.Size = new System.Drawing.Size(75, 36);
			this.btn_CLR.TabIndex = 13;
			this.btn_CLR.Text = "クリア";
			this.btn_CLR.UseVisualStyleBackColor = true;
			this.btn_CLR.Click += new System.EventHandler(this.btn_CLR_Click);
			// 
			// frmSal030
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(625, 474);
			this.Controls.Add(this.lblEngNm);
			this.Controls.Add(this.lblCusNm);
			this.Controls.Add(this.dgv_expense);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label01);
			this.Controls.Add(this.btn_DEL);
			this.Controls.Add(this.btn_End);
			this.Controls.Add(this.btn_CLR);
			this.Controls.Add(this.btn_OK);
			this.Name = "frmSal030";
			this.Text = "frmMNT100";
			this.Load += new System.EventHandler(this.frmSal030_Load);
			this.Controls.SetChildIndex(this.btn_OK, 0);
			this.Controls.SetChildIndex(this.btn_CLR, 0);
			this.Controls.SetChildIndex(this.btn_End, 0);
			this.Controls.SetChildIndex(this.btn_DEL, 0);
			this.Controls.SetChildIndex(this.label01, 0);
			this.Controls.SetChildIndex(this.label16, 0);
			this.Controls.SetChildIndex(this.dgv_expense, 0);
			this.Controls.SetChildIndex(this.lblCusNm, 0);
			this.Controls.SetChildIndex(this.lblEngNm, 0);
			((System.ComponentModel.ISupportInitialize)(this.dgv_expense)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.Button btn_DEL;
		private System.Windows.Forms.Label label01;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lblCusNm;
		private System.Windows.Forms.Label lblEngNm;
		private System.Windows.Forms.Button btn_CLR;
		private Sugitec.Common.ucDataGridViewEx dgv_expense;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_del;
		private Common.ucDataGridViewDateColumn dgv_ym;
		private System.Windows.Forms.DataGridViewComboBoxColumn dgv_cd;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_amount;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_biko1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_biko2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_tax;
	}
}