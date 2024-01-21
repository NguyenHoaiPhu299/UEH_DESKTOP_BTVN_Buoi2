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
    public partial class Form1 : Form
    {
        private Point pA;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) // MouseDown
        {
            pA = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) // MouseMove
        {
            string s = $"Toa do: {e.X} - {e.Y}";
            label1.Text = s;
            /*if (e.Button == MouseButtons.Left)
            {
                Graphics g = this.CreateGraphics();
                Pen pen = new Pen(Color.Red, 2f);
                g.DrawLine(pen, pA, e.Location);
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        /*
         Khi mouse move không vẽ vào màn hình mà chỉ là 1
        đường ảo. Khi mouse up sẽ vẽ 1 đường từ điểm nhấn
        chuột đến chỗ thả chuột giống chức năng vẽ đường
        thẳng trong MS Paint.
         */
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2f);
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(pen, pA, e.Location);
            }
        }
    }
}
