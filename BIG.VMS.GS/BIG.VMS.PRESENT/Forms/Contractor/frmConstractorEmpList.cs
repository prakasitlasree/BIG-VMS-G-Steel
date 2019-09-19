using BIG.VMS.MODEL.EntityModel;
using BIG.VMS.PRESENT.Forms.FormVisitor;
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
    public partial class frmConstractorEmpList : Form
    {
        public TRN_PROJECT_MASTER _TRN_PROJECT_MASTER = new TRN_PROJECT_MASTER();

        public frmConstractorEmpList()
        {
            InitializeComponent();
        }

        private void FrmConstractorEmpList_Load(object sender, EventArgs e)
        {
            gridProjectMember.AutoGenerateColumns = false;
            gridProjectMember.DataSource = _TRN_PROJECT_MASTER.TRN_PROJECT_MEMBER.ToList();
        }

        private void GridProjectMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0) //check in
                {
                    frmConstractorVisitor frm = new frmConstractorVisitor();
                    frm.visitorMode = MODEL.CustomModel.VisitorMode.ConstructorIn;
                    var fullName = gridProjectMember.Rows[e.RowIndex].Cells["FULLNAME"].Value.ToString().Split(' ').ToList();
                    var firstName = "";
                    var lastName = "";
                    if(fullName.Count > 1)
                    {
                        firstName = fullName[0];
                        lastName = fullName[1];
                    }
                    else
                    {
                        firstName = gridProjectMember.Rows[e.RowIndex].Cells["FULLNAME"].Value.ToString();
                    }
                    frm.visitorObj = new TRN_VISITOR()
                    {
                        CONTACT_EMPLOYEE_NAME = _TRN_PROJECT_MASTER.RESPONSIBLE_MANAGER,
                        REASON_TEXT = _TRN_PROJECT_MASTER.PROJECT_NAME,
                        FIRST_NAME = firstName,
                        LAST_NAME = lastName,
                        ID_CARD = Convert.ToString(gridProjectMember.Rows[e.RowIndex].Cells["ID_CARD"].Value),
                    };
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var orgData = (List<TRN_PROJECT_MEMBER>)gridProjectMember.DataSource;
                        orgData.RemoveAll(o => o.AUTO_ID == Convert.ToInt32(gridProjectMember.Rows[e.RowIndex].Cells["AUTO_ID"].Value));
                        List<TRN_PROJECT_MEMBER> temp = new List<TRN_PROJECT_MEMBER>();
                        foreach(var item in orgData)
                        {
                            temp.Add(item);
                        }
                        gridProjectMember.DataSource = temp;
                    }
                }
            }
        }
    }
}
