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
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.PRESENT.Forms.Master;

namespace BIG.VMS.PRESENT.Forms.FormVisitorNew
{
    public partial class frmSelectCard : Form
    {

        public string TYPE { get; set; }
        public string CARD_READER { get; set; }
        public bool READ_CARD_STATUS { get; set; }
        public PIDCard CARD { get; set; }
        public string CARD_TYPE { get; set; }
        public DIDCard DID { get; set; }

        public Image OTHER_CARD_IMAGE { get; set; }

        public frmSelectCard()
        {
            InitializeComponent();
        }

        private void FrmSelectCard_Load(object sender, EventArgs e)
        {
            //btnDriverCard.Click += new EventHandler(ButtonClick);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            TYPE = button.Tag.ToString();
            ReturnType();
        }

        private string ReturnType()
        {
            this.DialogResult = DialogResult.OK;
            return TYPE;
        }

        private void BtnIdCard_Click(object sender, EventArgs e)
        {
            ReadPidCard();
            TYPE = "ID_CARD";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void ListCardReader()
        {
            byte[] szReaders = new byte[1024 * 2];
            int size = szReaders.Length;
            int numreader = RDNID.getReaderListRD(szReaders, size);
            if (numreader <= 0)
                return;
            string s = CardHelper.ByteToString(szReaders);
            string[] readlist = s.Split(';');
            if (readlist != null)
            {
                for (int i = 0; i < readlist.Length; i++)
                {
                    CARD_READER = readlist[i];
                }
            }
        }
        protected int ReadPidCard()
        {
            try
            {
                string strTerminal = CARD_READER;
                CARD = new PIDCard();
                CARD_TYPE = "PID";
                IntPtr obj = CardHelper.SelectReader(strTerminal);

                int nInsertCard = 0;
                nInsertCard = RDNID.connectCardRD(obj);
                if (nInsertCard != 0)
                {
                    String m;
                    m = $" error no {nInsertCard} ";
                    MessageBox.Show(m);

                    RDNID.disconnectCardRD(obj);
                    RDNID.deselectReaderRD(obj);
                    return nInsertCard;
                }

                byte[] id = new byte[30];
                int res = RDNID.getNIDNumberRD(obj, id);
                if (res != DefineConstants.NID_SUCCESS)
                {
                    return res;
                }
                string nidNum = CardHelper.ByteToString(id);


                byte[] data = new byte[1024];
                res = RDNID.getNIDTextRD(obj, data, data.Length);
                if (res != DefineConstants.NID_SUCCESS)
                    return res;

                string nidData = CardHelper.ByteToString(data);
                if (nidData == "")
                {
                    MessageBox.Show("Read Text error");
                }
                else
                {
                    string[] fields = nidData.Split('#');
                    CARD.NO = nidNum;
                    CARD.TH_TITLE = fields[(int)Enums.NID_FIELD.TITLE_T];
                    CARD.TH_FIRST_NAME = fields[(int)Enums.NID_FIELD.NAME_T];
                    CARD.TH_MID_NAME = fields[(int)Enums.NID_FIELD.MIDNAME_T];
                    CARD.TH_LAST_NAME = fields[(int)Enums.NID_FIELD.SURNAME_T];
                    CARD.EN_TITLE = fields[(int)Enums.NID_FIELD.TITLE_E];
                    CARD.EN_FIRST_NAME = fields[(int)Enums.NID_FIELD.NAME_E];
                    CARD.EN_MID_NAME = fields[(int)Enums.NID_FIELD.MIDNAME_E];
                    CARD.EN_LAST_NAME = fields[(int)Enums.NID_FIELD.SURNAME_E];
                    CARD.BIRTH_DATE = CardHelper.DateFormat(fields[(int)Enums.NID_FIELD.BIRTH_DATE]);
                    CARD.HOME_NO = fields[(int)Enums.NID_FIELD.HOME_NO];
                    CARD.MOO = fields[(int)Enums.NID_FIELD.MOO];
                    CARD.TROK = fields[(int)Enums.NID_FIELD.TROK];
                    CARD.SOI = fields[(int)Enums.NID_FIELD.SOI];
                    CARD.ROAD = fields[(int)Enums.NID_FIELD.ROAD];
                    CARD.TUMBON = fields[(int)Enums.NID_FIELD.TUMBON];
                    CARD.AMPHOE = fields[(int)Enums.NID_FIELD.AMPHOE];
                    CARD.PROVINCE = fields[(int)Enums.NID_FIELD.PROVINCE];

                    if (fields[(int)Enums.NID_FIELD.GENDER] == "1")
                    {
                        CARD.GENDER = "ชาย";
                    }
                    else
                    {
                        CARD.GENDER = "หญิง";
                    }
                }

                byte[] nidPicture = new byte[1024 * 5];
                int imgsize = nidPicture.Length;
                res = RDNID.getNIDPhotoRD(obj, nidPicture, out imgsize);
                if (res != DefineConstants.NID_SUCCESS)
                    return res;

                byte[] byteImage = nidPicture;
                {
                    //m_picPhoto
                    Image img = Image.FromStream(new MemoryStream(byteImage));
                    CARD.PHOTO = new Bitmap(img, 270 - 2, 180 - 2);
                    CARD.CARD_IMAGE = img;
                    CARD.BYTE_IMAGE = byteImage;
                }
                RDNID.disconnectCardRD(obj);
                RDNID.deselectReaderRD(obj);
                READ_CARD_STATUS = true;
            }
            catch (Exception ex)
            {
                READ_CARD_STATUS = false;
                MessageBox.Show("ไม่พบเครื่องอ่านบัตรประชาชน หรืออ่านบัตรไม่สำเร็จ!!! " + ex.Message);

            }

            return 0;

        }

        private void BtnDriverCard_Click(object sender, EventArgs e)
        {
            DrivingLicenseCardInfo frm = new DrivingLicenseCardInfo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DID = new DIDCard();
                TYPE = "DRIVER_CARD"; //Driving card ID
                try
                {
                    string[] temp = frm.DID_INFO.Split('$');
                    if (temp.Length > 0)
                    {
                        string[] str = { };
                        string[] str2 = { };
                        try
                        {
                            string[] no = temp[2].Replace("\r\n", "").Split('?');
                            str = no;
                        }
                        catch
                        {
                            // ignored
                        }

                        try
                        {
                            string[] no2 = str[1].Replace("\r\n", "").Split('=');
                            str2 = no2;
                        }
                        catch
                        {

                        }
                        try
                        {
                            DID.NO = str2[0].Replace(";", "").ToString().Substring(6);


                        }
                        catch
                        {

                        }
                        try
                        {
                            DID.FIRST_NAME_EN = temp[1].ToString();
                        }
                        catch
                        {

                        }
                        try
                        {
                            DID.LAST_NAME_EN = temp[0].Trim().Replace("%", "").Replace("^", "").Replace(" ", "");
                        }
                        catch
                        {

                        }


                    }
                    READ_CARD_STATUS = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    DID.NO = "99999999999999";
                    DID.FIRST_NAME_EN = "ERROR";
                    DID.LAST_NAME_EN = "ERROR";

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }

        private void BtnOtherCard_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new CameraSelection();
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    if (frm.CAMERA != null)
                    {
                        TYPE = "OTHER_CARD";
                        OTHER_CARD_IMAGE = frm.CAMERA;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReadPidCard();
            TYPE = "ID_CARD";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pb_driving_Click(object sender, EventArgs e)
        {
            DrivingLicenseCardInfo frm = new DrivingLicenseCardInfo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DID = new DIDCard();
                TYPE = "DRIVER_CARD"; //Driving card ID
                try
                {
                    string[] temp = frm.DID_INFO.Split('$');
                    if (temp.Length > 0)
                    {
                        string[] str = { };
                        string[] str2 = { };
                        try
                        {
                            string[] no = temp[2].Replace("\r\n", "").Split('?');
                            str = no;
                        }
                        catch
                        {
                            // ignored
                        }

                        try
                        {
                            string[] no2 = str[1].Replace("\r\n", "").Split('=');
                            str2 = no2;
                        }
                        catch
                        {

                        }
                        try
                        {
                            DID.NO = str2[0].Replace(";", "").ToString().Substring(6);


                        }
                        catch
                        {

                        }
                        try
                        {
                            DID.FIRST_NAME_EN = temp[1].ToString();
                        }
                        catch
                        {

                        }
                        try
                        {
                            DID.LAST_NAME_EN = temp[0].Trim().Replace("%", "").Replace("^", "").Replace(" ", "");
                        }
                        catch
                        {

                        }


                    }
                    READ_CARD_STATUS = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    DID.NO = "99999999999999";
                    DID.FIRST_NAME_EN = "ERROR";
                    DID.LAST_NAME_EN = "ERROR";

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }

        private void pb_capturecard_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new CameraSelection();
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    if (frm.CAMERA != null)
                    {
                        TYPE = "OTHER_CARD";
                        OTHER_CARD_IMAGE = frm.CAMERA;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
