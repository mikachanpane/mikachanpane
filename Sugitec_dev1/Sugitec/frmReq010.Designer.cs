namespace Sugitec
{
    partial class frmReq010
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSime = new Sugitec.Common.ucNumTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCus = new System.Windows.Forms.ComboBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnMak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(43, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "得意先";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSime
            // 
            this.txtSime.BackColor = System.Drawing.SystemColors.Window;
            this.txtSime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtSime.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericCode;
            this.txtSime.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSime.Format = null;
            this.txtSime.IllegalCharacter = null;
            this.txtSime.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtSime.Location = new System.Drawing.Point(126, 65);
            this.txtSime.MaxLength = 2;
            this.txtSime.Name = "txtSime";
            this.txtSime.OldText = null;
            this.txtSime.Size = new System.Drawing.Size(44, 20);
            this.txtSime.TabIndex = 1;
            this.txtSime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSime.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.Left;
            this.txtSime.Validated += new System.EventHandler(this.txtSime_Validated);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.GreenYellow;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(43, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "対象締日";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(175, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "(末日：99)";
            // 
            // cmbCus
            // 
            this.cmbCus.FormattingEnabled = true;
            this.cmbCus.Location = new System.Drawing.Point(126, 106);
            this.cmbCus.Name = "cmbCus";
            this.cmbCus.Size = new System.Drawing.Size(265, 21);
            this.cmbCus.TabIndex = 4;
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(297, 253);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(93, 43);
            this.btnEnd.TabIndex = 6;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnMak
            // 
            this.btnMak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMak.Location = new System.Drawing.Point(198, 253);
            this.btnMak.Name = "btnMak";
            this.btnMak.Size = new System.Drawing.Size(93, 43);
            this.btnMak.TabIndex = 5;
            this.btnMak.Text = "作成";
            this.btnMak.UseVisualStyleBackColor = true;
            this.btnMak.Click += new System.EventHandler(this.btnMak_Click);
            // 
            // frmReq010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 331);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnMak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbCus);
            this.Name = "frmReq010";
            this.Text = "frmReq010";
            this.Controls.SetChildIndex(this.cmbCus, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtSime, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnMak, 0);
            this.Controls.SetChildIndex(this.btnEnd, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Common.ucNumTextBox txtSime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbCus;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnMak;
    }
}