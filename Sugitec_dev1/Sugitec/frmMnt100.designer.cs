namespace Sugitec
{
    partial class frmMnt100
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
            Sugitec.Common.HeaderCell headerCell8 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell9 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell10 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell11 = new Sugitec.Common.HeaderCell();
            Sugitec.Common.HeaderCell headerCell12 = new Sugitec.Common.HeaderCell();
            this.txt_Fax = new Sugitec.Common.ucNumTextBox();
            this.txt_Phone = new Sugitec.Common.ucNumTextBox();
            this.txt_Address1 = new Sugitec.Common.ucTextBoxEx();
            this.txt_Kana = new Sugitec.Common.ucTextBoxEx();
            this.txt_Name = new Sugitec.Common.ucTextBoxEx();
            this.txt_Cod = new Sugitec.Common.ucNumTextBox();
            this.txt_Sime = new Sugitec.Common.ucNumTextBox();
            this.txt_Payment = new Sugitec.Common.ucNumTextBox();
            this.dgv_TokSaki = new Sugitec.Common.ucDataGridViewEx();
            this.dgv_del = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_tokCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_kana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Simebi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_paykbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_payday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_CLR = new System.Windows.Forms.Button();
            this.btn_End = new System.Windows.Forms.Button();
            this.cmb_PayKbn = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_DEL = new System.Windows.Forms.Button();
            this.txt_ZIP = new Sugitec.Common.ucNumTextBox();
            this.btnContent = new System.Windows.Forms.Button();
            this.txt_Address2 = new Sugitec.Common.ucTextBoxEx();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TokSaki)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Fax
            // 
            this.txt_Fax.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Fax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_Fax.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericSymbol;
            this.txt_Fax.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Fax.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Fax.Format = null;
            this.txt_Fax.IllegalCharacter = null;
            this.txt_Fax.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_Fax.Location = new System.Drawing.Point(292, 126);
            this.txt_Fax.MaxLength = 15;
            this.txt_Fax.Name = "txt_Fax";
            this.txt_Fax.OldText = null;
            this.txt_Fax.Size = new System.Drawing.Size(130, 20);
            this.txt_Fax.TabIndex = 5;
            this.txt_Fax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Fax.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.None;
            // 
            // txt_Phone
            // 
            this.txt_Phone.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_Phone.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericSymbol;
            this.txt_Phone.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Phone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Phone.Format = null;
            this.txt_Phone.IllegalCharacter = null;
            this.txt_Phone.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_Phone.Location = new System.Drawing.Point(82, 126);
            this.txt_Phone.MaxLength = 15;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.OldText = null;
            this.txt_Phone.Size = new System.Drawing.Size(130, 20);
            this.txt_Phone.TabIndex = 4;
            this.txt_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Phone.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.None;
            // 
            // txt_Address1
            // 
            this.txt_Address1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_Address1.Location = new System.Drawing.Point(292, 152);
            this.txt_Address1.MaxLength = 100;
            this.txt_Address1.Name = "txt_Address1";
            this.txt_Address1.Size = new System.Drawing.Size(531, 20);
            this.txt_Address1.TabIndex = 7;
            this.txt_Address1.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.None;
            this.txt_Address1.xFormat = null;
            this.txt_Address1.xIllegalCharacter = null;
            this.txt_Address1.xOldText = null;
            this.txt_Address1.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // txt_Kana
            // 
            this.txt_Kana.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_Kana.Location = new System.Drawing.Point(82, 98);
            this.txt_Kana.MaxLength = 30;
            this.txt_Kana.Name = "txt_Kana";
            this.txt_Kana.Size = new System.Drawing.Size(429, 20);
            this.txt_Kana.TabIndex = 3;
            this.txt_Kana.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.None;
            this.txt_Kana.xFormat = null;
            this.txt_Kana.xIllegalCharacter = null;
            this.txt_Kana.xOldText = null;
            this.txt_Kana.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_Name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_Name.Location = new System.Drawing.Point(82, 72);
            this.txt_Name.MaxLength = 30;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(429, 20);
            this.txt_Name.TabIndex = 2;
            this.txt_Name.Text = "８８８８８８８８８８８８８８８８８８８８８８８８８８８８８８";
            this.txt_Name.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.None;
            this.txt_Name.xFormat = null;
            this.txt_Name.xIllegalCharacter = null;
            this.txt_Name.xOldText = null;
            this.txt_Name.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
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
            this.txt_Cod.Location = new System.Drawing.Point(82, 43);
            this.txt_Cod.MaxLength = 8;
            this.txt_Cod.Name = "txt_Cod";
            this.txt_Cod.OldText = null;
            this.txt_Cod.Size = new System.Drawing.Size(86, 20);
            this.txt_Cod.TabIndex = 1;
            this.txt_Cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Cod.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.Left;
            // 
            // txt_Sime
            // 
            this.txt_Sime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_Sime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_Sime.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericCode;
            this.txt_Sime.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Sime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Sime.Format = null;
            this.txt_Sime.IllegalCharacter = "";
            this.txt_Sime.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_Sime.Location = new System.Drawing.Point(688, 72);
            this.txt_Sime.MaxLength = 2;
            this.txt_Sime.Name = "txt_Sime";
            this.txt_Sime.OldText = null;
            this.txt_Sime.Size = new System.Drawing.Size(47, 20);
            this.txt_Sime.TabIndex = 8;
            this.txt_Sime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Sime.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.Left;
            // 
            // txt_Payment
            // 
            this.txt_Payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_Payment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_Payment.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericCode;
            this.txt_Payment.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Payment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Payment.Format = null;
            this.txt_Payment.IllegalCharacter = null;
            this.txt_Payment.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_Payment.Location = new System.Drawing.Point(688, 126);
            this.txt_Payment.MaxLength = 2;
            this.txt_Payment.Name = "txt_Payment";
            this.txt_Payment.OldText = null;
            this.txt_Payment.Size = new System.Drawing.Size(47, 20);
            this.txt_Payment.TabIndex = 10;
            this.txt_Payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Payment.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.Left;
            // 
            // dgv_TokSaki
            // 
            this.dgv_TokSaki.AllowUserToAddRows = false;
            this.dgv_TokSaki.AllowUserToDeleteRows = false;
            this.dgv_TokSaki.AllowUserToResizeRows = false;
            this.dgv_TokSaki.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TokSaki.ColumnHeaderBorderStyle = Sugitec.Common.ucDataGridViewEx.HeaderCellBorderStyle.SingleLine;
            this.dgv_TokSaki.ColumnHeaderRowCount = 1;
            this.dgv_TokSaki.ColumnHeaderRowHeight = 20;
            this.dgv_TokSaki.ColumnHeadersHeight = 22;
            this.dgv_TokSaki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_del,
            this.dgv_tokCod,
            this.dgv_name,
            this.dgv_kana,
            this.dgv_Tel,
            this.dgv_fax,
            this.dgv_post,
            this.dgv_Address1,
            this.dgv_Address2,
            this.dgv_Simebi,
            this.dgv_paykbn,
            this.dgv_payday});
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
            headerCell3.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerCell3.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell4.BackgroundColor = System.Drawing.Color.Empty;
            headerCell4.Column = 3;
            headerCell4.ColumnSpan = 1;
            headerCell4.ForeColor = System.Drawing.Color.Empty;
            headerCell4.Row = 0;
            headerCell4.RowSpan = 1;
            headerCell4.SortVisible = false;
            headerCell4.Text = "かな";
            headerCell4.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            headerCell4.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell5.BackgroundColor = System.Drawing.Color.Empty;
            headerCell5.Column = 4;
            headerCell5.ColumnSpan = 1;
            headerCell5.ForeColor = System.Drawing.Color.Empty;
            headerCell5.Row = 0;
            headerCell5.RowSpan = 1;
            headerCell5.SortVisible = false;
            headerCell5.Text = "電話番号";
            headerCell5.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell5.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell6.BackgroundColor = System.Drawing.Color.Empty;
            headerCell6.Column = 5;
            headerCell6.ColumnSpan = 1;
            headerCell6.ForeColor = System.Drawing.Color.Empty;
            headerCell6.Row = 0;
            headerCell6.RowSpan = 1;
            headerCell6.SortVisible = false;
            headerCell6.Text = "FAX番号";
            headerCell6.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell6.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell7.BackgroundColor = System.Drawing.Color.Empty;
            headerCell7.Column = 6;
            headerCell7.ColumnSpan = 1;
            headerCell7.ForeColor = System.Drawing.Color.Empty;
            headerCell7.Row = 0;
            headerCell7.RowSpan = 1;
            headerCell7.SortVisible = false;
            headerCell7.Text = "郵便番号";
            headerCell7.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell7.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell8.BackgroundColor = System.Drawing.Color.Empty;
            headerCell8.Column = 7;
            headerCell8.ColumnSpan = 1;
            headerCell8.ForeColor = System.Drawing.Color.Empty;
            headerCell8.Row = 0;
            headerCell8.RowSpan = 1;
            headerCell8.SortVisible = false;
            headerCell8.Text = "住所1";
            headerCell8.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerCell8.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell9.BackgroundColor = System.Drawing.Color.Empty;
            headerCell9.Column = 9;
            headerCell9.ColumnSpan = 1;
            headerCell9.ForeColor = System.Drawing.Color.Empty;
            headerCell9.Row = 0;
            headerCell9.RowSpan = 1;
            headerCell9.SortVisible = false;
            headerCell9.Text = "請求締日";
            headerCell9.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell9.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell10.BackgroundColor = System.Drawing.Color.Empty;
            headerCell10.Column = 10;
            headerCell10.ColumnSpan = 1;
            headerCell10.ForeColor = System.Drawing.Color.Empty;
            headerCell10.Row = 0;
            headerCell10.RowSpan = 1;
            headerCell10.SortVisible = false;
            headerCell10.Text = "支払区分";
            headerCell10.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell10.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell11.BackgroundColor = System.Drawing.Color.Empty;
            headerCell11.Column = 11;
            headerCell11.ColumnSpan = 1;
            headerCell11.ForeColor = System.Drawing.Color.Empty;
            headerCell11.Row = 0;
            headerCell11.RowSpan = 1;
            headerCell11.SortVisible = false;
            headerCell11.Text = "支払日";
            headerCell11.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerCell11.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            headerCell12.BackgroundColor = System.Drawing.Color.Empty;
            headerCell12.Column = 8;
            headerCell12.ColumnSpan = 1;
            headerCell12.ForeColor = System.Drawing.Color.Empty;
            headerCell12.Row = 0;
            headerCell12.RowSpan = 1;
            headerCell12.SortVisible = false;
            headerCell12.Text = "住所2";
            headerCell12.TextAlign = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            headerCell12.WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;
            this.dgv_TokSaki.HeaderCells.Add(headerCell1);
            this.dgv_TokSaki.HeaderCells.Add(headerCell2);
            this.dgv_TokSaki.HeaderCells.Add(headerCell3);
            this.dgv_TokSaki.HeaderCells.Add(headerCell4);
            this.dgv_TokSaki.HeaderCells.Add(headerCell5);
            this.dgv_TokSaki.HeaderCells.Add(headerCell6);
            this.dgv_TokSaki.HeaderCells.Add(headerCell7);
            this.dgv_TokSaki.HeaderCells.Add(headerCell8);
            this.dgv_TokSaki.HeaderCells.Add(headerCell9);
            this.dgv_TokSaki.HeaderCells.Add(headerCell10);
            this.dgv_TokSaki.HeaderCells.Add(headerCell11);
            this.dgv_TokSaki.HeaderCells.Add(headerCell12);
            this.dgv_TokSaki.Location = new System.Drawing.Point(15, 256);
            this.dgv_TokSaki.Name = "dgv_TokSaki";
            this.dgv_TokSaki.RowHeadersVisible = false;
            this.dgv_TokSaki.RowTemplate.Height = 21;
            this.dgv_TokSaki.Size = new System.Drawing.Size(808, 287);
            this.dgv_TokSaki.TabIndex = 35;
            this.dgv_TokSaki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TokSaki_CellClick);
            // 
            // dgv_del
            // 
            this.dgv_del.HeaderText = "削除";
            this.dgv_del.Name = "dgv_del";
            this.dgv_del.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_del.Width = 60;
            // 
            // dgv_tokCod
            // 
            this.dgv_tokCod.HeaderText = "コード";
            this.dgv_tokCod.Name = "dgv_tokCod";
            this.dgv_tokCod.ReadOnly = true;
            this.dgv_tokCod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tokCod.Width = 80;
            // 
            // dgv_name
            // 
            this.dgv_name.HeaderText = "名称";
            this.dgv_name.Name = "dgv_name";
            this.dgv_name.ReadOnly = true;
            this.dgv_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_name.Width = 400;
            // 
            // dgv_kana
            // 
            this.dgv_kana.HeaderText = "かな";
            this.dgv_kana.Name = "dgv_kana";
            this.dgv_kana.Visible = false;
            // 
            // dgv_Tel
            // 
            this.dgv_Tel.HeaderText = "電話番号";
            this.dgv_Tel.Name = "dgv_Tel";
            this.dgv_Tel.Visible = false;
            // 
            // dgv_fax
            // 
            this.dgv_fax.HeaderText = "FAX番号";
            this.dgv_fax.Name = "dgv_fax";
            this.dgv_fax.Visible = false;
            // 
            // dgv_post
            // 
            this.dgv_post.HeaderText = "郵便番号";
            this.dgv_post.Name = "dgv_post";
            this.dgv_post.Visible = false;
            // 
            // dgv_Address1
            // 
            this.dgv_Address1.HeaderText = "住所1";
            this.dgv_Address1.Name = "dgv_Address1";
            this.dgv_Address1.Visible = false;
            // 
            // dgv_Address2
            // 
            this.dgv_Address2.HeaderText = "住所2";
            this.dgv_Address2.Name = "dgv_Address2";
            this.dgv_Address2.Visible = false;
            // 
            // dgv_Simebi
            // 
            this.dgv_Simebi.HeaderText = "請求締日";
            this.dgv_Simebi.Name = "dgv_Simebi";
            this.dgv_Simebi.ReadOnly = true;
            this.dgv_Simebi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Simebi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_Simebi.Width = 88;
            // 
            // dgv_paykbn
            // 
            this.dgv_paykbn.HeaderText = "支払区分";
            this.dgv_paykbn.Name = "dgv_paykbn";
            this.dgv_paykbn.ReadOnly = true;
            this.dgv_paykbn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_paykbn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_paykbn.Width = 86;
            // 
            // dgv_payday
            // 
            this.dgv_payday.HeaderText = "支払日";
            this.dgv_payday.Name = "dgv_payday";
            this.dgv_payday.ReadOnly = true;
            this.dgv_payday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_payday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_payday.Width = 74;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(505, 214);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 36);
            this.btn_OK.TabIndex = 11;
            this.btn_OK.Text = "確定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_CLR
            // 
            this.btn_CLR.Location = new System.Drawing.Point(667, 214);
            this.btn_CLR.Name = "btn_CLR";
            this.btn_CLR.Size = new System.Drawing.Size(75, 36);
            this.btn_CLR.TabIndex = 13;
            this.btn_CLR.Text = "クリア";
            this.btn_CLR.UseVisualStyleBackColor = true;
            this.btn_CLR.Click += new System.EventHandler(this.btn_CLR_Click);
            // 
            // btn_End
            // 
            this.btn_End.Location = new System.Drawing.Point(748, 214);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(75, 36);
            this.btn_End.TabIndex = 14;
            this.btn_End.Text = "終了";
            this.btn_End.UseVisualStyleBackColor = true;
            this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
            // 
            // cmb_PayKbn
            // 
            this.cmb_PayKbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmb_PayKbn.FormattingEnabled = true;
            this.cmb_PayKbn.Location = new System.Drawing.Point(688, 98);
            this.cmb_PayKbn.Name = "cmb_PayKbn";
            this.cmb_PayKbn.Size = new System.Drawing.Size(113, 21);
            this.cmb_PayKbn.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(741, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "(末日：99)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(741, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "(末日：99)";
            // 
            // btn_DEL
            // 
            this.btn_DEL.Location = new System.Drawing.Point(586, 214);
            this.btn_DEL.Name = "btn_DEL";
            this.btn_DEL.Size = new System.Drawing.Size(75, 36);
            this.btn_DEL.TabIndex = 12;
            this.btn_DEL.Text = "削除";
            this.btn_DEL.UseVisualStyleBackColor = true;
            this.btn_DEL.Click += new System.EventHandler(this.btn_DEL_Click);
            // 
            // txt_ZIP
            // 
            this.txt_ZIP.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ZIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_ZIP.CharacterType = Sugitec.Common.ucNumTextBox.emCharacterType.OnlyNumericSymbol;
            this.txt_ZIP.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_ZIP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ZIP.Format = null;
            this.txt_ZIP.IllegalCharacter = null;
            this.txt_ZIP.Location = new System.Drawing.Point(82, 152);
            this.txt_ZIP.MaxLength = 8;
            this.txt_ZIP.Name = "txt_ZIP";
            this.txt_ZIP.OldText = null;
            this.txt_ZIP.Size = new System.Drawing.Size(86, 20);
            this.txt_ZIP.TabIndex = 6;
            this.txt_ZIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ZIP.ZeroPadding = Sugitec.Common.ucNumTextBox.emPaddingType.None;
            // 
            // btnContent
            // 
            this.btnContent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnContent.Location = new System.Drawing.Point(16, 204);
            this.btnContent.Name = "btnContent";
            this.btnContent.Size = new System.Drawing.Size(103, 46);
            this.btnContent.TabIndex = 46;
            this.btnContent.Text = "担当者別登録";
            this.btnContent.UseVisualStyleBackColor = true;
            this.btnContent.Click += new System.EventHandler(this.btnContent_Click);
            // 
            // txt_Address2
            // 
            this.txt_Address2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_Address2.Location = new System.Drawing.Point(292, 178);
            this.txt_Address2.MaxLength = 100;
            this.txt_Address2.Name = "txt_Address2";
            this.txt_Address2.Size = new System.Drawing.Size(531, 20);
            this.txt_Address2.TabIndex = 47;
            this.txt_Address2.xCharacterType = Sugitec.Common.ucTextBoxEx.emCharacterType.None;
            this.txt_Address2.xFormat = null;
            this.txt_Address2.xIllegalCharacter = null;
            this.txt_Address2.xOldText = null;
            this.txt_Address2.xZeroPadding = Sugitec.Common.ucTextBoxEx.emPaddingType.None;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.GreenYellow;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(9, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 49;
            this.label14.Text = "コード";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.GreenYellow;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(9, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 20);
            this.label15.TabIndex = 50;
            this.label15.Text = "名称";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.GreenYellow;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(9, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 20);
            this.label16.TabIndex = 51;
            this.label16.Text = "かな";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.GreenYellow;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(9, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 20);
            this.label17.TabIndex = 52;
            this.label17.Text = "電話番号";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.GreenYellow;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(9, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 20);
            this.label18.TabIndex = 53;
            this.label18.Text = "郵便番号";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.GreenYellow;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(220, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 20);
            this.label19.TabIndex = 54;
            this.label19.Text = "FAX番号";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.GreenYellow;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(220, 152);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 20);
            this.label20.TabIndex = 55;
            this.label20.Text = "住所１";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.GreenYellow;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Location = new System.Drawing.Point(220, 178);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 20);
            this.label21.TabIndex = 56;
            this.label21.Text = "住所２";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.GreenYellow;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(615, 71);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 20);
            this.label22.TabIndex = 57;
            this.label22.Text = "請求締日";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.GreenYellow;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Location = new System.Drawing.Point(615, 99);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 20);
            this.label23.TabIndex = 58;
            this.label23.Text = "支払区分";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.GreenYellow;
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label24.Location = new System.Drawing.Point(615, 126);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 20);
            this.label24.TabIndex = 59;
            this.label24.Text = "支払日";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMnt100
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 575);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_Address2);
            this.Controls.Add(this.btnContent);
            this.Controls.Add(this.txt_ZIP);
            this.Controls.Add(this.btn_DEL);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_PayKbn);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.btn_CLR);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dgv_TokSaki);
            this.Controls.Add(this.txt_Payment);
            this.Controls.Add(this.txt_Sime);
            this.Controls.Add(this.txt_Fax);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_Address1);
            this.Controls.Add(this.txt_Kana);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Cod);
            this.Name = "frmMnt100";
            this.Text = "frmMNT100";
            this.Controls.SetChildIndex(this.txt_Cod, 0);
            this.Controls.SetChildIndex(this.txt_Name, 0);
            this.Controls.SetChildIndex(this.txt_Kana, 0);
            this.Controls.SetChildIndex(this.txt_Address1, 0);
            this.Controls.SetChildIndex(this.txt_Phone, 0);
            this.Controls.SetChildIndex(this.txt_Fax, 0);
            this.Controls.SetChildIndex(this.txt_Sime, 0);
            this.Controls.SetChildIndex(this.txt_Payment, 0);
            this.Controls.SetChildIndex(this.dgv_TokSaki, 0);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.btn_CLR, 0);
            this.Controls.SetChildIndex(this.btn_End, 0);
            this.Controls.SetChildIndex(this.cmb_PayKbn, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.btn_DEL, 0);
            this.Controls.SetChildIndex(this.txt_ZIP, 0);
            this.Controls.SetChildIndex(this.btnContent, 0);
            this.Controls.SetChildIndex(this.txt_Address2, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.label23, 0);
            this.Controls.SetChildIndex(this.label24, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TokSaki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sugitec.Common.ucNumTextBox txt_Fax;
        private Sugitec.Common.ucNumTextBox txt_Phone;
        private Sugitec.Common.ucTextBoxEx txt_Address1;
        private Sugitec.Common.ucTextBoxEx txt_Kana;
        private Sugitec.Common.ucNumTextBox txt_Cod;
        private Sugitec.Common.ucNumTextBox txt_Payment;
        private Sugitec.Common.ucDataGridViewEx dgv_TokSaki;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_CLR;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.ComboBox cmb_PayKbn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_DEL;
        private Sugitec.Common.ucNumTextBox txt_ZIP;
        private Common.ucTextBoxEx txt_Name;
        private Common.ucNumTextBox txt_Sime;
		private System.Windows.Forms.Button btnContent;
		private Common.ucTextBoxEx txt_Address2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_del;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tokCod;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_kana;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Tel;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_fax;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_post;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Address1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Address2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Simebi;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_paykbn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_payday;
	}
}