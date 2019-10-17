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
using BIG.VMS.MODEL.CustomModel.CustomContainer;
using BIG.VMS.MODEL.CustomModel.General;
using BIG.VMS.MODEL.EntityModel;
using BIG.VMS.MODEL.GsteelModel.CustomModel;
using BIG.VMS.PRESENT.Forms.FormReport;
using BIG.VMS.PRESENT.Forms.Master;
using CrystalDecisions.CrystalReports.Engine;

namespace BIG.VMS.PRESENT.Forms.FormVisitor
{
    public partial class frmVisitorNew : PageBase
    {

        public VisitorGroup VISITOR_GROUP { get; set; }
        public VisitorType VISITOR_TYPE { get; set; }
        public TRN_CUSTOMER_VISIT TrnCustomerVisit = new TRN_CUSTOMER_VISIT();
        public TRN_PROJECT_MASTER TrnProjectMaster = new TRN_PROJECT_MASTER();
        public TRN_VISITOR TrnVisitor = new TRN_VISITOR();
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
                        btnTakeCard.Visible = true;
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
                    txtFirstName.Text = txtFirstName.Text.Trim() != "" ? txtFirstName.Text.Trim() : "ไม่ระบุุ";
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
            if (ValidateControl())
            {
                if (formMode == FormMode.Add)
                {
                    SaveTrnVisitor();
                }
                else if (formMode == FormMode.Edit)
                {
                    UpdateTrnVisitor();
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
                    txtEmployee.Text = frm.SELECTED_EMPLOYEE_TEXT;
                    _reasonId = frm.SELECTED_REASON_ID;
                    txtReason.Text = frm.SELECTED_REASON_TEXT;
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

            lbTime.Text = DateTime.Now.ToString();

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
            lbType.Text = $@"{DisplayTextGroup(VISITOR_GROUP)}({DisplayTextType(VISITOR_TYPE)})";
            btnBlacklist.Visible = false;
            StartTimer();
            if (formMode == FormMode.Add)
            {
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

                switch (this.VISITOR_GROUP)
                {
                    case VisitorGroup.APPOINTMENT:
                    case VisitorGroup.NORMAL:
                        {

                        }
                        break;
                    case VisitorGroup.CONSTRUCTOR:
                    case VisitorGroup.CUSTOMER:
                        {

                            btnMeet.Visible = false;
                            if (VISITOR_GROUP == VisitorGroup.CONSTRUCTOR)
                            {
                                int dayLeft = Convert.ToInt32((Convert.ToDateTime(TrnProjectMaster.PROJECT_END_DATE) - DateTime.Now)
                                    .TotalDays);

                                if (dayLeft < 0)
                                {
                                    if (MessageBox.Show($@"จำนวนวันทำงานหมดแล้ว วันสิ้นสุดการทำงาน {TrnProjectMaster.PROJECT_END_DATE.ToString()}", "สิ้นสุดวันทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Error) ==
                                        DialogResult.OK)
                                    {
                                        this.Close();
                                        return;
                                    };
                                }

                                lbDayLeft.Text = $@"วันทำงานที่เหลือ {dayLeft} วัน";
                                lbDayLeft.Visible = true;
                                var companyName = TrnProjectMaster.MAS_CONTRACTOR != null
                                    ? TrnProjectMaster.MAS_CONTRACTOR.NAME
                                    : "ไม่ระบุ";
                                txtFirstName.Text = $@"กลุ่มพนักงานผู้รับเหมา {companyName}";

                                txtIDCard.Text = $@"กลุ่มพนักงานผู้รับเหมา {companyName}";
                                txtEmployee.Text = $@"{TrnProjectMaster.RESPONSIBLE_MANAGER}";
                                txtReason.Text = $@"{TrnProjectMaster.PROJECT_NAME}";
                            }
                            else
                            {
                                txtFirstName.Text = $@"กลุ่มลูกค้า {TrnCustomerVisit.CUSTOMER_NAME}";

                                txtIDCard.Text = $@"กลุ่มลูกค้า {TrnCustomerVisit.CUSTOMER_NAME}";
                                txtEmployee.Text = $@"{TrnCustomerVisit.CONTACT_PERSON}";
                                txtReason.Text = $@"{TrnCustomerVisit.OBJECTIVE_OF_VISIT}";
                            }
                        }
                        break;
                }
            }
            else if (formMode == FormMode.Edit)
            {
                lbType.Text = $@"{DisplayTextGroup(VISITOR_GROUP)}({DisplayTextType(VISITOR_TYPE)})";
                btnTakeCard.Visible = true;
                switch (this.VISITOR_GROUP)
                {
                    case VisitorGroup.APPOINTMENT:
                    case VisitorGroup.NORMAL:
                        {

                        }
                        break;
                    case VisitorGroup.CONSTRUCTOR:
                    case VisitorGroup.CUSTOMER:
                        {
                            btnMeet.Visible = false;
                        }
                        break;

                }

            }
        }

        private void InitialControlData()
        {
            if (formMode == FormMode.Add && VISITOR_GROUP == VisitorGroup.APPOINTMENT)
            {
                if (TrnVisitor != null)
                {

                    txtFirstName.Text = TrnVisitor.FIRST_NAME;
                    txtLastName.Text = TrnVisitor.LAST_NAME;
                    txtIDCard.Text = TrnVisitor.ID_CARD;
                    txtEmployee.Text = TrnVisitor.MAS_EMPLOYEE != null
                        ? TrnVisitor.MAS_EMPLOYEE.FIRST_NAME + " " + TrnVisitor.MAS_EMPLOYEE.LAST_NAME
                        : "ไม่ระบุ";
                    txtReason.Text = TrnVisitor.MAS_REASON != null
                        ? TrnVisitor.MAS_REASON.REASON
                        : "ไม่ระบุ";

                    _contactEmployeeId = TrnVisitor.MAS_EMPLOYEE?.AUTO_ID ?? 0;
                    _reasonId = TrnVisitor.MAS_REASON?.AUTO_ID ?? 0;
                }
            }
            else if (formMode == FormMode.Edit)
            {

                if (TrnVisitor != null)
                {
                    txtNo.Text = TrnVisitor.NO.ToString();
                    txtFirstName.Text = TrnVisitor.FIRST_NAME;
                    txtLastName.Text = TrnVisitor.LAST_NAME;
                    txtIDCard.Text = TrnVisitor.ID_CARD;

                    if (TrnVisitor.TRN_ATTACHEDMENT.Count > 0)
                    {
                        if (TrnVisitor.TRN_ATTACHEDMENT.FirstOrDefault()?.ID_CARD_PHOTO != null)
                        {
                            picCard.Image = ByteToImage(TrnVisitor.TRN_ATTACHEDMENT.FirstOrDefault()?.ID_CARD_PHOTO);
                        }
                        if (TrnVisitor.TRN_ATTACHEDMENT.FirstOrDefault()?.CONTACT_PHOTO != null)
                        {
                            picPhoto.Image = ByteToImage(TrnVisitor.TRN_ATTACHEDMENT.FirstOrDefault()?.CONTACT_PHOTO);
                        }

                    }

                    if (TrnVisitor.MAS_CAR_TYPE != null)
                    {
                        _carTypeId = TrnVisitor.MAS_CAR_TYPE.AUTO_ID;
                        if (TrnVisitor.MAS_CAR_TYPE.NAME.Trim() != "ไม่ระบุ" &&
                            TrnVisitor.MAS_CAR_TYPE.NAME.Trim() != "เดินเท้า")
                        {
                            tableLayoutPanel2.Visible = true;
                            tableLayoutPanel8.Visible = true;
                            txtCar.Text = TrnVisitor.MAS_CAR_TYPE.NAME;
                            if (TrnVisitor.MAS_PROVINCE != null)
                            {
                                _provinceId = TrnVisitor.MAS_PROVINCE.AUTO_ID;
                                txtProvince.Text = TrnVisitor.MAS_PROVINCE.NAME;
                                txtLicense.Text = TrnVisitor.LICENSE_PLATE;
                            }
                        }
                        else
                        {
                            txtCar.Text = TrnVisitor.MAS_CAR_TYPE.NAME;
                            tableLayoutPanel2.Visible = false;
                            tableLayoutPanel8.Visible = false;
                        }
                    }


                    switch (this.VISITOR_GROUP)
                    {
                        case VisitorGroup.APPOINTMENT:
                        case VisitorGroup.NORMAL:
                            {
                                txtEmployee.Text = TrnVisitor.MAS_EMPLOYEE != null
                                    ? TrnVisitor.MAS_EMPLOYEE.FIRST_NAME + " " + TrnVisitor.MAS_EMPLOYEE.LAST_NAME
                                    : "ไม่ระบุ";
                                txtReason.Text = TrnVisitor.MAS_REASON != null
                                    ? TrnVisitor.MAS_REASON.REASON
                                    : "ไม่ระบุ";

                                _contactEmployeeId = TrnVisitor.MAS_EMPLOYEE?.AUTO_ID ?? 0;
                                _reasonId = TrnVisitor.MAS_REASON?.AUTO_ID ?? 0;

                            }
                            break;
                        case VisitorGroup.CONSTRUCTOR:
                        case VisitorGroup.CUSTOMER:
                            {
                                txtEmployee.Text = TrnVisitor.CONTACT_EMPLOYEE_NAME;
                                txtReason.Text = TrnVisitor.REASON_TEXT;
                            }
                            break;
                    }
                }



            }
        }

        private string DisplayTextGroup(VisitorGroup group)
        {
            string type = "";
            switch (group)
            {
                case VisitorGroup.APPOINTMENT:
                    type = "นัดล่วงหน้า";
                    break;
                case VisitorGroup.CONSTRUCTOR:
                    type = "กลุ่มโครงการ";
                    break;
                case VisitorGroup.CUSTOMER:
                    type = "กลุ่มลููกค้า";
                    break;
                case VisitorGroup.NORMAL:
                    type = "บุคคลทั่วไป";
                    break;


            }
            return type;
        }

        private string DisplayTextType(VisitorType type)
        {
            string text = "";
            switch (type)
            {
                case VisitorType.IN:
                    text = "เข้า";
                    break;
                case VisitorType.OUT:
                    text = "ออก";
                    break;



            }
            return text;
        }

        private bool ValidateControl()
        {
            bool status = false;

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
                    return false;
                };
            }

            switch (this.VISITOR_GROUP)
            {
                case VisitorGroup.NORMAL:
                case VisitorGroup.APPOINTMENT:
                    {
                        List<string> listMsg = new List<string>();
                        if (string.IsNullOrEmpty(txtFirstName.Text)) listMsg.Add("ชื่อจริง");
                        if (string.IsNullOrEmpty(txtLastName.Text)) listMsg.Add("นามสกุล");
                        if (string.IsNullOrEmpty(txtIDCard.Text)) listMsg.Add("รหัสบัตรประชาชน");
                        if (string.IsNullOrEmpty(txtEmployee.Text) || _contactEmployeeId == 0) listMsg.Add("ผู้ที่ต้องการเข้าพบ");
                        if (string.IsNullOrEmpty(txtReason.Text) || _reasonId == 0) listMsg.Add("วัตถุประสงค์");
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
                case VisitorGroup.CONSTRUCTOR:
                case VisitorGroup.CUSTOMER:
                    {
                        List<string> listMsg = new List<string>();
                        if (string.IsNullOrEmpty(txtFirstName.Text)) listMsg.Add("ชื่อจริง");

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

        private void SaveTrnVisitor()
        {

            TRN_VISITOR source = new TRN_VISITOR();
            switch (this.VISITOR_GROUP)
            {
                case VisitorGroup.NORMAL:
                case VisitorGroup.APPOINTMENT:
                    {
                        TRN_VISITOR obj = new TRN_VISITOR()
                        {
                            #region === Obj ==
                            YEAR = DateTime.Now.Year,
                            MONTH = DateTime.Now.Month,
                            NO = Convert.ToInt32(txtNo.Text),
                            ID_CARD = txtIDCard.Text,
                            TYPE = "IN",
                            GROUP = VISITOR_GROUP == VisitorGroup.NORMAL ? nameof(VisitorGroup.NORMAL) : nameof(VisitorGroup.APPOINTMENT),
                            BY_PASS = _cardType == "OTHER_CARD" ? "Y" : "N",
                            CAR_TYPE_ID = _carTypeId,
                            CONTACT_EMPLOYEE_ID = _contactEmployeeId,
                            CONTACT_EMPLOYEE_NAME = txtEmployee.Text,
                            FIRST_NAME = txtFirstName.Text,
                            LAST_NAME = txtLastName.Text,
                            LICENSE_PLATE = (txtCar.Text.Trim() == "เดินเท้า" && txtCar.Text.Trim() == "ไม่ระบุ") ? "ไม่ระบุ" : txtLicense.Text,
                            LICENSE_PLATE_PROVINCE_ID = _provinceId != 0 ? _provinceId : (int?)null,
                            REASON_ID = _reasonId,
                            REASON_TEXT = txtReason.Text,
                            STATUS = 1,
                            CREATED_BY = LOGIN,
                            CREATED_DATE = DateTime.Now,
                            UPDATED_BY = LOGIN,
                            UPDATED_DATE = DateTime.Now,
                            TRN_ATTACHEDMENT = new List<TRN_ATTACHEDMENT>()
                            #endregion

                        };

                        TRN_ATTACHEDMENT attached = new TRN_ATTACHEDMENT();
                        string dir = DIRECTORY_IN + "\\" + obj.NO + "\\";
                        Directory.CreateDirectory(dir);
                        attached.PHOTO_URL = dir;
                        if (flgCardImgChange)
                        {
                            attached.ID_CARD_PHOTO = ImageToByte(picCard);
                            attached.CREATED_BY = LOGIN;
                            attached.CREATED_DATE = DateTime.Now;
                            attached.UPDATED_BY = LOGIN;
                            attached.UPDATED_DATE = DateTime.Now;
                            picPhoto.Image.Save(dir + "PHOTO.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        if (flgPhotoImgChange)
                        {
                            attached.CREATED_BY = LOGIN;
                            attached.CREATED_DATE = DateTime.Now;
                            attached.UPDATED_BY = LOGIN;
                            attached.UPDATED_DATE = DateTime.Now;
                            attached.CONTACT_PHOTO = ImageToByte(picPhoto);
                            picCard.Image.Save(dir + "ID_CARD.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }

                        obj.TRN_ATTACHEDMENT.Add(attached);
                        source = obj;



                    }
                    break;
                case VisitorGroup.CONSTRUCTOR:
                case VisitorGroup.CUSTOMER:
                    {

                        TRN_VISITOR obj = new TRN_VISITOR()
                        {

                            #region === Obj ==
                            YEAR = DateTime.Now.Year,
                            MONTH = DateTime.Now.Month,
                            NO = Convert.ToInt32(txtNo.Text),
                            ID_CARD = txtIDCard.Text,
                            TYPE = "IN",
                            GROUP = VISITOR_GROUP == VisitorGroup.CONSTRUCTOR ? nameof(VisitorGroup.CONSTRUCTOR) : nameof(VisitorGroup.CUSTOMER),
                            BY_PASS = _cardType == "OTHER_CARD" ? "Y" : "N",
                            CAR_TYPE_ID = _carTypeId,
                            CONTACT_EMPLOYEE_NAME = txtEmployee.Text,
                            FIRST_NAME = txtFirstName.Text,
                            LICENSE_PLATE = (txtCar.Text.Trim() == "เดินเท้า" && txtCar.Text.Trim() == "ไม่ระบุ") ? "ไม่ระบุ" : txtLicense.Text,
                            LICENSE_PLATE_PROVINCE_ID = _provinceId != 0 ? _provinceId : (int?)null,
                            REASON_TEXT = txtReason.Text,
                            STATUS = 1,

                            CREATED_BY = LOGIN,
                            CREATED_DATE = DateTime.Now,
                            UPDATED_BY = LOGIN,
                            UPDATED_DATE = DateTime.Now,
                            TRN_ATTACHEDMENT = new List<TRN_ATTACHEDMENT>()
                            #endregion
                        };

                        if (VISITOR_GROUP == VisitorGroup.CONSTRUCTOR)
                        {
                            obj.PROJECT_ID = TrnProjectMaster.AUTO_ID;
                        }
                        else
                        {
                            obj.CUSTOMER_ID = TrnCustomerVisit.AUTO_ID;
                        }
                        TRN_ATTACHEDMENT attached = new TRN_ATTACHEDMENT();
                        string dir = DIRECTORY_IN + "\\" + obj.NO + "\\";
                        Directory.CreateDirectory(dir);
                        attached.PHOTO_URL = dir;
                        if (flgCardImgChange)
                        {
                            attached.ID_CARD_PHOTO = ImageToByte(picCard);
                            attached.CREATED_BY = LOGIN;
                            attached.CREATED_DATE = DateTime.Now;
                            attached.UPDATED_BY = LOGIN;
                            attached.UPDATED_DATE = DateTime.Now;
                            picPhoto.Image.Save(dir + "PHOTO.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        if (flgPhotoImgChange)
                        {
                            attached.CONTACT_PHOTO = ImageToByte(picPhoto);
                            attached.CREATED_BY = LOGIN;
                            attached.CREATED_DATE = DateTime.Now;
                            attached.UPDATED_BY = LOGIN;
                            attached.UPDATED_DATE = DateTime.Now;
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

                if (source.GROUP == nameof(VisitorGroup.NORMAL) &&
                    source.GROUP == nameof(VisitorGroup.APPOINTMENT))
                {
                    #region Normal && Appointment
                    var obj = _vistorServices.GetVisitorReportById(((TRN_VISITOR)resp.ResultObj).AUTO_ID);

                    if (obj.ResultObj.Count > 0)
                    {
                        List<CustomDisplayVisitor> listData = (List<CustomDisplayVisitor>)obj.ResultObj;
                        DataTable dt = ConvertToDataTable(listData);
                        ReportDocument rpt = new ReportDocument();
                        string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                        if (listData.FirstOrDefault()?.BY_PASS == "N" || listData.FirstOrDefault()?.BY_PASS == null)
                        {
                            var appPath = Application.StartupPath + "\\" + "ReportSlip.rpt";
                            rpt.Load(appPath);
                            rpt.SetDataSource(dt);
                            rpt.PrintToPrinter(1, true, 0, 0);
                        }
                        else
                        {
                            var appPath = Application.StartupPath + "\\" + "ReportSlipByPass.rpt";
                            rpt.Load(appPath);
                            rpt.SetDataSource(dt);
                            rpt.PrintToPrinter(1, true, 0, 0);
                        }

                    }
                    #endregion
                }
                else if (source.GROUP == nameof(VisitorGroup.CONSTRUCTOR))
                {
                    #region Constructor
                    var response = _vistorServices.GetConstructorReport(((TRN_VISITOR)resp.ResultObj).AUTO_ID);
                    if (response.Status)
                    {
                        Project projectObj = (Project)response.ResultObj;
                        DataTable dtHeader = ConvertToDataTable(projectObj.LIST_PROJECT_HEADER);
                        DataTable dtMember = ConvertToDataTable(projectObj.LIST_PROJECT_MEMBER);
                        ReportDocument rpt = new ReportDocument();
                        string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                        var appPath = Application.StartupPath + "\\" + "ReportConstructor.rpt";
                        rpt.Load(appPath);
                        var k = rpt.Database.Tables[0];
                        rpt.Database.Tables[0].SetDataSource(dtHeader);
                        rpt.Database.Tables[1].SetDataSource(dtMember);
                        rpt.PrintToPrinter(1, true, 0, 0);
                    }

                    #endregion

                }
                else
                {
                    #region Customer
                    var response = _vistorServices.GetCustomerReport(((TRN_VISITOR)resp.ResultObj).AUTO_ID);
                    if (response.Status)
                    {
                        CustomerReport CustomerObj = (CustomerReport)response.ResultObj;
                        DataTable dtHeader = ConvertToDataTable(CustomerObj.LIST_CUSTOMER_HEADER);
                        DataTable dtMember = ConvertToDataTable(CustomerObj.LIST_CUSTOMER);
                        ReportDocument rpt = new ReportDocument();
                        string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                        var appPath = Application.StartupPath + "\\" + "ReportCustomer.rpt";
                        rpt.Load(appPath);
                        //var k = rpt.Database.Tables[0];
                        rpt.Database.Tables[0].SetDataSource(dtHeader);
                        rpt.Database.Tables[1].SetDataSource(dtMember);
                        rpt.PrintToPrinter(1, true, 0, 0);
                    }


                    #endregion

                }


                MessageBox.Show(Message.MSG_SAVE_COMPLETE, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(resp.Message + resp.ExceptionMessage);
            }

        }


        private void UpdateTrnVisitor()
        {

            TRN_VISITOR source = new TRN_VISITOR();
            switch (this.VISITOR_GROUP)
            {
                case VisitorGroup.NORMAL:
                case VisitorGroup.APPOINTMENT:
                    {
                        TRN_VISITOR obj = new TRN_VISITOR()
                        {
                            #region === Obj ==
                            AUTO_ID = TrnVisitor.AUTO_ID,
                            YEAR = DateTime.Now.Year,
                            MONTH = DateTime.Now.Month,
                            NO = Convert.ToInt32(txtNo.Text),
                            ID_CARD = txtIDCard.Text,
                            TYPE = TrnVisitor.TYPE,
                            GROUP = VISITOR_GROUP == VisitorGroup.NORMAL ? nameof(VisitorGroup.NORMAL) : nameof(VisitorGroup.APPOINTMENT),
                            BY_PASS = TrnVisitor.BY_PASS,
                            CAR_TYPE_ID = _carTypeId,
                            CONTACT_EMPLOYEE_ID = _contactEmployeeId,
                            CONTACT_EMPLOYEE_NAME = txtEmployee.Text,
                            FIRST_NAME = txtFirstName.Text,
                            LAST_NAME = txtLastName.Text,
                            LICENSE_PLATE = (txtCar.Text.Trim() == "เดินเท้า" && txtCar.Text.Trim() == "ไม่ระบุ") ? "ไม่ระบุ" : txtLicense.Text,
                            LICENSE_PLATE_PROVINCE_ID = _provinceId != 0 ? _provinceId : (int?)null,
                            REASON_ID = _reasonId,
                            REASON_TEXT = txtReason.Text,
                            STATUS = 1,
                            CREATED_BY = TrnVisitor.CREATED_BY,
                            CREATED_DATE = TrnVisitor.CREATED_DATE,
                            UPDATED_BY = LOGIN,
                            UPDATED_DATE = DateTime.Now,
                            TRN_ATTACHEDMENT = new List<TRN_ATTACHEDMENT>()
                            #endregion

                        };

                        TRN_ATTACHEDMENT attached = new TRN_ATTACHEDMENT();
                        string dir = DIRECTORY_IN + "\\" + obj.NO + "\\";
                        Directory.CreateDirectory(dir);
                        attached.PHOTO_URL = dir;
                        if (flgCardImgChange)
                        {
                            attached.ID_CARD_PHOTO = ImageToByte(picCard);
                            attached.CREATED_BY = LOGIN;
                            attached.CREATED_DATE = DateTime.Now;
                            attached.UPDATED_BY = LOGIN;
                            attached.UPDATED_DATE = DateTime.Now;
                            picCard.Image.Save(dir + "ID_CARD.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        if (flgPhotoImgChange)
                        {
                            attached.CONTACT_PHOTO = ImageToByte(picPhoto);
                            attached.CREATED_BY = LOGIN;
                            attached.CREATED_DATE = DateTime.Now;
                            attached.UPDATED_BY = LOGIN;
                            attached.UPDATED_DATE = DateTime.Now;
                            picCard.Image.Save(dir + "PHOTO.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }

                        obj.TRN_ATTACHEDMENT.Add(attached);
                        source = obj;
                    }
                    break;
                case VisitorGroup.CONSTRUCTOR:
                case VisitorGroup.CUSTOMER:
                    {

                        TRN_VISITOR obj = new TRN_VISITOR()
                        {

                            #region === Obj ==
                            AUTO_ID = TrnVisitor.AUTO_ID,
                            YEAR = DateTime.Now.Year,
                            MONTH = DateTime.Now.Month,
                            NO = Convert.ToInt32(txtNo.Text),
                            ID_CARD = txtIDCard.Text,
                            TYPE = TrnVisitor.TYPE,
                            GROUP = VISITOR_GROUP == VisitorGroup.CONSTRUCTOR ? nameof(VisitorGroup.CONSTRUCTOR) : nameof(VisitorGroup.CUSTOMER),
                            BY_PASS = _cardType == "OTHER_CARD" ? "Y" : "N",
                            CAR_TYPE_ID = _carTypeId,
                            CONTACT_EMPLOYEE_NAME = txtEmployee.Text,
                            FIRST_NAME = txtFirstName.Text,
                            LICENSE_PLATE = (txtCar.Text.Trim() == "เดินเท้า" && txtCar.Text.Trim() == "ไม่ระบุ") ? "ไม่ระบุ" : txtLicense.Text,
                            LICENSE_PLATE_PROVINCE_ID = _provinceId != 0 ? _provinceId : (int?)null,
                            REASON_TEXT = txtReason.Text,
                            STATUS = 1,
                            CREATED_BY = TrnVisitor.CREATED_BY,
                            CREATED_DATE = TrnVisitor.CREATED_DATE,
                            UPDATED_BY = LOGIN,
                            UPDATED_DATE = DateTime.Now,
                            TRN_ATTACHEDMENT = new List<TRN_ATTACHEDMENT>()
                            #endregion
                        };
                        TRN_ATTACHEDMENT attached = new TRN_ATTACHEDMENT();
                        string dir = DIRECTORY_IN + "\\" + obj.NO + "\\";
                        Directory.CreateDirectory(dir);
                        attached.PHOTO_URL = dir;
                        if (flgCardImgChange)
                        {
                            attached.ID_CARD_PHOTO = ImageToByte(picCard);
                            attached.CREATED_BY = LOGIN;
                            attached.CREATED_DATE = DateTime.Now;
                            attached.UPDATED_BY = LOGIN;
                            attached.UPDATED_DATE = DateTime.Now;
                            picCard.Image.Save(dir + "ID_CARD.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        if (flgPhotoImgChange)
                        {
                            attached.CONTACT_PHOTO = ImageToByte(picPhoto);
                            attached.CREATED_BY = LOGIN;
                            attached.CREATED_DATE = DateTime.Now;
                            attached.UPDATED_BY = LOGIN;
                            attached.UPDATED_DATE = DateTime.Now;
                            picPhoto.Image.Save(dir + "PHOTO.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }

                        obj.TRN_ATTACHEDMENT.Add(attached);
                        source = obj;
                    }
                    break;
            }

            var resp = _vistorServices.UpdateVisitor(source, flgCardImgChange, flgPhotoImgChange);
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
