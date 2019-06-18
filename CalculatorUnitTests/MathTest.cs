using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorUnitTests
{
    [TestClass]
    public class MathTest
    {
        private Calculator.Math math;

        [TestInitialize]
        public void SetupContext()
        {
            math = new Calculator.Math();
        }
        [TestMethod]
        public void Calculator_Add_ShouldRetur25()
        {
            Assert.AreEqual(math.Add(20, 5), 25);
        }

        [TestMethod]
        public void Calculator_Sub_ShouldRetur15()
        {
            Assert.AreEqual(math.Sub(20, 5), 15);
        }

        [TestMethod]
        public void Calculator_Mult_ShouldRetur50()
        {
            Assert.AreEqual(math.Mult(10, 5), 50);
        }

        [TestMethod]
        public void Calculator_Div_ShouldRetur1()
        {
            Assert.AreEqual(math.Div(100, 100), 1);
        }
    }
}
