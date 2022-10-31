namespace Lab345
{
    partial class BuyTicket
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.dataGridViewBuyTicket = new System.Windows.Forms.DataGridView();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.startDatetime = new System.Windows.Forms.DateTimePicker();
            this.endDatetime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuyTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(1160, 635);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 27);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(548, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUY TICKET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(24, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(25, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Time: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(24, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(25, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "End Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(25, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(25, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Available:";
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(128, 146);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(207, 22);
            this.txtDest.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(128, 207);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(207, 22);
            this.txtPrice.TabIndex = 10;
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(128, 375);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(57, 22);
            this.txtAvailable.TabIndex = 13;
            // 
            // dataGridViewBuyTicket
            // 
            this.dataGridViewBuyTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuyTicket.Location = new System.Drawing.Point(359, 115);
            this.dataGridViewBuyTicket.Name = "dataGridViewBuyTicket";
            this.dataGridViewBuyTicket.RowHeadersWidth = 51;
            this.dataGridViewBuyTicket.RowTemplate.Height = 24;
            this.dataGridViewBuyTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuyTicket.Size = new System.Drawing.Size(922, 482);
            this.dataGridViewBuyTicket.TabIndex = 14;
            this.dataGridViewBuyTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuyTicket_CellContentClick);
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(128, 431);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(70, 22);
            this.numAmount.TabIndex = 15;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPurchase.Location = new System.Drawing.Point(30, 514);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(120, 31);
            this.btnPurchase.TabIndex = 16;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClear.Location = new System.Drawing.Point(187, 514);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 31);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // startDatetime
            // 
            this.startDatetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatetime.Location = new System.Drawing.Point(128, 262);
            this.startDatetime.Margin = new System.Windows.Forms.Padding(4);
            this.startDatetime.Name = "startDatetime";
            this.startDatetime.Size = new System.Drawing.Size(207, 22);
            this.startDatetime.TabIndex = 18;
            // 
            // endDatetime
            // 
            this.endDatetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatetime.Location = new System.Drawing.Point(128, 318);
            this.endDatetime.Margin = new System.Windows.Forms.Padding(4);
            this.endDatetime.Name = "endDatetime";
            this.endDatetime.Size = new System.Drawing.Size(207, 22);
            this.endDatetime.TabIndex = 19;
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 674);
            this.Controls.Add(this.endDatetime);
            this.Controls.Add(this.startDatetime);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.dataGridViewBuyTicket);
            this.Controls.Add(this.txtAvailable);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Name = "BuyTicket";
            this.Text = "BuyTicket";
            this.Load += new System.EventHandler(this.BuyTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuyTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.DataGridView dataGridViewBuyTicket;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker startDatetime;
        private System.Windows.Forms.DateTimePicker endDatetime;
    }
}