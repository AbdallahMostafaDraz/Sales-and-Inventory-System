namespace Sales01.Forms
{
    partial class SearchEstlamMali
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.D2 = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.D1 = new System.Windows.Forms.DateTimePicker();
            this.Label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detalis = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EznNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EznDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EznValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.ExitBTN);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Location = new System.Drawing.Point(218, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 131);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بحث";
            // 
            // ExitBTN
            // 
            this.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBTN.Location = new System.Drawing.Point(46, 98);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(93, 26);
            this.ExitBTN.TabIndex = 38;
            this.ExitBTN.Text = "رجــوع";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Button1);
            this.panel3.Controls.Add(this.D2);
            this.panel3.Controls.Add(this.Label1);
            this.panel3.Controls.Add(this.D1);
            this.panel3.Controls.Add(this.Label7);
            this.panel3.Location = new System.Drawing.Point(42, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 39);
            this.panel3.TabIndex = 37;
            this.panel3.Visible = false;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(7, 8);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(90, 23);
            this.Button1.TabIndex = 79;
            this.Button1.Text = "بحث";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // D2
            // 
            this.D2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D2.Location = new System.Drawing.Point(124, 8);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(139, 27);
            this.D2.TabIndex = 76;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(267, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 21);
            this.Label1.TabIndex = 75;
            this.Label1.Text = "حتى :";
            // 
            // D1
            // 
            this.D1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D1.Location = new System.Drawing.Point(322, 9);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(137, 27);
            this.D1.TabIndex = 74;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(465, 11);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(45, 21);
            this.Label7.TabIndex = 73;
            this.Label7.Text = "من :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(43, 68);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(380, 27);
            this.textBox5.TabIndex = 36;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "بــرقم الاذن",
            "بــتاريخ الاذن"});
            this.comboBox2.Location = new System.Drawing.Point(437, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(113, 27);
            this.comboBox2.TabIndex = 35;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(218, 131);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 284);
            this.panel1.TabIndex = 41;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalis,
            this.EznNo,
            this.EznDate,
            this.EznValue});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(23, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(553, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // detalis
            // 
            this.detalis.HeaderText = "التفاصيل";
            this.detalis.MinimumWidth = 6;
            this.detalis.Name = "detalis";
            this.detalis.ReadOnly = true;
            this.detalis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detalis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.detalis.Width = 125;
            // 
            // EznNo
            // 
            this.EznNo.DataPropertyName = "EznNo";
            this.EznNo.HeaderText = "رقم الاذن";
            this.EznNo.MinimumWidth = 6;
            this.EznNo.Name = "EznNo";
            this.EznNo.ReadOnly = true;
            this.EznNo.Width = 135;
            // 
            // EznDate
            // 
            this.EznDate.DataPropertyName = "EznDate";
            this.EznDate.HeaderText = "تاريخ الاذن";
            this.EznDate.MinimumWidth = 6;
            this.EznDate.Name = "EznDate";
            this.EznDate.ReadOnly = true;
            this.EznDate.Width = 135;
            // 
            // EznValue
            // 
            this.EznValue.DataPropertyName = "EznValue";
            this.EznValue.HeaderText = "قيمة الاذن";
            this.EznValue.MinimumWidth = 6;
            this.EznValue.Name = "EznValue";
            this.EznValue.ReadOnly = true;
            this.EznValue.Width = 140;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(14, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 64);
            this.panel2.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(283, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(464, 33);
            this.label12.TabIndex = 1;
            this.label12.Text = "اســتـــعــــلام عـــن اذن اســـتــــلام";
            // 
            // SearchEstlamMali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 606);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchEstlamMali";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SearchEstlamMali_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button ExitBTN;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.DateTimePicker D2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker D1;
        internal System.Windows.Forms.Label Label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn detalis;
        private System.Windows.Forms.DataGridViewTextBoxColumn EznNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EznDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EznValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
    }
}