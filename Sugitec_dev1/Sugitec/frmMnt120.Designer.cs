namespace Sugitec
{
    partial class frmMnt120
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_GroupList = new Sugitec.Common.ucDataGridViewEx();
            this.dgv_CDEL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_KotsuhiKBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_KotsuhiKbnNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdv_perDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdv_Accommodation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_DEL = new System.Windows.Forms.Button();
            this.btn_End = new System.Windows.Forms.Button();
            this.btn_CLR = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cod = new Sugitec.Common.ucNumTextBox();
            this.txt_Name = new Sugitec.Common.ucTextBoxEx();
            this.cmb_TrvKbn = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudperdiem = new Sugitec.Common.ucNumUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudaccommodation = new Sugitec.Common.ucNumUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GroupList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_GroupList
            // 
            this.dgv_GroupList.AllowUserToAddRows = false;
            this.dgv_GroupList.AllowUserToDeleteRows = false;
            this.dgv_GroupList.AllowUserToResizeRows = false;
            this.dgv_GroupList.ColumnHeaderBorderStyle = Sugitec.Common.ucDataGridViewEx.HeaderCellBorderStyle.SingleLine;
            this.dgv_GroupList.ColumnHeaderRowCount = 1;
            this.dgv_GroupList.ColumnHeaderRowHeight = 20;
            this.dgv_GroupList.ColumnHeadersHeight = 22;
            this.dgv_GroupList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_CDEL,
            this.dgv_CODE,
            this.dgv_Nm,
            this.dgv_KotsuhiKBN,
            this.dgv_KotsuhiKbnNm,
            this.gdv_perDiem,
            this.gdv_Accommodation});
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
            headerCell3.Text = "名称";
            headerCell3.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell3.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell4.BackgroundColor = System.Drawing.Color.Empty;
            headerCell4.Column = 3;
            headerCell4.ColumnSpan = 1;
            headerCell4.ForeColor = System.Drawing.Color.Empty;
            headerCell4.Row = 0;
            headerCell4.RowSpan = 1;
            headerCell4.SortVisible = false;
            headerCell4.Text = "交通費区分";
            headerCell4.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell4.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell5.BackgroundColor = System.Drawing.Color.Empty;
            headerCell5.Column = 4;
            headerCell5.ColumnSpan = 1;
            headerCell5.ForeColor = System.Drawing.Color.Empty;
            headerCell5.Row = 0;
            headerCell5.RowSpan = 1;
            headerCell5.SortVisible = false;
            headerCell5.Text = "交通費区分";
            headerCell5.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell5.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell6.BackgroundColor = System.Drawing.Color.Empty;
            headerCell6.Column = 5;
            headerCell6.ColumnSpan = 1;
            headerCell6.ForeColor = System.Drawing.Color.Empty;
            headerCell6.Row = 0;
            headerCell6.RowSpan = 1;
            headerCell6.SortVisible = false;
            headerCell6.Text = "日当";
            headerCell6.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell6.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell7.BackgroundColor = System.Drawing.Color.Empty;
            headerCell7.Column = 6;
            headerCell7.ColumnSpan = 1;
            headerCell7.ForeColor = System.Drawing.Color.Empty;
            headerCell7.Row = 0;
            headerCell7.RowSpan = 1;
            headerCell7.SortVisible = false;
            headerCell7.Text = "宿泊費";
            headerCell7.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell7.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.dgv_GroupList.HeaderCells.Add(headerCell1);
            this.dgv_GroupList.HeaderCells.Add(headerCell2);
            this.dgv_GroupList.HeaderCells.Add(headerCell3);
            this.dgv_GroupList.HeaderCells.Add(headerCell4);
            this.dgv_GroupList.HeaderCells.Add(headerCell5);
            this.dgv_GroupList.HeaderCells.Add(headerCell6);
            this.dgv_GroupList.HeaderCells.Add(headerCell7);
            this.dgv_GroupList.Location = new System.Drawing.Point(12, 228);
            this.dgv_GroupList.Name = "dgv_GroupList";
            this.dgv_GroupList.RowHeadersVisible = false;
            this.dgv_GroupList.RowTemplate.Height = 21;
            this.dgv_GroupList.Size = new System.Drawing.Size(538, 300);
            this.dgv_GroupList.TabIndex = 0;
            this.dgv_GroupList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GroupList_CellClick);
            // 
            // dgv_CDEL
            // 
            this.dgv_CDEL.FalseValue = "0";
            this.dgv_CDEL.HeaderText = "削除";
            this.dgv_CDEL.Name = "dgv_CDEL";
            this.dgv_CDEL.TrueValue = "1";
            this.dgv_CDEL.Width = 40;
            // 
            // dgv_CODE
            // 
            this.dgv_CODE.HeaderText = "コード";
            this.dgv_CODE.Name = "dgv_CODE";
            this.dgv_CODE.ReadOnly = true;
            this.dgv_CODE.Width = 60;
            // 
            // dgv_Nm
            // 
            this.dgv_Nm.HeaderText = "名称";
            this.dgv_Nm.Name = "dgv_Nm";
            this.dgv_Nm.Width = 120;
            // 
            // dgv_KotsuhiKBN
            // 
            this.dgv_KotsuhiKBN.HeaderText = "交通費区分";
            this.dgv_KotsuhiKBN.Name = "dgv_KotsuhiKBN";
            this.dgv_KotsuhiKBN.Visible = false;
            // 
            // dgv_KotsuhiKbnNm
            // 
            this.dgv_KotsuhiKbnNm.HeaderText = "交通費区分名";
            this.dgv_KotsuhiKbnNm.Name = "dgv_KotsuhiKbnNm";
            // 
            // gdv_perDiem
            // 
            dataGridViewCellStyle1.Format = "C";
            dataGridViewCellStyle1.NullValue = null;
            this.gdv_perDiem.DefaultCellStyle = dataGridViewCellStyle1;
            this.gdv_perDiem.HeaderText = "日当";
            this.gdv_perDiem.Name = "gdv_perDiem";
            // 
            // gdv_Accommodation
            // 
            dataGridViewCellStyle2.Format = "C";
            dataGridViewCellStyle2.NullValue = null;
            this.gdv_Accommodation.DefaultCellStyle = dataGridViewCellStyle2;
            this.gdv_Accommodation.HeaderText = "宿泊費";
            this.gdv_Accommodation.Name = "gdv_Accommodation";
            // 
            // btn_DEL
            // 
            this.btn_DEL.Location = new System.Drawing.Point(310, 184);
            this.btn_DEL.Name = "btn_DEL";
            this.btn_DEL.Size = new System.Drawing.Size(75, 36);
            this.btn_DEL.TabIndex = 39;
            this.btn_DEL.Text = "削除";
            this.btn_DEL.UseVisualStyleBackColor = true;
            this.btn_DEL.Click += new System.EventHandler(this.btn_DEL_Click);
            // 
            // btn_End
            // 
            this.btn_End.Location = new System.Drawing.Point(472, 184);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(75, 36);
            this.btn_End.TabIndex = 41;
            this.btn_End.Text = "終了";
            this.btn_End.UseVisualStyleBackColor = true;
            this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
            // 
            // btn_CLR
            // 
            this.btn_CLR.Location = new System.Drawing.Point(391, 184);
            this.btn_CLR.Name = "btn_CLR";
            this.btn_CLR.Size = new System.Drawing.Size(75, 36);
            this.btn_CLR.TabIndex = 40;
            this.btn_CLR.Text = "クリア";
            this.btn_CLR.UseVisualStyleBackColor = true;
            this.btn_CLR.Click += new System.EventHandler(this.btn_CLR_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(229, 184);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 36);
            this.btn_OK.TabIndex = 38;
            this.btn_OK.Text = "確定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "コード";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "名称";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Cod
            // 
            this.txt_Cod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_Cod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_Cod.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericCode;
            this.txt_Cod.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Cod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Cod.Format = null;
            this.txt_Cod.IllegalCharacter = null;
            this.txt_Cod.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_Cod.Location = new System.Drawing.Point(102, 50);
            this.txt_Cod.MaxLength = 3;
            this.txt_Cod.Name = "txt_Cod";
            this.txt_Cod.OldText = null;
            this.txt_Cod.Size = new System.Drawing.Size(52, 20);
            this.txt_Cod.TabIndex = 44;
            this.txt_Cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Cod.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.Left;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_Name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_Name.Location = new System.Drawing.Point(102, 87);
            this.txt_Name.MaxLength = 20;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(429, 20);
            this.txt_Name.TabIndex = 45;
            this.txt_Name.Text = "８８８８８８８８８８８８８８８８８８８８８８８８８８８８８８";
            this.txt_Name.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.None;
            this.txt_Name.xFormat = null;
            this.txt_Name.xIllegalCharacter = null;
            this.txt_Name.xOldText = null;
            this.txt_Name.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // cmb_TrvKbn
            // 
            this.cmb_TrvKbn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TrvKbn.FormattingEnabled = true;
            this.cmb_TrvKbn.Location = new System.Drawing.Point(102, 119);
            this.cmb_TrvKbn.Name = "cmb_TrvKbn";
            this.cmb_TrvKbn.Size = new System.Drawing.Size(206, 21);
            this.cmb_TrvKbn.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.GreenYellow;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "交通費区分";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudperdiem
            // 
            this.nudperdiem.BackColor = System.Drawing.SystemColors.Window;
            this.nudperdiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nudperdiem.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudperdiem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudperdiem.Location = new System.Drawing.Point(102, 154);
            this.nudperdiem.Name = "nudperdiem";
            this.nudperdiem.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudperdiem.Size = new System.Drawing.Size(119, 20);
            this.nudperdiem.TabIndex = 49;
            this.nudperdiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudperdiem.ThousandsSeparator = true;
            this.nudperdiem.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.GreenYellow;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(12, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "日当";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudaccommodation
            // 
            this.nudaccommodation.BackColor = System.Drawing.SystemColors.Window;
            this.nudaccommodation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nudaccommodation.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudaccommodation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudaccommodation.Location = new System.Drawing.Point(336, 154);
            this.nudaccommodation.Name = "nudaccommodation";
            this.nudaccommodation.OldValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudaccommodation.Size = new System.Drawing.Size(119, 20);
            this.nudaccommodation.TabIndex = 51;
            this.nudaccommodation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudaccommodation.ThousandsSeparator = true;
            this.nudaccommodation.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.GreenYellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(250, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "宿泊費";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMnt120
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 553);
            this.Controls.Add(this.nudaccommodation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudperdiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_TrvKbn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Cod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DEL);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.btn_CLR);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dgv_GroupList);
            this.Name = "frmMnt120";
            this.Text = "frmMnt120";
            this.Controls.SetChildIndex(this.dgv_GroupList, 0);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.btn_CLR, 0);
            this.Controls.SetChildIndex(this.btn_End, 0);
            this.Controls.SetChildIndex(this.btn_DEL, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_Cod, 0);
            this.Controls.SetChildIndex(this.txt_Name, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cmb_TrvKbn, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.nudperdiem, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.nudaccommodation, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GroupList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.ucDataGridViewEx dgv_GroupList;
        private System.Windows.Forms.Button btn_DEL;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.Button btn_CLR;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Common.ucNumTextBox txt_Cod;
        private Common.ucTextBoxEx txt_Name;
        private System.Windows.Forms.ComboBox cmb_TrvKbn;
        private System.Windows.Forms.Label label7;
        private Common.ucNumUpDown nudperdiem;
        private System.Windows.Forms.Label label8;
        private Common.ucNumUpDown nudaccommodation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_CDEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_KotsuhiKBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_KotsuhiKbnNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdv_perDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdv_Accommodation;
    }
}