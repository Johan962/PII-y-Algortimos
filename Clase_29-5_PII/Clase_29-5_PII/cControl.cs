using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clase_29_5_PII
{
    public class cControl
    {

        public int MenuRegistro()
        {
            Console.WriteLine("     & 1.- Ingresar Libro");
            Console.WriteLine("     & 2.- Ingresar Revista");
            Console.WriteLine("     & 3.- Mostrar Registro");
            Console.WriteLine("     & 4.- Contar el numero de libros y revistas");
            Console.WriteLine("     & 5.- Salir");
            Console.Write("Ingrese una Opcion (1-5) -> ");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }
        public void Contar(ArrayList listaPublicaciones)
        {
            int NroLibros = 0;
            int NroRevistas = 0;
            foreach (cPublicacion publicacion in listaPublicaciones)
            {
                if (publicacion is cLibro)
                {
                    NroLibros++;
                }
                else
                {
                    NroRevistas++;
                }
            }

            Console.WriteLine("El numero de libros es " + NroLibros + " y el numero de revistas es " + NroRevistas);
        }

        public void Info(ArrayList Publicaciones)
        {
            Console.WriteLine("Relacion de Publicaciones ");
            foreach (cPublicacion Publicacion in Publicaciones)
                Console.WriteLine(Publicacion.ToString());

        }
        public void Ejecutar()
        {
            // VARIABLES

            ArrayList ListaPublicaciones = new ArrayList();
            int opcion;

            do
            {
                opcion = MenuRegistro();
                switch (opcion)
                {
                    case 1:
                        cLibro Libro = new cLibro();
                        Libro.Leer();
                        foreach(cPublicacion publicacion in ListaPublicaciones)
                        {
                            if (Libro.Equals(publicacion))
                            {
                                Console.WriteLine("ESTE LIBRO YA EXISTE");
                                break;
                            }
                        }
                        ListaPublicaciones.Add(Libro);
                        //((cPublicacion)ListaPublicaciones[ListaPublicaciones.Count - 1]).Leer();
                        break;
                    case 2:
                        cRevista Revista = new cRevista();
                        Revista.Leer();
                        ListaPublicaciones.Add(Revista);
                        //((cPublicacion)ListaPublicaciones[ListaPublicaciones.Count - 1]).Leer();
                        break;
                    case 3:
                        Info(ListaPublicaciones);
                        break;
                    case 4:
                        Contar(ListaPublicaciones);
                        break;
                }
            } while (opcion != 5);
        }
    }
}