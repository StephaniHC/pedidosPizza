namespace pedidosPizza.PricingStrategies
{
    public interface IPricingStrategy
    {
        decimal CalculatePrice(decimal basePrice, bool is2x1Promotion);
    }
}
