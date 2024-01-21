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
    public partial class BaiTap4_C3 : Form
    {
        private List<string> SoThich = new List<string>();
        private List<string> Mau = new List<string>();
        public BaiTap4_C3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (string x in SoThich)
            {
                s += x + "\n";
            }
            MessageBox.Show("Sở thích của bạn là: " + s);
        }

        private void CheckBoxLike_CheckedChanged(object sender, EventArgs e)
        {
            Mau.Clear();
            SoThich.Clear();
            if (checkBox1.Checked == true) { SoThich.Add(checkBox1.Text); }
            if (checkBox2.Checked == true) { SoThich.Add(checkBox2.Text); }
            if (checkBox3.Checked == true) { SoThich.Add(checkBox3.Text); }
            if (checkBox4.Checked == true) { SoThich.Add(checkBox4.Text); }
            if (checkBox5.Checked == true) { SoThich.Add(checkBox5.Text); }
            if (checkBox6.Checked == true) { Mau.Add(checkBox6.Text); }
            if (checkBox7.Checked == true) { Mau.Add(checkBox7.Text); }
            if (checkBox8.Checked == true) { Mau.Add(checkBox8.Text); }
            if (checkBox9.Checked == true) { Mau.Add(checkBox9.Text); }
            if (checkBox10.Checked == true) { Mau.Add(checkBox10.Text); }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            SoThich.Clear();
            if (checkBox1.Checked == true) { SoThich.Add(checkBox1.Text); }
            if (checkBox2.Checked == true) { SoThich.Add(checkBox2.Text); }
            if (checkBox3.Checked == true) { SoThich.Add(checkBox3.Text); }
            if (checkBox4.Checked == true) { SoThich.Add(checkBox4.Text); }
            if (checkBox5.Checked == true) { SoThich.Add(checkBox5.Text); }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SoThich.Clear();
            if (checkBox1.Checked == true) { SoThich.Add(checkBox1.Text); }
            if (checkBox2.Checked == true) { SoThich.Add(checkBox2.Text); }
            if (checkBox3.Checked == true) { SoThich.Add(checkBox3.Text); }
            if (checkBox4.Checked == true) { SoThich.Add(checkBox4.Text); }
            if (checkBox5.Checked == true) { SoThich.Add(checkBox5.Text); }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SoThich.Clear();
            if (checkBox1.Checked == true) { SoThich.Add(checkBox1.Text); }
            if (checkBox2.Checked == true) { SoThich.Add(checkBox2.Text); }
            if (checkBox3.Checked == true) { SoThich.Add(checkBox3.Text); }
            if (checkBox4.Checked == true) { SoThich.Add(checkBox4.Text); }
            if (checkBox5.Checked == true) { SoThich.Add(checkBox5.Text); }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            SoThich.Clear();
            if (checkBox1.Checked == true) { SoThich.Add(checkBox1.Text); }
            if (checkBox2.Checked == true) { SoThich.Add(checkBox2.Text); }
            if (checkBox3.Checked == true) { SoThich.Add(checkBox3.Text); }
            if (checkBox4.Checked == true) { SoThich.Add(checkBox4.Text); }
            if (checkBox5.Checked == true) { SoThich.Add(checkBox5.Text); }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            SoThich.Clear();
            if (checkBox1.Checked == true) { SoThich.Add(checkBox1.Text); }
            if (checkBox2.Checked == true) { SoThich.Add(checkBox2.Text); }
            if (checkBox3.Checked == true) { SoThich.Add(checkBox3.Text); }
            if (checkBox4.Checked == true) { SoThich.Add(checkBox4.Text); }
            if (checkBox5.Checked == true) { SoThich.Add(checkBox5.Text); }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Mau.Clear();
            if (checkBox6.Checked == true) { Mau.Add(checkBox6.Text); }
            if (checkBox7.Checked == true) { Mau.Add(checkBox7.Text); }
            if (checkBox8.Checked == true) { Mau.Add(checkBox8.Text); }
            if (checkBox9.Checked == true) { Mau.Add(checkBox9.Text); }
            if (checkBox10.Checked == true) { Mau.Add(checkBox10.Text); }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            Mau.Clear();
            if (checkBox6.Checked == true) { Mau.Add(checkBox6.Text); }
            if (checkBox7.Checked == true) { Mau.Add(checkBox7.Text); }
            if (checkBox8.Checked == true) { Mau.Add(checkBox8.Text); }
            if (checkBox9.Checked == true) { Mau.Add(checkBox9.Text); }
            if (checkBox10.Checked == true) { Mau.Add(checkBox10.Text); }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            Mau.Clear();
            if (checkBox6.Checked == true) { Mau.Add(checkBox6.Text); }
            if (checkBox7.Checked == true) { Mau.Add(checkBox7.Text); }
            if (checkBox8.Checked == true) { Mau.Add(checkBox8.Text); }
            if (checkBox9.Checked == true) { Mau.Add(checkBox9.Text); }
            if (checkBox10.Checked == true) { Mau.Add(checkBox10.Text); }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Mau.Clear();
            if (checkBox6.Checked == true) { Mau.Add(checkBox6.Text); }
            if (checkBox7.Checked == true) { Mau.Add(checkBox7.Text); }
            if (checkBox8.Checked == true) { Mau.Add(checkBox8.Text); }
            if (checkBox9.Checked == true) { Mau.Add(checkBox9.Text); }
            if (checkBox10.Checked == true) { Mau.Add(checkBox10.Text); }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Mau.Clear();
            if (checkBox6.Checked == true) { Mau.Add(checkBox6.Text); }
            if (checkBox7.Checked == true) { Mau.Add(checkBox7.Text); }
            if (checkBox8.Checked == true) { Mau.Add(checkBox8.Text); }
            if (checkBox9.Checked == true) { Mau.Add(checkBox9.Text); }
            if (checkBox10.Checked == true) { Mau.Add(checkBox10.Text); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (string x in Mau)
            {
                s += x + "\n";
            }
            MessageBox.Show("Màu bạn thích là: " + s);
        }
    }
}
