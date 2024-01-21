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
    public partial class BaiTap3_C3 : Form
    {
        public BaiTap3_C3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_red.Checked == true)
            {
                txt_hoVaTen.ForeColor = Color.Red;
            }
        }

        private void rdbtn_green_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_green.Checked == true)
            {
                txt_hoVaTen.ForeColor = Color.Green;
            }
        }

        private void rdbtn_blue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_blue.Checked == true)
            {
                txt_hoVaTen.ForeColor = Color.Blue;
            }
        }

        private void rdbtn_black_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_black.Checked == true)
            {
                txt_hoVaTen.ForeColor = Color.Black;
            }
        }

        private void cb_bold_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            if (cb_bold.Checked)
                fontStyle |= FontStyle.Bold;

            if (cb_italic.Checked)
                fontStyle |= FontStyle.Italic;

            if (cb_underline.Checked)
                fontStyle |= FontStyle.Underline;

            // Áp dụng font mới cho TextBox
            txt_hoVaTen.Font = new Font(txt_hoVaTen.Font.FontFamily, txt_hoVaTen.Font.Size, fontStyle);
        }

        private void cb_italic_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            if (cb_bold.Checked)
                fontStyle |= FontStyle.Bold;

            if (cb_italic.Checked)
                fontStyle |= FontStyle.Italic;

            if (cb_underline.Checked)
                fontStyle |= FontStyle.Underline;

            // Áp dụng font mới cho TextBox
            txt_hoVaTen.Font = new Font(txt_hoVaTen.Font.FontFamily, txt_hoVaTen.Font.Size, fontStyle);
        }

        private void cb_underline_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            if (cb_bold.Checked)
                fontStyle |= FontStyle.Bold;

            if (cb_italic.Checked)
                fontStyle |= FontStyle.Italic;

            if (cb_underline.Checked)
                fontStyle |= FontStyle.Underline;

            // Áp dụng font mới cho TextBox
            txt_hoVaTen.Font = new Font(txt_hoVaTen.Font.FontFamily, txt_hoVaTen.Font.Size, fontStyle);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
