using BIG.VMS.MODEL.CustomModel.Filter;
using BIG.VMS.MODEL.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIG.VMS.MODEL.CustomModel.Container
{
   public class ContainerPlanVisit
    {
        public bool Status { get; set; }

        public string Message { get; set; }

        public string ExceptionMessage { get; set; }

        public dynamic ResultObj { get; set; }

        public PlanVisitFilter Filter { get; set; }

        public TRN_CUSTOMER_VISIT TRN_CUSTOMER_VISIT { get; set; }

        public Pagination PageInfo { get; set; }

    }
}
