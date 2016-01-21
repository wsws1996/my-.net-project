using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 使用gdi绘制简单的图形
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Red);
            Point p1 = new Point(30, 50);
            Point p2 = new Point(250, 250);
            g.DrawLine(pen, p1, p2);
        }
        int i = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Brushes.Black);
            Rectangle rec = new Rectangle(50, 50, 80, 80);
            g.DrawRectangle(p, rec);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Brushes.Blue);
            Rectangle rec = new Rectangle(50, 50, 180, 180);
            g.DrawPie(p, rec, 60, 60);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawString("啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊", new Font("宋体", 20, FontStyle.Underline), Brushes.Black, new Point(70, 70));
        }
    }
}
