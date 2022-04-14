using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C868.Models
{
    public class OrderItems
    {
        public int ItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int ProdQty { get; set; }

        public OrderItems(int item, int order, int product, int qty)
        {
            ItemId = item;
            OrderId = order;
            ProductId = product;
            ProdQty = qty;
        }
    }
}
