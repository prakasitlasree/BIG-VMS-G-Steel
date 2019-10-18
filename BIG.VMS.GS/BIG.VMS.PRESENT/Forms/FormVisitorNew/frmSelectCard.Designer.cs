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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIdCard = new System.Windows.Forms.Button();
            this.pb_card = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pb_driving = new System.Windows.Forms.PictureBox();
            this.btnDriverCard = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pb_capturecard = new System.Windows.Forms.PictureBox();
            this.btnOtherCard = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_card)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_driving)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_capturecard)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 331);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnIdCard, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pb_card, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(258, 323);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnIdCard
            // 
            this.btnIdCard.BackColor = System.Drawing.Color.LimeGreen;
            this.btnIdCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIdCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdCard.Location = new System.Drawing.Point(4, 4);
            this.btnIdCard.Name = "btnIdCard";
            this.btnIdCard.Size = new System.Drawing.Size(250, 122);
            this.btnIdCard.TabIndex = 0;
            this.btnIdCard.Tag = "ID_CARD";
            this.btnIdCard.Text = "(1) อ่านบัตรประชาชน";
            this.btnIdCard.UseVisualStyleBackColor = false;
            this.btnIdCard.Click += new System.EventHandler(this.BtnIdCard_Click);
            // 
            // pb_card
            // 
            this.pb_card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_card.Image = ((System.Drawing.Image)(resources.GetObject("pb_card.Image")));
            this.pb_card.Location = new System.Drawing.Point(4, 133);
            this.pb_card.Name = "pb_card";
            this.pb_card.Size = new System.Drawing.Size(250, 186);
            this.pb_card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_card.TabIndex = 1;
            this.pb_card.TabStop = false;
            this.pb_card.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pb_driving, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDriverCard, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(267, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(258, 323);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // pb_driving
            // 
            this.pb_driving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_driving.Image = ((System.Drawing.Image)(resources.GetObject("pb_driving.Image")));
            this.pb_driving.Location = new System.Drawing.Point(4, 133);
            this.pb_driving.Name = "pb_driving";
            this.pb_driving.Size = new System.Drawing.Size(250, 186);
            this.pb_driving.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_driving.TabIndex = 2;
            this.pb_driving.TabStop = false;
            this.pb_driving.Click += new System.EventHandler(this.pb_driving_Click);
            // 
            // btnDriverCard
            // 
            this.btnDriverCard.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDriverCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDriverCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriverCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriverCard.Location = new System.Drawing.Point(4, 4);
            this.btnDriverCard.Name = "btnDriverCard";
            this.btnDriverCard.Size = new System.Drawing.Size(250, 122);
            this.btnDriverCard.TabIndex = 1;
            this.btnDriverCard.Tag = "DRIVER";
            this.btnDriverCard.Text = "(2) อ่านใบขับขี่";
            this.btnDriverCard.UseVisualStyleBackColor = false;
            this.btnDriverCard.Click += new System.EventHandler(this.BtnDriverCard_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.pb_capturecard, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnOtherCard, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(531, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(258, 323);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // pb_capturecard
            // 
            this.pb_capturecard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_capturecard.Image = ((System.Drawing.Image)(resources.GetObject("pb_capturecard.Image")));
            this.pb_capturecard.Location = new System.Drawing.Point(4, 133);
            this.pb_capturecard.Name = "pb_capturecard";
            this.pb_capturecard.Size = new System.Drawing.Size(250, 186);
            this.pb_capturecard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_capturecard.TabIndex = 3;
            this.pb_capturecard.TabStop = false;
            this.pb_capturecard.Click += new System.EventHandler(this.pb_capturecard_Click);
            // 
            // btnOtherCard
            // 
            this.btnOtherCard.BackColor = System.Drawing.Color.Crimson;
            this.btnOtherCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOtherCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherCard.Location = new System.Drawing.Point(4, 4);
            this.btnOtherCard.Name = "btnOtherCard";
            this.btnOtherCard.Size = new System.Drawing.Size(250, 122);
            this.btnOtherCard.TabIndex = 2;
            this.btnOtherCard.Tag = "OTHER";
            this.btnOtherCard.Text = "(3) ถ่ายรูปบัตรทดแทน";
            this.btnOtherCard.UseVisualStyleBackColor = false;
            this.btnOtherCard.Click += new System.EventHandler(this.BtnOtherCard_Click);
            // 
            // frmSelectCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 369);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_card)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_driving)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_capturecard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnIdCard;
        private System.Windows.Forms.Button btnDriverCard;
        private System.Windows.Forms.Button btnOtherCard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pb_card;
        private System.Windows.Forms.PictureBox pb_driving;
        private System.Windows.Forms.PictureBox pb_capturecard;
    }
}