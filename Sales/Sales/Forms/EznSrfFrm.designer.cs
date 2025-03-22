namespace Sales01.Forms
{
    partial class EznSrfFrm
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
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustNameTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BillNoTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BillSearchBTN = new System.Windows.Forms.Button();
            this.EznDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.EznNoTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NewBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.EdietBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityDont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(12, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1778, 95);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox6.Image = global::Sales.Properties.Resources.paid_bill_64px;
            this.pictureBox6.Location = new System.Drawing.Point(583, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 71);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(667, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(598, 33);
            this.label12.TabIndex = 1;
            this.label12.Text = "اذن صــــــــــــــــــرف أصــــــــــنـــــــــــــــــــاف";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.BackColor = System.Drawing.Color.Navy;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(878, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 34);
            this.label11.TabIndex = 4;
            this.label11.Text = "(لاغـــــــــــــي)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CustNameTXT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BillNoTXT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BillSearchBTN);
            this.panel1.Controls.Add(this.EznDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EznNoTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(531, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 98);
            this.panel1.TabIndex = 9;
            // 
            // CustNameTXT
            // 
            this.CustNameTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CustNameTXT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustNameTXT.Location = new System.Drawing.Point(48, 51);
            this.CustNameTXT.Margin = new System.Windows.Forms.Padding(4);
            this.CustNameTXT.Name = "CustNameTXT";
            this.CustNameTXT.ReadOnly = true;
            this.CustNameTXT.Size = new System.Drawing.Size(181, 27);
            this.CustNameTXT.TabIndex = 42;
            this.CustNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustNameTXT.TextChanged += new System.EventHandler(this.CustNameTXT_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(230, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "اسـم الـعـمـيـل :";
            // 
            // BillNoTXT
            // 
            this.BillNoTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BillNoTXT.Location = new System.Drawing.Point(425, 54);
            this.BillNoTXT.Margin = new System.Windows.Forms.Padding(4);
            this.BillNoTXT.Name = "BillNoTXT";
            this.BillNoTXT.Size = new System.Drawing.Size(181, 27);
            this.BillNoTXT.TabIndex = 40;
            this.BillNoTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BillNoTXT.TextChanged += new System.EventHandler(this.BillNoTXT_TextChanged);
            this.BillNoTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BillNoTXT_KeyDown);
            this.BillNoTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BillNoTXT_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(614, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "رقـم الـفـاتـورة :";
            // 
            // BillSearchBTN
            // 
            this.BillSearchBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BillSearchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BillSearchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillSearchBTN.Image = global::Sales.Properties.Resources.search_property_24px;
            this.BillSearchBTN.Location = new System.Drawing.Point(363, 54);
            this.BillSearchBTN.Name = "BillSearchBTN";
            this.BillSearchBTN.Size = new System.Drawing.Size(42, 25);
            this.BillSearchBTN.TabIndex = 38;
            this.toolTip1.SetToolTip(this.BillSearchBTN, "البحث عن الفاتورة");
            this.BillSearchBTN.UseVisualStyleBackColor = true;
            this.BillSearchBTN.Click += new System.EventHandler(this.BillSearchTXT_Click);
            this.BillSearchBTN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BillSearchBTN_KeyDown);
            // 
            // EznDate
            // 
            this.EznDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EznDate.Location = new System.Drawing.Point(48, 15);
            this.EznDate.Name = "EznDate";
            this.EznDate.Size = new System.Drawing.Size(181, 27);
            this.EznDate.TabIndex = 28;
            this.EznDate.ValueChanged += new System.EventHandler(this.EznDate_ValueChanged);
            this.EznDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EznDate_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(237, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "تـاريخ الاذن :";
            // 
            // EznNoTXT
            // 
            this.EznNoTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EznNoTXT.Location = new System.Drawing.Point(425, 17);
            this.EznNoTXT.Margin = new System.Windows.Forms.Padding(4);
            this.EznNoTXT.Name = "EznNoTXT";
            this.EznNoTXT.Size = new System.Drawing.Size(181, 27);
            this.EznNoTXT.TabIndex = 1;
            this.EznNoTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EznNoTXT.TextChanged += new System.EventHandler(this.EznNoTXT_TextChanged);
            this.EznNoTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EznNoTXT_KeyDown);
            this.EznNoTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EznNoTXT_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(614, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقـم اذن الـصـرف :";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.NewBTN);
            this.panel5.Controls.Add(this.ExitBTN);
            this.panel5.Controls.Add(this.SearchBTN);
            this.panel5.Controls.Add(this.DeleteBTN);
            this.panel5.Controls.Add(this.EdietBTN);
            this.panel5.Controls.Add(this.SaveBTN);
            this.panel5.Location = new System.Drawing.Point(531, 546);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(809, 77);
            this.panel5.TabIndex = 11;
            // 
            // NewBTN
            // 
            this.NewBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NewBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBTN.Location = new System.Drawing.Point(685, 18);
            this.NewBTN.Name = "NewBTN";
            this.NewBTN.Size = new System.Drawing.Size(114, 42);
            this.NewBTN.TabIndex = 22;
            this.NewBTN.Text = "اذن جــديـــد";
            this.NewBTN.UseVisualStyleBackColor = true;
            this.NewBTN.Click += new System.EventHandler(this.Btn_new_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBTN.Location = new System.Drawing.Point(11, 18);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(114, 41);
            this.ExitBTN.TabIndex = 21;
            this.ExitBTN.Text = "اغلاق";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // SearchBTN
            // 
            this.SearchBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBTN.Location = new System.Drawing.Point(412, 18);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(114, 41);
            this.SearchBTN.TabIndex = 20;
            this.SearchBTN.Text = "بحث";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBTN.Location = new System.Drawing.Point(145, 18);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(114, 41);
            this.DeleteBTN.TabIndex = 19;
            this.DeleteBTN.Text = "الغاء الاذن";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // EdietBTN
            // 
            this.EdietBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EdietBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EdietBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdietBTN.Location = new System.Drawing.Point(278, 18);
            this.EdietBTN.Name = "EdietBTN";
            this.EdietBTN.Size = new System.Drawing.Size(114, 41);
            this.EdietBTN.TabIndex = 18;
            this.EdietBTN.Text = "تعديل";
            this.EdietBTN.UseVisualStyleBackColor = true;
            this.EdietBTN.Click += new System.EventHandler(this.EdietBTN_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBTN.Location = new System.Drawing.Point(548, 18);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(114, 42);
            this.SaveBTN.TabIndex = 17;
            this.SaveBTN.Text = "حفظ";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(303, 250);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(207, 21);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اضافة أصناف اخرى للاذن";
            this.toolTip1.SetToolTip(this.linkLabel1, "لاضافة أصناف اخرى لم تصرف من الفاتورة لاذن الصرف");
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
            this.QuantityDont,
            this.QuantityDone});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(783, 232);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "كود الصنف";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemCode.Width = 120;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "اسم الصنف";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemName.Width = 220;
            // 
            // MainQuantity
            // 
            this.MainQuantity.HeaderText = "الكمية المباعة";
            this.MainQuantity.MinimumWidth = 6;
            this.MainQuantity.Name = "MainQuantity";
            this.MainQuantity.ReadOnly = true;
            this.MainQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MainQuantity.Width = 130;
            // 
            // QuantityDont
            // 
            this.QuantityDont.HeaderText = "تم صرفها";
            this.QuantityDont.MinimumWidth = 6;
            this.QuantityDont.Name = "QuantityDont";
            this.QuantityDont.ReadOnly = true;
            this.QuantityDont.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.QuantityDont.Width = 130;
            // 
            // QuantityDone
            // 
            this.QuantityDone.HeaderText = "الكمية المصروفة";
            this.QuantityDone.MinimumWidth = 6;
            this.QuantityDone.Name = "QuantityDone";
            this.QuantityDone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.QuantityDone.Width = 140;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Location = new System.Drawing.Point(530, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 276);
            this.panel3.TabIndex = 12;
            // 
            // EznSrfFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1802, 726);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EznSrfFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EznSrfFrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BillSearchBTN;
        private System.Windows.Forms.DateTimePicker EznDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustNameTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Button NewBTN;
        internal System.Windows.Forms.Button ExitBTN;
        internal System.Windows.Forms.Button SearchBTN;
        internal System.Windows.Forms.Button DeleteBTN;
        internal System.Windows.Forms.Button EdietBTN;
        internal System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.TextBox BillNoTXT;
        public System.Windows.Forms.TextBox EznNoTXT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityDont;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityDone;
    }
}