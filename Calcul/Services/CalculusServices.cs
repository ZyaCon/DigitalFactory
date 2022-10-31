using System;
using System.Collections.Generic;
using System.Text;

namespace Calcul
{
    public class CalculusServices : ICalculusServices
    {
        public long Add(int a, int b)
        {
            return a + b;
        }

        public int Diff(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// retourne le rapport de a/b. si b est b=0 la fonction lève une exception
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Fraction(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            return a / b;
        }

        /// <summary>
        /// Calcul le factoriel d'un nombre
        /// n! = (n-1)!*n avec 1!=1 et 0!=1
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public long Factorial(int number)
        {
            var resultValue = 1;

            for (int i = 1; i <= number; i++)
            {
                resultValue *= i;
            }

            return resultValue;
        }
    }
}
