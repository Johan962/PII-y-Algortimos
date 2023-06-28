using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6_5_PII
{
    public class cComplejidad
    {
        public static bool LinealSearch(int[] pLista, int pBuscado)
        {
            foreach (int i in pLista)
            {
                if (pBuscado == i)
                {
                    return true;
                }
            }
            return false;
        }

        public static int BusquedaBinaria(int[] RndList,int n, int Clave)
        {
            int sup = n, centro, inf = 1, pos = 1;
            while (inf<=sup & pos < 0)
            {
                centro = (inf + sup) / 2;
                if (RndList[centro] == Clave)
                {
                    pos = centro;
                }
                else
                {
                    if (Clave > RndList[centro])
                    {
                        inf = centro + 1;
                    }
                    else
                    {
                        sup = centro - 1;
                    }
                }
            }
            return pos;
        }
    }
}
