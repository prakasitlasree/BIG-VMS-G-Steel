using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.EntityModel;
using BIG.VMS.MODEL.GsteelModel.CustomModel;
using BIG.VMS.MODEL.GsteelModel.FilterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIG.VMS.MODEL.GsteelModel.ContainerModel
{
    public class ContainerConstractor
    {
        public List<MAS_CONTRACTOR> ListData { get; set; }

        public Pagination PageInfo { get; set; }

        public FilterConstractor Filter { get; set; }

        public ContainerConstractor()
        {
            ListData = new List<MAS_CONTRACTOR>();
            PageInfo = new Pagination();
            Filter = new FilterConstractor();
        }
    }
}
