//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IndiaTourProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PassengerDetails1
    {
        public int passengerid { get; set; }
        public string passengername { get; set; }
        public Nullable<System.DateTime> passengerdob { get; set; }
        public string roomtype { get; set; }
        public Nullable<decimal> cost { get; set; }
        public string passengeriddocument { get; set; }
        public Nullable<int> passengeridno { get; set; }
        public string passengersex { get; set; }
        public string passengeremail { get; set; }
        public int bookingid { get; set; }
    
        public virtual BookingDetail BookingDetail { get; set; }
    }
}
