using BIG.VMS.DATASERVICE;
using BIG.VMS.MODEL.EntityModel;
using BIG.VMS.MODEL.CustomModel.Container;
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
    public partial class frmContractor : PageBase
    {
        public MAS_CONTRACTOR MAS_CONTRACTOR { get; set; }
        private ConstractorServices service = new ConstractorServices();
        
        public frmContractor()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmContractor_Load(object sender, EventArgs e)
        {
            SetControl();
        }


        private void SetControl()
        {
            if(formMode == MODEL.CustomModel.FormMode.Add)
            {
                lbType.Text = "เพิ่มผู้รับเหมา";
            }
            if (formMode == MODEL.CustomModel.FormMode.Edit)
            {
                lbType.Text = "แก้ไขผู้รับเหมา";
                txtAddress.Text = MAS_CONTRACTOR.ADDRESS;
                txtName.Text = MAS_CONTRACTOR.NAME;
                txtTel.Text = MAS_CONTRACTOR.TEL;
            }
            if (formMode == MODEL.CustomModel.FormMode.View)
            {
                lbType.Text = "ผู้รับเหมา";
                txtAddress.ReadOnly = true;
                txtName.ReadOnly = true;
                txtTel.ReadOnly = true;
                txtAddress.Text = MAS_CONTRACTOR.ADDRESS;
                txtName.Text = MAS_CONTRACTOR.NAME;
                txtTel.Text = MAS_CONTRACTOR.TEL;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateControl())
            {
                if (MessageBox.Show("ต้องการบันทึกข้อมูลใช่หรือไม่ ?", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (formMode == MODEL.CustomModel.FormMode.Add)
                    {
                        MAS_CONTRACTOR obj = new MAS_CONTRACTOR()
                        {
                            NAME = txtName.Text,
                            ADDRESS = txtAddress.Text,
                            TEL = txtTel.Text,
                            CREATED_BY = LOGIN,
                            UPDATED_BY = LOGIN,
                            CREATED_DATE = DateTime.Now,
                            UPDATED_DATE = DateTime.Now
                        };

                        var resp = service.AddConstractor(obj);
                        if (resp.Status)
                        {
                            MessageBox.Show(Message.MSG_SAVE_COMPLETE, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(resp.Message);
                        }
                    }
                    if (formMode == MODEL.CustomModel.FormMode.Edit)
                    {
                        MAS_CONTRACTOR obj = new MAS_CONTRACTOR()
                        {
                            AUTO_ID = MAS_CONTRACTOR.AUTO_ID,
                            NAME = txtName.Text,
                            ADDRESS = txtAddress.Text,
                            TEL = txtTel.Text,
                            CREATED_BY = LOGIN,
                            UPDATED_BY = LOGIN,
                            CREATED_DATE = DateTime.Now,
                            UPDATED_DATE = DateTime.Now
                        };
                         
                        var resp = service.UpdateContractor(obj);
                        if (resp.Status)
                        {
                            MessageBox.Show(Message.MSG_SAVE_COMPLETE, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(resp.Message);
                        }
                    }

                }
               
            }
           
        }

        private bool ValidateControl()
        {
            List<string> listMsg = new List<string>();
            if (string.IsNullOrEmpty(txtName.Text)) listMsg.Add("ชื่อจริง");
            if (string.IsNullOrEmpty(txtAddress.Text)) listMsg.Add("ที่อยู่");
            if (string.IsNullOrEmpty(txtTel.Text)) listMsg.Add("เบอร์โทร");               
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
    }
}
