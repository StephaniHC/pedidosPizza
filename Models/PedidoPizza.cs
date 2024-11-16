using SQLite;

namespace pedidosPizza.Models
{
    public class PedidoPizza
    {
        [PrimaryKey, AutoIncrement]
        public int ID_PedidoPizza { get; set; }

        [Indexed]
        public int ID_Pedido { get; set; } // Foreign Key a Pedido

        [Indexed]
        public int ID_Pizza { get; set; } // Foreign Key a Pizza

        public int Cantidad { get; set; } // Cantidad de esta pizza en el pedido

        public decimal Precio_Total { get; set; } // Precio total de la pizza considerando promociones
    }
}
