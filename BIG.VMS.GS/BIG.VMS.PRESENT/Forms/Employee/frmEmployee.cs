using BIG.VMS.DATASERVICE;
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.CustomModel.Container;
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

namespace BIG.VMS.PRESENT.Forms.Employee
{
    public partial class frmEmployee : PageBase
    {
        private readonly EmployeeServices _service = new EmployeeServices();
        private ContainerEmployee _container = new ContainerEmployee();
        private ComboBoxServices _comboService = new ComboBoxServices();
        public int employee_id = 0;
        public int dept_id = 0;
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            comboDept.DataSource = _comboService.GetComboDepartment(true);
            comboDept.DisplayMember = "Text";
            comboDept.ValueMember = "Value";
            if (formMode == FormMode.Add && dept_id > 0)
            {
                comboDept.SelectedValue = dept_id;
            }
            if (formMode == FormMode.View)
            {
                btnSave.Visible = false;
                txtFirstName.ReadOnly = true;
                txtLastName.ReadOnly = true;
                comboDept.Enabled = false;
                numSeq.Enabled = false;
                radNotShow.Enabled = false;
                radShow.Enabled = false;
                lbType.Text = "ดูข้อมูลพนักงาน";
                var resp = _service.GetEmployee(employee_id);
                if (resp.Status)
                {
                    var employee = (MAS_EMPLOYEE)resp.ResultObj;
                    txtFirstName.Text = employee.FIRST_NAME;
                    txtLastName.Text = employee.LAST_NAME;
                    numSeq.Value = Convert.ToDecimal(employee.SHOW_SEQ);
                    comboDept.SelectedValue = employee.DEPARTMENT_ID;
                    if(employee.SHOW_FLAG == "Y")
                    {
                        radShow.Checked = true;
                        radNotShow.Checked = false;
                    }
                    else
                    {
                        radNotShow.Checked = true;
                        radShow.Checked = false;
                    }
                }
            }
            if (formMode == FormMode.Edit)
            {
                lbType.Text = "แก้ไขพนักงาน";
                var resp = _service.GetEmployee(employee_id);
                if (resp.Status)
                {
                    var employee = (MAS_EMPLOYEE)resp.ResultObj;
                    txtFirstName.Text = employee.FIRST_NAME;
                    txtLastName.Text = employee.LAST_NAME;
                    numSeq.Value = Convert.ToDecimal(employee.SHOW_SEQ);
                    comboDept.SelectedValue = employee.DEPARTMENT_ID;
                    if (employee.SHOW_FLAG == "Y")
                    {
                        radShow.Checked = true;
                        radNotShow.Checked = false;
                    }
                    else
                    {
                        radNotShow.Checked = true;
                        radShow.Checked = false;
                    }
                }
            }
        }

        private bool ValidateControl()
        {
            bool status = false;
            List<string> listMsg = new List<string>();
            if (string.IsNullOrEmpty(txtFirstName.Text)) listMsg.Add("ชื่อจริง");
            if (string.IsNullOrEmpty(txtLastName.Text)) listMsg.Add("นามสกุล");
            if (Convert.ToInt32(comboDept.SelectedValue) == 0) listMsg.Add("แผนก");

            string joined = string.Join("," + Environment.NewLine, listMsg);
            if (listMsg.Count > 0)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ " + joined, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                status = true;
            }


            return status;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateControl())
            {
                if (MessageBox.Show("ต้องการบันทึกข้อมูลใช่หรือไม่ ?", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (formMode == FormMode.Add)
                    {
                        MAS_EMPLOYEE emp = new MAS_EMPLOYEE()
                        {
                            DEPARTMENT_ID = Convert.ToInt32(comboDept.SelectedValue),
                            FIRST_NAME = txtFirstName.Text,
                            LAST_NAME = txtLastName.Text,
                            SHOW_FLAG = radShow.Checked ? "Y" : "N",
                            SHOW_SEQ = Convert.ToInt32(numSeq.Value)
                        };

                        var resp = _service.AddEmployee(emp);
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
                    else if (formMode == FormMode.Edit)
                    {
                        MAS_EMPLOYEE emp = new MAS_EMPLOYEE()
                        {
                            AUTO_ID = employee_id,
                            DEPARTMENT_ID = Convert.ToInt32(comboDept.SelectedValue),
                            FIRST_NAME = txtFirstName.Text,
                            LAST_NAME = txtLastName.Text,
                            SHOW_FLAG = radShow.Checked ? "Y" : "N",
                            SHOW_SEQ = Convert.ToInt32(numSeq.Value)
                        };

                        var resp = _service.UpadateEmployee(emp);
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
