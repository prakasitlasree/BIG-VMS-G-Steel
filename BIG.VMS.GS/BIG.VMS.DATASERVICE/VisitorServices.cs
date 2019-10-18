using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIG.VMS.DAL;
using BIG.VMS.MODEL;
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.EntityModel;
using BIG.VMS.MODEL.CustomModel.CustomContainer;
using System.Globalization;
using System.Data.Entity.Validation;
using BIG.VMS.MODEL.CustomModel.Container;
using BIG.VMS.MODEL.CustomModel.General;
using BIG.VMS.MODEL.GsteelModel.CustomModel;

namespace BIG.VMS.DATASERVICE
{
    public class VisitorServices : IService<ContainerVisitor>
    {
        public ContainerVisitor GetItem(ContainerVisitor obj)
        {
            var result = new ContainerVisitor();
            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var reTrnVisitor = ctx.TRN_VISITOR.OrderByDescending(x => x.NO).FirstOrDefault();
                    if (reTrnVisitor != null)
                    {


                        result.TRN_VISITOR = reTrnVisitor;
                        result.Status = true;

                    }
                    else
                    {
                        TRN_VISITOR visit = new TRN_VISITOR()
                        {
                            AUTO_ID = 0,
                            NO = 0,
                        };
                        result.TRN_VISITOR = visit;
                        result.Status = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.ExceptionMessage = ex.Message;
            }
            return result;
        }

        public ContainerVisitor GetLastUserNo()
        {
            var result = new ContainerVisitor();
            using (var ctx = new BIG_VMSEntities())
            {
                var reTrnVisitor = ctx.TRN_VISITOR.Where(o => o.MONTH == DateTime.Today.Month && o.YEAR == DateTime.Today.Year).OrderByDescending(x => x.NO).FirstOrDefault();
                if (reTrnVisitor != null)
                {


                    result.TRN_VISITOR = reTrnVisitor;
                    result.Status = true;

                }
                else
                {
                    TRN_VISITOR visit = new TRN_VISITOR()
                    {
                        AUTO_ID = 0,
                        NO = 0,
                    };
                    result.TRN_VISITOR = visit;
                    result.Status = true;
                }
            }
            return result;
        }

        public ContainerVisitor Create(ContainerVisitor obj)
        {
            var result = new ContainerVisitor();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var data = ctx.TRN_VISITOR.Add(obj.TRN_VISITOR);

                    ctx.SaveChanges();
                    result.ResultObj = obj.TRN_VISITOR;
                    result.Status = true;
                    result.Message = "Save Successful";
                }
                catch (DbEntityValidationException ex)
                {
                    result.Status = false;
                    result.Message = ex.Message.ToString();
                }
            }

