namespace pedidosPizza.DTOs
{
    public class PedidoDto
    {
        public int ID_Pedido { get; set; } 
        public DateTime Fecha_Pedido { get; set; }
        public decimal Costo_Total { get; set; }
        public bool Delivery_Incluido { get; set; }
        public bool Promocion_2x1_Aplicada { get; set; }
        public string Estado { get; set; }
    }
}
