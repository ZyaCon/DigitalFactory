using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calcul
{

    /*
      1- Corriger les tests unitaires en erreur
      2- Décommenter le test Test_Factorial et corriger le test
      3- Implémenter les tests associés à la methode Fraction de ICalculusServices
    */


    [TestClass]
    public class CalculusServicesUnitTest
    {
        [TestMethod]
        public void Test_Add()
        {
            ICalculusServices calculusServices = new CalculusServices();
            var expected = 20;
            var result = calculusServices.Add(10, 10);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_Diff()
        {
            ICalculusServices calculusServices = new CalculusServices();
            var expected = 0;
            var result = calculusServices.Diff(10, 10);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_Factorial()
        {
            ICalculusServices calculusServices = new CalculusServices();
            var expected = 3628800;
            var result = calculusServices.Factorial(10);
            Assert.AreEqual(expected, result);
        }

        // TODO Test_Fraction
        [TestMethod]
        public void Test_Fraction()
        {
            ICalculusServices calculusServices = new CalculusServices();
            var expected = 5;
            var result = calculusServices.Fraction(10, 2);
            Assert.AreEqual(expected, result);
            Assert.ThrowsException<DivideByZeroException>(() => { calculusServices.Fraction(10, 0); });
        }

    }
}
