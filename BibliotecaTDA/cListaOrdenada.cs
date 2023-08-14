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

            if (EsVacia())
            {
                aObjeto = pObjeto;
                return this;
            }
            else
            {
                if (aObjeto.ToString().CompareTo(pObjeto.ToString()) > 0)
                {
                    return aSublista.Agregar(pObjeto);
                }
                else
                {
                    aSublista = new cListaOrdenada(aObjeto,aSublista);
                    aObjeto = pObjeto;
                    return aSublista;
                }
            }
        }

        public void Listar()
        {
            if (EsVacia())
            {
                Console.WriteLine("Si llega");
            }
            else
            {
                Console.WriteLine($"- {aObjeto}");
                aSublista.Listar();
            }
        }
        public int Longitud()
        {
            if ( aSublista == null)
            {
                return 0;
            }
            else
            {
                return 1 + aSublista.Longitud();
            }
        }

        public object Cima()
        {
            return aObjeto;
        }
    }
}