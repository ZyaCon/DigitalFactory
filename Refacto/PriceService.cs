namespace Refacto
{
    public static class PriceService
    {
        private static decimal sumDiscount(decimal amount, decimal value)
        {
            return amount * value;
        }

        public static decimal CalculateDiscount(decimal amount, int type, int years)
        {
            // Refactorize this function
            decimal result = 0;
            decimal disc;

            disc = (years > 5) ? 5 / 100m : years / 100m;
            if (type == 1)
            {
                result = amount;
            }
            else if (type == 2)
            {
                result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
            }
            else if (type == 3)
            {
                result = (0.7m * amount) - disc * (0.7m * amount);
            }
            else if (type == 4)
            {
                result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
            }

            return result;
        }

        public static decimal CalculateDiscountRefactor(decimal amount, int type, int years)
        {
            decimal result = 0;
            decimal disc;



            disc = (years > 5) ? 5 / 100m : years / 100m;

            if (type == 1)
            {
                result = amount;
            }
            else if (type == 2)
            {
                result = calcPercentWithDiscount(0.9m, amount, disc);
            }
            else if (type == 3)
            {
                result = calcPercentWithDiscount(0.7m, amount, disc);
            }
            else if (type == 4)
            {
                result = calcPercentWithDiscount(0.5m, amount, disc);
            }


            return result;

            //List<KeyValuePair<int, decimal>> discountListByType = new List<KeyValuePair<int, decimal>>()
            //{
            //    new KeyValuePair<int, decimal>(1, amount),
            //    new KeyValuePair<int, decimal>(2, (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount))),
            //    new KeyValuePair<int, decimal>(3, (0.7m * amount) - disc * (0.7m * amount)),
            //    new KeyValuePair<int, decimal>(4, (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount))),
            //};

            //decimal result = discountListByType.Find(e => e.Key == type);
        }

        private static decimal calcPercentWithDiscount(decimal percent ,decimal amount, decimal disc)
        {
            return (percent * amount) - disc * (percent * amount);
        }

        //public static decimal CalculateDiscountRefactor(decimal amount, int type, int years)
        //{
        //    // Refactorize this function
        //    decimal result = 0;

        //    if (type == 1) return amount;

        //    if (type == 2)
        //    {
        //        return amount - (0.1m * amount);
        //    }

        //    if (type == 3)
        //    {
        //        return (0.7m * amount);
        //    }

        //    if (type == 4)
        //    {
        //        return amount - (0.5m * amount);
        //    }

        //    return result;
        //}
    }
}
