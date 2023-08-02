using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    internal class cArbolBinario
    {
        //Atributes
        private cArbolBinario aHijoIzquierdo;
        private Object aElemento;
        private cArbolBinario aHijoDerecho;

        //Constructors

        public cArbolBinario()
        {
            aElemento = null;
            aHijoDerecho = null;
            aHijoIzquierdo = null;
        }

        public cArbolBinario(cArbolBinario pRaiz, Object pElemento, cArbolBinario pHijoIzquierdo, cArbolBinario pHijoDerecho)
        {
            aElemento = pElemento;
            aHijoIzquierdo = pHijoIzquierdo;
            aHijoDerecho = pHijoDerecho;
        }

        public cArbolBinario(object pElemento)
        {
            aElemento = pElemento;
            aHijoDerecho = null;
            aHijoIzquierdo = null;
        }

        //Properties

        public object Elemento
        {
            get { return aElemento; }
            set { aElemento = value; }
        }

        public cArbolBinario HijoIzquierdo
        {
            get { return aHijoIzquierdo; }
            set { aHijoIzquierdo = value; }
        }

        public cArbolBinario HijoDerecho
        {
            get { return aHijoDerecho;}
            set { aHijoDerecho= value; }
        }

        //Metods

        public bool EsVacia()
        {
            return aElemento == null && aHijoDerecho == null && aHijoIzquierdo == null;
        }

        public virtual cArbolBinario Agregar(object pElemento, cArbolBinario pSubArbolPadre)
        {
            if (EsVacia() && pSubArbolPadre == null)
            {
                aElemento = pElemento;
                return this;
            }
            else
            {
                if (pSubArbolPadre == BuscarArbol(pSubArbolPadre.Elemento))
                {
                    return pSubArbolPadre.Agregar(pElemento, pSubArbolPadre);
                }
                else
                {
                    Console.WriteLine("No se puede agregar a este nodo :c ") ;
                    return null;
                }
            }
        }

        public cArbolBinario AgregarHijo(object pElementoHijo)
        {
            if (EsVacia())
            {
                aElemento = pElementoHijo;
                return this;
            }
            else
            {
                if (HijoIzquierdo.EsVacia())
                {
                    aHijoIzquierdo = new cArbolBinario(pElementoHijo);
                    return this;
                }
                else
                {
                    if (HijoDerecho.EsVacia())
                    {
                        aHijoDerecho = new cArbolBinario(pElementoHijo);
                        return this;
                    }
                    else
                    {
                        if (aHijoIzquierdo != null)
                        {
                            return aHijoIzquierdo.AgregarHijo(pElementoHijo);
                        }
                        else if (!aHijoDerecho.EsVacia())
                        {
                            return aHijoDerecho.AgregarHijo(pElementoHijo);
                        }
                    }
                }
            }
            return this;
        }

        public cArbolBinario BuscarArbol(Object pArbolBuscado)
        {
            if (EsVacia())
            {
                return null;
            }
            else {
                if ( this == pArbolBuscado)
                {
                    return this;
                }
                else
                {
                    if (HijoIzquierdo != null)
                    {
                        return HijoIzquierdo.BuscarArbol(pArbolBuscado);
                    }
                    else
                    {
                        return HijoDerecho.BuscarArbol(pArbolBuscado);
                    }
                }
            }
        }

        public virtual void Insertar()
        {

        }
    }
}
