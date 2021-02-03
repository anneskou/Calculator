using NUnit.Framework;


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var uut = new Calculator.Calculator();
        }

        [TestCase(3, 4, 7)]
        public void Add_twoPositiveNumbers_expected(double a, double b, double expected)
        {
            

        }
    }
}