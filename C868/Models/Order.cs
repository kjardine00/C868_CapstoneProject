using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C868.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustName { get; set; }
        public string CustPhone { get; set; }
        public string CustEmail { get; set; }
        public decimal OrderTotal { get; set; }

        public Order(int oID, DateTime oDate, string cName, string cPhone, string cEmail, decimal oTotal)
        {
            OrderId = oID;
            OrderDate = oDate;
            CustName = cName;
            CustPhone = cPhone;
            CustEmail = cEmail;
            OrderTotal = oTotal;
        }

        public string orderDateToMonthYear()
        {
            return OrderDate.ToString("MMMM yyyy");
        }
    }
}
