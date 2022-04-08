using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace C868.Models
{
    [Table("OrderItems")]
    class OrderItems
    {
        [PrimaryKey, AutoIncrement]
        int ItemId { get; set; }
        int OrderId { get; set; }
        int ProductId { get; set; }
    }
}
