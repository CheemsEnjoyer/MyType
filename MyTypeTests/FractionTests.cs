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

            Fraction result = fraction1 + fraction2;

            Assert.AreEqual("5/6", result.ToString()); // 1/3 + 1/2 = 5/6
        }

        [TestMethod()]
        public void AddTestSameDenominators()
        {
            Fraction fraction1 = new Fraction(1, 3);
            Fraction fraction2 = new Fraction(1, 3);

            Fraction result = fraction1 + fraction2;

            Assert.AreEqual("2/3", result.ToString()); // 1/3 + 1/3 = 2/3
        }

        [TestMethod()]
        public void SubtractTestSameDenominators()
        {
            Fraction fraction1 = new Fraction(3, 4); 
            Fraction fraction2 = new Fraction(1, 4);

            Fraction result = fraction1 - fraction2;

            Assert.AreEqual("2/4", result.ToString()); // 3/4 - 1/4 = 2/4
        }

        [TestMethod()]
        public void SubtractTestDifferentDenominators()
        {
        Fraction fraction1 = new Fraction(3, 4);
        Fraction fraction2 = new Fraction(1, 3);

        Fraction result = fraction1 - fraction2;

        Assert.AreEqual("5/12", result.ToString()); // 3/4 - 1/3 = 5/12
        }

        [TestMethod()]
        public void MultiplyTest()
        {

        Fraction fraction1 = new Fraction(3, 4);
        Fraction fraction2 = new Fraction(2, 3); 

        Fraction result = fraction1 * fraction2;

        Assert.AreEqual("6/12", result.ToString()); // 3/4* 2/3 = 6/12
        }

        [TestMethod()]
        public void DivideTestWithoutZero()
        {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(2, 3);

            Fraction result = fraction1 / fraction2;

            Assert.AreEqual("9/8", result.ToString()); // 3/4 / 2/3 = 9/8
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
