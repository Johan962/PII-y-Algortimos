using BibliotecaTDA;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
  
    private static void Main(string[] args)
    {

        //Define variables
        cListaRecursiva Lista = new cListaRecursiva();
        cArbol ArbolEnario = new cArbol();
        cArbolBinario ArbolBinario = new cArbolBinario();
        cArbolBB ArbolBB = new cArbolBB();
        cArbolAVL ArbolAVL = new cArbolAVL();
        Lista.Agregar(5);
        Lista.Agregar(4);
        Lista.Agregar(1);
        Lista.Agregar(2);
        Lista.Agregar(3);
        Lista.Agregar(6);
        Lista.Agregar(7);
        Lista.Agregar(8);
        
        for (int i = 0; i < Lista.Longitud(); i++)
        {
            ArbolEnario.Agregar(Lista.Iesimo(i));
            ArbolBinario.Agregar(Lista.Iesimo(i));
            ArbolBB.Agregar(Lista.Iesimo(i));
            ArbolAVL.Agregar(Lista.Iesimo(i));

        }
        Console.WriteLine("Recorrido in Orden Enario");
        ArbolEnario.RecorrerInOrden();
        Console.WriteLine("Recorrido in Orden Binario");
        ArbolBinario.RecorrerInOrden();
        Console.WriteLine("Recorrido in Orden BB");
        ArbolBB.RecorrerInOrden();
        Console.WriteLine("Recorrido in Orden AVL");
        ArbolAVL.RecorrerInOrden();


        int ObjetoBuscado = 6;
        Console.WriteLine("Arbol enario");
        ArbolEnario.SubArbol(ObjetoBuscado);
        Console.WriteLine("Arbol Binario");
        ArbolBinario.SubArbol(ObjetoBuscado);
        Console.WriteLine("Arbol BB");
        ArbolBB.SubArbol(ObjetoBuscado);
        Console.WriteLine("Arbol AVL");
        ArbolAVL.SubArbol(ObjetoBuscado);


    }
}