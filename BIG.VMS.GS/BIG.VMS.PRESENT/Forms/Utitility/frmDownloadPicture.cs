using BIG.VMS.DATASERVICE;
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.CustomModel.Container;
using BIG.VMS.MODEL.EntityModel;
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

namespace BIG.VMS.PRESENT.Forms.Utitility
{
    public partial class frmDownloadPicture : Form
    {
        VisitorServices service = new VisitorServices();
        ContainerDisplayVisitor container = new ContainerDisplayVisitor();
        public frmDownloadPicture()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Download();
        }

        private void Download()
        {
            container.Filter = new VisitorFilter();
            container.Filter.DATE_FROM = dtFrom.Value;
            container.Filter.DATE_TO = dtTo.Value.AddDays(1);
            var resp = service.DownloadImage(container);
            List<string> errorImage = new List<string>();
            if (resp.Status)
            {
                List<TRN_ATTACHEDMENT> listData = resp.ResultObj;
                foreach (var item in listData)
                {
                    if (item.CONTACT_PHOTO != null ||
                        item.ID_CARD_PHOTO != null ||
                        item.REF_PHOTO1 != null ||
                        item.REF_PHOTO2 != null ||
                        item.REF_PHOTO3 != null)
                    {
                        try
                        {
                            if (!Directory.Exists(item.PHOTO_URL))
                            {
                                Directory.CreateDirectory(item.PHOTO_URL);
                            }
                            if (item.CONTACT_PHOTO != null)
                            {
                                var img = ByteToImage(item.CONTACT_PHOTO, item.PHOTO_URL + "CONTACT_PHOTO.jpg");
                            }
                            if (item.ID_CARD_PHOTO != null)
                            {
                                var img = ByteToImage(item.ID_CARD_PHOTO, item.PHOTO_URL + "ID_CARD_PHOTO.jpg");
                            }
                            if (item.REF_PHOTO1 != null)
                            {
                                var img = ByteToImage(item.REF_PHOTO1, item.PHOTO_URL + "REF_PHOTO_1.jpg");
                            }
                            if (item.REF_PHOTO2 != null)
                            {
                                var img = ByteToImage(item.REF_PHOTO2, item.PHOTO_URL + "REF_PHOTO_2.jpg");
                            }
                            if (item.REF_PHOTO3 != null)
                            {
                                var img = ByteToImage(item.REF_PHOTO3, item.PHOTO_URL + "REF_PHOTO_3.jpg");
                            }
                        }
                        catch (Exception ex)
                        {
                            errorImage.Add($@"ไม่สามารถดาวน์โหลดภาพเลขที่ {item.TRN_VISITOR.NO} เนื่องจาก {ex.Message}");
                            
                        }

                    }

                }

                MessageBox.Show("ดาวน์โหลดภาพเรียบร้อย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(errorImage.Count > 0)
                {
                    string msg = string.Join(",", errorImage);
                    MessageBox.Show(msg, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Bitmap ByteToImage(byte[] blob, string url)
        {
            try
            {
                MemoryStream mStream = new MemoryStream();
                byte[] pData = blob;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                Bitmap bm = new Bitmap(mStream, false);

                bm.Save(url, System.Drawing.Imaging.ImageFormat.Jpeg);



                mStream.Dispose();
                return bm;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private Bitmap ByteToImage(byte[] blob)
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

        public void BindingLayout()
        {
            container.Filter = new VisitorFilter();
            container.Filter.DATE_FROM = dtFrom.Value;
            container.Filter.DATE_TO = dtTo.Value.AddDays(1);

            var resp = service.DownloadImage(container);
            if (resp.Status)
            {

                List<TRN_ATTACHEDMENT> listData = resp.ResultObj;
                imgPanel.Controls.Clear();
                foreach (var item in listData)
                {
                    if (item.CONTACT_PHOTO != null || item.ID_CARD_PHOTO != null || item.REF_PHOTO1 != null || item.REF_PHOTO2 != null || item.REF_PHOTO3 != null)
                    {

                        FlowLayoutPanel panel = new FlowLayoutPanel();
                        panel.Height = 370;
                        panel.Width = 350;
                        panel.AutoScroll = true;
                        panel.BorderStyle = BorderStyle.FixedSingle;

                        Label lb = new Label();
                        lb.AutoSize = false;
                        lb.Width = 350;
                        string type = item.TRN_VISITOR.TYPE == "IN" ? "เข้า" : "ออก";
                        lb.Text = $@"เลขที่ {item.TRN_VISITOR.NO} เดือน {item.TRN_VISITOR.MONTH} ปี {item.TRN_VISITOR.YEAR} ประเภท {type}";
                        panel.Controls.Add(lb);

                        Button btnDownload = new Button();
                        btnDownload.Height = 100;
                        btnDownload.Width = 150;
                        btnDownload.Text = "ดาวน์โหลด";
                        btnDownload.Tag = item;
                        btnDownload.FlatStyle = FlatStyle.Flat;
                        btnDownload.Click += new EventHandler(VisitorSelected_EventHadler);

                        if (item.CONTACT_PHOTO != null)
                        {
                            panel.Controls.Add(LoadPicBox(item.CONTACT_PHOTO));
                        }
                        if (item.ID_CARD_PHOTO != null)
                        {
                            panel.Controls.Add(LoadPicBox(item.ID_CARD_PHOTO));
                        }
                        if (item.REF_PHOTO1 != null)
                        {
                            panel.Controls.Add(LoadPicBox(item.REF_PHOTO1));
                        }
                        if (item.REF_PHOTO2 != null)
                        {
                            panel.Controls.Add(LoadPicBox(item.REF_PHOTO2));
                        }
                        if (item.REF_PHOTO3 != null)
                        {
                            panel.Controls.Add(LoadPicBox(item.REF_PHOTO3));
                        }


                        panel.Controls.Add(btnDownload);
                        imgPanel.Controls.Add(panel);
                    }

                }
            }
        }

        private void frmDownloadPicture_Load(object sender, EventArgs e)
        {
            var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtFrom.MaxDate = dtTo.Value;
            dtTo.MinDate = dtFrom.Value;
            dtFrom.Value = firstDayOfMonth;
            BindingLayout();
        }

        private PictureBox LoadPicBox(byte[] img)
        {
            PictureBox picBox = new PictureBox();
            picBox.Height = 100;
            picBox.Width = 150;
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.BorderStyle = BorderStyle.FixedSingle;
            picBox.Image = ByteToImage(img);
            return picBox;
        }

        private void VisitorSelected_EventHadler(object sender, EventArgs e)
        {
            TRN_ATTACHEDMENT obj = (TRN_ATTACHEDMENT)((Button)sender).Tag;
            try
            {
                if (!Directory.Exists(obj.PHOTO_URL))
                {
                    Directory.CreateDirectory(obj.PHOTO_URL);
                }
                if (obj.CONTACT_PHOTO != null)
                {
                    var img = ByteToImage(obj.CONTACT_PHOTO, obj.PHOTO_URL + "CONTACT_PHOTO.jpg");
                }
                if (obj.ID_CARD_PHOTO != null)
                {
                    var img = ByteToImage(obj.ID_CARD_PHOTO, obj.PHOTO_URL + "ID_CARD_PHOTO.jpg");
                }
                if (obj.REF_PHOTO1 != null)
                {
                    var img = ByteToImage(obj.REF_PHOTO1, obj.PHOTO_URL + "REF_PHOTO_1.jpg");
                }
                if (obj.REF_PHOTO2 != null)
                {
                    var img = ByteToImage(obj.REF_PHOTO2, obj.PHOTO_URL + "REF_PHOTO_2.jpg");
                }
                if (obj.REF_PHOTO3 != null)
                {
                    var img = ByteToImage(obj.REF_PHOTO3, obj.PHOTO_URL + "REF_PHOTO_3.jpg");
                }
                MessageBox.Show($@"บันทึกภาพที่ {obj.PHOTO_URL}", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"บันทึกภาพไม่สำเร็จ {ex.Message}", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void btnDownloadnew_Click(object sender, EventArgs e)
        {
            Download();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            BindingLayout();
        }

        private void DtTo_ValueChanged(object sender, EventArgs e)
        {
            dtFrom.MaxDate = dtTo.Value;
        }

        private void DtFrom_ValueChanged(object sender, EventArgs e)
        {
            dtTo.MinDate = dtFrom.Value;
        }
    }
}