            return result;
        }

        public ContainerVisitor Delete(ContainerVisitor obj)
        {
            var result = new ContainerVisitor();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var deleteAttach = ctx.TRN_ATTACHEDMENT.Where(o => o.VISITOR_ID == obj.TRN_VISITOR.AUTO_ID).FirstOrDefault();
                    var deleteData = ctx.TRN_VISITOR.Where(o => o.AUTO_ID == obj.TRN_VISITOR.AUTO_ID).FirstOrDefault();

                    if (deleteAttach != null)
                    {
                        ctx.TRN_ATTACHEDMENT.Remove(deleteAttach);
                    }

                    ctx.TRN_VISITOR.Remove(deleteData);
                    ctx.SaveChanges();
                    result.Status = true;
                    result.Message = "Delete Successful";
                }
                catch (Exception ex)
                {
                    result.Status = false;
                    result.Message = ex.Message.ToString();
                }

            }

            return result;
        }

        public ContainerVisitor Retrieve(ContainerVisitor obj)
        {
            var result = new ContainerVisitor();

            using (var ctx = new BIG_VMSEntities())
            {
                var listData = new List<CustomVisitor>();
                try
                {
                    var query = GetListVisitorQuery(obj).Select(item => new CustomVisitor
                    {
                        AUTO_ID = item.AUTO_ID,
                        NO = item.NO,
                        ID_CARD = item.ID_CARD,
                        TYPE = item.TYPE == "In" ? "เข้า" :
                        (item.TYPE == "Out" ? "ออก" :
                        (item.TYPE == "Appointment" ? "นัดล่วงหน้า(เข้า)" :
                        (item.TYPE == "AppointmentOut" ? "นัดล่วงหน้า(ออก)" :
                        (item.TYPE == "ConstructorIn" ? "โครงการ(เข้า)" :
                        (item.TYPE == "ConstructorOut" ? "โครงการ(ออก)" :
                        (item.TYPE == "CustomerIn" ? "ลูกค้า(เข้า)" :
                        (item.TYPE == "CustomerOut" ? "ลูกค้า(ออก)" :
                        "ไม่ระบุ"))))))),

                        FIRST_NAME = item.FIRST_NAME,
                        LAST_NAME = item.LAST_NAME,
                        CAR_TYPE_ID = item.CAR_TYPE_ID,
                        LICENSE_PLATE = item.LICENSE_PLATE,
                        LICENSE_PLATE_PROVINCE_ID = item.LICENSE_PLATE_PROVINCE_ID,
                        REASON_ID = item.REASON_ID,
                        CONTACT_EMPLOYEE_ID = item.CONTACT_EMPLOYEE_ID,
                        STATUS = item.STATUS,
                        CREATED_BY = item.CREATED_BY,
                        CREATED_DATE = item.CREATED_DATE,
                        UPDATED_BY = item.UPDATED_BY,
                        UPDATED_DATE = item.UPDATED_DATE,

                        CONTACT_NAME = item.TYPE == "ConstructorIn" ||
                        item.TYPE == "ConstructorOut" ||
                        item.TYPE == "CustomerIn" ||
                        item.TYPE == "CustomerOut" ? item.CONTACT_EMPLOYEE_NAME : item.MAS_EMPLOYEE.FIRST_NAME + " " + item.MAS_EMPLOYEE.LAST_NAME,

                        CAR_TYPE_NAME = item.MAS_CAR_TYPE.NAME,
                        FULL_NAME = item.FIRST_NAME + " " + item.LAST_NAME,
                        DEPT_NAME = item.MAS_EMPLOYEE.MAS_DEPARTMENT.NAME,
                        TIME_IN = item.CREATED_DATE,

                        TOPIC = item.TYPE == "ConstructorIn" ||
                        item.TYPE == "ConstructorOut" ||
                        item.TYPE == "CustomerIn" ||
                        item.TYPE == "CustomerOut" ? item.REASON_TEXT : item.MAS_REASON.REASON,

                    });


                    if (obj.PageInfo != null)
                    {
                        obj.PageInfo.TOTAL_PAGE = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(query.Count()) / Convert.ToDouble(obj.PageInfo.PAGE_SIZE)));

                        listData = query.OrderByDescending(o => o.UPDATED_DATE)
                                           .Skip(obj.PageInfo.PAGE_SIZE * (obj.PageInfo.PAGE - 1))
                                           .Take(obj.PageInfo.PAGE_SIZE)
                                           .ToList();

                        result.PageInfo = obj.PageInfo;
                    }
                    else
                    {
                        Pagination page = new Pagination();
                        page.TOTAL_PAGE = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(query.Count()) / Convert.ToDouble(page.PAGE_SIZE)));
                        listData = query.OrderByDescending(o => o.UPDATED_DATE)
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

        public ContainerVisitor Update(ContainerVisitor obj)
        {
            var result = new ContainerVisitor();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var visitorObj = obj.TRN_VISITOR;
                    var updateData = ctx.TRN_VISITOR.Where(o => o.AUTO_ID == obj.TRN_VISITOR.AUTO_ID).FirstOrDefault();
                    if (updateData != null)
                    {
                        if (visitorObj.TRN_ATTACHEDMENT.Count > 0)
                        {

                            var attach = ctx.TRN_ATTACHEDMENT.Where(o => o.VISITOR_ID == visitorObj.AUTO_ID).FirstOrDefault();
                            if (attach != null)
                            {
                                attach.CONTACT_PHOTO = visitorObj.TRN_ATTACHEDMENT.FirstOrDefault().CONTACT_PHOTO;
                                attach.ID_CARD_PHOTO = visitorObj.TRN_ATTACHEDMENT.FirstOrDefault().ID_CARD_PHOTO;
                                attach.UPDATED_DATE = DateTime.Now;
                                attach.UPDATED_BY = visitorObj.UPDATED_BY;
                            }
                            else
                            {
                                var att = new TRN_ATTACHEDMENT();
                                att.CONTACT_PHOTO = visitorObj.TRN_ATTACHEDMENT.FirstOrDefault().CONTACT_PHOTO;
                                att.ID_CARD_PHOTO = visitorObj.TRN_ATTACHEDMENT.FirstOrDefault().ID_CARD_PHOTO;
                                attach.UPDATED_DATE = DateTime.Now;
                                attach.UPDATED_BY = visitorObj.UPDATED_BY;
                                attach.UPDATED_DATE = DateTime.Now;
                                attach.UPDATED_BY = visitorObj.UPDATED_BY;
                                att.VISITOR_ID = visitorObj.AUTO_ID;
                            }

                        }

                        updateData.ID_CARD = visitorObj.ID_CARD;
                        updateData.FIRST_NAME = visitorObj.FIRST_NAME;
                        updateData.LAST_NAME = visitorObj.LAST_NAME;
                        updateData.CAR_TYPE_ID = visitorObj.CAR_TYPE_ID;
                        updateData.LICENSE_PLATE = visitorObj.LICENSE_PLATE;
                        updateData.LICENSE_PLATE_PROVINCE_ID = visitorObj.LICENSE_PLATE_PROVINCE_ID;
                        updateData.REASON_ID = visitorObj.REASON_ID;
                        updateData.CONTACT_EMPLOYEE_ID = visitorObj.CONTACT_EMPLOYEE_ID;
                        updateData.REASON_TEXT = visitorObj.REASON_TEXT;
                        updateData.CONTACT_EMPLOYEE_NAME = visitorObj.CONTACT_EMPLOYEE_NAME;
                        updateData.UPDATED_DATE = DateTime.Now;
                        updateData.UPDATED_BY = visitorObj.UPDATED_BY;


                        ctx.SaveChanges();
                        result.Status = true;
                        result.Message = "บันทึกข้อมูลเรียบร้อย";
                    }
                    else
                    {
                        result.Status = false;
                        result.Message = "แก้ไขไม่สำเร็จ";
                    }
                }
                catch (Exception ex)
                {
                    result.Status = false;
                    result.Message = ex.Message.ToString();
                }

            }

            return result;
        }

        public ContainerVisitor GetVisitorForOutByNo(int no)
        {
            var result = new ContainerVisitor();
            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    DateTime today = DateTime.Today;
                    DateTime endOfMonth = new DateTime(today.Year, today.Month, 1).AddMonths(1).AddDays(-1);

                    var startMonth = DateTime.Now.Month;
                    var year = DateTime.Now.Year;
                    var endMonth = DateTime.Now.Month;
                    if (today == endOfMonth)
                    {
                        endMonth = endMonth - 1;

                    }
                    var startDate = DateTime.Now.AddDays(-5);
                    var endDate = DateTime.Now.AddDays(5);

                    var isAlreadyOut = ctx.TRN_VISITOR.Any(o => (o.STATUS == 2) && (o.NO == no && (o.TYPE == "In" || o.TYPE == "Appointment" || o.TYPE == "ConstructorIn" || o.TYPE == "CustomerIn")) && (o.CREATED_DATE >= startDate && o.CREATED_DATE <= endDate) && (o.YEAR == year));
                    if (isAlreadyOut)
                    {
                        TRN_VISITOR visit = new TRN_VISITOR()
                        {
                            AUTO_ID = 0,
                            NO = 0,
                            STATUS = 2,

                        };
                        result.TRN_VISITOR = visit;
                        result.Status = true;
                        result.Message = "หมายเลขนี้ได้ออกไปแล้ว";
                    }
                    else
                    {
                        var reTrnVisitor = ctx.TRN_VISITOR
                                        .Include("MAS_PROVINCE")
                                        .Include("TRN_ATTACHEDMENT")
                                        .Where(o => o.NO == no && (o.TYPE == "In" || o.TYPE == "Appointment" || o.TYPE == "ConstructorIn" || o.TYPE == "CustomerIn"))
                                        .Where(o => (o.CREATED_DATE >= startDate && o.CREATED_DATE <= endDate) && o.YEAR == year)
                                        .OrderByDescending(x => x.NO).ToList();

                        if (reTrnVisitor.Count > 0)
                        {
                            if (reTrnVisitor.Any(o => o.STATUS == 2))
                            {
                                TRN_VISITOR visit = new TRN_VISITOR()
                                {
                                    AUTO_ID = 0,
                                    NO = 0,
                                };
                                result.TRN_VISITOR = visit;
                                result.Status = true;
                                result.Message = "หมายเลขนี้ได้ออกไปแล้ว";
                            }
                            else
                            {
                                result.TRN_VISITOR = reTrnVisitor.FirstOrDefault();
                                result.Status = true;
                            }

                        }
                        else
                        {
                            TRN_VISITOR visit = new TRN_VISITOR()
                            {
                                AUTO_ID = 0,
                                NO = 0,
                            };
                            result.TRN_VISITOR = visit;
                            result.Status = true;
                            result.Message = "ไม่พบข้อมูล";
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.ExceptionMessage = ex.Message;
            }
            return result;
        }

        public ContainerVisitor GetVisitorForOutById(int id)
        {
            var result = new ContainerVisitor();
            try
            {
                using (var ctx = new BIG_VMSEntities())
                {

                    var isAlreadyOut = ctx.TRN_VISITOR.Any(o => (o.STATUS == 2) && (o.AUTO_ID == id));
                    if (isAlreadyOut)
                    {
                        TRN_VISITOR visit = new TRN_VISITOR()
                        {
                            AUTO_ID = 0,
                            NO = 0,
                        };
                        result.TRN_VISITOR = visit;
                        result.Status = true;
                        result.Message = "หมายเลขนี้ได้ออกไปแล้ว";
                    }
                    else
                    {
                        var reTrnVisitor = ctx.TRN_VISITOR
                                        .Include("MAS_PROVINCE")
                                        .Include("TRN_ATTACHEDMENT")
                                        .Where(o => o.AUTO_ID == id && (o.TYPE == "In" || o.TYPE == "Appointment"))
                                        .OrderByDescending(x => x.NO).ToList();

                        if (reTrnVisitor.Count > 0)
                        {
                            if (reTrnVisitor.Any(o => o.STATUS == 2))
                            {
                                TRN_VISITOR visit = new TRN_VISITOR()
                                {
                                    AUTO_ID = 0,
                                    NO = 0,
                                };
                                result.TRN_VISITOR = visit;
                                result.Status = true;
                                result.Message = "หมายเลขนี้ได้ออกไปแล้ว";
                            }
                            else
                            {
                                result.TRN_VISITOR = reTrnVisitor.FirstOrDefault();
                                result.Status = true;
                            }

                        }
                        else
                        {
                            TRN_VISITOR visit = new TRN_VISITOR()
                            {
                                AUTO_ID = 0,
                                NO = 0,
                            };
                            result.TRN_VISITOR = visit;
                            result.Status = true;
                            result.Message = "ไม่พบข้อมูล";
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.ExceptionMessage = ex.Message;
            }
            return result;
        }

        public ContainerVisitor GetVisitorByAutoId(int autoId)
        {
            var result = new ContainerVisitor();
            try
            {

                using (var ctx = new BIG_VMSEntities())
                {
                    var reTrnVisitor = ctx.TRN_VISITOR
                                          .Include("MAS_EMPLOYEE")
                                          .Include("MAS_REASON")
                                          .Include("MAS_PROVINCE")
                                          .Include("MAS_CAR_TYPE")
                                          .Include("TRN_ATTACHEDMENT")
                                          .Where(x => x.AUTO_ID == autoId).FirstOrDefault();
                    if (reTrnVisitor != null)
                    {
                        //var x = string.Join(",",reTrnVisitor.ID_CARD_PHOTO);
                        result.TRN_VISITOR = reTrnVisitor;
                        result.Status = true;
                    }

                }
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.ExceptionMessage = ex.Message;
            }
            return result;
        }

        public ContainerDisplayVisitor GetVisitorReportById(int autoId)
        {
            var result = new ContainerDisplayVisitor();

            List<CustomDisplayVisitor> listData = new List<CustomDisplayVisitor>();
            CultureInfo _cultureTHInfo = new CultureInfo("th-TH");
            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var reTrnVisitor = ctx.TRN_VISITOR
                                          .Include("MAS_EMPLOYEE")
                                          .Include("MAS_REASON")
                                          .Include("MAS_PROVINCE")
                                          .Include("MAS_CAR_TYPE")
                                          .Include("TRN_ATTACHEDMENT")
                                          .Where(x => x.AUTO_ID == autoId).ToList();

                    var reParameter = ctx.SYS_CONFIGURATION.Where(x => x.MODULE == "SLIP" && x.NAME == "COMPANY_NAME").FirstOrDefault();
                    string company = "";
                    if (reParameter != null)
                    {
                        company = reParameter.VALUE;
                    }
                    else
                    {
                        company = "BIG Visitor Management";
                    }
                    if (reTrnVisitor.Count > 0)
                    {


                        listData = (from item in reTrnVisitor
                                    select new CustomDisplayVisitor()
                                    {
                                        AUTO_ID = item.AUTO_ID,
                                        NO = item.NO,
                                        ID_CARD = item.ID_CARD,
                                        FULL_NAME = item.FIRST_NAME + " " + item.LAST_NAME,
                                        CAR_TYPE_NAME = item.MAS_CAR_TYPE != null ? item.MAS_CAR_TYPE.NAME : "",
                                        LICENSE_PLATE = string.IsNullOrEmpty(item.LICENSE_PLATE) ? "ไม่ระบุุ" : item.LICENSE_PLATE,
                                        //PROVINCE = item.MAS_PROVINCE != null ? item.MAS_PROVINCE.NAME : "",
                                        REASON_TEXT = item.MAS_REASON != null ? item.MAS_REASON.REASON : "",
                                        CONTACT_EMP_NAME = item.MAS_EMPLOYEE != null ? item.MAS_EMPLOYEE.FIRST_NAME + " " + item.MAS_EMPLOYEE.LAST_NAME : item.CONTACT_EMPLOYEE_NAME,
                                        TIME_IN = Convert.ToDateTime(item.CREATED_DATE.Value, _cultureTHInfo),
                                        TYPE = item.TYPE == "In" ? "เข้า" : (item.TYPE == "Out" ? "ออก" : (item.TYPE == "Regulary" ? "มาประจำ" : "ไม่ระบุ")),
                                        DEPT_NAME = item.MAS_EMPLOYEE != null ? (item.MAS_EMPLOYEE.MAS_DEPARTMENT != null ? item.MAS_EMPLOYEE.MAS_DEPARTMENT.NAME : "ไม่ระบุ") : "ไม่ระบุ",
                                        ID_CARD_PHOTO = item.TRN_ATTACHEDMENT != null ? (item.TRN_ATTACHEDMENT.Count() > 0 ? item.TRN_ATTACHEDMENT.FirstOrDefault().ID_CARD_PHOTO : null) : null,
                                        CONTACT_PHOTO = item.TRN_ATTACHEDMENT != null ? (item.TRN_ATTACHEDMENT.Count() > 0 ? item.TRN_ATTACHEDMENT.FirstOrDefault().CONTACT_PHOTO : null) : null,
                                        //COMPANY_NAME = company,
                                        CREATED_BY = item.CREATED_BY,
                                        BY_PASS = item.BY_PASS

                                    }).ToList();
                    }

                    result.ResultObj = listData;
                }
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.ExceptionMessage = ex.Message;
            }
            return result;
        }

        public ContainerVisitor UpdateVisitorOut(int id)
        {
            var result = new ContainerVisitor();
            try
            {
                using (var ctx = new BIG_VMSEntities())
                {

                    var reTrnVisitor = ctx.TRN_VISITOR.Where(o => o.AUTO_ID == id).FirstOrDefault();



                    if (reTrnVisitor != null)
                    {

                        reTrnVisitor.STATUS = 2;
                        ctx.SaveChanges();
                        result.Status = true;
                    }
                    else
                    {
                        result.Status = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.ExceptionMessage = ex.Message;
            }
            return result;
        }

        public ContainerVisitor UpdateVisitorOutById(ContainerVisitor obj)
        {
            var result = new ContainerVisitor();
            try
            {
                using (var ctx = new BIG_VMSEntities())
                {

                    var reTrnVisitor = ctx.TRN_VISITOR.Where(o => o.AUTO_ID == obj.TRN_VISITOR.AUTO_ID).FirstOrDefault();



                    if (reTrnVisitor != null)
                    {

                        reTrnVisitor.STATUS = 2;
                        ctx.SaveChanges();
                        result.Status = true;
                    }
                    else
                    {
                        result.Status = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.ExceptionMessage = ex.Message;
            }
            return result;
        }

        public TransactionModel GetVisitorTransaction()
        {
            TransactionModel obj = new TransactionModel();
            DateTime startDate = DateTime.Now.Date;
            DateTime endDate = DateTime.Now.AddDays(1).Date;
            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    obj.ALL_VISITOR_IN = ctx.TRN_VISITOR.Where(o => o.TYPE == "In" || o.TYPE == "Appointment" || o.TYPE == "ConstructorIn" || o.TYPE == "CustomerIn").Count();

                    obj.TODAY_VISITOR_IN = ctx.TRN_VISITOR.Where(o => ((o.TYPE == "In" || o.TYPE == "Appointment" || o.TYPE == "Appointment" || o.TYPE == "ConstructorIn" || o.TYPE == "CustomerIn")
                    && (o.CREATED_DATE >= startDate && o.CREATED_DATE <= endDate))).Count();

                    obj.TODAY_VISITOR_OUT = ctx.TRN_VISITOR.Where(o => ((o.TYPE == "Out" || o.TYPE == "AppointmentOut" || o.TYPE == "Appointment" || o.TYPE == "ConstructorOut" || o.TYPE == "CustomerOut")
                    && (o.CREATED_DATE >= startDate && o.CREATED_DATE <= endDate))).Count();
                }
            }
            catch (Exception ex)
            {

            }

            return obj;
        }

        public ContainerDisplayVisitor GetListVisitorNotOut(ContainerDisplayVisitor obj)
        {
            var result = new ContainerDisplayVisitor();
            var filter = obj.Filter;
            DateTime startDate = filter.DATE_FROM.Date;
            DateTime endDate = DateTime.Now.AddDays(1).Date;
            List<CustomDisplayVisitor> listData = new List<CustomDisplayVisitor>();
            CultureInfo _cultureTHInfo = new CultureInfo("th-TH");

            try
            {

                using (var ctx = new BIG_VMSEntities())
                {

                    var query = ctx.TRN_VISITOR
                                          .Include("MAS_EMPLOYEE")
                                          .Include("MAS_REASON")
                                          .Include("MAS_PROVINCE")
                                          .Include("MAS_CAR_TYPE")
                                          .Where(x => x.CREATED_DATE >= startDate && x.CREATED_DATE <= endDate && x.STATUS == 1);
                    if (filter.NO > 0)
                    {
                        query = query.Where(o => o.NO == filter.NO);
                    }
                    if (!string.IsNullOrEmpty(filter.FIRST_NAME))
                    {
                        query = query.Where(o => o.FIRST_NAME.Contains(filter.FIRST_NAME));
                    }
                    if (!string.IsNullOrEmpty(filter.LAST_NAME))
                    {
                        query = query.Where(o => o.LAST_NAME.Contains(filter.LAST_NAME));
                    }
                    if (!string.IsNullOrEmpty(filter.LICENSE_PLATE))
                    {
                        query = query.Where(o => o.LICENSE_PLATE.Contains(filter.LICENSE_PLATE));
                    }
                    if (!string.IsNullOrEmpty(filter.ID_CARD))
                    {
                        query = query.Where(o => o.ID_CARD.Contains(filter.ID_CARD));
                    }

                    if (filter.DATE_TO != null && filter.DATE_TO != DateTime.MinValue)
                    {
                        endDate = filter.DATE_TO.AddDays(1);
                        query = query.Where(x => x.CREATED_DATE >= filter.DATE_TO && x.CREATED_DATE <= endDate);

                    }



                    var reTrnVisitor = query.ToList();

                    if (reTrnVisitor.Count > 0)
                    {


                        listData = (from item in reTrnVisitor
                                    select new CustomDisplayVisitor()
                                    {
                                        AUTO_ID = item.AUTO_ID,
                                        NO = item.NO,
                                        ID_CARD = item.ID_CARD,

                                        TYPE = item.TYPE == "IN" ? "เข้า" : "ออก",
                                        GROUP = item.GROUP == "NORMAL" ? "บุคคลทั่วไป" :
                                            item.GROUP == "APPOINTMENT" ? "บุคคลที่นัดหมาย" :
                                            item.GROUP == "CONSTRUCTOR" ? "กลุ่มพนักงานรับเหมา" :
                                            item.GROUP == "CUSTOMER" ? "กลุ่มลูกค้า" : "ไม่ระบุ",

                                        FIRST_NAME = item.FIRST_NAME,
                                        LAST_NAME = item.LAST_NAME,
                                        LICENSE_PLATE = item.LICENSE_PLATE,
                                        STATUS = item.STATUS,
                                        CAR_TYPE_NAME = item.MAS_CAR_TYPE.NAME,
                                        //DEPT_NAME = item.MAS_EMPLOYEE.MAS_DEPARTMENT.NAME,
                                        TIME_IN = item.CREATED_DATE,
                                        BY_PASS = item.BY_PASS,
                                        CONTACT_EMP_NAME = item.CONTACT_EMPLOYEE_NAME,
                                        REASON_TEXT = item.REASON_TEXT,
                                        //BLACKLIST = blList.Any(o => o.ID_CARD == item.ID_CARD) ? "Y" : "N",

                                        FULL_NAME = item.FIRST_NAME + " " + item.LAST_NAME,

                                        CREATED_BY = item.CREATED_BY,
                                        CREATED_DATE = item.CREATED_DATE,
                                        UPDATED_BY = item.UPDATED_BY,
                                        UPDATED_DATE = item.UPDATED_DATE,



                                    }).OrderByDescending(x => x.CREATED_DATE).ToList();
                    }

                    if (obj.PageInfo != null)
                    {
                        obj.PageInfo.TOTAL_PAGE = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(listData.Count) / Convert.ToDouble(obj.PageInfo.PAGE_SIZE)));
                        obj.PageInfo.TOTAL_ITEM = listData.Count();

                        listData = listData.Skip(obj.PageInfo.PAGE_SIZE * (obj.PageInfo.PAGE - 1))
                                           .Take(obj.PageInfo.PAGE_SIZE)
                                           .ToList();

                        result.PageInfo = obj.PageInfo;
                    }
                    else
                    {
                        Pagination page = new Pagination();
                        page.TOTAL_PAGE = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(listData.Count) / Convert.ToDouble(page.PAGE_SIZE)));
                        listData = listData.Skip(page.PAGE_SIZE * (page.PAGE - 1))
                                          .Take(page.PAGE_SIZE)
                                          .ToList();

                        result.PageInfo = page;
                    }

                    result.ResultObj = listData;
                }
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.ExceptionMessage = ex.Message;
            }
            return result;
        }

        public Response AddVisitor(TRN_VISITOR source)
        {
            var result = new Response();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var data = ctx.TRN_VISITOR.Add(source);

                    ctx.SaveChanges();
                    result.ResultObj = data;
                    result.Status = true;
                    result.Message = "Save Successful";
                }
                catch (DbEntityValidationException ex)
                {
                    result.Status = false;
                    result.ExceptionMessage = ex.Message.ToString();
                }
                catch (Exception ex)
                {
                    result.Status = false;
                    result.ExceptionMessage = ex.Message.ToString();
                }
            }

            return result;
        }

        public Response UpdateVisitor(TRN_VISITOR source, bool cardChange, bool photoChange)
        {
            var result = new Response();
            using (var ctx = new BIG_VMSEntities())
            {

                try
                {
                    var data = ctx.TRN_VISITOR.Include("TRN_ATTACHEDMENT").FirstOrDefault(o => o.AUTO_ID == source.AUTO_ID);

                    if (data != null)
                    {
                        data.YEAR = source.YEAR;
                        data.MONTH = source.MONTH;
                        data.NO = source.NO;
                        data.ID_CARD = source.ID_CARD;
                        data.TYPE = source.TYPE;
                        data.GROUP = source.GROUP;
                        data.BY_PASS = source.BY_PASS;
                        data.CAR_TYPE_ID = source.CAR_TYPE_ID;
                        data.CONTACT_EMPLOYEE_ID = source.CONTACT_EMPLOYEE_ID;
                        data.CONTACT_EMPLOYEE_NAME = source.CONTACT_EMPLOYEE_NAME;
                        data.FIRST_NAME = source.FIRST_NAME;
                        data.LAST_NAME = source.LAST_NAME;
                        data.LICENSE_PLATE = source.LICENSE_PLATE;
                        data.LICENSE_PLATE_PROVINCE_ID = source.LICENSE_PLATE_PROVINCE_ID;
                        data.REASON_ID = source.REASON_ID;
                        data.REASON_TEXT = source.REASON_TEXT;
                        data.STATUS = source.STATUS;
                        data.CREATED_BY = source.CREATED_BY;
                        data.CREATED_DATE = source.CREATED_DATE;
                        data.UPDATED_BY = source.UPDATED_BY;
                        data.UPDATED_DATE = source.UPDATED_DATE;

                        if (data.TRN_ATTACHEDMENT.Count > 0)
                        {
                            if (cardChange)
                            {
                                data.TRN_ATTACHEDMENT.FirstOrDefault().ID_CARD_PHOTO =
                                    source.TRN_ATTACHEDMENT.FirstOrDefault()?.ID_CARD_PHOTO;
                            }

                            if (photoChange)
                            {
                                data.TRN_ATTACHEDMENT.FirstOrDefault().CONTACT_PHOTO = source.TRN_ATTACHEDMENT.FirstOrDefault()?.CONTACT_PHOTO;
                            }

                        }
                    }

                    ctx.SaveChanges();
                    result.ResultObj = source;
                    result.Status = true;
                    result.Message = "Save Successful";
                }
                catch (DbEntityValidationException ex)
                {
                    result.Status = false;
                    result.ExceptionMessage = ex.Message.ToString();
                }
                catch (Exception ex)
                {
                    result.Status = false;
                    result.ExceptionMessage = ex.Message.ToString();
                }
            }

            return result;
        }

        public Response GetConstructorReport(int autoId)
        {
            Response resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var visitor = ctx.TRN_VISITOR.Where(o => o.AUTO_ID == autoId).FirstOrDefault();
                    if (visitor != null)
                    {
                        var project = ctx.TRN_PROJECT_MASTER
                            .Include("TRN_PROJECT_MEMBER").Where(o => o.AUTO_ID == visitor.PROJECT_ID)
                            .FirstOrDefault();

                        if (project != null)
                        {
                            Project outputData = new Project();

                            outputData.LIST_PROJECT_HEADER = new List<ProjectHeader>();
                            ProjectHeader header = new ProjectHeader()
                            {
                                PROJECT_NAME = project.PROJECT_NAME,
                                CONTRUCTOR_NAME = project.MAS_CONTRACTOR.NAME,
                                RESP_MANAGER = project.RESPONSIBLE_MANAGER,
                                RESP_TEL = project.RESPONSIBLE_TEL,
                                CONTRUCTOR_TEL = project.MAS_CONTRACTOR.TEL

                            };

                            outputData.LIST_PROJECT_HEADER.Add(header);

                            outputData.LIST_PROJECT_MEMBER = new List<ProjectMember>();

                            foreach (var item in project.TRN_PROJECT_MEMBER)
                            {
                                ProjectMember member = new ProjectMember()
                                {
                                    ID_CARD = item.ID_CARD,
                                    FULLNAME = item.FULLNAME
                                };
                                outputData.LIST_PROJECT_MEMBER.Add(member);

                            }

                            resp.Status = true;
                            resp.ResultObj = outputData;
                        }

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

        public Response GetCustomerReport(int autoId)
        {
            Response resp = new Response();

            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var visitor = ctx.TRN_VISITOR.Where(o => o.AUTO_ID == autoId).FirstOrDefault();
                    if (visitor != null)
                    {
                        var customer = ctx.TRN_CUSTOMER_VISIT
                            .Include("TRN_CUSTOMER_VISIT_LIST").Where(o => o.AUTO_ID == visitor.CUSTOMER_ID)
                            .FirstOrDefault();

                        if (customer != null)
                        {
                            CustomerReport outputData = new CustomerReport();

                            outputData.LIST_CUSTOMER_HEADER = new List<CUSTOMER_HEADER>();
                            CUSTOMER_HEADER header = new CUSTOMER_HEADER()
                            {
                                CUST_GROUP_NAME = customer.CUSTOMER_NAME,
                                CUST_OBJECTIVE = customer.OBJECTIVE_OF_VISIT,
                                REQ_DEPT = customer.REQUESTOR_DEPARTMENT,
                                REQ_NAME = customer.REQUESTOR_FULLNAME,
                                REQ_POSITION = customer.REQUESTOR_POSITION

                            };

                            outputData.LIST_CUSTOMER_HEADER.Add(header);

                            outputData.LIST_CUSTOMER = new List<CUSTOMER>();

                            foreach (var item in customer.TRN_CUSTOMER_VISIT_LIST)
                            {
                                CUSTOMER member = new CUSTOMER()
                                {
                                    CUST_NAME = item.FULLNAME,

                                };
                                outputData.LIST_CUSTOMER.Add(member);

                            }

                            resp.Status = true;
                            resp.ResultObj = outputData;
                        }

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

        public ContainerDisplayVisitor GetContainerDisplayVisitor(ContainerDisplayVisitor obj)
        {
            var result = new ContainerDisplayVisitor();

            using (var ctx = new BIG_VMSEntities())
            {
                var listData = new List<CustomDisplayVisitor>();
                var blList = ctx.TRN_BLACKLIST.ToList();
                try
                {
                    var query = GetListDisplayVisitorQuery(obj).Select(item => new CustomDisplayVisitor()
                    {
                        AUTO_ID = item.AUTO_ID,
                        NO = item.NO,
                        ID_CARD = item.ID_CARD,

                        TYPE = item.TYPE == "IN" ? "เข้า" : "ออก",
                        GROUP = item.GROUP == "NORMAL" ? "บุคคลทั่วไป" :
                                item.GROUP == "APPOINTMENT" ? "บุคคลที่นัดหมาย" :
                                item.GROUP == "CONSTRUCTOR" ? "กลุ่มพนักงานรับเหมา" :
                                item.GROUP == "CUSTOMER" ? "กลุ่มลูกค้า" : "ไม่ระบุ",

                        FIRST_NAME = item.FIRST_NAME,
                        LAST_NAME = item.LAST_NAME,
                        LICENSE_PLATE = item.LICENSE_PLATE,
                        STATUS = item.STATUS,
                        CAR_TYPE_NAME = item.MAS_CAR_TYPE.NAME,
                        DEPT_NAME = item.MAS_EMPLOYEE != null ? item.MAS_EMPLOYEE.MAS_DEPARTMENT.NAME : "ไม่ระบุ",
                        TIME_IN = item.CREATED_DATE,
                        BY_PASS = item.BY_PASS,
                        CONTACT_EMP_NAME = item.CONTACT_EMPLOYEE_NAME,
                        REASON_TEXT = item.REASON_TEXT,
                        //BLACKLIST = blList.Any(o => o.ID_CARD == item.ID_CARD) ? "Y" : "N",

                        FULL_NAME = item.FIRST_NAME + " " + item.LAST_NAME,

                        CREATED_BY = item.CREATED_BY,
                        CREATED_DATE = item.CREATED_DATE,
                        UPDATED_BY = item.UPDATED_BY,
                        UPDATED_DATE = item.UPDATED_DATE,

                    });


                    if (obj.PageInfo != null)
                    {
                        obj.PageInfo.TOTAL_PAGE = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(query.Count()) / Convert.ToDouble(obj.PageInfo.PAGE_SIZE)));

                        listData = query.OrderByDescending(o => o.UPDATED_DATE)
                                           .Skip(obj.PageInfo.PAGE_SIZE * (obj.PageInfo.PAGE - 1))
                                           .Take(obj.PageInfo.PAGE_SIZE)
                                           .ToList();


                        foreach (var item in listData)
                        {
                            item.BLACKLIST = blList.Any(o => o.ID_CARD == item.ID_CARD) ? "Y" : "N";
                        }

                        result.PageInfo = obj.PageInfo;
                    }
                    else
                    {
                        Pagination page = new Pagination();
                        page.TOTAL_PAGE = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(query.Count()) / Convert.ToDouble(page.PAGE_SIZE)));
                        listData = query.OrderByDescending(o => o.UPDATED_DATE)
                                          .Skip(page.PAGE_SIZE * (page.PAGE - 1))
                                          .Take(page.PAGE_SIZE)
                                          .ToList();

                        foreach (var item in listData)
                        {
                            item.BLACKLIST = blList.Any(o => o.ID_CARD == item.ID_CARD) ? "Y" : "N";
                        }

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

        public IQueryable<TRN_VISITOR> GetListDisplayVisitorQuery(ContainerDisplayVisitor obj)
        {

            try
            {
                var ctx = new BIG_VMSEntities();
                var filter = obj.Filter;
                IQueryable<TRN_VISITOR> query = ctx.TRN_VISITOR;
                if (obj.Filter != null)
                {
                    if (!string.IsNullOrEmpty(filter.ID_CARD))
                    {
                        query = query.Where(o => o.ID_CARD.Contains(filter.ID_CARD));
                    }
                    if (!string.IsNullOrEmpty(filter.TYPE))
                    {
                        query = query.Where(o => o.TYPE == filter.TYPE);
                    }
                    if (!string.IsNullOrEmpty(filter.GROUP))
                    {
                        query = query.Where(o => o.GROUP == filter.GROUP);
                    }
                    if (!string.IsNullOrEmpty(filter.LICENSE_PLATE))
                    {
                        query = query.Where(o => o.LICENSE_PLATE.Contains(filter.LICENSE_PLATE));
                    }
                    if (filter.NO > 0)
                    {
                        query = query.Where(o => o.NO == filter.NO);
                    }
                    if (!string.IsNullOrEmpty(filter.FIRST_NAME))
                    {
                        query = query.Where(o => o.FIRST_NAME.Contains(filter.FIRST_NAME));
                    }
                    if (!string.IsNullOrEmpty(filter.LAST_NAME))
                    {
                        query = query.Where(o => o.LAST_NAME.Contains(filter.LAST_NAME));
                    }
                    if (filter.DATE_FROM != DateTime.MinValue && filter.DATE_TO != DateTime.MinValue)
                    {
                        var endDate = filter.DATE_TO.AddDays(1);
                        query = query.Where(x => x.CREATED_DATE >= filter.DATE_FROM && x.CREATED_DATE <= endDate);


                    }
                    //if (string.IsNullOrEmpty(filter.FIRST_NAME) && string.IsNullOrEmpty(filter.LAST_NAME) &&
                    //    string.IsNullOrEmpty(filter.LICENSE_PLATE) && filter.NO == 0)
                    //{
                    //    var date = DateTime.Now.AddDays(-30);
                    //    query = query.Where(x => x.CREATED_DATE >= date);
                    //}

                    query.OrderByDescending(o => o.UPDATED_DATE);
                    return query;
                }
                else
                {
                    query.OrderByDescending(o => o.UPDATED_DATE);
                    return query;
                }

            }
            catch
            {
                throw;
            }
        }

        public IQueryable<TRN_VISITOR> GetListVisitorQuery(ContainerVisitor obj)
        {

            try
            {
                var ctx = new BIG_VMSEntities();
                var filter = obj.Filter;
                IQueryable<TRN_VISITOR> query = ctx.TRN_VISITOR;
                if (obj.Filter != null)
                {
                    if (!string.IsNullOrEmpty(filter.ID_CARD))
                    {
                        query = query.Where(o => o.ID_CARD.Contains(filter.ID_CARD));
                    }
                    if (!string.IsNullOrEmpty(filter.TYPE))
                    {
                        query = query.Where(o => o.TYPE == filter.TYPE);
                    }
                    if (!string.IsNullOrEmpty(filter.LICENSE_PLATE))
                    {
                        query = query.Where(o => o.LICENSE_PLATE.Contains(filter.LICENSE_PLATE));
                    }
                    if (filter.NO > 0)
                    {
                        query = query.Where(o => o.NO == filter.NO);
                    }
                    if (!string.IsNullOrEmpty(filter.FIRST_NAME))
                    {
                        query = query.Where(o => o.FIRST_NAME.Contains(filter.FIRST_NAME));
                    }
                    if (!string.IsNullOrEmpty(filter.LAST_NAME))
                    {
                        query = query.Where(o => o.LAST_NAME.Contains(filter.LAST_NAME));
                    }
                    if (filter.DATE_TO != null && filter.DATE_TO != DateTime.MinValue)
                    {
                        var endDate = filter.DATE_TO.AddDays(1);
                        query = query.Where(x => x.CREATED_DATE >= filter.DATE_TO && x.CREATED_DATE <= endDate);

                    }
                    if (string.IsNullOrEmpty(filter.FIRST_NAME) && string.IsNullOrEmpty(filter.LAST_NAME) &&
                        string.IsNullOrEmpty(filter.LICENSE_PLATE) && filter.NO == 0)
                    {
                        var date = DateTime.Now.AddDays(-30);
                        query = query.Where(x => x.CREATED_DATE >= date);
                    }

                    query.OrderByDescending(o => o.UPDATED_DATE);
                    return query;
                }
                else
                {
                    query.OrderByDescending(o => o.UPDATED_DATE);
                    return query;
                }

            }
            catch
            {
                throw;
            }
        }


        public Response GetVisitorTransactionByNo_Api(int no)
        {
            Response resp = new Response();
            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    DateTime today = DateTime.Today;
                    DateTime endOfMonth = new DateTime(today.Year, today.Month, 1).AddMonths(1).AddDays(-1);

                    var startMonth = DateTime.Now.Month;
                    var year = DateTime.Now.Year;
                    var endMonth = DateTime.Now.Month;
                    if (today == endOfMonth)
                    {
                        endMonth = endMonth - 1;

                    }
                    var startDate = DateTime.Now.AddDays(-1.5);
                    var endDate = DateTime.Now.AddDays(1.5);


                    var listData = ctx.TRN_VISITOR
                                    .Include("MAS_PROVINCE")
                                    .Include("TRN_ATTACHEDMENT")
                                    .Where(o => o.NO == no)
                                    .Where(o => (o.CREATED_DATE >= startDate && o.CREATED_DATE <= endDate) && o.YEAR == year)
                                    .OrderByDescending(o => o.AUTO_ID)
                                    .ToList();
                    if (listData.Count > 0)
                    {
                        var reTrnVisitor = listData.FirstOrDefault();
                        if (reTrnVisitor.TRN_ATTACHEDMENT.Count > 0)
                        {
                            var existAttachment = reTrnVisitor.TRN_ATTACHEDMENT.FirstOrDefault();
                            if (existAttachment.REF_PHOTO1 != null || existAttachment.REF_PHOTO2 != null || existAttachment.REF_PHOTO3 != null)
                            {
                                resp.Status = false;
                                resp.Message = "หมายเลขนี้ได้ทำการถ่ายรูปแล้ว";
                            }
                            else
                            {
                                reTrnVisitor.MAS_CAR_TYPE = new MODEL.EntityModel.MAS_CAR_TYPE();
                                reTrnVisitor.MAS_EMPLOYEE = new MODEL.EntityModel.MAS_EMPLOYEE();
                                reTrnVisitor.MAS_PROVINCE = new MODEL.EntityModel.MAS_PROVINCE();
                                reTrnVisitor.MAS_REASON = new MODEL.EntityModel.MAS_REASON();
                                reTrnVisitor.TRN_ATTACHEDMENT = new List<MODEL.EntityModel.TRN_ATTACHEDMENT>();
                                resp.ResultObj = reTrnVisitor;
                                resp.Status = true;
                            }
                        }
                        else
                        {
                            reTrnVisitor.MAS_CAR_TYPE = new MODEL.EntityModel.MAS_CAR_TYPE();
                            reTrnVisitor.MAS_EMPLOYEE = new MODEL.EntityModel.MAS_EMPLOYEE();
                            reTrnVisitor.MAS_PROVINCE = new MODEL.EntityModel.MAS_PROVINCE();
                            reTrnVisitor.MAS_REASON = new MODEL.EntityModel.MAS_REASON();
                            reTrnVisitor.TRN_ATTACHEDMENT = new List<MODEL.EntityModel.TRN_ATTACHEDMENT>();
                            resp.ResultObj = reTrnVisitor;
                            resp.Status = true;
                        }


                    }
                    else
                    {
                        resp.Message = "ไม่พบข้อมููล";
                        resp.Status = false;
                    }

                }
            }
            catch (Exception ex)
            {
                resp.Status = false;
                resp.Message = ex.Message;
            }
            return resp;
        }

        public Response GetLastVisitorTransaction_Api()
        {
            Response resp = new Response();
            try
            {
                using (var ctx = new BIG_VMSEntities())
                {


                    var reTrnVisitor = ctx.TRN_VISITOR
                                    .Include("TRN_ATTACHEDMENT")
                                    .OrderByDescending(o => o.AUTO_ID)
                                    .FirstOrDefault();


                    if (reTrnVisitor != null)
                    {

                        if (reTrnVisitor.TRN_ATTACHEDMENT.Count > 0)
                        {
                            var existAttachment = reTrnVisitor.TRN_ATTACHEDMENT.FirstOrDefault();
                            if (existAttachment.REF_PHOTO1 != null || existAttachment.REF_PHOTO2 != null || existAttachment.REF_PHOTO3 != null)
                            {
                                resp.Status = false;
                                //resp.Message = "หมายเลขนี้ได้ทำการถ่ายรูปแล้ว";
                            }
                            else
                            {
                                reTrnVisitor.MAS_CAR_TYPE = new MODEL.EntityModel.MAS_CAR_TYPE();
                                reTrnVisitor.MAS_EMPLOYEE = new MODEL.EntityModel.MAS_EMPLOYEE();
                                reTrnVisitor.MAS_PROVINCE = new MODEL.EntityModel.MAS_PROVINCE();
                                reTrnVisitor.MAS_REASON = new MODEL.EntityModel.MAS_REASON();
                                reTrnVisitor.TRN_ATTACHEDMENT = new List<MODEL.EntityModel.TRN_ATTACHEDMENT>();
                                resp.ResultObj = reTrnVisitor;
                                resp.Status = true;
                            }
                        }
                        else
                        {
                            reTrnVisitor.MAS_CAR_TYPE = new MODEL.EntityModel.MAS_CAR_TYPE();
                            reTrnVisitor.MAS_EMPLOYEE = new MODEL.EntityModel.MAS_EMPLOYEE();
                            reTrnVisitor.MAS_PROVINCE = new MODEL.EntityModel.MAS_PROVINCE();
                            reTrnVisitor.MAS_REASON = new MODEL.EntityModel.MAS_REASON();
                            reTrnVisitor.TRN_ATTACHEDMENT = new List<MODEL.EntityModel.TRN_ATTACHEDMENT>();
                            resp.ResultObj = reTrnVisitor;
                            resp.Status = true;
                        }
                    }
                    else
                    {
                        //resp.Message = "ไม่พบข้อมููล";
                        resp.Status = false;
                    }

                }
            }
            catch (Exception ex)
            {
                resp.Status = false;
                resp.Message = ex.Message;
            }
            return resp;
        }

        public Response UpdateVisitorOutBy_Api(int no, int autoId, TRN_ATTACHEDMENT attachment)
        {
            Response resp = new Response();
            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var reTrnVisitor = ctx.TRN_VISITOR.Where(o => o.AUTO_ID == autoId).FirstOrDefault();
                    if (reTrnVisitor != null)
                    {

                        if (reTrnVisitor.TRN_ATTACHEDMENT.Count > 0)
                        {
                            reTrnVisitor.TRN_ATTACHEDMENT.First().REF_PHOTO1 = attachment.REF_PHOTO1;
                            reTrnVisitor.TRN_ATTACHEDMENT.First().REF_PHOTO2 = attachment.REF_PHOTO2;
                            reTrnVisitor.TRN_ATTACHEDMENT.First().REF_PHOTO3 = attachment.REF_PHOTO3;
                        }
                        else
                        {
                            TRN_ATTACHEDMENT attach = new TRN_ATTACHEDMENT()
                            {
                                REF_PHOTO1 = attachment.REF_PHOTO1,
                                REF_PHOTO2 = attachment.REF_PHOTO2,
                                REF_PHOTO3 = attachment.REF_PHOTO3,

                            };

                            reTrnVisitor.TRN_ATTACHEDMENT.Add(attach);
                        }

                        ctx.SaveChanges();
                        resp.Status = true;
                        resp.Message = "บันทึกข้อมูลเรียบร้อย";
                    }
                }
            }
            catch (Exception ex)
            {
                resp.Status = false;
                resp.Message = ex.Message;
            }

            return resp;
        }

        public Response UpdateVisitorImgRef_Api(int no, int autoId, string key, byte[] image)
        {
            Response resp = new Response();
            try
            {
                using (var ctx = new BIG_VMSEntities())
                {
                    var reTrnVisitor = ctx.TRN_VISITOR.Where(o => o.AUTO_ID == autoId).FirstOrDefault();
                    if (reTrnVisitor != null)
                    {

                        if (reTrnVisitor.TRN_ATTACHEDMENT.Count > 0)
                        {
                            switch (key)
                            {
                                case ("FILE#1"):
                                    {
                                        reTrnVisitor.TRN_ATTACHEDMENT.First().REF_PHOTO1 = image;
                                    }
                                    break;
                                case ("FILE#2"):
                                    {
                                        reTrnVisitor.TRN_ATTACHEDMENT.First().REF_PHOTO2 = image;
                                    }
                                    break;
                                case ("FILE#3"):
                                    {
                                        reTrnVisitor.TRN_ATTACHEDMENT.First().REF_PHOTO3 = image;
                                    }
                                    break;
                            }
                        }
                    }

                    ctx.SaveChanges();
                    resp.Status = true;

                }
            }
            catch (Exception ex)
            {
                resp.Exception = ex;
                resp.Status = false;
            }
            return resp;
        }

        public Response DownloadImage(ContainerDisplayVisitor obj)
        {
            Response resp = new Response();
            var ctx = new BIG_VMSEntities();
            var filter = obj.Filter;

            var query = ctx.TRN_ATTACHEDMENT.Include("TRN_VISITOR")
                .Where(o => (o.CREATED_DATE >= filter.DATE_FROM && o.CREATED_DATE <= filter.DATE_TO));


            try
            {

                var listData = query.ToList();
                resp.Status = true;
                resp.ResultObj = listData;
            }
            catch (Exception ex)
            {
                resp.Status = false;
                resp.Exception = ex;
            }
            return resp;
        }
    }
}
