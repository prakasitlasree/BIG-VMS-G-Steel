namespace BIG.VMS.PRESENT.Forms.Contractor
{
    partial class frmConstractorEmpList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConstractorEmpList));
            this.gridProjectMember = new System.Windows.Forms.DataGridView();
            this.SELECT = new System.Windows.Forms.DataGridViewImageColumn();
            this.AUTO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARD_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FULLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjectMember)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProjectMember
            // 
            this.gridProjectMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridProjectMember.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridProjectMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProjectMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECT,
            this.AUTO_ID,
            this.CARD_TYPE,
            this.FULLNAME,
            this.ID_CARD,
            this.POSITION});
            this.gridProjectMember.Location = new System.Drawing.Point(11, 12);
            this.gridProjectMember.Name = "gridProjectMember";
            this.gridProjectMember.RowTemplate.Height = 30;
            this.gridProjectMember.Size = new System.Drawing.Size(863, 409);
            this.gridProjectMember.TabIndex = 0;
            this.gridProjectMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProjectMember_CellContentClick);
            // 
            // SELECT
            // 
            this.SELECT.HeaderText = "เลือก";
            this.SELECT.Image = ((System.Drawing.Image)(resources.GetObject("SELECT.Image")));
            this.SELECT.Name = "SELECT";
            this.SELECT.Width = 49;
            // 
            // AUTO_ID
            // 
            this.AUTO_ID.DataPropertyName = "AUTO_ID";
            this.AUTO_ID.HeaderText = "AUTO_ID";
            this.AUTO_ID.Name = "AUTO_ID";
            this.AUTO_ID.Visible = false;
            this.AUTO_ID.Width = 115;
            // 
            // CARD_TYPE
            // 
            this.CARD_TYPE.DataPropertyName = "CARD_TYPE";
            this.CARD_TYPE.HeaderText = "บัตร";
            this.CARD_TYPE.Name = "CARD_TYPE";
            this.CARD_TYPE.Width = 65;
            // 
            // FULLNAME
            // 
            this.FULLNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FULLNAME.DataPropertyName = "FULLNAME";
            this.FULLNAME.HeaderText = "ชื่อ-นามสกุล";
            this.FULLNAME.Name = "FULLNAME";
            // 
            // ID_CARD
            // 
            this.ID_CARD.DataPropertyName = "ID_CARD";
            this.ID_CARD.HeaderText = "รหัสบัตรประชาชน";
            this.ID_CARD.Name = "ID_CARD";
            this.ID_CARD.Width = 165;
            // 
            // POSITION
            // 
            this.POSITION.DataPropertyName = "POSITION";
            this.POSITION.HeaderText = "ตำแหน่ง";
            this.POSITION.Name = "POSITION";
            this.POSITION.Width = 96;
            // 
            // frmConstractorEmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 432);
            this.Controls.Add(this.gridProjectMember);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmConstractorEmpList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "รายชื่อพนักงาน";
            this.Load += new System.EventHandler(this.FrmConstractorEmpList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProjectMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProjectMember;
        private System.Windows.Forms.DataGridViewImageColumn SELECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARD_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CARD;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSITION;
    }
}