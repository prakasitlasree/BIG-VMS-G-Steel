using BIG.VMS.DAL;
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.EntityModel;
using BIG.VMS.MODEL.CustomModel.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIG.VMS.DATASERVICE
{
    public class PlanVisitServices
    {
        public Response GetList(ContainerPlanVisit source)
        {
            var resp = new Response();
            var container = new ContainerPlanVisit();
            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var query = ctx.TRN_CUSTOMER_VISIT;

                    #region === Filter ===
                    if (source.Filter != null)
                    {
                        var filter = source.Filter;

                        if (!string.IsNullOrEmpty(filter.CUSTOMER_NAME))
                        {
                            query.Where(o => o.CUSTOMER_NAME.ToUpper().Contains(filter.CUSTOMER_NAME.ToUpper()));
                        }
                        if (!string.IsNullOrEmpty(filter.REQUESTOR_NAME))
                        {
                            query.Where(o => o.REQUESTOR_FULLNAME.ToUpper().Contains(filter.REQUESTOR_NAME.ToUpper()));
                        }
                    }
                    #endregion

                    #region === Paging ===
                    if (source.PageInfo != null)
                    {
                        if (source.PageInfo != null)
                        {
                            source.PageInfo.TOTAL_PAGE = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(query.Count()) / Convert.ToDouble(source.PageInfo.PAGE_SIZE)));

                            container.ResultObj = query.OrderByDescending(o => o.UPDATED_DATE)
                                                    .Skip(source.PageInfo.PAGE_SIZE * (source.PageInfo.PAGE - 1))
                                                    .Take(source.PageInfo.PAGE_SIZE)
                                                    .ToList();

                            container.PageInfo = source.PageInfo;
                        }
                        else
                        {
                            Pagination page = new Pagination();
                            page.TOTAL_PAGE = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(query.Count()) / Convert.ToDouble(page.PAGE_SIZE)));
                            container.ResultObj = query.OrderByDescending(o => o.UPDATED_DATE)
                                              .Skip(page.PAGE_SIZE * (page.PAGE - 1))
                                              .Take(page.PAGE_SIZE)
                                              .ToList();

                            container.PageInfo = page;
                        }
                    }
                    #endregion
                }

                resp.ResultObj = container;
                resp.Status = true;
            }
            catch (Exception ex)
            {
                resp.Status = false;
                resp.ExceptionMessage = ex.Message.ToString();
            }

            return resp;
        }

        public Response Add(TRN_CUSTOMER_VISIT source)
        {
            var resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var query = ctx.TRN_CUSTOMER_VISIT;
                    query.Add(source);
                    ctx.SaveChanges();
                    resp.Status = true;
                }
            }
            catch (Exception ex)
            {
                resp.Status = false;
                resp.ExceptionMessage = ex.Message.ToString();
            }

            return resp;
        }

        public Response Update(TRN_CUSTOMER_VISIT source)
        {
            var resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var obj = ctx.TRN_CUSTOMER_VISIT.Where(o => o.AUTO_ID == source.AUTO_ID).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.CUSTOMER_NAME = source.CUSTOMER_NAME;
                        obj.DATE_TIME_OF_VISIT = source.DATE_TIME_OF_VISIT;
                        obj.CONTACT_PERSON = source.CONTACT_PERSON;
                        obj.NUMBER_OF_CUSTOMER = source.NUMBER_OF_CUSTOMER;
                        obj.OBJECTIVE_OF_VISIT = source.OBJECTIVE_OF_VISIT;

                        obj.UPDATED_DATE = DateTime.Now;
                        obj.UPDATED_BY = source.UPDATED_BY;
                    }
                    resp.Status = true;
                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                resp.Status = false;
                resp.ExceptionMessage = ex.Message.ToString();
            }
            return resp;
        }

        public Response GetItem(int AUTO_ID)
        {
            var resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var obj = ctx.TRN_CUSTOMER_VISIT
                        .Include("TRN_CUSTOMER_VISIT_LIST")
                        .Include("TRN_CUSTOMER_VISIT_PURPOSE").Where(o => o.AUTO_ID == AUTO_ID).FirstOrDefault();
                    resp.ResultObj = obj;
                    resp.Status = true;
                }

            }
            catch (Exception ex)
            {
                resp.Message = ex.Message;
            }


            return resp;
        }

        public Response Delete(int id)
        {
            var resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var obj = ctx.TRN_CUSTOMER_VISIT.Where(o => o.AUTO_ID == id).FirstOrDefault();
                    if (obj != null)
                    {
                        ctx.TRN_CUSTOMER_VISIT.Remove(obj);
                        ctx.SaveChanges();
                        resp.Status = true;
                    }
                }

            }
            catch (Exception ex)
            {
                resp.Status = false;
                resp.ExceptionMessage = ex.Message.ToString();
            }


            return resp;
        }

        public Response AddVisitor(TRN_CUSTOMER_VISIT_LIST visitor)
        {
            var resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    ctx.TRN_CUSTOMER_VISIT_LIST.Add(visitor);
                    ctx.SaveChanges();
                    resp.Status = true;

                }

            }
            catch (Exception ex)
            {
                resp.Status = false;
                resp.ExceptionMessage = ex.Message.ToString();
            }


            return resp;
        }

        public Response GetVisitorSeq(int vistorId)
        {
            var resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var list = ctx.TRN_CUSTOMER_VISIT_LIST.Where(o => o.CUSTOMER_VISIT_ID == vistorId).ToList();
                    if (list.Count > 0)
                    {
                        resp.ResultObj = list.Max(o => o.SEQ) + 1;
                    }
                    else
                    {
                        resp.ResultObj = 1;
                    }

                    resp.Status = true;

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
