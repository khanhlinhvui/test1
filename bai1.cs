using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtbk.Text, out double r))
            {
                if (r > 0)
                {
                    double chuVi = 2 * Math.PI * r;
                    double dienTich = Math.PI * Math.Pow(r, 2);
                    txtcv.Text = chuVi.ToString();
                    txtdt.Text = dienTich.ToString();
                }
                else
                {
                    MessageBox.Show("bán kính phải lớn hơn 0!", "lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbk.Focus();
                }
            }
            else
            {
                MessageBox.Show("vui lòng nhập bán kính là một số hợp lệ!", "lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbk.Focus();
            }
        }

        private void bntll_Click(object sender, EventArgs e)
        {
            txtbk.Clear();
            txtcv.Clear();
            txtdt.Clear();
            txtbk.Focus();
        }
    }
}
