namespace Sales01.Forms
{
    partial class EstlamMaliFrm
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
            this.OtherCheck = new System.Windows.Forms.RadioButton();
            this.VenCheck = new System.Windows.Forms.RadioButton();
            this.CustCheck = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.NameCOMBO = new System.Windows.Forms.ComboBox();
            this.CodeCOMBO = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ShekDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.EznPriceTXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EznTypeTXT = new System.Windows.Forms.ComboBox();
            this.EznDateTXT = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BankNameTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EznNotesTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ShekNoTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EznNoTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.EdietBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.OtherCheck);
            this.groupBox1.Controls.Add(this.VenCheck);
            this.groupBox1.Controls.Add(this.CustCheck);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(11, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1762, 66);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نـــوع الـحـركـــة ";
            // 
            // OtherCheck
            // 
            this.OtherCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OtherCheck.AutoSize = true;
            this.OtherCheck.Location = new System.Drawing.Point(502, 26);
            this.OtherCheck.Name = "OtherCheck";
            this.OtherCheck.Size = new System.Drawing.Size(125, 25);
            this.OtherCheck.TabIndex = 2;
            this.OtherCheck.TabStop = true;
            this.OtherCheck.Text = "أخــــــــــرى";
            this.OtherCheck.UseVisualStyleBackColor = true;
            this.OtherCheck.CheckedChanged += new System.EventHandler(this.OtherChek_CheckedChanged);
            // 
            // VenCheck
            // 
            this.VenCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VenCheck.AutoSize = true;
            this.VenCheck.Location = new System.Drawing.Point(776, 26);
            this.VenCheck.Name = "VenCheck";
            this.VenCheck.Size = new System.Drawing.Size(212, 25);
            this.VenCheck.TabIndex = 1;
            this.VenCheck.TabStop = true;
            this.VenCheck.Text = "اســتـــلام مــن مــــورد";
            this.VenCheck.UseVisualStyleBackColor = true;
            this.VenCheck.CheckedChanged += new System.EventHandler(this.VenChek_CheckedChanged);
            // 
            // CustCheck
            // 
            this.CustCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CustCheck.AutoSize = true;
            this.CustCheck.Location = new System.Drawing.Point(1137, 26);
            this.CustCheck.Name = "CustCheck";
            this.CustCheck.Size = new System.Drawing.Size(259, 25);
            this.CustCheck.TabIndex = 0;
            this.CustCheck.TabStop = true;
            this.CustCheck.Text = "اســـتـــلام مـــن عـــمـــيــــل";
            this.CustCheck.UseVisualStyleBackColor = true;
            this.CustCheck.CheckedChanged += new System.EventHandler(this.CustChek_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(13, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1760, 78);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox11.Image = global::Sales.Properties.Resources.money_transfer_100px;
            this.pictureBox11.Location = new System.Drawing.Point(586, -13);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(100, 100);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 16;
            this.pictureBox11.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(717, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(586, 33);
            this.label12.TabIndex = 1;
            this.label12.Text = "اذن اســـــــــتــــــــــلام مـــــــــــــالـــــــــــــي";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.NameCOMBO);
            this.panel1.Controls.Add(this.CodeCOMBO);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.ShekDate);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.EznPriceTXT);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.EznTypeTXT);
            this.panel1.Controls.Add(this.EznDateTXT);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BankNameTXT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EznNotesTXT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ShekNoTXT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EznNoTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(618, 256);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 349);
            this.panel1.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Navy;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(116, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(323, 35);
            this.label11.TabIndex = 18;
            this.label11.Text = "(اذن مــــــلــــــغــــــي)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Visible = false;
            // 
            // NameCOMBO
            // 
            this.NameCOMBO.FormattingEnabled = true;
            this.NameCOMBO.Location = new System.Drawing.Point(15, 126);
            this.NameCOMBO.Name = "NameCOMBO";
            this.NameCOMBO.Size = new System.Drawing.Size(318, 27);
            this.NameCOMBO.TabIndex = 34;
            this.NameCOMBO.TextUpdate += new System.EventHandler(this.NameCOMBO_TextUpdate);
            this.NameCOMBO.TextChanged += new System.EventHandler(this.NameCOMBO_TextChanged);
            this.NameCOMBO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameCOMBO_KeyDown);
            // 
            // CodeCOMBO
            // 
            this.CodeCOMBO.FormattingEnabled = true;
            this.CodeCOMBO.Location = new System.Drawing.Point(339, 126);
            this.CodeCOMBO.Name = "CodeCOMBO";
            this.CodeCOMBO.Size = new System.Drawing.Size(192, 27);
            this.CodeCOMBO.TabIndex = 33;
            this.CodeCOMBO.TextUpdate += new System.EventHandler(this.CodeCOMBO_TextUpdate);
            this.CodeCOMBO.TextChanged += new System.EventHandler(this.CodeCOMBO_TextChanged);
            this.CodeCOMBO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeCOMBO_KeyDown);
            this.CodeCOMBO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeCOMBO_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(579, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 21);
            this.label14.TabIndex = 32;
            this.label14.Text = "اسم البنك :";
            // 
            // ShekDate
            // 
            this.ShekDate.Location = new System.Drawing.Point(17, 168);
            this.ShekDate.Name = "ShekDate";
            this.ShekDate.Size = new System.Drawing.Size(190, 27);
            this.ShekDate.TabIndex = 31;
            this.ShekDate.ValueChanged += new System.EventHandler(this.ShekDate_ValueChanged);
            this.ShekDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShekDate_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(207, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 21);
            this.label13.TabIndex = 30;
            this.label13.Text = "تاريخ الاستحقاق :";
            // 
            // EznPriceTXT
            // 
            this.EznPriceTXT.Location = new System.Drawing.Point(341, 77);
            this.EznPriceTXT.Name = "EznPriceTXT";
            this.EznPriceTXT.Size = new System.Drawing.Size(190, 27);
            this.EznPriceTXT.TabIndex = 29;
            this.EznPriceTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EznPriceTXT.TextChanged += new System.EventHandler(this.EznPriceTXT_TextChanged);
            this.EznPriceTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EznPriceTXT_KeyDown);
            this.EznPriceTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EznPriceTXT_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(532, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "قيمة اذن الاستلام :";
            // 
            // EznTypeTXT
            // 
            this.EznTypeTXT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EznTypeTXT.FormattingEnabled = true;
            this.EznTypeTXT.Items.AddRange(new object[] {
            "نقدي",
            "شيك"});
            this.EznTypeTXT.Location = new System.Drawing.Point(15, 79);
            this.EznTypeTXT.Name = "EznTypeTXT";
            this.EznTypeTXT.Size = new System.Drawing.Size(192, 27);
            this.EznTypeTXT.TabIndex = 27;
            this.EznTypeTXT.SelectedIndexChanged += new System.EventHandler(this.EznTypeTXT_SelectedIndexChanged);
            this.EznTypeTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EznTypeTXT_KeyDown);
            this.EznTypeTXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EznTypeTXT_KeyUp);
            this.EznTypeTXT.Leave += new System.EventHandler(this.EznTypeTXT_Leave);
            // 
            // EznDateTXT
            // 
            this.EznDateTXT.Location = new System.Drawing.Point(17, 33);
            this.EznDateTXT.Name = "EznDateTXT";
            this.EznDateTXT.Size = new System.Drawing.Size(190, 27);
            this.EznDateTXT.TabIndex = 26;
            this.EznDateTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EznDateTXT_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(577, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "استلام من :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(574, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "رقم الشيك :";
            // 
            // BankNameTXT
            // 
            this.BankNameTXT.Location = new System.Drawing.Point(15, 218);
            this.BankNameTXT.Name = "BankNameTXT";
            this.BankNameTXT.Size = new System.Drawing.Size(516, 27);
            this.BankNameTXT.TabIndex = 12;
            this.BankNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BankNameTXT.TextChanged += new System.EventHandler(this.BankNameTXT_TextChanged);
            this.BankNameTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankNameTXT_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(597, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "الـبـيـان :";
            // 
            // EznNotesTXT
            // 
            this.EznNotesTXT.Location = new System.Drawing.Point(15, 264);
            this.EznNotesTXT.Name = "EznNotesTXT";
            this.EznNotesTXT.Size = new System.Drawing.Size(516, 27);
            this.EznNotesTXT.TabIndex = 10;
            this.EznNotesTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EznNotesTXT.TextChanged += new System.EventHandler(this.EznNotesTXT_TextChanged);
            this.EznNotesTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EznNotesTXT_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(232, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "طريقة الدفع :";
            // 
            // ShekNoTXT
            // 
            this.ShekNoTXT.Location = new System.Drawing.Point(341, 170);
            this.ShekNoTXT.Name = "ShekNoTXT";
            this.ShekNoTXT.Size = new System.Drawing.Size(190, 27);
            this.ShekNoTXT.TabIndex = 8;
            this.ShekNoTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ShekNoTXT.TextChanged += new System.EventHandler(this.ShekNoTXT_TextChanged);
            this.ShekNoTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShekNoTXT_KeyDown);
            this.ShekNoTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShekNoTXT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(256, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "الـتـاريـخ :";
            // 
            // EznNoTXT
            // 
            this.EznNoTXT.Location = new System.Drawing.Point(341, 33);
            this.EznNoTXT.Name = "EznNoTXT";
            this.EznNoTXT.Size = new System.Drawing.Size(190, 27);
            this.EznNoTXT.TabIndex = 1;
            this.EznNoTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EznNoTXT.TextChanged += new System.EventHandler(this.EznNoTXT_TextChanged);
            this.EznNoTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EznNoTXT_KeyDown);
            this.EznNoTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EznNoTXT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(539, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم اذن الاستلام :";
            // 
            // NewBTN
            // 
            this.NewBTN.BackColor = System.Drawing.SystemColors.Control;
            this.NewBTN.ForeColor = System.Drawing.Color.Navy;
            this.NewBTN.Location = new System.Drawing.Point(554, 12);
            this.NewBTN.Name = "NewBTN";
            this.NewBTN.Size = new System.Drawing.Size(113, 42);
            this.NewBTN.TabIndex = 5;
            this.NewBTN.Text = "اذن جــديــد";
            this.NewBTN.UseVisualStyleBackColor = false;
            this.NewBTN.Click += new System.EventHandler(this.NewBTN_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SaveBTN.ForeColor = System.Drawing.Color.Navy;
            this.SaveBTN.Location = new System.Drawing.Point(447, 12);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(103, 42);
            this.SaveBTN.TabIndex = 6;
            this.SaveBTN.Text = "حــفــظ الاذن";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.SystemColors.Control;
            this.ExitBTN.ForeColor = System.Drawing.Color.Navy;
            this.ExitBTN.Location = new System.Drawing.Point(19, 12);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(103, 42);
            this.ExitBTN.TabIndex = 9;
            this.ExitBTN.Text = "رجوع";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DeleteBTN);
            this.panel3.Controls.Add(this.EdietBTN);
            this.panel3.Controls.Add(this.SearchBTN);
            this.panel3.Controls.Add(this.ExitBTN);
            this.panel3.Controls.Add(this.SaveBTN);
            this.panel3.Controls.Add(this.NewBTN);
            this.panel3.Location = new System.Drawing.Point(620, 624);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 69);
            this.panel3.TabIndex = 9;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBTN.ForeColor = System.Drawing.Color.Navy;
            this.DeleteBTN.Location = new System.Drawing.Point(126, 12);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(103, 42);
            this.DeleteBTN.TabIndex = 12;
            this.DeleteBTN.Text = "حـذف الاذن";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // EdietBTN
            // 
            this.EdietBTN.BackColor = System.Drawing.SystemColors.Control;
            this.EdietBTN.ForeColor = System.Drawing.Color.Navy;
            this.EdietBTN.Location = new System.Drawing.Point(233, 13);
            this.EdietBTN.Name = "EdietBTN";
            this.EdietBTN.Size = new System.Drawing.Size(103, 42);
            this.EdietBTN.TabIndex = 11;
            this.EdietBTN.Text = "تـعـديـل الاذن";
            this.EdietBTN.UseVisualStyleBackColor = false;
            this.EdietBTN.Click += new System.EventHandler(this.EdietBTN_Click);
            // 
            // SearchBTN
            // 
            this.SearchBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SearchBTN.ForeColor = System.Drawing.Color.Navy;
            this.SearchBTN.Location = new System.Drawing.Point(340, 12);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(103, 42);
            this.SearchBTN.TabIndex = 10;
            this.SearchBTN.Text = "بـحـث";
            this.SearchBTN.UseVisualStyleBackColor = false;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // EstlamMaliFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1785, 699);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EstlamMaliFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EstlamMaliFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OtherCheck;
        private System.Windows.Forms.RadioButton VenCheck;
        private System.Windows.Forms.RadioButton CustCheck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox NameCOMBO;
        private System.Windows.Forms.ComboBox CodeCOMBO;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker ShekDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox EznPriceTXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox EznTypeTXT;
        private System.Windows.Forms.DateTimePicker EznDateTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BankNameTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EznNotesTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ShekNoTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EznNoTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewBTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button EdietBTN;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}