namespace Sales01.Forms
{
    partial class VendorsFrm
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NewBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.EdietBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.VenNotesTXT = new System.Windows.Forms.TextBox();
            this.VenNameTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VenMobTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VenCodeTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.VenCreditTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VenBalanceTXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.VenDebitTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(11, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1671, 93);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::Sales.Properties.Resources.conference_100px;
            this.pictureBox3.Location = new System.Drawing.Point(471, -7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 87);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(571, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(763, 33);
            this.label12.TabIndex = 1;
            this.label12.Text = "بـــــــــــيـــــــــــــانـــــــــات الـــــــــمــــــــــــورديـــــــــــــ" +
    "ـــن";
            this.label12.Click += new System.EventHandler(this.label12_Click);
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
            this.panel3.Location = new System.Drawing.Point(475, 488);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 73);
            this.panel3.TabIndex = 8;
            // 
            // NewBTN
            // 
            this.NewBTN.BackColor = System.Drawing.SystemColors.Control;
            this.NewBTN.ForeColor = System.Drawing.Color.Navy;
            this.NewBTN.Location = new System.Drawing.Point(670, 15);
            this.NewBTN.Name = "NewBTN";
            this.NewBTN.Size = new System.Drawing.Size(128, 42);
            this.NewBTN.TabIndex = 15;
            this.NewBTN.Text = "جــــــديــــــد";
            this.NewBTN.UseVisualStyleBackColor = false;
            this.NewBTN.Click += new System.EventHandler(this.NewBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.SystemColors.Control;
            this.ExitBTN.ForeColor = System.Drawing.Color.Navy;
            this.ExitBTN.Location = new System.Drawing.Point(8, 15);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(115, 42);
            this.ExitBTN.TabIndex = 14;
            this.ExitBTN.Text = "رجوع";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBTN.ForeColor = System.Drawing.Color.Navy;
            this.DeleteBTN.Location = new System.Drawing.Point(128, 15);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(128, 42);
            this.DeleteBTN.TabIndex = 13;
            this.DeleteBTN.Text = "حذف مورد";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // EdietBTN
            // 
            this.EdietBTN.BackColor = System.Drawing.SystemColors.Control;
            this.EdietBTN.ForeColor = System.Drawing.Color.Navy;
            this.EdietBTN.Location = new System.Drawing.Point(261, 15);
            this.EdietBTN.Name = "EdietBTN";
            this.EdietBTN.Size = new System.Drawing.Size(128, 42);
            this.EdietBTN.TabIndex = 12;
            this.EdietBTN.Text = "تعديل مورد";
            this.EdietBTN.UseVisualStyleBackColor = false;
            this.EdietBTN.Click += new System.EventHandler(this.EdietBTN_Click);
            // 
            // SearchBTN
            // 
            this.SearchBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SearchBTN.ForeColor = System.Drawing.Color.Navy;
            this.SearchBTN.Location = new System.Drawing.Point(394, 15);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(128, 42);
            this.SearchBTN.TabIndex = 11;
            this.SearchBTN.Text = "بحث في الموردين";
            this.SearchBTN.UseVisualStyleBackColor = false;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SaveBTN.ForeColor = System.Drawing.Color.Navy;
            this.SaveBTN.Location = new System.Drawing.Point(527, 15);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(138, 42);
            this.SaveBTN.TabIndex = 10;
            this.SaveBTN.Text = "تسجيل مورد";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.VenNotesTXT);
            this.panel1.Controls.Add(this.VenNameTXT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.VenMobTXT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.VenCodeTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(475, 251);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 232);
            this.panel1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(579, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "مـــــــلاحــــــظــــــــات :";
            // 
            // VenNotesTXT
            // 
            this.VenNotesTXT.Location = new System.Drawing.Point(153, 163);
            this.VenNotesTXT.Name = "VenNotesTXT";
            this.VenNotesTXT.Size = new System.Drawing.Size(368, 27);
            this.VenNotesTXT.TabIndex = 12;
            this.VenNotesTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VenNotesTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VenNotesTXT_KeyDown);
            // 
            // VenNameTXT
            // 
            this.VenNameTXT.Location = new System.Drawing.Point(153, 71);
            this.VenNameTXT.Name = "VenNameTXT";
            this.VenNameTXT.Size = new System.Drawing.Size(368, 27);
            this.VenNameTXT.TabIndex = 10;
            this.VenNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VenNameTXT.TextChanged += new System.EventHandler(this.VenNameTXT_TextChanged);
            this.VenNameTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VenNameTXT_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(555, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "رقــــم الــــمـــوبــــــايـــــل :";
            // 
            // VenMobTXT
            // 
            this.VenMobTXT.Location = new System.Drawing.Point(153, 117);
            this.VenMobTXT.Name = "VenMobTXT";
            this.VenMobTXT.Size = new System.Drawing.Size(368, 27);
            this.VenMobTXT.TabIndex = 8;
            this.VenMobTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VenMobTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VenMobTXT_KeyDown);
            this.VenMobTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VenMobTXT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(568, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "اســــــم الــــــمــــــــورد :";
            // 
            // VenCodeTXT
            // 
            this.VenCodeTXT.Location = new System.Drawing.Point(153, 25);
            this.VenCodeTXT.Name = "VenCodeTXT";
            this.VenCodeTXT.Size = new System.Drawing.Size(368, 27);
            this.VenCodeTXT.TabIndex = 1;
            this.VenCodeTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VenCodeTXT.TextChanged += new System.EventHandler(this.VenCodeTXT_TextChanged);
            this.VenCodeTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VenCodeTXT_KeyDown);
            this.VenCodeTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VenCodeTXT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(579, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "كــــــود الــــــمـــــــورد :";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.VenCreditTXT);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.VenBalanceTXT);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.VenDebitTXT);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(475, 570);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(809, 85);
            this.panel4.TabIndex = 9;
            this.panel4.Visible = false;
            // 
            // VenCreditTXT
            // 
            this.VenCreditTXT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VenCreditTXT.Location = new System.Drawing.Point(339, 29);
            this.VenCreditTXT.Name = "VenCreditTXT";
            this.VenCreditTXT.ReadOnly = true;
            this.VenCreditTXT.Size = new System.Drawing.Size(116, 27);
            this.VenCreditTXT.TabIndex = 10;
            this.VenCreditTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VenCreditTXT.TextChanged += new System.EventHandler(this.VenCreditTXT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(277, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "الرصيد :";
            // 
            // VenBalanceTXT
            // 
            this.VenBalanceTXT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VenBalanceTXT.Location = new System.Drawing.Point(153, 29);
            this.VenBalanceTXT.Name = "VenBalanceTXT";
            this.VenBalanceTXT.ReadOnly = true;
            this.VenBalanceTXT.Size = new System.Drawing.Size(116, 27);
            this.VenBalanceTXT.TabIndex = 8;
            this.VenBalanceTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(646, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "مـديـن :";
            // 
            // VenDebitTXT
            // 
            this.VenDebitTXT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VenDebitTXT.Location = new System.Drawing.Point(524, 29);
            this.VenDebitTXT.Name = "VenDebitTXT";
            this.VenDebitTXT.ReadOnly = true;
            this.VenDebitTXT.Size = new System.Drawing.Size(116, 27);
            this.VenDebitTXT.TabIndex = 1;
            this.VenDebitTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VenDebitTXT.TextChanged += new System.EventHandler(this.VenDebitTXT_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(466, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "دائـن :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // VendorsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1691, 823);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VendorsFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VendorsFrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VenNotesTXT;
        private System.Windows.Forms.TextBox VenNameTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VenMobTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox VenCreditTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VenBalanceTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VenDebitTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button EdietBTN;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button NewBTN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox VenCodeTXT;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}