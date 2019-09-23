using BIG.VMS.DATASERVICE;
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.EntityModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIG.VMS.GS.API.Controllers
{
    public class APIController : Controller
    {
        // GET: API
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetVisitorData(int no)
        {
            var resp = new VisitorServices().GetVisitorTransactionByNo_Api(no);
            return Json(resp, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetLastVistorTransaction()
        {
            var resp = new VisitorServices().GetLastVisitorTransaction_Api();
            return Json(resp, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateVisitorOut()
        {

            HttpFileCollectionBase files = Request.Files;
            var no = int.Parse(Request.Form["NO"].ToString());
            var auto_id = int.Parse(Request.Form["AUTO_ID"].ToString());

            TRN_ATTACHEDMENT attachment = new TRN_ATTACHEDMENT();
            for (int i = 0; i < files.Count; i++)
            {
                HttpPostedFileBase file = files[i];

                byte[] image = GetImageBinary(file);

                switch (files.AllKeys[i])
                {
                    case ("FILE#1"):
                        {
                            attachment.REF_PHOTO1 = image;
                        }
                        break;
                    case ("FILE#2"):
                        {
                            attachment.REF_PHOTO2 = image;
                        }
                        break;
                    case ("FILE#3"):
                        {
                            attachment.REF_PHOTO3 = image;
                        }
                        break;
                }

            }

            var resp = new VisitorServices().UpdateVisitorOutBy_Api(no, auto_id, attachment);

            return Json(resp, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateVistorImgRef()
        {
            Response resp = new MODEL.CustomModel.Response();
            HttpFileCollectionBase files = Request.Files;
            var no = int.Parse(Request.Form["NO"].ToString());
            var auto_id = int.Parse(Request.Form["AUTO_ID"].ToString());

            for (int i = 0; i < files.Count; i++)
            {
                HttpPostedFileBase file = files[i];
                byte[] image = GetImageBinary(file);
                resp = new VisitorServices().UpdateVisitorImgRef_Api(no, auto_id, files.AllKeys[i], image);
            }

            return Json(resp, JsonRequestBehavior.AllowGet);
        }

        private byte[] GetImageBinary(HttpPostedFileBase file)
        {
            Image img = Image.FromStream(file.InputStream, true, true);
            using (var ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(img, 240, 120);
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                return ms.ToArray();

            }

        }

    }
}