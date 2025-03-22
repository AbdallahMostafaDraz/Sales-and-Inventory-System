namespace Sales01.Forms
{
    partial class SearchEznEstlamFrm
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
            this.Detalis = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EznNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EznDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAfterDriba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.groupBox2.Location = new System.Drawing.Point(234, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 123);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بــحــث فــي الاذون";
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.SystemColors.Control;
            this.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBTN.Location = new System.Drawing.Point(17, 85);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(95, 26);
            this.ExitBTN.TabIndex = 22;
            this.ExitBTN.Text = "رجــوع";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Button1);
            this.panel3.Controls.Add(this.D2);
            this.panel3.Controls.Add(this.Label1);
            this.panel3.Controls.Add(this.D1);
            this.panel3.Controls.Add(this.Label7);
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 39);
            this.panel3.TabIndex = 37;
            this.panel3.Visible = false;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(14, 8);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(90, 23);
            this.Button1.TabIndex = 77;
            this.Button1.Text = "بحث";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // D2
            // 
            this.D2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D2.Location = new System.Drawing.Point(133, 8);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(138, 27);
            this.D2.TabIndex = 76;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(275, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(104, 21);
            this.Label1.TabIndex = 75;
            this.Label1.Text = "حتى تاريخ :";
            // 
            // D1
            // 
            this.D1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D1.Location = new System.Drawing.Point(355, 9);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(137, 27);
            this.D1.TabIndex = 74;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(498, 11);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(89, 21);
            this.Label7.TabIndex = 73;
            this.Label7.Text = "من تاريخ :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(17, 56);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(544, 27);
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
            "بـــرقم الاذن",
            "بــــتاريخ الاذن",
            "بـــاسم المورد"});
            this.comboBox2.Location = new System.Drawing.Point(582, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 27);
            this.comboBox2.TabIndex = 35;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(233, 113);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 234);
            this.panel1.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalis,
            this.EznNo,
            this.EznDate,
            this.VenName,
            this.TotalAfterDriba});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(18, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(713, 203);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // Detalis
            // 
            this.Detalis.HeaderText = "التفاصيل";
            this.Detalis.MinimumWidth = 6;
            this.Detalis.Name = "Detalis";
            this.Detalis.ReadOnly = true;
            this.Detalis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detalis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Detalis.Text = "";
            this.Detalis.Width = 125;
            // 
            // EznNo
            // 
            this.EznNo.DataPropertyName = "EznNo";
            this.EznNo.HeaderText = "رقم الاذن";
            this.EznNo.MinimumWidth = 6;
            this.EznNo.Name = "EznNo";
            this.EznNo.ReadOnly = true;
            this.EznNo.Width = 130;
            // 
            // EznDate
            // 
            this.EznDate.DataPropertyName = "EznDate";
            this.EznDate.HeaderText = "تاريخ الاذن";
            this.EznDate.MinimumWidth = 6;
            this.EznDate.Name = "EznDate";
            this.EznDate.ReadOnly = true;
            this.EznDate.Width = 130;
            // 
            // VenName
            // 
            this.VenName.DataPropertyName = "VenName";
            this.VenName.HeaderText = "اسم المورد";
            this.VenName.MinimumWidth = 6;
            this.VenName.Name = "VenName";
            this.VenName.ReadOnly = true;
            this.VenName.Width = 180;
            // 
            // TotalAfterDriba
            // 
            this.TotalAfterDriba.DataPropertyName = "TotalAfterDriba";
            this.TotalAfterDriba.HeaderText = "الاجمالي";
            this.TotalAfterDriba.MinimumWidth = 6;
            this.TotalAfterDriba.Name = "TotalAfterDriba";
            this.TotalAfterDriba.ReadOnly = true;
            this.TotalAfterDriba.Width = 130;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(9, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 46);
            this.panel2.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(156, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(890, 33);
            this.label12.TabIndex = 1;
            this.label12.Text = "الـــــــــــــــــبــــــــــــــحــــــــــــــث فــي اذون الاســــــــــتـــــ" +
    "ـــــــــلام";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // SearchEznEstlamFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 568);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchEznEstlamFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SearchEznEstlamFrm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewButtonColumn Detalis;
        private System.Windows.Forms.DataGridViewTextBoxColumn EznNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EznDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAfterDriba;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        internal System.Windows.Forms.Button ExitBTN;
    }
}