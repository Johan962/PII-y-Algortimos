internal class Program
{
    private static void Main(string[] args)
    {
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
    }
}