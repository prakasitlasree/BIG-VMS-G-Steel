using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIG.VMS.MODEL.CustomModel.CustomContainer
{
    public class CustomEmployee
    {
        public int AUTO_ID { get; set; }
        //public Nullable<int> DEPARTMENT_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string DEPARTMENT { get; set; }
       
        public int? SHOW_SEQ { get; set;  }
    }
}
