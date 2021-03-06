using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class TriangleCalc
    {
        public static double TriangleAreaCalc(double a, double b, double c)
        {
            //Длины сторон не должны быть меньше 0
            if ((a <= 0)||(b <= 0) ||(c <= 0))
            {
                throw new CalcException("Input arguments must be > 0!");
            }

            //Сумма двух сторон не должна быть равна длине третьей
            if ((a + b == c) || (a + c == b) || (b + c == a))
            {
                throw new CalcException("Data not valid!");
            }

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public class CalcException : Exception
        {
            public CalcException(string message)
                : base(message)
            { }
        }
    }
}
