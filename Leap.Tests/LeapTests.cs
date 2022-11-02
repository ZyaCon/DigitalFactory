using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PriceService.Tests
{
    [TestClass]
    public class LeapTests
    {

        [DataTestMethod]
        [DataRow(2016)]
        [DataRow(2020)]
        [DataRow(2000)]
        [DataRow(2044)]
        [DataRow(2072)]
        [DataRow(2092)]
        [TestMethod()]
        public void IsLeapYearWhenDivisibleBy4(int year)
        {
            Assert.IsTrue(Leap.IsLeapYear(year));
        }

        [DataRow(1000)]
        [DataRow(2200)]
        [DataRow(2900)]
        [DataRow(700)]
        [DataRow(1700)]
        [DataRow(1300)]

        [TestMethod()]
        public void IsNotLeapYearWhenDivisibleBy4And100(int year)
        {
            Assert.IsFalse(Leap.IsLeapYear(year));
        }

        [TestMethod()]
        public void IsLeapYearTest()
        {
            Assert.IsTrue(Leap.IsLeapYear(2016));
            Assert.IsTrue(Leap.IsLeapYear(2020));
            Assert.IsTrue(Leap.IsLeapYear(2000));
            Assert.IsTrue(Leap.IsLeapYear(2044));
            Assert.IsTrue(Leap.IsLeapYear(2072));
            Assert.IsTrue(Leap.IsLeapYear(2092));
        }

        [TestMethod()]
        public void IsNotLeapYearTest()
        {
            Assert.IsFalse(Leap.IsLeapYear(2017));
            Assert.IsFalse(Leap.IsLeapYear(1997));
            Assert.IsFalse(Leap.IsLeapYear(1900));
            Assert.IsFalse(Leap.IsLeapYear(1998));
        }

    }
}
