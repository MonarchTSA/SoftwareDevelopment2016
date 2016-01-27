using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopment2016
{

    public struct Interval
    {
        public double Min { get; set; }
        public double Max { get; set; }
        public Interval(double min, double max)
        {
            Min = min;
            Max = max;
        }
        public override string ToString()
        {
            return "[" + Min + ", " + Max + "]";
        }
    }

    public struct Polynomial
    {
        //a0 + a1x + a2x^2 + a3x^3 + ... + anx^n
        public List<double> Coefficients;
        public Polynomial(params double[] coefficients) 
        {
            Coefficients = new List<double>();
            foreach(double d in coefficients)
            {
                Coefficients.Add(d);
            }
        }
        //returns f(x)
        public double f(double x)
        {
            double sum = 0;
            for(int i = 0; i < Coefficients.Count; ++i)
            {
                sum += Coefficients[i] * Math.Pow(x, i);
            }
            return sum;
        }
    }

    public abstract class DataSet
    {
        public string Name { get; set; }
    }

    public class NumericalDataSet : DataSet
    {

        public List<NumericPoint> Data { get; set; }

        public NumericalDataSet(string name)
        {
            Data = new List<NumericPoint>();
            Name = name;
        }

        public double? getMean()
        {
            var list = (from dp in Data where !dp.isNull() select dp.Y.Value);
            return list.ToList().Count == 0 ? (double?)null : list.Average();
        }

        public double? getMedian()
        {
            List<double> sorted = (from dp in Data where !dp.isNull() orderby dp.X select dp.X.Value).ToList();
            if(sorted.Count == 0)
            {
                return null;
            } 
            else
            {
                if (sorted.Count % 2 == 0)
                {
                    return (sorted[sorted.Count / 2] + sorted[sorted.Count / 2 - 1]) / 2;
                }
                else
                {
                    return sorted[(sorted.Count + 1) / 2 - 1];
                }
            }
        }

        public double? getMode()
        {
            List<double> yvals = (from dp in Data where !dp.isNull() orderby dp.Y select dp.Y.Value).ToList();
            if(yvals.Count == 0)
            {
                return null;
            } 
            else
            {
                int maxCount = 0, currentCount = 1;
                double currentMode = 0, maxMode = 0;
                for (int i = 0; i < yvals.Count; ++i)
                {
                    if (i == 0)
                    {
                        currentMode = 0;
                    }
                    else
                    {
                        if (yvals[i] == currentMode)
                        {
                            ++currentCount;
                        }
                        else
                        {
                            currentMode = yvals[i];
                            currentCount = 1;
                        }
                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                            maxMode = yvals[i];
                        }
                    }
                }
                return maxMode;
            }
        }

        public Interval? getDomain()
        {
            var list = from dp in Data where !dp.isNull() select dp.X;
            if(list.ToList().Count == 0)
            {
                return null;
            } 
            else
            {
                return new Interval(list.Min().Value, list.Max().Value);
            }
        }

        public Interval? getRange()
        {
            var list = from dp in Data where !dp.isNull() select dp.Y;
            if (list.ToList().Count == 0)
            {
                return null;
            }
            else
            {
                
                return new Interval(list.Min().Value, list.Max().Value);
            }
        }

        public double? getStandardDeviation()
        {
            var list = (from dp in Data where !dp.isNull() select Math.Pow((dp.Y - getMean()).Value, 2));
            if (list.ToList().Count == 0)
            {
                return null;
            }
            else
            {
                return Math.Sqrt(list.Average());
            }
        }

        public Polynomial? CalculateNthPolynomialRegression(int order)
        {
            if(Data.Count == 0)
            {
                return null;
            } 
            else
            {
                //Calculate the sums to be used in the matrix
                double[] sums = new double[order * 2 + 1];
                for (int i = 0; i < order * 2 + 1; ++i)
                {
                    foreach (NumericPoint dp in (from dp in Data where !dp.isNull() select dp))
                    {
                        sums[i] += Math.Pow(dp.X.Value, i);
                    }
                }
                //Calculate the augmented part of the matrix
                double[] augments = new double[order + 1];
                for (int i = 0; i < order + 1; ++i)
                {
                    foreach (NumericPoint dp in (from dp in Data where !dp.isNull() select dp))
                    {
                        augments[i] += dp.Y.Value * Math.Pow(dp.X.Value, i);
                    }
                }
                //Distrubute the terms into the matrix
                double[,] matrix = new double[order + 1, order + 1];
                for (int i = 0; i < order + 1; ++i)
                {
                    for (int j = 0; j < order + 1; ++j)
                    {
                        matrix[i, j] = sums[i + j];
                    }
                }

                double[] solutions = new double[order + 1];
                double determinant = Determinant(matrix, order + 1);
                for (int n = 0; n < order + 1; ++n)
                {
                    double[,] newMatrix = new double[order + 1, order + 1];
                    for (int i = 0; i < order + 1; ++i)
                    {
                        for (int j = 0; j < order + 1; ++j)
                        {
                            if (j == n)
                            {
                                newMatrix[i, j] = augments[i];
                            }
                            else
                            {
                                newMatrix[i, j] = matrix[i, j];
                            }
                        }
                    }
                    solutions[n] = Determinant(newMatrix, order + 1) / determinant;
                }
                Polynomial p = new Polynomial(solutions);
                //Console.WriteLine(CalculateRSquared(p));
                return new Polynomial(solutions);
            }
        }
        
        private double Determinant(double[,] matrix, int size)
        {
            if(size == 2)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            else
            {
                double determinant = 0;
                for(int n = 0; n < size; ++n)
                {
                    double[,] newMatrix = new double[size - 1, size - 1];
                    for(int i = 0; i < size-1; ++i)
                    {
                        for(int j = 0; j < size-1; j++)
                        {
                            if(j >= n)
                            {
                                newMatrix[i, j] = matrix[i + 1, j + 1];
                            }
                            else
                            {
                                newMatrix[i, j] = matrix[i + 1, j];
                            }
                        }
                    }
                    //Add
                    if (n % 2 == 0)
                    {
                        determinant += matrix[0,n] * Determinant(newMatrix, size - 1);
                    }
                    //Subtract
                    else
                    {
                        determinant -= matrix[0, n] * Determinant(newMatrix, size - 1);
                    }
                }
                return determinant;
            }
        }

        private void swap(List<DataPoint> list, int element1, int element2)
        {
            DataPoint temp = list[element2];
            list[element1] = list[element2];
            list[element2] = temp;
        }

    }

    public class LabeledDataSet : DataSet
    {
        public List<LabeledPoint> Data { get; set; }

        public LabeledDataSet(string name)
        {
            Name = name;
            Data = new List<LabeledPoint>();
        }

        public double getMode()
        {
            return (from dp in Data where !dp.isNull() select dp.Y).Max().Value;
        }

        public Interval? getRange()
        {
            var list = from dp in Data select dp.Y;
            if(list.Min() == null || list.Max() == null)
            {
                return null;
            }
            else
            {
               return new Interval(list.Min().Value, list.Max().Value);
            }
        }
    }
}
