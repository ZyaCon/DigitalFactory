using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Refacto.Tests
{
    [TestClass]
    public class RefactoTests
    {
        [TestMethod()]
        public void CalculateDiscountRefactorType1()
        {
            Assert.AreEqual(PriceService.CalculateDiscountRefactor(12, 1, 5), 12);
        }

        [TestMethod()]
        public void CalculateDiscounType1()
        {
            Assert.AreEqual(PriceService.CalculateDiscount(12, 1, 5), 12);
        }


        [TestMethod()]
        public void CalculateDiscountRefactorType2()
        {
            decimal value = 10.8m;
            Assert.AreEqual(PriceService.CalculateDiscountRefactor(12, 2, 5), value);
        }

        [TestMethod()]
        public void CalculateDiscounType2()
        {
            decimal value = 10.8m;
            Assert.AreEqual(PriceService.CalculateDiscount(12, 2, 5),value);
        }


        [TestMethod()]
        public void CalculateDiscountRefactorType3()
        {
            decimal value = 8.4m;
            Assert.AreEqual(PriceService.CalculateDiscountRefactor(12, 3, 5), value);
        }

        [TestMethod()]
        public void CalculateDiscounType3()
        {
            decimal value = 8.4m;
            Assert.AreEqual(PriceService.CalculateDiscount(12, 3, 5), value);
        }


        [TestMethod()]
        public void CalculateDiscountRefactorType4()
        {
            decimal value = 6.0m;
            Assert.AreEqual(PriceService.CalculateDiscountRefactor(12, 4, 5), value);
        }

        [TestMethod()]
        public void CalculateDiscounType4()
        {
            decimal value = 6.0m;
            Assert.AreEqual(PriceService.CalculateDiscount(12, 4, 5), value);
        }
    }
}
