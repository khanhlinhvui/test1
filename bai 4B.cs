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
    public partial class bai_4B : Form
    {
        public bai_4B()
        {
            InitializeComponent();
        }

        private void rdoln_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txta.Text, out long a) || !long.TryParse(txtb.Text, out long b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho cả a và b!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rdoln.Checked)
            {
                long uscln = USCLN(a, b);
                txtkq.Text = uscln.ToString();
            }
            else if (rdonn.Checked)
            {
                long bscnn = BSCNN(a, b);
                txtkq.Text = bscnn.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chế độ USCLN hoặc BSCNN!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    }
        private long USCLN(long a, long b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                long temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        private long BSCNN(long a, long b)
        {
            if (a == 0 || b == 0) return 0;
            return Math.Abs(a * b) / USCLN(a, b);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
