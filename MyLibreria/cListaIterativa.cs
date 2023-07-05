using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibreria
{
    internal class cListaIterativa
    {
        //Attributes
        private cNodo aNodo;

        //Constructors

        private cListaIterativa()
        {
            aNodo = null;
        }

        private cListaIterativa(cNodo pNodo)
        {
            aNodo = pNodo;
            
        }

        //Properties 
        public cNodo Nodo
        {
            get { return aNodo; }
            set { aNodo = value; }
        }

        //Metods

        public bool isEmpty(cListaIterativa Lista)
        {
            if (Lista == null)
            {
                return true;
            } 
            
            return false;
        }

        public void append(object pObjeto)
        {
            aNodo = new cNodo(pObjeto, aNodo);
        }
    }
}
