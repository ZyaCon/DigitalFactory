using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Refacto.Tests
{
    [TestClass]
    public class RefactoTests
    {
        [TestMethod()]
        public void CompareCalculateDiscountType1()
        {
            var original = PriceService.CalculateDiscount(12, 1, 5);
            var refactor = PriceService.CalculateDiscountRefactor(12, 1, 5);

            Assert.AreEqual(original, refactor);
        }

        [TestMethod()]
        public void CompareCalculateDiscountType2()
        {
            var original = PriceService.CalculateDiscount(100, 2, 5);
            var refactor = PriceService.CalculateDiscountRefactor(100, 2, 5);

            Assert.AreEqual(original, refactor);
        }

        [TestMethod()]
        public void CompareCalculateDiscountType3()
        {
            var original = PriceService.CalculateDiscount(123, 3, 4);
            var refactor = PriceService.CalculateDiscountRefactor(123, 3, 4);

            Assert.AreEqual(original, refactor);
        }

        [TestMethod()]
        public void CompareCalculateDiscountType4()
        {
            var original = PriceService.CalculateDiscount(444, 4, 2);
            var refactor = PriceService.CalculateDiscountRefactor(444, 4, 2);

            Assert.AreEqual(original, refactor);
        }

    }
}
