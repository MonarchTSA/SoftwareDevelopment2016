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
    public partial class FormEditWindow : Form
    {

        public double XMin { get; set; }
        public double XMax { get; set; }
        public double YMin { get; set; }
        public double YMax { get; set; }

        public FormEditWindow(double xmin, double xmax, double ymin, double ymax)
        {
            InitializeComponent();
            XMin = xmin;
            XMax = xmax;
            YMin = ymin;
            YMax = ymax;

            numericUpDownXMax.Maximum = Decimal.MaxValue;
            numericUpDownXMax.Minimum = Decimal.MinValue;
            numericUpDownXMin.Maximum = Decimal.MaxValue;
            numericUpDownXMin.Minimum = Decimal.MinValue;
            numericUpDownYMax.Maximum = Decimal.MaxValue;
            numericUpDownYMax.Minimum = Decimal.MinValue;
            numericUpDownYMin.Maximum = Decimal.MaxValue;
            numericUpDownYMin.Minimum = Decimal.MinValue;

            numericUpDownXMin.Value = (decimal)XMin;
            numericUpDownXMax.Value = (decimal)XMax;
            numericUpDownYMin.Value = (decimal)YMin;
            numericUpDownYMax.Value = (decimal)YMax;
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Done")
            {
                decimal xmin = numericUpDownXMin.Value;
                decimal xmax = numericUpDownXMax.Value;
                decimal ymin = numericUpDownYMin.Value;
                decimal ymax = numericUpDownYMax.Value;
                if (xmax == xmin || xmax < xmin || ymax == ymin || ymax < ymin)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Window boundaries are invalid. Make sure the minimum and maximum are not equal and the minimum isn't greater than the maximum.", "Error");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
