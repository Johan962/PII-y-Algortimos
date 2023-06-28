using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_15_6_Nodos
{
    internal class cNodo
    {
        //Attributes
        private object aPrimero;
        private cNodo aNodo;
        //Constructors

        public cNodo()
        {
            aPrimero = new object();
            aNodo = new cNodo();
        }

        public cNodo(object pPrimero, cNodo pNodo)
        {
            aPrimero = pPrimero;
            aNodo = pNodo;
        }
        
        //Metods
        static public bool EsVacio(object pObjeto)
        {
            return true;
        }
    }
}