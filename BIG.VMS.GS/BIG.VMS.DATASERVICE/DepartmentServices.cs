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
    public class DepartmentServices
    {
        public IQueryable<MAS_DEPARTMENT> GetListDepartment(ContainerDepartment obj)
        {

            try
            {
                var ctx = new BIG_VMSEntities();
                var filter = obj.Filter;
                IQueryable<MAS_DEPARTMENT> query = ctx.MAS_DEPARTMENT;
                if (obj.Filter != null)
                {

                    if (!string.IsNullOrEmpty(filter.NAME))
                    {
                        query = query.Where(o => o.NAME.Contains(filter.NAME));
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
        public Response AddDepartment(MAS_DEPARTMENT dept)
        {
            var result = new Response();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var data = ctx.MAS_DEPARTMENT.Add(dept);

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
        public Response GetDepartment(int id)
        {
            var result = new Response();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var data = ctx.MAS_DEPARTMENT.Where(o => o.AUTO_ID == id).FirstOrDefault();


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
        public Response UpadateDepartment(MAS_DEPARTMENT dept)
        {
            var result = new Response();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var data = ctx.MAS_DEPARTMENT.Where(o => o.AUTO_ID == dept.AUTO_ID).FirstOrDefault();
                    if (data != null)
                    {
                        data.NAME = dept.NAME;
                       
                        data.SHOW_FLAG = dept.SHOW_FLAG;
                        data.SHOW_SEQ = dept.SHOW_SEQ;
                     
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
        public Response DeleteDepartment(int id)
        {
            var result = new Response();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var data = ctx.MAS_DEPARTMENT.Where(o => o.AUTO_ID == id).FirstOrDefault();
                    ctx.MAS_DEPARTMENT.Remove(data);
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
        public ContainerDepartment GetItem(ContainerDepartment obj)
        {
            var result = new ContainerDepartment();

            using (var ctx = new BIG_VMSEntities())
            {
                var listData = new List<CustomDepartment>();
                var blList = ctx.TRN_BLACKLIST.ToList();
                try
                {

                    var query = GetListDepartment(obj).Select(item => new CustomDepartment()
                    {
                        AUTO_ID = item.AUTO_ID,


                      NAME = item.NAME,
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
