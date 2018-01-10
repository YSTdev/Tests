using System;
using MathLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TriangleCalcTest1
    {
        [TestMethod]
        public void TriangleCalcResult()
        {
            double a = 10;
            double b = 30;
            double c = 30;
            double expected = Math.Sqrt(21875);
            double actual = TriangleCalc.TriangleAreaCalc(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, 
        ExpectedException(typeof(TriangleCalc.CalcException),
        "Expected exception: Input arguments must be > 0!")]
        public void TriangleCalcNegative()
        {
            double a = -10;
            double b = 30;
            double c = -30;
            TriangleCalc.TriangleAreaCalc(a, b, c);
        }

        [TestMethod,
        ExpectedException(typeof(TriangleCalc.CalcException),
            "Expected exception: Data not valid!")]
        public void TriangleCalcInvalidData()
        {
            double a = 10;
            double b = 20;
            double c = 30;
            TriangleCalc.TriangleAreaCalc(a, b, c);
        }
    }
}
