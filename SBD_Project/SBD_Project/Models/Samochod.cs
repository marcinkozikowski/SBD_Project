//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace SBD_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Samochod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Samochod()
        {
            this.Naprawa = new HashSet<Naprawa>();
            this.Przewoz = new HashSet<Przewoz>();
        }
    
        public int ID { get; set; }

        [Display(Name = "Numer rejestracyjny")]
        public string NumerRej { get; set; }

        [Display(Name = "Wolny")]
        public byte CzyWolny { get; set; }

        [Display(Name = "Marka")]
        public string Marka { get; set; }

        [Display(Name = "Model")]
        public string Model { get; set; }

        [Display(Name = "Tona�")]
        public decimal Tonaz { get; set; }

        [Display(Name = "Opis")]
        public string Opis { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Naprawa> Naprawa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Przewoz> Przewoz { get; set; }
    }
}
