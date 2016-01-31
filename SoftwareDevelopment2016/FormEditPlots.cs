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
    public partial class FormEditPlot : Form
    {
        
        public Color PointColor { get; set; }
        public double PointSize { get; set; }
        public Shape PointShape { get; set; }

        public FormEditPlot(DataSet ds)
        {
            InitializeComponent();

            PointColor = ds.PointColor;
            PointSize = ds.PointSize;
            PointShape = ds.PointShape;

            colorSamplePanel.BackColor = PointColor;
            numericUpDownSize.Value = (decimal)PointSize;
            switch(PointShape)
            {
                case Shape.Square:
                    comboBoxShapes.SelectedIndex = 0;
                    break;
                case Shape.Circle:
                    comboBoxShapes.SelectedIndex = 1;
                    break;
                case Shape.Diamond:
                    comboBoxShapes.SelectedIndex = 2;
                    break;
            }
        }

        private void OnButtonColorClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                PointColor = cd.Color;
            }
            colorSamplePanel.BackColor = PointColor;
        }

        private void OnButonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text == "Done")
            {
                PointSize = (double)numericUpDownSize.Value;
                switch(comboBoxShapes.Text) {
                    case "Square":
                        PointShape = Shape.Square;
                        break;
                    case "Circle":
                        PointShape = Shape.Circle;
                        break;
                    case "Diamond":
                        PointShape = Shape.Diamond;
                        break;
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
