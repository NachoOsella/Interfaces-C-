namespace Interfaces_Practica_1;

public interface ICOllection
{
    bool EstaVacia();
    object Extraer();
    object Primero();
    bool Añadir(object obj);
}
