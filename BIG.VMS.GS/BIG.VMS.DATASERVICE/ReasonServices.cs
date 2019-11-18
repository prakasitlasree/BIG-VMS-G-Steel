using BIG.VMS.DAL;
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.CustomModel.Container;
using BIG.VMS.MODEL.CustomModel.CustomContainer;
using BIG.VMS.MODEL.EntityModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIG.VMS.DATASERVICE
{
    public class ReasonServices
    {
        public IQueryable<MAS_REASON> GetListReason(ContainerReason obj)
        {

            try
            {
                var ctx = new BIG_VMSEntities();
                var filter = obj.Filter;
                IQueryable<MAS_REASON> query = ctx.MAS_REASON;
                if (obj.Filter != null)
                {

                    if (!string.IsNullOrEmpty(filter.REASON))
                    {
                        query = query.Where(o => o.REASON.Contains(filter.REASON));
                    }


                    query.OrderBy(o => o.SHOW_SEQ);
                    return query;
                }
                else
                {
                    query.OrderBy(o => o.SHOW_SEQ);
                    return query;
                }

            }
            catch
            {
                throw;
            }
        }
        public Response AddReason(MAS_REASON reason)
        {
            var result = new Response();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var data = ctx.MAS_REASON.Add(reason);

                    ctx.SaveChanges();
                    result.ResultObj = data;
                    result.Status = true;
                    result.Message = "Save Successful";
                }
                catch (DbEntityValidationException ex)
                {
                    string message = "";
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        foreach (var ve in eve.ValidationErrors)
                        {
                            message += ve.PropertyName + " " + ve.ErrorMessage;

                        }
                    }
                    result.Status = false;
                    result.ExceptionMessage = ex.Message + message;
                }
                catch (Exception ex)
                {
                    result.Status = false;
                    result.ExceptionMessage = ex.Message.ToString();
                }
            }

            return result;
        }
        public Response GetReason(int id)
        {
            var result = new Response();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var data = ctx.MAS_REASON.Where(o => o.AUTO_ID == id).FirstOrDefault();


                    result.ResultObj = data;
                    result.Status = true;
                    result.Message = "Save Successful";
                }
                catch (DbEntityValidationException ex)
                {
                    string message = "";
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        foreach (var ve in eve.ValidationErrors)
                        {
                            message += ve.PropertyName + " " + ve.ErrorMessage;

                        }
                    }
                    result.Status = false;
                    result.ExceptionMessage = ex.Message + message;
                }
                catch (Exception ex)
                {
                    result.Status = false;
                    result.ExceptionMessage = ex.Message.ToString();
                }
            }

            return result;
        }
        public Response UpadateReason(MAS_REASON reason)
        {
            var result = new Response();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var data = ctx.MAS_REASON.Where(o => o.AUTO_ID == reason.AUTO_ID).FirstOrDefault();
                    if (data != null)
                    {
                        data.REASON = reason.REASON;

                        data.SHOW_FLAG = reason.SHOW_FLAG;
                        data.SHOW_SEQ = reason.SHOW_SEQ;

                    }
                    ctx.SaveChanges();
                    result.ResultObj = data;
                    result.Status = true;
                    result.Message = "Save Successful";
                }
                catch (DbEntityValidationException ex)
                {
                    string message = "";
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        foreach (var ve in eve.ValidationErrors)
                        {
                            message += ve.PropertyName + " " + ve.ErrorMessage;

                        }
                    }
                    result.Status = false;
                    result.ExceptionMessage = ex.Message + message;
                }
                catch (Exception ex)
                {
                    result.Status = false;
                    result.ExceptionMessage = ex.Message.ToString();
                }
            }

            return result;
        }
        public Response DeleteReason(int id)
        {
            var result = new Response();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var data = ctx.MAS_REASON.Where(o => o.AUTO_ID == id).FirstOrDefault();
                    ctx.MAS_REASON.Remove(data);
                    ctx.SaveChanges();
                    result.ResultObj = data;
                    result.Status = true;
                    result.Message = "Save Successful";
                }
                catch (DbEntityValidationException ex)
                {
                    string message = "";
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        foreach (var ve in eve.ValidationErrors)
                        {
                            message += ve.PropertyName + " " + ve.ErrorMessage;

                        }
                    }
                    result.Status = false;
                    result.ExceptionMessage = ex.Message + message;
                }
                catch (Exception ex)
                {
                    result.Status = false;
                    result.ExceptionMessage = ex.Message.ToString();
                }
            }

            return result;
        }
        public ContainerReason GetItem(ContainerReason obj)
        {
            var result = new ContainerReason();

            using (var ctx = new BIG_VMSEntities())
            {
                var listData = new List<CustomReason>();
                var blList = ctx.TRN_BLACKLIST.ToList();
                try
                {

                    var query = GetListReason(obj).Select(item => new CustomReason()
                    {
                        AUTO_ID = item.AUTO_ID,

                        REASON = item.REASON,
                        DEPT_ID = item.DEPT_ID,
                        SHOW_FLAG = item.SHOW_FLAG,
                        SHOW_SEQ = item.SHOW_SEQ

                    }).ToList();


                    if (obj.PageInfo != null)
                    {
                        obj.PageInfo.TOTAL_PAGE = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(query.Count()) / Convert.ToDouble(obj.PageInfo.PAGE_SIZE)));

                        listData = query.OrderBy(o => o.SHOW_SEQ)
                                           .Skip(obj.PageInfo.PAGE_SIZE * (obj.PageInfo.PAGE - 1))
                                           .Take(obj.PageInfo.PAGE_SIZE)
                                           .ToList();
                        result.PageInfo = obj.PageInfo;
                    }
                    else
                    {
                        Pagination page = new Pagination();
                        page.TOTAL_PAGE = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(query.Count()) / Convert.ToDouble(page.PAGE_SIZE)));
                        listData = query.OrderBy(o => o.SHOW_SEQ)
                                          .Skip(page.PAGE_SIZE * (page.PAGE - 1))
                                          .Take(page.PAGE_SIZE)
                                          .ToList();



                        result.PageInfo = page;
                    }

                    result.ResultObj = listData;
                    result.Status = true;
                    result.Message = "Retrive Data Successful";
                }
                catch (Exception ex)
                {
                    result.Status = false;
                    result.Message = ex.Message.ToString();
                }

            }

            return result;
        }
    }
}
