using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIG.VMS.DATASERVICE;
using BIG.VMS.MODEL.CustomModel;
using ClosedXML.Excel;
using CrystalDecisions.CrystalReports.Engine;

namespace BIG.VMS.PRESENT.Forms.FormReportNew
{
    public partial class frmReport : PageBase
    {
        private bool _flgAll = false;
        private DataTable _dt = new DataTable();

        private readonly ReportServices _services = new ReportServices();
        public frmReport()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (radAll.Checked)
            {
                _flgAll = true;
                var group = string.Empty;
                if (radAllGroup.Checked)
                {
                    group = "ALL";
                }
                else if (radAppoint.Checked)
                {
                    group = nameof(VisitorGroup.APPOINTMENT);
                }
                else if (radConstructor.Checked)
                {
                    group = nameof(VisitorGroup.CONSTRUCTOR);
                }
                else if (radCustomer.Checked)
                {
                    group = nameof(VisitorGroup.CUSTOMER);
                }
                else if (radNormal.Checked)
                {
                    group = nameof(VisitorGroup.NORMAL);
                }
                var resp = _services.GetReportVisitorTypeAll(group, dtFrom.Value, dtTo.Value);
                if (resp.Status)
                {
                    _dt = ConvertToDataTable(resp.ResultObj);
                    SetDataSourceHeader(gridReport, ListHeaderAll(), resp.ResultObj);
                    customGrid();
                    gridReport.DataBindingComplete += BindingComplete;
                }
            }
            else
            {
                _flgAll = false;
                var group = string.Empty;
                var type = string.Empty;
                if (radAllGroup.Checked) group = "ALL";
                else if (radAppoint.Checked) group = nameof(VisitorGroup.APPOINTMENT);
                else if (radConstructor.Checked) group = nameof(VisitorGroup.CONSTRUCTOR);
                else if (radCustomer.Checked) group = nameof(VisitorGroup.CUSTOMER);
                else if (radNormal.Checked) group = nameof(VisitorGroup.NORMAL);

                if (radIn.Checked) type = "IN";
                if (radOut.Checked) type = "OUT";

                var resp = _services.GetReportVisitor(group, type, dtFrom.Value, dtTo.Value);
                if (resp.Status)
                {
                    _dt = ConvertToDataTable(resp.ResultObj);
                    SetDataSourceHeader(gridReport, ListHeader(), resp.ResultObj);
                    customGrid();
                    gridReport.DataBindingComplete += BindingComplete;
                }
            }

        }

        private List<HeaderGrid> ListHeader()
        {
            List<HeaderGrid> listCol = new List<HeaderGrid>();
            listCol.Add(new HeaderGrid { HEADER_TEXT = "เลขที่", FIELD = "NO", VISIBLE = true, ALIGN = align.Center, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "เวลา", FIELD = "TIME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "กลุ่ม", FIELD = "GROUP", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ประเภท", FIELD = "TYPE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "บัตรประชาชน", FIELD = "ID_CARD", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ชื่อ-นามสกุล", FIELD = "FULL_NAME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "รถ", FIELD = "CAR_INFO", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "เข้าพบ", FIELD = "EMP_NAME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "วัตถุประสงค์", FIELD = "REASON_TEXT", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "บันทึกโดย", FIELD = "CREATED_BY", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            return listCol;
        }

        private List<HeaderGrid> ListHeaderAll()
        {
            List<HeaderGrid> listCol = new List<HeaderGrid>();
            listCol.Add(new HeaderGrid { HEADER_TEXT = "เลขที่", FIELD = "NO", VISIBLE = true, ALIGN = align.Center, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "เวลาเข้า", FIELD = "TIME_IN", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "เวลาออก", FIELD = "TIME_OUT", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "บัตรประชาชน", FIELD = "ID_CARD", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ชื่อ-นามสกุล", FIELD = "FULL_NAME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "รถ", FIELD = "CAR_INFO", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "เข้าพบ", FIELD = "EMP_NAME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "วัตถุประสงค์", FIELD = "REASON_TEXT", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "บันทึกโดย", FIELD = "CREATED_BY", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            return listCol;
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            _flgAll = true;
            var resp = _services.GetReportVisitorTypeAll("ALL", dtFrom.Value, dtTo.Value);
            if (resp.Status)
            {
                _dt = ConvertToDataTable(resp.ResultObj);
                SetDataSourceHeader(gridReport, ListHeaderAll(), resp.ResultObj);
                customGrid();
                gridReport.DataBindingComplete += BindingComplete;
            }
        }

        private void customGrid()
        {
            gridReport.RowTemplate.Height = 30;
            for (int i = 0; i < gridReport.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    gridReport.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                }
                else
                {
                    gridReport.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

            }
        }

        private void BindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridReport.RowTemplate.Height = 30;
            for (int i = 0; i < gridReport.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    gridReport.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                }
                else
                {
                    gridReport.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

            }

        }

        private void BtnPrintReport_Click(object sender, EventArgs e)
        {
            if (_flgAll)
            {
                ReportDocument rpt = new ReportDocument();
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                var appPath = Application.StartupPath + "\\" + "ReportVisitorListAll.rpt";
                rpt.Load(appPath);
                //var k = rpt.Database.Tables[0];
                rpt.SetDataSource(_dt);
                rpt.PrintToPrinter(1, true, 0, 0);
            }
            else
            {
                ReportDocument rpt = new ReportDocument();
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                var appPath = Application.StartupPath + "\\" + "ReportVisitorListNotAll.rpt";
                rpt.Load(appPath);
                //var k = rpt.Database.Tables[0];
                rpt.SetDataSource(_dt);
                rpt.PrintToPrinter(1, true, 0, 0);
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var appPath = Application.StartupPath + "\\Excel\\";
            System.IO.Directory.CreateDirectory(appPath);
            XLWorkbook wb = new XLWorkbook();
            DataTable data = (DataTable)(gridReport.DataSource);
            wb.Worksheets.Add(data, "ExportData");
            var date = DateTime.Now.Day.ToString()+DateTime.Now.Month+DateTime.Now.Year+ DateTime.Now.Hour +DateTime.Now.Minute;
            wb.SaveAs(appPath + "ExportExcel" + date + ".xlsx");
            MessageBox.Show("บันทึก Excel ที่ " + appPath + " เรียบร้อย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
