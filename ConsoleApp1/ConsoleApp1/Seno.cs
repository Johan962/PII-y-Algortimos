using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


    
namespace ConsoleApp1
{
    internal class Seno
    {
        //Metods

        static double Potencia(double p_ap, double p_bp)
        {
            double Result = 1;
            for (int i = 0; i < p_bp; i++)
            {
                Result *= p_ap;
            }
            return Result;
        }

        static double Factorial(double p_af)
        {
            if (p_af == 0)
            {
                return 1;
            }
            double Result = 1;
            for (int i = 1; i <= p_af; i++)
            {
                Result *= i;
            }
            return Result;
        }

        static double SenoST(double p_as, int p_ns)
        {
            double p_ars = (p_as/180) * Math.PI;
            double Result = 0;
            double Exponente = 1;
            for (int i = 1; i < p_ns; i++)
            {      
                if (i % 2 == 0)
                {
                    Result -= (Potencia(p_ars,Exponente)/Factorial(Exponente));
                }

                if (i % 2 == 1)
                {
                    Result += (Potencia(p_ars,Exponente) / Factorial(Exponente));
                }
                Exponente += 2;
            }

            return Result;
        }
        public static void Main()
        {
            Console.WriteLine("Ingrese el angulo: ");
            string Angulo = Console.ReadLine();
            double Angulo1 = double.Parse(Angulo);
            Console.WriteLine("Ingrese la cantidad de elementos que quiere en la Serie de Taylor: ");
            string N = Console.ReadLine();
            int N1 = int.Parse(N);

            Console.WriteLine(Seno.SenoST(Angulo1, N1));

            Console.WriteLine(Math.Sin((Angulo1/180)*Math.PI));
        }   
    }
}


