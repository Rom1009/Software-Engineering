
namespace Lab1
{
    partial class Form1
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
            this.textUserID = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExsit = new System.Windows.Forms.Button();
            this.rdnMale = new System.Windows.Forms.RadioButton();
            this.rdnFemale = new System.Windows.Forms.RadioButton();
            this.gender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textUserID
            // 
            this.textUserID.AutoSize = true;
            this.textUserID.Location = new System.Drawing.Point(235, 78);
            this.textUserID.Name = "textUserID";
            this.textUserID.Size = new System.Drawing.Size(40, 13);
            this.textUserID.TabIndex = 0;
            this.textUserID.Text = "UserID";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(339, 71);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 1;
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.Location = new System.Drawing.Point(235, 117);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(53, 13);
            this.TextPassword.TabIndex = 2;
            this.TextPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(339, 114);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(241, 198);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnExsit
            // 
            this.btnExsit.Location = new System.Drawing.Point(385, 198);
            this.btnExsit.Name = "btnExsit";
            this.btnExsit.Size = new System.Drawing.Size(75, 23);
            this.btnExsit.TabIndex = 5;
            this.btnExsit.Text = "Exist";
            this.btnExsit.UseVisualStyleBackColor = true;
            this.btnExsit.Click += new System.EventHandler(this.btnExsit_Click);
            // 
            // rdnMale
            // 
            this.rdnMale.AutoSize = true;
            this.rdnMale.Location = new System.Drawing.Point(284, 157);
            this.rdnMale.Name = "rdnMale";
            this.rdnMale.Size = new System.Drawing.Size(48, 17);
            this.rdnMale.TabIndex = 6;
            this.rdnMale.TabStop = true;
            this.rdnMale.Text = "Male";
            this.rdnMale.UseVisualStyleBackColor = true;
            // 
            // rdnFemale
            // 
            this.rdnFemale.AutoSize = true;
            this.rdnFemale.Location = new System.Drawing.Point(375, 157);
            this.rdnFemale.Name = "rdnFemale";
            this.rdnFemale.Size = new System.Drawing.Size(59, 17);
            this.rdnFemale.TabIndex = 7;
            this.rdnFemale.TabStop = true;
            this.rdnFemale.Text = "Female";
            this.rdnFemale.UseVisualStyleBackColor = true;
            this.rdnFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(238, 157);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(42, 13);
            this.gender.TabIndex = 8;
            this.gender.Text = "Gender";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.rdnFemale);
            this.Controls.Add(this.rdnMale);
            this.Controls.Add(this.btnExsit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textUserID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textUserID;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label TextPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExsit;
        private System.Windows.Forms.RadioButton rdnMale;
        private System.Windows.Forms.RadioButton rdnFemale;
        private System.Windows.Forms.Label gender;
    }
}

