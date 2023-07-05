using Palabras;
using BibliotecaTDA;

internal class Program
{
    private static void Main(string[] args)
    {
        cListaIterativa Lista = new cListaIterativa();
        Lista.EsVacio();
        Lista.Agregar(new cPalabra("Perro", "Dog"));
        Lista.Agregar(new cPalabra("Gato", "Cat"));
        Lista.Agregar(new cPalabra("Abeja", "Bee"));

        Lista.Listar();
    }
}