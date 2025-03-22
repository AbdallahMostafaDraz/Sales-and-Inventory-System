namespace Sales.Forms
{
    partial class EznMortg3BillFrm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.NewBTN = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EdietBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityMortg3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BillSearchBTN = new System.Windows.Forms.Button();
            this.CustNameTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BillNoTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EznDateTXT = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.EznNoTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TotalDontTXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalDoneTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalEznTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.NewBTN);
            this.panel5.Controls.Add(this.ExitBtn);
            this.panel5.Controls.Add(this.SearchBtn);
            this.panel5.Controls.Add(this.DeleteBtn);
            this.panel5.Controls.Add(this.EdietBtn);
            this.panel5.Controls.Add(this.SaveBtn);
            this.panel5.Location = new System.Drawing.Point(9, 654);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1741, 71);
            this.panel5.TabIndex = 15;
            // 
            // NewBTN
            // 
            this.NewBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NewBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBTN.Location = new System.Drawing.Point(1135, 12);
            this.NewBTN.Name = "NewBTN";
            this.NewBTN.Size = new System.Drawing.Size(122, 39);
            this.NewBTN.TabIndex = 22;
            this.NewBTN.Text = "اذن جــديـــد";
            this.NewBTN.UseVisualStyleBackColor = true;
            this.NewBTN.Click += new System.EventHandler(this.NewBTN_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(443, 13);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(122, 38);
            this.ExitBtn.TabIndex = 21;
            this.ExitBtn.Text = "اغلاق";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(859, 13);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(122, 38);
            this.SearchBtn.TabIndex = 20;
            this.SearchBtn.Text = "بحث";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(584, 13);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(122, 38);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "الغاء الاذن";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EdietBtn
            // 
            this.EdietBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EdietBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EdietBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdietBtn.Location = new System.Drawing.Point(723, 13);
            this.EdietBtn.Name = "EdietBtn";
            this.EdietBtn.Size = new System.Drawing.Size(122, 38);
            this.EdietBtn.TabIndex = 18;
            this.EdietBtn.Text = "تعديل";
            this.EdietBtn.UseVisualStyleBackColor = true;
            this.EdietBtn.Click += new System.EventHandler(this.EdietBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(999, 12);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(122, 39);
            this.SaveBtn.TabIndex = 17;
            this.SaveBtn.Text = "حفظ";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(8, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1743, 360);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(765, 336);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(207, 21);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اضافة أصناف اخرى للاذن";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.MainQuantity,
            this.QuantityDone,
            this.QuantityMortg3,
            this.ItemPrice,
            this.ItemValue});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(374, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(963, 309);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "كود الصنف";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 220;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "اسم الصنف";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 200;
            // 
            // MainQuantity
            // 
            this.MainQuantity.HeaderText = "مباع";
            this.MainQuantity.MinimumWidth = 6;
            this.MainQuantity.Name = "MainQuantity";
            this.MainQuantity.ReadOnly = true;
            this.MainQuantity.Width = 125;
            // 
            // QuantityDone
            // 
            this.QuantityDone.HeaderText = "مصروف";
            this.QuantityDone.MinimumWidth = 6;
            this.QuantityDone.Name = "QuantityDone";
            this.QuantityDone.ReadOnly = true;
            this.QuantityDone.Width = 125;
            // 
            // QuantityMortg3
            // 
            this.QuantityMortg3.HeaderText = "مرتجع";
            this.QuantityMortg3.MinimumWidth = 6;
            this.QuantityMortg3.Name = "QuantityMortg3";
            this.QuantityMortg3.Width = 125;
            // 
            // ItemPrice
            // 
            this.ItemPrice.HeaderText = "السعر";
            this.ItemPrice.MinimumWidth = 6;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            this.ItemPrice.Width = 125;
            // 
            // ItemValue
            // 
            this.ItemValue.HeaderText = "الاجمالي";
            this.ItemValue.MinimumWidth = 6;
            this.ItemValue.Name = "ItemValue";
            this.ItemValue.ReadOnly = true;
            this.ItemValue.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BillSearchBTN);
            this.panel1.Controls.Add(this.CustNameTXT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BillNoTXT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EznDateTXT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EznNoTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 131);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1741, 98);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BillSearchBTN
            // 
            this.BillSearchBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BillSearchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BillSearchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillSearchBTN.Image = global::Sales.Properties.Resources.search_property_24px;
            this.BillSearchBTN.Location = new System.Drawing.Point(805, 56);
            this.BillSearchBTN.Name = "BillSearchBTN";
            this.BillSearchBTN.Size = new System.Drawing.Size(42, 26);
            this.BillSearchBTN.TabIndex = 43;
            this.BillSearchBTN.UseVisualStyleBackColor = true;
            this.BillSearchBTN.Click += new System.EventHandler(this.BillSearchBTN_Click);
            this.BillSearchBTN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BillSearchBTN_KeyPress);
            // 
            // CustNameTXT
            // 
            this.CustNameTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CustNameTXT.Location = new System.Drawing.Point(483, 55);
            this.CustNameTXT.Margin = new System.Windows.Forms.Padding(4);
            this.CustNameTXT.Name = "CustNameTXT";
            this.CustNameTXT.Size = new System.Drawing.Size(181, 27);
            this.CustNameTXT.TabIndex = 42;
            this.CustNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustNameTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustNameTXT_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(665, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "اسـم الـعـمـيـل :";
            // 
            // BillNoTXT
            // 
            this.BillNoTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BillNoTXT.Location = new System.Drawing.Point(854, 56);
            this.BillNoTXT.Margin = new System.Windows.Forms.Padding(4);
            this.BillNoTXT.Name = "BillNoTXT";
            this.BillNoTXT.Size = new System.Drawing.Size(181, 27);
            this.BillNoTXT.TabIndex = 40;
            this.BillNoTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BillNoTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(1043, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "رقـم الـفـاتـورة :";
            // 
            // EznDateTXT
            // 
            this.EznDateTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EznDateTXT.Location = new System.Drawing.Point(483, 19);
            this.EznDateTXT.Name = "EznDateTXT";
            this.EznDateTXT.Size = new System.Drawing.Size(181, 27);
            this.EznDateTXT.TabIndex = 28;
            this.EznDateTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EznDateTXT_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(672, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "تـاريخ الاذن :";
            // 
            // EznNoTXT
            // 
            this.EznNoTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EznNoTXT.Location = new System.Drawing.Point(854, 19);
            this.EznNoTXT.Margin = new System.Windows.Forms.Padding(4);
            this.EznNoTXT.Name = "EznNoTXT";
            this.EznNoTXT.Size = new System.Drawing.Size(181, 27);
            this.EznNoTXT.TabIndex = 1;
            this.EznNoTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EznNoTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(1043, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم اذن المرتجع :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(13, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1738, 64);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox6.Image = global::Sales.Properties.Resources.icons8_return_purcddhase_32;
            this.pictureBox6.Location = new System.Drawing.Point(433, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(479, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(790, 33);
            this.label12.TabIndex = 1;
            this.label12.Text = "اذن مـــــــــرتـــــــجــــــــــــع مــــــــبـــــــــيـــــــــــعـــــــــــ" +
    "ــات";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TotalDontTXT);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.TotalDoneTXT);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TotalEznTXT);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(9, 595);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1741, 52);
            this.panel3.TabIndex = 17;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // TotalDontTXT
            // 
            this.TotalDontTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalDontTXT.BackColor = System.Drawing.SystemColors.Window;
            this.TotalDontTXT.Location = new System.Drawing.Point(425, 15);
            this.TotalDontTXT.Margin = new System.Windows.Forms.Padding(4);
            this.TotalDontTXT.Name = "TotalDontTXT";
            this.TotalDontTXT.ReadOnly = true;
            this.TotalDontTXT.Size = new System.Drawing.Size(183, 27);
            this.TotalDontTXT.TabIndex = 45;
            this.TotalDontTXT.Text = "0";
            this.TotalDontTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalDontTXT.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.TotalDontTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalDontTXT_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(610, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 44;
            this.label7.Text = "المتبقي :";
            // 
            // TotalDoneTXT
            // 
            this.TotalDoneTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalDoneTXT.Location = new System.Drawing.Point(702, 16);
            this.TotalDoneTXT.Margin = new System.Windows.Forms.Padding(4);
            this.TotalDoneTXT.Name = "TotalDoneTXT";
            this.TotalDoneTXT.Size = new System.Drawing.Size(183, 27);
            this.TotalDoneTXT.TabIndex = 43;
            this.TotalDoneTXT.Text = "0";
            this.TotalDoneTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalDoneTXT.TextChanged += new System.EventHandler(this.TotalDoneTXT_TextChanged);
            this.TotalDoneTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(890, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "المسدد :";
            // 
            // TotalEznTXT
            // 
            this.TotalEznTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalEznTXT.BackColor = System.Drawing.SystemColors.Window;
            this.TotalEznTXT.Location = new System.Drawing.Point(987, 15);
            this.TotalEznTXT.Margin = new System.Windows.Forms.Padding(4);
            this.TotalEznTXT.Name = "TotalEznTXT";
            this.TotalEznTXT.ReadOnly = true;
            this.TotalEznTXT.Size = new System.Drawing.Size(183, 27);
            this.TotalEznTXT.TabIndex = 41;
            this.TotalEznTXT.Text = "0";
            this.TotalEznTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalEznTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalEznTXT_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(1174, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "اجمالي الاذن :";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.BackColor = System.Drawing.Color.Navy;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(714, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 34);
            this.label11.TabIndex = 18;
            this.label11.Text = "(لاغـــــــــــــي)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Visible = false;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // EznMortg3BillFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1753, 731);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EznMortg3BillFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EznMortg3BillFrm_Load);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Button NewBTN;
        internal System.Windows.Forms.Button ExitBtn;
        internal System.Windows.Forms.Button SearchBtn;
        internal System.Windows.Forms.Button DeleteBtn;
        internal System.Windows.Forms.Button EdietBtn;
        internal System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CustNameTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker EznDateTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EznNoTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TotalDontTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalDoneTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalEznTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BillSearchBTN;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityMortg3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemValue;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox BillNoTXT;
    }
}