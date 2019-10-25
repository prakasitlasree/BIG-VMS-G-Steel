namespace BIG.VMS.PRESENT.Forms.Home
{
    partial class frmVisitorList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitorList));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gridVisitorList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnListExit = new System.Windows.Forms.Button();
            this.btnBlacklist = new System.Windows.Forms.Button();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnAhead = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTodayOut = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAllCount = new System.Windows.Forms.Label();
            this.lblTodayIn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.IMAGE = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.colPrint = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVisitorList)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1181, 676);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.gridVisitorList, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 290);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1175, 389);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // gridVisitorList
            // 
            this.gridVisitorList.AllowUserToAddRows = false;
            this.gridVisitorList.AllowUserToDeleteRows = false;
            this.gridVisitorList.BackgroundColor = System.Drawing.Color.White;
            this.gridVisitorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVisitorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEdit,
            this.IMAGE,
            this.colDelete,
            this.colPrint});
            this.gridVisitorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVisitorList.Location = new System.Drawing.Point(3, 3);
            this.gridVisitorList.Name = "gridVisitorList";
            this.gridVisitorList.ReadOnly = true;
            this.gridVisitorList.Size = new System.Drawing.Size(1169, 333);
            this.gridVisitorList.TabIndex = 0;
            this.gridVisitorList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVisitorList_CellContentClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.txtPage, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnFirst, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPrevious, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnNext, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnLast, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 342);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1169, 44);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // txtPage
            // 
            this.txtPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPage.Enabled = false;
            this.txtPage.Location = new System.Drawing.Point(3, 6);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(227, 31);
            this.txtPage.TabIndex = 1;
            this.txtPage.Text = "หน้า";
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirst.Location = new System.Drawing.Point(236, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(227, 38);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "หน้าแรก";
            this.btnFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirst.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrevious.Location = new System.Drawing.Point(469, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(227, 38);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "หน้าก่อนหน้า";
            this.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(702, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(227, 38);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "หน้าถัดไป";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.White;
            this.btnLast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLast.Location = new System.Drawing.Point(935, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(231, 38);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "หน้าสุดท้าย";
            this.btnLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.txtIDCard, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtLastName, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtLicense, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtNo, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.dtFrom, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.dtTo, 5, 2);
            this.tableLayoutPanel5.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.label11, 4, 2);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label12, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.comboType, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.comboGroup, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 109);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1175, 175);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // txtIDCard
            // 
            this.txtIDCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDCard.Location = new System.Drawing.Point(892, 4);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(279, 31);
            this.txtIDCard.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(477, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(278, 31);
            this.txtLastName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ทะเบียนรถ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "นามสกุล";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(762, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "บัตรประชาชน";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(107, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(278, 31);
            this.txtName.TabIndex = 6;
            // 
            // txtLicense
            // 
            this.txtLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLicense.Location = new System.Drawing.Point(107, 43);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(278, 31);
            this.txtLicense.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "เลขที่";
            // 
            // txtNo
            // 
            this.txtNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNo.Location = new System.Drawing.Point(477, 43);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(278, 31);
            this.txtNo.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Controls.Add(this.btnListExit);
            this.flowLayoutPanel1.Controls.Add(this.btnBlacklist);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(107, 122);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(616, 49);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(186, 43);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnListExit
            // 
            this.btnListExit.BackColor = System.Drawing.SystemColors.Info;
            this.btnListExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListExit.ForeColor = System.Drawing.Color.Black;
            this.btnListExit.Image = ((System.Drawing.Image)(resources.GetObject("btnListExit.Image")));
            this.btnListExit.Location = new System.Drawing.Point(195, 3);
            this.btnListExit.Name = "btnListExit";
            this.btnListExit.Size = new System.Drawing.Size(224, 43);
            this.btnListExit.TabIndex = 16;
            this.btnListExit.Text = "รายการคนที่ยังไม่ออก";
            this.btnListExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListExit.UseVisualStyleBackColor = false;
            this.btnListExit.Click += new System.EventHandler(this.btnListExit_Click);
            // 
            // btnBlacklist
            // 
            this.btnBlacklist.AutoSize = true;
            this.btnBlacklist.BackColor = System.Drawing.Color.MistyRose;
            this.btnBlacklist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlacklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlacklist.ForeColor = System.Drawing.Color.Black;
            this.btnBlacklist.Image = ((System.Drawing.Image)(resources.GetObject("btnBlacklist.Image")));
            this.btnBlacklist.Location = new System.Drawing.Point(425, 3);
            this.btnBlacklist.Name = "btnBlacklist";
            this.btnBlacklist.Size = new System.Drawing.Size(188, 43);
            this.btnBlacklist.TabIndex = 15;
            this.btnBlacklist.Text = "Blacklist";
            this.btnBlacklist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlacklist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBlacklist.UseVisualStyleBackColor = false;
            this.btnBlacklist.Click += new System.EventHandler(this.btnBlacklist_Click);
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(477, 83);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(278, 31);
            this.dtFrom.TabIndex = 18;
            this.dtFrom.ValueChanged += new System.EventHandler(this.DtFrom_ValueChanged);
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(892, 83);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(279, 31);
            this.dtTo.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "เริ่มต้น";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(826, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "สิ้นสุด";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "กลุ่ม";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(812, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "ประเภท";
            // 
            // comboType
            // 
            this.comboType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "ทั้งหมด",
            "เข้า",
            "ออก"});
            this.comboType.Location = new System.Drawing.Point(892, 42);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(279, 33);
            this.comboType.TabIndex = 23;
            // 
            // comboGroup
            // 
            this.comboGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Items.AddRange(new object[] {
            "ทั้งหมด",
            "บุุคคลทั่วไป",
            "บุุคคลนัดหมาย",
            "ผูู้รับเหมา",
            "กลุ่มลูกค้า"});
            this.comboGroup.Location = new System.Drawing.Point(107, 82);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(278, 33);
            this.comboGroup.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 100);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Controls.Add(this.btnIn);
            this.flowLayoutPanel3.Controls.Add(this.btnOut);
            this.flowLayoutPanel3.Controls.Add(this.btnReport);
            this.flowLayoutPanel3.Controls.Add(this.btnAhead);
            this.flowLayoutPanel3.Controls.Add(this.panel3);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1175, 100);
            this.flowLayoutPanel3.TabIndex = 19;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.Black;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(3, 3);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(189, 94);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "เข้า";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnOut
            // 
            this.btnOut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOut.BackColor = System.Drawing.Color.MistyRose;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.ForeColor = System.Drawing.Color.Black;
            this.btnOut.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.Image")));
            this.btnOut.Location = new System.Drawing.Point(198, 3);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(189, 94);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "ออก";
            this.btnOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReport.BackColor = System.Drawing.Color.Lavender;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.Location = new System.Drawing.Point(393, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(189, 94);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "รายงาน";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnAhead
            // 
            this.btnAhead.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAhead.BackColor = System.Drawing.Color.LightBlue;
            this.btnAhead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAhead.ForeColor = System.Drawing.Color.Black;
            this.btnAhead.Image = ((System.Drawing.Image)(resources.GetObject("btnAhead.Image")));
            this.btnAhead.Location = new System.Drawing.Point(588, 3);
            this.btnAhead.Name = "btnAhead";
            this.btnAhead.Size = new System.Drawing.Size(189, 94);
            this.btnAhead.TabIndex = 4;
            this.btnAhead.Text = "นัดล่วงหน้า";
            this.btnAhead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAhead.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAhead.UseVisualStyleBackColor = false;
            this.btnAhead.Click += new System.EventHandler(this.btnAhead_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTodayOut);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblAllCount);
            this.panel3.Controls.Add(this.lblTodayIn);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(783, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 94);
            this.panel3.TabIndex = 17;
            // 
            // lblTodayOut
            // 
            this.lblTodayOut.AutoSize = true;
            this.lblTodayOut.Location = new System.Drawing.Point(199, 36);
            this.lblTodayOut.Name = "lblTodayOut";
            this.lblTodayOut.Size = new System.Drawing.Size(24, 25);
            this.lblTodayOut.TabIndex = 5;
            this.lblTodayOut.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "จำนวนคนออกวันนี้";
            // 
            // lblAllCount
            // 
            this.lblAllCount.AutoSize = true;
            this.lblAllCount.Location = new System.Drawing.Point(199, 68);
            this.lblAllCount.Name = "lblAllCount";
            this.lblAllCount.Size = new System.Drawing.Size(24, 25);
            this.lblAllCount.TabIndex = 3;
            this.lblAllCount.Text = "0";
            // 
            // lblTodayIn
            // 
            this.lblTodayIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTodayIn.AutoSize = true;
            this.lblTodayIn.Location = new System.Drawing.Point(199, 3);
            this.lblTodayIn.Name = "lblTodayIn";
            this.lblTodayIn.Size = new System.Drawing.Size(24, 25);
            this.lblTodayIn.TabIndex = 2;
            this.lblTodayIn.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "จำนวนคนเข้าทั้งหมด";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "จำนวนคนเข้าวันนี้";
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEdit.HeaderText = "แก้ไข";
            this.colEdit.Image = ((System.Drawing.Image)(resources.GetObject("colEdit.Image")));
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEdit.Width = 60;
            // 
            // IMAGE
            // 
            this.IMAGE.HeaderText = "ดูรูปภาพ";
            this.IMAGE.Image = ((System.Drawing.Image)(resources.GetObject("IMAGE.Image")));
            this.IMAGE.Name = "IMAGE";
            this.IMAGE.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDelete.HeaderText = "ลบ";
            this.colDelete.Image = ((System.Drawing.Image)(resources.GetObject("colDelete.Image")));
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDelete.Width = 60;
            // 
            // colPrint
            // 
            this.colPrint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPrint.HeaderText = "พิมพ์";
            this.colPrint.Image = ((System.Drawing.Image)(resources.GetObject("colPrint.Image")));
            this.colPrint.Name = "colPrint";
            this.colPrint.ReadOnly = true;
            this.colPrint.Width = 60;
            // 
            // frmVisitorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 676);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmVisitorList";
            this.ShowIcon = false;
            this.Text = "รายการทั้งหมด";
            this.Load += new System.EventHandler(this.frmAllvisitor_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVisitorList)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView gridVisitorList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnAhead;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.Button btnBlacklist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAllCount;
        private System.Windows.Forms.Label lblTodayIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTodayOut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn IMAGE;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
        private System.Windows.Forms.DataGridViewImageColumn colPrint;
    }
}