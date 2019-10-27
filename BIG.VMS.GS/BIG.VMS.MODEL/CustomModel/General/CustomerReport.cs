using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIG.VMS.MODEL.CustomModel.General
{
    public class CUSTOMER_HEADER
    {
        public string REQ_NAME { get; set; }
        public string REQ_POSITION { get; set; }
        public string REQ_DEPT { get; set; }
        public string CUST_GROUP_NAME { get; set; }
        public string CUST_OBJECTIVE { get; set; }
        public string COMPANY_NAME { get; set; }
    }

    public class CUSTOMER
    {
        public string ID_CARD { get; set; }
        public string CUST_NAME { get; set; }
      
    }

    public class CustomerReport
    {
        public List<CUSTOMER_HEADER> LIST_CUSTOMER_HEADER { get; set; }
        public List<CUSTOMER> LIST_CUSTOMER { get; set; }
    }

}
