using BIG.VMS.MODEL.EntityModel;
using BIG.VMS.DATASERVICE;
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
    public partial class frmPlantVisit : PageBase
    {
        public TRN_CUSTOMER_VISIT TRN_CUSTOMER_VISIT { get; set; }
        private PlanVisitServices service = new PlanVisitServices();

        public frmPlantVisit()
        {
            InitializeComponent();
        }

        private void frmPlantVisit_Load(object sender, EventArgs e)
        {
            SetControl();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateControl())
            {
                if (MessageBox.Show("ต้องการบันทึกข้อมูลใช่หรือไม่ ?", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (formMode == MODEL.CustomModel.FormMode.Add)
                    {
                        TRN_CUSTOMER_VISIT visit = new TRN_CUSTOMER_VISIT()
                        {
                            REQUESTOR_FULLNAME = txtReqname.Text,
                            REQUESTOR_POSITION = txtReqPosition.Text,
                            REQUESTOR_DEPARTMENT = txtDepartment.Text,
                            REQUESTOR_GROUP_AREA = txtGroup.Text,
                            CUSTOMER_NAME = txtvisitgroup.Text,
                            NUMBER_OF_CUSTOMER = int.Parse(txtnoofvisit.Text),
                            OBJECTIVE_OF_VISIT = txtobjective.Text,
                            DATE_TIME_OF_VISIT = visitordate.Value,
                            CONTACT_PERSON = txtcontractperson.Text,

                            CREATED_BY = LOGIN,
                            UPDATED_BY = LOGIN,
                            CREATED_DATE = DateTime.Now,
                            UPDATED_DATE = DateTime.Now
                        };

                        var resp = service.Add(visit);
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
                        //    MAS_CONTRACTOR obj = new MAS_CONTRACTOR()
                        //    {
                        //        AUTO_ID = MAS_CONTRACTOR.AUTO_ID,
                        //        NAME = txtName.Text,
                        //        ADDRESS = txtAddress.Text,
                        //        TEL = txtTel.Text,
                        //        CREATED_BY = LOGIN,
                        //        UPDATED_BY = LOGIN,
                        //        CREATED_DATE = DateTime.Now,
                        //        UPDATED_DATE = DateTime.Now
                        //    };

                        //    var resp = service.UpdateContractor(obj);
                        //    if (resp.Status)
                        //    {
                        //        MessageBox.Show(Message.MSG_SAVE_COMPLETE, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //        this.DialogResult = DialogResult.OK;
                        //        this.Close();
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show(resp.Message);
                        //    }
                    }

                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        #region method 

        private void SetControl()
        {
            if (formMode == MODEL.CustomModel.FormMode.Add)
            {
                lbType.Text = "Add customer visit";
            }
            if (formMode == MODEL.CustomModel.FormMode.Edit)
            {
                lbType.Text = "Edit customer visit";
                
                //requestor
                txtDepartment.ReadOnly = true;
                txtGroup.ReadOnly = true;
                txtReqname.ReadOnly = true;
                txtReqPosition.ReadOnly = true;

                //request for 
                txtcontractperson.ReadOnly = false;
                txtobjective.ReadOnly = false;
                txtnoofvisit.ReadOnly = false;
                txtvisitgroup.ReadOnly = false;
                visitordate.Enabled = true;
                visitortime.ReadOnly = false;
                clbfac_req.Enabled = true;
                btnAddvisitor.Enabled = true;
            }
            if (formMode == MODEL.CustomModel.FormMode.View)
            {
                lbType.Text = "Customer visit";
                txtDepartment.ReadOnly = true;
                txtGroup.ReadOnly = true;
                txtReqname.ReadOnly = true;
                txtReqPosition.ReadOnly = true;
                btnAddvisitor.Enabled = false;
                txtcontractperson.ReadOnly = true;
                txtobjective.ReadOnly = true;
                txtnoofvisit.ReadOnly = true;
                txtvisitgroup.ReadOnly = true;
                visitordate.Enabled = false;
                visitortime.ReadOnly = true;
                clbfac_req.Enabled = false;
            }
        }

        private bool ValidateControl()
        {
            List<string> listMsg = new List<string>();
            if (string.IsNullOrEmpty(txtReqname.Text)) listMsg.Add("Requester name");
            if (string.IsNullOrEmpty(txtReqPosition.Text)) listMsg.Add("Requester position");
            if (string.IsNullOrEmpty(txtvisitgroup.Text)) listMsg.Add("Customer Group");
            if (string.IsNullOrEmpty(txtnoofvisit.Text)) listMsg.Add("No. of visitor");
            if (string.IsNullOrEmpty(txtobjective.Text)) listMsg.Add("Objective");
             
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

        #endregion

        private void btnAddvisitor_Click(object sender, EventArgs e)
        {
            

        }

      
    }
}
