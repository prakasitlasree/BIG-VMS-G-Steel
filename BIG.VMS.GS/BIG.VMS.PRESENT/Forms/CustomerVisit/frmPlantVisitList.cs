using BIG.VMS.MODEL.CustomModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIG.VMS.PRESENT.Forms.CustomerVisit
{
    public partial class frmPlantVisitList : Form
    {
        public frmPlantVisitList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmPlantVisit();
            frm.formMode = FormMode.Add;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //BindGridData();
            }
        }
    }
}
