using BIG.VMS.DAL;
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.EntityModel;
using BIG.VMS.MODEL.GsteelModel.ContainerModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIG.VMS.DATASERVICE
{
    public class ProjectServices
    {
        public Response GetListProject(ContainerProject source)
        {
            var resp = new Response();
            ContainerProject container = new ContainerProject();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var query = ctx.TRN_PROJECT_MASTER;

                    #region === Filter ===
                    if (source.Filter != null)
                    {
                        var filter = source.Filter;

                        if (!string.IsNullOrEmpty(filter.PROJECT_NAME))
                        {
                            query.Where(o => o.PROJECT_NAME.ToUpper().Contains(filter.PROJECT_NAME.ToUpper()));
                        }

                    }
                    #endregion

                    #region === Paging ===
                    if (source.PageInfo != null)
                    {
                        if (source.PageInfo != null)
                        {
                            source.PageInfo.TOTAL_PAGE = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(query.Count()) / Convert.ToDouble(source.PageInfo.PAGE_SIZE)));

                            container.ListData = query.OrderByDescending(o => o.UPDATED_DATE)
                                                    .Skip(source.PageInfo.PAGE_SIZE * (source.PageInfo.PAGE - 1))
                                                    .Take(source.PageInfo.PAGE_SIZE)
                                                    .ToList();

                            container.PageInfo = source.PageInfo;
                        }
                        else
                        {
                            Pagination page = new Pagination();
                            page.TOTAL_PAGE = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(query.Count()) / Convert.ToDouble(page.PAGE_SIZE)));
                            container.ListData = query.OrderByDescending(o => o.UPDATED_DATE)
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

        public Response UpdateProject(TRN_PROJECT_MASTER source)
        {
            var resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var obj = ctx.TRN_PROJECT_MASTER.Where(o => o.AUTO_ID == source.AUTO_ID).FirstOrDefault();

                    obj.HRA_MANAGER_APP_BY = source.HRA_MANAGER_APP_BY;
                    obj.ID_BADGE_EXPIRED_DATE = source.ID_BADGE_EXPIRED_DATE;
                    obj.ID_BADGE_ISSUED_DATE = source.ID_BADGE_ISSUED_DATE;
                    obj.ID_BADGE_TYPE = source.ID_BADGE_TYPE;
                    obj.PROJECT_END_DATE = source.PROJECT_END_DATE;
                    obj.PROJECT_NAME = source.PROJECT_NAME;
                    obj.PROJECT_SCOPE = source.PROJECT_SCOPE;
                    obj.PROJECT_START_DATE = source.PROJECT_START_DATE;
                    obj.PROJECT_WORKING_TIME = source.PROJECT_WORKING_TIME;
                    obj.PURCHASING_VERIFY_BY = source.PURCHASING_VERIFY_BY;
                    obj.PURCHASING_VERIFY_DATE = source.PURCHASING_VERIFY_DATE;
                    obj.REGISTER_DATE = source.REGISTER_DATE;
                    obj.RESPONSIBLE_DEP_HEAD = source.RESPONSIBLE_DEP_HEAD;
                    obj.RESPONSIBLE_MANAGER = source.RESPONSIBLE_MANAGER;
                    obj.RESPONSIBLE_TEL = source.RESPONSIBLE_TEL;
                    obj.SAFETY_MANAGER_APP_BY = source.SAFETY_MANAGER_APP_BY;
                    obj.SAFETY_TRAINING_EXPIRED_DATE = source.SAFETY_TRAINING_EXPIRED_DATE;
                    obj.SAFETY_TRAINING_ISSUED_DATE = source.SAFETY_TRAINING_ISSUED_DATE;
                    obj.SAFETY_TRAINING_REQUIRE = source.SAFETY_TRAINING_REQUIRE;
                    obj.UPDATED_BY = source.UPDATED_BY;
                    obj.UPDATED_DATE = source.UPDATED_DATE;
                    obj.WORKING_AREA = source.WORKING_AREA;
                    obj.WORKING_DAY = source.WORKING_DAY;

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

        public Response AddProject(TRN_PROJECT_MASTER project)
        {
            var resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    ctx.TRN_PROJECT_MASTER.Add(project);
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

        public Response AddProjectMember(TRN_PROJECT_MEMBER source)
        {
            var resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    ctx.TRN_PROJECT_MEMBER.Add(source);
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


        public Response DeleteProjectMember(int id)
        {
            var resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var obj = ctx.TRN_PROJECT_MEMBER.Where(o => o.AUTO_ID == id).FirstOrDefault();
                   
                    if (obj != null)
                    {
                        ctx.TRN_PROJECT_MEMBER.Remove(obj);
                        ctx.SaveChanges();
                        resp.ResultObj = ctx.TRN_PROJECT_MEMBER.Where(o => o.PROJECT_ID == obj.PROJECT_ID).ToList();
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

        public Response DeleteProject(int id)
        {
            var resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {

                    var project = ctx.TRN_PROJECT_MASTER.Where(o => o.AUTO_ID == id).First();
                    if (project != null)
                    {
                        ctx.TRN_PROJECT_MASTER.Remove(project);
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

        public Response GetProjectbyProjectID(int id)
        {
            var resp = new Response();


            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var project = ctx.TRN_PROJECT_MASTER
                        .Include("TRN_PROJECT_MEMBER")
                        .Where(o => o.AUTO_ID == id).FirstOrDefault();

                    resp.ResultObj = project;
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

        public Response GetConstractor(int id)
        {
            var resp = new Response();


            try
            {
                using (var ctx = new BIG_VMSEntities())
                {

                    var contractor = ctx.MAS_CONTRACTOR
                        .Include("TRN_PROJECT_MASTER")
                        .Include("TRN_PROJECT_MASTER.TRN_PROJECT_MEMBER")
                        .Where(o => o.AUTO_ID == id)
                        .FirstOrDefault();

                    resp.ResultObj = contractor;
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
