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
    public partial class BaiTap5_C3 : Form
    {
        public BaiTap5_C3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                textBox2.Text = listBox1.Items.Count.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Xóa phần tử được chọn
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                textBox2.Text = listBox1.Items.Count.ToString();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phần tử để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(0);
                textBox2.Text = listBox1.Items.Count.ToString();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Danh sách trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                textBox2.Text = listBox1.Items.Count.ToString();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Danh sách trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
                textBox2.Text = listBox1.Items.Count.ToString();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Danh sách trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
