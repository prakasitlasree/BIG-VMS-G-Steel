namespace BIG.VMS.PRESENT.Forms.FormReportNew
{
    partial class frmSelectReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectReport));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnConstructor = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnNormal);
            this.flowLayoutPanel1.Controls.Add(this.btnAppointment);
            this.flowLayoutPanel1.Controls.Add(this.btnCustomer);
            this.flowLayoutPanel1.Controls.Add(this.btnConstructor);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(514, 282);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.SeaShell;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.Location = new System.Drawing.Point(3, 3);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(250, 134);
            this.btnNormal.TabIndex = 0;
            this.btnNormal.Tag = "ID_CARD";
            this.btnNormal.Text = "รายงานบุคคลภายนอก";
            this.btnNormal.UseVisualStyleBackColor = false;
            // 
            // btnAppointment
            // 
            this.btnAppointment.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.Location = new System.Drawing.Point(259, 3);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(250, 134);
            this.btnAppointment.TabIndex = 1;
            this.btnAppointment.Tag = "DRIVER";
            this.btnAppointment.Text = "รายงานนัดหมาย\r\nบุคคลภายนอก";
            this.btnAppointment.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(3, 143);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(250, 134);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Tag = "OTHER";
            this.btnCustomer.Text = "รายงานกลุ่มลูกค้า";
            this.btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnConstructor
            // 
            this.btnConstructor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnConstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConstructor.Location = new System.Drawing.Point(259, 143);
            this.btnConstructor.Name = "btnConstructor";
            this.btnConstructor.Size = new System.Drawing.Size(250, 134);
            this.btnConstructor.TabIndex = 3;
            this.btnConstructor.Tag = "OTHER";
            this.btnConstructor.Text = "รายงานผู้รับเหมา";
            this.btnConstructor.UseVisualStyleBackColor = false;
            // 
            // frmSelectReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 314);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectReport";
            this.Text = "ประเภทรายงาน";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnConstructor;
    }
}