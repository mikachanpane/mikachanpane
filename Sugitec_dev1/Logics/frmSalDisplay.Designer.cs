namespace Sugitec.Logics
{
    partial class frmSalDisplay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_result = new Sugitec.Common.ctlDataGridViewEx();
            this.dgv_reqNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_cusNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_engNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_orderYm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_salState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_result
            // 
            this.dgv_result.AllowUserToAddRows = false;
            this.dgv_result.AllowUserToDeleteRows = false;
            this.dgv_result.AllowUserToResizeRows = false;
            this.dgv_result.ColumnHeaderBorderStyle = Sugitec.Common.ctlDataGridViewEx.HeaderCellBorderStyle.SingleLine;
            this.dgv_result.ColumnHeaderRowCount = 1;
            this.dgv_result.ColumnHeaderRowHeight = 17;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_result.ColumnHeadersHeight = 22;
            this.dgv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_reqNo,
            this.dgv_cusNm,
            this.dgv_engNm,
            this.dgv_orderYm,
            this.dgv_salState});
            this.dgv_result.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_result.Location = new System.Drawing.Point(12, 82);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.ReadOnly = true;
            this.dgv_result.RowHeadersVisible = false;
            this.dgv_result.RowTemplate.Height = 21;
            this.dgv_result.Size = new System.Drawing.Size(981, 363);
            this.dgv_result.TabIndex = 63;
            // 
            // dgv_reqNo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgv_reqNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_reqNo.HeaderText = "受注No.";
            this.dgv_reqNo.Name = "dgv_reqNo";
            this.dgv_reqNo.ReadOnly = true;
            this.dgv_reqNo.Width = 75;
            // 
            // dgv_cusNm
            // 
            this.dgv_cusNm.HeaderText = "得意先名";
            this.dgv_cusNm.Name = "dgv_cusNm";
            this.dgv_cusNm.ReadOnly = true;
            this.dgv_cusNm.Width = 150;
            // 
            // dgv_engNm
            // 
            this.dgv_engNm.HeaderText = "技術者名";
            this.dgv_engNm.Name = "dgv_engNm";
            this.dgv_engNm.ReadOnly = true;
            this.dgv_engNm.Width = 130;
            // 
            // dgv_orderYm
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgv_orderYm.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_orderYm.HeaderText = "受注期間";
            this.dgv_orderYm.Name = "dgv_orderYm";
            this.dgv_orderYm.ReadOnly = true;
            // 
            // dgv_salState
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv_salState.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_salState.HeaderText = "売上状態";
            this.dgv_salState.Name = "dgv_salState";
            this.dgv_salState.ReadOnly = true;
            // 
            // frmSalDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 457);
            this.Controls.Add(this.dgv_result);
            this.Name = "frmSalDisplay";
            this.Text = "frmSalDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.ctlDataGridViewEx dgv_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_reqNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_cusNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_engNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_orderYm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_salState;
    }
}