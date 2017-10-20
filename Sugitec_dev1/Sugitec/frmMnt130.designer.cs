namespace Sugitec
{
	partial class frmMnt130
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_ConName = new Sugitec.Common.ucTextBoxEx();
            this.txt_ConCod = new Sugitec.Common.ucNumTextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_CLR = new System.Windows.Forms.Button();
            this.btn_End = new System.Windows.Forms.Button();
            this.btn_DEL = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txt_Section = new Sugitec.Common.ucTextBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_contact = new Sugitec.Common.ucDataGridViewEx();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_CusCd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_tokCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_Cus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contact)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ConName
            // 
            this.txt_ConName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_ConName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_ConName.Location = new System.Drawing.Point(123, 104);
            this.txt_ConName.MaxLength = 100;
            this.txt_ConName.Name = "txt_ConName";
            this.txt_ConName.Size = new System.Drawing.Size(425, 20);
            this.txt_ConName.TabIndex = 3;
            this.txt_ConName.Text = "８８８８８８８８８８８８８８８８８８８８８８８８８８８８８８";
            this.txt_ConName.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.None;
            this.txt_ConName.xFormat = null;
            this.txt_ConName.xIllegalCharacter = null;
            this.txt_ConName.xMaxLengthByByte = true;
            this.txt_ConName.xOldText = null;
            this.txt_ConName.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // txt_ConCod
            // 
            this.txt_ConCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_ConCod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_ConCod.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericCode;
            this.txt_ConCod.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_ConCod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ConCod.Format = null;
            this.txt_ConCod.IllegalCharacter = null;
            this.txt_ConCod.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_ConCod.Location = new System.Drawing.Point(123, 78);
            this.txt_ConCod.MaxLength = 4;
            this.txt_ConCod.Name = "txt_ConCod";
            this.txt_ConCod.OldText = null;
            this.txt_ConCod.Size = new System.Drawing.Size(58, 20);
            this.txt_ConCod.TabIndex = 2;
            this.txt_ConCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ConCod.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.Left;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(230, 156);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 36);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Text = "確定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_CLR
            // 
            this.btn_CLR.Location = new System.Drawing.Point(392, 156);
            this.btn_CLR.Name = "btn_CLR";
            this.btn_CLR.Size = new System.Drawing.Size(75, 36);
            this.btn_CLR.TabIndex = 7;
            this.btn_CLR.Text = "クリア";
            this.btn_CLR.UseVisualStyleBackColor = true;
            this.btn_CLR.Click += new System.EventHandler(this.btn_CLR_Click);
            // 
            // btn_End
            // 
            this.btn_End.Location = new System.Drawing.Point(473, 156);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(75, 36);
            this.btn_End.TabIndex = 8;
            this.btn_End.Text = "終了";
            this.btn_End.UseVisualStyleBackColor = true;
            this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
            // 
            // btn_DEL
            // 
            this.btn_DEL.Location = new System.Drawing.Point(311, 156);
            this.btn_DEL.Name = "btn_DEL";
            this.btn_DEL.Size = new System.Drawing.Size(75, 36);
            this.btn_DEL.TabIndex = 6;
            this.btn_DEL.Text = "削除";
            this.btn_DEL.UseVisualStyleBackColor = true;
            this.btn_DEL.Click += new System.EventHandler(this.btn_DEL_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txt_Section
            // 
            this.txt_Section.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_Section.Location = new System.Drawing.Point(123, 130);
            this.txt_Section.MaxLength = 100;
            this.txt_Section.Name = "txt_Section";
            this.txt_Section.Size = new System.Drawing.Size(425, 20);
            this.txt_Section.TabIndex = 4;
            this.txt_Section.Text = "８８８８８８８８８８８８８８８８８８８８８８８８８８８８８８";
            this.txt_Section.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.None;
            this.txt_Section.xFormat = null;
            this.txt_Section.xIllegalCharacter = null;
            this.txt_Section.xMaxLengthByByte = true;
            this.txt_Section.xOldText = null;
            this.txt_Section.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.GreenYellow;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "得意先名";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.GreenYellow;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "担当者コード";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.GreenYellow;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(12, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "氏名";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.GreenYellow;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(12, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "部署";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_contact
            // 
            this.dgv_contact.AllowUserToAddRows = false;
            this.dgv_contact.AllowUserToDeleteRows = false;
            this.dgv_contact.AllowUserToResizeRows = false;
            this.dgv_contact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_contact.ColumnHeaderBorderStyle = Sugitec.Common.ucDataGridViewEx.HeaderCellBorderStyle.SingleLine;
            this.dgv_contact.ColumnHeaderRowCount = 1;
            this.dgv_contact.ColumnHeaderRowHeight = 20;
            this.dgv_contact.ColumnHeadersHeight = 22;
            this.dgv_contact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dgv_CusCd,
            this.dgv_tokCod,
            this.dgv_sec,
            this.dataGridViewTextBoxColumn1});
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
            headerCell2.Column = 2;
            headerCell2.ColumnSpan = 1;
            headerCell2.ForeColor = System.Drawing.Color.Empty;
            headerCell2.Row = 0;
            headerCell2.RowSpan = 1;
            headerCell2.SortVisible = false;
            headerCell2.Text = "コード";
            headerCell2.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell2.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell3.BackgroundColor = System.Drawing.Color.Empty;
            headerCell3.Column = 3;
            headerCell3.ColumnSpan = 1;
            headerCell3.ForeColor = System.Drawing.Color.Empty;
            headerCell3.Row = 0;
            headerCell3.RowSpan = 1;
            headerCell3.SortVisible = false;
            headerCell3.Text = "部署";
            headerCell3.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell3.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell4.BackgroundColor = System.Drawing.Color.Empty;
            headerCell4.Column = 4;
            headerCell4.ColumnSpan = 1;
            headerCell4.ForeColor = System.Drawing.Color.Empty;
            headerCell4.Row = 0;
            headerCell4.RowSpan = 1;
            headerCell4.SortVisible = false;
            headerCell4.Text = "氏名";
            headerCell4.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell4.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.dgv_contact.HeaderCells.Add(headerCell1);
            this.dgv_contact.HeaderCells.Add(headerCell2);
            this.dgv_contact.HeaderCells.Add(headerCell3);
            this.dgv_contact.HeaderCells.Add(headerCell4);
            this.dgv_contact.Location = new System.Drawing.Point(12, 198);
            this.dgv_contact.Name = "dgv_contact";
            this.dgv_contact.RowHeadersVisible = false;
            this.dgv_contact.RowTemplate.Height = 21;
            this.dgv_contact.Size = new System.Drawing.Size(546, 287);
            this.dgv_contact.TabIndex = 9;
            this.dgv_contact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_contact_CellClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "削除";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn1.Width = 60;
            // 
            // dgv_CusCd
            // 
            this.dgv_CusCd.HeaderText = "得意先コード";
            this.dgv_CusCd.Name = "dgv_CusCd";
            this.dgv_CusCd.Visible = false;
            // 
            // dgv_tokCod
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_tokCod.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tokCod.HeaderText = "コード";
            this.dgv_tokCod.Name = "dgv_tokCod";
            this.dgv_tokCod.ReadOnly = true;
            this.dgv_tokCod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tokCod.Width = 60;
            // 
            // dgv_sec
            // 
            this.dgv_sec.HeaderText = "部署";
            this.dgv_sec.Name = "dgv_sec";
            this.dgv_sec.Width = 280;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // cmb_Cus
            // 
            this.cmb_Cus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmb_Cus.FormattingEnabled = true;
            this.cmb_Cus.Location = new System.Drawing.Point(123, 47);
            this.cmb_Cus.Name = "cmb_Cus";
            this.cmb_Cus.Size = new System.Drawing.Size(425, 21);
            this.cmb_Cus.TabIndex = 1;
            this.cmb_Cus.SelectedIndexChanged += new System.EventHandler(this.cmb_Cus_SelectedIndexChanged);
            // 
            // frmMnt130
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 519);
            this.Controls.Add(this.cmb_Cus);
            this.Controls.Add(this.dgv_contact);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Section);
            this.Controls.Add(this.btn_DEL);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.btn_CLR);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_ConName);
            this.Controls.Add(this.txt_ConCod);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMnt130";
            this.Text = "frmMNT100";
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.txt_ConCod, 0);
            this.Controls.SetChildIndex(this.txt_ConName, 0);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.btn_CLR, 0);
            this.Controls.SetChildIndex(this.btn_End, 0);
            this.Controls.SetChildIndex(this.btn_DEL, 0);
            this.Controls.SetChildIndex(this.txt_Section, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.dgv_contact, 0);
            this.Controls.SetChildIndex(this.cmb_Cus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private Sugitec.Common.ucNumTextBox txt_ConCod;
		private System.Windows.Forms.Button btn_OK;
		private System.Windows.Forms.Button btn_CLR;
		private System.Windows.Forms.Button btn_End;
		private System.Windows.Forms.Button btn_DEL;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private Common.ucTextBoxEx txt_ConName;
		private Common.ucTextBoxEx txt_Section;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private Common.ucDataGridViewEx dgv_contact;
		private System.Windows.Forms.ComboBox cmb_Cus;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_CusCd;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tokCod;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_sec;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
	}
}