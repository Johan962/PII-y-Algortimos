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

        public object Objeto
        {
            get { return aObjeto; }
            set { aObjeto = value; }
        }
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
            if (aSubcola == null)
            {
                aSubcola = new cCola(pObjeto,new cCola());
            }
            else
            {
                aSubcola.Acolar(pObjeto);
            }

            
        }
        public object Desacolar()
        {
            if (aSubcola.Subcola == null)
            {
                object pop = aSubcola.aObjeto;
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
