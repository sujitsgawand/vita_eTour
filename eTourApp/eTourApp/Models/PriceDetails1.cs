//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eTourApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PriceDetails1
    {
        public int priceid { get; set; }
        public Nullable<decimal> adultprice { get; set; }
        public Nullable<decimal> childrenprice { get; set; }
        public Nullable<decimal> additionalcharges { get; set; }
        public Nullable<int> packageid { get; set; }
    
        public virtual PackageCompleteDetail PackageCompleteDetail { get; set; }
    }
}
