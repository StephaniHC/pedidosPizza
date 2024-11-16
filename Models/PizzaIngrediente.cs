using SQLite;

namespace pedidosPizza.Models
{
    public class PizzaIngrediente
    {
        [PrimaryKey, AutoIncrement]
        public int ID_PizzaIngrediente { get; set; }

        [Indexed]
        public int ID_Pizza { get; set; } // Foreign Key a Pizza

        [Indexed]
        public int ID_Ingrediente { get; set; } // Foreign Key a Ingrediente

        public int Cantidad { get; set; } // Cantidad del ingrediente en la pizza
    }
}
