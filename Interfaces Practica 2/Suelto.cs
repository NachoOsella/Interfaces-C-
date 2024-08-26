namespace Interfaces_practica_2
{
    public class Suelto : Producto
    {
        public decimal Medida { get; set; }

        // Implementación del método CalcularPrecio para Suelto
        public override decimal CalcularPrecio()
        {
            return Medida * Precio;
        }
    }
}