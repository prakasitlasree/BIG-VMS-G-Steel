using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIG.VMS.DAL;
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.CustomModel.CustomContainer;
using BIG.VMS.MODEL.EntityModel;

namespace BIG.VMS.DATASERVICE
{
    public class ReportServices
    {
        public Response GetReportVisitorTypeAll(string group, DateTime dtFrom, DateTime dtTo)
        {
            Response resp = new Response();
            List<CustomReportVisitorAll> listData = new List<CustomReportVisitorAll>();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    IQueryable<TRN_VISITOR> query = ctx.TRN_VISITOR;
                    if (group != "ALL")
                    {
                        query = query.Where(o => o.GROUP == group);
                    }

                    dtFrom = dtFrom.Date;
                    dtTo = dtTo.Date;
                    dtTo = dtTo.AddDays(1);

                    query = query.Where(x => x.CREATED_DATE >= dtFrom && x.CREATED_DATE <= dtTo);
                    var visitorIn = query.Where(o => o.TYPE == "IN").ToList();
                    var visitorOut = query.Where(o => o.TYPE == "OUT").ToList();

                    listData = (from item in visitorIn
                                select new CustomReportVisitorAll()
                                {
                                    NO = item.NO.ToString(),
                                    REASON_TEXT = item.REASON_TEXT.ToString(),
                                    ID_CARD = item.ID_CARD.ToString(),
                                    CREATED_BY = item.CREATED_BY.ToString(),
                                    FULL_NAME = $@"{item.FIRST_NAME} {item.LAST_NAME}",
                                    CAR_INFO = item.MAS_CAR_TYPE != null ? $@"{item.MAS_CAR_TYPE.NAME} {item.LICENSE_PLATE}" : "ไม่ระบุ",
                                    EMP_NAME = item.CONTACT_EMPLOYEE_NAME,
                                    TIME_IN = item.CREATED_DATE.ToString(),
                                    TIME_OUT = visitorOut.Any(o => o.REF_ID == item.AUTO_ID)
                                        ? visitorOut.FirstOrDefault(o => o.REF_ID == item.AUTO_ID)?.CREATED_DATE.ToString()
                                        : "ไม่ระบุุ"

                                }).ToList();

                    resp.Status = true;
                    resp.ResultObj = listData;
                }
            }
            catch (Exception ex)
            {
                resp.Status = false;
                resp.ExceptionMessage = ex.Message.ToString();
            }

            return resp;
        }

        public Response GetReportVisitor(string group, string type, DateTime dtFrom, DateTime dtTo)
        {
            Response resp = new Response();
            List<CustomReportVisitor> listData = new List<CustomReportVisitor>();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    IQueryable<TRN_VISITOR> query = ctx.TRN_VISITOR;
                    if (group != "ALL")
                    {
                        query = query.Where(o => o.GROUP == group);
                    }

                    dtFrom = dtFrom.Date;
                    dtTo = dtTo.Date;
                    dtTo = dtTo.AddDays(1);

                    query = query.Where(x => x.CREATED_DATE >= dtFrom && x.CREATED_DATE <= dtTo);


                    if (type == "IN")
                    {
                        query = query.Where(o => o.TYPE == "IN");
                    }
                    else
                    {
                        query = query.Where(o => o.TYPE == "OUT");
                    }
                    var visitor = query.ToList();


                    listData = (from item in visitor
                                select new CustomReportVisitor()
                                {
                                    NO = item.NO.ToString(),
                                    REASON_TEXT = item.REASON_TEXT.ToString(),
                                    ID_CARD = item.ID_CARD.ToString(),
                                    CREATED_BY = item.CREATED_BY.ToString(),
                                    FULL_NAME = $@"{item.FIRST_NAME} {item.LAST_NAME}",
                                    CAR_INFO = item.MAS_CAR_TYPE != null ? $@"{item.MAS_CAR_TYPE.NAME} {item.LICENSE_PLATE}" : "ไม่ระบุ",
                                    EMP_NAME = item.CONTACT_EMPLOYEE_NAME,
                                    TIME = item.CREATED_DATE.ToString(),
                                    TYPE = item.TYPE,
                                    GROUP = item.GROUP,

                                }).ToList();

                    resp.Status = true;
                    resp.ResultObj = listData;
                }
            }
            catch (Exception ex)
            {
                resp.Status = false;
                resp.ExceptionMessage = ex.Message.ToString();
            }

            return resp;
        }
    }


}
