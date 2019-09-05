using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.EntityModel;
using BIG.VMS.MODEL.GsteelModel.FilterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIG.VMS.MODEL.GsteelModel.ContainerModel
{
    public class ContainerProject
    {
        public List<TRN_PROJECT_MASTER> ListData { get; set; }

        public Pagination PageInfo { get; set; }

        public FilterProject Filter { get; set; }

        public ContainerProject()
        {
            ListData = new List<TRN_PROJECT_MASTER>();
            PageInfo = new Pagination();
            Filter = new FilterProject();
        }
    }
}
