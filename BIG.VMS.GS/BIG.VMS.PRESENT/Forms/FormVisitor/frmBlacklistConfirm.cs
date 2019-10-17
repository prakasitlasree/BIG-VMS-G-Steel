using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIG.VMS.PRESENT.Forms.FormVisitor
{
    public partial class frmBlacklistConfirm : PageBase
    {

        public frmBlacklistConfirm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == PASSWORD)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("รหัสผ่านไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBlacklistConfirm_Load(object sender, EventArgs e)
        {
            lbUser.Text = LOGIN;
        }
    }
}
