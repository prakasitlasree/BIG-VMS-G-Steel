namespace BIG.VMS.PRESENT.Forms.FormVisitor
{
    partial class frmVisitorOutList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitorOutList));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.dtContactDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalItem = new System.Windows.Forms.Label();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gridVisitorOut = new System.Windows.Forms.DataGridView();
            this.colMeeted = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVisitorOut)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightCyan;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(141, 92);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtIDCard
            // 
            this.txtIDCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.SetColumnSpan(this.txtIDCard, 2);
            this.txtIDCard.Location = new System.Drawing.Point(141, 49);
            this.txtIDCard.Margin = new System.Windows.Forms.Padding(6);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(243, 31);
            this.txtIDCard.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(396, 6);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(153, 31);
            this.txtLastName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อผู้นัดหมาย";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ทะเบียนรถ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "นามสกุล";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "บัตรประชาชน";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(141, 6);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 31);
            this.txtName.TabIndex = 6;
            // 
            // txtLicense
            // 
            this.txtLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLicense.Location = new System.Drawing.Point(669, 6);
            this.txtLicense.Margin = new System.Windows.Forms.Padding(6);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(153, 31);
            this.txtLicense.TabIndex = 7;
            // 
            // dtContactDate
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.dtContactDate, 2);
            this.dtContactDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtContactDate.Location = new System.Drawing.Point(561, 49);
            this.dtContactDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtContactDate.Name = "dtContactDate";
            this.dtContactDate.Size = new System.Drawing.Size(255, 31);
            this.dtContactDate.TabIndex = 12;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.btnSearch, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.txtLastName, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblTotalItem, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.txtLicense, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.chkDate, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.dtContactDate, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtIDCard, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(828, 133);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "จำนวน";
            // 
            // lblTotalItem
            // 
            this.lblTotalItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalItem.AutoSize = true;
            this.lblTotalItem.Location = new System.Drawing.Point(396, 97);
            this.lblTotalItem.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalItem.Name = "lblTotalItem";
            this.lblTotalItem.Size = new System.Drawing.Size(24, 25);
            this.lblTotalItem.TabIndex = 14;
            this.lblTotalItem.Text = "0";
            // 
            // chkDate
            // 
            this.chkDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkDate.Location = new System.Drawing.Point(456, 50);
            this.chkDate.Margin = new System.Windows.Forms.Padding(6);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(93, 29);
            this.chkDate.TabIndex = 11;
            this.chkDate.Text = "วันที่เข้า";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // txtPage
            // 
            this.txtPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPage.Enabled = false;
            this.txtPage.Location = new System.Drawing.Point(3, 4);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(117, 31);
            this.txtPage.TabIndex = 1;
            this.txtPage.Text = "หน้า";
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirst.Location = new System.Drawing.Point(126, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(170, 34);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "หน้าแรก";
            this.btnFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirst.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrevious.Location = new System.Drawing.Point(302, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(170, 34);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "หน้าก่อนหน้า";
            this.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(478, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(170, 34);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "หน้าถัดไป";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.White;
            this.btnLast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLast.Location = new System.Drawing.Point(654, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(171, 34);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "หน้าสุดท้าย";
            this.btnLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.txtPage, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnFirst, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPrevious, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnNext, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnLast, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 468);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(828, 40);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // gridVisitorOut
            // 
            this.gridVisitorOut.AllowUserToAddRows = false;
            this.gridVisitorOut.AllowUserToDeleteRows = false;
            this.gridVisitorOut.BackgroundColor = System.Drawing.Color.White;
            this.gridVisitorOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVisitorOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMeeted});
            this.gridVisitorOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVisitorOut.Location = new System.Drawing.Point(3, 142);
            this.gridVisitorOut.Name = "gridVisitorOut";
            this.gridVisitorOut.ReadOnly = true;
            this.gridVisitorOut.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridVisitorOut.RowTemplate.Height = 30;
            this.gridVisitorOut.Size = new System.Drawing.Size(828, 320);
            this.gridVisitorOut.TabIndex = 0;
            this.gridVisitorOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVisitorOut_CellContentClick);
            // 
            // colMeeted
            // 
            this.colMeeted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMeeted.HeaderText = "ออก";
            this.colMeeted.Image = ((System.Drawing.Image)(resources.GetObject("colMeeted.Image")));
            this.colMeeted.Name = "colMeeted";
            this.colMeeted.ReadOnly = true;
            this.colMeeted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMeeted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMeeted.Width = 70;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridVisitorOut, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 511);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // frmVisitorOutList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisitorOutList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "รายการคนที่ยังไม่ออก";
            this.Load += new System.EventHandler(this.frmListExist_Load);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVisitorOut)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.DateTimePicker dtContactDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView gridVisitorOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewImageColumn colMeeted;
        private System.Windows.Forms.Label lblTotalItem;
    }
}