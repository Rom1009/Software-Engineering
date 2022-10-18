namespace Lab1
{
    partial class frmDangkymonhoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbyear = new System.Windows.Forms.ComboBox();
            this.cbnlop = new System.Windows.Forms.ComboBox();
            this.rdn1 = new System.Windows.Forms.RadioButton();
            this.rdn2 = new System.Windows.Forms.RadioButton();
            this.rdn3 = new System.Windows.Forms.RadioButton();
            this.rdn4 = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btbSignin = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(306, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ MÔN HỌC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Niên Khóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Học kỳ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Môn học";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(250, 144);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(152, 22);
            this.txtMSSV.TabIndex = 7;
            this.txtMSSV.TextChanged += new System.EventHandler(this.txtMSSV_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(250, 181);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(379, 22);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cmbyear
            // 
            this.cmbyear.FormattingEnabled = true;
            this.cmbyear.Items.AddRange(new object[] {
            "2007",
            "2008",
            "2009"});
            this.cmbyear.Location = new System.Drawing.Point(250, 226);
            this.cmbyear.Name = "cmbyear";
            this.cmbyear.Size = new System.Drawing.Size(164, 24);
            this.cmbyear.TabIndex = 9;
            this.cmbyear.Text = "2007";
            // 
            // cbnlop
            // 
            this.cbnlop.FormattingEnabled = true;
            this.cbnlop.Items.AddRange(new object[] {
            "TH02",
            "TH03"});
            this.cbnlop.Location = new System.Drawing.Point(250, 275);
            this.cbnlop.Name = "cbnlop";
            this.cbnlop.Size = new System.Drawing.Size(164, 24);
            this.cbnlop.TabIndex = 10;
            this.cbnlop.Text = "TH02";
            this.cbnlop.SelectedIndexChanged += new System.EventHandler(this.cbnlop_SelectedIndexChanged);
            // 
            // rdn1
            // 
            this.rdn1.AutoSize = true;
            this.rdn1.Location = new System.Drawing.Point(250, 330);
            this.rdn1.Name = "rdn1";
            this.rdn1.Size = new System.Drawing.Size(31, 20);
            this.rdn1.TabIndex = 11;
            this.rdn1.TabStop = true;
            this.rdn1.Text = "I";
            this.rdn1.UseVisualStyleBackColor = true;
            // 
            // rdn2
            // 
            this.rdn2.AutoSize = true;
            this.rdn2.Location = new System.Drawing.Point(398, 328);
            this.rdn2.Name = "rdn2";
            this.rdn2.Size = new System.Drawing.Size(34, 20);
            this.rdn2.TabIndex = 12;
            this.rdn2.TabStop = true;
            this.rdn2.Text = "II";
            this.rdn2.UseVisualStyleBackColor = true;
            // 
            // rdn3
            // 
            this.rdn3.AutoSize = true;
            this.rdn3.Location = new System.Drawing.Point(546, 328);
            this.rdn3.Name = "rdn3";
            this.rdn3.Size = new System.Drawing.Size(37, 20);
            this.rdn3.TabIndex = 13;
            this.rdn3.TabStop = true;
            this.rdn3.Text = "III";
            this.rdn3.UseVisualStyleBackColor = true;
            // 
            // rdn4
            // 
            this.rdn4.AutoSize = true;
            this.rdn4.Location = new System.Drawing.Point(691, 328);
            this.rdn4.Name = "rdn4";
            this.rdn4.Size = new System.Drawing.Size(40, 20);
            this.rdn4.TabIndex = 14;
            this.rdn4.TabStop = true;
            this.rdn4.Text = "IV";
            this.rdn4.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "LT WIndows",
            "LT Internet",
            "Mạng máy tính",
            "UML"});
            this.checkedListBox1.Location = new System.Drawing.Point(271, 394);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(248, 89);
            this.checkedListBox1.TabIndex = 15;
            // 
            // btbSignin
            // 
            this.btbSignin.Location = new System.Drawing.Point(256, 501);
            this.btbSignin.Name = "btbSignin";
            this.btbSignin.Size = new System.Drawing.Size(107, 28);
            this.btbSignin.TabIndex = 16;
            this.btbSignin.Text = "Đăng ký";
            this.btbSignin.UseVisualStyleBackColor = true;
            this.btbSignin.Click += new System.EventHandler(this.btbSignin_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(428, 501);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 28);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Hủy";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(593, 501);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(107, 28);
            this.btnOut.TabIndex = 18;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // frmDangkymonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 547);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btbSignin);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.rdn4);
            this.Controls.Add(this.rdn3);
            this.Controls.Add(this.rdn2);
            this.Controls.Add(this.rdn1);
            this.Controls.Add(this.cbnlop);
            this.Controls.Add(this.cmbyear);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangkymonhoc";
            this.Text = "frmDangkymonhoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbyear;
        private System.Windows.Forms.ComboBox cbnlop;
        private System.Windows.Forms.RadioButton rdn1;
        private System.Windows.Forms.RadioButton rdn2;
        private System.Windows.Forms.RadioButton rdn3;
        private System.Windows.Forms.RadioButton rdn4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btbSignin;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOut;
    }
}