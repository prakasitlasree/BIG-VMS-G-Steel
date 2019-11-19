using BIG.VMS.DATASERVICE;
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
    public partial class frmViewImage : Form
    {
        public int visitorId = 0;
        private VisitorServices _visitorService = new VisitorServices();
        public frmViewImage()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void FrmViewImage_Load(object sender, EventArgs e)
        {
            if(visitorId > 0)
            {
                var resp = _visitorService.GetVisitorImage(visitorId);
                if (resp.Status)
                {
                    if(resp.ResultObj  != null)
                    {
                        TRN_ATTACHEDMENT attachment = resp.ResultObj;
                        if (attachment.ID_CARD_PHOTO == null &&
                            attachment.CONTACT_PHOTO == null &&
                            attachment.SLIP_PHOTO == null &&
                            attachment.REF_PHOTO1 == null &&
                            attachment.REF_PHOTO2 == null &&
                            attachment.REF_PHOTO3 == null)
                        {
                            MessageBox.Show("ไม่พบรูปภาพ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                        }
                        else
                        {
                            if(attachment.ID_CARD_PHOTO != null)
                            {
                                picCard.Image = ByteToImage(attachment.ID_CARD_PHOTO);
                            }
                            if (attachment.CONTACT_PHOTO != null)
                            {
                                picPhoto.Image = ByteToImage(attachment.CONTACT_PHOTO);
                            }
                            if (attachment.SLIP_PHOTO != null)
                            {
                                picSlip.Image = ByteToImage(attachment.SLIP_PHOTO);

                            }
                            if (attachment.REF_PHOTO1 != null)
                            {
                                picRef1.Image = ByteToImage(attachment.REF_PHOTO1);
                            }
                            if (attachment.REF_PHOTO2 != null)
                            {
                                picRef2.Image = ByteToImage(attachment.REF_PHOTO2);

                            }
                            if (attachment.REF_PHOTO3 != null)
                            {
                                picRef3.Image = ByteToImage(attachment.REF_PHOTO3);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบรูปภาพ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("ไม่พบรูปภาพ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
          
        }
    }
}
