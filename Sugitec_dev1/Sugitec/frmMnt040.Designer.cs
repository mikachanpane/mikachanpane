namespace Sugitec
{
    partial class frmMnt040
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_KbnList = new Sugitec.Common.ucDataGridViewEx();
            this.dgv_DEL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_StartYmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_TaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Valid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.dtpStartYmd = new Sugitec.Common.ctlDateTimePickerEx();
            this.label3 = new System.Windows.Forms.Label();
            this.nudTaxRate = new Sugitec.Common.ucNumUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_DEL = new System.Windows.Forms.Button();
            this.btn_End = new System.Windows.Forms.Button();
            this.btn_CLR = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.chkValid = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KbnList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_KbnList
            // 
            this.dgv_KbnList.AllowUserToAddRows = false;
            this.dgv_KbnList.AllowUserToDeleteRows = false;
            this.dgv_KbnList.AllowUserToResizeRows = false;
            this.dgv_KbnList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_KbnList.ColumnHeaderBorderStyle = Sugitec.Common.ucDataGridViewEx.HeaderCellBorderStyle.SingleLine;
            this.dgv_KbnList.ColumnHeaderRowCount = 1;
            this.dgv_KbnList.ColumnHeaderRowHeight = 20;
            this.dgv_KbnList.ColumnHeadersHeight = 22;
            this.dgv_KbnList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_DEL,
            this.dgv_Code,
            this.dgv_StartYmd,
            this.dgv_TaxRate,
            this.dgv_Valid});
            headerCell1.BackgroundColor = System.Drawing.Color.Empty;
            headerCell1.Column = 0;
            headerCell1.ColumnSpan = 1;
            headerCell1.ForeColor = System.Drawing.Color.Empty;
            headerCell1.Row = 0;
            headerCell1.RowSpan = 1;
            headerCell1.SortVisible = false;
            headerCell1.Text = "削除";
            headerCell1.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell1.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell2.BackgroundColor = System.Drawing.Color.Empty;
            headerCell2.Column = 1;
            headerCell2.ColumnSpan = 1;
            headerCell2.ForeColor = System.Drawing.Color.Empty;
            headerCell2.Row = 0;
            headerCell2.RowSpan = 1;
            headerCell2.SortVisible = false;
            headerCell2.Text = "コード";
            headerCell2.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell2.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell3.BackgroundColor = System.Drawing.Color.Empty;
            headerCell3.Column = 2;
            headerCell3.ColumnSpan = 1;
            headerCell3.ForeColor = System.Drawing.Color.Empty;
            headerCell3.Row = 0;
            headerCell3.RowSpan = 1;
            headerCell3.SortVisible = false;
            headerCell3.Text = "開始日";
            headerCell3.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell3.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell4.BackgroundColor = System.Drawing.Color.Empty;
            headerCell4.Column = 3;
            headerCell4.ColumnSpan = 1;
            headerCell4.ForeColor = System.Drawing.Color.Empty;
            headerCell4.Row = 0;
            headerCell4.RowSpan = 1;
            headerCell4.SortVisible = false;
            headerCell4.Text = "税率";
            headerCell4.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell4.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell5.BackgroundColor = System.Drawing.Color.Empty;
            headerCell5.Column = 4;
            headerCell5.ColumnSpan = 1;
            headerCell5.ForeColor = System.Drawing.Color.Empty;
            headerCell5.Row = 0;
            headerCell5.RowSpan = 1;
            headerCell5.SortVisible = false;
            headerCell5.Text = "有効";
            headerCell5.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell5.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.dgv_KbnList.HeaderCells.Add(headerCell1);
            this.dgv_KbnList.HeaderCells.Add(headerCell2);
            this.dgv_KbnList.HeaderCells.Add(headerCell3);
            this.dgv_KbnList.HeaderCells.Add(headerCell4);
            this.dgv_KbnList.HeaderCells.Add(headerCell5);
            this.dgv_KbnList.Location = new System.Drawing.Point(13, 167);
            this.dgv_KbnList.Name = "dgv_KbnList";
            this.dgv_KbnList.RowHeadersVisible = false;
            this.dgv_KbnList.RowTemplate.Height = 21;
            this.dgv_KbnList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_KbnList.Size = new System.Drawing.Size(478, 200);
            this.dgv_KbnList.TabIndex = 4;
            this.dgv_KbnList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KbnList_CellClick);
            // 
            // dgv_DEL
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DEL.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DEL.FalseValue = "0";
            this.dgv_DEL.HeaderText = "削除";
            this.dgv_DEL.Name = "dgv_DEL";
            this.dgv_DEL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DEL.TrueValue = "1";
            this.dgv_DEL.Width = 40;
            // 
            // dgv_Code
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Code.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Code.HeaderText = "コード";
            this.dgv_Code.Name = "dgv_Code";
            this.dgv_Code.ReadOnly = true;
            this.dgv_Code.Width = 80;
            // 
            // dgv_StartYmd
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_StartYmd.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_StartYmd.HeaderText = "開始日";
            this.dgv_StartYmd.Name = "dgv_StartYmd";
            this.dgv_StartYmd.ReadOnly = true;
            this.dgv_StartYmd.Width = 120;
            // 
            // dgv_TaxRate
            // 
            this.dgv_TaxRate.HeaderText = "税率";
            this.dgv_TaxRate.Name = "dgv_TaxRate";
            this.dgv_TaxRate.ReadOnly = true;
            this.dgv_TaxRate.Width = 80;
            // 
            // dgv_Valid
            // 
            this.dgv_Valid.HeaderText = "有効";
            this.dgv_Valid.Name = "dgv_Valid";
            this.dgv_Valid.ReadOnly = true;
            this.dgv_Valid.Width = 80;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "コード";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCode
            // 
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode.Location = new System.Drawing.Point(110, 51);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(37, 20);
            this.lblCode.TabIndex = 28;
            this.lblCode.Text = "88";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpStartYmd
            // 
            this.dtpStartYmd.Location = new System.Drawing.Point(110, 79);
            this.dtpStartYmd.Name = "dtpStartYmd";
            this.dtpStartYmd.Size = new System.Drawing.Size(145, 20);
            this.dtpStartYmd.TabIndex = 29;
            this.dtpStartYmd.Value = null;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.GreenYellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "開始日付";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTaxRate
            // 
            this.nudTaxRate.BackColor = System.Drawing.SystemColors.Window;
            this.nudTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nudTaxRate.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudTaxRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudTaxRate.Location = new System.Drawing.Point(367, 79);
            this.nudTaxRate.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTaxRate.Name = "nudTaxRate";
            this.nudTaxRate.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTaxRate.Size = new System.Drawing.Size(120, 20);
            this.nudTaxRate.TabIndex = 31;
            this.nudTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.GreenYellow;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(280, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "税率";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.GreenYellow;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(16, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "有効";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_DEL
            // 
            this.btn_DEL.Location = new System.Drawing.Point(254, 125);
            this.btn_DEL.Name = "btn_DEL";
            this.btn_DEL.Size = new System.Drawing.Size(75, 36);
            this.btn_DEL.TabIndex = 35;
            this.btn_DEL.Text = "削除";
            this.btn_DEL.UseVisualStyleBackColor = true;
            this.btn_DEL.Click += new System.EventHandler(this.btn_DEL_Click);
            // 
            // btn_End
            // 
            this.btn_End.Location = new System.Drawing.Point(416, 125);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(75, 36);
            this.btn_End.TabIndex = 37;
            this.btn_End.Text = "終了";
            this.btn_End.UseVisualStyleBackColor = true;
            this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
            // 
            // btn_CLR
            // 
            this.btn_CLR.Location = new System.Drawing.Point(335, 125);
            this.btn_CLR.Name = "btn_CLR";
            this.btn_CLR.Size = new System.Drawing.Size(75, 36);
            this.btn_CLR.TabIndex = 36;
            this.btn_CLR.Text = "クリア";
            this.btn_CLR.UseVisualStyleBackColor = true;
            this.btn_CLR.Click += new System.EventHandler(this.btn_CLR_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(173, 125);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 36);
            this.btn_OK.TabIndex = 34;
            this.btn_OK.Text = "確定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // chkValid
            // 
            this.chkValid.AutoSize = true;
            this.chkValid.Location = new System.Drawing.Point(110, 110);
            this.chkValid.Name = "chkValid";
            this.chkValid.Size = new System.Drawing.Size(15, 14);
            this.chkValid.TabIndex = 38;
            this.chkValid.UseVisualStyleBackColor = true;
            // 
            // frmMnt040
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 403);
            this.Controls.Add(this.chkValid);
            this.Controls.Add(this.btn_DEL);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.btn_CLR);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudTaxRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpStartYmd);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.dgv_KbnList);
            this.Controls.Add(this.label1);
            this.Name = "frmMnt040";
            this.Text = "frmMnt040";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgv_KbnList, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.Controls.SetChildIndex(this.dtpStartYmd, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.nudTaxRate, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.btn_CLR, 0);
            this.Controls.SetChildIndex(this.btn_End, 0);
            this.Controls.SetChildIndex(this.btn_DEL, 0);
            this.Controls.SetChildIndex(this.chkValid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KbnList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Common.ucDataGridViewEx dgv_KbnList;
        private Common.ctlDateTimePickerEx dtpStartYmd;
        private System.Windows.Forms.Label label3;
        private Common.ucNumUpDown nudTaxRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_DEL;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.Button btn_CLR;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.CheckBox chkValid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_DEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_StartYmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_TaxRate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_Valid;
        private System.Windows.Forms.Label lblCode;
    }
}