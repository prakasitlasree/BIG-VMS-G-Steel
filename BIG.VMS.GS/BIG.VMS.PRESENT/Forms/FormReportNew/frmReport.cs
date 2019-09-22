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

namespace BIG.VMS.PRESENT.Forms.FormReportNew
{
    public partial class frmReport : PageBase
    {

        private readonly ReportServices _services = new ReportServices();
        public frmReport()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (radAll.Checked)
            {
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
                    SetDataSourceHeader(gridReport, ListHeaderAll(), resp.ResultObj);
                    customGrid();
                    gridReport.DataBindingComplete += BindingComplete;
                }
            }
            else
            {
                var group = string.Empty;
                var type = string.Empty;
                if (radAllGroup.Checked) group = "ALL";
                else if (radAppoint.Checked) group = nameof(VisitorGroup.APPOINTMENT);
                else if (radConstructor.Checked) group = nameof(VisitorGroup.CONSTRUCTOR);
                else if (radCustomer.Checked) group = nameof(VisitorGroup.CUSTOMER);
                else if (radNormal.Checked) group = nameof(VisitorGroup.NORMAL);

                if (radIn.Checked) type = "IN";
                if (radOut.Checked) type = "OUT";

                var resp = _services.GetReportVisitor(group,type, dtFrom.Value, dtTo.Value);
                if (resp.Status)
                {
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
    }
}
