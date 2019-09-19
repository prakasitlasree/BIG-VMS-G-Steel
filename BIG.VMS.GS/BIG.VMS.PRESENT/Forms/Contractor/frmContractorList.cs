using BIG.VMS.DATASERVICE;
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.MODEL.CustomModel.Container;
using BIG.VMS.MODEL.CustomModel.Filter;
using BIG.VMS.MODEL.EntityModel;
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
    public partial class frmContractorList : Form
    {

        private ContainerContractor _container = new ContainerContractor();
        private readonly ContratorServices _service = new ContratorServices();
        public frmContractorList()
        {
            InitializeComponent();
        }


        private void frmContractorList_Load(object sender, EventArgs e)
        {
            InitialEventHandler();
            ResetScreen();
            gridContractorList.DataBindingComplete += BindingComplete;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmContractor();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ResetScreen();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ResetScreen();
        }

        #region method
        private void InitialEventHandler()
        {

            btnNext.Click += new EventHandler(Pagination_EventHadler);
            btnLast.Click += new EventHandler(Pagination_EventHadler);
            btnFirst.Click += new EventHandler(Pagination_EventHadler);
            btnPrevious.Click += new EventHandler(Pagination_EventHadler);


        }

        private void ResetScreen()
        {
            _container.PageInfo = new Pagination();
            BindGridData();
            CustomGrid();
        }

        private void BindGridData()
        {
            var filter = new ContractorFilter()
            {

                NAME = txtName.Text,
                ADDRESS = txtAddress.Text,
                TEL = txtTel.Text

            };


            _container.Filter = filter;
            _container = _service.GetListConstractor(_container).ResultObj;
            SetDataSourceHeader(gridContractorList, ListHeader(), _container.ResultObj);
            SetPageControl(_container);

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

        private void BindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CustomGrid();
        }

        private void CustomGrid()
        {
            gridContractorList.RowTemplate.Height = 30;
            for (int i = 0; i < gridContractorList.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    gridContractorList.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                }
                else
                {
                    gridContractorList.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }

            gridContractorList.Columns[0].DefaultCellStyle.ForeColor = Color.White;
        }

        private List<HeaderGrid> ListHeader()
        {
            List<HeaderGrid> listCol = new List<HeaderGrid>();

            listCol.Add(new HeaderGrid { HEADER_TEXT = "ID", FIELD = "AUTO_ID", VISIBLE = false, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ชื่อบริษัทผู้รับเหมา", FIELD = "NAME", VISIBLE = true, ALIGN = align.Center, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "เบอร์โทร", FIELD = "TEL", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ที่อยู่", FIELD = "ADDRESS", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "วันที่บันทึก", FIELD = "UPDATED_DATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ผู้บันทึก", FIELD = "UPDATED_BY", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });


            return listCol;
        }

        public void SetDataSourceHeader(DataGridView control, List<HeaderGrid> list_header, dynamic data)
        {
            if (data != null)
            {
                DataTable dt = ConvertToDataTable(data);
                control.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //control.DataSource = dt;
                List<string> columnNames = dt.Columns.Cast<DataColumn>()
                                 .Select(x => x.ColumnName)
                                 .ToList();

                int columnIndex = 0;


                foreach (var item in list_header)
                {
                    if (dt.Columns.Contains(item.FIELD))
                    {
                        dt.Columns[item.FIELD].SetOrdinal(columnIndex);
                        columnIndex++;
                    }
                }

                control.DataSource = dt;

                foreach (var item in columnNames)
                {
                    control.Columns[item].Visible = false;
                }
                foreach (var item in list_header)
                {
                    if (control.Columns.Contains(item.FIELD))
                    {
                        control.Columns[item.FIELD].HeaderText = item.HEADER_TEXT;
                        control.Columns[item.FIELD].Visible = item.VISIBLE;
                        control.Columns[item.FIELD].DefaultCellStyle.Alignment = item.ALIGN == align.Center ? DataGridViewContentAlignment.MiddleCenter : (item.ALIGN == align.Left ? DataGridViewContentAlignment.MiddleLeft : (item.ALIGN == align.Right ? DataGridViewContentAlignment.BottomRight : DataGridViewContentAlignment.MiddleLeft));
                        control.Columns[item.FIELD].AutoSizeMode = item.AUTO_SIZE == autoSize.CellContent ? DataGridViewAutoSizeColumnMode.AllCells : (item.AUTO_SIZE == autoSize.Fill ? DataGridViewAutoSizeColumnMode.Fill : DataGridViewAutoSizeColumnMode.AllCells);

                    }
                }
            }
        }

        private void SetPageControl(ContainerContractor obj)
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

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)

                    try
                    {
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                    }
                    catch
                    {

                    }

                table.Rows.Add(row);
            }
            return table;

        }

        #endregion

        private void gridContractorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
               
                if (e.ColumnIndex == 0) //Edit
                {

                    var id = Convert.ToInt32(gridContractorList.Rows[e.RowIndex].Cells["AUTO_ID"].Value);
                    MAS_CONTRACTOR con = new MAS_CONTRACTOR();

                    var result = _service.GetContractor(id);
                    con.AUTO_ID = result.AUTO_ID;
                    con.NAME = result.NAME;
                    con.ADDRESS = result.ADDRESS;
                    con.TEL = result.TEL;
                    con.UPDATED_BY = result.UPDATED_BY;
                    con.UPDATED_DATE = result.UPDATED_DATE;

                    frmContractor frm = new frmContractor();
                    frm.MAS_CONTRACTOR = con;
                    frm.formMode = FormMode.Edit;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ResetScreen();
                    }
                }
                if (e.ColumnIndex == 1) //Delete
                {
                    if (MessageBox.Show("ต้องการ ลบ!!!ข้อมูลใช่หรือไม่ ?", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var id = Convert.ToInt32(gridContractorList.Rows[e.RowIndex].Cells["AUTO_ID"].Value);

                        var resp = _service.DeleteContractor(id);
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
