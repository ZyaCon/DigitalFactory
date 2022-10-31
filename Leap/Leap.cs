using System;

namespace PriceService
{
    public static class Leap
    {

        /// <summary>
        /// Indique si l'année est une année bissextile ou non.
        /// <para>Dans le calendrier grégorien une année bissextile respecte les conditions suivantes :
        /// <br/>- Toutes les années qui sont divisibles par 4
        /// <br/>- à l'exception des années qui sont divisibles par 100
        /// <br/>- sauf si l'année est ausi divisible par 400
        /// </para>
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static bool IsLeapYear(int year)
        {
            var divisableBy4  = IsDivisableBy(year, 4);
            var divisableBy100  = IsDivisableBy(year, 100);
            var divisableBy400  = IsDivisableBy(year, 400);

            if (divisableBy4 && divisableBy400) return true;
            if (divisableBy4 && !divisableBy100) return true;


            return false;
        }

        private static bool IsDivisableBy(int year, int value)
        {
            return year % value == 0;
        }
    }
}