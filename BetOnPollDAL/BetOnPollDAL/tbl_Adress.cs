//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetOnPollDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Adress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Adress()
        {
            this.tbl_User = new HashSet<tbl_User>();
            this.tbl_Poll = new HashSet<tbl_Poll>();
        }
    
        public int ID { get; set; }
        public string City { get; set; }
        public string Postalcode { get; set; }
        public string StreetAdress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_User> tbl_User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Poll> tbl_Poll { get; set; }
    }
}