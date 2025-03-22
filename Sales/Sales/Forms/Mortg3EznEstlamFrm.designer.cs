namespace Sales01.Forms
{
    partial class Mortg3EznEstlamFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityMortg3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BillSearchBTN = new System.Windows.Forms.Button();
            this.VenNameTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EznEstlamNoTXT = new System.Windows.Forms.TextBox();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.NewBTN = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EdietBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(408, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 348);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(425, 324);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(207, 21);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اضافة أصناف اخرى للاذن";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.MainQuantity,
            this.QuantityMortg3,
            this.ItemPrice,
            this.ItemValue});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(13, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(923, 300);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "كود الصنف";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 200;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "اسم الصنف";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 200;
            // 
            // MainQuantity
            // 
            this.MainQuantity.DataPropertyName = "MainQuantity";
            this.MainQuantity.HeaderText = "الوارد";
            this.MainQuantity.MinimumWidth = 6;
            this.MainQuantity.Name = "MainQuantity";
            this.MainQuantity.ReadOnly = true;
            this.MainQuantity.Width = 120;
            // 
            // QuantityMortg3
            // 
            this.QuantityMortg3.DataPropertyName = "QuantityMortg3";
            this.QuantityMortg3.HeaderText = "المرتجع";
            this.QuantityMortg3.MinimumWidth = 6;
            this.QuantityMortg3.Name = "QuantityMortg3";
            this.QuantityMortg3.Width = 120;
            // 
            // ItemPrice
            // 
            this.ItemPrice.HeaderText = "السعر";
            this.ItemPrice.MinimumWidth = 6;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            this.ItemPrice.Width = 120;
            // 
            // ItemValue
            // 
            this.ItemValue.HeaderText = "الاجمالي";
            this.ItemValue.MinimumWidth = 6;
            this.ItemValue.Name = "ItemValue";
            this.ItemValue.ReadOnly = true;
            this.ItemValue.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BillSearchBTN);
            this.panel1.Controls.Add(this.VenNameTXT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EznEstlamNoTXT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EznDateTXT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EznNoTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(409, 146);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 98);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BillSearchBTN
            // 
            this.BillSearchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BillSearchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillSearchBTN.Image = global::Sales.Properties.Resources.search_property_24px;
            this.BillSearchBTN.Location = new System.Drawing.Point(457, 53);
            this.BillSearchBTN.Name = "BillSearchBTN";
            this.BillSearchBTN.Size = new System.Drawing.Size(42, 26);
            this.BillSearchBTN.TabIndex = 44;
            this.BillSearchBTN.UseVisualStyleBackColor = true;
            this.BillSearchBTN.Click += new System.EventHandler(this.BillSearchBTN_Click);
            this.BillSearchBTN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BillSearchBTN_KeyPress);
            // 
            // VenNameTXT
            // 
            this.VenNameTXT.Location = new System.Drawing.Point(162, 54);
            this.VenNameTXT.Margin = new System.Windows.Forms.Padding(4);
            this.VenNameTXT.Name = "VenNameTXT";
            this.VenNameTXT.Size = new System.Drawing.Size(181, 27);
            this.VenNameTXT.TabIndex = 42;
            this.VenNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VenNameTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VenNameTXT_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(348, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "اسم المورد :";
            // 
            // EznEstlamNoTXT
            // 
            this.EznEstlamNoTXT.Location = new System.Drawing.Point(506, 55);
            this.EznEstlamNoTXT.Margin = new System.Windows.Forms.Padding(4);
            this.EznEstlamNoTXT.Name = "EznEstlamNoTXT";
            this.EznEstlamNoTXT.Size = new System.Drawing.Size(181, 27);
            this.EznEstlamNoTXT.TabIndex = 40;
            this.EznEstlamNoTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EznEstlamNoTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EznEstlamNoTXT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(692, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "رقم اذن الاستلام :";
            // 
            // EznDateTXT
            // 
            this.EznDateTXT.Location = new System.Drawing.Point(162, 18);
            this.EznDateTXT.Name = "EznDateTXT";
            this.EznDateTXT.Size = new System.Drawing.Size(181, 27);
            this.EznDateTXT.TabIndex = 28;
            this.EznDateTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EznDateTXT_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(351, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "تـاريخ الاذن :";
            // 
            // EznNoTXT
            // 
            this.EznNoTXT.Location = new System.Drawing.Point(506, 18);
            this.EznNoTXT.Margin = new System.Windows.Forms.Padding(4);
            this.EznNoTXT.Name = "EznNoTXT";
            this.EznNoTXT.Size = new System.Drawing.Size(181, 27);
            this.EznNoTXT.TabIndex = 1;
            this.EznNoTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EznNoTXT.TextChanged += new System.EventHandler(this.EznNoTXT_TextChanged);
            this.EznNoTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EznNoTXT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(695, 21);
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
            this.panel2.Location = new System.Drawing.Point(30, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1706, 78);
            this.panel2.TabIndex = 17;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox6.Image = global::Sales.Properties.Resources.icons8_return_purcddhase_32;
            this.pictureBox6.Location = new System.Drawing.Point(375, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(423, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(906, 33);
            this.label12.TabIndex = 1;
            this.label12.Text = "اذن مــــــــــــرتـــــــــــجــــــــــــــع مـــــــــــــشــــــــــتــــــــ" +
    "ــريــــــــــات";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TotalDontTXT);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.TotalDoneTXT);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TotalEznTXT);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(409, 608);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 51);
            this.panel3.TabIndex = 22;
            // 
            // TotalDontTXT
            // 
            this.TotalDontTXT.Location = new System.Drawing.Point(71, 14);
            this.TotalDontTXT.Margin = new System.Windows.Forms.Padding(4);
            this.TotalDontTXT.Name = "TotalDontTXT";
            this.TotalDontTXT.Size = new System.Drawing.Size(179, 27);
            this.TotalDontTXT.TabIndex = 45;
            this.TotalDontTXT.Text = "0";
            this.TotalDontTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalDontTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalDontTXT_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(251, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 44;
            this.label7.Text = "المتبقي :";
            // 
            // TotalDoneTXT
            // 
            this.TotalDoneTXT.Location = new System.Drawing.Point(336, 15);
            this.TotalDoneTXT.Margin = new System.Windows.Forms.Padding(4);
            this.TotalDoneTXT.Name = "TotalDoneTXT";
            this.TotalDoneTXT.Size = new System.Drawing.Size(179, 27);
            this.TotalDoneTXT.TabIndex = 43;
            this.TotalDoneTXT.Text = "0";
            this.TotalDoneTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalDoneTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalDoneTXT_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(515, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "المسدد :";
            // 
            // TotalEznTXT
            // 
            this.TotalEznTXT.Location = new System.Drawing.Point(593, 14);
            this.TotalEznTXT.Margin = new System.Windows.Forms.Padding(4);
            this.TotalEznTXT.Name = "TotalEznTXT";
            this.TotalEznTXT.Size = new System.Drawing.Size(179, 27);
            this.TotalEznTXT.TabIndex = 41;
            this.TotalEznTXT.Text = "0";
            this.TotalEznTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalEznTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalEznTXT_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(774, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "اجمالي الاذن :";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.NewBTN);
            this.panel5.Controls.Add(this.ExitBtn);
            this.panel5.Controls.Add(this.SearchBtn);
            this.panel5.Controls.Add(this.DeleteBtn);
            this.panel5.Controls.Add(this.EdietBtn);
            this.panel5.Controls.Add(this.SaveBtn);
            this.panel5.Location = new System.Drawing.Point(409, 665);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(945, 71);
            this.panel5.TabIndex = 23;
            // 
            // NewBTN
            // 
            this.NewBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBTN.Location = new System.Drawing.Point(756, 12);
            this.NewBTN.Name = "NewBTN";
            this.NewBTN.Size = new System.Drawing.Size(122, 39);
            this.NewBTN.TabIndex = 22;
            this.NewBTN.Text = "اذن جــديـــد";
            this.NewBTN.UseVisualStyleBackColor = true;
            this.NewBTN.Click += new System.EventHandler(this.NewBTN_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(64, 13);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(122, 38);
            this.ExitBtn.TabIndex = 21;
            this.ExitBtn.Text = "اغلاق";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(480, 13);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(122, 38);
            this.SearchBtn.TabIndex = 20;
            this.SearchBtn.Text = "بحث";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(205, 13);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(122, 38);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "الغاء الاذن";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EdietBtn
            // 
            this.EdietBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EdietBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdietBtn.Location = new System.Drawing.Point(344, 13);
            this.EdietBtn.Name = "EdietBtn";
            this.EdietBtn.Size = new System.Drawing.Size(122, 38);
            this.EdietBtn.TabIndex = 18;
            this.EdietBtn.Text = "تعديل";
            this.EdietBtn.UseVisualStyleBackColor = true;
            this.EdietBtn.Click += new System.EventHandler(this.EdietBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(620, 12);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(122, 39);
            this.SaveBtn.TabIndex = 17;
            this.SaveBtn.Text = "حفظ";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.BackColor = System.Drawing.Color.Navy;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(751, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 34);
            this.label11.TabIndex = 24;
            this.label11.Text = "(لاغـــــــــــــي)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // Mortg3EznEstlamFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1765, 750);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mortg3EznEstlamFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mortg3EznEstlamFrm_Load);
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
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox VenNameTXT;
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
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button BillSearchBTN;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Button NewBTN;
        internal System.Windows.Forms.Button ExitBtn;
        internal System.Windows.Forms.Button SearchBtn;
        internal System.Windows.Forms.Button DeleteBtn;
        internal System.Windows.Forms.Button EdietBtn;
        internal System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityMortg3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemValue;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox EznEstlamNoTXT;
    }
}