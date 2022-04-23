using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C868.Models
{
    public class OrderItems : QtyByProductId
    {
        public int ItemId { get; set; }
        public int OrderId { get; set; }

        public OrderItems(int item, int order, int pID, int qty) : base (pID, qty)
        {
            ItemId = item;
            OrderId = order;
            ProductId = pID;
            Quantity = qty;
        }
    }
}
