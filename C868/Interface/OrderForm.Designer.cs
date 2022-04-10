
namespace C868
{
    partial class OrderForm
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CustEmailText = new System.Windows.Forms.TextBox();
            this.CustPhoneText = new System.Windows.Forms.TextBox();
            this.CustNameText = new System.Windows.Forms.TextBox();
            this.ProdIdText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProdPicker = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SubTotalText = new System.Windows.Forms.TextBox();
            this.TaxText = new System.Windows.Forms.TextBox();
            this.TotalPriceText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Details";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(330, 18);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(121, 37);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(330, 570);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(121, 37);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(203, 570);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(121, 37);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CustEmailText
            // 
            this.CustEmailText.Location = new System.Drawing.Point(116, 177);
            this.CustEmailText.Name = "CustEmailText";
            this.CustEmailText.Size = new System.Drawing.Size(335, 20);
            this.CustEmailText.TabIndex = 19;
            // 
            // CustPhoneText
            // 
            this.CustPhoneText.Location = new System.Drawing.Point(116, 145);
            this.CustPhoneText.Name = "CustPhoneText";
            this.CustPhoneText.Size = new System.Drawing.Size(335, 20);
            this.CustPhoneText.TabIndex = 18;
            // 
            // CustNameText
            // 
            this.CustNameText.Location = new System.Drawing.Point(116, 114);
            this.CustNameText.Name = "CustNameText";
            this.CustNameText.Size = new System.Drawing.Size(335, 20);
            this.CustNameText.TabIndex = 17;
            // 
            // ProdIdText
            // 
            this.ProdIdText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ProdIdText.Location = new System.Drawing.Point(249, 27);
            this.ProdIdText.Name = "ProdIdText";
            this.ProdIdText.ReadOnly = true;
            this.ProdIdText.Size = new System.Drawing.Size(69, 20);
            this.ProdIdText.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Order ID";
            // 
            // ProdPicker
            // 
            this.ProdPicker.FormattingEnabled = true;
            this.ProdPicker.Location = new System.Drawing.Point(17, 386);
            this.ProdPicker.Name = "ProdPicker";
            this.ProdPicker.Size = new System.Drawing.Size(307, 21);
            this.ProdPicker.TabIndex = 20;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(330, 386);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(121, 21);
            this.AddBtn.TabIndex = 21;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(14, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Products";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(330, 413);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(121, 21);
            this.RemoveBtn.TabIndex = 24;
            this.RemoveBtn.Text = "Remove Selected";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(14, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Subtotal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Tax:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 520);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Total:";
            // 
            // SubTotalText
            // 
            this.SubTotalText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SubTotalText.Location = new System.Drawing.Point(199, 465);
            this.SubTotalText.Name = "SubTotalText";
            this.SubTotalText.ReadOnly = true;
            this.SubTotalText.Size = new System.Drawing.Size(103, 20);
            this.SubTotalText.TabIndex = 29;
            // 
            // TaxText
            // 
            this.TaxText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TaxText.Location = new System.Drawing.Point(199, 491);
            this.TaxText.Name = "TaxText";
            this.TaxText.ReadOnly = true;
            this.TaxText.Size = new System.Drawing.Size(103, 20);
            this.TaxText.TabIndex = 30;
            // 
            // TotalPriceText
            // 
            this.TotalPriceText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TotalPriceText.Location = new System.Drawing.Point(199, 517);
            this.TotalPriceText.Name = "TotalPriceText";
            this.TotalPriceText.ReadOnly = true;
            this.TotalPriceText.Size = new System.Drawing.Size(103, 20);
            this.TotalPriceText.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 494);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "(7.15%)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(12, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 24);
            this.label12.TabIndex = 33;
            this.label12.Text = "Customer Information";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 619);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TotalPriceText);
            this.Controls.Add(this.TaxText);
            this.Controls.Add(this.SubTotalText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ProdPicker);
            this.Controls.Add(this.CustEmailText);
            this.Controls.Add(this.CustPhoneText);
            this.Controls.Add(this.CustNameText);
            this.Controls.Add(this.ProdIdText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "Order Details";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox CustEmailText;
        private System.Windows.Forms.TextBox CustPhoneText;
        private System.Windows.Forms.TextBox CustNameText;
        private System.Windows.Forms.TextBox ProdIdText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProdPicker;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SubTotalText;
        private System.Windows.Forms.TextBox TaxText;
        private System.Windows.Forms.TextBox TotalPriceText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}