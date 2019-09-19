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
        private ContainerProject _container = new ContainerProject();
        public frmProjectMasterList()
        {
            InitializeComponent();
        }

        private void FrmProjectMasterList_Load(object sender, EventArgs e)
        {
            InitialEventHandler();
            BindGridData();
            gridVisitorList.DataBindingComplete += BindingComplete;
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


        private void SetPageControl(ContainerProject obj)
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

            if (obj.PageInfo.PAGE >= obj.PageInfo.TOTAL_PAGE)
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

        private void InitialEventHandler()
        {

            btnNext.Click += new EventHandler(Pagination_EventHadler);
            btnLast.Click += new EventHandler(Pagination_EventHadler);
            btnFirst.Click += new EventHandler(Pagination_EventHadler);
            btnPrevious.Click += new EventHandler(Pagination_EventHadler);

        }

        private void BindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CustomGrid();
        }

        private void BindGridData()
        {
           
            var filter = new FilterProject()
            {
                PROJECT_NAME = txtProjectName.Text,
            };

            _container.Filter = filter;
            var response = service.GetListProject(_container);
            if (response.Status)
            {
                var result = response.ResultObj;
                _container.Filter = filter;
                SetDataSourceHeader(gridVisitorList, ListHeader(), result.ListData);
                SetPageControl(_container);
            }
            

        }


        private List<HeaderGrid> ListHeader()
        {
            List<HeaderGrid> listCol = new List<HeaderGrid>();
            listCol.Add(new HeaderGrid { HEADER_TEXT = "AUTO_ID", FIELD = "AUTO_ID", VISIBLE = false, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ชื่อโครงการ", FIELD = "PROJECT_NAME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ขอบเขตโครงการ", FIELD = "PROJECT_SCOPE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "พื้นที่การทำงาน", FIELD = "WORKING_AREA", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "หัวหน้าผูรับผิดชอบ", FIELD = "RESPONSIBLE_DEP_HEAD", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "วันที่เพิ่ม", FIELD = "REGISTER_DATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "เบอร์โทรผู้รับผิดชอบ", FIELD = "RESPONSIBLE_TEL", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
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

      

      
        private void GridVisitorList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {

                    if (e.ColumnIndex == 0) //In
                    {

                        var id = Convert.ToInt32(gridVisitorList.Rows[e.RowIndex].Cells["AUTO_ID"].Value);
                        var result = service.GetProjectbyProjectID(id);
                        if (result.Status)
                        {
                            frmConstractorEmpList frm = new frmConstractorEmpList();
                            frm._TRN_PROJECT_MASTER = result.ResultObj;
                            frm.ShowDialog();
                        }
                    }
                    if (e.ColumnIndex == 1)
                    {
                        #region ===================== edit =====================
                        var id = Convert.ToInt32(gridVisitorList.Rows[e.RowIndex].Cells["AUTO_ID"].Value);
                        var response = service.GetProjectbyProjectID(id);
                        if (response.Status)
                        {
                            var frm = new frmProjectMasters();
                            frm.formMode = FormMode.View;
                            frm._TRN_PROJECT_MASTER = (TRN_PROJECT_MASTER)response.ResultObj;
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                BindGridData();
                            }
                        }
                        #endregion
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        #region ===================== Edit =====================
                        var id = Convert.ToInt32(gridVisitorList.Rows[e.RowIndex].Cells["AUTO_ID"].Value);
                        var response = service.GetProjectbyProjectID(id);
                        if (response.Status)
                        {
                            var frm = new frmProjectMasters();
                            frm.formMode = FormMode.Edit;
                            frm._TRN_PROJECT_MASTER = (TRN_PROJECT_MASTER)response.ResultObj;
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                BindGridData();
                            }
                        }
                        #endregion
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        #region ===================== delete =====================
                        var id = Convert.ToInt32(gridVisitorList.Rows[e.RowIndex].Cells["AUTO_ID"].Value);
                        if (MessageBox.Show("ต้องการลบข้อมูลใช่หรือไม่ ?", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var resp = service.DeleteProject(id);
                            if (resp.Status)
                            {
                                MessageBox.Show(Message.MSG_DELETE_COMPLETE, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BindGridData();
                            }
                            else
                            {
                                MessageBox.Show(resp.Message + resp.ExceptionMessage);
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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
