namespace BIG.VMS.PRESENT.Forms.FormVisitor
{
    partial class frmSelectInType
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInWithOutCard = new System.Windows.Forms.Button();
            this.btnInCard = new System.Windows.Forms.Button();
            this.id_card = new System.Windows.Forms.PictureBox();
            this.other_card = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_card)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnInWithOutCard, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInCard, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.id_card, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.other_card, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 11);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 329);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnInWithOutCard
            // 
            this.btnInWithOutCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInWithOutCard.AutoEllipsis = true;
            this.btnInWithOutCard.BackColor = System.Drawing.Color.LightGreen;
            this.btnInWithOutCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInWithOutCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInWithOutCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInWithOutCard.ForeColor = System.Drawing.Color.Black;
            this.btnInWithOutCard.Location = new System.Drawing.Point(352, 2);
            this.btnInWithOutCard.Margin = new System.Windows.Forms.Padding(2);
            this.btnInWithOutCard.Name = "btnInWithOutCard";
            this.btnInWithOutCard.Size = new System.Drawing.Size(346, 94);
            this.btnInWithOutCard.TabIndex = 1;
            this.btnInWithOutCard.Text = "เข้าโดยถ่ายรูปบัตร";
            this.btnInWithOutCard.UseVisualStyleBackColor = false;
            this.btnInWithOutCard.Click += new System.EventHandler(this.btnInWithOutCard_Click);
            // 
            // btnInCard
            // 
            this.btnInCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInCard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInCard.ForeColor = System.Drawing.Color.Black;
            this.btnInCard.Location = new System.Drawing.Point(2, 2);
            this.btnInCard.Margin = new System.Windows.Forms.Padding(2);
            this.btnInCard.Name = "btnInCard";
            this.btnInCard.Size = new System.Drawing.Size(346, 94);
            this.btnInCard.TabIndex = 0;
            this.btnInCard.Text = "อ่านบัตรประชาชน/ใบขับขี่ี";
            this.btnInCard.UseVisualStyleBackColor = false;
            this.btnInCard.Click += new System.EventHandler(this.btnInCard_Click);
            // 
            // id_card
            // 
            this.id_card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.id_card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id_card.Image = global::BIG.VMS.PRESENT.Properties.Resources.idcard_template;
            this.id_card.Location = new System.Drawing.Point(3, 101);
            this.id_card.Name = "id_card";
            this.id_card.Size = new System.Drawing.Size(344, 225);
            this.id_card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.id_card.TabIndex = 2;
            this.id_card.TabStop = false;
            this.id_card.Click += new System.EventHandler(this.id_card_Click);
            // 
            // other_card
            // 
            this.other_card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.other_card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.other_card.Image = global::BIG.VMS.PRESENT.Properties.Resources.sso_card;
            this.other_card.Location = new System.Drawing.Point(353, 101);
            this.other_card.Name = "other_card";
            this.other_card.Size = new System.Drawing.Size(344, 225);
            this.other_card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.other_card.TabIndex = 3;
            this.other_card.TabStop = false;
            this.other_card.Click += new System.EventHandler(this.other_card_Click);
            // 
            // frmSelectInType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectInType";
            this.ShowIcon = false;
            this.Text = "เลือกวิธีเข้า";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.id_card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_card)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnInWithOutCard;
        private System.Windows.Forms.Button btnInCard;
        private System.Windows.Forms.PictureBox id_card;
        private System.Windows.Forms.PictureBox other_card;
    }
}