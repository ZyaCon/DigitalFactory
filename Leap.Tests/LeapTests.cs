using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PriceService.Tests
{
    [TestClass]
    public class LeapTests
    {
        [TestMethod()]
        public void IsLeapYearTest()
        {
            Assert.IsTrue(Leap.IsLeapYear(2016));
            Assert.IsTrue(Leap.IsLeapYear(2020));
            Assert.IsTrue(Leap.IsLeapYear(2000));
            Assert.IsTrue(Leap.IsLeapYear(2044));
            Assert.IsTrue(Leap.IsLeapYear(2072));
            Assert.IsTrue(Leap.IsLeapYear(2092));

            Assert.IsFalse(Leap.IsLeapYear(2017));
            Assert.IsFalse(Leap.IsLeapYear(1997));
            Assert.IsFalse(Leap.IsLeapYear(1900));
            Assert.IsFalse(Leap.IsLeapYear(1998));
        }

    }
}
