//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Klient
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string KodPocztowy { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public decimal NumerDomu { get; set; }
        public Nullable<decimal> NumerMieszkania { get; set; }
        public decimal Telefon { get; set; }
    
        public virtual Nadanie Nadanie { get; set; }
        public virtual Odbior Odbior { get; set; }
    }
}