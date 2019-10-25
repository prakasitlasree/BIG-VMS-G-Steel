namespace BIG.VMS.PRESENT.Forms.Contractor
{
    partial class frmContractor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContractor));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_FirstName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Lbl_IDCard = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.tableLayoutPanel4.Controls.Add(this.txtAddress, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.Lbl_IDCard, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtTel, 1, 2);
            this.tableLayoutPanel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(560, 229);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lbType
            // 
            this.lbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbType.Location = new System.Drawing.Point(132, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(425, 25);
            this.lbType.TabIndex = 21;
            this.lbType.Text = "เพิ่มผู้รับเหมา";
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
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(132, 28);
            this.txtName.MaxLength = 1000;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(425, 31);
            this.txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(132, 91);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(425, 77);
            this.txtAddress.TabIndex = 3;
            // 
            // Lbl_IDCard
            // 
            this.Lbl_IDCard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lbl_IDCard.AutoSize = true;
            this.Lbl_IDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDCard.ForeColor = System.Drawing.Color.Red;
            this.Lbl_IDCard.Location = new System.Drawing.Point(30, 62);
            this.Lbl_IDCard.Name = "Lbl_IDCard";
            this.Lbl_IDCard.Size = new System.Drawing.Size(96, 25);
            this.Lbl_IDCard.TabIndex = 1;
            this.Lbl_IDCard.Text = "เบอร์โทร *";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(66, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "ที่อยู่ *";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(132, 174);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTel
            // 
            this.txtTel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTel.Location = new System.Drawing.Point(132, 65);
            this.txtTel.Mask = "000-000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(425, 20);
            this.txtTel.TabIndex = 2;
            // 
            // frmContractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 253);
            this.Controls.Add(this.tableLayoutPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContractor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ผู้รับเหมา";
            this.Load += new System.EventHandler(this.frmContractor_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_FirstName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Lbl_IDCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox txtTel;
    }
}