using BIG.VMS.MODEL.CustomModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIG.VMS.PRESENT.Forms.FormVisitorNew;
using PCSC;
using BIG.VMS.MODEL.CustomModel.Container;
using BIG.VMS.DATASERVICE;
using BIG.VMS.MODEL.EntityModel;
using BIG.VMS.PRESENT.Forms.Master;

namespace BIG.VMS.PRESENT.Forms.FormVisitor
{
    public partial class frmVisitorNew : PageBase
    {

        public VisitorMode visitorType { get; set; }
        public TRN_CUSTOMER_VISIT TrnCustomerVisit = new TRN_CUSTOMER_VISIT();
        public TRN_PROJECT_MASTER TrnProjectMaster = new TRN_PROJECT_MASTER();
        public PIDCard CARD { get; set; }
        private readonly BlackListServices _blService = new BlackListServices();
        private readonly VisitorServices _vistorServices = new VisitorServices();
        private Timer _timer = null;
        private int _carTypeId = 0;
        private int _provinceId = 0;
        private int _contactEmployeeId = 0;
        private int _reasonId = 0;
        private string _cardType = string.Empty;


        private bool flgCardImgChange = false;
        private bool flgPhotoImgChange = false;

        public frmVisitorNew()
        {
            InitializeComponent();
        }

        private void FrmVisitorNew_Load(object sender, EventArgs e)
        {
            InitialControlProperties();
            InitialControlData();

        }

        private void BthCardDelete_Click(object sender, EventArgs e)
        {
            SetDefaultImage(picCard);
            flgPhotoImgChange = false;
        }

        private void BtnDeleteCam_Click(object sender, EventArgs e)
        {
            SetDefaultImage(picPhoto);
            flgCardImgChange = false;
        }

        private void SetDefaultImage(PictureBox picBox)
        {
            picBox.Image = BIG.VMS.PRESENT.Properties.Resources.emploee;
        }

        private void BtnReadCard_Click(object sender, EventArgs e)
        {
            frmSelectCard frm = new frmSelectCard();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _cardType = frm.TYPE;
                if (frm.TYPE == "ID_CARD")
                {
                    #region === ID_CARD ===

                    if (frm.READ_CARD_STATUS)
                    {
                        var card = frm.CARD;
                        txtFirstName.Text = card.EN_FIRST_NAME;
                        txtLastName.Text = card.EN_LAST_NAME;
                        txtIDCard.Text = card.NO;
                        picCard.Image = card.CARD_IMAGE;
                        flgCardImgChange = true;
                        var data = _blService.GetBlackListByIdCard(txtIDCard.Text);
                        if (data.TRN_BLACKLIST != null)
                        {
                            var blData = data.TRN_BLACKLIST;
                            var msg = "เลขบัตรประชาชน : " + blData.ID_CARD + Environment.NewLine + "ชื่อ-สกุล : " + blData.FIRST_NAME + " " + blData.LAST_NAME;
                            msg += Environment.NewLine + "เหตุผล : " + blData.REASON;
                            msg += Environment.NewLine + "ณ วันที่ : " + blData.UPDATED_DATE;
                            if (MessageBox.Show(msg, "บุคคล Blacklist", MessageBoxButtons.OK, MessageBoxIcon.Error) ==
                                DialogResult.OK)
                            {
                                this.Close();
                            };
                        }

                    }

                    #endregion

                }
                else if (frm.TYPE == "DRIVER_CARD")
                {

                    #region === DRIVER_CARD ===

                    if (frm.READ_CARD_STATUS)
                    {
                        txtFirstName.Text = frm.DID.FIRST_NAME_EN;
                        txtLastName.Text = frm.DID.LAST_NAME_EN;
                        txtIDCard.Text = frm.DID.NO;
                        var data = _blService.GetBlackListByIdCard(txtIDCard.Text);
                        if (data.TRN_BLACKLIST != null)
                        {
                            var blData = data.TRN_BLACKLIST;
                            var msg = "เลขบัตรประชาชน : " + blData.ID_CARD + Environment.NewLine + "ชื่อ-สกุล : " + blData.FIRST_NAME + " " + blData.LAST_NAME;
                            msg += Environment.NewLine + "เหตุผล : " + blData.REASON;
                            msg += Environment.NewLine + "ณ วันที่ : " + blData.UPDATED_DATE;
                            if (MessageBox.Show(msg, "บุคคล Blacklist", MessageBoxButtons.OK, MessageBoxIcon.Error) ==
                                DialogResult.OK)
                            {
                                this.Close();
                            };
                        }
                    }
                    else
                    {
                        MessageBox.Show("พบข้อผิดพลาด!!!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    #endregion

                }
                else if (frm.TYPE == "OTHER_CARD")
                {
                    #region === Other ===

                    picCard.Image = frm.OTHER_CARD_IMAGE;
                    txtFirstName.Text = txtFirstName.Text.Trim() != ""? txtFirstName.Text.Trim() :"ไม่ระบุุ";
                    txtLastName.Text = txtLastName.Text.Trim() != "" ? txtLastName.Text.Trim() : "ไม่ระบุุ";
                    txtIDCard.Text = txtIDCard.Text.Trim() != "" ? txtIDCard.Text.Trim() : "ไม่ระบุุ";
                    flgCardImgChange = true;

                    #endregion

                }
            }
        }

        private void ChkKeyIn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKeyIn.Checked == true)
            {
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtIDCard.Enabled = true;
            }
            else
            {
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                txtIDCard.Enabled = false;
            }
        }

