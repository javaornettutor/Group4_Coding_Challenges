//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Room_Booking
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.StaffBookings = new HashSet<StaffBooking>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> checkInDate { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffBooking> StaffBookings { get; set; }
    }
}
