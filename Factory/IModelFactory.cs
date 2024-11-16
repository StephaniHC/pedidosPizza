using pedidosPizza.Models;

namespace pedidosPizza.Factory
{
    public interface IModelFactory
    {
        Pedido CreatePedido(DateTime fechaPedido, decimal costoTotal, bool deliveryIncluido, bool promocion2x1, string estado);
        Pizza CreatePizza(string nombre, bool esPersonalizada, decimal precioBase);
        Ingrediente CreateIngrediente(string nombre, decimal precio);
        PizzaIngrediente CreatePizzaIngrediente(int idPizza, int idIngrediente, int cantidad);
        PedidoPizza CreatePedidoPizza(int idPedido, int idPizza);
    }
}
