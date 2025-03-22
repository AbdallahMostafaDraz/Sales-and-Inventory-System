namespace Sales01.Forms
{
    partial class MainItems
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.PriceInputTXT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTXT = new System.Windows.Forms.TextBox();
            this.CompanyTXT = new System.Windows.Forms.TextBox();
            this.MainNameTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MainCodeTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NewBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.EdietBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.PriceInputTXT);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PriceTXT);
            this.panel1.Controls.Add(this.CompanyTXT);
            this.panel1.Controls.Add(this.MainNameTXT);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MainCodeTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(370, 125);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 458);
            this.panel1.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(774, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 21);
            this.label13.TabIndex = 31;
            this.label13.Text = "سـعـر الـشـراء :";
            // 
            // PriceInputTXT
            // 
            this.PriceInputTXT.Location = new System.Drawing.Point(493, 134);
            this.PriceInputTXT.Name = "PriceInputTXT";
            this.PriceInputTXT.Size = new System.Drawing.Size(257, 27);
            this.PriceInputTXT.TabIndex = 30;
            this.PriceInputTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceInputTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PriceInputTXT_KeyDown);
            this.PriceInputTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceInputTXT_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddBTN);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(72, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 208);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مــــكـــــــونــــــــــات الــــــــعــــــــرض :";
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(731, 20);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(48, 181);
            this.AddBTN.TabIndex = 1;
            this.AddBTN.Text = "+";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.button1_Click);
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
            this.Delete});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(14, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(713, 180);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "كـــود الــصــنـــف";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemCode.Width = 285;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "اســـــــــم الــــــــصـــــــــنــــــــف";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemName.Width = 285;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "";
            this.Delete.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(360, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "ســعــر الــبـيــع :";
            // 
            // PriceTXT
            // 
            this.PriceTXT.Location = new System.Drawing.Point(83, 134);
            this.PriceTXT.Margin = new System.Windows.Forms.Padding(4);
            this.PriceTXT.Name = "PriceTXT";
            this.PriceTXT.Size = new System.Drawing.Size(256, 27);
            this.PriceTXT.TabIndex = 21;
            this.PriceTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceTXT.TextChanged += new System.EventHandler(this.PriceTXT_TextChanged);
            this.PriceTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PriceTXT_KeyDown);
            this.PriceTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTXT_KeyPress);
            // 
            // CompanyTXT
            // 
            this.CompanyTXT.Location = new System.Drawing.Point(81, 185);
            this.CompanyTXT.Margin = new System.Windows.Forms.Padding(4);
            this.CompanyTXT.Name = "CompanyTXT";
            this.CompanyTXT.Size = new System.Drawing.Size(665, 27);
            this.CompanyTXT.TabIndex = 20;
            this.CompanyTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CompanyTXT.TextChanged += new System.EventHandler(this.CompanyTXT_TextChanged);
            this.CompanyTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyTXT_KeyDown);
            // 
            // MainNameTXT
            // 
            this.MainNameTXT.Location = new System.Drawing.Point(83, 83);
            this.MainNameTXT.Margin = new System.Windows.Forms.Padding(4);
            this.MainNameTXT.Name = "MainNameTXT";
            this.MainNameTXT.Size = new System.Drawing.Size(257, 27);
            this.MainNameTXT.TabIndex = 19;
            this.MainNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MainNameTXT.TextChanged += new System.EventHandler(this.MainNameTXT_TextChanged);
            this.MainNameTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainNameTXT_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(769, 187);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "اسـم الـشـركـة :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(360, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "اسم العرض :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "صحي",
            "خلاطات"});
            this.comboBox1.Location = new System.Drawing.Point(83, 31);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(667, 27);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(766, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "كود العرض :";
            // 
            // MainCodeTXT
            // 
            this.MainCodeTXT.Location = new System.Drawing.Point(493, 83);
            this.MainCodeTXT.Margin = new System.Windows.Forms.Padding(4);
            this.MainCodeTXT.Name = "MainCodeTXT";
            this.MainCodeTXT.Size = new System.Drawing.Size(257, 27);
            this.MainCodeTXT.TabIndex = 1;
            this.MainCodeTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MainCodeTXT.TextChanged += new System.EventHandler(this.MainCodeTXT_TextChanged);
            this.MainCodeTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainCodeTXT_KeyDown);
            this.MainCodeTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainCodeTXT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(766, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "الـــــــنــــــــــوع :";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.NewBTN);
            this.panel3.Controls.Add(this.ExitBTN);
            this.panel3.Controls.Add(this.DeleteBTN);
            this.panel3.Controls.Add(this.EdietBTN);
            this.panel3.Controls.Add(this.SearchBTN);
            this.panel3.Controls.Add(this.SaveBTN);
            this.panel3.Location = new System.Drawing.Point(370, 590);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(991, 72);
            this.panel3.TabIndex = 4;
            // 
            // NewBTN
            // 
            this.NewBTN.BackColor = System.Drawing.SystemColors.Control;
            this.NewBTN.ForeColor = System.Drawing.Color.Navy;
            this.NewBTN.Location = new System.Drawing.Point(810, 13);
            this.NewBTN.Name = "NewBTN";
            this.NewBTN.Size = new System.Drawing.Size(166, 42);
            this.NewBTN.TabIndex = 10;
            this.NewBTN.Text = "جــديـــد";
            this.NewBTN.UseVisualStyleBackColor = false;
            this.NewBTN.Click += new System.EventHandler(this.NewBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.SystemColors.Control;
            this.ExitBTN.ForeColor = System.Drawing.Color.Navy;
            this.ExitBTN.Location = new System.Drawing.Point(13, 13);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(156, 42);
            this.ExitBTN.TabIndex = 9;
            this.ExitBTN.Text = "رجوع";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.button5_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBTN.ForeColor = System.Drawing.Color.Navy;
            this.DeleteBTN.Location = new System.Drawing.Point(168, 13);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(156, 42);
            this.DeleteBTN.TabIndex = 8;
            this.DeleteBTN.Text = "حذف صنف";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // EdietBTN
            // 
            this.EdietBTN.BackColor = System.Drawing.SystemColors.Control;
            this.EdietBTN.ForeColor = System.Drawing.Color.Navy;
            this.EdietBTN.Location = new System.Drawing.Point(327, 13);
            this.EdietBTN.Name = "EdietBTN";
            this.EdietBTN.Size = new System.Drawing.Size(156, 42);
            this.EdietBTN.TabIndex = 7;
            this.EdietBTN.Text = "تعديل صنف ";
            this.EdietBTN.UseVisualStyleBackColor = false;
            this.EdietBTN.Click += new System.EventHandler(this.EdietBTN_Click);
            // 
            // SearchBTN
            // 
            this.SearchBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SearchBTN.ForeColor = System.Drawing.Color.Navy;
            this.SearchBTN.Location = new System.Drawing.Point(485, 13);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(156, 42);
            this.SearchBTN.TabIndex = 6;
            this.SearchBTN.Text = "بحث في الأصناف";
            this.SearchBTN.UseVisualStyleBackColor = false;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SaveBTN.ForeColor = System.Drawing.Color.Navy;
            this.SaveBTN.Location = new System.Drawing.Point(643, 13);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(166, 42);
            this.SaveBTN.TabIndex = 5;
            this.SaveBTN.Text = "تسجيل صنف";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1686, 69);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Sales.Properties.Resources.checklist_50px;
            this.pictureBox1.Location = new System.Drawing.Point(497, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(580, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(641, 33);
            this.label12.TabIndex = 1;
            this.label12.Text = "بـــــــــــيـــــــــــــانـــــــــات الـــــــــــعــــــــــــروض";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // MainItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1708, 711);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainItems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainItems_Load);
            this.Leave += new System.EventHandler(this.MainItems_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceTXT;
        private System.Windows.Forms.TextBox CompanyTXT;
        private System.Windows.Forms.TextBox MainNameTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MainCodeTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button EdietBTN;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button NewBTN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PriceInputTXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}