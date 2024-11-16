using pedidosPizza.PricingStrategies;

namespace pedidosPizza.Service.Impl
{
    public class PricingService
    {
        private IPricingStrategy _pricingStrategy;

        public PricingService(IPricingStrategy pricingStrategy)
        {
            _pricingStrategy = pricingStrategy;
        }

        public void SetStrategy(IPricingStrategy pricingStrategy)
        {
            _pricingStrategy = pricingStrategy;
        }

        public decimal GetPrice(decimal basePrice, bool is2x1Promotion)
        {
            return _pricingStrategy.CalculatePrice(basePrice, is2x1Promotion);
        }
    }
}
