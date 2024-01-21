using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN
{
    public partial class BaiTap1_C3 : Form
    {
        private string hoVaTen;
        private string ten;
        private string hoVaTenDem;
        public BaiTap1_C3()
        {
            InitializeComponent();
        }

        private void BaiTap1_C3_Load(object sender, EventArgs e)
        {

        }

        private void lblTen_Click(object sender, EventArgs e)
        {

        }

        private void txtHoLot_TextChanged(object sender, EventArgs e)
        {
            this.hoVaTenDem = txtHoLot.Text;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            this.ten = txtTen.Text;
        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
            lblHoVaTen.Text = this.hoVaTenDem;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoVaTen.Text = this.ten;
        }

        private void btnHoVaTen_Click(object sender, EventArgs e)
        {
            this.hoVaTen = this.hoVaTenDem + " " + this.ten;
            lblHoVaTen.Text = this.hoVaTen;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
