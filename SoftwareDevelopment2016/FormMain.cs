﻿using System;
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
        private int currentDataSetIndex;

        private List<Label> dividers = new List<Label>();
        private List<Label> descriptiveLabels = new List<Label>();
        private List<Label> descriptiveLabelText = new List<Label>();

        public FormMain()
        {
            DataSets = new List<DataSet>();
            InitializeComponent();
            
            dividers.Add(divider1);
            dividers.Add(divider2);
            dividers.Add(divider3);
            dividers.Add(divider4);
            dividers.Add(divider5);
            dividers.Add(divider6);
            dividers.Add(divider7);
            dividers.Add(divider8);

            descriptiveLabels.Add(labelMean);
            descriptiveLabels.Add(labelMedian);
            descriptiveLabels.Add(labelMode);
            descriptiveLabels.Add(labelStdDev);
            descriptiveLabels.Add(labelRange);
            descriptiveLabels.Add(labelDomain);

            descriptiveLabelText.Add(labelMeanText);
            descriptiveLabelText.Add(labelMedianText);
            descriptiveLabelText.Add(labelModeText);
            descriptiveLabelText.Add(labelStdDevText);
            descriptiveLabelText.Add(labelRangeText);
            descriptiveLabelText.Add(labelDomainText);
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

        private void DrawPlot(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = panel1.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            double xmin = -2;
            double xmax = 10;
            double ymin = -2;
            double ymax = 6;
            double xstep = (xmax - xmin) / panel1.Width;
            double ystep = (ymax - ymin) / panel1.Height;
            double xaxis = ymax / ystep;
            double yaxis = -xmin / xstep;

            graphics.DrawLine(new Pen(Color.Black, 1f), new PointF(0, (float)xaxis), new PointF(panel1.Width, (float)xaxis));
            graphics.DrawLine(new Pen(Color.Black, 1f), new PointF((float)yaxis, 0), new PointF((float)yaxis, panel1.Height));
            foreach(DataSet ds in DataSets)
            {
                if(ds.GetType() == typeof(NumericalDataSet))
                {
                    if(ds.IsPlotted)
                    {
                        foreach(NumericPoint dp in (from a in ((NumericalDataSet)ds).Data where !a.isNull() select a))
                        {
                            PointF p =  new PointF((float)(yaxis + dp.X / xstep), (float)(xaxis - dp.Y / ystep));
                            graphics.FillEllipse(new SolidBrush(Color.Blue), p.X - 2, p.Y - 2, 4, 4);
                        }
                    }
                    if(((NumericalDataSet)ds).IsRegressionPlotted)
                    {
                        Polynomial? p = ((NumericalDataSet)ds).CalculateNthPolynomialRegression((int)numericUpDownOrder.Value);
                        if(p != null)
                        {
                            List<PointF> points = new List<PointF>();
                            for (double x = xmin; x <= xmax; x += xstep)
                            {
                                points.Add(new PointF((float)(yaxis + x / xstep), (float)(xaxis - p.Value.f(x) / ystep)));
                            }
                            try
                            {
                                graphics.DrawLines(new Pen(Color.Black, 1f), points.ToArray());
                            } 
                            catch(OverflowException oe)
                            {
                                MessageBox.Show("Something went wrong plotting the regression");
                            }
                        }
                    }
                }
                else
                {

                }

            }

        }

        private void CreateDataSet(object sender, EventArgs e)
        {
            FormCreateDataSet form = new FormCreateDataSet();
            if(form.ShowDialog() == DialogResult.OK)
            {
                int index = 0;
                string name = form.DataSetName;
                bool labeled = form.Labeled;
                if (comboBoxDataSets.Items.Count == 0)
                {
                    currentDataSetIndex = index;
                    comboBoxDataSets.Items.Add(name);
                    comboBoxDataSets.Enabled = true;
                    dataGridView.Enabled = true;
                    foreach(Label d in dividers)
                    {
                        d.Enabled = true;
                    }
                    foreach(Label l in descriptiveLabels)
                    {
                        l.Enabled = true;
                    }
                    foreach (Label l in descriptiveLabelText)
                    {
                        l.Enabled = true;
                    }
                    checkBoxPlotPoints.Enabled = true;
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
                            currentDataSetIndex = index;
                            break;
                        }
                        if(i == comboBoxDataSets.Items.Count - 1)
                        {
                            comboBoxDataSets.Items.Add(name);
                            index = comboBoxDataSets.Items.Count - 1;
                            currentDataSetIndex = index;
                            break;
                        }
                    }
                }
                comboBoxDataSets.SelectedIndex = index;
                if(labeled)
                {
                    DataSets.Add(new LabeledDataSet(name));
                    dataGridView.Columns[0].HeaderText = "Label";
                }
                else
                {
                    DataSets.Add(new NumericalDataSet(name));
                    dataGridView.Columns[0].HeaderText = "X";
                }
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
                    MessageBox.Show("No class is created. Please create one first.");
                }
            }
        }

        private DataSet GetCurrentDataSet()
        {
            return DataSets[currentDataSetIndex];
        }

        private void OnCellEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(ValidateEntry(e))
            {
                if (GetCurrentDataSet().GetType() == typeof(NumericalDataSet))
                {
                    ((NumericalDataSet)GetCurrentDataSet()).Data.Clear();
                    for (int i = 0; i < dataGridView.Rows.Count - 1; ++i)
                    {
                        ((NumericalDataSet)GetCurrentDataSet()).Data.Add(new NumericPoint(dataGridView.Rows[i].Cells[0].Value == null ? (double?)null : Convert.ToDouble(dataGridView.Rows[i].Cells[0].Value),
                                                                                          dataGridView.Rows[i].Cells[1].Value == null ? (double?)null : Convert.ToDouble(dataGridView.Rows[i].Cells[1].Value)));
                    }
                    labelMean.Text = ((NumericalDataSet)GetCurrentDataSet()).getMean().ToString();
                    labelMedian.Text = ((NumericalDataSet)GetCurrentDataSet()).getMedian().ToString();
                    labelMode.Text = ((NumericalDataSet)GetCurrentDataSet()).getMode().ToString();
                    labelStdDev.Text = ((NumericalDataSet)GetCurrentDataSet()).getStandardDeviation().ToString();
                    labelDomain.Text = ((NumericalDataSet)GetCurrentDataSet()).getDomain().ToString();
                    labelRange.Text = ((NumericalDataSet)GetCurrentDataSet()).getRange().ToString();
                }
                else
                {
                    for (int i = 0; i < dataGridView.Rows.Count - 1; ++i)
                    {
                        ((LabeledDataSet)GetCurrentDataSet()).Data.Clear();
                        ((LabeledDataSet)GetCurrentDataSet()).Data.Add(new LabeledPoint(dataGridView.Rows[i].Cells[0].Value == null ? null : Convert.ToString(dataGridView.Rows[i].Cells[0].Value),
                                                                                        dataGridView.Rows[i].Cells[1].Value == null ? (double?)null : Convert.ToDouble(dataGridView.Rows[i].Cells[1].Value)));
                    }
                }

                foreach(DataGridViewRow r in dataGridView.Rows)
                {
                    if (r.Cells[0].Value == null && r.Cells[1].Value == null && r.Index != dataGridView.Rows.Count-1 )
                    {
                        dataGridView.Rows.Remove(r);
                    }
                }
                var list = (from dp in ((NumericalDataSet)GetCurrentDataSet()).Data where !dp.isNull() select dp).ToList();
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
                if (GetCurrentDataSet().GetType() == typeof(NumericalDataSet))
                {
                    double temp;
                    if(!Double.TryParse(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out temp))
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
                                MessageBox.Show("Something went wrong. Try again.", "Error");
                            }
                        }
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Please enter only numbers.");
                        return false; ;
                    }
                }
                else
                {
                    double temp;
                    if(e.ColumnIndex != 0 && (!Double.TryParse(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out temp)))
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
                                MessageBox.Show("Something went wrong. Try again.", "Error");
                            }
                        }
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Please enter only numbers.");
                        return false;
                    }
                }
            }
            return true;
        }

        private void OnDataSetChange(object sender, EventArgs e)
        {
            currentDataSetIndex = comboBoxDataSets.SelectedIndex;
            dataGridView.Rows.Clear();
            if(GetCurrentDataSet().GetType() == typeof(NumericalDataSet))
            {
                dataGridView.Columns[0].HeaderText = "X";
                foreach(NumericPoint dp in ((NumericalDataSet)GetCurrentDataSet()).Data)
                {
                    dataGridView.Rows.Add(dp.X, dp.Y);
                }
                labelMean.Text = ((NumericalDataSet)GetCurrentDataSet()).getMean().ToString();
                labelMedian.Text = ((NumericalDataSet)GetCurrentDataSet()).getMedian().ToString();
                labelMode.Text = ((NumericalDataSet)GetCurrentDataSet()).getMode().ToString();
                labelStdDev.Text = ((NumericalDataSet)GetCurrentDataSet()).getStandardDeviation().ToString();
                labelDomain.Text = ((NumericalDataSet)GetCurrentDataSet()).getDomain().ToString();
                labelRange.Text = ((NumericalDataSet)GetCurrentDataSet()).getRange().ToString();
            }
            else
            {
                dataGridView.Columns[0].HeaderText = "Label";
                foreach (LabeledPoint dp in ((LabeledDataSet)GetCurrentDataSet()).Data)
                {
                    dataGridView.Rows.Add(dp.Label, dp.Y);
                }
            }
        }

        private void OnPlotCheckChange(object sender, EventArgs e)
        {
            GetCurrentDataSet().IsPlotted = checkBoxPlotPoints.CheckState == CheckState.Checked ? true : false;
            this.Refresh();
        }

        private void OnRegressionCheckChange(object sender, EventArgs e)
        {
            ((NumericalDataSet)GetCurrentDataSet()).IsRegressionPlotted = checkBoxPlotRegression.CheckState == CheckState.Checked ? true : false;
            this.Refresh();
        }

        private void OnOrderChange(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void editWindow(object sender, EventArgs e)
        {

        }
    }
}