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
    public partial class Hóa_đơn_tiền_điện : Form
    {
        public Hóa_đơn_tiền_điện()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btntinhtien_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtcsm.Text, out double csMoi) || !double.TryParse(txtcsc.Text, out double csCu))
            {
                MessageBox.Show("Vui lòng nhập chỉ số mới và chỉ số cũ dạng số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (csMoi < csCu)
            {
                MessageBox.Show("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double soKw = csMoi - csCu;
            double donGia = 0;
            if (rdocn.Checked)
            {
                donGia = 5000;
            }
            else if (txtrdocq.Checked)
            {
                donGia = 6000;
            }
            double thanhTien = soKw * donGia;
            double thueVAT = thanhTien * 0.10;
            double tongCong = thanhTien + thueVAT;
            txtkw.Text = soKw.ToString();
            txttt.Text = thanhTien.ToString();
            txtvat.Text = thueVAT.ToString();
            txttc.Text = tongCong.ToString();
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            if (cbomk.Items.Count > 0)
                cbomk.SelectedIndex = -1;

            txttk.Clear();
            txtcsm.Clear();
            txtcsc.Clear();
            txtkw.Clear();
            txttt.Clear();
            txtvat.Clear();
            txttc.Clear();

            rdocn.Checked = true;
            cbomk.Focus();       
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
