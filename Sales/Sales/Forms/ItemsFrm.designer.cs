namespace Sales01.Forms
{
    partial class ItemsFrm
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.PriceInputTXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.StrartQuantityTXT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NotesTXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PricreTXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MetreTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FrzTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SizeTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ColorTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CompanyTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTXT = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodeTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NewBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.EdietBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.label13);
            this.Panel1.Controls.Add(this.PriceInputTXT);
            this.Panel1.Controls.Add(this.label10);
            this.Panel1.Controls.Add(this.StrartQuantityTXT);
            this.Panel1.Controls.Add(this.label11);
            this.Panel1.Controls.Add(this.NotesTXT);
            this.Panel1.Controls.Add(this.label9);
            this.Panel1.Controls.Add(this.PricreTXT);
            this.Panel1.Controls.Add(this.label7);
            this.Panel1.Controls.Add(this.MetreTXT);
            this.Panel1.Controls.Add(this.label8);
            this.Panel1.Controls.Add(this.FrzTXT);
            this.Panel1.Controls.Add(this.label5);
            this.Panel1.Controls.Add(this.SizeTXT);
            this.Panel1.Controls.Add(this.label6);
            this.Panel1.Controls.Add(this.ColorTXT);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Controls.Add(this.CompanyTXT);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.NameTXT);
            this.Panel1.Controls.Add(this.comboBox1);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.CodeTXT);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Location = new System.Drawing.Point(471, 185);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(716, 368);
            this.Panel1.TabIndex = 1;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(596, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 21);
            this.label13.TabIndex = 29;
            this.label13.Text = "سعر الشراء :";
            this.label13.Click += new System.EventHandler(this.label13_Click_1);
            // 
            // PriceInputTXT
            // 
            this.PriceInputTXT.Location = new System.Drawing.Point(364, 239);
            this.PriceInputTXT.Name = "PriceInputTXT";
            this.PriceInputTXT.Size = new System.Drawing.Size(189, 27);
            this.PriceInputTXT.TabIndex = 28;
            this.PriceInputTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceInputTXT.TextChanged += new System.EventHandler(this.PriceInputTXT_TextChanged);
            this.PriceInputTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PriceInputTXT_KeyDown);
            this.PriceInputTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceInputTXT_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(571, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "رصيد بداية المدة :";
            // 
            // StrartQuantityTXT
            // 
            this.StrartQuantityTXT.Location = new System.Drawing.Point(364, 286);
            this.StrartQuantityTXT.Name = "StrartQuantityTXT";
            this.StrartQuantityTXT.Size = new System.Drawing.Size(189, 27);
            this.StrartQuantityTXT.TabIndex = 26;
            this.StrartQuantityTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StrartQuantityTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StrartQuantityTXT_KeyDown);
            this.StrartQuantityTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StrartQuantityTXT_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(615, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "ملاحظات :";
            // 
            // NotesTXT
            // 
            this.NotesTXT.Location = new System.Drawing.Point(47, 324);
            this.NotesTXT.Name = "NotesTXT";
            this.NotesTXT.Size = new System.Drawing.Size(506, 27);
            this.NotesTXT.TabIndex = 24;
            this.NotesTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NotesTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NotesTXT_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(271, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "سعر البيع :";
            // 
            // PricreTXT
            // 
            this.PricreTXT.Location = new System.Drawing.Point(47, 238);
            this.PricreTXT.Name = "PricreTXT";
            this.PricreTXT.Size = new System.Drawing.Size(189, 27);
            this.PricreTXT.TabIndex = 22;
            this.PricreTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PricreTXT.TextChanged += new System.EventHandler(this.PricreTXT_TextChanged);
            this.PricreTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PricreTXT_KeyDown);
            this.PricreTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PricreTXT_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(303, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "م/ك :";
            // 
            // MetreTXT
            // 
            this.MetreTXT.BackColor = System.Drawing.SystemColors.Window;
            this.MetreTXT.Location = new System.Drawing.Point(47, 199);
            this.MetreTXT.Name = "MetreTXT";
            this.MetreTXT.Size = new System.Drawing.Size(189, 27);
            this.MetreTXT.TabIndex = 18;
            this.MetreTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.MetreTXT, "هذه الخانة خاصة بالسيراميك");
            this.MetreTXT.TextChanged += new System.EventHandler(this.MetreTXT_TextChanged);
            this.MetreTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MetreTXT_KeyDown);
            this.MetreTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MetreTXT_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(641, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "الفرز :";
            // 
            // FrzTXT
            // 
            this.FrzTXT.Location = new System.Drawing.Point(364, 197);
            this.FrzTXT.Name = "FrzTXT";
            this.FrzTXT.Size = new System.Drawing.Size(189, 27);
            this.FrzTXT.TabIndex = 16;
            this.FrzTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.FrzTXT, "هذه الخانة خاصة بالسيراميك");
            this.FrzTXT.TextChanged += new System.EventHandler(this.FrzTXT_TextChanged);
            this.FrzTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrzTXT_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(285, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "المقاس :";
            // 
            // SizeTXT
            // 
            this.SizeTXT.Location = new System.Drawing.Point(47, 154);
            this.SizeTXT.Name = "SizeTXT";
            this.SizeTXT.Size = new System.Drawing.Size(189, 27);
            this.SizeTXT.TabIndex = 14;
            this.SizeTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SizeTXT.TextChanged += new System.EventHandler(this.SizeTXT_TextChanged);
            this.SizeTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SizeTXT_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(639, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "اللون :";
            // 
            // ColorTXT
            // 
            this.ColorTXT.Location = new System.Drawing.Point(364, 154);
            this.ColorTXT.Name = "ColorTXT";
            this.ColorTXT.Size = new System.Drawing.Size(189, 27);
            this.ColorTXT.TabIndex = 12;
            this.ColorTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColorTXT.TextChanged += new System.EventHandler(this.ColorTXT_TextChanged);
            this.ColorTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorTXT_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(253, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "اسم الشركة :";
            // 
            // CompanyTXT
            // 
            this.CompanyTXT.Location = new System.Drawing.Point(47, 286);
            this.CompanyTXT.Name = "CompanyTXT";
            this.CompanyTXT.Size = new System.Drawing.Size(189, 27);
            this.CompanyTXT.TabIndex = 10;
            this.CompanyTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CompanyTXT.TextChanged += new System.EventHandler(this.CompanyTXT_TextChanged);
            this.CompanyTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyTXT_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(597, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "اسم الصنف :";
            // 
            // NameTXT
            // 
            this.NameTXT.Location = new System.Drawing.Point(47, 112);
            this.NameTXT.Name = "NameTXT";
            this.NameTXT.Size = new System.Drawing.Size(506, 27);
            this.NameTXT.TabIndex = 8;
            this.NameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTXT.TextChanged += new System.EventHandler(this.NameTXT_TextChanged);
            this.NameTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTXT_KeyDown);
            this.NameTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTXT_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "سيراميك",
            "صحي",
            "خلاطات",
            "لوازم",
            "بانيو"});
            this.comboBox1.Location = new System.Drawing.Point(47, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(506, 27);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(604, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "كود الصنف :";
            // 
            // CodeTXT
            // 
            this.CodeTXT.Location = new System.Drawing.Point(47, 70);
            this.CodeTXT.Name = "CodeTXT";
            this.CodeTXT.Size = new System.Drawing.Size(506, 27);
            this.CodeTXT.TabIndex = 1;
            this.CodeTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CodeTXT.TabStopChanged += new System.EventHandler(this.CodeTXT_TabStopChanged);
            this.CodeTXT.TextChanged += new System.EventHandler(this.CodeTXT_TextChanged);
            this.CodeTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeTXT_KeyDown);
            this.CodeTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeTXT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(605, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع الصنف :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(13, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1629, 89);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::Sales.Properties.Resources.checklist_50px;
            this.pictureBox1.Location = new System.Drawing.Point(473, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(600, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(672, 33);
            this.label12.TabIndex = 1;
            this.label12.Text = "بـــــــــــــيــــــــــــانــــــــــــات الأصـــــــــــنــــــــــــاف";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.NewBTN);
            this.panel3.Controls.Add(this.ExitBTN);
            this.panel3.Controls.Add(this.DeleteBTN);
            this.panel3.Controls.Add(this.EdietBTN);
            this.panel3.Controls.Add(this.SearchBTN);
            this.panel3.Controls.Add(this.SaveBTN);
            this.panel3.Location = new System.Drawing.Point(471, 569);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 82);
            this.panel3.TabIndex = 3;
            // 
            // NewBTN
            // 
            this.NewBTN.BackColor = System.Drawing.SystemColors.Control;
            this.NewBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewBTN.ForeColor = System.Drawing.Color.Navy;
            this.NewBTN.Location = new System.Drawing.Point(602, 22);
            this.NewBTN.Name = "NewBTN";
            this.NewBTN.Size = new System.Drawing.Size(101, 42);
            this.NewBTN.TabIndex = 10;
            this.NewBTN.Text = "جديد";
            this.NewBTN.UseVisualStyleBackColor = false;
            this.NewBTN.Click += new System.EventHandler(this.button6_Click_1);
            this.NewBTN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewBTN_KeyDown);
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.SystemColors.Control;
            this.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBTN.ForeColor = System.Drawing.Color.Navy;
            this.ExitBTN.Location = new System.Drawing.Point(11, 22);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(96, 42);
            this.ExitBTN.TabIndex = 9;
            this.ExitBTN.Text = "رجوع";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            this.ExitBTN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExitBTN_KeyDown);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBTN.ForeColor = System.Drawing.Color.Navy;
            this.DeleteBTN.Location = new System.Drawing.Point(110, 22);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(120, 42);
            this.DeleteBTN.TabIndex = 8;
            this.DeleteBTN.Text = "حذف صنف";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            this.DeleteBTN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeleteBTN_KeyDown);
            // 
            // EdietBTN
            // 
            this.EdietBTN.BackColor = System.Drawing.SystemColors.Control;
            this.EdietBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EdietBTN.ForeColor = System.Drawing.Color.Navy;
            this.EdietBTN.Location = new System.Drawing.Point(233, 22);
            this.EdietBTN.Name = "EdietBTN";
            this.EdietBTN.Size = new System.Drawing.Size(120, 42);
            this.EdietBTN.TabIndex = 7;
            this.EdietBTN.Text = "تعديل صنف ";
            this.EdietBTN.UseVisualStyleBackColor = false;
            this.EdietBTN.Click += new System.EventHandler(this.EdietBTN_Click);
            this.EdietBTN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EdietBTN_KeyDown);
            // 
            // SearchBTN
            // 
            this.SearchBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SearchBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBTN.ForeColor = System.Drawing.Color.Navy;
            this.SearchBTN.Location = new System.Drawing.Point(356, 22);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(120, 42);
            this.SearchBTN.TabIndex = 6;
            this.SearchBTN.Text = "بحث في الأصناف";
            this.SearchBTN.UseVisualStyleBackColor = false;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            this.SearchBTN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBTN_KeyDown);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SaveBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBTN.ForeColor = System.Drawing.Color.Navy;
            this.SaveBTN.Location = new System.Drawing.Point(479, 22);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(120, 42);
            this.SaveBTN.TabIndex = 5;
            this.SaveBTN.Text = "تسجيل صنف";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.button1_Click);
            this.SaveBTN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaveBTN_KeyDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ItemsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1654, 793);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemsFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemsFrm_Load);
            this.Leave += new System.EventHandler(this.ItemsFrm_Leave);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NotesTXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PricreTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MetreTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FrzTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SizeTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ColorTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CompanyTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTXT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodeTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button EdietBTN;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button NewBTN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox StrartQuantityTXT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PriceInputTXT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}