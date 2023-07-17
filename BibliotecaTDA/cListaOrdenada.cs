using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    public class cListaOrdenada : cListaRecursiva
    {
        //Attributes
        private object aObjeto;
        private cListaOrdenada aSublista;

        //Constructors 

        public cListaOrdenada(){
            aObjeto = null;
            aSublista = null;
        }

        public cListaOrdenada(object pObjeto, cListaOrdenada pSublista){
            aObjeto = pObjeto;
            aSublista = pSublista;
        }

        //Properties

        public object Objeto {
            get { return aObjeto; }
            set { aObjeto = value; }
        }

        public cListaOrdenada Sublista {
            get { return aSublista;}
            set { aSublista = value;}
        }

        //Metods

        public override cListaOrdenada Agregar(object pObjeto){
            if ((int)aObjeto >= (int)pObjeto && (int)pObjeto >= (int)aSublista.Objeto)
            {
                return aSublista.Agregar(pObjeto);
            }
            else
            {
                aSublista = new cListaOrdenada(pObjeto, aSublista.Sublista);
                return aSublista;
            }
        }
    }
}