using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA_6b.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}