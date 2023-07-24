using AppCalculadora;
internal class Program
{
    private static void Main(string[] args)
    {

        cCalculadora Calculadora = new cCalculadora();
        string Expresion;

        Console.WriteLine();

        Console.Write("Ingrese la expresion: ");
        Expresion = Console.ReadLine();

        Console.WriteLine("El resultado es: " + Calculadora.Evaluar(Expresion));
        
        Console.ReadLine();
    }
}

