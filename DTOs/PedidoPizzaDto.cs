namespace pedidosPizza.DTOs
{
    public class PedidoPizzaDto
    {
        public int ID_Pedido { get; set; }
        public int ID_Pizza { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Total { get; set; }
    }
}
