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
    public partial class BaiTap7_C3 : Form
    {
        private string selectedClass;
        public BaiTap7_C3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Không hợp lệ");
                }
                else
                {
                    if (selectedClass == "Lớp A")
                    {
                        listBox1.Items.Add(textBox2.Text);
                    }
                    else if (selectedClass == "Lớp B")
                    {
                        listBox2.Items.Add(textBox2.Text);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn lớp");
                    }    
                    textBox2.Clear();
                }    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndex]);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phần tử để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox2.Items[listBox2.SelectedIndex]);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
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
                foreach (string item in listBox1.Items)
                {
                    listBox2.Items.Add(item);
                }
                listBox1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Danh sách trống");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                foreach (string item in listBox2.Items)
                {
                    listBox1.Items.Add(item);
                }
                listBox2.Items.Clear();
            }
            else
            {
                MessageBox.Show("Danh sách trống");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Xóa phần tử được chọn
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phần tử để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedClass = comboBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
