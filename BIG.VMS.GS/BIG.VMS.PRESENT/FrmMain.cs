﻿
using BIG.VMS.PRESENT.Forms.Contractor;
using BIG.VMS.PRESENT.Forms.CustomerVisit;
using BIG.VMS.PRESENT.Forms.FormReport;
using BIG.VMS.PRESENT.Forms.FormVisitor;
using BIG.VMS.PRESENT.Forms.Home;
using BIG.VMS.PRESENT.Forms.Master;
using System;
using System.Drawing;
using System.Windows.Forms;
using BIG.VMS.PRESENT.Forms.FormReportNew;
using BIG.VMS.PRESENT.Forms.Utitility;
using BIG.VMS.PRESENT.Forms.Employee;
using BIG.VMS.PRESENT.Forms.Department;

namespace BIG.VMS.PRESENT
{
    public partial class FrmMain : PageBase
    {
        public string User { get; set; }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SetRoleControl()
        {
            if (ROLE.Trim().ToUpper() == "GUARD")
            {
                menuAppointment.Visible = false;
                menuContact.Visible = false;
                menuReport.Visible = false;
                menuEmployee.Visible = false;

            }
            if (ROLE.Trim().ToUpper() == "USER")
            {
                menuInOut.Visible = false;
                menuEmployee.Visible = false;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetRoleControl();
            toolStripStatusLabel2.Text = User;
            //============ เปลี่ยนสี MDI form ===============
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.Gainsboro;
                }
            }
            //============================================

            frmVisitorList frm = new frmVisitorList();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(Message.LOGOUT, Message.MSG_WARNING_CAPTION, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OnCloseAllChildrenForm();
                Dispose(true);
                Application.ExitThread();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        #region  ============= Private ================
        private void OnCloseAllChildrenForm()
        {
            foreach (var c in MdiChildren)
            {
                c.Close();
            }
        }

        #endregion


        private void appointment_Click(object sender, EventArgs e)
        {
            frmAppointmentList frm = new frmAppointmentList();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void BlacklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmBlacklistList();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void report_in_out_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void visitor_transaction_Click(object sender, EventArgs e)
        {
            frmVisitorList frm = new frmVisitorList();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void website_Click(object sender, EventArgs e)
        {
            Website frm = new Website();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void test_readcard_Click(object sender, EventArgs e)
        {
            ReadCard frm = new ReadCard();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmProjectMasterList();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void contratorcompany_Click(object sender, EventArgs e)
        {
            var frm = new frmContractorList();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void contractorบรษทผรบเหมาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmContractorList();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void planVisitRequestForm_Click(object sender, EventArgs e)
        {
            var frm = new frmPlantVisitList();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void downloadPic_Click(object sender, EventArgs e)
        {
            var frm = new frmDownloadPicture();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void แผนกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartmentList frm = new frmDepartmentList();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void รายชอแผนกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeList frm = new frmEmployeeList();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void MenuInOut_Click(object sender, EventArgs e)
        {

        }

        private void menuEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
