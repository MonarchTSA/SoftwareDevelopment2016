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
        public double XTickInterval { get; set; }
        public double YTickInterval { get; set; }

        public FormEditWindow(double xmin, double xmax, double ymin, double ymax, double xtickinterval, double ytickinterval)
        {
            InitializeComponent();
            XMin = xmin;
            XMax = xmax;
            YMin = ymin;
            YMax = ymax;
            XTickInterval = xtickinterval;
            YTickInterval = ytickinterval;

            numericUpDownXMax.Maximum = Decimal.MaxValue;
            numericUpDownXMax.Minimum = Decimal.MinValue;
            numericUpDownXMin.Maximum = Decimal.MaxValue;
            numericUpDownXMin.Minimum = Decimal.MinValue;
            numericUpDownYMax.Maximum = Decimal.MaxValue;
            numericUpDownYMax.Minimum = Decimal.MinValue;
            numericUpDownYMin.Maximum = Decimal.MaxValue;
            numericUpDownYMin.Minimum = Decimal.MinValue;
            numericUpDownXTickInterval.Maximum = Decimal.MaxValue;
            numericUpDownXTickInterval.Minimum = 1;
            numericUpDownYTickInterval.Maximum = Decimal.MaxValue;
            numericUpDownYTickInterval.Minimum = 1;

            numericUpDownXMin.Value = (decimal)XMin;
            numericUpDownXMax.Value = (decimal)XMax;
            numericUpDownYMin.Value = (decimal)YMin;
            numericUpDownYMax.Value = (decimal)YMax;
            numericUpDownXTickInterval.Value = (decimal)XTickInterval;
            numericUpDownYTickInterval.Value = (decimal)YTickInterval;
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
                    XMin = (double)xmin;
                    XMax = (double)xmax;
                    YMin = (double)ymin;
                    YMax = (double)ymax;
                    XTickInterval = (double)numericUpDownXTickInterval.Value;
                    YTickInterval = (double)numericUpDownYTickInterval.Value;

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