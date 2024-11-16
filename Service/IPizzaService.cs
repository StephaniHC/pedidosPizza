using pedidosPizza.DTOs;

namespace pedidosPizza.Service
{
    public interface IPizzaService
    {
        void CreatePizza(PizzaDto pizzaDto);
        PizzaDto GetPizzaById(int id);
        List<PizzaDto> GetAllPizzas();
    }
}
