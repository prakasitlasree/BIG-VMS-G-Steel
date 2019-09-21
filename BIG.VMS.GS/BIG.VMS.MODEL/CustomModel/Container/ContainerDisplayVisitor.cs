using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIG.VMS.MODEL.CustomModel.CustomContainer;

namespace BIG.VMS.MODEL.CustomModel.Container
{
    public class ContainerDisplayVisitor
    {
        public bool Status { get; set; }

        public string Message { get; set; }

        public string ExceptionMessage { get; set; }

        public List<CustomDisplayVisitor> ResultObj { get; set; }

        public VisitorFilter Filter { get; set; }

        public Pagination PageInfo { get; set; }
    }
}
