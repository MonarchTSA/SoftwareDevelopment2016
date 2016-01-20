using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopment2016
{
    public abstract class DataPoint
    {
        public double Y { get; set; }
    }
    public class NumericPoint : DataPoint
    {
        public double X { get; set; }
        public NumericPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    public class LabeledPoint : DataPoint
    {
        public string Label { get; set; }
        public LabeledPoint(string label, double y)
        {
            Label = label;
            Y = y;
        }
    }
}
