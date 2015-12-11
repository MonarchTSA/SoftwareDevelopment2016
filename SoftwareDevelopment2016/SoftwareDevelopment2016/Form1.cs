using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDevelopment2016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Data.Add(new DataPoint(-1,-1));
            ds.Data.Add(new DataPoint(0, 3));
            ds.Data.Add(new DataPoint(1, 2.5));
            ds.Data.Add(new DataPoint(2, 5));
            ds.Data.Add(new DataPoint(3, 4));
            ds.Data.Add(new DataPoint(5, 2));
            ds.Data.Add(new DataPoint(7, 5));
            ds.Data.Add(new DataPoint(9, 4));

            DataSet ds1 = new DataSet();
            ds1.Data.Add(new DataPoint(-1, -1));
            ds1.Data.Add(new DataPoint(0, 3));
            ds1.Data.Add(new DataPoint(1, 2.5));
            ds1.Data.Add(new DataPoint(2, 5));
            ds1.Data.Add(new DataPoint(3, 4));
            ds1.Data.Add(new DataPoint(5, 2));
            ds1.Data.Add(new DataPoint(7, 5));
            ds1.Data.Add(new DataPoint(9, 4));
            //ds1.CalculateNthPolynomialRegression(4);
            Console.WriteLine((from dp in ds1.Data from fdp in ds1.Data select dp.Y - fdp.Y).Sum());
            foreach(DataPoint dp in ds.Data)
            {

            }
            //label1.Text = "Clicked";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Data.Add(new DataPoint(-1, -1));
            ds.Data.Add(new DataPoint(0, 3));
            ds.Data.Add(new DataPoint(1, 2.5));
            ds.Data.Add(new DataPoint(2, 5));
            ds.Data.Add(new DataPoint(3, 4));
            ds.Data.Add(new DataPoint(5, 2));
            ds.Data.Add(new DataPoint(7, 5));
            ds.Data.Add(new DataPoint(9, 4));

            DataSet ds1 = new DataSet();
            ds1.Data.Add(new DataPoint(-1, 1));
            ds1.Data.Add(new DataPoint(0, 3));
            ds1.Data.Add(new DataPoint(1, 2.5));
            ds1.Data.Add(new DataPoint(2, 5));
            ds1.Data.Add(new DataPoint(3, 4));
            ds1.Data.Add(new DataPoint(5, 2));
            ds1.Data.Add(new DataPoint(7, 5));
            ds1.Data.Add(new DataPoint(9, 4));
            //ds1.CalculateNthPolynomialRegression(4);
            List<double> l = (from dp in ds1.Data from fdp in ds1.Data select dp.Y - fdp.Y).ToList();
            
            foreach (double d in l)
            {
                Console.Write(d + " ");
            }
            //label1.Text = "Clicked";
            

        }

        int zoom = 0;
        float xmin = 0;
        float xmax = 2 * (float)Math.PI;
        float ymin = -1;
        float ymax = 1;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = panel1.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            float xstep = (xmax - xmin) / panel1.Width;
            float ystep = (ymax - ymin) / panel1.Height;
            float xaxis = ymax / ystep;
            float yaxis = panel1.Width - xmax / xstep;
            PointF[] points = new PointF[panel1.Width];
            for(int i = 0; i < panel1.Width; ++i)
            {
                float functionValue =  (float)Math.Sin(i * xstep - xmax);
                graphics.DrawLine(new Pen(Color.Black, 1f), new PointF(yaxis, 0), new PointF(yaxis, panel1.Height));
                graphics.DrawLine(new Pen(Color.Black, 1f), new PointF(0, xaxis), new PointF(panel1.Width, xaxis));
                points[i] = new PointF(i,-1 + (float)(xaxis - functionValue / ystep));
            }
            graphics.DrawLines(new Pen(Color.Black, 1f), points);
        }

        private void buttonZoom(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text == "+")
            {
                --xmin;
                ++xmax;
                --ymin;
                ++ymax;
            }
            else
            {
                ++xmin;
                --xmax;
                ++ymin;
                --ymax;
            }
            panel1.Refresh();
        }
    }
}
