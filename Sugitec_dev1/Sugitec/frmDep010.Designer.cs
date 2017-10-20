namespace Sugitec
{
	partial class frmDep010
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
            Sugitec.Common.HeaderCell headerCell6 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell7 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell8 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell9 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell10 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell11 = new Sugitec.Common.HeaderCell();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoNoFin = new System.Windows.Forms.RadioButton();
            this.rdoFin = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_result = new Sugitec.Common.ucDataGridViewEx();
            this.dgv_reqNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_subNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_engNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_transfYm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_billAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_depAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_depRec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_diff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_diffCd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_dis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_cancel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReqYm = new Sugitec.Common.ucYMTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.GreenYellow;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(22, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 22);
            this.label18.TabIndex = 57;
            this.label18.Text = "請求年月";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.GreenYellow;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(22, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 22);
            this.label15.TabIndex = 56;
            this.label15.Text = "得意先";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Location = new System.Drawing.Point(30, 21);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(53, 17);
            this.rdoAll.TabIndex = 58;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "全て";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // rdoNoFin
            // 
            this.rdoNoFin.AutoSize = true;
            this.rdoNoFin.Location = new System.Drawing.Point(30, 43);
            this.rdoNoFin.Name = "rdoNoFin";
            this.rdoNoFin.Size = new System.Drawing.Size(67, 17);
            this.rdoNoFin.TabIndex = 59;
            this.rdoNoFin.Text = "未回収";
            this.rdoNoFin.UseVisualStyleBackColor = true;
            // 
            // rdoFin
            // 
            this.rdoFin.AutoSize = true;
            this.rdoFin.Location = new System.Drawing.Point(123, 43);
            this.rdoFin.Name = "rdoFin";
            this.rdoFin.Size = new System.Drawing.Size(67, 17);
            this.rdoFin.TabIndex = 60;
            this.rdoFin.Text = "回収済";
            this.rdoFin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1006, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 61;
            this.button1.Text = "検索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_result
            // 
            this.dgv_result.AllowUserToAddRows = false;
            this.dgv_result.AllowUserToDeleteRows = false;
            this.dgv_result.AllowUserToResizeRows = false;
            this.dgv_result.ColumnHeaderBorderStyle = Sugitec.Common.ucDataGridViewEx.HeaderCellBorderStyle.SingleLine;
            this.dgv_result.ColumnHeaderRowCount = 1;
            this.dgv_result.ColumnHeaderRowHeight = 17;
            this.dgv_result.ColumnHeadersHeight = 22;
            this.dgv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_reqNo,
            this.dgv_subNo,
            this.dgv_engNm,
            this.dgv_transfYm,
            this.dgv_billAm,
            this.dgv_depAm,
            this.dgv_depRec,
            this.dgv_diff,
            this.dgv_diffCd,
            this.dgv_dis,
            this.dgv_cancel});
            this.dgv_result.Cursor = System.Windows.Forms.Cursors.Default;
            headerCell1.BackgroundColor = System.Drawing.Color.Empty;
            headerCell1.Column = 0;
            headerCell1.ColumnSpan = 1;
            headerCell1.ForeColor = System.Drawing.Color.Empty;
            headerCell1.Row = 0;
            headerCell1.RowSpan = 1;
            headerCell1.SortVisible = false;
            headerCell1.Text = "請求書№";
            headerCell1.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell1.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell2.BackgroundColor = System.Drawing.Color.Empty;
            headerCell2.Column = 1;
            headerCell2.ColumnSpan = 1;
            headerCell2.ForeColor = System.Drawing.Color.Empty;
            headerCell2.Row = 0;
            headerCell2.RowSpan = 1;
            headerCell2.SortVisible = false;
            headerCell2.Text = "枝番";
            headerCell2.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell2.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell3.BackgroundColor = System.Drawing.Color.Empty;
            headerCell3.Column = 2;
            headerCell3.ColumnSpan = 1;
            headerCell3.ForeColor = System.Drawing.Color.Empty;
            headerCell3.Row = 0;
            headerCell3.RowSpan = 1;
            headerCell3.SortVisible = false;
            headerCell3.Text = "技術者名";
            headerCell3.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell3.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell4.BackgroundColor = System.Drawing.Color.Empty;
            headerCell4.Column = 3;
            headerCell4.ColumnSpan = 1;
            headerCell4.ForeColor = System.Drawing.Color.Empty;
            headerCell4.Row = 0;
            headerCell4.RowSpan = 1;
            headerCell4.SortVisible = false;
            headerCell4.Text = "振込指定日";
            headerCell4.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell4.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell5.BackgroundColor = System.Drawing.Color.Empty;
            headerCell5.Column = 4;
            headerCell5.ColumnSpan = 1;
            headerCell5.ForeColor = System.Drawing.Color.Empty;
            headerCell5.Row = 0;
            headerCell5.RowSpan = 1;
            headerCell5.SortVisible = false;
            headerCell5.Text = "請求金額";
            headerCell5.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell5.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell6.BackgroundColor = System.Drawing.Color.Empty;
            headerCell6.Column = 5;
            headerCell6.ColumnSpan = 1;
            headerCell6.ForeColor = System.Drawing.Color.Empty;
            headerCell6.Row = 0;
            headerCell6.RowSpan = 1;
            headerCell6.SortVisible = false;
            headerCell6.Text = "回収済金額";
            headerCell6.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell6.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell7.BackgroundColor = System.Drawing.Color.Empty;
            headerCell7.Column = 6;
            headerCell7.ColumnSpan = 1;
            headerCell7.ForeColor = System.Drawing.Color.Empty;
            headerCell7.Row = 0;
            headerCell7.RowSpan = 1;
            headerCell7.SortVisible = false;
            headerCell7.Text = "回収残高";
            headerCell7.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell7.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell8.BackgroundColor = System.Drawing.Color.Empty;
            headerCell8.Column = 7;
            headerCell8.ColumnSpan = 1;
            headerCell8.ForeColor = System.Drawing.Color.Empty;
            headerCell8.Row = 0;
            headerCell8.RowSpan = 1;
            headerCell8.SortVisible = false;
            headerCell8.Text = "差額";
            headerCell8.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell8.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell9.BackgroundColor = System.Drawing.Color.Empty;
            headerCell9.Column = 8;
            headerCell9.ColumnSpan = 1;
            headerCell9.ForeColor = System.Drawing.Color.Empty;
            headerCell9.Row = 0;
            headerCell9.RowSpan = 1;
            headerCell9.SortVisible = false;
            headerCell9.Text = "差額理由";
            headerCell9.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell9.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell10.BackgroundColor = System.Drawing.Color.Empty;
            headerCell10.Column = 9;
            headerCell10.ColumnSpan = 1;
            headerCell10.ForeColor = System.Drawing.Color.Empty;
            headerCell10.Row = 0;
            headerCell10.RowSpan = 1;
            headerCell10.SortVisible = false;
            headerCell10.Text = "値引";
            headerCell10.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell10.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell11.BackgroundColor = System.Drawing.Color.Empty;
            headerCell11.Column = 10;
            headerCell11.ColumnSpan = 1;
            headerCell11.ForeColor = System.Drawing.Color.Empty;
            headerCell11.Row = 0;
            headerCell11.RowSpan = 1;
            headerCell11.SortVisible = false;
            headerCell11.Text = "ｷｬﾝｾﾙ";
            headerCell11.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell11.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
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
            this.dgv_result.Location = new System.Drawing.Point(10, 147);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.RowHeadersVisible = false;
            this.dgv_result.RowTemplate.Height = 21;
            this.dgv_result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_result.Size = new System.Drawing.Size(1089, 356);
            this.dgv_result.TabIndex = 62;
            // 
            // dgv_reqNo
            // 
            this.dgv_reqNo.HeaderText = "請求No.";
            this.dgv_reqNo.Name = "dgv_reqNo";
            this.dgv_reqNo.ReadOnly = true;
            this.dgv_reqNo.Width = 75;
            // 
            // dgv_subNo
            // 
            this.dgv_subNo.HeaderText = "枝番";
            this.dgv_subNo.Name = "dgv_subNo";
            this.dgv_subNo.ReadOnly = true;
            this.dgv_subNo.Width = 50;
            // 
            // dgv_engNm
            // 
            this.dgv_engNm.HeaderText = "技術者名";
            this.dgv_engNm.Name = "dgv_engNm";
            this.dgv_engNm.ReadOnly = true;
            this.dgv_engNm.Width = 130;
            // 
            // dgv_transfYm
            // 
            this.dgv_transfYm.HeaderText = "振込指定日";
            this.dgv_transfYm.Name = "dgv_transfYm";
            this.dgv_transfYm.ReadOnly = true;
            // 
            // dgv_billAm
            // 
            this.dgv_billAm.HeaderText = "請求金額";
            this.dgv_billAm.Name = "dgv_billAm";
            this.dgv_billAm.ReadOnly = true;
            this.dgv_billAm.Width = 105;
            // 
            // dgv_depAm
            // 
            this.dgv_depAm.HeaderText = "回収金額";
            this.dgv_depAm.Name = "dgv_depAm";
            this.dgv_depAm.ReadOnly = true;
            this.dgv_depAm.Width = 105;
            // 
            // dgv_depRec
            // 
            this.dgv_depRec.HeaderText = "回収残高";
            this.dgv_depRec.Name = "dgv_depRec";
            this.dgv_depRec.ReadOnly = true;
            this.dgv_depRec.Width = 105;
            // 
            // dgv_diff
            // 
            this.dgv_diff.HeaderText = "差額";
            this.dgv_diff.Name = "dgv_diff";
            this.dgv_diff.ReadOnly = true;
            this.dgv_diff.Width = 105;
            // 
            // dgv_diffCd
            // 
            this.dgv_diffCd.HeaderText = "差額理由";
            this.dgv_diffCd.Name = "dgv_diffCd";
            this.dgv_diffCd.ReadOnly = true;
            // 
            // dgv_dis
            // 
            this.dgv_dis.HeaderText = "値引";
            this.dgv_dis.Name = "dgv_dis";
            this.dgv_dis.ReadOnly = true;
            this.dgv_dis.Width = 105;
            // 
            // dgv_cancel
            // 
            this.dgv_cancel.HeaderText = "キャンセル";
            this.dgv_cancel.Name = "dgv_cancel";
            this.dgv_cancel.ReadOnly = true;
            this.dgv_cancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgv_cancel.Width = 80;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(1006, 509);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(93, 43);
            this.btnEnd.TabIndex = 63;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(907, 509);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(93, 43);
            this.btnClr.TabIndex = 64;
            this.btnClr.Text = "クリア";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(808, 509);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(93, 43);
            this.btnCustom.TabIndex = 65;
            this.btnCustom.Text = "編集";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoAll);
            this.groupBox1.Controls.Add(this.rdoNoFin);
            this.groupBox1.Controls.Add(this.rdoFin);
            this.groupBox1.Location = new System.Drawing.Point(615, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 66);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "回収状況";
            // 
            // cmbCus
            // 
            this.cmbCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbCus.FormattingEnabled = true;
            this.cmbCus.Location = new System.Drawing.Point(106, 90);
            this.cmbCus.Name = "cmbCus";
            this.cmbCus.Size = new System.Drawing.Size(435, 21);
            this.cmbCus.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "回収対象一覧";
            // 
            // txtReqYm
            // 
            this.txtReqYm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtReqYm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtReqYm.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtReqYm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtReqYm.Location = new System.Drawing.Point(106, 52);
            this.txtReqYm.Name = "txtReqYm";
            this.txtReqYm.OldValue = null;
            this.txtReqYm.Size = new System.Drawing.Size(103, 20);
            this.txtReqYm.TabIndex = 69;
            this.txtReqYm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frmDep010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 582);
            this.Controls.Add(this.txtReqYm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.dgv_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Name = "frmDep010";
            this.Text = "frmDep010";
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.dgv_result, 0);
            this.Controls.SetChildIndex(this.btnEnd, 0);
            this.Controls.SetChildIndex(this.btnClr, 0);
            this.Controls.SetChildIndex(this.btnCustom, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cmbCus, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtReqYm, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.RadioButton rdoAll;
		private System.Windows.Forms.RadioButton rdoNoFin;
		private System.Windows.Forms.RadioButton rdoFin;
		private System.Windows.Forms.Button button1;
		private Common.ucDataGridViewEx dgv_result;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Button btnClr;
		private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCus;
        private System.Windows.Forms.Label label1;
        public Common.ucYMTextbox txtReqYm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_reqNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_subNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_engNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_transfYm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_billAm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_depAm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_depRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_diff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_diffCd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_dis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_cancel;
    }
}