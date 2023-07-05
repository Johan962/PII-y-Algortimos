internal class Program
{
    private static void Main(string[] args)
    {
        static int[] Burbuja(int[] pLista)
        {
            int Temp;
            for (int k = 0; k < pLista.Length; k++)
            {
                for (int i = 0; i < pLista.Length - 1; i++)
                {
                    if (pLista[i] > pLista[i + 1])
                    {
                        Temp = pLista[i];
                        pLista[i] = pLista[i + 1];
                        pLista[i + 1] = Temp;
                    }
                }
            }
            return pLista;
        }

        static string MostrarLista(int[] pLista)
        {
            string listaStr = "[";
            foreach (int E in pLista)
            {
                listaStr += " " + E.ToString();
            }
            return listaStr + "]";
        }

        static int[] SeleccionDirecta(int[] pLista)
        {
            int Inicio = 0;
            for (int k = 0; k < pLista.Length; k++)
            {
                int Menor = pLista[k];
                for (int i = Inicio; i < pLista.Length; i++)
                {   
                    // Console.WriteLine(i);
                    if (pLista[i] < Menor)
                    {
                        Menor = pLista[i];
                    }
                    Console.WriteLine(Menor.ToString());
                    Inicio++;
                }
                pLista[k] = Menor;
            }
            return pLista;
        }

        static bool BusquedaLineal(int[] pLista, int pValor)
        {
            foreach (int p in pLista)
            {
                if (p == pValor)
                {
                    return true;
                }
            }
            return false;
        }

        static string BusquedaBinaria(int[] pLista, int Valor)
        {

        }

        //Main Program
        int[] lista = {9,8,7,6,5,4,3,2,1};
        Console.WriteLine(MostrarLista(SeleccionDirecta(lista)));
        
    }
}