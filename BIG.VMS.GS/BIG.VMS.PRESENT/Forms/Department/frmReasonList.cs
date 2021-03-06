﻿using BIG.VMS.DATASERVICE;
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

namespace BIG.VMS.PRESENT.Forms.Department
{
    public partial class frmReasonList : PageBase
    {
        private readonly ReasonServices _service = new ReasonServices();
        private ContainerReason _container = new ContainerReason();
        private ComboBoxServices _comboService = new ComboBoxServices();
        public int dept_id = 0;
        public frmReasonList()
        {
            InitializeComponent();
        }



        private void gridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                if (e.ColumnIndex == 0) //Edit
                {

                    var id = Convert.ToInt32(gridEmployee.Rows[e.RowIndex].Cells["AUTO_ID"].Value);

                    frmReason frm = new frmReason();
                    frm.reason_id = id;
                    frm.formMode = FormMode.View;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ResetScreen();
                    }
                }
                if (e.ColumnIndex == 1) //Edit
                {

                    var id = Convert.ToInt32(gridEmployee.Rows[e.RowIndex].Cells["AUTO_ID"].Value);

                    frmReason frm = new frmReason();
                    frm.reason_id = id;
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

                        var resp = _service.DeleteReason(id);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ResetScreen();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmReason frm = new frmReason();
            frm.formMode = FormMode.Add;
            frm.dept_id = dept_id;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ResetScreen();
            }
        }

        private void BindGridData()
        {
            var filter = new FilterReason()
            {

                REASON = txtReason.Text,
                DEPT_ID = dept_id

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
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ชื่อ", FIELD = "REASON", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.Fill });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ลำดับ", FIELD = "SHOW_SEQ", VISIBLE = true, ALIGN = align.Center, AUTO_SIZE = autoSize.CellContent });

            //listCol.Add(new HeaderGrid { HEADER_TEXT = "วันที่แก้ไข", FIELD = "UPDATED_DATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            //listCol.Add(new HeaderGrid { HEADER_TEXT = "ผู้แก้ไข", FIELD = "UPDATED_BY", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            return listCol;
        }

        private void SetPageControl(ContainerReason obj)
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

        private void frmReasonList_Load(object sender, EventArgs e)
        {
            InitialEventHandler();
            ResetScreen();
            gridEmployee.DataBindingComplete += BindingComplete;
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

        private void ResetScreen()
        {
            _container.PageInfo = new Pagination();
            BindGridData();
            CustomGrid();

        }
    }
}
