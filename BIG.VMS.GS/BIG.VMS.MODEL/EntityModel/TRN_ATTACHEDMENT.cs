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
    
    public partial class TRN_ATTACHEDMENT
    {
        public int AUTO_ID { get; set; }
        public Nullable<int> VISITOR_ID { get; set; }
        public byte[] ID_CARD_PHOTO { get; set; }
        public byte[] CONTACT_PHOTO { get; set; }
        public string PHOTO_URL { get; set; }
        public byte[] REF_PHOTO1 { get; set; }
        public byte[] REF_PHOTO2 { get; set; }
        public byte[] REF_PHOTO3 { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
    
        public virtual TRN_VISITOR TRN_VISITOR { get; set; }
    }
}
