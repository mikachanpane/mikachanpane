namespace Sugitec
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoServer = new System.Windows.Forms.RadioButton();
            this.rdoLocal = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSync = new System.Windows.Forms.CheckBox();
            this.rdoSync3 = new System.Windows.Forms.RadioButton();
            this.rdoSync2 = new System.Windows.Forms.RadioButton();
            this.rdoSync1 = new System.Windows.Forms.RadioButton();
            this.txt_Pass = new Sugitec.Common.ucTextBoxEx();
            this.txt_User = new Sugitec.Common.ucTextBoxEx();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.GreenYellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(25, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_OK.Location = new System.Drawing.Point(192, 324);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(94, 42);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoServer);
            this.groupBox1.Controls.Add(this.rdoLocal);
            this.groupBox1.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(25, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接続先";
            // 
            // rdoServer
            // 
            this.rdoServer.AutoSize = true;
            this.rdoServer.Location = new System.Drawing.Point(30, 56);
            this.rdoServer.Name = "rdoServer";
            this.rdoServer.Size = new System.Drawing.Size(132, 23);
            this.rdoServer.TabIndex = 1;
            this.rdoServer.TabStop = true;
            this.rdoServer.Text = "サーバ接続";
            this.rdoServer.UseVisualStyleBackColor = false;
            // 
            // rdoLocal
            // 
            this.rdoLocal.AutoSize = true;
            this.rdoLocal.Location = new System.Drawing.Point(30, 28);
            this.rdoLocal.Name = "rdoLocal";
            this.rdoLocal.Size = new System.Drawing.Size(153, 23);
            this.rdoLocal.TabIndex = 0;
            this.rdoLocal.TabStop = true;
            this.rdoLocal.Text = "ローカル接続";
            this.rdoLocal.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(292, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSync);
            this.groupBox2.Controls.Add(this.rdoSync3);
            this.groupBox2.Controls.Add(this.rdoSync2);
            this.groupBox2.Controls.Add(this.rdoSync1);
            this.groupBox2.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(25, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 121);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // chkSync
            // 
            this.chkSync.AutoSize = true;
            this.chkSync.Location = new System.Drawing.Point(13, 0);
            this.chkSync.Name = "chkSync";
            this.chkSync.Size = new System.Drawing.Size(217, 23);
            this.chkSync.TabIndex = 3;
            this.chkSync.Text = "データの同期を行う";
            this.chkSync.UseVisualStyleBackColor = true;
            // 
            // rdoSync3
            // 
            this.rdoSync3.AutoSize = true;
            this.rdoSync3.Location = new System.Drawing.Point(30, 85);
            this.rdoSync3.Name = "rdoSync3";
            this.rdoSync3.Size = new System.Drawing.Size(216, 23);
            this.rdoSync3.TabIndex = 2;
            this.rdoSync3.TabStop = true;
            this.rdoSync3.Text = "サーバ　⇒ローカル";
            this.rdoSync3.UseVisualStyleBackColor = false;
            // 
            // rdoSync2
            // 
            this.rdoSync2.AutoSize = true;
            this.rdoSync2.Location = new System.Drawing.Point(30, 57);
            this.rdoSync2.Name = "rdoSync2";
            this.rdoSync2.Size = new System.Drawing.Size(195, 23);
            this.rdoSync2.TabIndex = 1;
            this.rdoSync2.TabStop = true;
            this.rdoSync2.Text = "ローカル⇒サーバ";
            this.rdoSync2.UseVisualStyleBackColor = false;
            // 
            // rdoSync1
            // 
            this.rdoSync1.AutoSize = true;
            this.rdoSync1.Location = new System.Drawing.Point(30, 29);
            this.rdoSync1.Name = "rdoSync1";
            this.rdoSync1.Size = new System.Drawing.Size(300, 23);
            this.rdoSync1.TabIndex = 0;
            this.rdoSync1.TabStop = true;
            this.rdoSync1.Text = "ローカル⇒サーバ⇒ローカル";
            this.rdoSync1.UseVisualStyleBackColor = false;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Pass.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_Pass.Location = new System.Drawing.Point(153, 58);
            this.txt_Pass.MaxLength = 20;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(233, 26);
            this.txt_Pass.TabIndex = 3;
            this.txt_Pass.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.OnlyNarrow;
            this.txt_Pass.xFormat = null;
            this.txt_Pass.xIllegalCharacter = null;
            this.txt_Pass.xOldText = null;
            this.txt_Pass.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_User.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_User.Location = new System.Drawing.Point(153, 19);
            this.txt_User.MaxLength = 20;
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(233, 26);
            this.txt_User.TabIndex = 1;
            this.txt_User.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.OnlyNarrow;
            this.txt_User.xFormat = null;
            this.txt_User.xIllegalCharacter = null;
            this.txt_User.xOldText = null;
            this.txt_User.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Text = "LOGIN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoServer;
        private System.Windows.Forms.RadioButton rdoLocal;
        private Common.ucTextBoxEx txt_User;
        private Common.ucTextBoxEx txt_Pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSync;
        private System.Windows.Forms.RadioButton rdoSync3;
        private System.Windows.Forms.RadioButton rdoSync2;
        private System.Windows.Forms.RadioButton rdoSync1;
    }
}