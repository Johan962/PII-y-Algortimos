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
        private object aObjeto;
        private cNodo aNodo;
        //Constructors

        public cNodo()
        {
            aObjeto = null;
            aNodo = null;
        }

        public cNodo(object pObjeto, cNodo pNodo)
        {
            aObjeto = pObjeto;
            aNodo = pNodo;
        }
        
        //Metods
        static public bool EsVacio()
        {
            if (aObjeto == null)
            {
                return true;
            }
            return false;
        }
    }
}