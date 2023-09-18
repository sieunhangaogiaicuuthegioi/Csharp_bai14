using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_bai14
{
    public partial class btnUSDtoVND : Form
    {
        public btnUSDtoVND()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sotien = Convert.ToDouble(txtTienQuiDoi.Text);
            txtKetQua.Text = Math.Round(sotien * 17861, 2).ToString();

        }

        private void txtTienQuiDoi_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "This is not avalid number  ");
            else
                this.errorProvider1.Clear();
        }

        private void btnVNDtoEUR_Click(object sender, EventArgs e)
        {
            double sotien = Convert.ToDouble(txtDoiTien.Text);
            txtDoiTien.Text = Math.Round(sotien * 27043, 2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sotien = Convert.ToDouble(txtDoiTien.Text);
            txtDoiTien.Text = Math.Round(sotien * 17861).ToString();
        }

        private void btnEURtoVND_Click(object sender, EventArgs e)
        {
            double sotien = Convert.ToDouble(txtDoiTien.Text);
            txtDoiTien.Text = Math.Round(sotien * 27043).ToString();
        }
    }
}
