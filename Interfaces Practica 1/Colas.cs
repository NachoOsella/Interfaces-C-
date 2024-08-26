namespace Interfaces_Practica_1;

public class Cola : ICOllection
{
    private List<object> elementos;

    public Cola()
    {
        elementos = new List<object>();
    }

    public bool EstaVacia()
    {
        if (elementos.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Añadir(object item)
    {
        elementos.Add(item);
        return true;
    }

    public object Primero()
    {
        if (EstaVacia())
        {
            return null;
        }
        else
        {
            return elementos[0];
        }
    }

    public object Extraer()
    {
        if (EstaVacia())
        {
            return null;
        }
        else
        {
            object elemento = elementos[0];
            elementos.RemoveAt(0);
            return elemento;
        }
    }

}
