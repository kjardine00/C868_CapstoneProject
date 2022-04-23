using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C868.Models
{
    public class Product : QtyByProductId
    {
        public string ProdName { get; set; }
        public string ProdSKU { get; set; }
        public decimal ProdPrice { get; set; }

        public Product(int pID, string pName, string pSKU, decimal pPrice, int qty) : base (pID, qty)
        {
            ProductId = pID;
            ProdName = pName;
            ProdSKU = pSKU;
            ProdPrice = pPrice;
            Quantity = qty;
        }
    }
}
