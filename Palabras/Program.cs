using Palabras;
using BibliotecaTDA;
using System.Runtime.Serialization.Formatters;

public class Program
{
    private static void Main(string[] args)
    {
        cListaIterativa Lista = new cListaIterativa();

        Lista.Agregar(new cPalabra("Gato", "Cat"));
        Lista.Agregar(new cPalabra("Perro", "Dog"));
        Console.WriteLine(Lista.EsVacio());
        Console.WriteLine(Lista.Longitud());
        Console.WriteLine("LISTA DE PALABRAS");
        Console.WriteLine("----------------------------");
        for (int i = 0;i < Lista.Longitud(); i++)
        { 
            Console.WriteLine(Lista.Iesimo(i).ToString());
        }
    }
}