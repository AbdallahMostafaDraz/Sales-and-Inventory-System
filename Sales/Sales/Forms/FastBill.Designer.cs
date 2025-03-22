namespace Sales.Forms
{
    partial class FastBill
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
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_BarCode = new System.Windows.Forms.TextBox();
            this.TotalBeforeDiscountTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.billtypeTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BillDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.BillNoTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalDiscountTXT = new System.Windows.Forms.TextBox();
            this.TotalAfterDiscountTXT = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NewBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.EdietBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DoneTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DontTXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1686, 99);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox5.Image = global::Sales.Properties.Resources.transaction_list_100px;
            this.pictureBox5.Location = new System.Drawing.Point(229, -7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(136, 101);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.BackColor = System.Drawing.Color.Navy;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(371, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1113, 31);
            this.label11.TabIndex = 3;
            this.label11.Text = "( الــفــاتـــورة مــلــغــيــة )";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Visible = false;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(588, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(753, 33);
            this.label12.TabIndex = 1;
            this.label12.Text = "مـــــــــــبيــــــــــــــــعــــــــــــات يـــــــــــومــــــــيــــــــــــ" +
    "ــة";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(5, 239);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1680, 319);
            this.panel3.TabIndex = 28;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.dataGridView1.Size = new System.Drawing.Size(1661, 294);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridView1_CellValuePushed);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
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
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.TotalBeforeDiscountTXT);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.billtypeTXT);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.BillDate);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.BillNoTXT);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.TotalDiscountTXT);
            this.panel4.Controls.Add(this.TotalAfterDiscountTXT);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Location = new System.Drawing.Point(5, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1683, 125);
            this.panel4.TabIndex = 30;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1306, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 21);
            this.label6.TabIndex = 117;
            this.label6.Text = "المطلوب سداده :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PictureBox1);
            this.groupBox1.Controls.Add(this.Txt_BarCode);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 114);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(14, 52);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(306, 47);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 21;
            this.PictureBox1.TabStop = false;
            // 
            // Txt_BarCode
            // 
            this.Txt_BarCode.BackColor = System.Drawing.Color.Linen;
            this.Txt_BarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_BarCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_BarCode.Location = new System.Drawing.Point(14, 27);
            this.Txt_BarCode.Name = "Txt_BarCode";
            this.Txt_BarCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_BarCode.Size = new System.Drawing.Size(307, 27);
            this.Txt_BarCode.TabIndex = 17;
            this.Txt_BarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_BarCode.TextChanged += new System.EventHandler(this.Txt_BarCode_TextChanged);
            this.Txt_BarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_BarCode_KeyPress);
            // 
            // TotalBeforeDiscountTXT
            // 
            this.TotalBeforeDiscountTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalBeforeDiscountTXT.BackColor = System.Drawing.SystemColors.Window;
            this.TotalBeforeDiscountTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBeforeDiscountTXT.Location = new System.Drawing.Point(355, 12);
            this.TotalBeforeDiscountTXT.Name = "TotalBeforeDiscountTXT";
            this.TotalBeforeDiscountTXT.ReadOnly = true;
            this.TotalBeforeDiscountTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalBeforeDiscountTXT.Size = new System.Drawing.Size(904, 27);
            this.TotalBeforeDiscountTXT.TabIndex = 115;
            this.TotalBeforeDiscountTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalBeforeDiscountTXT.TextChanged += new System.EventHandler(this.TotalBeforeDiscountTXT_TextChanged_1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1311, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 114;
            this.label3.Text = "إجمالي الفاتورة :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // billtypeTXT
            // 
            this.billtypeTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billtypeTXT.BackColor = System.Drawing.SystemColors.Window;
            this.billtypeTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billtypeTXT.ForeColor = System.Drawing.Color.BlueViolet;
            this.billtypeTXT.Location = new System.Drawing.Point(1432, 76);
            this.billtypeTXT.Name = "billtypeTXT";
            this.billtypeTXT.ReadOnly = true;
            this.billtypeTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.billtypeTXT.Size = new System.Drawing.Size(139, 27);
            this.billtypeTXT.TabIndex = 112;
            this.billtypeTXT.Text = "زبون عام";
            this.billtypeTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1587, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 111;
            this.label2.Text = "نوع الفاتورة :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BillDate
            // 
            this.BillDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillDate.Location = new System.Drawing.Point(1431, 44);
            this.BillDate.Name = "BillDate";
            this.BillDate.Size = new System.Drawing.Size(136, 26);
            this.BillDate.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(1582, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 109;
            this.label5.Text = "تاريخ الفاتورة :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BillNoTXT
            // 
            this.BillNoTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillNoTXT.BackColor = System.Drawing.SystemColors.Window;
            this.BillNoTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNoTXT.Location = new System.Drawing.Point(1430, 13);
            this.BillNoTXT.Name = "BillNoTXT";
            this.BillNoTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BillNoTXT.Size = new System.Drawing.Size(139, 27);
            this.BillNoTXT.TabIndex = 108;
            this.BillNoTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BillNoTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1585, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 107;
            this.label1.Text = "رقم الفاتورة :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TotalDiscountTXT
            // 
            this.TotalDiscountTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalDiscountTXT.BackColor = System.Drawing.SystemColors.Window;
            this.TotalDiscountTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDiscountTXT.Location = new System.Drawing.Point(356, 43);
            this.TotalDiscountTXT.Name = "TotalDiscountTXT";
            this.TotalDiscountTXT.ReadOnly = true;
            this.TotalDiscountTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalDiscountTXT.Size = new System.Drawing.Size(903, 27);
            this.TotalDiscountTXT.TabIndex = 106;
            this.TotalDiscountTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalDiscountTXT.TextChanged += new System.EventHandler(this.DoneTXT_TextChanged);
            // 
            // TotalAfterDiscountTXT
            // 
            this.TotalAfterDiscountTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAfterDiscountTXT.BackColor = System.Drawing.SystemColors.Window;
            this.TotalAfterDiscountTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAfterDiscountTXT.Location = new System.Drawing.Point(355, 75);
            this.TotalAfterDiscountTXT.Name = "TotalAfterDiscountTXT";
            this.TotalAfterDiscountTXT.ReadOnly = true;
            this.TotalAfterDiscountTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalAfterDiscountTXT.Size = new System.Drawing.Size(904, 27);
            this.TotalAfterDiscountTXT.TabIndex = 94;
            this.TotalAfterDiscountTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalAfterDiscountTXT.TextChanged += new System.EventHandler(this.TotalBeforeDiscountTXT_TextChanged);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1308, 47);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(140, 21);
            this.label21.TabIndex = 91;
            this.label21.Text = "اجمالي الخصم :";
            this.label21.Click += new System.EventHandler(this.label21_Click);
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
            this.panel5.Location = new System.Drawing.Point(6, 633);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1682, 60);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // NewBTN
            // 
            this.NewBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewBTN.BackColor = System.Drawing.SystemColors.Control;
            this.NewBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBTN.Location = new System.Drawing.Point(1138, 2);
            this.NewBTN.Name = "NewBTN";
            this.NewBTN.Size = new System.Drawing.Size(119, 44);
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
            this.ExitBTN.Location = new System.Drawing.Point(432, 3);
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
            this.SearchBTN.Location = new System.Drawing.Point(852, 3);
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
            this.DeleteBTN.Location = new System.Drawing.Point(571, 3);
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
            this.EdietBTN.Location = new System.Drawing.Point(713, 3);
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
            this.SaveBTN.Location = new System.Drawing.Point(993, 2);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(115, 44);
            this.SaveBTN.TabIndex = 17;
            this.SaveBTN.Text = "حفظ";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DoneTXT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DontTXT);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(5, 565);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1683, 61);
            this.panel1.TabIndex = 116;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DoneTXT
            // 
            this.DoneTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DoneTXT.BackColor = System.Drawing.SystemColors.Window;
            this.DoneTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneTXT.Location = new System.Drawing.Point(851, 18);
            this.DoneTXT.Name = "DoneTXT";
            this.DoneTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DoneTXT.Size = new System.Drawing.Size(316, 27);
            this.DoneTXT.TabIndex = 115;
            this.DoneTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DoneTXT.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1179, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 114;
            this.label4.Text = "المبلغ المسدد :";
            // 
            // DontTXT
            // 
            this.DontTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DontTXT.BackColor = System.Drawing.SystemColors.Window;
            this.DontTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DontTXT.Location = new System.Drawing.Point(358, 18);
            this.DontTXT.Name = "DontTXT";
            this.DontTXT.ReadOnly = true;
            this.DontTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DontTXT.Size = new System.Drawing.Size(318, 27);
            this.DontTXT.TabIndex = 104;
            this.DontTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DontTXT.TextChanged += new System.EventHandler(this.DontTXT_TextChanged_1);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(683, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 21);
            this.label10.TabIndex = 103;
            this.label10.Text = "المبلغ المتبقي :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // FastBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FastBill";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FastBill_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Button NewBTN;
        internal System.Windows.Forms.Button ExitBTN;
        internal System.Windows.Forms.Button SearchBTN;
        internal System.Windows.Forms.Button DeleteBTN;
        internal System.Windows.Forms.Button EdietBTN;
        internal System.Windows.Forms.Button SaveBTN;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.TextBox DoneTXT;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox DontTXT;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        internal System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TotalDiscountTXT;
        public System.Windows.Forms.TextBox TotalAfterDiscountTXT;
        public System.Windows.Forms.TextBox BillNoTXT;
        public System.Windows.Forms.DateTimePicker BillDate;
        public System.Windows.Forms.TextBox billtypeTXT;
        public System.Windows.Forms.TextBox TotalBeforeDiscountTXT;
        public System.Windows.Forms.PictureBox PictureBox1;
        public System.Windows.Forms.TextBox Txt_BarCode;
    }
}