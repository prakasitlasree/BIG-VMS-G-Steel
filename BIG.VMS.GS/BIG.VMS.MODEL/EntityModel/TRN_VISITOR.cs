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
    
    public partial class TRN_VISITOR
    {
        public TRN_VISITOR()
        {
            this.TRN_ATTACHEDMENT = new HashSet<TRN_ATTACHEDMENT>();
        }
    
        public int AUTO_ID { get; set; }
        public Nullable<int> YEAR { get; set; }
        public Nullable<int> MONTH { get; set; }
        public Nullable<int> NO { get; set; }
        public string ID_CARD { get; set; }
        public string TYPE { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public Nullable<int> CAR_TYPE_ID { get; set; }
        public string LICENSE_PLATE { get; set; }
        public Nullable<int> LICENSE_PLATE_PROVINCE_ID { get; set; }
        public Nullable<int> REASON_ID { get; set; }
        public Nullable<int> CONTACT_EMPLOYEE_ID { get; set; }
        public Nullable<int> STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<int> REF_NO { get; set; }
        public string BY_PASS { get; set; }
    
        public virtual MAS_CAR_TYPE MAS_CAR_TYPE { get; set; }
        public virtual MAS_EMPLOYEE MAS_EMPLOYEE { get; set; }
        public virtual MAS_PROVINCE MAS_PROVINCE { get; set; }
        public virtual MAS_REASON MAS_REASON { get; set; }
        public virtual ICollection<TRN_ATTACHEDMENT> TRN_ATTACHEDMENT { get; set; }
    }
}
