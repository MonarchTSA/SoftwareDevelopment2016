using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDevelopment2016
{
    public partial class FormMain : Form
    {
        public List<DataSet> dataSets;

        public FormMain()
        {
            dataSets = new List<DataSet>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NumericalDataSet ds = new NumericalDataSet("test");
            ds.Data.Add(new NumericPoint(-1,-1));
            ds.Data.Add(new NumericPoint(0, 3));
            ds.Data.Add(new NumericPoint(1, 2.5));
            ds.Data.Add(new NumericPoint(2, 5));
            ds.Data.Add(new NumericPoint(3, 4));
            ds.Data.Add(new NumericPoint(5, 2));
            ds.Data.Add(new NumericPoint(7, 5));
            ds.Data.Add(new NumericPoint(9, 4));

            NumericalDataSet ds1 = new NumericalDataSet("test");
            ds1.Data.Add(new NumericPoint(-1, -1));
            ds1.Data.Add(new NumericPoint(0, 3));
            ds1.Data.Add(new NumericPoint(1, 2.5));
            ds1.Data.Add(new NumericPoint(2, 5));
            ds1.Data.Add(new NumericPoint(3, 4));
            ds1.Data.Add(new NumericPoint(5, 2));
            ds1.Data.Add(new NumericPoint(7, 5));
            ds1.Data.Add(new NumericPoint(9, 4));
            //ds1.CalculateNthPolynomialRegression(4);
            Console.WriteLine((from dp in ds1.Data from fdp in ds1.Data select dp.Y - fdp.Y).Sum());
            foreach(NumericPoint dp in ds.Data)
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
            //Sample test data set
            NumericalDataSet ds = new NumericalDataSet("test");
            ds.Data.Add(new NumericPoint(-1, -1    ));
            ds.Data.Add(new NumericPoint(0, 3));
            ds.Data.Add(new NumericPoint(1, 2.5));
            ds.Data.Add(new NumericPoint(2, 5));
            ds.Data.Add(new NumericPoint(3, 4));
            ds.Data.Add(new NumericPoint(5, 2));
            ds.Data.Add(new NumericPoint(7, 5));
            ds.Data.Add(new NumericPoint(9, 4));            

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
                float x = i * xstep - xmax;
                float functionValue =  (float)Math.Pow(x,2) + x;
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

        private void buttonCreateDataSet_Click(object sender, EventArgs e)
        {
            FormCreateDataSet form = new FormCreateDataSet();
            if(form.ShowDialog() == DialogResult.OK)
            {
                int index = 0;
                string name = form.DataSetName;
                bool labeled = form.Labeled;
                if (comboBoxDataSets.Items.Count == 0)
                {
                    comboBoxDataSets.Items.Add(name);
                    comboBoxDataSets.Enabled = true;
                } 
                else
                {
                    for(int i = 0; i < comboBoxDataSets.Items.Count; ++i)
                    {
                        string s = comboBoxDataSets.Items[i].ToString();
                        if (name.CompareTo(s) <= 0)
                        {
                            comboBoxDataSets.Items.Insert(i, name);
                            index = i;
                            break;
                        }
                        if(i == comboBoxDataSets.Items.Count - 1)
                        {
                            comboBoxDataSets.Items.Add(name);
                            index = comboBoxDataSets.Items.Count - 1;
                            break;
                        }
                    }
                }
                comboBoxDataSets.SelectedIndex = index;
                if(labeled)
                {
                    dataSets.Add(new LabeledDataSet(name));
                    dataGridView.Columns[0].HeaderText = "Label";
                }
                else
                {
                    dataSets.Add(new NumericalDataSet(name));
                    dataGridView.Columns[0].HeaderText = "X";
                }
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            var p = PointToClient(Cursor.Position);
            var c = GetChildAtPoint(p);
            if (c != null && c.Enabled == false)
            {
                if (dataSets.Count == 0)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("No class is created. Please create one first.");
                }
            }
        }
    }
}
