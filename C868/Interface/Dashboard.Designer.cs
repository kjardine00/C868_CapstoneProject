
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
            this.SearchCustText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateOrderBtn = new System.Windows.Forms.Button();
            this.NewOrderBtn = new System.Windows.Forms.Button();
            this.OrdersDGV = new System.Windows.Forms.DataGridView();
            this.InventoryTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.AdjustInventoryBtn = new System.Windows.Forms.Button();
            this.SearchProductText = new System.Windows.Forms.TextBox();
            this.UpdateProdBtn = new System.Windows.Forms.Button();
            this.NewProdBtn = new System.Windows.Forms.Button();
            this.InventoryDGV = new System.Windows.Forms.DataGridView();
            this.ReportsTab = new System.Windows.Forms.TabPage();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.OrdersTab.Controls.Add(this.SearchCustText);
            this.OrdersTab.Controls.Add(this.label1);
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
            // SearchCustText
            // 
            this.SearchCustText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SearchCustText.Location = new System.Drawing.Point(849, 463);
            this.SearchCustText.Name = "SearchCustText";
            this.SearchCustText.Size = new System.Drawing.Size(294, 26);
            this.SearchCustText.TabIndex = 5;
            this.SearchCustText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(690, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search by Customer";
            // 
            // UpdateOrderBtn
            // 
            this.UpdateOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateOrderBtn.Location = new System.Drawing.Point(213, 448);
            this.UpdateOrderBtn.Name = "UpdateOrderBtn";
            this.UpdateOrderBtn.Size = new System.Drawing.Size(199, 50);
            this.UpdateOrderBtn.TabIndex = 3;
            this.UpdateOrderBtn.Text = "Update Selected Order";
            this.UpdateOrderBtn.UseVisualStyleBackColor = true;
            this.UpdateOrderBtn.Click += new System.EventHandler(this.UpdateOrderBtn_Click);
            // 
            // NewOrderBtn
            // 
            this.NewOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderBtn.Location = new System.Drawing.Point(8, 448);
            this.NewOrderBtn.Name = "NewOrderBtn";
            this.NewOrderBtn.Size = new System.Drawing.Size(199, 50);
            this.NewOrderBtn.TabIndex = 2;
            this.NewOrderBtn.Text = "New Order";
            this.NewOrderBtn.UseVisualStyleBackColor = true;
            this.NewOrderBtn.Click += new System.EventHandler(this.NewOrderBtn_Click);
            // 
            // OrdersDGV
            // 
            this.OrdersDGV.AllowUserToAddRows = false;
            this.OrdersDGV.AllowUserToDeleteRows = false;
            this.OrdersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrdersDGV.Location = new System.Drawing.Point(3, 3);
            this.OrdersDGV.MultiSelect = false;
            this.OrdersDGV.Name = "OrdersDGV";
            this.OrdersDGV.ReadOnly = true;
            this.OrdersDGV.RowHeadersVisible = false;
            this.OrdersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDGV.Size = new System.Drawing.Size(1145, 439);
            this.OrdersDGV.TabIndex = 0;
            // 
            // InventoryTab
            // 
            this.InventoryTab.Controls.Add(this.label2);
            this.InventoryTab.Controls.Add(this.AdjustInventoryBtn);
            this.InventoryTab.Controls.Add(this.SearchProductText);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(704, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search by Product";
            // 
            // AdjustInventoryBtn
            // 
            this.AdjustInventoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdjustInventoryBtn.Location = new System.Drawing.Point(418, 448);
            this.AdjustInventoryBtn.Name = "AdjustInventoryBtn";
            this.AdjustInventoryBtn.Size = new System.Drawing.Size(199, 50);
            this.AdjustInventoryBtn.TabIndex = 9;
            this.AdjustInventoryBtn.Text = "Adjust Inventory";
            this.AdjustInventoryBtn.UseVisualStyleBackColor = true;
            this.AdjustInventoryBtn.Click += new System.EventHandler(this.AddInventoryBtn_Click);
            // 
            // SearchProductText
            // 
            this.SearchProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SearchProductText.Location = new System.Drawing.Point(849, 461);
            this.SearchProductText.Name = "SearchProductText";
            this.SearchProductText.Size = new System.Drawing.Size(294, 26);
            this.SearchProductText.TabIndex = 7;
            this.SearchProductText.TextChanged += new System.EventHandler(this.SearchProductText_TextChanged);
            // 
            // UpdateProdBtn
            // 
            this.UpdateProdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProdBtn.Location = new System.Drawing.Point(213, 448);
            this.UpdateProdBtn.Name = "UpdateProdBtn";
            this.UpdateProdBtn.Size = new System.Drawing.Size(199, 50);
            this.UpdateProdBtn.TabIndex = 6;
            this.UpdateProdBtn.Text = "Update Selected Product";
            this.UpdateProdBtn.UseVisualStyleBackColor = true;
            this.UpdateProdBtn.Click += new System.EventHandler(this.UpdateProdBtn_Click);
            // 
            // NewProdBtn
            // 
            this.NewProdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProdBtn.Location = new System.Drawing.Point(8, 448);
            this.NewProdBtn.Name = "NewProdBtn";
            this.NewProdBtn.Size = new System.Drawing.Size(199, 50);
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.Text = "Skin StrateG Inventory Manager";
            this.tabControl1.ResumeLayout(false);
            this.OrdersTab.ResumeLayout(false);
            this.OrdersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGV)).EndInit();
            this.InventoryTab.ResumeLayout(false);
            this.InventoryTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox SearchCustText;
        private System.Windows.Forms.TabPage ReportsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchProductText;
        private System.Windows.Forms.Button AdjustInventoryBtn;
        private System.Windows.Forms.Label label2;
    }
}

