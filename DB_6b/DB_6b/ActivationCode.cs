//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_6b
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActivationCode
    {
        public int CodeId { get; set; }
        public string ActCode { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    
        public virtual OrderDetail OrderDetail { get; set; }
    }
}