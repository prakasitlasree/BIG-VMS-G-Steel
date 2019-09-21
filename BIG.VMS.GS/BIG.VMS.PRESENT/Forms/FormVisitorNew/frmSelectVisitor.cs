﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIG.VMS.MODEL.CustomModel;
using BIG.VMS.PRESENT.Forms.FormVisitor;

namespace BIG.VMS.PRESENT.Forms.FormVisitorNew
{
    public partial class frmSelectVisitor : Form
    {
        public frmSelectVisitor()
        {
            InitializeComponent();
        }

        private void FrmSelectVisitor_Load(object sender, EventArgs e)
        {

        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {
            frmVisitorNew frm = new frmVisitorNew();
            frm.visitorType = VisitorMode.In;
            frm.formMode = FormMode.Add;

            frm.ShowDialog();

        }

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            frmAppointment frm = new frmAppointment();
            frm.ShowDialog();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            frmSelectCustomer frm = new frmSelectCustomer();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                frmVisitorNew frmVisitor = new frmVisitorNew();
                frmVisitor.visitorType = VisitorMode.CustomerIn;
                frmVisitor.formMode = FormMode.Add;
                frmVisitor.TrnCustomerVisit = frm.TrnCustomerVisit;
                frm.Hide();
                frmVisitor.ShowDialog();
            }
            
        }

        private void BtnConstructor_Click(object sender, EventArgs e)
        {
            frmSelectConstructor frm = new frmSelectConstructor();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                frmVisitorNew frmVisitor = new frmVisitorNew();
                frmVisitor.visitorType = VisitorMode.ConstructorIn;
                frmVisitor.formMode = FormMode.Add;
                frmVisitor.TrnProjectMaster = frm.TrnProjectMaster;
                frm.Hide();
                frmVisitor.ShowDialog();
            }
        }
    }
}
