namespace Interfaces_practica_2
{
    public class Pack : Producto
    {
        public int Cantidad { get; set; }

        // Implementación del método CalcularPrecio para Pack
        public override decimal CalcularPrecio()
        {
            return Cantidad * Precio;
        }
    }
}