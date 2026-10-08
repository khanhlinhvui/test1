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
    public partial class bai_2B : Form
    {
        public bai_2B()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            try
            {
                double cSharp = double.Parse(txtltc.Text);
                double truyenThong = double.Parse(txtlttt.Text);
                double maNguonMo = double.Parse(txtmmn.Text);
                double quanTriMang = double.Parse(txtqtm.Text);
                if (cSharp < 0 || cSharp > 10 || truyenThong < 0 || truyenThong > 10 ||  maNguonMo < 0 || maNguonMo > 10 || quanTriMang < 0 || quanTriMang > 10)
                {
                    MessageBox.Show("Điểm số phải nằm trong khoảng từ 0 đến 10!", "Lỗi nhập liệu",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double dtb = (cSharp + truyenThong + maNguonMo + quanTriMang) / 4.0;
                txtdtb.Text = dtb.ToString();
                string xepLoai = "";
                if (dtb >= 8.0)
                {
                    xepLoai = "Giỏi";
                }
                else if (dtb >= 7.0)
                {
                    xepLoai = "Khá";
                }
                else if (dtb >= 5.0)
                {
                    xepLoai = "TB";
                }
                else
                {
                    xepLoai = "Yếu";
                }
                txtxl.Text = xepLoai;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng điểm số (kiểu số)!",
                                "Thông báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            txtmsv.Clear();
            txthvt.Clear();
            rdonam.Checked = true;
            txtltc.Clear();
            txtlttt.Clear();
            txtmmn.Clear();
            txtqtm.Clear();
            txtdtb.Clear();
            txtxl.Clear();
            txtmsv.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
