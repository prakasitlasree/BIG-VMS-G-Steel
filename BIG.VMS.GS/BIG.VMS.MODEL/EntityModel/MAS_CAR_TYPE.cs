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
    
    public partial class MAS_CAR_TYPE
    {
        public MAS_CAR_TYPE()
        {
            this.MAS_CAR_BRAND = new HashSet<MAS_CAR_BRAND>();
            this.TRN_VISITOR = new HashSet<TRN_VISITOR>();
        }
    
        public int AUTO_ID { get; set; }
        public string NAME { get; set; }
        public string SHOW_FLAG { get; set; }
        public Nullable<int> SHOW_SEQ { get; set; }
    
        public virtual ICollection<MAS_CAR_BRAND> MAS_CAR_BRAND { get; set; }
        public virtual ICollection<TRN_VISITOR> TRN_VISITOR { get; set; }
    }
}
