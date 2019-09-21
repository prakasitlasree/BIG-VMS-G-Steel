using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIG.VMS.MODEL.CustomModel
{
    public enum FormMode
    {
        Add,
        View,
        Edit,
    }

    public enum VisitorGroup
    {
        CONSTRUCTOR,
        CUSTOMER,
        NORMAL,
        APPOINTMENT,
    }

    public enum VisitorType
    {
        IN,
        OUT
    }

    public enum VisitorMode
    {
        In,
        Out,
        Appointment,
        AppointmentOut,
        ConstructorIn,
        ConstructorOut,
        CustomerIn,
        CustomerOut
    }
}
