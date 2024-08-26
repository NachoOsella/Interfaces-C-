namespace Interfaces_practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de productos
            List<Producto> productos = new List<Producto>
            {
                new Suelto { Codigo = 1, Nombre = "Producto Suelto 1", Precio = 10, Medida = 2 },
                new Pack { Codigo = 2, Nombre = "Producto Pack 1", Precio = 5, Cantidad = 3 },
                new Suelto { Codigo = 3, Nombre = "Producto Suelto 2", Precio = 8, Medida = 1.5m },
                new Pack { Codigo = 4, Nombre = "Producto Pack 2", Precio = 7, Cantidad = 2 }
            };

            decimal precioTotal = 0;

            // Mostrar cada producto y su precio calculado
            foreach (var producto in productos)
            {
                decimal precio = producto.CalcularPrecio();
                Console.WriteLine($"Código: {producto.Codigo}, Nombre: {producto.Nombre}, Precio Calculado: {precio:C}");
                precioTotal += precio;
            }

            // Mostrar el precio total de todos los productos
            Console.WriteLine($"\nPrecio Total: {precioTotal:C}");
        }
    }
}