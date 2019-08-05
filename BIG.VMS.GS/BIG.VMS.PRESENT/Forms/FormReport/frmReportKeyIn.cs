using BIG.VMS.MODEL.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIG.VMS.PRESENT.Forms.FormReport
{
    public partial class frmReportKeyIn : PageBase
    {
        public TRN_VISITOR visitorObj = new TRN_VISITOR();

        public frmReportKeyIn()
        {
            InitializeComponent();
        }

        private void frmReportKeyIn_Load(object sender, EventArgs e)
        {

        }
    }
}
