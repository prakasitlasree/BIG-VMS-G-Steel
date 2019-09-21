namespace BIG.VMS.PRESENT.Forms.FormVisitorNew
{
    partial class frmSelectCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectCard));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIdCard = new System.Windows.Forms.Button();
            this.btnDriverCard = new System.Windows.Forms.Button();
            this.btnOtherCard = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnIdCard);
            this.flowLayoutPanel1.Controls.Add(this.btnDriverCard);
            this.flowLayoutPanel1.Controls.Add(this.btnOtherCard);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(768, 140);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnIdCard
            // 
            this.btnIdCard.BackColor = System.Drawing.Color.SeaShell;
            this.btnIdCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdCard.Location = new System.Drawing.Point(3, 3);
            this.btnIdCard.Name = "btnIdCard";
            this.btnIdCard.Size = new System.Drawing.Size(250, 134);
            this.btnIdCard.TabIndex = 0;
            this.btnIdCard.Tag = "ID_CARD";
            this.btnIdCard.Text = "บัตรประชาชน";
            this.btnIdCard.UseVisualStyleBackColor = false;
            this.btnIdCard.Click += new System.EventHandler(this.BtnIdCard_Click);
            // 
            // btnDriverCard
            // 
            this.btnDriverCard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDriverCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriverCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriverCard.Location = new System.Drawing.Point(259, 3);
            this.btnDriverCard.Name = "btnDriverCard";
            this.btnDriverCard.Size = new System.Drawing.Size(250, 134);
            this.btnDriverCard.TabIndex = 1;
            this.btnDriverCard.Tag = "DRIVER";
            this.btnDriverCard.Text = "ใบขับขี่";
            this.btnDriverCard.UseVisualStyleBackColor = false;
            this.btnDriverCard.Click += new System.EventHandler(this.BtnDriverCard_Click);
            // 
            // btnOtherCard
            // 
            this.btnOtherCard.BackColor = System.Drawing.SystemColors.Info;
            this.btnOtherCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherCard.Location = new System.Drawing.Point(515, 3);
            this.btnOtherCard.Name = "btnOtherCard";
            this.btnOtherCard.Size = new System.Drawing.Size(250, 134);
            this.btnOtherCard.TabIndex = 2;
            this.btnOtherCard.Tag = "OTHER";
            this.btnOtherCard.Text = "อิ่นๆ (ถ่ายรูปบัตร)";
            this.btnOtherCard.UseVisualStyleBackColor = false;
            this.btnOtherCard.Click += new System.EventHandler(this.BtnOtherCard_Click);
            // 
            // frmSelectCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 167);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เลือกประเภทบัตร";
            this.Load += new System.EventHandler(this.FrmSelectCard_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnIdCard;
        private System.Windows.Forms.Button btnDriverCard;
        private System.Windows.Forms.Button btnOtherCard;
    }
}