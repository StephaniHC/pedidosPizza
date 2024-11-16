using pedidosPizza.Models;

namespace pedidosPizza.Data.Repositories.Implementacion
{
    public interface IPizzaRepository
    {
        void AddPizza(Pizza pizza);
        Pizza GetPizzaById(int id);
        List<Pizza> GetAllPizzas();
    }
}
