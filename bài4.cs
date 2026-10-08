using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            double csDau = double.Parse(txtcsd.Text);
            double csCuoi = double.Parse(txtcsd.Text);
            if(csDau < csCuoi)
            {
                MessageBox.Show("chỉ số cuối phải lớn hơn hoặc bằng chỉ số đầu!");
                return;
            }
            double kWh = csCuoi - csDau;
            double tien = 0;
            if (kWh <= 100)
            {
                tien = kWh * 500;
            }
            else if (kWh <= 250)
            {
                tien = (100 * 500) + (kWh - 100) * 600;
            }
            else if (kWh <= 300)
            {
                tien = (100 * 500) + (150 * 600) + (kWh - 250) * 800;
            }
            else
            {
                tien = (100 * 500) + (150 * 600) + (50 * 800) + (kWh - 300) * 1000;
            }
            lblSoTien.Text = tien.ToString();
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txtcsd.Clear();
            txtcsc.Clear();
            lblSoTien.Text = "";
            txtcsd.Focus();
        }
    }
}
