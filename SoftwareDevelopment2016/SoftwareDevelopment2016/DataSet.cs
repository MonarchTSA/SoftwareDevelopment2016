using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopment2016
{

    public struct DataPoint
    {
        public double X;
        public double Y;
        public DataPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public struct Interval
    {
        public double Min;
        public double Max;
        public double Length;
        public Interval(double min, double max)
        {
            Min = min;
            Max = max;
            Length = Math.Abs(Max - min);
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

    public class DataSet
    {

        public List<DataPoint> Data { get; set; }

        public double MeanX
        {
            get
            {
                return (from dp in Data select dp.X).Average();
            }
        }
        public double MeanY
        {
            get
            {
                return (from dp in Data select dp.Y).Average();
            }
        }
        public double StandardDeviationX
        {
            get
            {
                return Math.Sqrt((from dp in Data select Math.Pow(dp.X - MeanX, 2)).Average());
            }
        }
        public double StandardDeviationY
        {
            get
            {
                return Math.Sqrt((from dp in Data select Math.Pow(dp.Y - MeanY, 2)).Average());
            }
        }
        public double ModeX
        {
            get
            {
                List<double> xvals = (from dp in Data orderby dp.X ascending select dp.X).ToList();
                int maxCount = 0, currentCount = 1;
                double currentMode = 0, maxMode = 0;
                for(int i = 0; i < xvals.Count; ++i)
                {
                    if (i == 0)
                    {
                        currentMode = 0;
                    }
                    else
                    {
                        if(xvals[i] == currentMode)
                        {
                            ++currentCount;
                        } 
                        else
                        {
                            currentMode = xvals[i];
                            currentCount = 1;
                        }
                        if(currentCount > maxCount)
                        {
                            maxCount = currentCount;
                            maxMode = xvals[i];
                        }
                    }
                }
                return maxMode;
            }
        }
        public double ModeY
        {
            get
            {
                List<double> yvals = (from dp in Data orderby dp.Y ascending select dp.Y).ToList();
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
        public double MedianX
        {
            get
            {
                List<double> sorted = (from dp in Data orderby dp.X select dp.X).ToList();
                if(sorted.Count % 2 == 0)
                {
                    return (sorted[sorted.Count / 2] + sorted[sorted.Count / 2 - 1]) / 2;
                }
                else
                {
                    return sorted[(sorted.Count + 1) / 2 - 1];
                }
            }
        }
        public double MedianY
        {
            get
            {
                List<double> sorted = (from dp in Data orderby dp.Y select dp.Y).ToList();
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
        public Interval Range
        {
            get
            {
                List<double> sorted = (from dp in Data orderby dp.Y ascending select dp.Y).ToList();
                return new Interval(sorted.First(), sorted.Last());
            }
        }
        public Interval Domain
        {
            get
            {
                List<double> sorted = (from dp in Data orderby dp.X ascending select dp.X).ToList();
                return new Interval(sorted.First(), sorted.Last());
            }
        }

        public DataSet()
        {
            Data = new List<DataPoint>();
        }

        public Polynomial CalculateNthPolynomialRegression(int order)
        {
            //Calculate the sums to be used in the matrix
            double[] sums = new double[order*2 + 1];
            for(int i = 0; i < order*2 + 1; ++i)
            {
                foreach(DataPoint dp in Data)
                {
                    sums[i] += Math.Pow(dp.X, i);
                }
            }
            //Calculate the augmented part of the matrix
            double[] augments = new double[order + 1];
            for(int i = 0; i < order + 1; ++i)
            {
                foreach(DataPoint dp in Data)
                {
                    augments[i] += dp.Y * Math.Pow(dp.X, i);
                }
            }
            //Distrubute the terms into the matrix
            double[,] matrix = new double[order + 1, order + 1];
            for(int i = 0; i < order + 1; ++i)
            {
                for(int j = 0; j < order + 1; ++j)
                {
                    matrix[i, j] = sums[i + j];
                }
            }

            double[] solutions = new double[order+1];
            double determinant = Determinant(matrix, order + 1);
            for(int n = 0; n < order+1; ++n)
            {
                double[,] newMatrix = new double[order + 1, order + 1];
                for(int i = 0; i < order + 1; ++i)
                {
                    for(int j = 0; j < order +1; ++j)
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
                solutions[n] =  Determinant(newMatrix, order + 1) / determinant;
            }
            Polynomial p = new Polynomial(solutions);
            Console.WriteLine(CalculateRSquared(p));
            return new Polynomial(solutions);
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
}
