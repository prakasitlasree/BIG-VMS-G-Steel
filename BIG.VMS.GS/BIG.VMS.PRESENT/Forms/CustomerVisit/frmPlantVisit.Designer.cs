namespace BIG.VMS.PRESENT.Forms.CustomerVisit
{
    partial class frmPlantVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlantVisit));
            this.tabmain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtVisitTime = new System.Windows.Forms.DateTimePicker();
            this.txtvisitgroup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.visitordate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtobjective = new System.Windows.Forms.TextBox();
            this.txtcontractperson = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clbfac_req = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numNo = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridVisitor = new System.Windows.Forms.DataGridView();
            this.AUTO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_VISIT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FULLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRN_CUSTOMER_VISIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddvisitor = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lb4 = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.txtReqname = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.tbmain = new System.Windows.Forms.TableLayoutPanel();
            this.group_requester = new System.Windows.Forms.GroupBox();
            this.tb1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtReqPosition = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.group_detail = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabmain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVisitor)).BeginInit();
            this.tbmain.SuspendLayout();
            this.group_requester.SuspendLayout();
            this.tb1.SuspendLayout();
            this.group_detail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabmain
            // 
            this.tabmain.Controls.Add(this.tabPage1);
            this.tabmain.Controls.Add(this.tabPage2);
            this.tabmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabmain.Location = new System.Drawing.Point(3, 22);
            this.tabmain.Name = "tabmain";
            this.tabmain.SelectedIndex = 0;
            this.tabmain.Size = new System.Drawing.Size(915, 302);
            this.tabmain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visitor Group/Company";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb2
            // 
            this.tb2.ColumnCount = 4;
            this.tb2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tb2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tb2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb2.Controls.Add(this.dtVisitTime, 3, 1);
            this.tb2.Controls.Add(this.txtvisitgroup, 1, 0);
            this.tb2.Controls.Add(this.label5, 0, 0);
            this.tb2.Controls.Add(this.label6, 0, 1);
            this.tb2.Controls.Add(this.visitordate, 3, 0);
            this.tb2.Controls.Add(this.label8, 2, 0);
            this.tb2.Controls.Add(this.label9, 2, 1);
            this.tb2.Controls.Add(this.label10, 0, 2);
            this.tb2.Controls.Add(this.txtobjective, 1, 3);
            this.tb2.Controls.Add(this.txtcontractperson, 1, 2);
            this.tb2.Controls.Add(this.label7, 0, 3);
            this.tb2.Controls.Add(this.clbfac_req, 3, 3);
            this.tb2.Controls.Add(this.label11, 2, 3);
            this.tb2.Controls.Add(this.numNo, 1, 1);
            this.tb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb2.Location = new System.Drawing.Point(3, 3);
            this.tb2.Name = "tb2";
            this.tb2.RowCount = 4;
            this.tb2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tb2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tb2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tb2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb2.Size = new System.Drawing.Size(901, 263);
            this.tb2.TabIndex = 16;
            // 
            // dtVisitTime
            // 
            this.dtVisitTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtVisitTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVisitTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtVisitTime.Location = new System.Drawing.Point(653, 48);
            this.dtVisitTime.Name = "dtVisitTime";
            this.dtVisitTime.ShowUpDown = true;
            this.dtVisitTime.Size = new System.Drawing.Size(245, 23);
            this.dtVisitTime.TabIndex = 22;
            // 
            // txtvisitgroup
            // 
            this.txtvisitgroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtvisitgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvisitgroup.Location = new System.Drawing.Point(203, 8);
            this.txtvisitgroup.Name = "txtvisitgroup";
            this.txtvisitgroup.Size = new System.Drawing.Size(244, 23);
            this.txtvisitgroup.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(35, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Visitor Group/Organize *";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(101, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "No. of visitor *";
            // 
            // visitordate
            // 
            this.visitordate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.visitordate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitordate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.visitordate.Location = new System.Drawing.Point(653, 8);
            this.visitordate.Name = "visitordate";
            this.visitordate.Size = new System.Drawing.Size(245, 23);
            this.visitordate.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(570, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Visit Date *";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(578, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Visit Time";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(33, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Contract person on site *";
            // 
            // txtobjective
            // 
            this.txtobjective.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtobjective.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobjective.Location = new System.Drawing.Point(203, 123);
            this.txtobjective.Multiline = true;
            this.txtobjective.Name = "txtobjective";
            this.txtobjective.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtobjective.Size = new System.Drawing.Size(244, 137);
            this.txtobjective.TabIndex = 7;
            // 
            // txtcontractperson
            // 
            this.txtcontractperson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcontractperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontractperson.Location = new System.Drawing.Point(203, 88);
            this.txtcontractperson.Name = "txtcontractperson";
            this.txtcontractperson.Size = new System.Drawing.Size(244, 23);
            this.txtcontractperson.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(91, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Visit Objective *";
            // 
            // clbfac_req
            // 
            this.clbfac_req.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbfac_req.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbfac_req.FormattingEnabled = true;
            this.clbfac_req.Items.AddRange(new object[] {
            "Uniform & PPE",
            "Over Head",
            "Projector",
            "Van Service",
            "Conference Room of AMO",
            "Other..."});
            this.clbfac_req.Location = new System.Drawing.Point(653, 123);
            this.clbfac_req.Name = "clbfac_req";
            this.clbfac_req.Size = new System.Drawing.Size(245, 137);
            this.clbfac_req.TabIndex = 10;
            this.clbfac_req.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(516, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Facility requirement";
            this.label11.Visible = false;
            // 
            // numNo
            // 
            this.numNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numNo.Location = new System.Drawing.Point(203, 47);
            this.numNo.Name = "numNo";
            this.numNo.Size = new System.Drawing.Size(120, 26);
            this.numNo.TabIndex = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visitor List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridVisitor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddvisitor, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 263);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gridVisitor
            // 
            this.gridVisitor.AllowUserToAddRows = false;
            this.gridVisitor.AllowUserToDeleteRows = false;
            this.gridVisitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVisitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AUTO_ID,
            this.CUSTOMER_VISIT_ID,
            this.SEQ,
            this.FULLNAME,
            this.TRN_CUSTOMER_VISIT});
            this.gridVisitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVisitor.Location = new System.Drawing.Point(3, 50);
            this.gridVisitor.Name = "gridVisitor";
            this.gridVisitor.ReadOnly = true;
            this.gridVisitor.RowTemplate.Height = 24;
            this.gridVisitor.Size = new System.Drawing.Size(895, 207);
            this.gridVisitor.TabIndex = 0;
            // 
            // AUTO_ID
            // 
            this.AUTO_ID.DataPropertyName = "AUTO_ID";
            this.AUTO_ID.HeaderText = "AUTO_ID";
            this.AUTO_ID.Name = "AUTO_ID";
            this.AUTO_ID.ReadOnly = true;
            this.AUTO_ID.Visible = false;
            this.AUTO_ID.Width = 104;
            // 
            // CUSTOMER_VISIT_ID
            // 
            this.CUSTOMER_VISIT_ID.DataPropertyName = "CUSTOMER_VISIT_ID";
            this.CUSTOMER_VISIT_ID.HeaderText = "CUSTOMER_VISIT_ID";
            this.CUSTOMER_VISIT_ID.Name = "CUSTOMER_VISIT_ID";
            this.CUSTOMER_VISIT_ID.ReadOnly = true;
            this.CUSTOMER_VISIT_ID.Visible = false;
            this.CUSTOMER_VISIT_ID.Width = 201;
            // 
            // SEQ
            // 
            this.SEQ.DataPropertyName = "SEQ";
            this.SEQ.HeaderText = "No.";
            this.SEQ.Name = "SEQ";
            this.SEQ.ReadOnly = true;
            this.SEQ.Width = 58;
            // 
            // FULLNAME
            // 
            this.FULLNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FULLNAME.DataPropertyName = "FULLNAME";
            this.FULLNAME.HeaderText = "Full Name";
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.ReadOnly = true;
            // 
            // TRN_CUSTOMER_VISIT
            // 
            this.TRN_CUSTOMER_VISIT.DataPropertyName = "TRN_CUSTOMER_VISIT";
            this.TRN_CUSTOMER_VISIT.HeaderText = "TRN_CUSTOMER_VISIT";
            this.TRN_CUSTOMER_VISIT.Name = "TRN_CUSTOMER_VISIT";
            this.TRN_CUSTOMER_VISIT.ReadOnly = true;
            this.TRN_CUSTOMER_VISIT.Visible = false;
            this.TRN_CUSTOMER_VISIT.Width = 216;
            // 
            // btnAddvisitor
            // 
            this.btnAddvisitor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddvisitor.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddvisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddvisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddvisitor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAddvisitor.Image = ((System.Drawing.Image)(resources.GetObject("btnAddvisitor.Image")));
            this.btnAddvisitor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddvisitor.Location = new System.Drawing.Point(810, 6);
            this.btnAddvisitor.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddvisitor.Name = "btnAddvisitor";
            this.btnAddvisitor.Size = new System.Drawing.Size(85, 35);
            this.btnAddvisitor.TabIndex = 1;
            this.btnAddvisitor.Text = "Add";
            this.btnAddvisitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddvisitor.UseVisualStyleBackColor = false;
            this.btnAddvisitor.Click += new System.EventHandler(this.btnAddvisitor_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(660, 41);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(252, 23);
            this.txtDepartment.TabIndex = 3;
            // 
            // lb4
            // 
            this.lb4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(572, 44);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(82, 17);
            this.lb4.TabIndex = 6;
            this.lb4.Text = "Department";
            // 
            // txtGroup
            // 
            this.txtGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroup.Location = new System.Drawing.Point(660, 6);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(252, 23);
            this.txtGroup.TabIndex = 2;
            // 
            // lb3
            // 
            this.lb3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(572, 9);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(82, 17);
            this.lb3.TabIndex = 4;
            this.lb3.Text = "Group/Area";
            // 
            // txtReqname
            // 
            this.txtReqname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReqname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReqname.Location = new System.Drawing.Point(203, 6);
            this.txtReqname.Name = "txtReqname";
            this.txtReqname.Size = new System.Drawing.Size(251, 23);
            this.txtReqname.TabIndex = 0;
            // 
            // lb2
            // 
            this.lb2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.Red;
            this.lb2.Location = new System.Drawing.Point(60, 44);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(137, 17);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Requestor Position *";
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Red;
            this.lb1.Location = new System.Drawing.Point(73, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(124, 17);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Requestor Name *";
            // 
            // tbmain
            // 
            this.tbmain.ColumnCount = 1;
            this.tbmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbmain.Controls.Add(this.group_requester, 0, 0);
            this.tbmain.Controls.Add(this.group_detail, 0, 1);
            this.tbmain.Controls.Add(this.panel1, 0, 2);
            this.tbmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbmain.Location = new System.Drawing.Point(0, 0);
            this.tbmain.Name = "tbmain";
            this.tbmain.RowCount = 3;
            this.tbmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.5426F));
            this.tbmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.4574F));
            this.tbmain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbmain.Size = new System.Drawing.Size(927, 494);
            this.tbmain.TabIndex = 1;
            // 
            // group_requester
            // 
            this.group_requester.Controls.Add(this.tb1);
            this.group_requester.Controls.Add(this.lbType);
            this.group_requester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_requester.Location = new System.Drawing.Point(3, 3);
            this.group_requester.Name = "group_requester";
            this.group_requester.Size = new System.Drawing.Size(921, 96);
            this.group_requester.TabIndex = 3;
            this.group_requester.TabStop = false;
            // 
            // tb1
            // 
            this.tb1.ColumnCount = 4;
            this.tb1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tb1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tb1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb1.Controls.Add(this.lb1, 0, 0);
            this.tb1.Controls.Add(this.lb2, 0, 1);
            this.tb1.Controls.Add(this.txtReqname, 1, 0);
            this.tb1.Controls.Add(this.txtReqPosition, 1, 1);
            this.tb1.Controls.Add(this.lb3, 2, 0);
            this.tb1.Controls.Add(this.txtGroup, 3, 0);
            this.tb1.Controls.Add(this.lb4, 2, 1);
            this.tb1.Controls.Add(this.txtDepartment, 3, 1);
            this.tb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb1.Location = new System.Drawing.Point(3, 22);
            this.tb1.Name = "tb1";
            this.tb1.RowCount = 2;
            this.tb1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb1.Size = new System.Drawing.Size(915, 71);
            this.tb1.TabIndex = 0;
            // 
            // txtReqPosition
            // 
            this.txtReqPosition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReqPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReqPosition.Location = new System.Drawing.Point(203, 41);
            this.txtReqPosition.Name = "txtReqPosition";
            this.txtReqPosition.Size = new System.Drawing.Size(251, 23);
            this.txtReqPosition.TabIndex = 1;
            // 
            // lbType
            // 
            this.lbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.Color.Black;
            this.lbType.Location = new System.Drawing.Point(9, -5);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(171, 20);
            this.lbType.TabIndex = 22;
            this.lbType.Text = "Add new customer visit";
            // 
            // group_detail
            // 
            this.group_detail.Controls.Add(this.tabmain);
            this.group_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_detail.Location = new System.Drawing.Point(3, 105);
            this.group_detail.Name = "group_detail";
            this.group_detail.Size = new System.Drawing.Size(921, 327);
            this.group_detail.TabIndex = 16;
            this.group_detail.TabStop = false;
            this.group_detail.Text = "Detail of request";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(3, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 52);
            this.panel1.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SeaShell;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(801, 9);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 37);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Close";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(667, 9);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPlantVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 494);
            this.Controls.Add(this.tbmain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlantVisit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer visit request form";
            this.Load += new System.EventHandler(this.frmPlantVisit_Load);
            this.tabmain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tb2.ResumeLayout(false);
            this.tb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVisitor)).EndInit();
            this.tbmain.ResumeLayout(false);
            this.group_requester.ResumeLayout(false);
            this.group_requester.PerformLayout();
            this.tb1.ResumeLayout(false);
            this.tb1.PerformLayout();
            this.group_detail.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabmain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtobjective;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvisitgroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox txtReqname;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DateTimePicker visitordate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView gridVisitor;
        private System.Windows.Forms.TableLayoutPanel tbmain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox group_requester;
        private System.Windows.Forms.TableLayoutPanel tb1;
        private System.Windows.Forms.TextBox txtReqPosition;
        private System.Windows.Forms.GroupBox group_detail;
        private System.Windows.Forms.TableLayoutPanel tb2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcontractperson;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox clbfac_req;
        private System.Windows.Forms.Button btnAddvisitor;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numNo;
        private System.Windows.Forms.DateTimePicker dtVisitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_VISIT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRN_CUSTOMER_VISIT;
    }
}