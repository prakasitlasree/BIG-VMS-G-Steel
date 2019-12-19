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
    
    public partial class TRN_PROJECT_MASTER
    {
        public TRN_PROJECT_MASTER()
        {
            this.TRN_VISITOR = new HashSet<TRN_VISITOR>();
            this.TRN_PROJECT_MEMBER = new HashSet<TRN_PROJECT_MEMBER>();
        }
    
        public int AUTO_ID { get; set; }
        public int CONTRACTOR_ID { get; set; }
        public System.DateTime REGISTER_DATE { get; set; }
        public string RESPONSIBLE_MANAGER { get; set; }
        public string RESPONSIBLE_TEL { get; set; }
        public string PROJECT_NAME { get; set; }
        public string PROJECT_SCOPE { get; set; }
        public string WORKING_AREA { get; set; }
        public string RESPONSIBLE_DEP_HEAD { get; set; }
        public string WORKING_DAY { get; set; }
        public Nullable<System.DateTime> PROJECT_START_DATE { get; set; }
        public Nullable<System.DateTime> PROJECT_END_DATE { get; set; }
        public string PROJECT_WORKING_TIME { get; set; }
        public string PURCHASING_VERIFY_BY { get; set; }
        public Nullable<System.DateTime> PURCHASING_VERIFY_DATE { get; set; }
        public string SAFETY_TRAINING_REQUIRE { get; set; }
        public Nullable<System.DateTime> SAFETY_TRAINING_ISSUED_DATE { get; set; }
        public Nullable<System.DateTime> SAFETY_TRAINING_EXPIRED_DATE { get; set; }
        public string SAFETY_MANAGER_APP_BY { get; set; }
        public string ID_BADGE_TYPE { get; set; }
        public Nullable<System.DateTime> ID_BADGE_ISSUED_DATE { get; set; }
        public Nullable<System.DateTime> ID_BADGE_EXPIRED_DATE { get; set; }
        public string HRA_MANAGER_APP_BY { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
    
        public virtual MAS_CONTRACTOR MAS_CONTRACTOR { get; set; }
        public virtual ICollection<TRN_VISITOR> TRN_VISITOR { get; set; }
        public virtual ICollection<TRN_PROJECT_MEMBER> TRN_PROJECT_MEMBER { get; set; }
    }
}
