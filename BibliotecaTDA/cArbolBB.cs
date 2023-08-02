using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    internal class cArbolBB : cArbolBinario
    {
        //Attributes
        private object aElemento;
        private cArbolBB aHijoIzquierdo;
        private cArbolBB aHijoDerecho;

        //Constructors
        public cArbolBB()
        {
            aElemento = null;
            aHijoIzquierdo = null;
            aHijoDerecho = null;
        }

        public cArbolBB(cArbolBB pHijoIzquierdo, object pElemento, cArbolBB pHijoDerecho)
        {
            aElemento = pElemento;
            aHijoIzquierdo = pHijoIzquierdo;
            aHijoDerecho = pHijoDerecho;
        }
        //Proerties

        public object Elemento
        {
            get { return aElemento; }
            set { aElemento = value; }
        }

        public cArbolBB HijoIzquierdo
        {
            get { return aHijoIzquierdo; }
            set { aHijoIzquierdo = value; }
        }

        public cArbolBB HijoDerecho
        {
            get { return aHijoDerecho; }
            set { aHijoDerecho = value; }
        }


        //Metods
        

        public void Agregar(object pElemento)
        {
            if (EsVacia())
            {
                aElemento = pElemento;
            }
            else
            {
                if(pElemento.ToString().CompareTo(aElemento.ToString()) < 0)
                {
                    if (aHijoIzquierdo == null)
                        aHijoIzquierdo = new cArbolBB(null, pElemento, null);
                    else
                        aHijoIzquierdo.Agregar(pElemento);
                }
                else
                {
                    if (aHijoDerecho == null)
                        aHijoDerecho = new cArbolBB(null, pElemento, null);
                    else 
                        aHijoDerecho.Agregar(pElemento);
                }
            }
        }

        public void Eliminar()
        {

        }
    }
}
