namespace Sugitec
{
    partial class frmSrc010
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
            this.num_Codfrm = new Sugitec.Common.ucNumTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_Codto = new Sugitec.Common.ucNumTextBox();
            this.txt_Name = new Sugitec.Common.ucTextBoxEx();
            this.dgv_result = new Sugitec.Common.ucDataGridViewEx();
            this.dgv_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // num_Codfrm
            // 
            this.num_Codfrm.BackColor = System.Drawing.SystemColors.Window;
            this.num_Codfrm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num_Codfrm.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumeric;
            this.num_Codfrm.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num_Codfrm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.num_Codfrm.Format = null;
            this.num_Codfrm.IllegalCharacter = null;
            this.num_Codfrm.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.num_Codfrm.Location = new System.Drawing.Point(75, 47);
            this.num_Codfrm.MaxLength = 8;
            this.num_Codfrm.Name = "num_Codfrm";
            this.num_Codfrm.OldText = null;
            this.num_Codfrm.Size = new System.Drawing.Size(82, 20);
            this.num_Codfrm.TabIndex = 3;
            this.num_Codfrm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.num_Codfrm.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.None;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(162, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "～";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_Codto
            // 
            this.num_Codto.BackColor = System.Drawing.SystemColors.Window;
            this.num_Codto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num_Codto.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumeric;
            this.num_Codto.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num_Codto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.num_Codto.Format = null;
            this.num_Codto.IllegalCharacter = null;
            this.num_Codto.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.num_Codto.Location = new System.Drawing.Point(184, 47);
            this.num_Codto.MaxLength = 8;
            this.num_Codto.Name = "num_Codto";
            this.num_Codto.OldText = null;
            this.num_Codto.Size = new System.Drawing.Size(82, 20);
            this.num_Codto.TabIndex = 5;
            this.num_Codto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.num_Codto.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.None;
            // 
            // txt_Name
            // 
            this.txt_Name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_Name.Location = new System.Drawing.Point(75, 73);
            this.txt_Name.MaxLength = 30;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(297, 20);
            this.txt_Name.TabIndex = 7;
            this.txt_Name.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.None;
            this.txt_Name.xFormat = null;
            this.txt_Name.xIllegalCharacter = null;
            this.txt_Name.xOldText = null;
            this.txt_Name.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
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
            this.dgv_result.ColumnHeaderRowCount = 1;
            this.dgv_result.ColumnHeaderRowHeight = 17;
            this.dgv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_ID,
            this.dgv_Name});
            this.dgv_result.Location = new System.Drawing.Point(13, 102);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.ReadOnly = true;
            this.dgv_result.RowHeadersVisible = false;
            this.dgv_result.RowTemplate.Height = 21;
            this.dgv_result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_result.Size = new System.Drawing.Size(440, 286);
            this.dgv_result.TabIndex = 8;
            // 
            // dgv_ID
            // 
            this.dgv_ID.HeaderText = "ID";
            this.dgv_ID.Name = "dgv_ID";
            this.dgv_ID.ReadOnly = true;
            // 
            // dgv_Name
            // 
            this.dgv_Name.HeaderText = "名称";
            this.dgv_Name.Name = "dgv_Name";
            this.dgv_Name.ReadOnly = true;
            this.dgv_Name.Width = 300;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(378, 49);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 47);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "検索";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Select.Location = new System.Drawing.Point(297, 394);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 32);
            this.btn_Select.TabIndex = 10;
            this.btn_Select.Text = "選択";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Location = new System.Drawing.Point(378, 394);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 32);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "閉じる";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "コード";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "名称";
            // 
            // frmSrc010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 454);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgv_result);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.num_Codto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_Codfrm);
            this.Name = "frmSrc010";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.num_Codfrm, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.num_Codto, 0);
            this.Controls.SetChildIndex(this.txt_Name, 0);
            this.Controls.SetChildIndex(this.dgv_result, 0);
            this.Controls.SetChildIndex(this.btn_Search, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.btn_Close, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sugitec.Common.ucNumTextBox num_Codfrm;
        private System.Windows.Forms.Label label1;
        private Sugitec.Common.ucNumTextBox num_Codto;
        private Sugitec.Common.ucTextBoxEx txt_Name;
        private Sugitec.Common.ucDataGridViewEx dgv_result;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}