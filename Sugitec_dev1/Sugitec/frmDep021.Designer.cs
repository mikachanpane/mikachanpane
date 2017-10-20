namespace Sugitec
{
    partial class frmDep021
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
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvList = new Sugitec.Common.ucDataGridViewEx();
            this.dgv_RecNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_RecYmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.txtCash = new Sugitec.Common.ucNumUpDown();
            this.txtDeposit = new Sugitec.Common.ucNumUpDown();
            this.txtFees = new Sugitec.Common.ucNumUpDown();
            this.txtBill = new Sugitec.Common.ucNumUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecYm = new Sugitec.Common.ucYMTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDepRcvAmt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.GreenYellow;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(9, 250);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "現金";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.GreenYellow;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(9, 312);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "預金";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.GreenYellow;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(9, 281);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "振込手数料";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.GreenYellow;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(9, 343);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 24);
            this.label14.TabIndex = 21;
            this.label14.Text = "手形";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.ColumnHeaderBorderStyle = Sugitec.Common.ucDataGridViewEx.HeaderCellBorderStyle.SingleLine;
            this.dgvList.ColumnHeaderRowCount = 2;
            this.dgvList.ColumnHeaderRowHeight = 20;
            this.dgvList.ColumnHeadersHeight = 42;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_RecNo,
            this.dgv_RecYmd,
            this.dgv_Cash,
            this.dgv_Fees,
            this.dgv_Deposit,
            this.dgv_Bill});
            headerCell1.BackgroundColor = System.Drawing.Color.Empty;
            headerCell1.Column = 0;
            headerCell1.ColumnSpan = 1;
            headerCell1.ForeColor = System.Drawing.Color.Empty;
            headerCell1.Row = 0;
            headerCell1.RowSpan = 2;
            headerCell1.SortVisible = false;
            headerCell1.Text = "入金№";
            headerCell1.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell1.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell2.BackgroundColor = System.Drawing.Color.Empty;
            headerCell2.Column = 1;
            headerCell2.ColumnSpan = 1;
            headerCell2.ForeColor = System.Drawing.Color.Empty;
            headerCell2.Row = 0;
            headerCell2.RowSpan = 2;
            headerCell2.SortVisible = false;
            headerCell2.Text = "入金日";
            headerCell2.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell2.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell3.BackgroundColor = System.Drawing.Color.Empty;
            headerCell3.Column = 2;
            headerCell3.ColumnSpan = 4;
            headerCell3.ForeColor = System.Drawing.Color.Empty;
            headerCell3.Row = 0;
            headerCell3.RowSpan = 1;
            headerCell3.SortVisible = false;
            headerCell3.Text = "回収可能金額";
            headerCell3.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell3.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell4.BackgroundColor = System.Drawing.Color.Empty;
            headerCell4.Column = 2;
            headerCell4.ColumnSpan = 1;
            headerCell4.ForeColor = System.Drawing.Color.Empty;
            headerCell4.Row = 1;
            headerCell4.RowSpan = 1;
            headerCell4.SortVisible = false;
            headerCell4.Text = "現金";
            headerCell4.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell4.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell5.BackgroundColor = System.Drawing.Color.Empty;
            headerCell5.Column = 3;
            headerCell5.ColumnSpan = 1;
            headerCell5.ForeColor = System.Drawing.Color.Empty;
            headerCell5.Row = 1;
            headerCell5.RowSpan = 1;
            headerCell5.SortVisible = false;
            headerCell5.Text = "振込手数料";
            headerCell5.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell5.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell6.BackgroundColor = System.Drawing.Color.Empty;
            headerCell6.Column = 4;
            headerCell6.ColumnSpan = 1;
            headerCell6.ForeColor = System.Drawing.Color.Empty;
            headerCell6.Row = 1;
            headerCell6.RowSpan = 1;
            headerCell6.SortVisible = false;
            headerCell6.Text = "預金";
            headerCell6.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell6.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell7.BackgroundColor = System.Drawing.Color.Empty;
            headerCell7.Column = 5;
            headerCell7.ColumnSpan = 1;
            headerCell7.ForeColor = System.Drawing.Color.Empty;
            headerCell7.Row = 1;
            headerCell7.RowSpan = 1;
            headerCell7.SortVisible = false;
            headerCell7.Text = "手形";
            headerCell7.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell7.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.dgvList.HeaderCells.Add(headerCell1);
            this.dgvList.HeaderCells.Add(headerCell2);
            this.dgvList.HeaderCells.Add(headerCell3);
            this.dgvList.HeaderCells.Add(headerCell4);
            this.dgvList.HeaderCells.Add(headerCell5);
            this.dgvList.HeaderCells.Add(headerCell6);
            this.dgvList.HeaderCells.Add(headerCell7);
            this.dgvList.Location = new System.Drawing.Point(9, 88);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 21;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(607, 121);
            this.dgvList.TabIndex = 17;
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
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(421, 333);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 34);
            this.btnOk.TabIndex = 26;
            this.btnOk.Text = "確定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(521, 333);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(94, 34);
            this.btnEnd.TabIndex = 28;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.SystemColors.Window;
            this.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCash.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtCash.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCash.Location = new System.Drawing.Point(135, 253);
            this.txtCash.Name = "txtCash";
            this.txtCash.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCash.Size = new System.Drawing.Size(150, 21);
            this.txtCash.TabIndex = 29;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCash.ThousandsSeparator = true;
            this.txtCash.ValueValidated += new System.EventHandler<System.EventArgs>(this.txt_ValueValidated);
            // 
            // txtDeposit
            // 
            this.txtDeposit.BackColor = System.Drawing.SystemColors.Window;
            this.txtDeposit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDeposit.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDeposit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDeposit.Location = new System.Drawing.Point(135, 315);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDeposit.Size = new System.Drawing.Size(150, 21);
            this.txtDeposit.TabIndex = 30;
            this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDeposit.ThousandsSeparator = true;
            this.txtDeposit.ValueValidated += new System.EventHandler<System.EventArgs>(this.txt_ValueValidated);
            // 
            // txtFees
            // 
            this.txtFees.BackColor = System.Drawing.SystemColors.Window;
            this.txtFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtFees.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFees.Location = new System.Drawing.Point(135, 284);
            this.txtFees.Name = "txtFees";
            this.txtFees.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtFees.Size = new System.Drawing.Size(150, 21);
            this.txtFees.TabIndex = 31;
            this.txtFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFees.ThousandsSeparator = true;
            this.txtFees.ValueValidated += new System.EventHandler<System.EventArgs>(this.txt_ValueValidated);
            // 
            // txtBill
            // 
            this.txtBill.BackColor = System.Drawing.SystemColors.Window;
            this.txtBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtBill.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBill.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBill.Location = new System.Drawing.Point(135, 346);
            this.txtBill.Name = "txtBill";
            this.txtBill.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtBill.Size = new System.Drawing.Size(150, 21);
            this.txtBill.TabIndex = 32;
            this.txtBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBill.ThousandsSeparator = true;
            this.txtBill.ValueValidated += new System.EventHandler<System.EventArgs>(this.txt_ValueValidated);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "入金日";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecYm
            // 
            this.txtRecYm.BackColor = System.Drawing.SystemColors.Window;
            this.txtRecYm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtRecYm.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtRecYm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRecYm.Location = new System.Drawing.Point(135, 56);
            this.txtRecYm.Name = "txtRecYm";
            this.txtRecYm.OldValue = null;
            this.txtRecYm.Size = new System.Drawing.Size(100, 21);
            this.txtRecYm.TabIndex = 34;
            this.txtRecYm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(238, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "以降";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(279, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 34);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.GreenYellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(9, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "回収残高";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepRcvAmt
            // 
            this.lblDepRcvAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepRcvAmt.Location = new System.Drawing.Point(135, 218);
            this.lblDepRcvAmt.Margin = new System.Windows.Forms.Padding(0);
            this.lblDepRcvAmt.Name = "lblDepRcvAmt";
            this.lblDepRcvAmt.Size = new System.Drawing.Size(130, 24);
            this.lblDepRcvAmt.TabIndex = 38;
            this.lblDepRcvAmt.Text = "999,999,999";
            this.lblDepRcvAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmDep021
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 401);
            this.Controls.Add(this.lblDepRcvAmt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRecYm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Name = "frmDep021";
            this.Text = "frmDep021";
            this.Load += new System.EventHandler(this.frmDep020_Load);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.dgvList, 0);
            this.Controls.SetChildIndex(this.btnEnd, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.txtCash, 0);
            this.Controls.SetChildIndex(this.txtDeposit, 0);
            this.Controls.SetChildIndex(this.txtFees, 0);
            this.Controls.SetChildIndex(this.txtBill, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtRecYm, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblDepRcvAmt, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private Common.ucDataGridViewEx dgvList;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_RecNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_RecYmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Bill;
        private Common.ucNumUpDown txtCash;
        private Common.ucNumUpDown txtDeposit;
        private Common.ucNumUpDown txtFees;
        private Common.ucNumUpDown txtBill;
        private System.Windows.Forms.Label label1;
        private Common.ucYMTextbox txtRecYm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDepRcvAmt;
    }
}