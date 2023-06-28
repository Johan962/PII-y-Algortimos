using System.Diagnostics;
using System.Globalization;
using Clase_6_5_PII;
internal class Program
{
    private static void Main(string[] args)
    {

        // Random list of n Numbers
        Console.WriteLine("Ingrese de cuantos numeros quiere la lista:");
        Random rnd = new Random();
        int N = int.Parse(Console.ReadLine());
        int[] RndList = new int[N];
        for (int i  = 0; i < N; i++)
        {
            int RndNumber = rnd.Next(10,100);
            RndList[i] = RndNumber;
        }

        cComplejidad.LinealSearch(RndList, 10);
        cComplejidad.BusquedaBinaria(RndList,10,13);

        var timer = new Stopwatch();
        timer.Start();
        for (int i = 0; i < 1000000000; i++)
        {
            int x = i * i + 1;
        }
        timer.Stop();

        TimeSpan TiempoTotal = timer.Elapsed;
        string Cadena = "Tiempo total: " + TiempoTotal.ToString(@"m\:ss\.fff");
        Console.WriteLine(Cadena);
    }
}