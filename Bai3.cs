using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2_nguyễn_khánh_linh
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void bntDongY_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(txtHKI.Text, out double hKI)||hKI<0 ||hKI>10)
            {
                MessageBox.Show("vui lòng nhập điểm HKI hợp lệ(từ 0 đến 10)!", "lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHKI.Focus();
                return;
            }
            if (!double.TryParse(txtHKII.Text,out double hKII)||hKII<0 ||hKII>10)
            {
                MessageBox.Show("vui lòng nhập điểm HKII hợp lệ(từ 0 đến 10)!", "lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHKII.Focus();
                return;
            }
            double dtb = (hKI + hKII * 2) / 3.0;
            string xepLoai = "";
            if(dtb >=8.0)
            {
                xepLoai = "Giỏi";
            }
            else if(dtb >=6.5)
            {
                xepLoai = "Khá";
            }
            else if(dtb >=5.0)
            {
                xepLoai = "Trung bình";
            }
            else
            {
                xepLoai = "Yếu";
            }
            txtXL.Text = xepLoai;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtHKI.Clear();
            txtHKII.Clear();
            txtXL.Clear();
            txtHKI.Focus();
        }
    }
}
