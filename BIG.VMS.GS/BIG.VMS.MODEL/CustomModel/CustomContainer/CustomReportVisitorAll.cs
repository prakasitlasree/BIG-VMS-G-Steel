using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIG.VMS.MODEL.CustomModel.CustomContainer
{
    public class CustomReportVisitorAll
    {
        public string NO { get; set; }
        public string TIME_IN { get; set; }
        public string TIME_OUT { get; set; }
        public string ID_CARD { get; set; }
        public string FULL_NAME { get; set; }

        public string CAR_INFO { get; set; }
        public string EMP_NAME { get; set; }
        public string REASON_TEXT { get; set; }
        public string CREATED_BY { get; set; }

    }

    public class CustomReportVisitor
    {
        public string NO { get; set; }
        public string TIME { get; set; }
        public string TYPE { get; set; }
        public string GROUP { get; set; }
        public string ID_CARD { get; set; }
        public string FULL_NAME { get; set; }

        public string CAR_INFO { get; set; }
        public string EMP_NAME { get; set; }
        public string REASON_TEXT { get; set; }
        public string CREATED_BY { get; set; }

    }
}
