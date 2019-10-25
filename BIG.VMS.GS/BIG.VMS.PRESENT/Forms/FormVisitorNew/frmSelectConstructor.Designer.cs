namespace BIG.VMS.PRESENT.Forms.FormVisitorNew
{
    partial class frmSelectConstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectConstructor));
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.gridVisitorList = new System.Windows.Forms.DataGridView();
            this.IN = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVisitorList)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "แก้ไข";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.HeaderText = "พิมพ์";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 60;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightCyan;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อโครงการ";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectName.Location = new System.Drawing.Point(121, 4);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(267, 31);
            this.txtProjectName.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(121, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(246, 45);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "ลบ";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // txtPage
            // 
            this.txtPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPage.Enabled = false;
            this.txtPage.Location = new System.Drawing.Point(8, 6);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(157, 31);
            this.txtPage.TabIndex = 1;
            this.txtPage.Text = "หน้า";
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirst.Location = new System.Drawing.Point(177, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(168, 37);
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
            this.btnPrevious.Location = new System.Drawing.Point(351, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(168, 37);
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
            this.btnNext.Location = new System.Drawing.Point(525, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(168, 37);
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
            this.btnLast.Location = new System.Drawing.Point(699, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(170, 37);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "หน้าสุดท้าย";
            this.btnLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // gridVisitorList
            // 
            this.gridVisitorList.AllowUserToAddRows = false;
            this.gridVisitorList.AllowUserToDeleteRows = false;
            this.gridVisitorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridVisitorList.BackgroundColor = System.Drawing.Color.White;
            this.gridVisitorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVisitorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IN});
            this.gridVisitorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVisitorList.Location = new System.Drawing.Point(3, 3);
            this.gridVisitorList.Name = "gridVisitorList";
            this.gridVisitorList.ReadOnly = true;
            this.gridVisitorList.RowTemplate.Height = 30;
            this.gridVisitorList.Size = new System.Drawing.Size(872, 503);
            this.gridVisitorList.TabIndex = 0;
            this.gridVisitorList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVisitorList_CellContentClick);
            // 
            // IN
            // 
            this.IN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IN.HeaderText = "เลือก";
            this.IN.Image = ((System.Drawing.Image)(resources.GetObject("IN.Image")));
            this.IN.Name = "IN";
            this.IN.ReadOnly = true;
            this.IN.Width = 60;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.gridVisitorList, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 100);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(878, 558);
            this.tableLayoutPanel3.TabIndex = 1;
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 512);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(872, 43);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 661);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 564F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtProjectName, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox1, 3, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(878, 91);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "ชื่อผู้รับผิดชอบ";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(535, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 31);
            this.textBox1.TabIndex = 9;
            // 
            // frmSelectConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectConstructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เลือกผู้รับเหมา";
            this.Load += new System.EventHandler(this.FrmSelectConstructor_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVisitorList)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.DataGridView gridVisitorList;
        private System.Windows.Forms.DataGridViewImageColumn IN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}