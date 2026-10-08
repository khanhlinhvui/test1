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
    public partial class bai_5B : Form
    {
        public bai_5B()
        {
            InitializeComponent();
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtnsn.Text, out int value))
            {
                lstDaySo.Items.Add(value);
                txtnsn.Clear();
                txtnsn.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDaySo.Items.Count; i++)
            {
                int val = Convert.ToInt32(lstDaySo.Items[i]);
                lstDaySo.Items[i] = val + 2;
            }
        }

        private void btncsd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDaySo.Items.Count; i++)
            {
                int val = Convert.ToInt32(lstDaySo.Items[i]);
                if (val % 2 == 0)
                {
                    lstDaySo.SelectedIndex = i; // Chọn phần tử
                    return;
                }
            }
            MessageBox.Show("Không có số chẵn nào trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = lstDaySo.Items.Count - 1; i >= 0; i--)
            {
                int val = Convert.ToInt32(lstDaySo.Items[i]);
                if (val % 2 != 0)
                {
                    lstDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số lẻ nào trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btndc_Click(object sender, EventArgs e)
        {
            if (lstDaySo.SelectedIndex != -1)
            {
                lstDaySo.Items.RemoveAt(lstDaySo.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phần tử cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnptd_Click(object sender, EventArgs e)
        {
            if (lstDaySo.Items.Count > 0)
            {
                lstDaySo.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Danh sách đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnptc_Click(object sender, EventArgs e)
        {
            if (lstDaySo.Items.Count > 0)
            {
                lstDaySo.Items.RemoveAt(lstDaySo.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Danh sách đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}

