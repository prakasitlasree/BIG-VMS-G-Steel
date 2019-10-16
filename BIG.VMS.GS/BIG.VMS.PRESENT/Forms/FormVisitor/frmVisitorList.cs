using BIG.VMS.DATASERVICE;
using BIG.VMS.MODEL;
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.CustomModel.CustomContainer;
using BIG.VMS.MODEL.EntityModel;
using BIG.VMS.PRESENT.Forms.FormReport;
using BIG.VMS.PRESENT.Forms.FormVisitor;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIG.VMS.MODEL.CustomModel.Container;
using BIG.VMS.MODEL.CustomModel.General;
using BIG.VMS.MODEL.GsteelModel.CustomModel;
using BIG.VMS.PRESENT.Forms.FormReportNew;
using BIG.VMS.PRESENT.Forms.FormVisitorNew;

namespace BIG.VMS.PRESENT.Forms.Home
{
    public partial class frmVisitorList : PageBase
    {
        private readonly VisitorServices _service = new VisitorServices();
        private ContainerDisplayVisitor _container = new ContainerDisplayVisitor();
        private ComboBoxServices _comboService = new ComboBoxServices();

        public frmVisitorList()
        {
            InitializeComponent();
        }

        private void frmAllvisitor_Load(object sender, EventArgs e)
        {

            InitialControl();
            InitialEventHandler();
            ResetScreen();
            gridVisitorList.DataBindingComplete += BindingComplete;

        }

        private void SetControl()
        {
            if (ROLE == "ธุรการ")
            {
                btnIn.Visible = false;
                btnOut.Visible = false;
                gridVisitorList.Columns[0].Visible = false;
                gridVisitorList.Columns[1].Visible = false;
                gridVisitorList.Columns[2].Visible = false;
            }

        }

        private void BindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CustomGrid();
        }

        private void BindGridData()
        {
            var filter = new VisitorFilter()
            {

                ID_CARD = txtIDCard.Text,
                LICENSE_PLATE = txtLicense.Text,
                NO = txtNo.Text == "" ? 0 : Convert.ToInt32(txtNo.Text),
                FIRST_NAME = txtName.Text,
                LAST_NAME = txtLastName.Text,
                DATE_FROM = dtFrom.Value.Date,
                DATE_TO = dtTo.Value.Date,

            };

            switch (comboType.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    filter.TYPE = "IN";
                    break;
                case 2:
                    filter.TYPE = "OUT";
                    break;
            }

            switch (comboGroup.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    filter.GROUP = nameof(VisitorGroup.NORMAL);
                    break;
                case 2:
                    filter.GROUP = nameof(VisitorGroup.APPOINTMENT);
                    break;
                case 3:
                    filter.GROUP = nameof(VisitorGroup.CONSTRUCTOR);
                    break;
                case 4:
                    filter.GROUP = nameof(VisitorGroup.CUSTOMER);
                    break;
            }




            _container.Filter = filter;
            _container = _service.GetContainerDisplayVisitor(_container);
            SetDataSourceHeader(gridVisitorList, ListHeader(), _container.ResultObj);
            SetPageControl(_container);

        }

