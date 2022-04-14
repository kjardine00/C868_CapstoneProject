using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C868.Models
{
    public class Product
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public string ProdSKU { get; set; }
        public decimal ProdPrice { get; set; }

        public Product(int pID, string pName, string pSKU, decimal pPrice)
        {
            ProdID = pID;
            ProdName = pName;
            ProdSKU = pSKU;
            ProdPrice = pPrice;
        }
    }
}
