using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 5;
            double sum = Add(a, b);
            Console.WriteLine("sum = {0}", sum);
        }

        static double Add(double a, double b)
        {
            return a + b;

        }
        static double Divide(double a, double b)
        {
            return (a / b);
        }

        static double subtract(double a, double b)
        {
            return a - b;
        }

        static double multiply(double a, double b)
        {
            return a * b;
        }
    }
}
