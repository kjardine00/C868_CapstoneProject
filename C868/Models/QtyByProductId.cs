using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C868.Models
{
    public class QtyByProductId
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public QtyByProductId(int product, int qty)
        {
            ProductId = product;
            Quantity = qty;
        }
    }
}
