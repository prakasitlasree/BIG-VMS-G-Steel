using BIG.VMS.DATASERVICE;
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

namespace BIG.VMS.PRESENT.Forms.CustomerVisit
{
    public partial class frmPlantVisitor : Form
    {
        public TRN_CUSTOMER_VISIT_LIST TRN_CUSTOMER_VISIT_LIST = new TRN_CUSTOMER_VISIT_LIST();
        public int seq = 0;
        public frmPlantVisitor()
        {
            InitializeComponent();
        }

        private bool ValidateControl()
        {
            List<string> listMsg = new List<string>();

            if (string.IsNullOrEmpty(txtName.Text)) listMsg.Add("ชื่อ");

            string joined = string.Join("," + Environment.NewLine, listMsg);

            if (listMsg.Count > 0)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ " + joined, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }


        }

        private void FrmPlantVisitor_Load(object sender, EventArgs e)
        {
            numSeq.Value = seq;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateControl())
            {
                TRN_CUSTOMER_VISIT_LIST obj = new TRN_CUSTOMER_VISIT_LIST()
                {
                    FULLNAME = txtName.Text,
                    SEQ = Convert.ToInt32 (numSeq.Value),
                    
                    
                };

                TRN_CUSTOMER_VISIT_LIST = obj;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
