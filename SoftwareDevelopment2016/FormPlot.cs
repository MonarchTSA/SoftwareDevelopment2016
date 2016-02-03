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
    public partial class FormPlot : Form
    {

        public Bitmap PlotBitmap;

        public FormPlot()
        {
            InitializeComponent();
            PlotBitmap = new Bitmap(225, 225);
        }

        private void DrawPlot(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(PlotBitmap, Point.Empty);
        }
    }
}
