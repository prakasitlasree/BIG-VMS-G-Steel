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

namespace BIG.VMS.PRESENT.Forms.Contractor
{
    public partial class frmProjectMasters : PageBase
    {
        public frmProjectMasters()
        {
            InitializeComponent();
        }

   

        private void FrmProjectMasters_Load(object sender, EventArgs e)
        {
            InitialControl();
        }

        private void InitialControl()
        {
            if(formMode == MODEL.CustomModel.FormMode.Add)
            {
                gridEmployee.DataSource = new List<TRN_PROJECT_MEMBER>();
                txtDate.Text = DateTime.Now.ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการบันทึกข้อมูลใช่หรือไม่ ?", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MAS_CONTRACTOR constractor = new MAS_CONTRACTOR();
                TRN_PROJECT_MASTER project = new TRN_PROJECT_MASTER();
                List<TRN_PROJECT_MEMBER> member = new List<TRN_PROJECT_MEMBER>();
            }
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            var frm = new frmProjectMember();
            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var listEmployee = (List<TRN_PROJECT_MEMBER>)gridEmployee.DataSource;
                listEmployee.Add(frm.TRN_PROJECT_MEMBER);
               
            }
        }
    }
}
