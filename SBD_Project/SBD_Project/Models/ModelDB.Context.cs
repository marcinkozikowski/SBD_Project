﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBD_Project.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SBD_DBEntities : DbContext
    {
        public SBD_DBEntities()
            : base("name=SBD_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cennik> Cennik { get; set; }
        public virtual DbSet<Kierowca> Kierowca { get; set; }
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Nadanie> Nadanie { get; set; }
        public virtual DbSet<Naprawa> Naprawa { get; set; }
        public virtual DbSet<Odbior> Odbior { get; set; }
        public virtual DbSet<Paczka> Paczka { get; set; }
        public virtual DbSet<Pracownik> Pracownik { get; set; }
        public virtual DbSet<Przewoz> Przewoz { get; set; }
        public virtual DbSet<Realizacja> Realizacja { get; set; }
        public virtual DbSet<Samochod> Samochod { get; set; }
        public virtual DbSet<Serwis> Serwis { get; set; }
        public virtual DbSet<Uprawnienia> Uprawnienia { get; set; }
        public virtual DbSet<Uzytkownik> Uzytkownik { get; set; }
        public virtual DbSet<Zlecenie> Zlecenie { get; set; }
    }
}
