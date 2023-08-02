using AppCalculadora1;

public class Program
{
    public static void Main(String[] a)

    {
        // ----- Declarar objetos
        CCalculadora Calculadora = new CCalculadora();
        String Expresion;
        // ----- Leer una expresion
        Console.WriteLine();
        Console.Write("Ingrese una expresión: ");
        Expresion = Console.ReadLine();
        // ----- Evaluar la expresion
        Console.WriteLine("El resultado es: " + Calculadora.Evaluar(Expresion));

        // ----- Pausa
        Console.ReadLine();
    }
}