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
        public TRN_CUSTOMER_VISIT _TRN_CUSTOMER_VISIT { get; set; }
        private PlanVisitServices service = new PlanVisitServices();

        public frmPlantVisit()
        {
            InitializeComponent();
        }

        private void frmPlantVisit_Load(object sender, EventArgs e)
        {
            SetControl();
            //gridVisitor.AutoGenerateColumns = false;
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
                            NUMBER_OF_CUSTOMER = int.Parse(numNo.Value.ToString()),
                            OBJECTIVE_OF_VISIT = txtobjective.Text,
                            DATE_TIME_OF_VISIT = visitordate.Value,
                            CONTACT_PERSON = txtcontractperson.Text,

                            CREATED_BY = LOGIN,
                            UPDATED_BY = LOGIN,
                            CREATED_DATE = DateTime.Now,
                            UPDATED_DATE = DateTime.Now
                        };



                        List<TRN_CUSTOMER_VISIT_LIST> visitor = new List<TRN_CUSTOMER_VISIT_LIST>();
                        visitor = (List<TRN_CUSTOMER_VISIT_LIST>)gridVisitor.DataSource;

                        visit.TRN_CUSTOMER_VISIT_LIST = visitor;

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



                        
                        _TRN_CUSTOMER_VISIT.REQUESTOR_FULLNAME = txtReqname.Text;
                        _TRN_CUSTOMER_VISIT.REQUESTOR_POSITION = txtReqPosition.Text;
                        _TRN_CUSTOMER_VISIT.REQUESTOR_DEPARTMENT = txtDepartment.Text;
                        _TRN_CUSTOMER_VISIT.REQUESTOR_GROUP_AREA = txtGroup.Text;

                        _TRN_CUSTOMER_VISIT.CUSTOMER_NAME = txtvisitgroup.Text;
                        _TRN_CUSTOMER_VISIT.NUMBER_OF_CUSTOMER = int.Parse(numNo.Text);
                        _TRN_CUSTOMER_VISIT.OBJECTIVE_OF_VISIT = txtobjective.Text;
                        _TRN_CUSTOMER_VISIT.DATE_TIME_OF_VISIT = visitordate.Value;
                        _TRN_CUSTOMER_VISIT.CONTACT_PERSON = txtcontractperson.Text;

                        _TRN_CUSTOMER_VISIT.CREATED_BY = LOGIN;
                        _TRN_CUSTOMER_VISIT.UPDATED_DATE = DateTime.Now;



                        var resp = service.Update(_TRN_CUSTOMER_VISIT);
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
                gridVisitor.DataSource = new List<TRN_CUSTOMER_VISIT_LIST>();
            }
            if (formMode == MODEL.CustomModel.FormMode.Edit)
            {
                gridVisitor.DataSource = (List<TRN_CUSTOMER_VISIT_LIST>)_TRN_CUSTOMER_VISIT.TRN_CUSTOMER_VISIT_LIST.ToList();
                txtReqname.Text = _TRN_CUSTOMER_VISIT.REQUESTOR_FULLNAME;
                txtReqPosition.Text = _TRN_CUSTOMER_VISIT.REQUESTOR_POSITION;
                txtGroup.Text = _TRN_CUSTOMER_VISIT.REQUESTOR_GROUP_AREA;
                txtDepartment.Text = _TRN_CUSTOMER_VISIT.REQUESTOR_DEPARTMENT;
                txtvisitgroup.Text = _TRN_CUSTOMER_VISIT.CUSTOMER_NAME;
                numNo.Value = Convert.ToInt32(_TRN_CUSTOMER_VISIT.NUMBER_OF_CUSTOMER);
                txtobjective.Text = _TRN_CUSTOMER_VISIT.OBJECTIVE_OF_VISIT;
                visitordate.Value = Convert.ToDateTime(_TRN_CUSTOMER_VISIT.DATE_TIME_OF_VISIT);
                txtcontractperson.Text = _TRN_CUSTOMER_VISIT.CONTACT_PERSON;


                lbType.Text = "Edit customer visit";

                //requestor
                txtDepartment.ReadOnly = true;
                txtGroup.ReadOnly = true;
                txtReqname.ReadOnly = true;
                txtReqPosition.ReadOnly = true;

                //request for 
                txtcontractperson.ReadOnly = false;
                txtobjective.ReadOnly = false;
                numNo.Enabled = false;
                txtvisitgroup.ReadOnly = false;
                visitordate.Enabled = true;
                dtVisitTime.Enabled = false;
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
                numNo.Enabled = true;
                txtvisitgroup.ReadOnly = true;
                visitordate.Enabled = false;
                dtVisitTime.Enabled = true;
                clbfac_req.Enabled = false;
            }
        }

        private bool ValidateControl()
        {
            List<string> listMsg = new List<string>();
            if (string.IsNullOrEmpty(txtReqname.Text)) listMsg.Add("Requester name");
            if (string.IsNullOrEmpty(txtReqPosition.Text)) listMsg.Add("Requester position");
            if (string.IsNullOrEmpty(txtvisitgroup.Text)) listMsg.Add("Customer Group");
            if (numNo.Value != 0) listMsg.Add("No. of visitor");
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
            frmPlantVisitor frm = new frmPlantVisitor();
            if (gridVisitor.Rows.Count > 0)
            {
                var MaxID = gridVisitor.Rows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells["SEQ"].Value));
                frm.seq = MaxID + 1;
            }
            else
            {
                frm.seq = 1;
            }

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var listVisitor = (List<TRN_CUSTOMER_VISIT_LIST>)gridVisitor.DataSource;
                if (formMode == MODEL.CustomModel.FormMode.Add)
                {
                    listVisitor.Add(frm.TRN_CUSTOMER_VISIT_LIST);
                }
                else
                {
                    listVisitor.Add(frm.TRN_CUSTOMER_VISIT_LIST);
                    frm.TRN_CUSTOMER_VISIT_LIST.CUSTOMER_VISIT_ID = _TRN_CUSTOMER_VISIT.AUTO_ID;
                    var resp = service.AddVisitor(frm.TRN_CUSTOMER_VISIT_LIST);
                    if (!resp.Status)
                    {
                        MessageBox.Show(resp.Message + resp.ExceptionMessage);
                    }
                }

                gridVisitor.DataSource = listVisitor.ToList();
            }

        }

        private void Visitortime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
