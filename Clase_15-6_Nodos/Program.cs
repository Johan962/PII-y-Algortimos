using BibliotecaTDA;

internal class Program
    {
        public static void test ( )
        {
            cListaRecursiva lista = new cListaRecursiva();
            // ListaRecursiva lista = new ListaRecursiva();

            lista.Agregar( 9 );
            lista.Agregar( 4 );
            lista.Agregar( 1 );
            lista.Agregar( 5 );
            lista.Agregar( 4 );
            lista.Listar();
            Console.WriteLine($"len: { lista.Longitud() }");
            Console.WriteLine();

            //lista.Insertar( 7, 0 );
            //lista.Insertar( 7, 2 );
            //lista.Insertar( 7, 4 );
            //lista.Listar();
            //Console.WriteLine();

            Console.WriteLine($"{ lista.Iesimo(0) }");
            Console.WriteLine($"{ lista.Iesimo(1) }");
            Console.WriteLine($"{ lista.Ubicacion( 1 ) }");
            Console.WriteLine($"{ lista.Ubicacion( 4 ) }");
            Console.WriteLine();

            lista.Eliminar( 7 );
            lista.Eliminar( 7 );
            lista.Eliminar( 1 );
            //lista.Listar();
            Console.WriteLine();

            //lista.pop( 0 );
            //lista.pop( 1 );
            //lista.Listar();
            Console.WriteLine();
        }

        public static void Main ( string[] argv )
        {
            test();
        }
    }