using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;

namespace Calculator
{
    [TestFixture]
    public class CalculatorTestUnit
    {
        public Calculator Uut;

        [SetUp]
        public void Setup()
        {
            Uut = new Calculator();
        }


        [TestCase(0.0, 0.0, 0.0)]
        [TestCase(1.0, 3.0, 4.0)]
        [TestCase(-1.0, 2.0, 1.0)]
        public void Add_AddaAndB_returnsResult(double a, double b, double result)
        {
            Assert.That(Uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(0.0, 0.0, 0.0)]
        [TestCase(1.0, 3.0, -2.0)]
        [TestCase(-1.0, -2.0, 1.0)]
        public void Subtract_SubtractaAndb_returnsResult(double a, double b, double result)
        {
            Assert.That(Uut.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(0.0, 0.0, 0.0)]
        [TestCase(1.0, 3.0, 3.0)]
        [TestCase(-1.0, -2.0, 2.0)]
        public void Multiply_MultiplyaAndB_returnsResult(double a, double b, double result)
        {
            Assert.That(Uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(0.0, 0.0, 1.0)]
        [TestCase(1.0, 3.0, 1.0)]
        [TestCase(2.0, 3.0, 8.0)]
        public void Power_PoweraAndB_returnsResult(double a, double b, double result)
        {
            Assert.That(Uut.Power(a, b), Is.EqualTo(result));
        }





    }
}
