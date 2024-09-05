using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTraders.Models
{
    internal class Car
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
