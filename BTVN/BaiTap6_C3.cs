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
    public partial class BaiTap6_C3 : Form
    {
        public BaiTap6_C3()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                listBox1.Items.Add(textBox2.Text);
                textBox2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                float sum = 0;
                foreach (string x in listBox1.Items)
                {
                    sum += int.Parse(x);
                }
                MessageBox.Show($"Tổng các phần tử trong list là: {sum}");
            }    
            else
            {
                MessageBox.Show("Danh sách rỗng");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                listBox1.Items.RemoveAt(0);
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Danh sách rỗng");
            }    
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            string s = "";
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    s += (int.Parse(listBox1.Items[i].ToString()) + 2).ToString() + "\n";
                }
                MessageBox.Show(s);
            }
            else
            {
                MessageBox.Show("Danh sách rỗng");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s = "";
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    s += Math.Pow(int.Parse(listBox1.Items[i].ToString()),2).ToString() + "\n";
                }
                MessageBox.Show(s);
            }
            else
            {
                MessageBox.Show("Danh sách rỗng");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = "";
            if (listBox1.Items.Count > 0)
            {
                foreach (string x in listBox1.Items)
                {
                    if (int.Parse(x) % 2 == 0)
                    {
                        s += x + "\n";
                    }
                }
                MessageBox.Show($"Danh sách các phần tử chẵn là: {s}");
            }
            else
            {
                MessageBox.Show("Danh sách rỗng");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string s = "";
            if (listBox1.Items.Count > 0)
            {
                foreach (string x in listBox1.Items)
                {
                    if (int.Parse(x) % 2 == 1)
                    {
                        s += x + "\n";
                    }
                }
                MessageBox.Show($"Danh sách các phần tử lẻ là: {s}");
            }
            else
            {
                MessageBox.Show("Danh sách rỗng");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
