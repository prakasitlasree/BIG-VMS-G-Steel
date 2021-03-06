﻿using BIG.VMS.DATASERVICE;
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.CustomModel.Container;
using BIG.VMS.MODEL.EntityModel;
using BIG.VMS.PRESENT.Forms.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIG.VMS.PRESENT.Forms.FormVisitor
{
    public partial class frmAppointment : PageBase
    {
        //public FormMode formMode = new FormMode();
        //public VisitorMode visitorMode = new VisitorMode();
        private readonly AppointmentServices _service = new AppointmentServices();
        private ContainerAppointment _container = new ContainerAppointment();
        private ComboBoxServices _comboService = new ComboBoxServices();
        private ContainerBlackList _blContainer = new ContainerBlackList();
        private readonly BlackListServices _blService = new BlackListServices();


        private int contactEmployeeId = 0;
        private int provinceId = 0;
        private int carModelId = 0;
        private int reasonId = 0;

        private string no = "";
        public frmAppointment()
        {
            InitializeComponent();
        }


        private void frmAppointment_Load(object sender, EventArgs e)
        {

        }

        private void InitialLoad()
        {


        }

        private TRN_APPOINTMENT GetObjectFromControl()
        {
            var obj = new TRN_APPOINTMENT
            {
                //NO = txtNo.Text.Trim(),
                REQUEST_ID_CARD = txtIDCard.Text.Trim(),
                REQUEST_FIRST_NAME = txtFirstName.Text.Trim(),
                REQUEST_LAST_NAME = txtLastName.Text.Trim(),
                //REQUEST_LICENSE_PLATE = txtLicense.Text.Trim(),
                STATUS = "รอเข้าพบ",
                CONTACT_EMPLOYEE_ID = contactEmployeeId,
                //REQUEST_CAR_MODEL_ID = 1,
                REASON_ID = reasonId,
                //REQUEST_LICENSE_PLATE_PROVINCE_ID = 1,
                CREATED_DATE = DateTime.Now,
                UPDATED_DATE = DateTime.Now,
                CREATED_BY = LOGIN,
                UPDATED_BY = LOGIN,


            };
            return obj;
        }

        private void Save()
        {
            var obj = new TRN_APPOINTMENT();
            obj = GetObjectFromControl();
            obj.CONTACT_DATE = dtContactDate.Value.Date + dtTime.Value.TimeOfDay;

            var container = new ContainerAppointment { TRN_APPOINTMENT = obj };

            var res = _service.Create(container);

            if (res.Status)
            {

                MessageBox.Show(Message.MSG_SAVE_COMPLETE, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(res.Message + res.ExceptionMessage);
            }

        }

        private void chkKeyIn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtFirstName.Text) &&
                    !string.IsNullOrEmpty(txtLastName.Text) &&
                    !string.IsNullOrEmpty(txtIDCard.Text) &&
                    !string.IsNullOrEmpty(txtMeet.Text) &&
                    !string.IsNullOrEmpty(txtTopic.Text) &&
                    !string.IsNullOrEmpty(dtContactDate.Text) &&
                     !string.IsNullOrEmpty(dtTime.Text) &&
                    contactEmployeeId > 0 && reasonId > 0 &&
                    dtContactDate.Value != null &&
                    dtTime.Value != null &&
                    dtContactDate.Value != DateTime.MinValue &&
                    dtTime.Value != DateTime.MinValue)
                {
                    var data = _blService.GetBlackListByIdCard(txtIDCard.Text);
                    if (data.TRN_BLACKLIST == null)
                    {
                        
                        if (MessageBox.Show("ต้องการบันทึกข้อมูลใช่หรือไม่ ?", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Save();
                        }
                       
                    }
                    else
                    {
                        var blData = data.TRN_BLACKLIST;
                        var msg = "เลขบัตรประชาชน : " + blData.ID_CARD + Environment.NewLine + "ชื่อ-สกุล : " + blData.FIRST_NAME + " " + blData.LAST_NAME;
                        msg += Environment.NewLine + "เหตุผล : " + blData.REASON;
                        msg += Environment.NewLine + "ณ วันที่ : " + blData.CREATED_DATE;
                        MessageBox.Show(msg, "บุคคล Blacklist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }

                }
                else
                {
                    List<string> listMsg = new List<string>();
                    if (string.IsNullOrEmpty(txtFirstName.Text)) listMsg.Add("ชื่อจริง");
                    if (string.IsNullOrEmpty(txtLastName.Text)) listMsg.Add("นามสกุล");
                    if (string.IsNullOrEmpty(txtIDCard.Text)) listMsg.Add("รหัสบัตรประชาชน");
                    if (string.IsNullOrEmpty(txtMeet.Text)) listMsg.Add("ผู้ที่ต้องการเข้าพบ");
                    if (string.IsNullOrEmpty(txtTopic.Text)) listMsg.Add("วัตถุประสงค์");
                    string joined = string.Join("," + Environment.NewLine, listMsg);

                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบ " + joined, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            frmProvince frm = new frmProvince();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                provinceId = frm.SELECTED_PROVINCE_ID;
                //txtProvince.Text = frm.SELECTED_PROVINCE_TEXT;
            }
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            frmCar frm = new frmCar();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                carModelId = frm.SELECTED_CAR_NAME_ID;
                //txtCar.Text = frm.SELECTED_CAR_TEXT;
            }
        }

        private void btnMeet_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                contactEmployeeId = frm.SELECTED_EMPLOYEE_ID;
                txtMeet.Text = frm.SELECTED_EMPLOYEE_TEXT;
                reasonId = frm.SELECTED_REASON_ID;
                txtTopic.Text = frm.SELECTED_REASON_TEXT;
            }
        }

       

        private void btnReadCard_Click(object sender, EventArgs e)
        {
            var frm = new CardSelection();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtFirstName.Text = frm.CARD.TH_FIRST_NAME;
                txtLastName.Text = frm.CARD.TH_LAST_NAME;
                txtIDCard.Text = frm.CARD.NO;
                //picCard.Image = (Image)frm.CARD.PHOTO;

                MessageBox.Show("อ่านข้อมูลจากบัตร เรียบร้อย!!!");
            }
        }

        private void BtnTakePhoto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValidCheckPersonID(string pid)
        {
            try
            {
                char[] numberChars = pid.ToCharArray();
                int total = 0;
                int mul = 13;
                int mod = 0, mod2 = 0;
                int nsub = 0;
                int numberChars12 = 0;

                for (int i = 0; i < numberChars.Length - 1; i++)
                {
                    int num = 0;
                    int.TryParse(numberChars[i].ToString(), out num);

                    total = total + num * mul;
                    mul = mul - 1;
                }

                mod = total % 11;
                nsub = 11 - mod;
                mod2 = nsub % 10;

                int.TryParse(numberChars[12].ToString(), out numberChars12);

                if (mod2 != numberChars12)
                    return false;
                else
                    return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void chkKeyIn_CheckedChanged_1(object sender, EventArgs e)
        {
            //if (chkKeyIn.Checked)
            //{
            //    txtFirstName.Enabled = true;
            //    txtLastName.Enabled = true;
            //    txtIDCard.Enabled = true;

            //}
            //else
            //{
            //    txtFirstName.Enabled = false;
            //    txtLastName.Enabled = false;
            //    txtIDCard.Enabled = false;
            //}
        }

        private void btnUploadCam_Click(object sender, EventArgs e)
        {

        }

        private void txtIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
