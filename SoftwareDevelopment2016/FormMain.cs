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
        public List<DataSet> DataSets { get; set; }
        private int CurrentDataSetIndex;

        private List<Label> Dividers = new List<Label>();
        private List<Label> DescriptiveLabels = new List<Label>();
        private List<Label> DescriptiveLableText = new List<Label>();

        private double XMin { get; set; }
        private double XMax { get; set; }
        private double YMin { get; set; }
        private double YMax { get; set; }

        public FormMain()
        {
            DataSets = new List<DataSet>();
            InitializeComponent();

            XMin = -2;
            XMax = 10;
            YMin = -2;
            YMax = 6;
            
            Dividers.Add(divider1);
            Dividers.Add(divider2);
            Dividers.Add(divider3);
            Dividers.Add(divider4);
            Dividers.Add(divider5);
            Dividers.Add(divider6);
            Dividers.Add(divider7);
            Dividers.Add(divider8);

            DescriptiveLabels.Add(labelMean);
            DescriptiveLabels.Add(labelMedian);
            DescriptiveLabels.Add(labelMode);
            DescriptiveLabels.Add(labelStdDev);
            DescriptiveLabels.Add(labelRange);
            DescriptiveLabels.Add(labelDomain);

            DescriptiveLableText.Add(labelMeanText);
            DescriptiveLableText.Add(labelMedianText);
            DescriptiveLableText.Add(labelModeText);
            DescriptiveLableText.Add(labelStdDevText);
            DescriptiveLableText.Add(labelRangeText);
            DescriptiveLableText.Add(labelDomainText);
        }

        private DataSet GetCurrentDataSet()
        {
            return DataSets[CurrentDataSetIndex];
        }

        private void DrawPlot(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = panel1.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            double xstep = (XMax - XMin) / panel1.Width;
            double ystep = (YMax - YMin) / panel1.Height;
            double xaxis = YMax / ystep;
            double yaxis = -XMin / xstep;

            graphics.DrawLine(new Pen(Color.Black, 1f), new PointF(0, (float)xaxis), new PointF(panel1.Width, (float)xaxis));
            graphics.DrawLine(new Pen(Color.Black, 1f), new PointF((float)yaxis, 0), new PointF((float)yaxis, panel1.Height));
            foreach(DataSet ds in DataSets)
            {
                if (ds.IsPlotted)
                {
                    foreach (DataPoint dp in (from a in ds.Data where !a.isNull() select a))
                    {
                        PointF p = new PointF((float)(yaxis + dp.X / xstep), (float)(xaxis - dp.Y / ystep));
                        graphics.FillEllipse(new SolidBrush(Color.Blue), p.X - 2, p.Y - 2, 4, 4);
                    }
                }
                if (ds.IsRegressionPlotted)
                {
                    Polynomial? p = ds.CalculateNthPolynomialRegression((int)numericUpDownOrder.Value);
                    if (p != null)
                    {
                        List<PointF> points = new List<PointF>();
                        for (double x = XMin; x <= XMax; x += xstep)
                        {
                            points.Add(new PointF((float)(yaxis + x / xstep), (float)(xaxis - p.Value.f(x) / ystep)));
                        }
                        try
                        {
                            graphics.DrawLines(new Pen(Color.Black, 1f), points.ToArray());
                        }
                        catch (OverflowException oe)
                        {
                            SystemSounds.Asterisk.Play();
                            MessageBox.Show("Something went wrong plotting the regression." , "Error" );
                        }
                    }
                }
            }
        }

        private void OnCreateDataSet(object sender, EventArgs e)
        {
            FormCreateDataSet form = new FormCreateDataSet();
            if(form.ShowDialog() == DialogResult.OK)
            {
                int index = 0;
                string name = form.DataSetName;
                if (comboBoxDataSets.Items.Count == 0)
                {
                    CurrentDataSetIndex = index;
                    comboBoxDataSets.Items.Add(name);
                    comboBoxDataSets.Enabled = true;
                    dataGridView.Enabled = true;
                    foreach(Label d in Dividers)
                    {
                        d.Enabled = true;
                    }
                    foreach(Label l in DescriptiveLabels)
                    {
                        l.Enabled = true;
                    }
                    foreach (Label l in DescriptiveLableText)
                    {
                        l.Enabled = true;
                    }
                    checkBoxPlotPoints.Enabled = true;
                    plotToolStripMenuItem.Enabled = true;
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
                            CurrentDataSetIndex = index;
                            break;
                        }
                        if(i == comboBoxDataSets.Items.Count - 1)
                        {
                            comboBoxDataSets.Items.Add(name);
                            index = comboBoxDataSets.Items.Count - 1;
                            CurrentDataSetIndex = index;
                            break;
                        }
                    }
                }
                comboBoxDataSets.SelectedIndex = index;
                DataSets.Add(new DataSet(name));
                checkBoxPlotPoints.CheckState = CheckState.Unchecked;
                checkBoxPlotRegression.CheckState = CheckState.Unchecked;
                dataGridView.Rows.Clear();
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            var p = PointToClient(Cursor.Position);
            var c = GetChildAtPoint(p);
            if (c != null && c.Enabled == false)
            {
                if (DataSets.Count == 0)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("No data set is created. Please create one first." , "Error");
                }
            }
        }

        private void OnCellEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(ValidateEntry(e))
            {
                GetCurrentDataSet().Data.Clear();
                for (int i = 0; i < dataGridView.Rows.Count - 1; ++i)
                {
                    GetCurrentDataSet().Data.Add(new DataPoint(dataGridView.Rows[i].Cells[0].Value == null ? (double?)null : Convert.ToDouble(dataGridView.Rows[i].Cells[0].Value),
                                                                  dataGridView.Rows[i].Cells[1].Value == null ? (double?)null : Convert.ToDouble(dataGridView.Rows[i].Cells[1].Value)));
                }
                labelMean.Text = GetCurrentDataSet().getMean().ToString();
                labelMedian.Text = GetCurrentDataSet().getMedian().ToString();
                labelMode.Text = GetCurrentDataSet().getMode().ToString();
                labelStdDev.Text = GetCurrentDataSet().getStandardDeviation().ToString();
                labelDomain.Text = GetCurrentDataSet().getDomain().ToString();
                labelRange.Text = GetCurrentDataSet().getRange().ToString();

                foreach (DataGridViewRow r in dataGridView.Rows)
                {
                    if (r.Cells[0].Value == null && r.Cells[1].Value == null && r.Index != dataGridView.Rows.Count-1 )
                    {
                        dataGridView.Rows.Remove(r);
                    }
                }
                var list = (from dp in GetCurrentDataSet().Data where !dp.isNull() select dp).ToList();
                if (list.Count >= 2)
                {
                    checkBoxPlotRegression.Enabled = true;
                    labelOrder.Enabled = true;
                    numericUpDownOrder.Enabled = true;
                    numericUpDownOrder.Maximum = list.Count - 1;
                }
                else
                {
                    checkBoxPlotRegression.CheckState = CheckState.Unchecked;
                    checkBoxPlotRegression.Enabled = false;
                    labelOrder.Enabled = false;
                    numericUpDownOrder.Enabled = false;
                }
                this.Refresh();
            } 
        }
        
        private bool ValidateEntry(DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                double temp;
                if (!Double.TryParse(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out temp))
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                    bool rowIsEmpty = true;
                    foreach (DataGridViewCell cell in dataGridView.Rows[e.RowIndex].Cells)
                    {
                        if (cell.Value != null)
                        {
                            rowIsEmpty = false;
                            break;
                        }
                    }
                    if (rowIsEmpty)
                    {
                        dataGridView.CancelEdit();
                        try
                        {
                            dataGridView.Rows.Remove(dataGridView.Rows[e.RowIndex]);
                        }
                        catch
                        {
                            SystemSounds.Asterisk.Play();
                            MessageBox.Show("Something went wrong. Try again.", "Error");
                        }
                    }
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Please enter only numbers." , "Erorr");
                    return false; ;
                }
            }
            return true;
        }

        private void OnDataSetChange(object sender, EventArgs e)
        {
            CurrentDataSetIndex = comboBoxDataSets.SelectedIndex;
            dataGridView.Rows.Clear();
            foreach (DataPoint dp in GetCurrentDataSet().Data)
            {
                dataGridView.Rows.Add(dp.X, dp.Y);
            }
            labelMean.Text = GetCurrentDataSet().getMean().ToString();
            labelMedian.Text = GetCurrentDataSet().getMedian().ToString();
            labelMode.Text = GetCurrentDataSet().getMode().ToString();
            labelStdDev.Text = GetCurrentDataSet().getStandardDeviation().ToString();
            labelDomain.Text = GetCurrentDataSet().getDomain().ToString();
            labelRange.Text = GetCurrentDataSet().getRange().ToString();
        }

        private void OnPlotCheckChange(object sender, EventArgs e)
        {
            GetCurrentDataSet().IsPlotted = checkBoxPlotPoints.CheckState == CheckState.Checked ? true : false;
            this.Refresh();
        }

        private void OnRegressionCheckChange(object sender, EventArgs e)
        {
            GetCurrentDataSet().IsRegressionPlotted = checkBoxPlotRegression.CheckState == CheckState.Checked ? true : false;
            this.Refresh();
        }

        private void OnOrderChange(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void OnEditWindow(object sender, EventArgs e)
        {
            FormEditWindow form = new FormEditWindow(XMin, XMax, YMin, YMax);
            if (form.ShowDialog() == DialogResult.OK)
            {
                XMin = form.XMin;
                XMax = form.XMax;
                YMin = form.YMin;
                YMax = form.YMax;
                this.Refresh();
            }
        }
    }
}
