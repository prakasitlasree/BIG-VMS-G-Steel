namespace BIG.VMS.PRESENT.Forms.Employee
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_FirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.Lbl_IDCard = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.comboDept = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radShow = new System.Windows.Forms.RadioButton();
            this.radNotShow = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numSeq = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.lbType, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Lbl_FirstName, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtFirstName, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.Lbl_IDCard, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtLastName, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.comboDept, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel2, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.numSeq, 1, 4);
            this.tableLayoutPanel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(560, 268);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lbType
            // 
            this.lbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbType.AutoSize = true;
            this.lbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbType.Location = new System.Drawing.Point(132, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(425, 25);
            this.lbType.TabIndex = 21;
            this.lbType.Text = "เพิ่มพนักงาน";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 0);
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
            this.Lbl_FirstName.Location = new System.Drawing.Point(77, 31);
            this.Lbl_FirstName.Name = "Lbl_FirstName";
            this.Lbl_FirstName.Size = new System.Drawing.Size(49, 25);
            this.Lbl_FirstName.TabIndex = 0;
            this.Lbl_FirstName.Text = "ชื่อ *";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(132, 28);
            this.txtFirstName.MaxLength = 1000;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(425, 31);
            this.txtFirstName.TabIndex = 1;
            // 
            // Lbl_IDCard
            // 
            this.Lbl_IDCard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lbl_IDCard.AutoSize = true;
            this.Lbl_IDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDCard.ForeColor = System.Drawing.Color.Red;
            this.Lbl_IDCard.Location = new System.Drawing.Point(34, 68);
            this.Lbl_IDCard.Name = "Lbl_IDCard";
            this.Lbl_IDCard.Size = new System.Drawing.Size(92, 25);
            this.Lbl_IDCard.TabIndex = 1;
            this.Lbl_IDCard.Text = "นามสกุล *";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(66, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "แผนก";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(132, 196);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(264, 49);
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
            this.btnSave.Location = new System.Drawing.Point(6, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 37);
            this.btnSave.TabIndex = 4;
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
            this.btnCancel.Location = new System.Drawing.Point(138, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 37);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "ปิด";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(132, 65);
            this.txtLastName.MaxLength = 1000;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(425, 31);
            this.txtLastName.TabIndex = 1;
            // 
            // comboDept
            // 
            this.comboDept.FormattingEnabled = true;
            this.comboDept.Location = new System.Drawing.Point(132, 102);
            this.comboDept.Name = "comboDept";
            this.comboDept.Size = new System.Drawing.Size(425, 33);
            this.comboDept.TabIndex = 22;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.radShow);
            this.flowLayoutPanel2.Controls.Add(this.radNotShow);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(132, 155);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(320, 35);
            this.flowLayoutPanel2.TabIndex = 23;
            // 
            // radShow
            // 
            this.radShow.AutoSize = true;
            this.radShow.Checked = true;
            this.radShow.Location = new System.Drawing.Point(3, 3);
            this.radShow.Name = "radShow";
            this.radShow.Size = new System.Drawing.Size(143, 29);
            this.radShow.TabIndex = 0;
            this.radShow.TabStop = true;
            this.radShow.Text = "แสดงพนักงาน";
            this.radShow.UseVisualStyleBackColor = true;
            // 
            // radNotShow
            // 
            this.radNotShow.AutoSize = true;
            this.radNotShow.Location = new System.Drawing.Point(152, 3);
            this.radNotShow.Name = "radNotShow";
            this.radNotShow.Size = new System.Drawing.Size(165, 29);
            this.radNotShow.TabIndex = 1;
            this.radNotShow.Text = "ไม่แสดงพนักงาน";
            this.radNotShow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "ลำดับที่แสดง";
            // 
            // numSeq
            // 
            this.numSeq.Location = new System.Drawing.Point(132, 129);
            this.numSeq.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numSeq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSeq.Name = "numSeq";
            this.numSeq.Size = new System.Drawing.Size(126, 31);
            this.numSeq.TabIndex = 25;
            this.numSeq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 297);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "พนักงาน";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_FirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label Lbl_IDCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox comboDept;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radShow;
        private System.Windows.Forms.RadioButton radNotShow;
        private System.Windows.Forms.NumericUpDown numSeq;
    }
}