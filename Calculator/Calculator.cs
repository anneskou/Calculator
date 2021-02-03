using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        private double sum = 0;
        private double product = 0;
        public double Add(double a, double b)
        {
            sum = a + b;
            Console.WriteLine(sum);
            return sum;
        }
        public double Subtract(double a, double b)
        {
            sum = a - b;
            Console.WriteLine(sum);
            return sum;
        }
        public double Multiply(double a, double b)
        {
            product = a * b;
            Console.WriteLine(product);
            return product;
        }

        public double Power(double x, double exp)
        {
            x = Math.Pow(x,exp);
            Console.WriteLine(x);
            return x;
        }
    }
}
