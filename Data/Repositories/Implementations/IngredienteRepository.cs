using pedidosPizza.Data.Repositories.Implementacion;
using pedidosPizza.Models;

namespace pedidosPizza.Data.Repositories.Interfaces
{
    public class IngredienteRepository : IIngredienteRepository
    {
        private readonly DataBaseHandler _dbHandler;

        public IngredienteRepository(DataBaseHandler dbHandler)
        {
            _dbHandler = dbHandler;
        }

        public void AddIngrediente(Ingrediente ingrediente) => _dbHandler.InsertIngrediente(ingrediente);

        public Ingrediente GetIngredienteById(int id) => _dbHandler.GetIngredienteById(id);

        public List<Ingrediente> GetAllIngredientes() => _dbHandler.GetAllIngredientes();
    }
}
