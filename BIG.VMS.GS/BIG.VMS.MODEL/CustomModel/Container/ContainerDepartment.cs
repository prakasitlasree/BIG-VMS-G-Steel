using BIG.VMS.MODEL.CustomModel.CustomContainer;
using BIG.VMS.MODEL.CustomModel.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIG.VMS.MODEL.CustomModel.Container
{
    public class ContainerDepartment
    {
        public bool Status { get; set; }

        public string Message { get; set; }

        public string ExceptionMessage { get; set; }

        public List<CustomDepartment> ResultObj { get; set; }

        public FilterDepartment Filter { get; set; }

        public Pagination PageInfo { get; set; }
    }
}
