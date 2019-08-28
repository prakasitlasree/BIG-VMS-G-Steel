using BIG.VMS.DATASERVICE;
using System;
using System.Collections.Generic;
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
            var resp = new VisitorServices().GetVisitorForOutByNo(no);

            resp.TRN_VISITOR.MAS_CAR_TYPE = new MODEL.EntityModel.MAS_CAR_TYPE();
            resp.TRN_VISITOR.MAS_EMPLOYEE = new MODEL.EntityModel.MAS_EMPLOYEE();
            resp.TRN_VISITOR.MAS_PROVINCE = new MODEL.EntityModel.MAS_PROVINCE();
            resp.TRN_VISITOR.MAS_REASON = new MODEL.EntityModel.MAS_REASON();


            return Json(resp, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UploadFiles()
        {
            string path = Server.MapPath("~/Content/Upload/");
            HttpFileCollectionBase files = Request.Files;
            for (int i = 0; i < files.Count; i++)
            {
                HttpPostedFileBase file = files[i];
                file.SaveAs(path + file.FileName);
            }

            return Json(files.Count + " Files Uploaded!");
        }
    }
}