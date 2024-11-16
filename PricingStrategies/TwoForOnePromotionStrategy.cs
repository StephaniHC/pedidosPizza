namespace pedidosPizza.PricingStrategies
{
    public class TwoForOnePromotionStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice, bool is2x1Promotion)
        {
            return is2x1Promotion ? basePrice / 2 : basePrice;  
        }
    }
}
