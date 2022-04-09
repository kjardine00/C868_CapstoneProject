using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C868.Models
{
    public class Order
    {
        int OrderId { get; set; }
        string CustName { get; set; }
        string CustPhone { get; set; }
        string CustEmail { get; set; }
        int Price { get; set; }
    }
}
