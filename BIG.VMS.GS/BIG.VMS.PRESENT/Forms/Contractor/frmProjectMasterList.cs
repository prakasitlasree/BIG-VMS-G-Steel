using BIG.VMS.DATASERVICE;
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.EntityModel;
using BIG.VMS.MODEL.GsteelModel.ContainerModel;
using BIG.VMS.MODEL.GsteelModel.FilterModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIG.VMS.PRESENT.Forms.Contractor
{
    public partial class frmProjectMasterList : PageBase
    {
        private ProjectServices service = new ProjectServices();
        public frmProjectMasterList()
        {
            InitializeComponent();
        }

        private void FrmProjectMasterList_Load(object sender, EventArgs e)
        {
            BindGridData();
            CustomGrid();

        }

        private void BindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CustomGrid();
        }

        private void BindGridData()
        {
            var container = new ContainerProject();
            var filter = new FilterProject()
            {

                PROJECT_NAME = txtName.Text,


            };

            container.Filter = filter;
            var response = service.GetListProject(container);
            if (response.Status)
            {

                var containerData = (ContainerProject)response.ResultObj;
                SetDataSourceHeader(gridVisitorList, ListHeader(), containerData.ListData);
                gridVisitorList.DataBindingComplete += BindingComplete;
            }
            else
            {

            }

        }


        private List<HeaderGrid> ListHeader()
        {
            List<HeaderGrid> listCol = new List<HeaderGrid>();
            listCol.Add(new HeaderGrid { HEADER_TEXT = "AUTO_ID", FIELD = "AUTO_ID", VISIBLE = false, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "วันที่เพิ่ม", FIELD = "REGISTER_DATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "เบอร์โทรผู้รับผิดชอบ", FIELD = "RESPONSIBLE_TEL", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ชื่อโรคงการ", FIELD = "PROJECT_NAME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ขอบเขตโครงการ", FIELD = "PROJECT_SCOPE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "พื้นที่การทำงาน", FIELD = "WORKING_AREA", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "หัวหน้าผูรับผิดชอบ", FIELD = "RESPONSIBLE_DEP_HEAD", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "วันทำงาน", FIELD = "WORKING_DAY", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "วันที่เริ่ม", FIELD = "PROJECT_START_DATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "วันที่สิ้นสุด", FIELD = "PROJECT_END_DATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "เวลาทำงาน", FIELD = "PROJECT_WORKING_TIME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ฝ่ายจัดซื้อรับรองโดย", FIELD = "PURCHASING_VERIFY_BY", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "วันทำงาน", FIELD = "WORKING_DAY", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "วันที่ฝ่ายจัดซื้อรับรอง", FIELD = "PURCHASING_VERIFY_DATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "การรองรับการอบรม", FIELD = "SAFETY_TRAINING_REQUIRE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "วันที่รับรอง", FIELD = "SAFETY_TRAINING_ISSUED_DATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "วันหมดอายุการรับรอง", FIELD = "SAFETY_TRAINING_EXPIRED_DATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ผู้รับรองฝ่ายความปลอดภัย", FIELD = "SAFETY_MANAGER_APP_BY", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ID_BADGE_TYPE", FIELD = "ID_BADGE_TYPE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ID_BADGE_ISSUED_DATE", FIELD = "ID_BADGE_ISSUED_DATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ID_BADGE_EXPIRED_DATE", FIELD = "ID_BADGE_EXPIRED_DATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "HRA_MANAGER_APP_BY", FIELD = "HRA_MANAGER_APP_BY", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });


            return listCol;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            BindGridData();
            CustomGrid();
        }


        private void CustomGrid()
        {
            gridVisitorList.RowTemplate.Height = 30;
            for (int i = 0; i < gridVisitorList.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    gridVisitorList.Rows[i].DefaultCellStyle.BackColor = Color.SeaShell;
                }
                else
                {
                    gridVisitorList.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

            }
            foreach (DataGridViewRow row in gridVisitorList.Rows)
            {

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmProjectMasters();
            frm.formMode = FormMode.Add;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindGridData();
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
                        var response = service.GetProjectbyProjectID(id);
                        if (response.Status)
                        {
                            var frm = new frmProjectMasters();
                            frm.formMode = FormMode.Edit;
                            frm.MAS_CONTRACTOR = (MAS_CONTRACTOR)response.ResultObj;
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                BindGridData();
                            }
                        }
                        #endregion
                    }
                    else if (e.ColumnIndex == 1)
                    {
                        #region ===================== delete =====================

                        #endregion
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        {
                            #region ===================== delete =====================

                            #endregion
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
