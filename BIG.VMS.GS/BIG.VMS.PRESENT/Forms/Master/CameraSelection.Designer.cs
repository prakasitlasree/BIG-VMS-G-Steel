namespace BIG.VMS.PRESENT.Forms.Master
{
    partial class CameraSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraSelection));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.imgCurrentImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.btnCapture = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.videoResolutionsCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.snapshotResolutionsCombo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCurrentImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.imgCurrentImage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCapture, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(779, 428);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Cancel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_OK, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(391, 338);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(386, 88);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Cancel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(195, 17);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(150, 53);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "(3) ยกเลิก";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_OK.BackColor = System.Drawing.Color.Blue;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OK.Location = new System.Drawing.Point(41, 17);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(150, 53);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "(2) ตกลง";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // imgCurrentImage
            // 
            this.imgCurrentImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.imgCurrentImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imgCurrentImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCurrentImage.Location = new System.Drawing.Point(417, 43);
            this.imgCurrentImage.Margin = new System.Windows.Forms.Padding(2);
            this.imgCurrentImage.Name = "imgCurrentImage";
            this.imgCurrentImage.Size = new System.Drawing.Size(334, 291);
            this.imgCurrentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCurrentImage.TabIndex = 9;
            this.imgCurrentImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.videoSourcePlayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 291);
            this.panel1.TabIndex = 13;
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.videoSourcePlayer.ForeColor = System.Drawing.Color.DarkRed;
            this.videoSourcePlayer.Location = new System.Drawing.Point(4, 3);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(378, 284);
            this.videoSourcePlayer.TabIndex = 12;
            this.videoSourcePlayer.VideoSource = null;
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCapture.BackColor = System.Drawing.Color.Green;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCapture.Location = new System.Drawing.Point(119, 353);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(150, 57);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.Text = "(1) บันทึกรูปภาพ";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "ตัวอย่างรูปถ่ายปัจจุบัน";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.videoResolutionsCombo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.snapshotResolutionsCombo, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(385, 37);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.Location = new System.Drawing.Point(195, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Snap resolution:";
            // 
            // videoResolutionsCombo
            // 
            this.videoResolutionsCombo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.videoResolutionsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoResolutionsCombo.FormattingEnabled = true;
            this.videoResolutionsCombo.Location = new System.Drawing.Point(99, 8);
            this.videoResolutionsCombo.Name = "videoResolutionsCombo";
            this.videoResolutionsCombo.Size = new System.Drawing.Size(90, 21);
            this.videoResolutionsCombo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Video resoluton:";
            // 
            // snapshotResolutionsCombo
            // 
            this.snapshotResolutionsCombo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.snapshotResolutionsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.snapshotResolutionsCombo.FormattingEnabled = true;
            this.snapshotResolutionsCombo.Location = new System.Drawing.Point(291, 8);
            this.snapshotResolutionsCombo.Name = "snapshotResolutionsCombo";
            this.snapshotResolutionsCombo.Size = new System.Drawing.Size(91, 21);
            this.snapshotResolutionsCombo.TabIndex = 7;
            // 
            // CameraSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 428);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CameraSelection";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ถ่ายรูป";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraSelection_FormClosing);
            this.Load += new System.EventHandler(this.CameraSelection_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCurrentImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgCurrentImage;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox videoResolutionsCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox snapshotResolutionsCombo;
    }
}