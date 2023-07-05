using Clase_23_5_Algoritmos;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        cListaIterativa Lista = new cListaIterativa();
        Lista.append(new cPalabra("Perro", "Dog"));
        Lista.append(new cPalabra("Gato", "Cat"));
        Lista.append(new cPalabra("Abeja", "Bee"));

        string Buscar(string pEspanol)
        { 
            for (int i = 0; i < Lista.length(); i++)
            {
                
                Console.WriteLine(Lista.item(i));
                
            }
            return "0";
        }
    }
}