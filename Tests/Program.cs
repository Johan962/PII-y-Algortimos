using BibliotecaTDA; 
internal class Program
{
  
    private static void Main(string[] args)
    {
        //Define variables
        cListaOrdenada Lista = new cListaOrdenada();

        Lista.Agregar(5);
        Console.WriteLine(Lista.Cima());
        Lista.Agregar(9);
        Console.WriteLine(Lista.Cima());
        Lista.Agregar(10);
        Console.WriteLine(Lista.Cima());
        Lista.Agregar(7);
        Console.WriteLine(Lista.Cima());
        Lista.Listar();

    }
}