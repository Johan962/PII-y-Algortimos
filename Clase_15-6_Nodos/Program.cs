using BibliotecaTDA;

internal class Program
    {
        public static void test ( )
        {
             cListaOrdenada lista = new cListaOrdenada();
            // ListaRecursiva lista = new ListaRecursiva();

            lista.Agregar( 9 );
            lista.Agregar( 4 );
            lista.Agregar( 1 );
            lista.Agregar( 5 );
            lista.Agregar( 4 );
            lista.Listar();
            Console.WriteLine($"len: { lista.Longitud() }");
            Console.WriteLine();
        }

        public static void Main ( string[] argv )
        {
            test();
        }
    }