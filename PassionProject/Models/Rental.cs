//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PassionProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rental
    {
        public int TinyHouseId { get; set; }
        public decimal Cost { get; set; }
        public string Location { get; set; }
        public Nullable<int> Capacity { get; set; }
        public Nullable<int> Nights { get; set; }
        public Nullable<int> Ratings { get; set; }
    }
}
