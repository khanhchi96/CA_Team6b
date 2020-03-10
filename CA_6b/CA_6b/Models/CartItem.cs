using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA_6b.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double NewPrice { get; set; }
    }
}