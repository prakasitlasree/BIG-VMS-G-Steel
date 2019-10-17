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
    
    public partial class TRN_CUSTOMER_VISIT
    {
        public TRN_CUSTOMER_VISIT()
        {
            this.TRN_CUSTOMER_VISIT_LIST = new HashSet<TRN_CUSTOMER_VISIT_LIST>();
            this.TRN_CUSTOMER_VISIT_PURPOSE = new HashSet<TRN_CUSTOMER_VISIT_PURPOSE>();
            this.TRN_VISITOR = new HashSet<TRN_VISITOR>();
        }
    
        public int AUTO_ID { get; set; }
        public Nullable<int> REQUESTOR_EMP_ID { get; set; }
        public string REQUESTOR_FULLNAME { get; set; }
        public string REQUESTOR_POSITION { get; set; }
        public string REQUESTOR_GROUP_AREA { get; set; }
        public string REQUESTOR_DEPARTMENT { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public Nullable<int> NUMBER_OF_CUSTOMER { get; set; }
        public string OBJECTIVE_OF_VISIT { get; set; }
        public Nullable<System.DateTime> DATE_TIME_OF_VISIT { get; set; }
        public string CONTACT_PERSON { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
    
        public virtual MAS_EMPLOYEE MAS_EMPLOYEE { get; set; }
        public virtual ICollection<TRN_CUSTOMER_VISIT_LIST> TRN_CUSTOMER_VISIT_LIST { get; set; }
        public virtual ICollection<TRN_CUSTOMER_VISIT_PURPOSE> TRN_CUSTOMER_VISIT_PURPOSE { get; set; }
        public virtual ICollection<TRN_VISITOR> TRN_VISITOR { get; set; }
    }
}
