using System.Runtime.InteropServices.ComTypes;

namespace Interfaces_Practica_1;

class Program
{
    static void Main(string[] args)
    {
        // Para la Fila
        Console.WriteLine("Ingrese el tamaño de la pila: ");
        int tamaño = Convert.ToInt32(Console.ReadLine());
        Pila miPila = new Pila(tamaño);
        miPila.Añadir(10);
        if (miPila.Añadir(20))
        {
            Console.WriteLine("Se ha añadido el elemento 20");
        }
        else
        {
            Console.WriteLine("No se ha podido añadir el elemento 20");
        }
        if (miPila.Añadir(30))
        {
            Console.WriteLine("Se ha añadido el elemento 30");
        }
        else
        {
            Console.WriteLine("No se ha podido añadir el elemento 30");
        }

        if (miPila.EstaVacia())
        {
            Console.WriteLine("La pila está vacia");
        }
        else
        {
            Console.WriteLine("El primer item de la pila es: " + miPila.Primero());
        }

        Console.WriteLine("El elemento extraido es: " + miPila.Extraer());

        if (miPila.EstaVacia())
        {
            Console.WriteLine("No se puede mostrar el primer elemento porque la pila esta vacia...");
        }
        else
        {
            Console.WriteLine("El nuevo primer elemento es: " + miPila.Primero());
        }


        // Para la Cola
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Cola miCola = new Cola();

        miCola.Añadir(10);
        miCola.Añadir(20);
        miCola.Añadir(30);

        if (miCola.EstaVacia())
        {
            Console.WriteLine("La cola está vacia...");
        }
        else
        {
            Console.WriteLine("El primer elemento de la cola es: " + miCola.Primero());
        }

        if (miCola.EstaVacia())
        {
            Console.WriteLine("La cola está vacia");
        }
        else
        {
            Console.WriteLine("La cola tiene al menos 1 item...");
        }

        if (miCola.EstaVacia())
        {
            Console.WriteLine("La cola está vacia");
        }
        else
        {
            Console.WriteLine("El elemento extraido es: " + miCola.Extraer());
        }

        if (miCola.EstaVacia())
        {
            Console.WriteLine("La cola está vacia...");
        }
        else
        {
            Console.WriteLine("El nuevo primer elemento de la cola es: " + miCola.Primero());
        }
    }
}