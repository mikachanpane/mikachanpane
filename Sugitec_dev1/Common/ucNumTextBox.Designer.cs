namespace Sugitec.Common
{
    partial class ucNumTextBox
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTenkey = new System.Windows.Forms.Button();
            this.txtInput = new Sugitec.Common.ucTextBoxEx();
            this.SuspendLayout();
            // 
            // btnTenkey
            // 
            this.btnTenkey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTenkey.Location = new System.Drawing.Point(130, 0);
            this.btnTenkey.Name = "btnTenkey";
            this.btnTenkey.Size = new System.Drawing.Size(20, 20);
            this.btnTenkey.TabIndex = 3;
            this.btnTenkey.TabStop = false;
            this.btnTenkey.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTenkey.UseVisualStyleBackColor = true;
            this.btnTenkey.Click += new System.EventHandler(this.btnTenkey_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(0, 0);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(130, 20);
            this.txtInput.TabIndex = 2;
            this.txtInput.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.OnlyNumeric;
            this.txtInput.xFormat = null;
            this.txtInput.xIllegalCharacter = null;
            this.txtInput.xOldText = null;
            this.txtInput.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // ucNumTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnTenkey);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "ucNumTextBox";
            this.Size = new System.Drawing.Size(150, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTenkey;
        private ucTextBoxEx txtInput;
    }
}
