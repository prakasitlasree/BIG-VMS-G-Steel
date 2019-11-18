using BIG.VMS.DATASERVICE;
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.CustomModel.Container;
using BIG.VMS.MODEL.CustomModel.Filter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIG.VMS.PRESENT.Forms.Employee
{
    public partial class frmEmployeeList : PageBase
    {
        private readonly EmployeeServices _service = new EmployeeServices();
        private ContainerEmployee _container = new ContainerEmployee();
        private ComboBoxServices _comboService = new ComboBoxServices();

        public frmEmployeeList()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.formMode = FormMode.Add;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ResetScreen();
            }
        }


        private void FrmEmployeeList_Load(object sender, EventArgs e)
        {
            InitialEventHandler();
            ResetScreen();
            comboDept.DataSource = _comboService.GetComboDepartment(true);
            comboDept.DisplayMember = "Text";
            comboDept.ValueMember = "Value";
            gridEmployee.DataBindingComplete += BindingComplete;
        }

        private void BindGridData()
        {
            var filter = new FilterEmployee()
            {

                FIRST_NAME = txtName.Text,
                LAST_NAME = txtLastName.Text,
                DEPARTMENT_ID = Convert.ToInt32(comboDept.SelectedValue),
            };

            _container.Filter = filter;
            _container = _service.GetItem(_container);
            SetDataSourceHeader(gridEmployee, ListHeader(), _container.ResultObj);
            SetPageControl(_container);

        }

        private List<HeaderGrid> ListHeader()
        {
            List<HeaderGrid> listCol = new List<HeaderGrid>();
            listCol.Add(new HeaderGrid { HEADER_TEXT = "AUTO_ID", FIELD = "AUTO_ID", VISIBLE = false, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ชื่อ", FIELD = "FIRST_NAME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "นามสกุล", FIELD = "LAST_NAME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });


            listCol.Add(new HeaderGrid { HEADER_TEXT = "แผนก", FIELD = "DEPARTMENT", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ประเภท", FIELD = "SHOW_SEQ", VISIBLE = false, ALIGN = align.Center, AUTO_SIZE = autoSize.CellContent });

            //listCol.Add(new HeaderGrid { HEADER_TEXT = "วันที่แก้ไข", FIELD = "UPDATED_DATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            //listCol.Add(new HeaderGrid { HEADER_TEXT = "ผู้แก้ไข", FIELD = "UPDATED_BY", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            return listCol;
        }

        private void SetPageControl(ContainerEmployee obj)
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

        private void ResetScreen()
        {
            _container.PageInfo = new Pagination();
            BindGridData();
            CustomGrid();



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


        private void CustomGrid()
        {
            gridEmployee.RowTemplate.Height = 30;
            for (int i = 0; i < gridEmployee.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    gridEmployee.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                }
                else
                {
                    gridEmployee.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ResetScreen();
        }

        private void GridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                if (e.ColumnIndex == 0) //Edit
                {

                    var id = Convert.ToInt32(gridEmployee.Rows[e.RowIndex].Cells["AUTO_ID"].Value);

                    frmEmployee frm = new frmEmployee();
                    frm.employee_id = id;
                    frm.formMode = FormMode.View;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ResetScreen();
                    }
                }
                if (e.ColumnIndex == 1) //Edit
                {

                    var id = Convert.ToInt32(gridEmployee.Rows[e.RowIndex].Cells["AUTO_ID"].Value);

                    frmEmployee frm = new frmEmployee();
                    frm.employee_id = id;
                    frm.formMode = FormMode.Edit;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ResetScreen();
                    }
                }
                if (e.ColumnIndex == 2) //Delete
                {
                    if (MessageBox.Show("ต้องการ ลบ!!!ข้อมูลใช่หรือไม่ ?", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var id = Convert.ToInt32(gridEmployee.Rows[e.RowIndex].Cells["AUTO_ID"].Value);

                        var resp = _service.DeleteEmployee(id);
                        if (resp.Status)
                        {
                            MessageBox.Show(Message.MSG_SAVE_COMPLETE, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            ResetScreen();
                        }
                        else
                        {
                            MessageBox.Show(resp.Message);
                        }
                    }

                }
            }
        }
    }
}
