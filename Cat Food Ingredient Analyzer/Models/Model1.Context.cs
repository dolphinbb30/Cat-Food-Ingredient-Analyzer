﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cat_Food_Ingredient_Analyzer.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mySampleDatabaseEntities : DbContext
    {
        public mySampleDatabaseEntities()
            : base("name=mySampleDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<CurrencyOrderByFrequency> CurrencyOrderByFrequencies { get; set; }
    }
}
