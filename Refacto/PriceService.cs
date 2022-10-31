namespace Refacto
{
    public static class PriceService
    {
        public static decimal CalculateDiscount(decimal amount, int type, int years)
        {
            // Refactorize this function
            decimal result = 0;
            decimal disc;

            disc = (years > 5) ? 5 / 100 : years / 100;
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
            // Refactorize this function
            decimal result = 0;

            if (type == 1) return amount;

            if (type == 2)
            {
                return amount - (0.1m * amount);
            }
            
            if (type == 3)
            {
                return (0.7m * amount)  ;
            }
            
            if (type == 4)
            {
                return amount - (0.5m * amount);
            }

            return result;
        }
    }
}
