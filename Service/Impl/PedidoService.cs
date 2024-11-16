using pedidosPizza.Data;
using pedidosPizza.Data.Repositories.Implementacion;
using pedidosPizza.DTOs;
using pedidosPizza.Factory;
using pedidosPizza.Models;

namespace pedidosPizza.Service.Impl
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IModelFactory _modelFactory;

        public PedidoService(IPedidoRepository pedidoRepository, IModelFactory modelFactory)
        {
            _pedidoRepository = pedidoRepository;
            _modelFactory = modelFactory;
        }

        public void CreatePedido(PedidoDto pedidoDto)
        { 
            var pedido = _modelFactory.CreatePedido(
                pedidoDto.Fecha_Pedido,
                pedidoDto.Costo_Total,
                pedidoDto.Delivery_Incluido,
                pedidoDto.Promocion_2x1_Aplicada,
                pedidoDto.Estado
            );
             
            _pedidoRepository.AddPedido(pedido);
        }

        public PedidoDto GetPedidoById(int id)
        { 
            var pedido = _pedidoRepository.GetPedidoById(id);
            if (pedido == null) return null;
             
            return new PedidoDto
            {
                ID_Pedido = pedido.ID_Pedido,
                Fecha_Pedido = pedido.Fecha_Pedido,
                Costo_Total = pedido.Costo_Total,
                Delivery_Incluido = pedido.Delivery_Incluido,
                Promocion_2x1_Aplicada = pedido.Promocion_2x1_Aplicada,
                Estado = pedido.Estado
            };
        }

        public List<PedidoDto> GetAllPedidos()
        { 
            return _pedidoRepository.GetAllPedidos()
                .Select(p => new PedidoDto
                {
                    ID_Pedido = p.ID_Pedido,
                    Fecha_Pedido = p.Fecha_Pedido,
                    Costo_Total = p.Costo_Total,
                    Delivery_Incluido = p.Delivery_Incluido,
                    Promocion_2x1_Aplicada = p.Promocion_2x1_Aplicada,
                    Estado = p.Estado
                }).ToList();
        }
    }
}
