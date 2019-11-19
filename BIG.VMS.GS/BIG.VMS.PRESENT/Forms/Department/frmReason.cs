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
    public partial class frmReason : PageBase
    {
        public int reason_id = 0;
        public int dept_id = 0;
        private readonly ReasonServices _service = new ReasonServices();
        private ContainerReason _container = new ContainerReason();
        private ComboBoxServices _comboService = new ComboBoxServices();
        public frmReason()
        {
            InitializeComponent();
        }

        private void frmReason_Load(object sender, EventArgs e)
        {
            comboDept.DataSource = _comboService.GetComboDepartment(true);
            comboDept.DisplayMember = "Text";
            comboDept.ValueMember = "Value";
            if (formMode == FormMode.Add)
            {
                comboDept.SelectedValue = dept_id;
            }
            if (formMode == FormMode.View)
            {
                btnSave.Visible = false;
                txtName.ReadOnly = true;

                numSeq.Enabled = false;
                radNotShow.Enabled = false;
                radShow.Enabled = false;
                lbType.Text = "ดูข้อมูลวัตถุประสงค์";
                var resp = _service.GetReason(reason_id);
                if (resp.Status)
                {
                    var reason = (MAS_REASON)resp.ResultObj;
                    txtName.Text = reason.REASON;
                    comboDept.SelectedValue = reason.DEPT_ID;

                    numSeq.Value = Convert.ToDecimal(reason.SHOW_SEQ);

                    if (reason.SHOW_FLAG == "Y")
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
                lbType.Text = "แก้ไขข้อมูลวัตถุประสงค์";
                var resp = _service.GetReason(reason_id);
                if (resp.Status)
                {
                    var reason = (MAS_REASON)resp.ResultObj;
                    txtName.Text = reason.REASON;
                    comboDept.SelectedValue = reason.DEPT_ID;

                    numSeq.Value = Convert.ToDecimal(reason.SHOW_SEQ);

                    if (reason.SHOW_FLAG == "Y")
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
            if (string.IsNullOrEmpty(txtName.Text)) listMsg.Add("เหตุผล");

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateControl())
            {
                if (MessageBox.Show("ต้องการบันทึกข้อมูลใช่หรือไม่ ?", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (formMode == FormMode.Add)
                    {
                        MAS_REASON reason = new MAS_REASON()
                        {
                            DEPT_ID = Convert.ToInt32(comboDept.SelectedValue),
                            REASON = txtName.Text,
                            SHOW_FLAG = radShow.Checked ? "Y" : "N",
                            SHOW_SEQ = Convert.ToInt32(numSeq.Value),
                            
                        };

                        var resp = _service.AddReason(reason);
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
                        MAS_REASON reason = new MAS_REASON()
                        {
                            AUTO_ID = reason_id,
                            DEPT_ID = Convert.ToInt32(comboDept.SelectedValue),
                            REASON = txtName.Text,
                            SHOW_FLAG = radShow.Checked ? "Y" : "N",
                            SHOW_SEQ = Convert.ToInt32(numSeq.Value),
                        };

                        var resp = _service.UpadateReason(reason);
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
