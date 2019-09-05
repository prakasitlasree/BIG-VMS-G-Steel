using BIG.VMS.DATASERVICE;
using BIG.VMS.MODEL.CustomModel;
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
                gridVisitorList.DataSource = container.ListData;
                //SetDataSourceHeader(gridVisitorList, ListHeader(), _container.ResultObj);
            }
            else
            {

            }
            
        }


        private List<HeaderGrid> ListHeader()
        {
            List<HeaderGrid> listCol = new List<HeaderGrid>();
            listCol.Add(new HeaderGrid { HEADER_TEXT = "REGISTER_DATE", FIELD = "REGISTER_DATE", VISIBLE = false, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "รหัสบัตรประชาชน", FIELD = "ID_CARD", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "ชื่อ", FIELD = "FIRST_NAME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "นามสกุล", FIELD = "LAST_NAME", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "เหตุผล", FIELD = "REASON", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.Fill });
            listCol.Add(new HeaderGrid { HEADER_TEXT = "วันที่บันทึก", FIELD = "CREATED_DATE", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.CellContent });
            //listCol.Add(new HeaderGrid { HEADER_TEXT = "สถานะ", FIELD = "STATUS", VISIBLE = true, ALIGN = align.Left, AUTO_SIZE = autoSize.Fill });

            return listCol;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

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
    }
}
