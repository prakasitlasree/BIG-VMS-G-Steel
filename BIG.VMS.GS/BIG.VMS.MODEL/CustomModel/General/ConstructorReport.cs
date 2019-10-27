using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIG.VMS.MODEL.GsteelModel.CustomModel
{
    public class ProjectHeader
    {
        public  string PROJECT_NAME { get; set; }
        public string RESP_MANAGER { get; set; }
        public string RESP_TEL { get; set; }
        public string CONTRUCTOR_NAME { get; set; }
        public string CONTRUCTOR_TEL { get; set; }
        public string COMPANY_NAME { get; set; }
    }

    public class ProjectMember
    {
        public string ID_CARD { get; set; }
        public string FULLNAME { get; set; }
    }

    public class Project
    {
        public List<ProjectHeader> LIST_PROJECT_HEADER { get; set; }
        public List<ProjectMember> LIST_PROJECT_MEMBER { get; set; }
    }
}
