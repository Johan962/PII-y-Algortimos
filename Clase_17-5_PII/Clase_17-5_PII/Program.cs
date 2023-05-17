
using Clase_17_5_PII;
internal class Program
{
    private static void Main(string[] args)

    {

        C_Vehiculo[] Objetos1 = new C_Vehiculo[2];
        Objetos1[0] = new C_Auto();
        Objetos1[1] = new C_Camion();

        while (true)
        {

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Ingrese la Opcion");
            Console.WriteLine("1. Peaje de Auto");
            Console.WriteLine("2. Peaje de Camion");
            Console.WriteLine("3. Salir");
            string Opcion = Console.ReadLine();
            

            if (int.Parse(Opcion) == 1)
            {
                Console.WriteLine("El peaje del auto es: " + Objetos1[0].Peaje());
            }
            else
            {
                if (int.Parse(Opcion) == 2)
                {
                    Console.WriteLine("El peaje del camion es: " + Objetos1[1].Peaje());
                }
                else
                {
                    break;
                }
            }
        }
    }    
}