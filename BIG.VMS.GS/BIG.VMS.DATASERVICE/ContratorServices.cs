using BIG.VMS.DAL;
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.CustomModel.Container;
using BIG.VMS.MODEL.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIG.VMS.DATASERVICE
{
   public class ContratorServices
    {
        public Response GetListConstractor(ContainerContractor source)
        {
            var resp = new Response();
            ContainerContractor container = new ContainerContractor();
            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var query = ctx.MAS_CONTRACTOR;

                    #region === Filter ===
                    if (source.Filter != null)
                    {
                        var filter = source.Filter;

                        if (!string.IsNullOrEmpty(filter.NAME))
                        {
                            query.Where(o => o.NAME.ToUpper().Contains(filter.NAME.ToUpper()));
                        }
                        if (!string.IsNullOrEmpty(filter.ADDRESS))
                        {
                            query.Where(o => o.ADDRESS.ToUpper().Contains(filter.ADDRESS.ToUpper()));
                        }
                        if (!string.IsNullOrEmpty(filter.TEL))
                        {
                            query.Where(o => o.TEL.ToUpper().Contains(filter.TEL.ToUpper()));
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

        public Response AddConstractor(MAS_CONTRACTOR source)
        {
            var resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var query = ctx.MAS_CONTRACTOR;
                    source.UPDATED_DATE = DateTime.Now;
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

        public Response UpdateContractor(MAS_CONTRACTOR source)
        {
            var resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var obj = ctx.MAS_CONTRACTOR.Where(o => o.AUTO_ID == source.AUTO_ID).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.NAME = source.NAME;
                        obj.ADDRESS = source.ADDRESS;
                        obj.TEL = source.TEL;
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


        public MAS_CONTRACTOR GetContractor(int AUTO_ID)
        {
            var resp = new MAS_CONTRACTOR();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var obj = ctx.MAS_CONTRACTOR.Where(o => o.AUTO_ID == AUTO_ID).FirstOrDefault();
                    resp = obj;
                }

            }
            catch (Exception ex)
            {
                
            }


            return resp;
        }
        public Response DeleteContractor(int id)
        {
            var resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var obj = ctx.MAS_CONTRACTOR.Where(o => o.AUTO_ID == id).FirstOrDefault();
                    if (obj != null)
                    {
                        ctx.MAS_CONTRACTOR.Remove(obj);
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
    }
}
