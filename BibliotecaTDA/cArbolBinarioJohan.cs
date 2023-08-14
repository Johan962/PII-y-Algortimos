using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    internal class cArbolBinario1
    {
        //Atributes
        private cArbolBinario1 aHijoIzquierdo;
        private Object aElemento;
        private cArbolBinario1 aHijoDerecho;

        //Constructors

        public cArbolBinario1()
        {
            aElemento = null;
            aHijoDerecho = null;
            aHijoIzquierdo = null;
        }

        public cArbolBinario1(cArbolBinario1 pRaiz, Object pElemento, cArbolBinario1 pHijoIzquierdo, cArbolBinario1 pHijoDerecho)
        {
            aElemento = pElemento;
            aHijoIzquierdo = pHijoIzquierdo;
            aHijoDerecho = pHijoDerecho;
        }

        public cArbolBinario1(object pElemento)
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

        public cArbolBinario1 HijoIzquierdo
        {
            get { return aHijoIzquierdo; }
            set { aHijoIzquierdo = value; }
        }

        public cArbolBinario1 HijoDerecho
        {
            get { return aHijoDerecho;}
            set { aHijoDerecho= value; }
        }

        //Metods

        public bool EsVacia()
        {
            return aElemento == null && aHijoDerecho == null && aHijoIzquierdo == null;
        }

        public virtual cArbolBinario1 Agregar(object pElemento, cArbolBinario1 pSubArbolPadre)
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

        public cArbolBinario1 AgregarHijo(object pElementoHijo)
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
                    aHijoIzquierdo = new cArbolBinario1(pElementoHijo);
                    return this;
                }
                else
                {
                    if (HijoDerecho.EsVacia())
                    {
                        aHijoDerecho = new cArbolBinario1(pElementoHijo);
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

        public cArbolBinario1 BuscarArbol(Object pArbolBuscado)
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
