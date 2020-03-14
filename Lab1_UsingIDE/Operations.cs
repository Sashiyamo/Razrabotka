using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4sem1lab
{
    class Operations
    {

        public double a;
        public double b;
        public double c;

        public Operations(double a1, double b1, double c1)
        {
            a = a1;
            b = b1;
            c = c1;
        }

        public void Sum(double a, double b, double c)
        {
            c = a + b;
        }

        public void Sub(double a, double b, double c)
        {
            c = a - b;
        }

        public void Mul(double a, double b, double c)
        {
            c = a * b;
        }

        public void Div(double a, double b, double c)
        {
            c = a / b;
        }
        public void SumSub(double a, double b, double c)
        {
            c = a + b - a;
        }
        public void MulDiv(double a, double b, double c)
        {
            c = a * b / a;
        }
        
        public void Max(double a, double b, double c)
        {
            c = Math.Max(a, b);
        }
        public void Min(double a, double b, double c)
        {
            c = Math.Min(a, b);
        }
    }
}
