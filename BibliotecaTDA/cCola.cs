using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    public class cCola : cListaRecursiva
    {

        //Atributtes
        private object aObjeto;
        cCola aSubcola;

        //Constructors
        public cCola()
        {
            aObjeto = null;
            aSubcola = new cCola();
        }
        public cCola(object pObjeto, cCola pCola)
        {
            aObjeto= pObjeto;
            aSubcola = pCola;
        }
        //Properties

        public cCola Subcola
        {
            get { return aSubcola; }   
            set { aSubcola = value; }
        }
        //Metods

        public bool EsVacio()
        {
            return aSubcola == null && aObjeto == null;
        }
        public void Acolar(object pObjeto)
        {
            new cCola(pObjeto, aSubcola);

            
        }
        public object Desacolar()
        {
            if (aSubcola.Subcola == null)
            {
                object pop = aSubcola.Objeto;
                aSubcola = null;
                return pop;
            }
            else
            {
                return aSubcola.Desacolar;
            }
        }

        public object Cabeza()
        {
            if (aSubcola == null)
            {
                return aObjeto;
            }
            else
            {
                return aSubcola.Cabeza();
            }
        }
    }
}
