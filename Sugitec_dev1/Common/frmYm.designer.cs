namespace Sugitec.Common
{
    partial class frmYm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_prev = new System.Windows.Forms.Button();
            this.lbl_year = new System.Windows.Forms.Label();
            this.btn_nxt = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Jan = new System.Windows.Forms.Button();
            this.btn_Feb = new System.Windows.Forms.Button();
            this.btn_Mar = new System.Windows.Forms.Button();
            this.btn_Apr = new System.Windows.Forms.Button();
            this.btn_May = new System.Windows.Forms.Button();
            this.btn_jun = new System.Windows.Forms.Button();
            this.btn_jul = new System.Windows.Forms.Button();
            this.btn_Aug = new System.Windows.Forms.Button();
            this.btn_Sep = new System.Windows.Forms.Button();
            this.btn_Oct = new System.Windows.Forms.Button();
            this.btn_Nov = new System.Windows.Forms.Button();
            this.btn_Dec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(267, 220);
            this.splitContainer1.SplitterDistance = 34;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn_prev, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_year, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_nxt, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 34);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_prev
            // 
            this.btn_prev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_prev.Location = new System.Drawing.Point(0, 0);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(0);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(53, 34);
            this.btn_prev.TabIndex = 0;
            this.btn_prev.Text = "＜";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.BackColor = System.Drawing.Color.Blue;
            this.lbl_year.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_year.ForeColor = System.Drawing.Color.White;
            this.lbl_year.Location = new System.Drawing.Point(53, 0);
            this.lbl_year.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(160, 34);
            this.lbl_year.TabIndex = 1;
            this.lbl_year.Text = "2017";
            this.lbl_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_nxt
            // 
            this.btn_nxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_nxt.Location = new System.Drawing.Point(213, 0);
            this.btn_nxt.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nxt.Name = "btn_nxt";
            this.btn_nxt.Size = new System.Drawing.Size(54, 34);
            this.btn_nxt.TabIndex = 2;
            this.btn_nxt.Text = "＞";
            this.btn_nxt.UseVisualStyleBackColor = true;
            this.btn_nxt.Click += new System.EventHandler(this.btn_nxt_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Jan, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Feb, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Mar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Apr, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_May, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_jun, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_jul, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_Aug, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_Sep, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_Oct, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_Nov, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_Dec, 3, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(267, 182);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_Jan
            // 
            this.btn_Jan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Jan.Location = new System.Drawing.Point(0, 0);
            this.btn_Jan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Jan.Name = "btn_Jan";
            this.btn_Jan.Size = new System.Drawing.Size(66, 60);
            this.btn_Jan.TabIndex = 0;
            this.btn_Jan.Text = "1月";
            this.btn_Jan.UseVisualStyleBackColor = false;
            // 
            // btn_Feb
            // 
            this.btn_Feb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Feb.Location = new System.Drawing.Point(66, 0);
            this.btn_Feb.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Feb.Name = "btn_Feb";
            this.btn_Feb.Size = new System.Drawing.Size(66, 60);
            this.btn_Feb.TabIndex = 1;
            this.btn_Feb.Text = "2月";
            this.btn_Feb.UseVisualStyleBackColor = true;
            // 
            // btn_Mar
            // 
            this.btn_Mar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Mar.Location = new System.Drawing.Point(132, 0);
            this.btn_Mar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Mar.Name = "btn_Mar";
            this.btn_Mar.Size = new System.Drawing.Size(66, 60);
            this.btn_Mar.TabIndex = 2;
            this.btn_Mar.Text = "3月";
            this.btn_Mar.UseVisualStyleBackColor = true;
            // 
            // btn_Apr
            // 
            this.btn_Apr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Apr.Location = new System.Drawing.Point(198, 0);
            this.btn_Apr.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Apr.Name = "btn_Apr";
            this.btn_Apr.Size = new System.Drawing.Size(69, 60);
            this.btn_Apr.TabIndex = 3;
            this.btn_Apr.Text = "4月";
            this.btn_Apr.UseVisualStyleBackColor = true;
            // 
            // btn_May
            // 
            this.btn_May.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_May.Location = new System.Drawing.Point(0, 60);
            this.btn_May.Margin = new System.Windows.Forms.Padding(0);
            this.btn_May.Name = "btn_May";
            this.btn_May.Size = new System.Drawing.Size(66, 60);
            this.btn_May.TabIndex = 4;
            this.btn_May.Text = "5月";
            this.btn_May.UseVisualStyleBackColor = false;
            // 
            // btn_jun
            // 
            this.btn_jun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_jun.Location = new System.Drawing.Point(66, 60);
            this.btn_jun.Margin = new System.Windows.Forms.Padding(0);
            this.btn_jun.Name = "btn_jun";
            this.btn_jun.Size = new System.Drawing.Size(66, 60);
            this.btn_jun.TabIndex = 5;
            this.btn_jun.Text = "6月";
            this.btn_jun.UseVisualStyleBackColor = true;
            // 
            // btn_jul
            // 
            this.btn_jul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_jul.Location = new System.Drawing.Point(132, 60);
            this.btn_jul.Margin = new System.Windows.Forms.Padding(0);
            this.btn_jul.Name = "btn_jul";
            this.btn_jul.Size = new System.Drawing.Size(66, 60);
            this.btn_jul.TabIndex = 6;
            this.btn_jul.Text = "7月";
            this.btn_jul.UseVisualStyleBackColor = true;
            // 
            // btn_Aug
            // 
            this.btn_Aug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Aug.Location = new System.Drawing.Point(198, 60);
            this.btn_Aug.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Aug.Name = "btn_Aug";
            this.btn_Aug.Size = new System.Drawing.Size(69, 60);
            this.btn_Aug.TabIndex = 7;
            this.btn_Aug.Text = "8月";
            this.btn_Aug.UseVisualStyleBackColor = true;
            // 
            // btn_Sep
            // 
            this.btn_Sep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sep.Location = new System.Drawing.Point(0, 120);
            this.btn_Sep.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Sep.Name = "btn_Sep";
            this.btn_Sep.Size = new System.Drawing.Size(66, 62);
            this.btn_Sep.TabIndex = 8;
            this.btn_Sep.Text = "9月";
            this.btn_Sep.UseVisualStyleBackColor = true;
            // 
            // btn_Oct
            // 
            this.btn_Oct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Oct.Location = new System.Drawing.Point(66, 120);
            this.btn_Oct.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Oct.Name = "btn_Oct";
            this.btn_Oct.Size = new System.Drawing.Size(66, 62);
            this.btn_Oct.TabIndex = 9;
            this.btn_Oct.Text = "10月";
            this.btn_Oct.UseVisualStyleBackColor = true;
            // 
            // btn_Nov
            // 
            this.btn_Nov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Nov.Location = new System.Drawing.Point(132, 120);
            this.btn_Nov.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Nov.Name = "btn_Nov";
            this.btn_Nov.Size = new System.Drawing.Size(66, 62);
            this.btn_Nov.TabIndex = 10;
            this.btn_Nov.Text = "11月";
            this.btn_Nov.UseVisualStyleBackColor = true;
            // 
            // btn_Dec
            // 
            this.btn_Dec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Dec.Location = new System.Drawing.Point(198, 120);
            this.btn_Dec.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Dec.Name = "btn_Dec";
            this.btn_Dec.Size = new System.Drawing.Size(69, 62);
            this.btn_Dec.TabIndex = 11;
            this.btn_Dec.Text = "12月";
            this.btn_Dec.UseVisualStyleBackColor = true;
            // 
            // frmYm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 220);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "年月指定";
            this.Load += new System.EventHandler(this.frmYm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Button btn_nxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Jan;
        private System.Windows.Forms.Button btn_Feb;
        private System.Windows.Forms.Button btn_Mar;
        private System.Windows.Forms.Button btn_Apr;
        private System.Windows.Forms.Button btn_May;
        private System.Windows.Forms.Button btn_jun;
        private System.Windows.Forms.Button btn_jul;
        private System.Windows.Forms.Button btn_Aug;
        private System.Windows.Forms.Button btn_Sep;
        private System.Windows.Forms.Button btn_Oct;
        private System.Windows.Forms.Button btn_Nov;
        private System.Windows.Forms.Button btn_Dec;
    }
}