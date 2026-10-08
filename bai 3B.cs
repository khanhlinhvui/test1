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
    public partial class bai_3B : Form
    {
        public bai_3B()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {

        }
            private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {

                int soLuong = int.Parse(txtslv.Text);
                double donGia = double.Parse(txtdg.Text);


                if (soLuong <= 0 || donGia <= 0)
                {
                    MessageBox.Show("Số lượng và Đơn giá phải lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double thanhTien = soLuong * donGia;
                double vat = 0.10 * thanhTien;


                double phamTramGiam = rdocn.Checked ? 0.03 : 0.05;
                double giamGia = phamTramGiam * thanhTien;

                double tongCong = (thanhTien + vat) - giamGia;
                txttt.Text = thanhTien.ToString("#,##0");
                txtvat.Text = vat.ToString("#,##0");
                txtgg.Text = giamGia.ToString("#,##0");
                txttc.Text = tongCong.ToString("#,##0");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho Số lượng vé và Đơn giá!", "Thông báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntiep_Click(object sender, EventArgs e)
        {
            txttkh.Clear();
            txtdc.Text = "";
            txtslv.Clear();
            txtdg.Clear();


            rdocn.Checked = true;


            txttt.Clear();
            txtvat.Clear();
            txtgg.Clear();


            txttkh.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}