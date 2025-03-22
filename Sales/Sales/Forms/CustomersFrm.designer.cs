namespace Sales01.Forms
{
    partial class CustomersFrm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.NewBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.EdietBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.CustNotesTXT = new System.Windows.Forms.TextBox();
            this.CustNameTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustMobTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustCodeTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.CustCreditTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustBalanceTXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CustDebitTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.NewBTN);
            this.panel3.Controls.Add(this.ExitBTN);
            this.panel3.Controls.Add(this.DeleteBTN);
            this.panel3.Controls.Add(this.EdietBTN);
            this.panel3.Controls.Add(this.SearchBTN);
            this.panel3.Controls.Add(this.SaveBTN);
            this.panel3.Location = new System.Drawing.Point(431, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(811, 73);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // NewBTN
            // 
            this.NewBTN.BackColor = System.Drawing.SystemColors.Control;
            this.NewBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewBTN.ForeColor = System.Drawing.Color.Navy;
            this.NewBTN.Location = new System.Drawing.Point(667, 15);
            this.NewBTN.Name = "NewBTN";
            this.NewBTN.Size = new System.Drawing.Size(129, 42);
            this.NewBTN.TabIndex = 15;
            this.NewBTN.Text = "جـــديـــد";
            this.NewBTN.UseVisualStyleBackColor = false;
            this.NewBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.SystemColors.Control;
            this.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBTN.ForeColor = System.Drawing.Color.Navy;
            this.ExitBTN.Location = new System.Drawing.Point(14, 15);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(119, 42);
            this.ExitBTN.TabIndex = 14;
            this.ExitBTN.Text = "رجوع";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBTN.ForeColor = System.Drawing.Color.Navy;
            this.DeleteBTN.Location = new System.Drawing.Point(142, 15);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(119, 42);
            this.DeleteBTN.TabIndex = 13;
            this.DeleteBTN.Text = "حذف عميل";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // EdietBTN
            // 
            this.EdietBTN.BackColor = System.Drawing.SystemColors.Control;
            this.EdietBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EdietBTN.ForeColor = System.Drawing.Color.Navy;
            this.EdietBTN.Location = new System.Drawing.Point(270, 15);
            this.EdietBTN.Name = "EdietBTN";
            this.EdietBTN.Size = new System.Drawing.Size(119, 42);
            this.EdietBTN.TabIndex = 12;
            this.EdietBTN.Text = "تعديل عميل";
            this.EdietBTN.UseVisualStyleBackColor = false;
            this.EdietBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // SearchBTN
            // 
            this.SearchBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SearchBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBTN.ForeColor = System.Drawing.Color.Navy;
            this.SearchBTN.Location = new System.Drawing.Point(399, 15);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(119, 42);
            this.SearchBTN.TabIndex = 11;
            this.SearchBTN.Text = "بحث في العملاء";
            this.SearchBTN.UseVisualStyleBackColor = false;
            this.SearchBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SaveBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBTN.ForeColor = System.Drawing.Color.Navy;
            this.SaveBTN.Location = new System.Drawing.Point(529, 15);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(129, 42);
            this.SaveBTN.TabIndex = 10;
            this.SaveBTN.Text = "تسجيل عميل";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CustNotesTXT);
            this.panel1.Controls.Add(this.CustNameTXT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CustMobTXT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CustCodeTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(432, 214);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 232);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(560, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "مـــــــلاحــــــظــــــــات :";
            // 
            // CustNotesTXT
            // 
            this.CustNotesTXT.Location = new System.Drawing.Point(110, 162);
            this.CustNotesTXT.Name = "CustNotesTXT";
            this.CustNotesTXT.Size = new System.Drawing.Size(368, 27);
            this.CustNotesTXT.TabIndex = 12;
            this.CustNotesTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustNotesTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustNotesTXT_KeyDown);
            // 
            // CustNameTXT
            // 
            this.CustNameTXT.Location = new System.Drawing.Point(110, 73);
            this.CustNameTXT.Name = "CustNameTXT";
            this.CustNameTXT.Size = new System.Drawing.Size(368, 27);
            this.CustNameTXT.TabIndex = 10;
            this.CustNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustNameTXT.TextChanged += new System.EventHandler(this.CustNameTXT_TextChanged);
            this.CustNameTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustNameTXT_KeyDown);
            this.CustNameTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustNameTXT_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(536, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "رقــــم الــــمـــوبــــــايـــــل :";
            // 
            // CustMobTXT
            // 
            this.CustMobTXT.Location = new System.Drawing.Point(110, 118);
            this.CustMobTXT.Name = "CustMobTXT";
            this.CustMobTXT.Size = new System.Drawing.Size(368, 27);
            this.CustMobTXT.TabIndex = 8;
            this.CustMobTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustMobTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustMobTXT_KeyDown);
            this.CustMobTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustMobTXT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(497, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "اســـــم الــــعـــــمــــــــيــــــــــل :";
            // 
            // CustCodeTXT
            // 
            this.CustCodeTXT.Location = new System.Drawing.Point(110, 25);
            this.CustCodeTXT.Name = "CustCodeTXT";
            this.CustCodeTXT.Size = new System.Drawing.Size(368, 27);
            this.CustCodeTXT.TabIndex = 1;
            this.CustCodeTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustCodeTXT.TextChanged += new System.EventHandler(this.CustCodeTXT_TextChanged);
            this.CustCodeTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustCodeTXT_KeyDown);
            this.CustCodeTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustCodeTXT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(512, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "كــــــود الــــــعــــــمـــــيـــــــل :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(10, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1659, 94);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox4.Image = global::Sales.Properties.Resources.team_80px;
            this.pictureBox4.Location = new System.Drawing.Point(424, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(586, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(688, 33);
            this.label12.TabIndex = 1;
            this.label12.Text = "بـــــــــــيـــــــــــــانـــــــــات الـــــــــعـــــــــــمـــــــــــلاء";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.CustCreditTXT);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.CustBalanceTXT);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.CustDebitTXT);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(432, 534);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(809, 85);
            this.panel4.TabIndex = 13;
            this.panel4.Visible = false;
            // 
            // CustCreditTXT
            // 
            this.CustCreditTXT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustCreditTXT.Location = new System.Drawing.Point(512, 31);
            this.CustCreditTXT.Name = "CustCreditTXT";
            this.CustCreditTXT.ReadOnly = true;
            this.CustCreditTXT.Size = new System.Drawing.Size(116, 27);
            this.CustCreditTXT.TabIndex = 10;
            this.CustCreditTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustCreditTXT.TextChanged += new System.EventHandler(this.CustCreditTXT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(237, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "الرصيد :";
            // 
            // CustBalanceTXT
            // 
            this.CustBalanceTXT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustBalanceTXT.Location = new System.Drawing.Point(115, 31);
            this.CustBalanceTXT.Name = "CustBalanceTXT";
            this.CustBalanceTXT.ReadOnly = true;
            this.CustBalanceTXT.Size = new System.Drawing.Size(116, 27);
            this.CustBalanceTXT.TabIndex = 8;
            this.CustBalanceTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustBalanceTXT.TextChanged += new System.EventHandler(this.CustBalanceTXT_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(634, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "مـديـن :";
            // 
            // CustDebitTXT
            // 
            this.CustDebitTXT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustDebitTXT.Location = new System.Drawing.Point(319, 31);
            this.CustDebitTXT.Name = "CustDebitTXT";
            this.CustDebitTXT.ReadOnly = true;
            this.CustDebitTXT.Size = new System.Drawing.Size(116, 27);
            this.CustDebitTXT.TabIndex = 1;
            this.CustDebitTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustDebitTXT.TextChanged += new System.EventHandler(this.CustDebitTXT_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(441, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "دائـن :";
            // 
            // CustomersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1681, 795);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomersFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomersFrm_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button EdietBTN;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustNotesTXT;
        private System.Windows.Forms.TextBox CustNameTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustMobTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustCodeTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button NewBTN;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox CustCreditTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustBalanceTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CustDebitTXT;
        private System.Windows.Forms.Label label8;
    }
}