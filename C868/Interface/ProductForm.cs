using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C868.Models;

namespace C868
{
    public partial class ProductForm : Form
    {
        bool newProd;
        public ProductForm(bool isNew, Product product)
        {
            newProd = isNew;
            InitializeComponent();
            LoadForm(product);
        }

        private void LoadForm(Product product)
        {
            Product loadProd = product;

            if (newProd == false)
            {
                ProdIdText.Text = loadProd.ProdID.ToString();
                ProdNameText.Text = loadProd.ProdName;
                ProdSKUText.Text = loadProd.ProdSKU;
                ProdPriceText.Text = loadProd.ProdPrice.ToString();
                DeleteBtn.Visible = true;
            }
            else
            {
                DeleteBtn.Visible = false;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = ProdToBeSaved(newProd);


            }
            catch
            {
                MessageBox.Show("Error", "Product Price must be a numeric value.");
            }
        }

        private Product ProdToBeSaved(bool IsNew)
        {
            if (newProd == false)
            {
                Product saveProd = new Product
                {
                    ProdID = Convert.ToInt32(ProdIdText.Text),
                    ProdName = ProdNameText.Text,
                    ProdSKU = ProdSKUText.Text,
                    ProdPrice = Convert.ToInt32(ProdPriceText.Text)
                };
                return saveProd;
            }
            else
            {
                Product saveProd = new Product
                {

                    ProdName = ProdNameText.Text,
                    ProdSKU = ProdSKUText.Text,
                    ProdPrice = Convert.ToInt32(ProdPriceText.Text)
                };
                return saveProd;
            }
        }
    }
}
