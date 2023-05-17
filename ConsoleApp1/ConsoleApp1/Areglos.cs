using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Areglos
    {
        //Metods
        public static int[] Buscar(int[] p_aA, string p_elto)
        {
            int[] Result = new int[p_aA.Length];
            for (int i = 0; i < p_aA.Length; i++)
            {
                if (p_aA[i].ToString() == p_elto)
                {
                    Result[i]==1;
                }
            }
            return Result;
        }

        public static int[] Eliminar(int[] p_aA, string p_elto)
        {
            int[] Result = new int[p_aA.Length];
            for (int i = 0; i < p_aA.Length; i++)
            {
                if (p_aA[i].ToString() == p_elto)
                {
                    Result[i] == 1;
                }
            }
        }
    }
}