        private void CustomGrid()
        {
            gridVisitorList.RowTemplate.Height = 30;
            for (int i = 0; i < gridVisitorList.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    gridVisitorList.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                }
                else
                {
                    gridVisitorList.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

            }
            foreach (DataGridViewRow row in gridVisitorList.Rows)
            {
                if (row.Cells["TYPE"].Value.ToString() == "ออก")
                {
                    row.Cells[2].Value = Properties.Resources.transparent;
                }
                if (row.Cells["BLACKLIST"].Value.ToString() == "Y")
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ResetScreen();
        }

        private void ResetScreen()
        {
            _container.PageInfo = new Pagination();
            BindGridData();
            CustomGrid();
            SetControl();

            TransactionModel obj = _service.GetVisitorTransaction();
            lblAllCount.Text = obj.ALL_VISITOR_IN.ToString();
            lblTodayIn.Text = obj.TODAY_VISITOR_IN.ToString();
            lblTodayOut.Text = obj.TODAY_VISITOR_OUT.ToString();
        }

        private List<HeaderGrid> ListHeader()
        {
            List<HeaderGrid> listCol = new List<HeaderGrid>();
            listCol.Add(new HeaderGrid { HEADER_TEXT = "AUTO_ID", FIELD = "AUTO_ID", VISIBLE = false, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "BY_PASS", FIELD = "BY_PASS", VISIBLE = false, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "BLACKLIST", FIELD = "BLACKLIST", VISIBLE = false, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });


            listCol.Add(new HeaderGrid { HEADER_TEXT = "เลขที่", FIELD = "NO", VISIBLE = true, ALIGN = align.Center, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ประเภท", FIELD = "TYPE", VISIBLE = true, ALIGN = align.Center, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "กลุ่ม", FIELD = "GROUP", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ชื่อ-สกุล", FIELD = "FULL_NAME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "บัตรประชาชน", FIELD = "ID_CARD", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ประเภทรถ", FIELD = "CAR_TYPE_NAME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ทะเบียนรถ", FIELD = "LICENSE_PLATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "บุคคลที่ต้องการพบ", FIELD = "CONTACT_EMP_NAME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "แผนก", FIELD = "DEPT_NAME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "วัตถุประสงค์", FIELD = "REASON_TEXT", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });

            listCol.Add(new HeaderGrid { HEADER_TEXT = "วันที่บันทึก", FIELD = "CREATED_DATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ผู้บันทึก", FIELD = "CREATED_BY", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "วันที่แก้ไข", FIELD = "UPDATED_DATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ผู้แก้ไข", FIELD = "UPDATED_BY", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            return listCol;
        }

        private void InitialControl()
        {


            comboGroup.SelectedIndex = 0;
            comboType.SelectedIndex = 0;
            DateTime date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            dtFrom.Value = firstDayOfMonth;
            //dtTo.MaxDate = DateTime.Now.AddDays(-1);
            dtFrom.MaxDate = DateTime.Now.AddDays(-1); ;
        }

        private void InitialEventHandler()
        {

            btnNext.Click += new EventHandler(Pagination_EventHadler);
            btnLast.Click += new EventHandler(Pagination_EventHadler);
            btnFirst.Click += new EventHandler(Pagination_EventHadler);
            btnPrevious.Click += new EventHandler(Pagination_EventHadler);


        }

        private void SetPageControl(ContainerDisplayVisitor obj)
        {
            if (obj.PageInfo == null)
            {
                obj.PageInfo = new Pagination();
            }

            if (obj.PageInfo.PAGE == 1)
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
            }

            if (obj.PageInfo.PAGE == obj.PageInfo.TOTAL_PAGE)
            {
                btnLast.Enabled = false;
                btnNext.Enabled = false;
            }
            else
            {
                btnLast.Enabled = true;
                btnNext.Enabled = true;
            }

            txtPage.Text = "หน้า : " + obj.PageInfo.PAGE.ToString() + "/" + obj.PageInfo.TOTAL_PAGE.ToString();
        }

        private void Pagination_EventHadler(object sender, EventArgs e)
        {
            string controlName = ((Control)sender).Name.ToString();

            switch (controlName)
            {
                case "btnNext":
                    {
                        _container.PageInfo.PAGE += 1;
                        BindGridData();
                    }
                    break;
                case "btnPrevious":
                    {
                        _container.PageInfo.PAGE -= 1;
                        BindGridData();
                    }
                    break;
                case "btnFirst":
                    {
                        _container.PageInfo.PAGE = 1;
                        BindGridData();
                    }
                    break;
                case "btnLast":
                    {
                        _container.PageInfo.PAGE = _container.PageInfo.TOTAL_PAGE;
                        BindGridData();
                    }
                    break;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //frmSelectInType frm = new frmSelectInType();
            frmSelectVisitor frm = new frmSelectVisitor();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            ResetScreen();


        }

        private void btnOut_Click(object sender, EventArgs e)
        {

            frmVisitorOut frm = new frmVisitorOut();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ResetScreen();
            }
        }



        private void btnAhead_Click(object sender, EventArgs e)
        {
            frmAppointmentList frm = new frmAppointmentList(); 
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ResetScreen();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.StartPosition = FormStartPosition.CenterParent;
            //frm.WindowState = FormWindowState.Maximized;
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void gridVisitorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    if (e.ColumnIndex == 0)
                    {
                        #region ===================== edit =====================
                        var id = Convert.ToInt32(gridVisitorList.Rows[e.RowIndex].Cells["AUTO_ID"].Value);
                        var obj = (TRN_VISITOR)_service.GetVisitorByAutoId(id).TRN_VISITOR;

                        frmVisitorNew frm = new frmVisitorNew();
                        frm.TrnVisitor = obj;
                        frm.formMode = FormMode.Edit;
                        switch (obj.GROUP)
                        {
                            case (nameof(VisitorGroup.NORMAL)):
                                { frm.VISITOR_GROUP = VisitorGroup.NORMAL; }
                                break;
                            case (nameof(VisitorGroup.APPOINTMENT)):
                                { frm.VISITOR_GROUP = VisitorGroup.APPOINTMENT; }
                                break;
                            case (nameof(VisitorGroup.CONSTRUCTOR)):
                                { frm.VISITOR_GROUP = VisitorGroup.CONSTRUCTOR; }
                                break;
                            case (nameof(VisitorGroup.CUSTOMER)):
                                { frm.VISITOR_GROUP = VisitorGroup.CUSTOMER; }
                                break;
                        }

                        switch (obj.TYPE)
                        {
                            case (nameof(VisitorType.IN)):
                                { frm.VISITOR_TYPE = VisitorType.IN; }
                                break;
                            case (nameof(VisitorType.OUT)):
                                { frm.VISITOR_TYPE = VisitorType.OUT; }
                                break;
                        }

                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            ResetScreen();
                        }

                        #endregion
                    }

                    else if (e.ColumnIndex == 1)
                    {
                        #region ===================== delete =====================
                        if (MessageBox.Show(Message.MSG_DELETE_CONFIRM, "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            var id = Convert.ToInt32(gridVisitorList.Rows[e.RowIndex].Cells["AUTO_ID"].Value);
                            ContainerVisitor obj = new ContainerVisitor
                            {
                                TRN_VISITOR = new TRN_VISITOR
                                {
                                    AUTO_ID = id
                                }
                            };
                            var res = _service.Delete(obj);
                            if (res.Status)
                            {
                                MessageBox.Show(Message.MSG_SAVE_COMPLETE, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResetScreen();
                            }
                            else
                            {
                                MessageBox.Show(res.ExceptionMessage, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        #endregion
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        #region ===================== print =====================
                        var id = Convert.ToInt32(gridVisitorList.Rows[e.RowIndex].Cells["AUTO_ID"].Value);
                        var visitor = (TRN_VISITOR)_service.GetVisitorByAutoId(id).TRN_VISITOR;
                        if (visitor != null)
                        {
                            if (MessageBox.Show("ต้องการพิมพ์ใบเสร็จอีกครั้งหรือไม่' ?", "แจ้งเตือน", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                if (visitor.GROUP == nameof(VisitorGroup.NORMAL) &&
                                    visitor.GROUP == nameof(VisitorGroup.APPOINTMENT))
                                {
                                    #region Normal && Appointment

                                    var obj = _service.GetVisitorReportById(id);

                                    if (obj.ResultObj.Count > 0)
                                    {
                                        List<CustomDisplayVisitor>
                                            listData = (List<CustomDisplayVisitor>)obj.ResultObj;
                                        DataTable dt = ConvertToDataTable(listData);
                                        ReportDocument rpt = new ReportDocument();
                                        string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                                        if (listData.FirstOrDefault()?.BY_PASS == "N" ||
                                            listData.FirstOrDefault()?.BY_PASS == null)
                                        {
                                            var appPath = Application.StartupPath + "\\" + "ReportSlip.rpt";
                                            rpt.Load(appPath);
                                            rpt.SetDataSource(dt);
                                            rpt.PrintToPrinter(1, true, 0, 0);
                                        }
                                        else
                                        {
                                            var appPath = Application.StartupPath + "\\" + "ReportSlipByPass.rpt";
                                            rpt.Load(appPath);
                                            rpt.SetDataSource(dt);
                                            rpt.PrintToPrinter(1, true, 0, 0);
                                        }

                                    }

                                    #endregion
                                }
                                else if (visitor.GROUP == nameof(VisitorGroup.CONSTRUCTOR))
                                {
                                    #region Constructor

                                    var response = _service.GetConstructorReport(id);
                                    if (response.Status)
                                    {
                                        Project projectObj = (Project)response.ResultObj;
                                        DataTable dtHeader = ConvertToDataTable(projectObj.LIST_PROJECT_HEADER);
                                        DataTable dtMember = ConvertToDataTable(projectObj.LIST_PROJECT_MEMBER);
                                        ReportDocument rpt = new ReportDocument();
                                        string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                                        var appPath = Application.StartupPath + "\\" + "ReportConstructor.rpt";
                                        rpt.Load(appPath);
                                        var k = rpt.Database.Tables[0];
                                        rpt.Database.Tables[0].SetDataSource(dtHeader);
                                        rpt.Database.Tables[1].SetDataSource(dtMember);
                                        rpt.PrintToPrinter(1, true, 0, 0);
                                    }

                                    #endregion

                                }
                                else
                                {
                                    #region Customer

                                    var response = _service.GetCustomerReport(id);
                                    if (response.Status)
                                    {
                                        CustomerReport CustomerObj = (CustomerReport)response.ResultObj;
                                        DataTable dtHeader = ConvertToDataTable(CustomerObj.LIST_CUSTOMER_HEADER);
                                        DataTable dtMember = ConvertToDataTable(CustomerObj.LIST_CUSTOMER);
                                        ReportDocument rpt = new ReportDocument();
                                        string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                                        var appPath = Application.StartupPath + "\\" + "ReportCustomer.rpt";
                                        rpt.Load(appPath);
                                        //var k = rpt.Database.Tables[0];
                                        rpt.Database.Tables[0].SetDataSource(dtHeader);
                                        rpt.Database.Tables[1].SetDataSource(dtMember);
                                        rpt.PrintToPrinter(1, true, 0, 0);
                                    }


                                    #endregion

                                }
                            }


                        }

                        #endregion
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBlacklist_Click(object sender, EventArgs e)
        {
            frmBlacklistList frm = new frmBlacklistList();
            frm.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnListExit_Click(object sender, EventArgs e)
        {
            frmVisitorOutList frm = new frmVisitorOutList();
            frm.ShowDialog();
        }



        private void DtFrom_ValueChanged(object sender, EventArgs e)
        {
            dtTo.MinDate = dtFrom.Value;
        }
    }
}
