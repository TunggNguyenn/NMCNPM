//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIMUPA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        public int ID { get; set; }
        public string BillCode { get; set; }
        public string CustomerName { get; set; }
        public Nullable<int> ID_Staff { get; set; }
        public Nullable<int> ID_Goods { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public Nullable<double> Total { get; set; }
        public Nullable<double> VAT { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhoneNumber { get; set; }
    
        public virtual Good Good { get; set; }
        public virtual User User { get; set; }
    }
}