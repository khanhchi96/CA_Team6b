using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA_6b.Models
{
    public class OrderDetail
    {
        public OrderDetail(List<Product> products, List<int> quantity, List<ActivationCode> codeLists)
        {
            Products = products;
            Quantity = quantity;
            CodeLists = codeLists;
        }
        public int OrderId { get; set; }
        public List<Product> Products { get; set; }
        public List<int> Quantity { get; set; }
        public List<ActivationCode> CodeLists { get; set; }
    }
}