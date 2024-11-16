using pedidosPizza.DTOs;

namespace pedidosPizza.Service
{
    public interface IIngredienteService
    {
        void CreateIngrediente(IngredienteDto ingredienteDto);
        IngredienteDto GetIngredienteById(int id);
        List<IngredienteDto> GetAllIngredientes();
    }
}
