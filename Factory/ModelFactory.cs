using pedidosPizza.Models;

namespace pedidosPizza.Factory
{
    public class ModelFactory : IModelFactory
    {
        public Pedido CreatePedido(DateTime fechaPedido, decimal costoTotal, bool deliveryIncluido, bool promocion2x1, string estado)
        {
            return new Pedido
            {
                Fecha_Pedido = fechaPedido,
                Costo_Total = costoTotal,
                Delivery_Incluido = deliveryIncluido,
                Promocion_2x1_Aplicada = promocion2x1,
                Estado = estado
            };
        }

        public Pizza CreatePizza(string nombre, bool esPersonalizada, decimal precioBase)
        {
            return new Pizza
            {
                Nombre = nombre,
                EsPersonalizada = esPersonalizada,
                Precio_Base = precioBase
            };
        }

        public Ingrediente CreateIngrediente(string nombre, decimal precio)
        {
            return new Ingrediente
            {
                Nombre = nombre,
                Precio = precio
            };
        }

        public PizzaIngrediente CreatePizzaIngrediente(int idPizza, int idIngrediente, int cantidad)
        {
            return new PizzaIngrediente
            {
                ID_Pizza = idPizza,
                ID_Ingrediente = idIngrediente,
                Cantidad = cantidad
            };
        }

        public PedidoPizza CreatePedidoPizza(int idPedido, int idPizza)
        {
            return new PedidoPizza
            {
                ID_Pedido = idPedido,
                ID_Pizza = idPizza
            };
        }
    }
}
