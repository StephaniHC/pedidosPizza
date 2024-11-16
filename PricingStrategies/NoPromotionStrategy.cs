namespace pedidosPizza.PricingStrategies
{
    public class NoPromotionStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice, bool is2x1Promotion)
        {
            return basePrice;  
        }
    }
}
