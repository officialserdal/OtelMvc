//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Otel.MVC.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kampanya
    {
        public int KampanyaID { get; set; }
        public string KampanyaAdı { get; set; }
        public Nullable<System.DateTime> BaslangicTarihi { get; set; }
        public Nullable<System.DateTime> BitisTarihi { get; set; }
        public string KampanyanyaFoto { get; set; }
        public Nullable<int> OtellID { get; set; }
        public string KampanyaAçıklama { get; set; }
    
        public virtual Otel11Set Otel11Set { get; set; }
    }
}
