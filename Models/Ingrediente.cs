using SQLite;

namespace pedidosPizza.Models
{
    public class Ingrediente
    {
        [PrimaryKey, AutoIncrement]
        public int ID_Ingrediente { get; set; }

        public string Nombre { get; set; } // Ejemplo: Pepperoni, Queso, Tomate

        public decimal Precio { get; set; }
    }
}
