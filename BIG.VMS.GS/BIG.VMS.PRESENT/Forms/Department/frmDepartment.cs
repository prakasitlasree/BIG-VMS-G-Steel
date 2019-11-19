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

namespace BIG.VMS.PRESENT.Forms.Department
{
    public partial class frmDepartment : PageBase
    {
        public int dept_id = 0;
        private readonly DepartmentServices _service = new DepartmentServices();
        private ContainerDepartment _container = new ContainerDepartment();
        private ComboBoxServices _comboService = new ComboBoxServices();
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            
            if (formMode == FormMode.View)
            {
                btnSave.Visible = false;
                txtName.ReadOnly = true;
             
                numSeq.Enabled = false;
                radNotShow.Enabled = false;
                radShow.Enabled = false;
                lbType.Text = "ดูข้อมูลแผนก";
                var resp = _service.GetDepartment(dept_id);
                if (resp.Status)
                {
                    var dept = (MAS_DEPARTMENT)resp.ResultObj;
                    txtName.Text = dept.NAME;
     
                    numSeq.Value = Convert.ToDecimal(dept.SHOW_SEQ);
                  
                    if (dept.SHOW_FLAG == "Y")
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
                lbType.Text = "แก้ไขข้อมูลแผนก";
                var resp = _service.GetDepartment(dept_id);
                if (resp.Status)
                {
                    var dept = (MAS_DEPARTMENT)resp.ResultObj;
                    txtName.Text = dept.NAME;
                    
                    numSeq.Value = Convert.ToDecimal(dept.SHOW_SEQ);
                   
                    if (dept.SHOW_FLAG == "Y")
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
            if (string.IsNullOrEmpty(txtName.Text)) listMsg.Add("ชื่อแผนก");
         
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateControl())
            {
                if (MessageBox.Show("ต้องการบันทึกข้อมูลใช่หรือไม่ ?", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (formMode == FormMode.Add)
                    {
                        MAS_DEPARTMENT dept = new MAS_DEPARTMENT()
                        {
                           
                          
                            SHOW_FLAG = radShow.Checked ? "Y" : "N",
                            SHOW_SEQ = Convert.ToInt32(numSeq.Value),
                            NAME = txtName.Text,
                        };

                        var resp = _service.AddDepartment(dept);
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
                        MAS_DEPARTMENT dept = new MAS_DEPARTMENT()
                        {
                            AUTO_ID = dept_id,
                            SHOW_FLAG = radShow.Checked ? "Y" : "N",
                            SHOW_SEQ = Convert.ToInt32(numSeq.Value),
                            NAME = txtName.Text,
                        };

                        var resp = _service.UpadateDepartment(dept);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
