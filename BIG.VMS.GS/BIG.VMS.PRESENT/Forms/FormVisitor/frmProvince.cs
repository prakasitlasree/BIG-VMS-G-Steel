using BIG.VMS.DATASERVICE;
using BIG.VMS.MODEL.CustomModel;
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
    public partial class frmProvince : Form
    {
        private ComboBoxServices _comboService = new ComboBoxServices();
        public int SELECTED_PROVINCE_ID { get; set; }
        public string SELECTED_PROVINCE_TEXT { get; set; }
        public List<ComboBoxItem> listProvince = new List<ComboBoxItem>();

        public frmProvince()
        {
            InitializeComponent();
        }

        private void frmProvince_Load(object sender, EventArgs e)
        {
            InitialProvince();
        }

        private void InitialProvince()
        {

            int fontSize = 12;
            listProvince = _comboService.GetComboProvince();
            //var province = _comboService.GetComboProvince();
            var provincePriority = _comboService.GetComboProvincePriority();
            for (int i = 0; i < provincePriority.Count; i++)
            {
                Button btn = new Button();
                //btn.Dock = DockStyle.Left;
                btn.Width = 100;
                btn.Height = 100;
                btn.Font = new Font(btn.Font.FontFamily, fontSize);
                btn.BackColor = Color.FromArgb(255, 204, 229);
                btn.Text = provincePriority[i].Text;
                btn.Tag = provincePriority[i].Value;

                flowTop.Controls.Add(btn);
                btn.Click += new EventHandler(ProvinceSelected_EventHadler);
            }

            for (int i = 0; i < listProvince.Count; i++)
            {

                Button btn = new Button();
                //btn.Dock = DockStyle.Left;
                btn.Width = 100;
                btn.Height = 100;
                btn.Font = new Font(btn.Font.FontFamily, fontSize);
                btn.BackColor = Color.FromArgb(240, 248, 255);
                btn.Text = listProvince[i].Text;
                btn.Tag = listProvince[i].Value;

                flowProvince.Controls.Add(btn);
                btn.Click += new EventHandler(ProvinceSelected_EventHadler);

            }


        }

        private void SearchProvince(string filter)
        {
            flowProvince.Controls.Clear();

            var provinceFilter = listProvince.Where(o => o.Text.Contains(filter)).OrderBy(o => o.Text).ToList();
            int fontSize = 12;
            //var province = _comboService.GetComboProvince(filter);

            for (int i = 0; i < provinceFilter.Count; i++)
            {

                Button btn = new Button();
                //btn.Dock = DockStyle.Left;
                btn.Width = 100;
                btn.Height = 100;
                btn.Font = new Font(btn.Font.FontFamily, fontSize);
                btn.BackColor = Color.FromArgb(240, 248, 255);
                btn.Text = provinceFilter[i].Text;
                btn.Tag = provinceFilter[i].Value;
                btn.FlatStyle = FlatStyle.Flat;
                flowProvince.Controls.Add(btn);
                btn.Click += new EventHandler(ProvinceSelected_EventHadler);


            }


        }

        private void txtProvice_TextChanged(object sender, EventArgs e)
        {
            SearchProvince(txtProvice.Text);
        }

        private void ProvinceSelected_EventHadler(object sender, EventArgs e)
        {
            SELECTED_PROVINCE_ID = Convert.ToInt32(((Control)sender).Tag.ToString());
            SELECTED_PROVINCE_TEXT = ((Control)sender).Text.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();

        }


    }
}
