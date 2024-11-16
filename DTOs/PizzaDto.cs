namespace pedidosPizza.DTOs
{
    public class PizzaDto
    {
        public int ID_Pizza { get; set; }
        public string Nombre { get; set; }
        public bool EsPersonalizada { get; set; }
        public decimal Precio_Base { get; set; }
    }
}
