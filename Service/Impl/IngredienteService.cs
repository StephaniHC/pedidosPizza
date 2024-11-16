using pedidosPizza.Data;
using pedidosPizza.Data.Repositories.Implementacion;
using pedidosPizza.DTOs;
using pedidosPizza.Factory;
using pedidosPizza.Models;

namespace pedidosPizza.Service.Impl
{
    public class IngredienteService : IIngredienteService
    {
        private readonly IIngredienteRepository _ingredienteRepository;
        private readonly IModelFactory _modelFactory;

        public IngredienteService(IIngredienteRepository ingredienteRepository, IModelFactory modelFactory)
        {
            _ingredienteRepository = ingredienteRepository;
            _modelFactory = modelFactory;
        }

        public void CreateIngrediente(IngredienteDto ingredienteDto)
        { 
            var ingrediente = _modelFactory.CreateIngrediente(ingredienteDto.Nombre, ingredienteDto.Precio);
             
            _ingredienteRepository.AddIngrediente(ingrediente);
        }

        public IngredienteDto GetIngredienteById(int id)
        { 
            var ingrediente = _ingredienteRepository.GetIngredienteById(id);
            if (ingrediente == null) return null;
             
            return new IngredienteDto
            {
                ID_Ingrediente = ingrediente.ID_Ingrediente,
                Nombre = ingrediente.Nombre,
                Precio = ingrediente.Precio
            };
        }

        public List<IngredienteDto> GetAllIngredientes()
        { 
            return _ingredienteRepository.GetAllIngredientes()
                .Select(i => new IngredienteDto
                {
                    ID_Ingrediente = i.ID_Ingrediente,
                    Nombre = i.Nombre,
                    Precio = i.Precio
                }).ToList();
        }
    }
}
