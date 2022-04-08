
namespace C868
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OrdersTab = new System.Windows.Forms.TabPage();
            this.UpdateOrderBtn = new System.Windows.Forms.Button();
            this.NewOrderBtn = new System.Windows.Forms.Button();
            this.OrdersDGV = new System.Windows.Forms.DataGridView();
            this.InventoryTab = new System.Windows.Forms.TabPage();
            this.UpdateProdBtn = new System.Windows.Forms.Button();
            this.NewProdBtn = new System.Windows.Forms.Button();
            this.InventoryDGV = new System.Windows.Forms.DataGridView();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.ReportsTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.OrdersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGV)).BeginInit();
            this.InventoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.OrdersTab);
            this.tabControl1.Controls.Add(this.InventoryTab);
            this.tabControl1.Controls.Add(this.ReportsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tabControl1.Location = new System.Drawing.Point(0, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1159, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Controls.Add(this.UpdateOrderBtn);
            this.OrdersTab.Controls.Add(this.NewOrderBtn);
            this.OrdersTab.Controls.Add(this.OrdersDGV);
            this.OrdersTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.OrdersTab.Location = new System.Drawing.Point(4, 33);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTab.Size = new System.Drawing.Size(1151, 506);
            this.OrdersTab.TabIndex = 0;
            this.OrdersTab.Text = "Orders";
            this.OrdersTab.UseVisualStyleBackColor = true;
            // 
            // UpdateOrderBtn
            // 
            this.UpdateOrderBtn.Location = new System.Drawing.Point(250, 450);
            this.UpdateOrderBtn.Name = "UpdateOrderBtn";
            this.UpdateOrderBtn.Size = new System.Drawing.Size(236, 50);
            this.UpdateOrderBtn.TabIndex = 3;
            this.UpdateOrderBtn.Text = "Update Selected Order";
            this.UpdateOrderBtn.UseVisualStyleBackColor = true;
            this.UpdateOrderBtn.Click += new System.EventHandler(this.UpdateOrderBtn_Click);
            // 
            // NewOrderBtn
            // 
            this.NewOrderBtn.Location = new System.Drawing.Point(8, 450);
            this.NewOrderBtn.Name = "NewOrderBtn";
            this.NewOrderBtn.Size = new System.Drawing.Size(236, 50);
            this.NewOrderBtn.TabIndex = 2;
            this.NewOrderBtn.Text = "New Order";
            this.NewOrderBtn.UseVisualStyleBackColor = true;
            this.NewOrderBtn.Click += new System.EventHandler(this.NewOrderBtn_Click);
            // 
            // OrdersDGV
            // 
            this.OrdersDGV.AllowUserToAddRows = false;
            this.OrdersDGV.AllowUserToDeleteRows = false;
            this.OrdersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrdersDGV.Location = new System.Drawing.Point(3, 3);
            this.OrdersDGV.MultiSelect = false;
            this.OrdersDGV.Name = "OrdersDGV";
            this.OrdersDGV.RowHeadersVisible = false;
            this.OrdersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDGV.Size = new System.Drawing.Size(1145, 441);
            this.OrdersDGV.TabIndex = 0;
            // 
            // InventoryTab
            // 
            this.InventoryTab.Controls.Add(this.UpdateProdBtn);
            this.InventoryTab.Controls.Add(this.NewProdBtn);
            this.InventoryTab.Controls.Add(this.InventoryDGV);
            this.InventoryTab.Location = new System.Drawing.Point(4, 33);
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryTab.Size = new System.Drawing.Size(1151, 506);
            this.InventoryTab.TabIndex = 1;
            this.InventoryTab.Text = "Inventory";
            this.InventoryTab.UseVisualStyleBackColor = true;
            // 
            // UpdateProdBtn
            // 
            this.UpdateProdBtn.Location = new System.Drawing.Point(250, 448);
            this.UpdateProdBtn.Name = "UpdateProdBtn";
            this.UpdateProdBtn.Size = new System.Drawing.Size(236, 50);
            this.UpdateProdBtn.TabIndex = 6;
            this.UpdateProdBtn.Text = "Update Selected Product";
            this.UpdateProdBtn.UseVisualStyleBackColor = true;
            this.UpdateProdBtn.Click += new System.EventHandler(this.UpdateProdBtn_Click);
            // 
            // NewProdBtn
            // 
            this.NewProdBtn.Location = new System.Drawing.Point(8, 448);
            this.NewProdBtn.Name = "NewProdBtn";
            this.NewProdBtn.Size = new System.Drawing.Size(236, 50);
            this.NewProdBtn.TabIndex = 5;
            this.NewProdBtn.Text = "New Product";
            this.NewProdBtn.UseVisualStyleBackColor = true;
            this.NewProdBtn.Click += new System.EventHandler(this.NewProdBtn_Click);
            // 
            // InventoryDGV
            // 
            this.InventoryDGV.AllowUserToAddRows = false;
            this.InventoryDGV.AllowUserToDeleteRows = false;
            this.InventoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryDGV.Location = new System.Drawing.Point(3, 3);
            this.InventoryDGV.MultiSelect = false;
            this.InventoryDGV.Name = "InventoryDGV";
            this.InventoryDGV.ReadOnly = true;
            this.InventoryDGV.RowHeadersVisible = false;
            this.InventoryDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryDGV.Size = new System.Drawing.Size(1145, 439);
            this.InventoryDGV.TabIndex = 4;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExitBtn.Location = new System.Drawing.Point(1052, 16);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(95, 26);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 62);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchBtn.Location = new System.Drawing.Point(951, 16);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(95, 26);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SearchText.Location = new System.Drawing.Point(698, 16);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(247, 26);
            this.SearchText.TabIndex = 5;
            // 
            // ReportsTab
            // 
            this.ReportsTab.Location = new System.Drawing.Point(4, 33);
            this.ReportsTab.Name = "ReportsTab";
            this.ReportsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReportsTab.Size = new System.Drawing.Size(1151, 506);
            this.ReportsTab.TabIndex = 2;
            this.ReportsTab.Text = "Reports";
            this.ReportsTab.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 620);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.Text = "Skin Strategy Inventory Manager";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.OrdersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGV)).EndInit();
            this.InventoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OrdersTab;
        private System.Windows.Forms.TabPage InventoryTab;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button UpdateOrderBtn;
        private System.Windows.Forms.Button NewOrderBtn;
        private System.Windows.Forms.DataGridView OrdersDGV;
        private System.Windows.Forms.Button UpdateProdBtn;
        private System.Windows.Forms.Button NewProdBtn;
        private System.Windows.Forms.DataGridView InventoryDGV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.TabPage ReportsTab;
    }
}

