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
    
    public partial class tbl_Statistics
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Statistics()
        {
            this.tbl_PollAnswer_Statistics = new HashSet<tbl_PollAnswer_Statistics>();
            this.tbl_User = new HashSet<tbl_User>();
            this.tbl_Poll = new HashSet<tbl_Poll>();
        }
    
        public int ID { get; set; }
        public string Age { get; set; }
        public string Social { get; set; }
        public string Kids { get; set; }
        public string Occupation { get; set; }
        public string Income { get; set; }
        public string Sex { get; set; }
        public string Teens { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PollAnswer_Statistics> tbl_PollAnswer_Statistics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_User> tbl_User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Poll> tbl_Poll { get; set; }
    }
}
