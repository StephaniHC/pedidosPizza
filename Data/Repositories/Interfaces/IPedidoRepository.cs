using pedidosPizza.Models;

namespace pedidosPizza.Data.Repositories.Implementacion
{
    public interface IPedidoRepository
    {
        void AddPedido(Pedido pedido);
        Pedido GetPedidoById(int id);
        List<Pedido> GetAllPedidos();
    }
}
