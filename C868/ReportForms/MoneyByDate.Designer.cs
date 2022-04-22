
namespace C868
{
    partial class MoneyByDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneyByDate));
            this.ReportDGVMoneyByDate = new System.Windows.Forms.DataGridView();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDGVMoneyByDate)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportDGVMoneyByDate
            // 
            this.ReportDGVMoneyByDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReportDGVMoneyByDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDGVMoneyByDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReportDGVMoneyByDate.Location = new System.Drawing.Point(0, 49);
            this.ReportDGVMoneyByDate.MultiSelect = false;
            this.ReportDGVMoneyByDate.Name = "ReportDGVMoneyByDate";
            this.ReportDGVMoneyByDate.ReadOnly = true;
            this.ReportDGVMoneyByDate.RowHeadersVisible = false;
            this.ReportDGVMoneyByDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReportDGVMoneyByDate.Size = new System.Drawing.Size(800, 401);
            this.ReportDGVMoneyByDate.TabIndex = 16;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(667, 6);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(121, 37);
            this.BackBtn.TabIndex = 15;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Revenue Earned by Month";
            // 
            // MoneyByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportDGVMoneyByDate);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoneyByDate";
            this.Text = "MoneyByDate";
            ((System.ComponentModel.ISupportInitialize)(this.ReportDGVMoneyByDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportDGVMoneyByDate;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
    }
}