namespace Interfaces_practica_2
{
    public abstract class Producto : IPrecio
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        // Método abstracto para calcular el precio
        public abstract decimal CalcularPrecio();
    }
}