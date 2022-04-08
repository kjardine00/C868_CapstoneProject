using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace C868.Models
{
    [Table("Product")]
    class Product
    {
        [PrimaryKey, AutoIncrement]
        int ProdID { get; set; }
        string ProdName { get; set; }
        string ProdSKU { get; set; }
        int ProdPrice { get; set; }
    }
}
