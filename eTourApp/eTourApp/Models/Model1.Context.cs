﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IndiaTourEntities : DbContext
    {
        public IndiaTourEntities()
            : base("name=IndiaTourEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<CategorySubCategory> CategorySubCategories { get; set; }
        public DbSet<CustomerDetail> CustomerDetails { get; set; }
        public DbSet<DatePackageDetail> DatePackageDetails { get; set; }
        public DbSet<Itinerary> Itineraries { get; set; }
        public DbSet<PackageCompleteDetail> PackageCompleteDetails { get; set; }
        public DbSet<PassengerDetails1> PassengerDetails1 { get; set; }
        public DbSet<PriceDetails1> PriceDetails1 { get; set; }
    }
}