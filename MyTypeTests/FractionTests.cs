using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyType.Tests
{
    [TestClass()]
    public class FractionTests
    {
        [TestMethod()]
        public void AddTestDifferentDenominators()
        {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(1, 3);
            Fraction expectedResult = new Fraction(5, 6); // 1/2 + 1/3 = 5/6

            Fraction result = fraction1.Add(fraction2);

            Assert.AreEqual(expectedResult.Numerator, result.Numerator);
            Assert.AreEqual(expectedResult.Denominator, result.Denominator);
        }

        [TestMethod()]
        public void AddTestSameDenominators()
        {
            Fraction fraction1 = new Fraction(1, 3);
            Fraction fraction2 = new Fraction(1, 3);
            Fraction expectedResult = new Fraction(2, 3); // 1/3 + 1/3 = 2/3

            Fraction result = fraction1.Add(fraction2);

            Assert.AreEqual(expectedResult.Numerator, result.Numerator);
            Assert.AreEqual(expectedResult.Denominator, result.Denominator);
        }

        [TestMethod()]
        public void SubtractTestSameDenominators()
        {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(1, 4);
            Fraction expectedResult = new Fraction(2, 4);

            Fraction result = fraction1.Subtract(fraction2); // 3/4 - 1/4 = 2/4

            Assert.AreEqual(expectedResult.Numerator, result.Numerator);
            Assert.AreEqual(expectedResult.Denominator, result.Denominator);
        }

        [TestMethod()]
        public void SubtractTestDifferentDenominators()
        {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(1, 3);
            Fraction expectedResult = new Fraction(5, 12);

            Fraction result = fraction1.Subtract(fraction2); // 3/4 - 1/3 = 5/12

            Assert.AreEqual(expectedResult.Numerator, result.Numerator);
            Assert.AreEqual(expectedResult.Denominator, result.Denominator);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(2, 5);
            Fraction expectedResult = new Fraction(6, 20); // 3/4 * 2/5 = 6/20

            Fraction result = fraction1.Multiply(fraction2);

            Assert.AreEqual(expectedResult.Numerator, result.Numerator);
            Assert.AreEqual(expectedResult.Denominator, result.Denominator);
        }

        [TestMethod()]
        public void DivideTestWithoutZero()
        {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(2, 5);
            Fraction expectedResult = new Fraction(15, 8); // 3/4 / 2/5 = 15/8

            Fraction result = fraction1.Divide(fraction2);

            Assert.AreEqual(expectedResult.Numerator, result.Numerator);
            Assert.AreEqual(expectedResult.Denominator, result.Denominator);
        }

        [TestMethod()]
        public void SimplifyTest()
        {
            Fraction fraction = new Fraction(6, 8);

            fraction.Simplify();

            Assert.AreEqual(3, fraction.Numerator);
            Assert.AreEqual(4, fraction.Denominator); // 3/4
        }

        [TestMethod()]
        public void CompareToTestFirstIsBigger()
        {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(2, 5);

            int result = fraction1.CompareTo(fraction2); // 3/4 > 2/5


            Assert.IsTrue(result > 0);
        }

        [TestMethod()]
        public void CompareToTestEqual()
        {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(6, 8);

            int result = fraction1.CompareTo(fraction2);

            Assert.IsTrue(result == 0);
        }

        [TestMethod()]
        public void CompareToTestSecondIsBigger()
        {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(2, 5);

            int result = fraction2.CompareTo(fraction1); // 2 / 5 < 3 / 4

            Assert.IsTrue(result < 0);
        }
    }
}
