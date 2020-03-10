using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA_6b.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public string Platform { get; set; }
        public string OperatingSystem { get; set; }
        public string ESRB { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public System.DateTime DiscountStart { get; set; }
        public System.DateTime DiscountEnd { get; set; }
        public int NumOfSales { get; set; }
        public ICollection<Image> Images { get; set; }

        public string ImageUrl { get; set; }
    }
}