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
    
    public partial class tbl_PollAnswer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PollAnswer()
        {
            this.tbl_Bet = new HashSet<tbl_Bet>();
            this.tbl_PollAnswer_Statistics = new HashSet<tbl_PollAnswer_Statistics>();
        }
    
        public int ID { get; set; }
        public string Answer { get; set; }
        public int PollID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Bet> tbl_Bet { get; set; }
        public virtual tbl_Poll tbl_Poll { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PollAnswer_Statistics> tbl_PollAnswer_Statistics { get; set; }
    }
}
