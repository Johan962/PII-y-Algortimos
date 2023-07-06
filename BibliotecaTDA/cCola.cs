using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    public class cCola
    {
        //Atributtes
        cListaIterativa aCola;

        //Constructors
        public cCola()
        {
            aCola = new cListaIterativa();
        }
        public cCola(cListaIterativa pCola)
        {
            aCola = pCola;
        }
        //Properties
        //Metods
        public void Acolar(object pElemento)
        { 

        }
        public object Desacolar()
        {
            return null;
        }

        public object Cabeza()
        {
            return null;
        }
    }
}
