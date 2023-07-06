using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    public class cPila : cListaIterativa
    {
        //Attributes

        cListaIterativa aPila;

        //Constructors

        public cPila()
        {
            aPila = new cListaIterativa();
        }

        cPila(cListaIterativa pPila)
        {
            aPila = pPila;
        }

        //Properties

        public cListaIterativa Pila
        {
            get { return aPila; }
            set { aPila = value; }
        }
        //Metods

        public void Apilar(object pElemento)
        {
            Pila.Agregar(pElemento);
        }

        public object Desapilar()
        {
            return null;
        }

        public object Cima()
        {
            return null;
        }
    }
}
