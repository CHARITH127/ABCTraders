using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTraders.Models
{
    internal class Order
    {
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
