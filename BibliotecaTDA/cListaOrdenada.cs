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

        cListaOrdenada(){
            aObjeto = null;
            aSublista = null;
        }

        cListaOrdenada(object pObjeto, cListaOrdenada pSublista){
            aObjeto = pObjeto;
            aSublista = pSublista;
        }

        cListaOrdenada(object pObjeto){
            aObjeto = pObjeto;
            aSublista = null;
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
    }
}