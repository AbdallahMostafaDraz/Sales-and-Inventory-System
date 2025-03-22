namespace Sales01.Forms
{
    partial class BillFrm
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShekMode = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.DribaTXT = new System.Windows.Forms.TextBox();
            this.CountDATE = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Df3TypeCMBO = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CustNameCMBO = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CustCodeCMBO = new System.Windows.Forms.ComboBox();
            this.BillDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NotesTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BillNoTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SrfFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPrecent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SafyKima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DoneTXT = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.DontTXT = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.PayTXT = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.TotalAfterDribaTXT = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.DribaValueTXT = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.TotalAfterDiscountTXT = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TotalBeforeDiscountTXT = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TotalDiscountTXT = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NewBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.EdietBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(11, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1761, 99);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = global::Sales.Properties.Resources.transaction_list_100px;
            this.pictureBox5.Location = new System.Drawing.Point(212, -3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(136, 101);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.BackColor = System.Drawing.Color.Navy;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(376, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1135, 31);
            this.label11.TabIndex = 3;
            this.label11.Text = "( الــفــاتـــورة مــلــغــيــة )";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(437, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(901, 33);
            this.label12.TabIndex = 1;
            this.label12.Text = "فـــــــــــــــــــــــواتــــــــــــــيـــــــــــــــر الــــــــــــــبـــــ" +
    "ــــــــيـــــــــــــــع";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ShekMode);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.DribaTXT);
            this.panel1.Controls.Add(this.CountDATE);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Df3TypeCMBO);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CustNameCMBO);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CustCodeCMBO);
            this.panel1.Controls.Add(this.BillDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NotesTXT);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BillNoTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 109);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1761, 199);
            this.panel1.TabIndex = 7;
            // 
            // ShekMode
            // 
            this.ShekMode.DisplayMember = "نقدي";
            this.ShekMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShekMode.FormattingEnabled = true;
            this.ShekMode.Items.AddRange(new object[] {
            "نقدي",
            "شيك"});
            this.ShekMode.Location = new System.Drawing.Point(469, 85);
            this.ShekMode.Name = "ShekMode";
            this.ShekMode.Size = new System.Drawing.Size(142, 27);
            this.ShekMode.TabIndex = 39;
            this.ShekMode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShekMode_KeyDown);
            this.ShekMode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShekMode_KeyUp);
            this.ShekMode.Leave += new System.EventHandler(this.ShekMode_Leave);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(6, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 22);
            this.button1.TabIndex = 38;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(447, 124);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "%";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // DribaTXT
            // 
            this.DribaTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DribaTXT.Location = new System.Drawing.Point(469, 120);
            this.DribaTXT.Margin = new System.Windows.Forms.Padding(4);
            this.DribaTXT.Name = "DribaTXT";
            this.DribaTXT.Size = new System.Drawing.Size(1156, 27);
            this.DribaTXT.TabIndex = 36;
            this.DribaTXT.Text = "0";
            this.DribaTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DribaTXT.TextChanged += new System.EventHandler(this.DribaTXT_TextChanged);
            this.DribaTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DribaTXT_KeyDown);
            this.DribaTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DribaTXT_KeyPress);
            // 
            // CountDATE
            // 
            this.CountDATE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CountDATE.Location = new System.Drawing.Point(46, 85);
            this.CountDATE.Name = "CountDATE";
            this.CountDATE.Size = new System.Drawing.Size(297, 27);
            this.CountDATE.TabIndex = 35;
            this.CountDATE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CountDATE_KeyDown);
            this.CountDATE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountDATE_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(346, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "تاريخ الاستحقاق :";
            // 
            // Df3TypeCMBO
            // 
            this.Df3TypeCMBO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Df3TypeCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Df3TypeCMBO.FormattingEnabled = true;
            this.Df3TypeCMBO.Items.AddRange(new object[] {
            "نـقـديـة",
            "أجـلــة"});
            this.Df3TypeCMBO.Location = new System.Drawing.Point(617, 84);
            this.Df3TypeCMBO.Name = "Df3TypeCMBO";
            this.Df3TypeCMBO.Size = new System.Drawing.Size(1008, 27);
            this.Df3TypeCMBO.TabIndex = 33;
            this.Df3TypeCMBO.SelectedIndexChanged += new System.EventHandler(this.Df3TypeCMBO_SelectedIndexChanged);
            this.Df3TypeCMBO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Df3TypeCMBO_KeyDown);
            this.Df3TypeCMBO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Df3TypeCMBO_KeyPress);
            this.Df3TypeCMBO.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Df3TypeCMBO_KeyUp);
            this.Df3TypeCMBO.Leave += new System.EventHandler(this.Df3TypeCMBO_Leave);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(1644, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "طريقة الدفع :";
            // 
            // CustNameCMBO
            // 
            this.CustNameCMBO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustNameCMBO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CustNameCMBO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustNameCMBO.FormattingEnabled = true;
            this.CustNameCMBO.Location = new System.Drawing.Point(46, 49);
            this.CustNameCMBO.Name = "CustNameCMBO";
            this.CustNameCMBO.Size = new System.Drawing.Size(297, 27);
            this.CustNameCMBO.TabIndex = 31;
            this.CustNameCMBO.DropDown += new System.EventHandler(this.CustNameCMBO_DropDown);
            this.CustNameCMBO.SelectedIndexChanged += new System.EventHandler(this.CustNameCMBO_SelectedIndexChanged);
            this.CustNameCMBO.TextChanged += new System.EventHandler(this.CustNameCMBO_TextChanged);
            this.CustNameCMBO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustNameCMBO_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(348, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "اسم العميل :";
            // 
            // CustCodeCMBO
            // 
            this.CustCodeCMBO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustCodeCMBO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CustCodeCMBO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustCodeCMBO.FormattingEnabled = true;
            this.CustCodeCMBO.Location = new System.Drawing.Point(469, 49);
            this.CustCodeCMBO.Name = "CustCodeCMBO";
            this.CustCodeCMBO.Size = new System.Drawing.Size(1156, 27);
            this.CustCodeCMBO.TabIndex = 29;
            this.CustCodeCMBO.DropDown += new System.EventHandler(this.CustCodeCMBO_DropDown);
            this.CustCodeCMBO.SelectedIndexChanged += new System.EventHandler(this.CustCodeCMBO_SelectedIndexChanged);
            this.CustCodeCMBO.TextChanged += new System.EventHandler(this.CustCodeCMBO_TextChanged);
            this.CustCodeCMBO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustCodeCMBO_KeyDown);
            this.CustCodeCMBO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustCodeCMBO_KeyPress);
            // 
            // BillDate
            // 
            this.BillDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BillDate.Location = new System.Drawing.Point(46, 17);
            this.BillDate.Name = "BillDate";
            this.BillDate.Size = new System.Drawing.Size(297, 27);
            this.BillDate.TabIndex = 28;
            this.BillDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BillDate_KeyDown);
            this.BillDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BillDate_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(345, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "تاريخ الفاتورة :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(367, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "ملاحظات :";
            // 
            // NotesTXT
            // 
            this.NotesTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NotesTXT.Location = new System.Drawing.Point(46, 120);
            this.NotesTXT.Margin = new System.Windows.Forms.Padding(4);
            this.NotesTXT.Name = "NotesTXT";
            this.NotesTXT.Size = new System.Drawing.Size(297, 27);
            this.NotesTXT.TabIndex = 21;
            this.NotesTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NotesTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NotesTXT_KeyDown);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(1625, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "ضريبة المبيعات :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(1651, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "كود العميل :";
            // 
            // BillNoTXT
            // 
            this.BillNoTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillNoTXT.Location = new System.Drawing.Point(469, 17);
            this.BillNoTXT.Margin = new System.Windows.Forms.Padding(4);
            this.BillNoTXT.Name = "BillNoTXT";
            this.BillNoTXT.Size = new System.Drawing.Size(1156, 27);
            this.BillNoTXT.TabIndex = 1;
            this.BillNoTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BillNoTXT.TextChanged += new System.EventHandler(this.BillNoTXT_TextChanged);
            this.BillNoTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BillNoTXT_KeyDown);
            this.BillNoTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BillNoTXT_KeyPress);
            this.BillNoTXT.ImeModeChanged += new System.EventHandler(this.BillNoTXT_ImeModeChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(1646, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة :";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(12, 270);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1761, 244);
            this.panel3.TabIndex = 27;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1703, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 219);
            this.button2.TabIndex = 2;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.SrfFlag,
            this.ItemCode,
            this.ItemName,
            this.ItemMeter,
            this.ItemQuantity,
            this.ItemPrice,
            this.DiscountPrecent,
            this.DiscountValue,
            this.ItemValue,
            this.SafyKima});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(9, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1688, 219);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 50;
            // 
            // SrfFlag
            // 
            this.SrfFlag.HeaderText = "تم الصرف";
            this.SrfFlag.MinimumWidth = 6;
            this.SrfFlag.Name = "SrfFlag";
            this.SrfFlag.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SrfFlag.Width = 80;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "كود الصنف";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemCode.Width = 125;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "اسم الصنف";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemName.Width = 200;
            // 
            // ItemMeter
            // 
            this.ItemMeter.HeaderText = "م/ك";
            this.ItemMeter.MinimumWidth = 6;
            this.ItemMeter.Name = "ItemMeter";
            this.ItemMeter.ReadOnly = true;
            this.ItemMeter.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemMeter.Width = 125;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.HeaderText = "الكمية";
            this.ItemQuantity.MinimumWidth = 6;
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemQuantity.Width = 125;
            // 
            // ItemPrice
            // 
            this.ItemPrice.HeaderText = "السعر";
            this.ItemPrice.MinimumWidth = 6;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemPrice.Width = 125;
            // 
            // DiscountPrecent
            // 
            this.DiscountPrecent.HeaderText = "نسبة الخصم";
            this.DiscountPrecent.MinimumWidth = 6;
            this.DiscountPrecent.Name = "DiscountPrecent";
            this.DiscountPrecent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DiscountPrecent.Width = 110;
            // 
            // DiscountValue
            // 
            this.DiscountValue.HeaderText = "قيمة الخصم";
            this.DiscountValue.MinimumWidth = 6;
            this.DiscountValue.Name = "DiscountValue";
            this.DiscountValue.ReadOnly = true;
            this.DiscountValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DiscountValue.Width = 110;
            // 
            // ItemValue
            // 
            this.ItemValue.HeaderText = "الاجمالي";
            this.ItemValue.MinimumWidth = 6;
            this.ItemValue.Name = "ItemValue";
            this.ItemValue.ReadOnly = true;
            this.ItemValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemValue.Width = 125;
            // 
            // SafyKima
            // 
            this.SafyKima.HeaderText = "صافي القيمة";
            this.SafyKima.MinimumWidth = 6;
            this.SafyKima.Name = "SafyKima";
            this.SafyKima.ReadOnly = true;
            this.SafyKima.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SafyKima.Width = 120;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.DoneTXT);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.DontTXT);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.PayTXT);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.TotalAfterDribaTXT);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.DribaValueTXT);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.TotalAfterDiscountTXT);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.TotalBeforeDiscountTXT);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.TotalDiscountTXT);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Location = new System.Drawing.Point(12, 518);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1762, 148);
            this.panel4.TabIndex = 29;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // DoneTXT
            // 
            this.DoneTXT.BackColor = System.Drawing.SystemColors.Window;
            this.DoneTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneTXT.Location = new System.Drawing.Point(297, 99);
            this.DoneTXT.Name = "DoneTXT";
            this.DoneTXT.ReadOnly = true;
            this.DoneTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DoneTXT.Size = new System.Drawing.Size(169, 27);
            this.DoneTXT.TabIndex = 106;
            this.DoneTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DoneTXT.TextChanged += new System.EventHandler(this.DoneTXT_TextChanged);
            this.DoneTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DoneTXT_KeyDown);
            this.DoneTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoneTXT_KeyPress);
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(491, 102);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(133, 21);
            this.label24.TabIndex = 105;
            this.label24.Text = "المبلغ المسدد :";
            // 
            // DontTXT
            // 
            this.DontTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DontTXT.BackColor = System.Drawing.SystemColors.Window;
            this.DontTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DontTXT.Location = new System.Drawing.Point(12, 98);
            this.DontTXT.Name = "DontTXT";
            this.DontTXT.ReadOnly = true;
            this.DontTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DontTXT.Size = new System.Drawing.Size(158, 27);
            this.DontTXT.TabIndex = 104;
            this.DontTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(176, 102);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(138, 21);
            this.label25.TabIndex = 103;
            this.label25.Text = "المبلغ المتبقي :";
            // 
            // PayTXT
            // 
            this.PayTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PayTXT.BackColor = System.Drawing.SystemColors.Window;
            this.PayTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayTXT.Location = new System.Drawing.Point(607, 95);
            this.PayTXT.Name = "PayTXT";
            this.PayTXT.ReadOnly = true;
            this.PayTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PayTXT.Size = new System.Drawing.Size(1031, 27);
            this.PayTXT.TabIndex = 102;
            this.PayTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PayTXT.TextChanged += new System.EventHandler(this.PayTXT_TextChanged);
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(1642, 98);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(148, 21);
            this.label26.TabIndex = 101;
            this.label26.Text = "المطلوب سداده :";
            // 
            // TotalAfterDribaTXT
            // 
            this.TotalAfterDribaTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalAfterDribaTXT.BackColor = System.Drawing.SystemColors.Window;
            this.TotalAfterDribaTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAfterDribaTXT.Location = new System.Drawing.Point(12, 56);
            this.TotalAfterDribaTXT.Name = "TotalAfterDribaTXT";
            this.TotalAfterDribaTXT.ReadOnly = true;
            this.TotalAfterDribaTXT.Size = new System.Drawing.Size(454, 27);
            this.TotalAfterDribaTXT.TabIndex = 100;
            this.TotalAfterDribaTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalAfterDribaTXT.TextChanged += new System.EventHandler(this.TotalAfterDribaTXT_TextChanged);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(466, 59);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(168, 21);
            this.label22.TabIndex = 99;
            this.label22.Text = "القيمة بعد الضريبة :";
            // 
            // DribaValueTXT
            // 
            this.DribaValueTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DribaValueTXT.BackColor = System.Drawing.SystemColors.Window;
            this.DribaValueTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DribaValueTXT.Location = new System.Drawing.Point(607, 54);
            this.DribaValueTXT.Name = "DribaValueTXT";
            this.DribaValueTXT.ReadOnly = true;
            this.DribaValueTXT.Size = new System.Drawing.Size(1031, 27);
            this.DribaValueTXT.TabIndex = 98;
            this.DribaValueTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DribaValueTXT.TextChanged += new System.EventHandler(this.DribaValueTXT_TextChanged);
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1658, 56);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(125, 21);
            this.label23.TabIndex = 97;
            this.label23.Text = "قيمة الضريبة :";
            // 
            // TotalAfterDiscountTXT
            // 
            this.TotalAfterDiscountTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalAfterDiscountTXT.BackColor = System.Drawing.SystemColors.Window;
            this.TotalAfterDiscountTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAfterDiscountTXT.Location = new System.Drawing.Point(12, 18);
            this.TotalAfterDiscountTXT.Name = "TotalAfterDiscountTXT";
            this.TotalAfterDiscountTXT.ReadOnly = true;
            this.TotalAfterDiscountTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalAfterDiscountTXT.Size = new System.Drawing.Size(171, 27);
            this.TotalAfterDiscountTXT.TabIndex = 96;
            this.TotalAfterDiscountTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalAfterDiscountTXT.TextChanged += new System.EventHandler(this.TotalAfterDiscountTXT_TextChanged);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(185, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 21);
            this.label19.TabIndex = 95;
            this.label19.Text = "صافي القيمة :";
            // 
            // TotalBeforeDiscountTXT
            // 
            this.TotalBeforeDiscountTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalBeforeDiscountTXT.BackColor = System.Drawing.SystemColors.Window;
            this.TotalBeforeDiscountTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBeforeDiscountTXT.Location = new System.Drawing.Point(604, 18);
            this.TotalBeforeDiscountTXT.Name = "TotalBeforeDiscountTXT";
            this.TotalBeforeDiscountTXT.ReadOnly = true;
            this.TotalBeforeDiscountTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalBeforeDiscountTXT.Size = new System.Drawing.Size(1034, 27);
            this.TotalBeforeDiscountTXT.TabIndex = 94;
            this.TotalBeforeDiscountTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalBeforeDiscountTXT.TextChanged += new System.EventHandler(this.TotalBeforeDiscountTXT_TextChanged);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1644, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(146, 21);
            this.label20.TabIndex = 93;
            this.label20.Text = "اجمالي الفاتورة :";
            // 
            // TotalDiscountTXT
            // 
            this.TotalDiscountTXT.BackColor = System.Drawing.SystemColors.Window;
            this.TotalDiscountTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDiscountTXT.Location = new System.Drawing.Point(285, 18);
            this.TotalDiscountTXT.Name = "TotalDiscountTXT";
            this.TotalDiscountTXT.ReadOnly = true;
            this.TotalDiscountTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalDiscountTXT.Size = new System.Drawing.Size(181, 27);
            this.TotalDiscountTXT.TabIndex = 92;
            this.TotalDiscountTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalDiscountTXT.TextChanged += new System.EventHandler(this.TotalDiscountTXT_TextChanged);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(486, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(140, 21);
            this.label21.TabIndex = 91;
            this.label21.Text = "اجمالي الخصم :";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.NewBTN);
            this.panel5.Controls.Add(this.ExitBTN);
            this.panel5.Controls.Add(this.SearchBTN);
            this.panel5.Controls.Add(this.DeleteBTN);
            this.panel5.Controls.Add(this.EdietBTN);
            this.panel5.Controls.Add(this.SaveBTN);
            this.panel5.Location = new System.Drawing.Point(12, 670);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1762, 61);
            this.panel5.TabIndex = 3;
            // 
            // NewBTN
            // 
            this.NewBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewBTN.BackColor = System.Drawing.SystemColors.Control;
            this.NewBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBTN.Location = new System.Drawing.Point(1204, 8);
            this.NewBTN.Name = "NewBTN";
            this.NewBTN.Size = new System.Drawing.Size(132, 44);
            this.NewBTN.TabIndex = 22;
            this.NewBTN.Text = "فاتورة جديدة";
            this.NewBTN.UseVisualStyleBackColor = false;
            this.NewBTN.Click += new System.EventHandler(this.NewBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExitBTN.BackColor = System.Drawing.SystemColors.Control;
            this.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBTN.Location = new System.Drawing.Point(498, 9);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(115, 43);
            this.ExitBTN.TabIndex = 21;
            this.ExitBTN.Text = "اغلاق";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // SearchBTN
            // 
            this.SearchBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SearchBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SearchBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBTN.Location = new System.Drawing.Point(918, 9);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(115, 43);
            this.SearchBTN.TabIndex = 20;
            this.SearchBTN.Text = "بحث";
            this.SearchBTN.UseVisualStyleBackColor = false;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteBTN.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBTN.Location = new System.Drawing.Point(637, 9);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(117, 43);
            this.DeleteBTN.TabIndex = 19;
            this.DeleteBTN.Text = "الغاء الفاتورة";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // EdietBTN
            // 
            this.EdietBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EdietBTN.BackColor = System.Drawing.SystemColors.Control;
            this.EdietBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EdietBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdietBTN.Location = new System.Drawing.Point(779, 9);
            this.EdietBTN.Name = "EdietBTN";
            this.EdietBTN.Size = new System.Drawing.Size(115, 43);
            this.EdietBTN.TabIndex = 18;
            this.EdietBTN.Text = "تعديل";
            this.EdietBTN.UseVisualStyleBackColor = false;
            this.EdietBTN.Click += new System.EventHandler(this.EdietBTN_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SaveBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBTN.Location = new System.Drawing.Point(1059, 8);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(115, 44);
            this.SaveBTN.TabIndex = 17;
            this.SaveBTN.Text = "حفظ";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // BillFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1784, 735);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BillFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BillFrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NotesTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BillNoTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DribaTXT;
        private System.Windows.Forms.DateTimePicker CountDATE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Df3TypeCMBO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CustNameCMBO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CustCodeCMBO;
        private System.Windows.Forms.DateTimePicker BillDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.TextBox DoneTXT;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.TextBox DontTXT;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.TextBox PayTXT;
        internal System.Windows.Forms.Label label26;
        internal System.Windows.Forms.TextBox TotalAfterDribaTXT;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.TextBox DribaValueTXT;
        internal System.Windows.Forms.Label label23;
        internal System.Windows.Forms.TextBox TotalAfterDiscountTXT;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.TextBox TotalBeforeDiscountTXT;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.TextBox TotalDiscountTXT;
        internal System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Button NewBTN;
        internal System.Windows.Forms.Button ExitBTN;
        internal System.Windows.Forms.Button SearchBTN;
        internal System.Windows.Forms.Button DeleteBTN;
        internal System.Windows.Forms.Button EdietBTN;
        internal System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox ShekMode;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SrfFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPrecent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SafyKima;
    }
}