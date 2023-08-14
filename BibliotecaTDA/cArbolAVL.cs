using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTDA
{   
    public class cArbolAVL : cArbolBB
    {
        #region Constructores
        //===========================================}

        public cArbolAVL() : base()
        {}
        public cArbolAVL(object pRaiz) : base(pRaiz)
        {}
        public cArbolAVL(cArbolBB HijoIz, object pRaiz,cArbolBB HijoDer):base(pRaiz)
        {
            aHijoIzquierdo = HijoIz;
            aHijoDerecho = HijoDer;
        }
        public static cArbolAVL Crear(object pRaiz=null)
        {
            return new cArbolAVL(pRaiz);
        }
        public static cArbolAVL Crear(cArbolBB HijoIz, object pRaiz,cArbolBB HijoDer)
        {
            return new cArbolAVL(HijoIz, pRaiz, HijoDer);
        }
        //===========================================
        #endregion Constructores
        //===========================================
        //===========================================
        #region Propiedades
        //===========================================
        public cArbolAVL HijoIzquierdoAVL
        {
            set { aHijoIzquierdo = value; }
            get { return aHijoIzquierdo as cArbolAVL; }
        }
        public cArbolAVL HijoDerechoAVL
        {
            set { aHijoDerecho = value; }
            get { return aHijoDerecho as cArbolAVL; }
        }

        //===========================================
        #endregion Propiedades
        //===========================================
        //===========================================
        #region Metodos
        //===========================================
        public bool EstaBalanceado()
        {
            int AltIz = aHijoIzquierdo == null? -1 : aHijoIzquierdo.Altura();
            int AltDer = aHijoDerecho == null ? -1 : aHijoDerecho.Altura();
            return Math.Abs(AltIz - AltDer) <= 1;
        }

        protected void RotacionIz()
        {
            aHijoDerecho = cArbolAVL.Crear(aHijoIzquierdo.HijoDerecho,aRaiz,aHijoDerecho);
            aRaiz = aHijoIzquierdo.Raiz;
            aHijoIzquierdo = aHijoIzquierdo.HijoIzquierdo;

        }
        protected void RotacionDer()
        {

            aHijoIzquierdo = cArbolAVL.Crear(aHijoIzquierdo, aRaiz, aHijoDerecho.HijoIzquierdo);
            aRaiz = aHijoDerecho.Raiz;
            aHijoDerecho = aHijoDerecho.HijoDerecho;

        }

        protected void RotacionDobleIz()
        {
            (aHijoIzquierdo as cArbolAVL).RotacionDer();
            RotacionIz();
        }

        protected void RotacionDobleDer()
        {

            (aHijoDerecho as cArbolAVL).RotacionIz();
            RotacionDer();
        }

        public override void Agregar(object pRaiz)
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
                        {
                            aHijoIzquierdo.Agregar(pRaiz);
                        }
                            
                        else
                        {
                            aHijoIzquierdo = new cArbolAVL(pRaiz);
                        }
                        //=====================================================================
                        if(!EstaBalanceado())
                        {
                            if (pRaiz.ToString().CompareTo(aHijoIzquierdo.Raiz.ToString())<0)
                                RotacionIz();
                            else
                                RotacionDobleIz();
                        }
                    }
                    else
                    {
                        if (aHijoDerecho != null)
                        {
                            aHijoDerecho.Agregar(pRaiz);
                        }
                            
                        else
                        {
                            aHijoDerecho = new cArbolAVL(pRaiz);
                        }

                        //=====================================================================

                        if (!EstaBalanceado())
                        {
                            if (pRaiz.ToString().CompareTo(aHijoDerecho.Raiz.ToString()) >= 0)
                                RotacionDer();
                            else
                                RotacionDobleDer();
                        }
                    }
                }
            }
        }
        public override void Eliminar(object pRaiz = null)
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
                            if (!EstaBalanceado())
                            {
                                if (pRaiz.ToString().CompareTo(aHijoIzquierdo.Raiz) < 0)
                                    RotacionIz();
                                else
                                    RotacionDobleIz();
                            }
                        }
                    }

                    else
                    {
                        if (aHijoDerecho != null)
                        {
                            aHijoDerecho.Eliminar(pRaiz);
                            if (aHijoDerecho.EsVacio())
                                aHijoDerecho = null;
                            if (!EstaBalanceado())
                            {
                                if (pRaiz.ToString().CompareTo(aHijoDerecho.Raiz) >= 0)
                                    RotacionDer();
                                else
                                    RotacionDobleDer();
                            }
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
        //===========================================
        #endregion Metodos

    }
}
