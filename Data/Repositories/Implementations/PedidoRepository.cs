using pedidosPizza.Data.Repositories.Implementacion;
using pedidosPizza.Models;

namespace pedidosPizza.Data.Repositories.Interfaces
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly DataBaseHandler _dbHandler;

        public PedidoRepository(DataBaseHandler dbHandler)
        {
            _dbHandler = dbHandler;
        }

        public void AddPedido(Pedido pedido) => _dbHandler.InsertPedido(pedido);

        public Pedido GetPedidoById(int id) => _dbHandler.GetPedidoById(id);

        public List<Pedido> GetAllPedidos() => _dbHandler.GetAllPedidos();
    }
}
