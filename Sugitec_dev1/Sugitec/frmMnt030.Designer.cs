namespace Sugitec
{
    partial class frmMnt030
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Sugitec.Common.HeaderCell headerCell4 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell5 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell6 = new Sugitec.Common.HeaderCell();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_KbnList = new Sugitec.Common.ucDataGridViewEx();
            this.dgv_KDEL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_KBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_KBNNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_KbnNm = new Sugitec.Common.ucTextBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Kbn = new Sugitec.Common.ucTextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_KbnNm = new System.Windows.Forms.Label();
            this.lbl_Kbn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dgv_CodeList = new Sugitec.Common.ucDataGridViewEx();
            this.dgv_CDEL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_CODENM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_CodeNm = new Sugitec.Common.ucTextBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Code = new Sugitec.Common.ucNumTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KbnList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CodeList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgv_KbnList);
            this.groupBox1.Controls.Add(this.txt_KbnNm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Kbn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 405);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "区分";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(358, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "削除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonKBNDEL_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "変更";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonKBNUPD_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "追加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonKBNADD_Click);
            // 
            // dgv_KbnList
            // 
            this.dgv_KbnList.AllowUserToAddRows = false;
            this.dgv_KbnList.AllowUserToDeleteRows = false;
            this.dgv_KbnList.AllowUserToResizeRows = false;
            this.dgv_KbnList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_KbnList.ColumnHeaderBorderStyle = Sugitec.Common.ucDataGridViewEx.HeaderCellBorderStyle.SingleLine;
            this.dgv_KbnList.ColumnHeaderRowCount = 1;
            this.dgv_KbnList.ColumnHeaderRowHeight = 20;
            this.dgv_KbnList.ColumnHeadersHeight = 22;
            this.dgv_KbnList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_KDEL,
            this.dgv_KBN,
            this.dgv_KBNNM});
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
            headerCell2.Text = "区分";
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
            headerCell3.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerCell3.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.dgv_KbnList.HeaderCells.Add(headerCell1);
            this.dgv_KbnList.HeaderCells.Add(headerCell2);
            this.dgv_KbnList.HeaderCells.Add(headerCell3);
            this.dgv_KbnList.Location = new System.Drawing.Point(12, 55);
            this.dgv_KbnList.Name = "dgv_KbnList";
            this.dgv_KbnList.RowHeadersVisible = false;
            this.dgv_KbnList.RowTemplate.Height = 21;
            this.dgv_KbnList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_KbnList.Size = new System.Drawing.Size(340, 334);
            this.dgv_KbnList.TabIndex = 4;
            this.dgv_KbnList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KbnList_CellClick);
            // 
            // dgv_KDEL
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KDEL.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_KDEL.FalseValue = "0";
            this.dgv_KDEL.HeaderText = "削除";
            this.dgv_KDEL.Name = "dgv_KDEL";
            this.dgv_KDEL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KDEL.TrueValue = "1";
            this.dgv_KDEL.Width = 40;
            // 
            // dgv_KBN
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KBN.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_KBN.HeaderText = "区分";
            this.dgv_KBN.Name = "dgv_KBN";
            this.dgv_KBN.ReadOnly = true;
            this.dgv_KBN.Width = 80;
            // 
            // dgv_KBNNM
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KBNNM.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_KBNNM.HeaderText = "名称";
            this.dgv_KBNNM.Name = "dgv_KBNNM";
            this.dgv_KBNNM.ReadOnly = true;
            this.dgv_KBNNM.Width = 200;
            // 
            // txt_KbnNm
            // 
            this.txt_KbnNm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_KbnNm.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_KbnNm.Location = new System.Drawing.Point(168, 26);
            this.txt_KbnNm.MaxLength = 50;
            this.txt_KbnNm.Name = "txt_KbnNm";
            this.txt_KbnNm.Size = new System.Drawing.Size(184, 20);
            this.txt_KbnNm.TabIndex = 3;
            this.txt_KbnNm.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.None;
            this.txt_KbnNm.xFormat = null;
            this.txt_KbnNm.xIllegalCharacter = null;
            this.txt_KbnNm.xOldText = null;
            this.txt_KbnNm.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(109, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "名称";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Kbn
            // 
            this.txt_Kbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_Kbn.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_Kbn.Location = new System.Drawing.Point(69, 26);
            this.txt_Kbn.MaxLength = 3;
            this.txt_Kbn.Name = "txt_Kbn";
            this.txt_Kbn.Size = new System.Drawing.Size(34, 20);
            this.txt_Kbn.TabIndex = 1;
            this.txt_Kbn.Text = "A88";
            this.txt_Kbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Kbn.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.OnlyAlphaNumeric;
            this.txt_Kbn.xFormat = null;
            this.txt_Kbn.xIllegalCharacter = null;
            this.txt_Kbn.xOldText = null;
            this.txt_Kbn.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "区分";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_KbnNm);
            this.groupBox2.Controls.Add(this.lbl_Kbn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.dgv_CodeList);
            this.groupBox2.Controls.Add(this.txt_CodeNm);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_Code);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(448, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 405);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "コード";
            // 
            // lbl_KbnNm
            // 
            this.lbl_KbnNm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_KbnNm.Location = new System.Drawing.Point(175, 26);
            this.lbl_KbnNm.Name = "lbl_KbnNm";
            this.lbl_KbnNm.Size = new System.Drawing.Size(191, 20);
            this.lbl_KbnNm.TabIndex = 3;
            this.lbl_KbnNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Kbn
            // 
            this.lbl_Kbn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Kbn.Location = new System.Drawing.Point(69, 26);
            this.lbl_Kbn.Name = "lbl_Kbn";
            this.lbl_Kbn.Size = new System.Drawing.Size(30, 20);
            this.lbl_Kbn.TabIndex = 1;
            this.lbl_Kbn.Text = "A88";
            this.lbl_Kbn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.GreenYellow;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(116, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "名称";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.GreenYellow;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "区分";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 34);
            this.button4.TabIndex = 11;
            this.button4.Text = "削除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonCDDEL_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(372, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 34);
            this.button5.TabIndex = 10;
            this.button5.Text = "変更";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonCDUPD_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(372, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 34);
            this.button6.TabIndex = 9;
            this.button6.Text = "追加";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonCDADD_Click);
            // 
            // dgv_CodeList
            // 
            this.dgv_CodeList.AllowUserToAddRows = false;
            this.dgv_CodeList.AllowUserToDeleteRows = false;
            this.dgv_CodeList.AllowUserToResizeRows = false;
            this.dgv_CodeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_CodeList.ColumnHeaderBorderStyle = Sugitec.Common.ucDataGridViewEx.HeaderCellBorderStyle.SingleLine;
            this.dgv_CodeList.ColumnHeaderRowCount = 1;
            this.dgv_CodeList.ColumnHeaderRowHeight = 20;
            this.dgv_CodeList.ColumnHeadersHeight = 22;
            this.dgv_CodeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_CDEL,
            this.dgv_CODE,
            this.dgv_CODENM});
            headerCell4.BackgroundColor = System.Drawing.Color.Empty;
            headerCell4.Column = 0;
            headerCell4.ColumnSpan = 1;
            headerCell4.ForeColor = System.Drawing.Color.Empty;
            headerCell4.Row = 0;
            headerCell4.RowSpan = 1;
            headerCell4.SortVisible = false;
            headerCell4.Text = "削除";
            headerCell4.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell4.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell5.BackgroundColor = System.Drawing.Color.Empty;
            headerCell5.Column = 1;
            headerCell5.ColumnSpan = 1;
            headerCell5.ForeColor = System.Drawing.Color.Empty;
            headerCell5.Row = 0;
            headerCell5.RowSpan = 1;
            headerCell5.SortVisible = false;
            headerCell5.Text = "コード";
            headerCell5.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell5.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell6.BackgroundColor = System.Drawing.Color.Empty;
            headerCell6.Column = 2;
            headerCell6.ColumnSpan = 1;
            headerCell6.ForeColor = System.Drawing.Color.Empty;
            headerCell6.Row = 0;
            headerCell6.RowSpan = 1;
            headerCell6.SortVisible = false;
            headerCell6.Text = "名称";
            headerCell6.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerCell6.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.dgv_CodeList.HeaderCells.Add(headerCell4);
            this.dgv_CodeList.HeaderCells.Add(headerCell5);
            this.dgv_CodeList.HeaderCells.Add(headerCell6);
            this.dgv_CodeList.Location = new System.Drawing.Point(12, 95);
            this.dgv_CodeList.Name = "dgv_CodeList";
            this.dgv_CodeList.RowHeadersVisible = false;
            this.dgv_CodeList.RowTemplate.Height = 21;
            this.dgv_CodeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_CodeList.Size = new System.Drawing.Size(354, 294);
            this.dgv_CodeList.TabIndex = 8;
            this.dgv_CodeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CodeList_CellClick);
            // 
            // dgv_CDEL
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CDEL.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_CDEL.FalseValue = "0";
            this.dgv_CDEL.HeaderText = "削除";
            this.dgv_CDEL.Name = "dgv_CDEL";
            this.dgv_CDEL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CDEL.TrueValue = "1";
            this.dgv_CDEL.Width = 40;
            // 
            // dgv_CODE
            // 
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CODE.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_CODE.HeaderText = "コード";
            this.dgv_CODE.Name = "dgv_CODE";
            this.dgv_CODE.ReadOnly = true;
            this.dgv_CODE.Width = 80;
            // 
            // dgv_CODENM
            // 
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CODENM.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_CODENM.HeaderText = "名称";
            this.dgv_CODENM.Name = "dgv_CODENM";
            this.dgv_CODENM.ReadOnly = true;
            this.dgv_CODENM.Width = 200;
            // 
            // txt_CodeNm
            // 
            this.txt_CodeNm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_CodeNm.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_CodeNm.Location = new System.Drawing.Point(175, 59);
            this.txt_CodeNm.MaxLength = 50;
            this.txt_CodeNm.Name = "txt_CodeNm";
            this.txt_CodeNm.Size = new System.Drawing.Size(191, 20);
            this.txt_CodeNm.TabIndex = 7;
            this.txt_CodeNm.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.None;
            this.txt_CodeNm.xFormat = null;
            this.txt_CodeNm.xIllegalCharacter = null;
            this.txt_CodeNm.xOldText = null;
            this.txt_CodeNm.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.GreenYellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(116, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "名称";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Code
            // 
            this.txt_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_Code.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_Code.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericCode;
            this.txt_Code.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Code.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Code.Format = null;
            this.txt_Code.IllegalCharacter = null;
            this.txt_Code.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_Code.Location = new System.Drawing.Point(69, 59);
            this.txt_Code.MaxLength = 2;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.OldText = null;
            this.txt_Code.Size = new System.Drawing.Size(42, 20);
            this.txt_Code.TabIndex = 5;
            this.txt_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Code.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.Left;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.GreenYellow;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "コード";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMnt030
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMnt030";
            this.Text = "frmMnt030";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KbnList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CodeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private Common.ucTextBoxEx txt_Kbn;
        private System.Windows.Forms.Label label1;
        private Common.ucTextBoxEx txt_KbnNm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Common.ucDataGridViewEx dgv_KbnList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_KDEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_KBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_KBNNM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_KbnNm;
        private System.Windows.Forms.Label lbl_Kbn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private Common.ucDataGridViewEx dgv_CodeList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_CDEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_CODENM;
        private Common.ucTextBoxEx txt_CodeNm;
        private System.Windows.Forms.Label label3;
        private Common.ucNumTextBox txt_Code;
        private System.Windows.Forms.Label label4;
    }
}