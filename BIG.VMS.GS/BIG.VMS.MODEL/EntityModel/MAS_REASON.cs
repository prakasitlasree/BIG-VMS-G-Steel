//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BIG.VMS.MODEL.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class MAS_REASON
    {
        public MAS_REASON()
        {
            this.TRN_APPOINTMENT = new HashSet<TRN_APPOINTMENT>();
            this.TRN_VISITOR = new HashSet<TRN_VISITOR>();
        }
    
        public int AUTO_ID { get; set; }
        public string REASON { get; set; }
        public string SHOW_FLAG { get; set; }
        public Nullable<int> SHOW_SEQ { get; set; }
        public Nullable<int> DEPT_ID { get; set; }
    
        public virtual MAS_DEPARTMENT MAS_DEPARTMENT { get; set; }
        public virtual ICollection<TRN_APPOINTMENT> TRN_APPOINTMENT { get; set; }
        public virtual ICollection<TRN_VISITOR> TRN_VISITOR { get; set; }
    }
}
