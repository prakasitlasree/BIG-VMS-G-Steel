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
    public partial class frmProjectMasters : PageBase
    {
        public MAS_CONTRACTOR MAS_CONTRACTOR = new MAS_CONTRACTOR();
        public List<TRN_PROJECT_MEMBER> LIST_TRN_PROJECT_MEMBER = new List<TRN_PROJECT_MEMBER>();
        private ProjectServices service = new ProjectServices();
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
            if (formMode == MODEL.CustomModel.FormMode.Add)
            {
                gridEmployee.DataSource = new List<TRN_PROJECT_MEMBER>();
                txtDate.Text = DateTime.Now.ToString();
            }

            AddRangeComboBox(comboCompany, new ComboBoxServices().GetComboConstractor());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการบันทึกข้อมูลใช่หรือไม่ ?", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                TRN_PROJECT_MASTER project = new TRN_PROJECT_MASTER()
                {
                    REGISTER_DATE = DateTime.Now,
                    RESPONSIBLE_MANAGER = txtResponse.Text,
                    RESPONSIBLE_TEL = txtResponseTel.Text,
                    PROJECT_NAME = txtProjectname.Text,
                    PROJECT_SCOPE = txtScope.Text,
                    WORKING_AREA = txtWorkArea.Text,
                    RESPONSIBLE_DEP_HEAD = txtPurchaseManager.Text,
                    WORKING_DAY = chkWorkDay.Checked ? "วันทำงาน" : "วันหยุด",
                    PROJECT_START_DATE = dtFrom.Value,
                    PROJECT_END_DATE = dtTo.Value,                   
                    PURCHASING_VERIFY_BY = txtPurchaseManager.Text,
                    PURCHASING_VERIFY_DATE = txtPurchaseDate.Value,
                    SAFETY_MANAGER_APP_BY = txtSafetyApprove.Text,
                    SAFETY_TRAINING_EXPIRED_DATE = dtExpireDate.Value,
                    SAFETY_TRAINING_ISSUED_DATE = dtIssuseDate.Value,
                    HRA_MANAGER_APP_BY = txtHraApprove.Text,
                    ID_BADGE_EXPIRED_DATE = dtHraExpire.Value,
                    ID_BADGE_ISSUED_DATE = dtHraIssue.Value,
                    SAFETY_TRAINING_REQUIRE = chkTraingRequire.Checked ? "อบรม" : "ไม่อบรม",
                    ID_BADGE_TYPE = radPerm.Checked ? "ถาวร" : "ชั่วคราว",
                    CREATED_BY = LOGIN,
                    CREATED_DATE = DateTime.Now,
                    UPDATED_BY = LOGIN,
                    UPDATED_DATE = DateTime.Now,
                    TRN_PROJECT_MEMBER = new List<TRN_PROJECT_MEMBER>()

                };
                LIST_TRN_PROJECT_MEMBER = (List<TRN_PROJECT_MEMBER>)gridEmployee.DataSource;

                foreach (var item in LIST_TRN_PROJECT_MEMBER)
                {
                    project.TRN_PROJECT_MEMBER.Add(item);
                }

                if(MAS_CONTRACTOR.TRN_PROJECT_MASTER != null)
                {
                    MAS_CONTRACTOR.TRN_PROJECT_MASTER.Add(project);
                }
                

                var resp = service.UpdateConstractor(MAS_CONTRACTOR);
                if (resp.Status)
                {
                    MessageBox.Show(Message.MSG_SAVE_COMPLETE, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(resp.Message + resp.ExceptionMessage);
                }
            }
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            var frm = new frmProjectMember();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var listEmployee = (List<TRN_PROJECT_MEMBER>)gridEmployee.DataSource;
                listEmployee.Add(frm.TRN_PROJECT_MEMBER);
                gridEmployee.DataSource = listEmployee.ToList();
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id   = Convert.ToInt32(comboCompany.SelectedValue);
            if (id != 0)
            {
                var resp = service.GetConstractor(id);
                if (resp.Status)
                {
                    MAS_CONTRACTOR obj = (MAS_CONTRACTOR)resp.ResultObj;
                    this.MAS_CONTRACTOR = obj;
                    txtAddress.Text = obj.ADDRESS;
                    txtTel.Text = obj.TEL;
                }
            }
        }
    }
}
