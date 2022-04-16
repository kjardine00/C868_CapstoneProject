
namespace C868
{
    partial class ProductForm
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ProdIdText = new System.Windows.Forms.TextBox();
            this.ProdNameText = new System.Windows.Forms.TextBox();
            this.ProdPriceText = new System.Windows.Forms.TextBox();
            this.ProdSKUText = new System.Windows.Forms.TextBox();
            this.QtyText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SKU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(239, 232);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(121, 37);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(239, 19);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(121, 37);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(106, 232);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(121, 37);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ProdIdText
            // 
            this.ProdIdText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ProdIdText.Location = new System.Drawing.Point(106, 75);
            this.ProdIdText.Name = "ProdIdText";
            this.ProdIdText.ReadOnly = true;
            this.ProdIdText.Size = new System.Drawing.Size(254, 20);
            this.ProdIdText.TabIndex = 8;
            // 
            // ProdNameText
            // 
            this.ProdNameText.Location = new System.Drawing.Point(106, 105);
            this.ProdNameText.Name = "ProdNameText";
            this.ProdNameText.Size = new System.Drawing.Size(254, 20);
            this.ProdNameText.TabIndex = 9;
            // 
            // ProdPriceText
            // 
            this.ProdPriceText.Location = new System.Drawing.Point(106, 136);
            this.ProdPriceText.Name = "ProdPriceText";
            this.ProdPriceText.Size = new System.Drawing.Size(254, 20);
            this.ProdPriceText.TabIndex = 10;
            // 
            // ProdSKUText
            // 
            this.ProdSKUText.Location = new System.Drawing.Point(106, 168);
            this.ProdSKUText.Name = "ProdSKUText";
            this.ProdSKUText.Size = new System.Drawing.Size(254, 20);
            this.ProdSKUText.TabIndex = 11;
            // 
            // QtyText
            // 
            this.QtyText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.QtyText.Location = new System.Drawing.Point(106, 197);
            this.QtyText.Name = "QtyText";
            this.QtyText.ReadOnly = true;
            this.QtyText.Size = new System.Drawing.Size(254, 20);
            this.QtyText.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantity Available";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 281);
            this.Controls.Add(this.QtyText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProdSKUText);
            this.Controls.Add(this.ProdPriceText);
            this.Controls.Add(this.ProdNameText);
            this.Controls.Add(this.ProdIdText);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox ProdIdText;
        private System.Windows.Forms.TextBox ProdNameText;
        private System.Windows.Forms.TextBox ProdPriceText;
        private System.Windows.Forms.TextBox ProdSKUText;
        private System.Windows.Forms.TextBox QtyText;
        private System.Windows.Forms.Label label6;
    }
}