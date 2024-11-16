namespace pedidosPizza.PricingStrategies
{
    public class PercentageDiscountStrategy : IPricingStrategy
    {
        private readonly decimal _discountPercentage;

        public PercentageDiscountStrategy(decimal discountPercentage)
        {
            _discountPercentage = discountPercentage;
        }

        public decimal CalculatePrice(decimal basePrice, bool is2x1Promotion)
        {
            return basePrice * (1 - _discountPercentage / 100);
        }
    }
}
