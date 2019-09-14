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

        private bool ValidateControl()
        {
            List<string> listMsg = new List<string>();
            if (string.IsNullOrEmpty(comboType.Text)) listMsg.Add("ประเภท");
            if (string.IsNullOrEmpty(txtIDCard.Text)) listMsg.Add("รหัสบัตร");
            if (string.IsNullOrEmpty(txtName.Text)) listMsg.Add("ชื่อ");
            if (string.IsNullOrEmpty(txtPosition.Text)) listMsg.Add("ตำแหน่ง");
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

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidateControl())
            {
                TRN_PROJECT_MEMBER obj = new TRN_PROJECT_MEMBER()
                {
                    CARD_TYPE = comboType.Text,
                    FULLNAME = txtName.Text,
                    ID_CARD = txtIDCard.Text,
                    SAFETY_TRAINING_FLAG = radRequire.Checked ? "Y" : "N",
                    POSITION = txtPosition.Text
                };

                TRN_PROJECT_MEMBER = obj;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
           
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
            comboType.SelectedIndex = 0;
        }
    }
}
