using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseManagement2.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public string pPrice { get; set; }
        public int pQty { get; set; }
    }
}
