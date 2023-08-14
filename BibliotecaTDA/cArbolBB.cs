using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaTDA;

namespace BibliotecaTDA
{
    public delegate bool DeValidarObjeto(object Elem);
    public delegate void DeProcesarObjeto(object Elem);

    public class cArbolBB
    {
        //=============================================
        //=============================================
        #region Atributos
        //Atributos Estaticos
        protected static DeValidarObjeto deValidar = (object X) => { return true; };
        protected static DeProcesarObjeto deProcesar = (object X) => { Console.WriteLine(X.ToString()); };
        //Atributos no estaticos
        protected cArbolBB aHijoIzquierdo;
        protected object aRaiz;
        protected cArbolBB aHijoDerecho;
        #endregion Atributos
        //=============================================
        //=============================================
        #region METODOS
        //=============================================
        //=============================================
        #region Constructores
        public cArbolBB()
        {
            aHijoDerecho = null;
            aHijoIzquierdo = null;
            aRaiz = null;

        }
        public cArbolBB(object pRaiz)
        {
            aHijoDerecho = null;
            aHijoIzquierdo = null;
            aRaiz = pRaiz;
        }
        public static cArbolBB Crear(object pElem)
        {
            return new cArbolBB(pElem);
        }
        public static cArbolBB Crear()
        {
            return new cArbolBB();
        }
        #endregion Constructores
        //=============================================
        #region Propiedades
        public object Raiz
        {
            set { aRaiz = value; }
            get { return aRaiz; }
        }
        public cArbolBB HijoIzquierdo
        {
            get { return aHijoIzquierdo; }
        }
        public cArbolBB HijoDerecho
        {
            get { return aHijoDerecho; }
        }
        public static void AsignarValidar(DeValidarObjeto X)
        {
            if (X != null)
                deValidar = X;

        }
        public static void AsignarProcesar(DeProcesarObjeto X)
        {
            if (X != null)
                deProcesar = X;
        }
        #endregion Propiedades
        //=============================================
        #region Proceso
        public bool EsVacio()
        {
            return aRaiz == null;
        }
        public virtual void Agregar(object pRaiz)
        {
            if (pRaiz != null)
            {
                if (EsVacio())
                {
                    aRaiz = pRaiz;
                }
                else
                {
                    if (pRaiz.ToString().CompareTo(aRaiz.ToString()) < 0)
                    {
                        if (aHijoIzquierdo != null)
                            aHijoIzquierdo.Agregar(pRaiz);
                        else
                            aHijoIzquierdo = new cArbolBB(pRaiz);
                    }
                    else
                    {
                        if (aHijoDerecho != null)
                            aHijoDerecho.Agregar(pRaiz);
                        else
                            aHijoDerecho = new cArbolBB(pRaiz);
                    }
                }
            }
        }
        public cArbolBB SubArbol(object pRaiz)
        {
            Console.WriteLine(aRaiz);
            if (pRaiz != null && !EsVacio())
            {
                //se verifica si estamos en la raiz correcta
                if (pRaiz.ToString().Equals(aRaiz.ToString()))
                {
                    Console.WriteLine(aRaiz.ToString());
                    return this;
                }
                //se decide hacia que hijo ir
                cArbolBB Aux = aHijoDerecho;
                if (pRaiz.ToString().CompareTo(aRaiz.ToString()) == -1)
                    Aux = aHijoDerecho;
                //se repite el proceso si el hijo existe 
                if (Aux != null)
                    return Aux.SubArbol(pRaiz);
                else
                    return null;
            }
            return null;
        }
        public object MayorElemento()
        {
            object Temp = aRaiz;
            if (aHijoDerecho != null)
                if (!aHijoDerecho.EsVacio())
                    Temp = aHijoDerecho.MayorElemento();
            return Temp;
        }
        public object MenorElemento()
        {
            object Temp = aRaiz;
            if (aHijoIzquierdo != null)
                if (!aHijoIzquierdo.EsVacio())
                    Temp = aHijoIzquierdo.MayorElemento();
            return Temp;
        }
        public virtual void Eliminar(object pRaiz = null)
        {
            if (pRaiz != null && !EsVacio())
            {
                //Se recorrer el arbol hasta llegar al elemento a eliminar
                if (!pRaiz.ToString().Equals(aRaiz.ToString()))
                {
                    if (pRaiz.ToString().CompareTo(aRaiz.ToString()) == -1)
                    {
                        if (aHijoIzquierdo != null)
                        {
                            aHijoIzquierdo.Eliminar(pRaiz);
                            if (aHijoIzquierdo.EsVacio())
                                aHijoIzquierdo = null;
                        }
                    }

                    else
                    {
                        if (aHijoDerecho != null)
                        {
                            aHijoDerecho.Eliminar(pRaiz);
                            if (aHijoDerecho.EsVacio())
                                aHijoDerecho = null;
                        }
                    }
                }
                else
                {
                    //si no tiene hijos se propone como null
                    if (aHijoIzquierdo == null && aHijoDerecho == null)
                    {
                        aRaiz = null;
                    }
                    else
                    {
                        //si tiene hijo izquierdo se coloca el mayor elemento de esa rama
                        if (aHijoIzquierdo != null)
                        {
                            aRaiz = aHijoIzquierdo.MayorElemento();
                            aHijoIzquierdo.Eliminar(aRaiz);
                        }
                        else
                        {
                            //si solo tiene hijo derecho se coloca el menor valor de esta rama
                            if (aHijoDerecho != null)
                            {
                                aRaiz = aHijoDerecho.MenorElemento();
                                aHijoDerecho.Eliminar(aRaiz);
                            }
                        }
                    }
                }
            }
        }

