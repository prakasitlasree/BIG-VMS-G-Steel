using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIG.VMS.MODEL.CustomModel.CustomContainer
{
   public class CustomReason
    {
        public int AUTO_ID { get; set; }
        public string REASON { get; set; }
        public string SHOW_FLAG { get; set; }
        public Nullable<int> SHOW_SEQ { get; set; }
        public Nullable<int> DEPT_ID { get; set; }
    }
}
