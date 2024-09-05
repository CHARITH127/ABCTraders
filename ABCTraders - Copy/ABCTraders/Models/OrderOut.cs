using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTraders.Models
{
    internal class OrderOut
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public decimal TotalAmount { get; set; }

        public List<OrderDetailsOut> OrderDetails { get; set; }

    }
}
