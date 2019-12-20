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
        public TRN_PROJECT_MASTER _TRN_PROJECT_MASTER = new TRN_PROJECT_MASTER();
        public List<TRN_PROJECT_MEMBER> LIST_TRN_PROJECT_MEMBER = new List<TRN_PROJECT_MEMBER>();
        private ProjectServices service = new ProjectServices();
        public frmProjectMasters()
        {
            InitializeComponent();
        }



        private void FrmProjectMasters_Load(object sender, EventArgs e)
        {
            InitialDropdown();
            InitialControl();
        }

        private void InitialControl()
        {
            if (formMode == MODEL.CustomModel.FormMode.Add)
            {
                gridEmployee.DataSource = new List<TRN_PROJECT_MEMBER>();
                txtDate.Text = DateTime.Now.ToString();
                this.Text = "Request Project";
            }
            if (formMode == MODEL.CustomModel.FormMode.View)
            {
                this.Text = "View Project";
                comboCompany.Enabled = false;
                txtProjectname.ReadOnly = true;
                btnAddEmployee.Enabled = false;
                txtForeman.ReadOnly = true;
                txtForemanTel.ReadOnly = true;
                txtScope.ReadOnly = true;
                txtWorkArea.ReadOnly = true;
                txtVerifyPurchase.ReadOnly = true;
                txtPurchaseManager.ReadOnly = true;
                txtSafetyApprove.ReadOnly = true;
                txtHraApprove.ReadOnly = true;
                dtFrom.Enabled = false;
                dtTo.Enabled = false;
                dtPurchase.Enabled = false;
                dtTo.Enabled = false;
                dtPurchase.Enabled = false;
                dtIssuseDate.Enabled = false;
                dtExpireDate.Enabled = false;
                dtHraExpire.Enabled = false;
                dtHraIssue.Enabled = false;
                chkHoliday.Enabled = false;
                chkNotTrRequire.Enabled = false;
                chkTraingRequire.Enabled = false;
                chkWorkDay.Enabled = false;
                radAlldays.Enabled = false;
                radEvening.Enabled = false;
                radMoring.Enabled = false;
                radTemp.Enabled = false;
                radAlldays.Enabled = false;
                radOther.Enabled = false;
                radPerm.Enabled = false;
                txtOtherTime.ReadOnly = true;
                btnAddEmployee.Enabled = false;
                btnSave1.Enabled = false;
                gridEmployee.Columns[0].Visible = false;
                gridEmployee.Columns[1].Visible = false;
                SetControlData();
            }
            if (formMode == MODEL.CustomModel.FormMode.Edit)
            {
                SetControlData();
                this.Text = "Edit Project";
            }


        }

        private void SetControlData()
        {
            var obj = _TRN_PROJECT_MASTER;
            txtDate.Text = obj.PROJECT_START_DATE.ToString();
            txtProjectname.Text = obj.PROJECT_NAME;
            comboCompany.SelectedValue = obj.CONTRACTOR_ID;
            gridEmployee.DataSource = obj.TRN_PROJECT_MEMBER.ToList();
            txtForeman.Text = obj.RESPONSIBLE_MANAGER;
            txtForemanTel.Text = obj.RESPONSIBLE_TEL;
            txtWorkArea.Text = obj.WORKING_AREA;
            txtVerifyPurchase.Text = obj.PURCHASING_VERIFY_BY;

            txtHraApprove.Text = obj.HRA_MANAGER_APP_BY;
            txtScope.Text = obj.PROJECT_SCOPE;
            txtPurchaseManager.Text = obj.RESPONSIBLE_DEP_HEAD;
            txtSafetyApprove.Text = obj.SAFETY_MANAGER_APP_BY;
            dtFrom.Value = Convert.ToDateTime(obj.PROJECT_START_DATE);
            dtTo.Value = Convert.ToDateTime(obj.PROJECT_END_DATE);

            dtPurchase.Value = Convert.ToDateTime(obj.PURCHASING_VERIFY_DATE);

            if (obj.SAFETY_TRAINING_REQUIRE == "อบรม")
            {
                chkTraingRequire.Checked = true;
            }
            else
            {
                chkNotTrRequire.Checked = true;
            }

            if (obj.ID_BADGE_TYPE == "ถาวร")
            {
                radPerm.Checked = true;
                dtHraExpire.Value = Convert.ToDateTime(obj.ID_BADGE_EXPIRED_DATE);

            }
            else
            {
                radTemp.Checked = true;
                dtHraIssue.Value = Convert.ToDateTime(obj.ID_BADGE_ISSUED_DATE);
            }


            if (obj.WORKING_DAY == "วันทำการ")
            {
                chkWorkDay.Checked = true;
            }
            else
            {
                chkHoliday.Checked = true;
            }

            if (obj.PROJECT_WORKING_TIME == radMoring.Text)
            {
                radMoring.Checked = true;
            }
            else if (obj.PROJECT_WORKING_TIME == radEvening.Text)
            {
                radEvening.Checked = true;
            }
            else if (obj.PROJECT_WORKING_TIME == radAlldays.Text)
            {
                radAlldays.Checked = true;
            }
            else
            {
                txtOtherTime.Text = obj.PROJECT_WORKING_TIME;
                radOther.Checked = true;
            } 
        }

        private void InitialDropdown()
        {
            AddRangeComboBox(comboCompany, new ComboBoxServices().GetComboConstractor());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateControl())
            {
                if (MessageBox.Show("ต้องการบันทึกข้อมูลใช่หรือไม่ ?", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (formMode == MODEL.CustomModel.FormMode.Add)
                    {
                        TRN_PROJECT_MASTER project = new TRN_PROJECT_MASTER()
                        {
                            REGISTER_DATE = DateTime.Now,

                            RESPONSIBLE_MANAGER = txtForeman.Text,
                            RESPONSIBLE_TEL = txtForemanTel.Text,
                            PROJECT_NAME = txtProjectname.Text,

                            PROJECT_SCOPE = txtScope.Text,
                            WORKING_AREA = txtWorkArea.Text,
                            RESPONSIBLE_DEP_HEAD = txtPurchaseManager.Text,
                            WORKING_DAY = chkWorkDay.Checked ? "วันทำงาน" : "วันหยุด",
                            PROJECT_START_DATE = dtFrom.Value,
                            PROJECT_END_DATE = dtTo.Value,
                            PURCHASING_VERIFY_BY = txtVerifyPurchase.Text,
                            PURCHASING_VERIFY_DATE = dtPurchase.Value,

                            SAFETY_MANAGER_APP_BY = txtSafetyApprove.Text,
                            SAFETY_TRAINING_EXPIRED_DATE = dtExpireDate.Value,
                            SAFETY_TRAINING_ISSUED_DATE = dtIssuseDate.Value,
                            SAFETY_TRAINING_REQUIRE = chkTraingRequire.Checked ? "อบรม" : "ไม่อบรม",

                            HRA_MANAGER_APP_BY = txtHraApprove.Text,
                            ID_BADGE_TYPE = radPerm.Checked ? "ถาวร" : "ชั่วคราว",

                            CREATED_BY = LOGIN,
                            CREATED_DATE = DateTime.Now,
                            UPDATED_BY = LOGIN,
                            UPDATED_DATE = DateTime.Now,
                            CONTRACTOR_ID = Convert.ToInt32(comboCompany.SelectedValue),

                            TRN_PROJECT_MEMBER = new List<TRN_PROJECT_MEMBER>()

                        };

                        if (radMoring.Checked) project.PROJECT_WORKING_TIME = radMoring.Text;
                        if (radAlldays.Checked) project.PROJECT_WORKING_TIME = radAlldays.Text;
                        if (radEvening.Checked) project.PROJECT_WORKING_TIME = radEvening.Text;
                        if (radOther.Checked) project.PROJECT_WORKING_TIME = txtOtherTime.Text;

                        if (radTemp.Checked)
                        {
                            project.ID_BADGE_ISSUED_DATE = dtHraIssue.Value;
                        }
                        else
                        {
                            project.ID_BADGE_EXPIRED_DATE = dtHraIssue.Value;
                        }

                        project.TRN_PROJECT_MEMBER = (List<TRN_PROJECT_MEMBER>)gridEmployee.DataSource;


                        var resp = service.AddProject(project);
                        if (resp.Status)
                        {

                            MessageBox.Show(Message.MSG_SAVE_COMPLETE, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(resp.Message + resp.ExceptionMessage);
                        }
                    }
                    else
                    {
                        var project = _TRN_PROJECT_MASTER;

                        project.RESPONSIBLE_MANAGER = txtForeman.Text;
                        project.RESPONSIBLE_TEL = txtForemanTel.Text;
                        project.PROJECT_NAME = txtProjectname.Text;
                        project.PROJECT_SCOPE = txtScope.Text;
                        project.WORKING_AREA = txtWorkArea.Text;

                        project.RESPONSIBLE_DEP_HEAD = txtPurchaseManager.Text;
                        project.WORKING_DAY = chkWorkDay.Checked ? "วันทำงาน" : "วันหยุด";
                        project.PROJECT_START_DATE = dtFrom.Value;
                        project.PROJECT_END_DATE = dtTo.Value;
                        project.PURCHASING_VERIFY_BY = txtVerifyPurchase.Text;
                        project.PURCHASING_VERIFY_DATE = dtPurchase.Value;

                        project.SAFETY_MANAGER_APP_BY = txtSafetyApprove.Text;
                        project.SAFETY_TRAINING_EXPIRED_DATE = dtExpireDate.Value;
                        project.SAFETY_TRAINING_ISSUED_DATE = dtIssuseDate.Value;
                        project.HRA_MANAGER_APP_BY = txtHraApprove.Text;
                        project.SAFETY_TRAINING_REQUIRE = chkTraingRequire.Checked ? "อบรม" : "ไม่อบรม";
                        project.ID_BADGE_TYPE = radPerm.Checked ? "ถาวร" : "ชั่วคราว";

                        project.UPDATED_BY = LOGIN;
                        project.UPDATED_DATE = DateTime.Now;
                        project.CONTRACTOR_ID = Convert.ToInt32(comboCompany.SelectedValue);
                        project.TRN_PROJECT_MEMBER = new List<TRN_PROJECT_MEMBER>();

                        if (radMoring.Checked) project.PROJECT_WORKING_TIME = radMoring.Text;
                        if (radAlldays.Checked) project.PROJECT_WORKING_TIME = radAlldays.Text;
                        if (radEvening.Checked) project.PROJECT_WORKING_TIME = radEvening.Text;
                        if (radOther.Checked) project.PROJECT_WORKING_TIME = txtOtherTime.Text;

                        if (radTemp.Checked)
                        {
                            project.ID_BADGE_ISSUED_DATE = dtHraIssue.Value;
                        }
                        else
                        {
                            project.ID_BADGE_EXPIRED_DATE = dtHraIssue.Value;
                        }

                        project.TRN_PROJECT_MEMBER = (List<TRN_PROJECT_MEMBER>)gridEmployee.DataSource; 
                        var resp = service.UpdateProject(project);
                        if (resp.Status)
                        {

                            MessageBox.Show(Message.MSG_SAVE_COMPLETE, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(resp.Message + resp.ExceptionMessage);
                        }
                    } 
                }
            }

        }

        private bool ValidateControl()
        {
            List<string> listMsg = new List<string>();
            if (string.IsNullOrEmpty(txtProjectname.Text)) listMsg.Add("Project name");
            if (string.IsNullOrEmpty(txtForeman.Text)) listMsg.Add("Forman Name");
            if (Convert.ToInt32(comboCompany.SelectedValue) == 0) listMsg.Add("Company");

            if (radOther.Checked && txtOtherTime.Text == "  :")
            {
                listMsg.Add("Visitor Time");

            }

            string joined = string.Join("," + Environment.NewLine, listMsg);

            if (listMsg.Count > 0)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ " + Environment.NewLine + joined, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            } 
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            var frm = new frmProjectMember();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var listEmployee = (List<TRN_PROJECT_MEMBER>)gridEmployee.DataSource;
                if (formMode == MODEL.CustomModel.FormMode.Add)
                {
                    listEmployee.Add(frm.TRN_PROJECT_MEMBER);
                }
                else
                {
                    listEmployee.Add(frm.TRN_PROJECT_MEMBER);
                    frm.TRN_PROJECT_MEMBER.PROJECT_ID = _TRN_PROJECT_MASTER.AUTO_ID;
                    var resp = service.AddProjectMember(frm.TRN_PROJECT_MEMBER);
                    if (!resp.Status)
                    {
                        MessageBox.Show(resp.Message + resp.ExceptionMessage);
                    }
                }

                gridEmployee.DataSource = listEmployee.ToList();
            }
        }

        private void comboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(comboCompany.SelectedValue);
            if (id != 0)
            {
                var resp = service.GetConstractor(id);
                if (resp.Status)
                {
                    MAS_CONTRACTOR obj = (MAS_CONTRACTOR)resp.ResultObj;
                    txtAddress.Text = obj.ADDRESS;
                    txtTel.Text = obj.TEL;
                }
            }
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadTemp_CheckedChanged(object sender, EventArgs e)
        {

            dtHraIssue.Enabled = true;
            dtHraExpire.Enabled = false;
        }

        private void RadPerm_CheckedChanged(object sender, EventArgs e)
        {
            dtHraIssue.Enabled = false;
            dtHraExpire.Enabled = true;
        }



        private void GridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0) //delete
                {
                    var id = Convert.ToInt32(gridEmployee.Rows[e.RowIndex].Cells["AUTO_ID"].Value);
                    var listEmployee = (List<TRN_PROJECT_MEMBER>)gridEmployee.DataSource;
                    if (id > 0)
                    {
                        var resp = service.GetProjectMember(id);
                        if (resp.Status)
                        {
                            frmProjectMember frm = new frmProjectMember();
                            frm.TRN_PROJECT_MEMBER = resp.ResultObj;
                            frm.formMode = MODEL.CustomModel.FormMode.Edit;
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                var resp2 = service.GetListProjectMember(((TRN_PROJECT_MEMBER)resp.ResultObj).PROJECT_ID);
                                if (resp2.Status)
                                {
                                    gridEmployee.DataSource = (List<TRN_PROJECT_MEMBER>)resp2.ResultObj;
                                }
                            }
                        }

                    }
                    else
                    {
                        var temp = (List<TRN_PROJECT_MEMBER>)gridEmployee.DataSource;
                        var obj = temp[e.RowIndex];
                        frmProjectMember frm = new frmProjectMember();
                        frm.TRN_PROJECT_MEMBER = obj;
                        frm.formMode = MODEL.CustomModel.FormMode.Edit;
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            temp[e.RowIndex] = frm.TRN_PROJECT_MEMBER;
                        }
                        //gridEmployee.DataSource = null;

                        //var bindingSource1 = new System.Windows.Forms.BindingSource { DataSource = temp };
                       // dataGridView1.DataSource = bindingSource1;
                        gridEmployee.DataSource = temp;
                        gridEmployee.Refresh();
                    }

                }
                if (e.ColumnIndex == 1) //Delete
                {
                    if (MessageBox.Show(Message.MSG_DELETE_CONFIRM, "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        var id = Convert.ToInt32(gridEmployee.Rows[e.RowIndex].Cells["AUTO_ID"].Value);
                        var listEmployee = (List<TRN_PROJECT_MEMBER>)gridEmployee.DataSource;
                        if (id > 0)
                        {
                            var resp = service.DeleteProjectMember(id);
                            if (!resp.Status)
                            {
                                MessageBox.Show(resp.Message + resp.ExceptionMessage);
                            }
                            else
                            {
                                gridEmployee.DataSource = (List<TRN_PROJECT_MEMBER>)resp.ResultObj;
                            }
                        }
                        else
                        {
                            List<TRN_PROJECT_MEMBER> temp = new List<TRN_PROJECT_MEMBER>();
                            listEmployee.RemoveAt(e.RowIndex);
                            foreach (var item in listEmployee)
                            {
                                temp.Add(item);

                            };
                            gridEmployee.DataSource = (List<TRN_PROJECT_MEMBER>)temp;
                        }
                    }
                }
            }
        }
    }
}
