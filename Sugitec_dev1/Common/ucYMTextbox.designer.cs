namespace Sugitec.Common
{
    partial class ucYMTextbox
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
            this.btnCalendar = new System.Windows.Forms.Button();
            this.masInput = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCalendar
            // 
            this.btnCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalendar.Location = new System.Drawing.Point(80, 0);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(20, 20);
            this.btnCalendar.TabIndex = 1;
            this.btnCalendar.TabStop = false;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // masInput
            // 
            this.masInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masInput.Location = new System.Drawing.Point(0, 0);
            this.masInput.Mask = "0000年00月";
            this.masInput.Name = "masInput";
            this.masInput.Size = new System.Drawing.Size(80, 20);
            this.masInput.TabIndex = 0;
            this.masInput.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // ucYMTextbox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.masInput);
            this.Controls.Add(this.btnCalendar);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "ucYMTextbox";
            this.Size = new System.Drawing.Size(100, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.MaskedTextBox masInput;
    }
}