        public void RecorrerPreOrden()
        {
            if (!EsVacio())
            {
                if (deValidar(aRaiz))
                    deProcesar(aRaiz);
                if (aHijoIzquierdo != null)
                {
                    aHijoIzquierdo.RecorrerPreOrden();
                }

                if (aHijoDerecho != null)
                {
                    aHijoDerecho.RecorrerPreOrden();
                }

            }
        }

        public void RecorrerInOrden()
        {
            if (!EsVacio())
            {
                if (aHijoIzquierdo != null)
                    aHijoIzquierdo.RecorrerInOrden();
                if (deValidar(aRaiz))
                    deProcesar(aRaiz);
                if (aHijoDerecho != null)
                    aHijoDerecho.RecorrerInOrden();
            }
        }

        public void RecorrerPostOrden()
        {
            if (!EsVacio())
            {
                if (aHijoIzquierdo != null)
                    aHijoIzquierdo.RecorrerPostOrden();
                if (aHijoDerecho != null)
                    aHijoDerecho.RecorrerPostOrden();
                if (deValidar(aRaiz))
                    deProcesar(aRaiz);
            }
        }
        public bool MostrarNivel(int k)
        {
            Boolean Aux = false;
            if (k == 0 && !EsVacio())
            {
                if (deValidar(aRaiz))
                    deProcesar(aRaiz);
                return true;
            }
            else
            {
                if (EsVacio())
                    return false;
                else
                {
                    k--;
                    if (aHijoIzquierdo != null)
                    {
                        Aux = aHijoIzquierdo.MostrarNivel(k) || Aux;
                    }
                    if (aHijoDerecho != null)
                    {
                        Aux = aHijoDerecho.MostrarNivel(k) || Aux;
                    }
                    return Aux;
                }
            }
        }
        public void RecorrerPorNivel()
        {
            cCola Cola = new cCola();
            Cola.Acolar(this);
            cArbolBB Temp;
            object Aux;
            while(!Cola.EsVacio())
            {
                Temp=Cola.Cabeza() as cArbolBB;
                if(!Temp.EsVacio())
                {
                    Aux=Temp.Raiz;
                    if (deValidar(Aux))
                        deProcesar(Aux);
                    if (Temp.aHijoIzquierdo != null)
                        Cola.Acolar(Temp.aHijoIzquierdo);
                    if (Temp.aHijoDerecho != null)
                        Cola.Acolar(Temp.aHijoDerecho);
                    Cola.Desacolar();
                }
            }         
        }

        public int Altura()
        {
            if (EsVacio())
                return 0;
            else
            {
                int AlturaIzq = (aHijoIzquierdo == null ? 0 : 1 + aHijoIzquierdo.Altura());
                int AlturaDer = (aHijoDerecho == null ? 0 : 1 + aHijoDerecho.Altura());
                return (AlturaIzq > AlturaDer ? AlturaIzq : AlturaDer);
            }
        }

        public void Podar()
        {
            if (!EsVacio())
            {
                if (aHijoIzquierdo != null)
                {
                    if (aHijoIzquierdo.EsVacio())
                        aHijoIzquierdo = null;
                    else
                        aHijoIzquierdo.Podar();
                }
                if (aHijoDerecho != null)
                {
                    if (aHijoDerecho.EsVacio())
                        aHijoDerecho = null;
                    else
                        aHijoDerecho.Podar();
                }
            }
        }

        #endregion Proceso
        //=============================================
        //=============================================
        #endregion METODOS
    }

}