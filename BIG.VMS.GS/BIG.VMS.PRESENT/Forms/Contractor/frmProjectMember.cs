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

namespace BIG.VMS.PRESENT.Forms.Contractor
{
    public partial class frmProjectMember : PageBase
    {
        public TRN_PROJECT_MEMBER TRN_PROJECT_MEMBER = new TRN_PROJECT_MEMBER();
        private ProjectServices service = new ProjectServices();
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
                if (formMode == MODEL.CustomModel.FormMode.Edit && TRN_PROJECT_MEMBER.AUTO_ID > 0)
                {
                    this.TRN_PROJECT_MEMBER.CARD_TYPE = comboType.Text;
                    this.TRN_PROJECT_MEMBER.FULLNAME = txtName.Text + " " + txtLastName.Text;
                    this.TRN_PROJECT_MEMBER.ID_CARD = txtIDCard.Text;
                    this.TRN_PROJECT_MEMBER.SAFETY_TRAINING_FLAG = radRequire.Checked ? "Y" : "N";
                    this.TRN_PROJECT_MEMBER.POSITION = txtPosition.Text;
                    if (radRequire.Checked)
                    {
                        this.TRN_PROJECT_MEMBER.TRAINING_ISSUE_DATE = dtTrainIssue.Value;
                        this.TRN_PROJECT_MEMBER.TRAINING_EXPIRE_DATE = dtTrainExpire.Value;
                    }
                    else
                    {
                        this.TRN_PROJECT_MEMBER.TRAINING_ISSUE_DATE = null;
                        this.TRN_PROJECT_MEMBER.TRAINING_EXPIRE_DATE = null;
                    }
                    

                    var resp = service.UpdateProjectMember(TRN_PROJECT_MEMBER);
                    if (resp.Status)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else if (formMode == MODEL.CustomModel.FormMode.Edit && TRN_PROJECT_MEMBER.AUTO_ID == 0)
                {
                    this.TRN_PROJECT_MEMBER.CARD_TYPE = comboType.Text;
                    this.TRN_PROJECT_MEMBER.FULLNAME = txtName.Text + " " + txtLastName.Text;
                    this.TRN_PROJECT_MEMBER.ID_CARD = txtIDCard.Text;
                    this.TRN_PROJECT_MEMBER.SAFETY_TRAINING_FLAG = radRequire.Checked ? "Y" : "N";
                    this.TRN_PROJECT_MEMBER.POSITION = txtPosition.Text;
                    if (radRequire.Checked)
                    {
                        this.TRN_PROJECT_MEMBER.TRAINING_ISSUE_DATE = dtTrainIssue.Value;
                        this.TRN_PROJECT_MEMBER.TRAINING_EXPIRE_DATE = dtTrainExpire.Value;
                    }
                    else
                    {
                        this.TRN_PROJECT_MEMBER.TRAINING_ISSUE_DATE = null;
                        this.TRN_PROJECT_MEMBER.TRAINING_EXPIRE_DATE = null;
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                  
                }
                else
                {
                    TRN_PROJECT_MEMBER obj = new TRN_PROJECT_MEMBER()
                    {
                        CARD_TYPE = comboType.Text,
                        FULLNAME = txtName.Text + " " + txtLastName.Text,
                        ID_CARD = txtIDCard.Text,
                        SAFETY_TRAINING_FLAG = radRequire.Checked ? "Y" : "N",
                        POSITION = txtPosition.Text,
                        TRAINING_ISSUE_DATE = dtTrainIssue.Value,
                        TRAINING_EXPIRE_DATE = dtTrainExpire.Value
                    };

                    TRN_PROJECT_MEMBER = obj;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

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
            if (formMode == MODEL.CustomModel.FormMode.Edit)
            {
                comboType.SelectedText = TRN_PROJECT_MEMBER.CARD_TYPE;
                var split = TRN_PROJECT_MEMBER.FULLNAME.Split(' ');
                if (split.Count() == 2)
                {
                    txtName.Text = split[0];
                    txtLastName.Text = split[1];

                }
                else
                {
                    txtName.Text = TRN_PROJECT_MEMBER.FULLNAME;
                }

                if (TRN_PROJECT_MEMBER.SAFETY_TRAINING_FLAG == "Y")
                {
                    radRequire.Checked = true;
                }
                else
                {
                    radNotRequire.Checked = true;
                }
                txtIDCard.Text = TRN_PROJECT_MEMBER.ID_CARD;
                txtPosition.Text = TRN_PROJECT_MEMBER.POSITION;
                dtTrainIssue.Value = TRN_PROJECT_MEMBER.TRAINING_ISSUE_DATE == null ? dtTrainIssue.MinDate : Convert.ToDateTime(TRN_PROJECT_MEMBER.TRAINING_ISSUE_DATE);
                dtTrainExpire.Value = TRN_PROJECT_MEMBER.TRAINING_EXPIRE_DATE == null ? dtTrainExpire.MinDate : Convert.ToDateTime(TRN_PROJECT_MEMBER.TRAINING_EXPIRE_DATE);
            }
            else
            {
                comboType.SelectedIndex = 0;
            }

        }
    }
}
