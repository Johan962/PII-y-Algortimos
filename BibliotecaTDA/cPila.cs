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
        private object aObjeto;
        private cPila aSubpila;

        //Constructors

        public cPila()
        {
            aObjeto = null;
            aSubpila = new cPila();
        }

        cPila(object pObjeto, cPila pSubpila)
        {
            aObjeto = pObjeto;
            aSubpila = pSubpila;
        }

        //Properties

        public object Objeto
        {
            get { return aObjeto; }
            set { aObjeto = value; }
        }
        public cPila Subpila
        {
            get { return aSubpila; }
            set { aSubpila = value; }
        }
        //Metods

        public bool EsVacio()
        {
            if (aSubpila == null && aObjeto == null)
            {
                return true;
            }
            return false;
        }
        public void Apilar(object pObjeto)
        {
            //Subpila.Agregar(pElemento);
            aSubpila = new cPila(aObjeto, aSubpila);
            aObjeto = pObjeto;
        }

        public void Desapilar()
        {
            // object Objeto = Iesimo(Longitud() - 1);
            // Eliminar(Longitud() - 1);
            // return Objeto;

            if (!EsVacio())
            {
                aObjeto = aSubpila.Objeto;
                aSubpila = aSubpila.Subpila;
            }
        }

        public object Cima()
        {
            return aObjeto;
        }
    }
}
