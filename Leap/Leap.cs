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
            bool divisableBy4 = IsDivisableBy(year, 4);
            bool divisableBy100 = IsDivisableBy(year, 100);
            bool divisableBy400 = IsDivisableBy(year, 400);

            return (divisableBy4 && divisableBy400)
                || (divisableBy4 && !divisableBy100);
        }

        private static bool IsDivisableBy(int year, int value)
        {
            return year % value == 0;
        }
    }
}