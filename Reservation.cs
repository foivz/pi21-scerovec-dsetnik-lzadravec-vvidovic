//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bitBooks_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public int ReservationID { get; set; }
        public int UserID { get; set; }
        public int PublishingID { get; set; }
        public System.DateTime DateReserved { get; set; }
        public System.DateTime DateAvailable { get; set; }
    
        public virtual LibraryUser LibraryUser { get; set; }
        public virtual Publishing Publishing { get; set; }
    }
}
