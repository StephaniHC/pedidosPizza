using pedidosPizza.Models;

namespace pedidosPizza.Data.Repositories.Implementacion
{
    public interface IIngredienteRepository
    {
        void AddIngrediente(Ingrediente ingrediente);
        Ingrediente GetIngredienteById(int id);
        List<Ingrediente> GetAllIngredientes();
    }
}
