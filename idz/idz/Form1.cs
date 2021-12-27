using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idz
{

    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;

        Random random = new Random();
        Pen pen = new Pen(Color.Black, 2);

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

        }
        void drawCircel(int count)
        {
            drawCircel(count, new Point(0, 0), new Point(random.Next(bitmap.Width), random.Next(bitmap.Height)));
        }
        void drawCircel(int count, Point point1, Point point2)
        {
            int radius = 10;
            int diametr = radius * 2 ;
            
            if(count  == 0)
            {
                return;
            }
            graphics.DrawLine(pen, point1, point2);
            graphics.DrawEllipse(pen, point2.X - radius , point2.Y - radius, diametr, diametr);
            drawCircel(count - 1, point2, new Point(random.Next(bitmap.Width), random.Next(bitmap.Height)));
            drawCircel(count - 1, point2, new Point(random.Next(bitmap.Width), random.Next(bitmap.Height)));
            pictureBox1.Image = bitmap;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox1.Text);
            drawCircel(count);
        }
    }
}
