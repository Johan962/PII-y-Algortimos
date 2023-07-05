using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    internal class cListaIterativa
    {
        //Attributes
        private cNodo? aFirst;

        //Constructors
        cListaIterativa()
        {
            aFirst = null;
        }

        cListaIterativa(cNodo? pFirst)
        {
            aFirst = pFirst;
        }

        //Properties

        public cNodo? First
        {
            get { return aFirst; }
            set { aFirst = value; }
        }

        //Metods

        public bool EsVacio()
        {
            return aFirst == null;
        }

        public void Listar()
        {
            cNodo? aAux = aFirst;
            Console.WriteLine("LISTA DE ELEMENTOS:");
            Console.WriteLine("-----------------------");
            while (aAux.Next != null)
            {
                Console.WriteLine("- " + aAux.Elemento);
            }    
        }

        public object? Iesimo(int pos)
        {
            cNodo? aAux = aFirst;
            int cont = 0;
            while(cont != pos)
            {
                aAux = aAux.Next; 
                cont++;
            }
            return null;
        }

        public void Agregar(object pElemento)
        {
            cNodo? aAux = aFirst;
            while(aAux.Next != null)
            {
                aAux = aAux.Next;
            }
            aAux.Next = new cNodo(pElemento);
        }

        public void Insertar(object pElemento, int pos)
        {
            cNodo? aAux = aFirst;
            int cont = 0;
            while( cont != pos)
            {
                aAux = aAux.Next;
                cont++;
            }
            aAux.Next = new cNodo(pElemento,aAux.Next.Next);
        }

        public void Eliminar(int pos)
        {

        }

        public void Eliminar(object pElemento)
        {
            
        }

        public int Ubicacion(object pElemento)
        {
            return 0;
        }

        public int Longitud()
        {
            cNodo? aAux = aFirst;
            int Long = 0;
            while (aAux != null)
            {
                Long += 1;
                aAux = aAux.Next;
            }
            return Long;
        }
    }
}
