using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator calculator = new Calculator();
            Console.WriteLine("a = 2 og b = 2");
            calculator.Add(2, 2);
            Console.WriteLine("a = 2 og b = 2");
            calculator.Subtract(2, 2);
            Console.WriteLine("a = 2 og b = 2");
            calculator.Multiply(2, 2);
            Console.WriteLine("a = 2 og b = 3");
            calculator.Power(2, 3);
        }
    }
}
