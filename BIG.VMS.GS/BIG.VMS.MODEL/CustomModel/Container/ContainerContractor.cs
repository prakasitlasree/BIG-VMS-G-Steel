using BIG.VMS.MODEL.CustomModel.Filter;
using BIG.VMS.MODEL.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIG.VMS.MODEL.CustomModel.Container
{
  public  class ContainerContractor
    {
        public bool Status { get; set; }

        public string Message { get; set; }

        public string ExceptionMessage { get; set; }

        public dynamic ResultObj { get; set; }

        public MAS_CONTRACTOR MAS_CONTRACTOR { get; set; }

        public ContractorFilter Filter { get; set; }

        public Pagination PageInfo { get; set; }

    }
}
