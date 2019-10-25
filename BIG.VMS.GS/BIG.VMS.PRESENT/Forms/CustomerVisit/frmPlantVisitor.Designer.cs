namespace BIG.VMS.PRESENT.Forms.CustomerVisit
{
    partial class frmPlantVisitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlantVisitor));
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_FirstName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numSeq = new System.Windows.Forms.NumericUpDown();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.Lbl_IDCard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeq)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lbType, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Lbl_FirstName, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.numSeq, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtLastname, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.Lbl_IDCard, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(18, 18);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(553, 228);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lbType
            // 
            this.lbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.Color.Red;
            this.lbType.Location = new System.Drawing.Point(135, 0);
            this.lbType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(414, 25);
            this.lbType.TabIndex = 21;
            this.lbType.Text = "เพิ่มลูกค้า";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "การทำรายการ";
            // 
            // Lbl_FirstName
            // 
            this.Lbl_FirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lbl_FirstName.AutoSize = true;
            this.Lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FirstName.ForeColor = System.Drawing.Color.Red;
            this.Lbl_FirstName.Location = new System.Drawing.Point(72, 33);
            this.Lbl_FirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_FirstName.Name = "Lbl_FirstName";
            this.Lbl_FirstName.Size = new System.Drawing.Size(55, 25);
            this.Lbl_FirstName.TabIndex = 0;
            this.Lbl_FirstName.Text = " ชื่อ *";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(135, 30);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.MaxLength = 1000;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 31);
            this.txtName.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(135, 153);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(323, 63);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(9, 10);
            this.btnSave.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 43);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "บันทึก";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SeaShell;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(171, 10);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 43);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // numSeq
            // 
            this.numSeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSeq.Location = new System.Drawing.Point(135, 112);
            this.numSeq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSeq.Name = "numSeq";
            this.numSeq.Size = new System.Drawing.Size(103, 31);
            this.numSeq.TabIndex = 22;
            // 
            // txtLastname
            // 
            this.txtLastname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(135, 71);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastname.MaxLength = 1000;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(286, 31);
            this.txtLastname.TabIndex = 24;
            // 
            // Lbl_IDCard
            // 
            this.Lbl_IDCard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lbl_IDCard.AutoSize = true;
            this.Lbl_IDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_IDCard.Location = new System.Drawing.Point(72, 115);
            this.Lbl_IDCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IDCard.Name = "Lbl_IDCard";
            this.Lbl_IDCard.Size = new System.Drawing.Size(55, 25);
            this.Lbl_IDCard.TabIndex = 1;
            this.Lbl_IDCard.Text = "ลำดับ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(29, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "นามสกุล * ";
            // 
            // frmPlantVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlantVisitor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visitor";
            this.Load += new System.EventHandler(this.FrmPlantVisitor_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSeq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_FirstName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label Lbl_IDCard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numSeq;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label1;
    }
}