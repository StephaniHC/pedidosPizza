using pedidosPizza.Data;
using pedidosPizza.Data.Repositories.Implementacion;
using pedidosPizza.DTOs;
using pedidosPizza.Factory;
using pedidosPizza.Models;

namespace pedidosPizza.Service.Impl
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _pizzaRepository;
        private readonly IModelFactory _modelFactory;
        private readonly PricingService _pricingService;

        public PizzaService(IPizzaRepository pizzaRepository, IModelFactory modelFactory, PricingService pricingService)
        {
            _pizzaRepository = pizzaRepository;
            _modelFactory = modelFactory;
            _pricingService = pricingService;
        }

        public void CreatePizza(PizzaDto pizzaDto)
        {
            var pizza = _modelFactory.CreatePizza(pizzaDto.Nombre, pizzaDto.EsPersonalizada, pizzaDto.Precio_Base);
            _pizzaRepository.AddPizza(pizza);
        }

        public List<PizzaDto> GetAllPizzas()
        {
            throw new NotImplementedException();
        }

        public PizzaDto GetPizzaById(int id)
        {
            var pizza = _pizzaRepository.GetPizzaById(id);
            if (pizza == null) return null;

            var finalPrice = _pricingService.GetPrice(pizza.Precio_Base, false);
            return new PizzaDto
            {
                ID_Pizza = pizza.ID_Pizza,
                Nombre = pizza.Nombre,
                EsPersonalizada = pizza.EsPersonalizada,
                Precio_Base = finalPrice
            };
        }
    }

}
