using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA_6b.Models
{
    public class OrderItem
    {
        public int ItemId { get; set; }
        public DateTime ItemOrderDate { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public double ItemPrice { get; set; }
        public double ItemDiscount { get; set; }
        public string ItemUrl { get; set; }
        public List<string> ItemCodeLists { get; set; }
    }
}