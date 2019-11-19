using BIG.VMS.DAL;
using BIG.VMS.MODEL;
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
    public class EmployeeServices : IService<ContainerEmployee>
    {
        public ContainerEmployee Create(ContainerEmployee obj)
        {
            throw new NotImplementedException();
        }

        public ContainerEmployee Delete(ContainerEmployee obj)
        {
            throw new NotImplementedException();
        }

        public ContainerEmployee Retrieve(ContainerEmployee obj)
        {
            throw new NotImplementedException();
        }

        public ContainerEmployee Update(ContainerEmployee obj)
        {
            throw new NotImplementedException();
        }

        public IQueryable<MAS_EMPLOYEE> GetListEmployee(ContainerEmployee obj)
        {

            try
            {
                var ctx = new BIG_VMSEntities();
                var filter = obj.Filter;
                IQueryable<MAS_EMPLOYEE> query = ctx.MAS_EMPLOYEE.Include("MAS_DEPARTMENT");
                if (obj.Filter != null)
                {

                    if (!string.IsNullOrEmpty(filter.FIRST_NAME))
                    {
                        query = query.Where(o => o.FIRST_NAME.Contains(filter.FIRST_NAME));
                    }
                    if (!string.IsNullOrEmpty(filter.LAST_NAME))
                    {
                        query = query.Where(o => o.LAST_NAME.Contains(filter.LAST_NAME));
                    }
                    if (filter.DEPARTMENT_ID > 0)
                    {
                        query = query.Where(o => o.DEPARTMENT_ID == filter.DEPARTMENT_ID);
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
        public Response AddEmployee(MAS_EMPLOYEE employee)
        {
            var result = new Response();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var data = ctx.MAS_EMPLOYEE.Add(employee);

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
        public Response GetEmployee(int id)
        {
            var result = new Response();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var data = ctx.MAS_EMPLOYEE.Where(o => o.AUTO_ID == id).FirstOrDefault();


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
        public Response UpadateEmployee(MAS_EMPLOYEE employee)
        {
            var result = new Response();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var data = ctx.MAS_EMPLOYEE.Where(o => o.AUTO_ID == employee.AUTO_ID).FirstOrDefault();
                    if (data != null)
                    {
                        data.FIRST_NAME = employee.FIRST_NAME;
                        data.LAST_NAME = employee.LAST_NAME;
                        data.SHOW_FLAG = employee.SHOW_FLAG;
                        data.SHOW_SEQ = employee.SHOW_SEQ;
                        data.DEPARTMENT_ID = employee.DEPARTMENT_ID;
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
        public Response DeleteEmployee(int id)
        {
            var result = new Response();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var data = ctx.MAS_EMPLOYEE.Where(o => o.AUTO_ID == id).FirstOrDefault();
                    if (data.TRN_VISITOR != null)
                    {
                        if (data.TRN_VISITOR.Count > 0)
                        {
                            result.ResultObj = data;
                            result.Status = false;
                            result.Message = $@"มีผู้ติดต่อที่ติดต่อ({data.FIRST_NAME})นี้อยู่ ไม่สามารถลบได้";
                        }
                        else
                        {
                            ctx.MAS_EMPLOYEE.Remove(data);
                            ctx.SaveChanges();
                            result.ResultObj = data;
                            result.Status = true;
                            result.Message = "Save Successful";
                        }
                    }
                    


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
        public ContainerEmployee GetItem(ContainerEmployee obj)
        {
            var result = new ContainerEmployee();

            using (var ctx = new BIG_VMSEntities())
            {
                var listData = new List<CustomEmployee>();
                var blList = ctx.TRN_BLACKLIST.ToList();
                try
                {

                    var query = GetListEmployee(obj).Select(item => new CustomEmployee()
                    {
                        AUTO_ID = item.AUTO_ID,


                        FIRST_NAME = item.FIRST_NAME,
                        LAST_NAME = item.LAST_NAME,
                        DEPARTMENT = item.MAS_DEPARTMENT != null ? item.MAS_DEPARTMENT.NAME : "ไม่ระบุ",
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
