using pedidosPizza.Models;
using SQLite;

namespace pedidosPizza.Data
{
    public class DataBaseHandler
    {
        public readonly SQLiteConnection database;
        private const string DATABASE_NAME = "BD_PIZZA.db";

        public DataBaseHandler()
        {
            string databasePath = Path.Combine(Directory.GetCurrentDirectory(), DATABASE_NAME);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Pedido>();
            database.CreateTable<Pizza>();
            database.CreateTable<Ingrediente>();
            database.CreateTable<PizzaIngrediente>();
            database.CreateTable<PedidoPizza>();
            SeedData();  
        }

        private void SeedData()
        {
            if (!database.Table<Pizza>().Any())
            {
                var defaultPizzas = new List<Pizza>
                {
                    new Pizza { Nombre = "Margarita", EsPersonalizada = false, Precio_Base = 8.99m },
                    new Pizza { Nombre = "Hawaiana", EsPersonalizada = false, Precio_Base = 10.99m }
                };

                foreach (var pizza in defaultPizzas)
                {
                    database.Insert(pizza);
                }
            }

            if (!database.Table<Ingrediente>().Any())
            {
                var defaultIngredientes = new List<Ingrediente>
                {
                    new Ingrediente { Nombre = "Queso Mozzarella", Precio = 1.50m },
                    new Ingrediente { Nombre = "Tomate", Precio = 0.50m },
                    new Ingrediente { Nombre = "Jamón", Precio = 2.00m },
                    new Ingrediente { Nombre = "Piña", Precio = 1.00m }
                };

                foreach (var ingrediente in defaultIngredientes)
                {
                    database.Insert(ingrediente);
                }
            }
        }
         
        public void InsertPedido(Pedido pedido)
        {
            database.Insert(pedido);
        }

        public Pedido GetPedidoById(int idPedido)
        {
            return database.Table<Pedido>().FirstOrDefault(p => p.ID_Pedido == idPedido);
        }

        public List<Pedido> GetAllPedidos()
        {
            return database.Table<Pedido>().ToList();
        }
         
        public void InsertPizza(Pizza pizza)
        {
            database.Insert(pizza);
        }

        public Pizza GetPizzaById(int idPizza)
        {
            return database.Table<Pizza>().FirstOrDefault(p => p.ID_Pizza == idPizza);
        }

        public List<Pizza> GetAllPizzas()
        {
            return database.Table<Pizza>().ToList();
        }
         
        public void InsertIngrediente(Ingrediente ingrediente)
        {
            database.Insert(ingrediente);
        }

        public Ingrediente GetIngredienteById(int idIngrediente)
        {
            return database.Table<Ingrediente>().FirstOrDefault(i => i.ID_Ingrediente == idIngrediente);
        }

        public List<Ingrediente> GetAllIngredientes()
        {
            return database.Table<Ingrediente>().ToList();
        }
         
        public void InsertPizzaIngrediente(PizzaIngrediente pizzaIngrediente)
        {
            database.Insert(pizzaIngrediente);
        }

        public List<PizzaIngrediente> GetIngredientesByPizzaId(int idPizza)
        {
            return database.Table<PizzaIngrediente>().Where(pi => pi.ID_Pizza == idPizza).ToList();
        }

        public List<PizzaIngrediente> GetAllPizzaIngredientes()
        {
            return database.Table<PizzaIngrediente>().ToList();
        }
         
        public void InsertPedidoPizza(PedidoPizza pedidoPizza)
        {
            database.Insert(pedidoPizza);
        }

        public List<PedidoPizza> GetPizzasByPedidoId(int idPedido)
        {
            return database.Table<PedidoPizza>().Where(pp => pp.ID_Pedido == idPedido).ToList();
        }

        public List<PedidoPizza> GetAllPedidoPizzas()
        {
            return database.Table<PedidoPizza>().ToList();
        }
    }
}
