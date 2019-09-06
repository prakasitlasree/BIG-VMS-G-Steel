using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIG.VMS.PRESENT.Forms.CustomerVisit
{
    public partial class frmPlantVisit : PageBase
    {
        public frmPlantVisit()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void gridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == 0)
            {
                tabPurpose.SelectTab(0);
                tabPlantTour.Hide();
                tabPurchasing.Hide();
            }
            if (comboBox2.SelectedIndex == 1)
            {
                tabPurpose.SelectTab(1);
                tabPlantTour.Hide();
                tabDiscussion.Hide();
            }
            if (comboBox2.SelectedIndex == 2)
            {
                tabPurpose.SelectTab(2);
                tabDiscussion.Hide();
                tabPurchasing.Hide();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
