using pedidosPizza.Data.Repositories.Implementacion;
using pedidosPizza.Models;

namespace pedidosPizza.Data.Repositories.Interfaces
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly DataBaseHandler _dbHandler;

        public PizzaRepository(DataBaseHandler dbHandler)
        {
            _dbHandler = dbHandler;
        }

        public void AddPizza(Pizza pizza) => _dbHandler.InsertPizza(pizza);

        public Pizza GetPizzaById(int id) => _dbHandler.GetPizzaById(id);

        public List<Pizza> GetAllPizzas() => _dbHandler.GetAllPizzas();
    }
}
