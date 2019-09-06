namespace BIG.VMS.PRESENT
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
            this.visitor_transaction = new System.Windows.Forms.ToolStripMenuItem();
            this.Contractor = new System.Windows.Forms.ToolStripMenuItem();
            this.appointment = new System.Windows.Forms.ToolStripMenuItem();
            this.planVisitRequestForm = new System.Windows.Forms.ToolStripMenuItem();
            this.contractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report = new System.Windows.Forms.ToolStripMenuItem();
            this.report_in_out = new System.Windows.Forms.ToolStripMenuItem();
            this.contractor_management = new System.Windows.Forms.ToolStripMenuItem();
            this.BlacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractorlist = new System.Windows.Forms.ToolStripMenuItem();
            this.เวบไซตToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.website = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.test_readcard = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbLogout = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home,
            this.Contractor,
            this.report,
            this.contractor_management,
            this.เวบไซตToolStripMenuItem,
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1049, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Home
            // 
            this.Home.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitor_transaction});
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(156, 24);
            this.Home.Text = "หน้าหลัก (ผ่านเข้าออก)";
            // 
            // visitor_transaction
            // 
            this.visitor_transaction.Name = "visitor_transaction";
            this.visitor_transaction.Size = new System.Drawing.Size(189, 26);
            this.visitor_transaction.Text = "ระบบผ่านเข้า-ออก";
            this.visitor_transaction.Click += new System.EventHandler(this.visitor_transaction_Click);
            // 
            // Contractor
            // 
            this.Contractor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointment,
            this.planVisitRequestForm,
            this.contractorToolStripMenuItem});
            this.Contractor.Name = "Contractor";
            this.Contractor.Size = new System.Drawing.Size(93, 24);
            this.Contractor.Text = "การนัดหมาย";
            // 
            // appointment
            // 
            this.appointment.Name = "appointment";
            this.appointment.Size = new System.Drawing.Size(308, 26);
            this.appointment.Text = "Appointment (บุคคลทั่วไป)";
            this.appointment.Click += new System.EventHandler(this.appointment_Click);
            // 
            // planVisitRequestForm
            // 
            this.planVisitRequestForm.Name = "planVisitRequestForm";
            this.planVisitRequestForm.Size = new System.Drawing.Size(308, 26);
            this.planVisitRequestForm.Text = "Plant visit request form (กลุ่มลูกค้า)";
            this.planVisitRequestForm.Click += new System.EventHandler(this.planVisitRequestForm_Click);
            // 
            // contractorToolStripMenuItem
            // 
            this.contractorToolStripMenuItem.Name = "contractorToolStripMenuItem";
            this.contractorToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.contractorToolStripMenuItem.Text = "Vendor Management (ผู้รับเหมา)";
            this.contractorToolStripMenuItem.Click += new System.EventHandler(this.contractorToolStripMenuItem_Click);
            // 
            // report
            // 
            this.report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.report_in_out});
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(64, 24);
            this.report.Text = "รายงาน";
            // 
            // report_in_out
            // 
            this.report_in_out.Name = "report_in_out";
            this.report_in_out.Size = new System.Drawing.Size(225, 26);
            this.report_in_out.Text = "รายงานการผ่านเข้า-ออก";
            this.report_in_out.Click += new System.EventHandler(this.report_in_out_Click);
            // 
            // contractor_management
            // 
            this.contractor_management.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BlacklistToolStripMenuItem,
            this.contractorlist});
            this.contractor_management.Name = "contractor_management";
            this.contractor_management.Size = new System.Drawing.Size(104, 24);
            this.contractor_management.Text = "จัดการผู้ติดต่อ";
            // 
            // BlacklistToolStripMenuItem
            // 
            this.BlacklistToolStripMenuItem.Name = "BlacklistToolStripMenuItem";
            this.BlacklistToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.BlacklistToolStripMenuItem.Text = "รายชื่อผู้ต้องห้าม/Blacklist";
            this.BlacklistToolStripMenuItem.Click += new System.EventHandler(this.BlacklistToolStripMenuItem_Click);
            // 
            // contractorlist
            // 
            this.contractorlist.Name = "contractorlist";
            this.contractorlist.Size = new System.Drawing.Size(283, 26);
            this.contractorlist.Text = "รายชื่อบริษัทผู้รับเหมา/Contractor";
            this.contractorlist.Click += new System.EventHandler(this.contractorบรษทผรบเหมาToolStripMenuItem_Click);
            // 
            // เวบไซตToolStripMenuItem
            // 
            this.เวบไซตToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.website});
            this.เวบไซตToolStripMenuItem.Name = "เวบไซตToolStripMenuItem";
            this.เวบไซตToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.เวบไซตToolStripMenuItem.Text = "เว็บไซต์";
            // 
            // website
            // 
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(173, 26);
            this.website.Text = "อัพโหลดรูปภาพ";
            this.website.Click += new System.EventHandler(this.website_Click);
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test_readcard,
            this.logout});
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(74, 24);
            this.help.Text = "ช่วยเหลือ";
            // 
            // test_readcard
            // 
            this.test_readcard.Name = "test_readcard";
            this.test_readcard.Size = new System.Drawing.Size(175, 26);
            this.test_readcard.Text = "ทดสอบอ่านบัตร";
            this.test_readcard.Click += new System.EventHandler(this.test_readcard_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(175, 26);
            this.logout.Text = "ออกจากระบบ";
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.lbLogout});
            this.statusStrip1.Location = new System.Drawing.Point(0, 616);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1049, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.ForestGreen;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 20);
            this.toolStripStatusLabel1.Text = "Logon :";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // lbLogout
            // 
            this.lbLogout.BackColor = System.Drawing.Color.IndianRed;
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(56, 20);
            this.lbLogout.Text = "Logout";
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 641);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem contractor_management;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem report;
        private System.Windows.Forms.ToolStripMenuItem appointment;
        private System.Windows.Forms.ToolStripMenuItem planVisitRequestForm;
        private System.Windows.Forms.ToolStripMenuItem contractorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlacklistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem report_in_out;
        private System.Windows.Forms.ToolStripMenuItem visitor_transaction;
        private System.Windows.Forms.ToolStripMenuItem เวบไซตToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem website;
        private System.Windows.Forms.ToolStripMenuItem test_readcard;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.ToolStripStatusLabel lbLogout;
        private System.Windows.Forms.ToolStripMenuItem contractorlist;
    }
}