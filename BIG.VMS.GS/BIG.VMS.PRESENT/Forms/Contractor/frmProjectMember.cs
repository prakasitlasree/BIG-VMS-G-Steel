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
    public partial class frmProjectMember : Form
    {
        public TRN_PROJECT_MEMBER TRN_PROJECT_MEMBER = new TRN_PROJECT_MEMBER();
        public frmProjectMember()
        {
            InitializeComponent();
        }

        

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            TRN_PROJECT_MEMBER obj = new TRN_PROJECT_MEMBER()
            {
                CARD_TYPE = txtCardType.Text,
                FULLNAME = txtName.Text,
                ID_CARD = txtIDCard.Text,
                SAFETY_TRAINING_FLAG = radRequire.Checked ? "Y" : "N",
                POSITION = txtPosition.Text
            };

            TRN_PROJECT_MEMBER = obj;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmProjectMember_Load(object sender, EventArgs e)
        {

        }
    }
}
