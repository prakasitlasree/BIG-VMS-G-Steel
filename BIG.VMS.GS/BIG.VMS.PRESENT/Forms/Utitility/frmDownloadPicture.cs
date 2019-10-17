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
            var resp = service.DownloadImage(container);
            if (resp.Status)
            {
                List<TRN_ATTACHEDMENT> listData = resp.ResultObj;
                foreach (var item in listData)
                {
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

                MessageBox.Show("ดาวน์โหลดภาพเรียบร้อย");
            }
        }



        public Bitmap ByteToImage(byte[] blob, string url)
        {
            try
            {
                MemoryStream mStream = new MemoryStream();
                byte[] pData = blob;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                Bitmap bm = new Bitmap(mStream, false);
                if (Directory.Exists(url))
                {
                    bm.Save(url, System.Drawing.Imaging.ImageFormat.Jpeg);
                }


                mStream.Dispose();
                return bm;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
