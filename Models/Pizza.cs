using SQLite;

namespace pedidosPizza.Models
{
    public class Pizza
    {
        [PrimaryKey, AutoIncrement]
        public int ID_Pizza { get; set; }

        public string Nombre { get; set; } // Ejemplo: Margarita, Hawaiana

        public bool EsPersonalizada { get; set; }

        public decimal Precio_Base { get; set; }
    }
}
