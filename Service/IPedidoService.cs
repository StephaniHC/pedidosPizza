using pedidosPizza.DTOs;

namespace pedidosPizza.Service
{
    public interface IPedidoService
    {
        void CreatePedido(PedidoDto pedidoDto);
        PedidoDto GetPedidoById(int id);
        List<PedidoDto> GetAllPedidos();
    }
}
