namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] argv)
        {
            C_Triangulo t = new C_Triangulo(/*new C_Punto(),new C_Punto(),new C_Punto()*/);

            Console.WriteLine(C_Triangulo.Area(t.Punto1,t.Punto2,t.Punto3 ));
            Console.WriteLine(C_Triangulo.Perimetro(t.Punto1, t.Punto2, t.Punto3));
            Console.WriteLine(t.Area());

        }
    }
}
