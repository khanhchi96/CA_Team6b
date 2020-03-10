using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA_6b.Models
{
    public class ActivationCode
    {
        public ActivationCode(int productId, List<string> actCode)
        {
            ProductId = productId;
            ActCode = actCode;
        }
        public int ProductId { get; set; }
        public List<string> ActCode { get; set; }
    }
}