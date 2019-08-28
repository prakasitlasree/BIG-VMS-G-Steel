﻿namespace BIG.VMS.PRESENT
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Home = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Contractor = new System.Windows.Forms.ToolStripMenuItem();
            this.appointment = new System.Windows.Forms.ToolStripMenuItem();
            this.planVisitRequestForm = new System.Windows.Forms.ToolStripMenuItem();
            this.contractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report = new System.Windows.Forms.ToolStripMenuItem();
            this.contractor_management = new System.Windows.Forms.ToolStripMenuItem();
            this.BlacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.report_in_out = new System.Windows.Forms.ToolStripMenuItem();
            this.visitor_transaction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home,
            this.toolStripMenuItem1,
            this.Contractor,
            this.report,
            this.contractor_management,
            this.logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Home
            // 
            this.Home.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitor_transaction});
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(58, 20);
            this.Home.Text = "หน้าหลัก";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // Contractor
            // 
            this.Contractor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointment,
            this.planVisitRequestForm,
            this.contractorToolStripMenuItem});
            this.Contractor.Name = "Contractor";
            this.Contractor.Size = new System.Drawing.Size(63, 20);
            this.Contractor.Text = "การติดต่อ";
            // 
            // appointment
            // 
            this.appointment.Name = "appointment";
            this.appointment.Size = new System.Drawing.Size(252, 22);
            this.appointment.Text = "Appointment (บุคคลทั่วไป)";
            this.appointment.Click += new System.EventHandler(this.appointment_Click);
            // 
            // planVisitRequestForm
            // 
            this.planVisitRequestForm.Name = "planVisitRequestForm";
            this.planVisitRequestForm.Size = new System.Drawing.Size(252, 22);
            this.planVisitRequestForm.Text = "Plant visit request form (กลุ่มลูกค้า)";
            // 
            // contractorToolStripMenuItem
            // 
            this.contractorToolStripMenuItem.Name = "contractorToolStripMenuItem";
            this.contractorToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.contractorToolStripMenuItem.Text = "Vendor Management (ผู้รับเหมา)";
            // 
            // report
            // 
            this.report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.report_in_out});
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(52, 20);
            this.report.Text = "รายงาน";
            // 
            // contractor_management
            // 
            this.contractor_management.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BlacklistToolStripMenuItem});
            this.contractor_management.Name = "contractor_management";
            this.contractor_management.Size = new System.Drawing.Size(100, 20);
            this.contractor_management.Text = "การจัดการผู้ติดต่อ";
            // 
            // BlacklistToolStripMenuItem
            // 
            this.BlacklistToolStripMenuItem.Name = "BlacklistToolStripMenuItem";
            this.BlacklistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BlacklistToolStripMenuItem.Text = "รายชื่อ Blacklist";
            this.BlacklistToolStripMenuItem.Click += new System.EventHandler(this.BlacklistToolStripMenuItem_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(79, 20);
            this.logout.Text = "ออกจากระบบ";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(787, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel1.Text = "Logon";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // report_in_out
            // 
            this.report_in_out.Name = "report_in_out";
            this.report_in_out.Size = new System.Drawing.Size(182, 22);
            this.report_in_out.Text = "รายงานการผ่านเข้า-ออก";
            this.report_in_out.Click += new System.EventHandler(this.report_in_out_Click);
            // 
            // visitor_transaction
            // 
            this.visitor_transaction.Name = "visitor_transaction";
            this.visitor_transaction.Size = new System.Drawing.Size(180, 22);
            this.visitor_transaction.Text = "ระบบผ่านเข้า-ออก";
            this.visitor_transaction.Click += new System.EventHandler(this.visitor_transaction_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 521);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIG Visitor Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Home;
        private System.Windows.Forms.ToolStripMenuItem Contractor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem contractor_management;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.ToolStripMenuItem report;
        private System.Windows.Forms.ToolStripMenuItem appointment;
        private System.Windows.Forms.ToolStripMenuItem planVisitRequestForm;
        private System.Windows.Forms.ToolStripMenuItem contractorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlacklistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem report_in_out;
        private System.Windows.Forms.ToolStripMenuItem visitor_transaction;
    }
}