        private void BtnTakePhotos_Click(object sender, EventArgs e)
        {
            Image image = BIG.VMS.PRESENT.Properties.Resources.emploee; ;
            try
            {
                var frm = new CameraSelection();
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.CAMERA != null)
                    {
                        picPhoto.Image = frm.CAMERA;
                        flgPhotoImgChange = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnTakeCard_Click(object sender, EventArgs e)
        {
            Image image = BIG.VMS.PRESENT.Properties.Resources.emploee; ;
            try
            {
                var frm = new CameraSelection();
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.CAMERA != null)
                    {
                        picCard.Image = frm.CAMERA;
                        flgCardImgChange = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                if (formMode == FormMode.Add)
                {
                    Save();
                }
                else if (formMode == FormMode.Edit)
                {

                }

            }
        }

        private void BtnVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                frmCar frm = new frmCar();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _carTypeId = frm.SELECTED_CAR_NAME_ID;
                    txtCar.Text = frm.SELECTED_CAR_TYPE_TEXT;
                    if (frm.SELECTED_CAR_TYPE_TEXT.Trim() == "เดินเท้า" || frm.SELECTED_CAR_TYPE_TEXT.Trim() == "ไม่ระบุ")
                    {
                        txtLicense.Text = "";
                        txtLicense.Enabled = false;
                        Lbl_LicensePlate.Visible = false;
                        txtLicense.Visible = false;
                        Lbl_Vahicle.Visible = false;
                        txtProvince.Visible = false;
                        btnProvince.Visible = false;
                        btnLicense.Visible = false;
                        tableLayoutPanel2.Visible = false;
                        tableLayoutPanel8.Visible = false;
                        _provinceId = 0;
                    }
                    else
                    {
                        Lbl_LicensePlate.Visible = true;
                        txtLicense.Visible = true;
                        txtLicense.Enabled = true;
                        Lbl_Vahicle.Visible = true;
                        txtProvince.Visible = true;
                        btnProvince.Visible = true;
                        btnLicense.Visible = true;
                        tableLayoutPanel2.Visible = true;
                        tableLayoutPanel8.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BtnMeet_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmployee frm = new frmEmployee();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _contactEmployeeId = frm.SELECTED_EMPLOYEE_ID;
                    txtMeet.Text = frm.SELECTED_EMPLOYEE_TEXT;
                    _reasonId = frm.SELECTED_REASON_ID;
                    txtTopic.Text = frm.SELECTED_REASON_TEXT;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BtnProvince_Click(object sender, EventArgs e)
        {
            frmProvince frm = new frmProvince();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _provinceId = frm.SELECTED_PROVINCE_ID;
                txtProvince.Text = frm.SELECTED_PROVINCE_TEXT;
            }
        }

        private void BtnLicense_Click(object sender, EventArgs e)
        {
            frmKeyboard frm = new frmKeyboard();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtLicense.Text = frm.text;
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {

            label6.Text = DateTime.Now.ToString();

        }

        public Bitmap ByteToImage(byte[] blob)
        {
            try
            {
                MemoryStream mStream = new MemoryStream();
                byte[] pData = blob;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                Bitmap bm = new Bitmap(mStream, false);
                mStream.Dispose();
                return bm;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public byte[] ImageToByte(PictureBox source)
        {
            try
            {
                Image img = source.Image;
                using (var ms = new MemoryStream())
                {
                    Bitmap bmp = new Bitmap(img, 240, 120);
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    return ms.ToArray();

                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private Image TakePhoto()
        {
            Image image = BIG.VMS.PRESENT.Properties.Resources.emploee; ;
            try
            {
                var frm = new CameraSelection();
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.CAMERA != null)
                    {
                        image = frm.CAMERA;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return image;
        }

        private void StartTimer()
        {

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(tmr_Tick);
            _timer.Enabled = true;

        }

        private void InitialControlProperties()
        {
            lbType.Text = DisplayText(visitorType);
            if (formMode == FormMode.Add)
            {
                btnBlacklist.Visible = false;
                var res = _vistorServices.GetLastUserNo();
                #region === Set Visitor No ===
                if (res.Status)
                {
                    int no = Convert.ToInt32(res.TRN_VISITOR.NO);
                    no = no + 1;
                    txtNo.Text = no.ToString();
                }
                else
                {
                    MessageBox.Show(res.ExceptionMessage);
                }
                #endregion
                switch (visitorType)
                {
                    case VisitorMode.In:
                    case VisitorMode.Appointment:
                        {

                        }
                        break;
                    case VisitorMode.ConstructorIn:
                    case VisitorMode.CustomerIn:
                        {
                            btnMeet.Visible = false;
                            if (visitorType == VisitorMode.ConstructorIn)
                            {
                                var companyName = TrnProjectMaster.MAS_CONTRACTOR != null ? TrnProjectMaster.MAS_CONTRACTOR.NAME : "ไม่ระบุ";
                                txtFirstName.Text = $@"กลุ่มพนักงานผู้รับเหมา {companyName }";
                                txtLastName.Text = "-";
                                txtIDCard.Text = $@"กลุ่มพนักงานผู้รับเหมา {companyName}";
                                txtMeet.Text = $@"{TrnProjectMaster.RESPONSIBLE_MANAGER}";
                                txtTopic.Text = $@"{TrnProjectMaster.PROJECT_NAME}";
                            }
                            else
                            {
                                txtFirstName.Text = $@"กลุ่มลูกค้า {TrnCustomerVisit.CUSTOMER_NAME}";
                                txtLastName.Text = "-";
                                txtIDCard.Text = $@"กลุ่มลูกค้า {TrnCustomerVisit.CUSTOMER_NAME}";
                                txtMeet.Text = $@"{TrnCustomerVisit.CONTACT_PERSON}";
                                txtTopic.Text = $@"{TrnCustomerVisit.OBJECTIVE_OF_VISIT}";
                            }
                        }
                        break;
                }
            }
        }

        private void InitialControlData()
        {

        }

        private string DisplayText(VisitorMode mode)
        {
            string type = "";
            switch (mode)
            {
                case VisitorMode.In:
                    type = "เข้า";
                    break;
                case VisitorMode.CustomerIn:
                    type = "ลูกค้า(เข้า)";
                    break;
                case VisitorMode.ConstructorIn:
                    type = "โครงการ(เข้า)";
                    break;
                case VisitorMode.Out:
                    type = "ออก";
                    break;
                case VisitorMode.ConstructorOut:
                    type = "ลูกค้า(ออก)";
                    break;
                case VisitorMode.CustomerOut:
                    type = "โครงการ(ออก)";
                    break;

            }
            return type;
        }

        private bool Validate()
        {
            bool status = false;
            switch (visitorType)
            {
                case VisitorMode.In:
                case VisitorMode.Appointment:
                    {
                        List<string> listMsg = new List<string>();
                        if (string.IsNullOrEmpty(txtFirstName.Text)) listMsg.Add("ชื่อจริง");
                        if (string.IsNullOrEmpty(txtLastName.Text)) listMsg.Add("นามสกุล");
                        if (string.IsNullOrEmpty(txtIDCard.Text)) listMsg.Add("รหัสบัตรประชาชน");
                        if (string.IsNullOrEmpty(txtMeet.Text) || _contactEmployeeId == 0) listMsg.Add("ผู้ที่ต้องการเข้าพบ");
                        if (string.IsNullOrEmpty(txtTopic.Text) || _reasonId == 0) listMsg.Add("วัตถุประสงค์");
                        if (string.IsNullOrEmpty(txtCar.Text) || _carTypeId == 0) listMsg.Add("ยานพาหนะ");
                        string joined = string.Join("," + Environment.NewLine, listMsg);
                        if (listMsg.Count > 0)
                        {
                            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ " + joined, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {
                            status = true;
                        }

                    }
                    break;
                case VisitorMode.ConstructorIn:
                case VisitorMode.CustomerIn:
                    {
                        List<string> listMsg = new List<string>();
                        if (string.IsNullOrEmpty(txtFirstName.Text)) listMsg.Add("ชื่อจริง");
                        if (string.IsNullOrEmpty(txtLastName.Text)) listMsg.Add("นามสกุล");
                        if (string.IsNullOrEmpty(txtIDCard.Text)) listMsg.Add("รหัสบัตรประชาชน");
                        if (string.IsNullOrEmpty(txtCar.Text) || _carTypeId == 0) listMsg.Add("ยานพาหนะ");
                        string joined = string.Join("," + Environment.NewLine, listMsg);
                        if (listMsg.Count > 0)
                        {
                            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ " + joined, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {
                            status = true;
                        }
                    }
                    break;

            }

            return status;
        }

        public byte[] ImageToByte(Image source)
        {

            try
            {

                Image img = source;
                using (var ms = new MemoryStream())
                {
                    Bitmap bmp = new Bitmap(img);
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    return ms.ToArray();

                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void Save()
        {

            TRN_VISITOR source = new TRN_VISITOR();
            switch (visitorType)
            {
                case VisitorMode.In:
                case VisitorMode.Appointment:
                    {
                        TRN_VISITOR obj = new TRN_VISITOR()
                        {
                            #region === Obj ==
                            YEAR = DateTime.Now.Year,
                            MONTH = DateTime.Now.Month,
                            NO = Convert.ToInt32(txtNo.Text),
                            ID_CARD = txtIDCard.Text,
                            TYPE = "IN",
                            GROUP = visitorType == VisitorMode.In ? "NORMAL" : "APPOINTMENT",
                            BY_PASS = _cardType == "OTHER_TYPE" ? "N" : "Y",
                            CAR_TYPE_ID = _carTypeId,
                            CONTACT_EMPLOYEE_ID = _contactEmployeeId,
                            CONTACT_EMPLOYEE_NAME = txtMeet.Text,
                            FIRST_NAME = txtFirstName.Text,
                            LAST_NAME = txtLastName.Text,
                            LICENSE_PLATE = (txtCar.Text.Trim() == "เดินเท้า" || txtCar.Text.Trim() == "ไม่ระบุ") ? "ไม่ระบุ" : txtLicense.Text,
                            LICENSE_PLATE_PROVINCE_ID = _provinceId != 0 ? _provinceId : (int?)null,
                            REASON_ID = _reasonId,
                            REASON_TEXT = txtTopic.Text,
                            STATUS = 1,
                            CREATED_BY = LOGIN,
                            CREATED_DATE = DateTime.Now,
                            UPDATED_BY = LOGIN,
                            UPDATED_DATE = DateTime.Now,
                            TRN_ATTACHEDMENT = new List<TRN_ATTACHEDMENT>()
                            #endregion

                        };

                        TRN_ATTACHEDMENT attached = new TRN_ATTACHEDMENT();
                        string dir = DIRECTORY_IN + "\\" + obj.NO + "\\" + obj.GROUP;
                        Directory.CreateDirectory(dir);
                        attached.PHOTO_URL = dir;
                        if (flgCardImgChange)
                        {
                            attached.ID_CARD_PHOTO = ImageToByte(picCard);
                            picPhoto.Image.Save(dir + "PHOTO.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        if (flgPhotoImgChange)
                        {
                            attached.CONTACT_PHOTO = ImageToByte(picPhoto);
                            picCard.Image.Save(dir + "ID_CARD.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }

                        obj.TRN_ATTACHEDMENT.Add(attached);
                        source = obj;
                    }
                    break;
                case VisitorMode.ConstructorIn:
                case VisitorMode.CustomerIn:
                    {

                        TRN_VISITOR obj = new TRN_VISITOR()
                        {

                            #region === Obj ==
                            YEAR = DateTime.Now.Year,
                            MONTH = DateTime.Now.Month,
                            NO = Convert.ToInt32(txtNo.Text),
                            ID_CARD = txtIDCard.Text,
                            TYPE = "IN",
                            GROUP = visitorType == VisitorMode.ConstructorIn ? "CONSTRUCTOR" : "CUSTOMER",
                            BY_PASS = _cardType == "OTHER_TYPE" ? "N" : "Y",
                            CAR_TYPE_ID = _carTypeId,
                            CONTACT_EMPLOYEE_NAME = txtMeet.Text,
                            FIRST_NAME = txtFirstName.Text,
                            LICENSE_PLATE = (txtCar.Text.Trim() == "เดินเท้า" || txtCar.Text.Trim() == "ไม่ระบุ") ? "ไม่ระบุ" : txtLicense.Text,
                            LICENSE_PLATE_PROVINCE_ID = _provinceId != 0 ? _provinceId : (int?)null,
                            REASON_TEXT = txtTopic.Text,
                            STATUS = 1,
                            CREATED_BY = LOGIN,
                            CREATED_DATE = DateTime.Now,
                            UPDATED_BY = LOGIN,
                            UPDATED_DATE = DateTime.Now,
                            TRN_ATTACHEDMENT = new List<TRN_ATTACHEDMENT>()
                            #endregion
                        };
                        TRN_ATTACHEDMENT attached = new TRN_ATTACHEDMENT();
                        string dir = DIRECTORY_IN + "\\" + obj.NO + "\\" + obj.GROUP;
                        Directory.CreateDirectory(dir);
                        attached.PHOTO_URL = dir;
                        if (flgCardImgChange)
                        {
                            attached.ID_CARD_PHOTO = ImageToByte(picCard);
                            picPhoto.Image.Save(dir + "PHOTO.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        if (flgPhotoImgChange)
                        {
                            attached.CONTACT_PHOTO = ImageToByte(picPhoto);
                            picCard.Image.Save(dir + "ID_CARD.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }

                        obj.TRN_ATTACHEDMENT.Add(attached);
                        source = obj;
                    }
                    break;
            }

            var resp = _vistorServices.AddVisitor(source);
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

        private void BtnBlacklist_Click(object sender, EventArgs e)
        {

        }

        private void BtnTakePhoto_Click(object sender, EventArgs e)
        {
            Image image = BIG.VMS.PRESENT.Properties.Resources.emploee; ;
            try
            {
                var frm = new CameraSelection();
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.CAMERA != null)
                    {
                        picPhoto.Image = frm.CAMERA;
                        flgPhotoImgChange = true;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }

    public class Configuration
    {

    }
}
