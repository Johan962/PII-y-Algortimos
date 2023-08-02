﻿using BibliotecaTDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    public class cArbolE
    {
        #region *********************** ATRIBUTOS ************************
        private Object aRaiz;
        private cArbolE aPrimerHijo;
        private cArbolE aSgteHermano;
        #endregion *********************** ATRIBUTOS *********************
        #region ==================== CONSTRUCTORES =======================
        protected cArbolE()
        {
            aRaiz = null;
            aPrimerHijo = null;
            aSgteHermano = null;
        }
        // ----------------------------------------------------------------
        protected cArbolE(Object pRaiz)
        {
            aRaiz = pRaiz;
            aPrimerHijo = null;
            aSgteHermano = null;
        }
        // ----------------------------------------------------------------
        public static cArbolE Crear()
        {
            return new cArbolE();
        }
        // ----------------------------------------------------------------
        public static cArbolE Crear(object pRaiz)
        {
            return new cArbolE(pRaiz);
        }
        // ----------------------------------------------------------------
        #endregion ==================== CONSTRUCTORES ======================
        #region ==================== PROPIEDADES =======================
        private object Raiz
        {
            get
            {
                return aRaiz;
            }
            set
            {
                aRaiz = value;
            }
        }
        // ----------------------------------------------------------------
        private cArbolE PrimerHijo
        {
            get
            {
                return aPrimerHijo;
            }
            set
            {
                aPrimerHijo = value;
            }
        }
        // ----------------------------------------------------------------
        private cArbolE SgteHermano
        {
            get
            {
                return aSgteHermano;
            }
            set
            {
                aSgteHermano = value;
            }
        }
        #endregion ==================== PROPIEDADES =======================
        #region ==================== MÉTODOS =======================
        // ----------------------------------------------------------------
        public bool EstaVacio()
        {
            return (aRaiz == null);
        }
        // -----------------------------------------------------------------
        public cArbolE Agregar(cArbolE SubArbolPadre, object Hijo)
        {
            /* Si árbol está vacío o SubArbolPadre es nulo, agregar hijo como raíz */
            if ((SubArbolPadre == null) && (EstaVacio()))
            {
                aRaiz = Hijo;
                return this;
            }
            else
            {
                /* --- Verificar que SubArbolPadre pertenece al árbol*/
                if (SubArbolPadre == SubArbol(SubArbolPadre.Raiz))
                    return SubArbolPadre.AgregarHijo(Hijo);
                else
                {
                    Console.WriteLine("ERROR. SubArbolPadre no pertenece al árbol");
                    return null;
                }
            }
        }
        // -----------------------------------------------------------------
        public cArbolE AgregarHijo(object Hijo)
        {
            /* Si no existe primer hijo, agregarlo como tal */
            if (aPrimerHijo == null)
            {
                aPrimerHijo = new cArbolE(Hijo);
                return aPrimerHijo;
            }
            else /* Agregar como hermano de primer hijo */
                return aPrimerHijo.AgregarHermano(Hijo);
        }
        // -----------------------------------------------------------------
        public cArbolE AgregarHermano(Object Hermano)
        {
            /* Si no existe siguiente hermano, agregarlo como tal */
            if (aSgteHermano == null)
            {
                aSgteHermano = new cArbolE(Hermano);
                return aSgteHermano;
            }
            else
                return aSgteHermano.AgregarHermano(Hermano);
        }
        // -----------------------------------------------------------------
        public cArbolE SubArbol(Object pRaiz)
        {
            if (EstaVacio())
                return null;
            else
                /* ---- Verifica si la raiz es del subarbol buscado */
                if (aRaiz.Equals(pRaiz))
                return this;
            else
            {
                /* ----- Buscar en el primer hijo (si existe) */
                cArbolE ArbolAux = null;
                if (aPrimerHijo != null)
                    ArbolAux = aPrimerHijo.SubArbol(pRaiz);
                /* ---- Si no existe en primer hijo, buscar en siguiente hermano (si existe)*/
                if ((ArbolAux == null) && (aSgteHermano != null))
                    ArbolAux = aSgteHermano.SubArbol(pRaiz);
                return ArbolAux;
            }
        }
        // -----------------------------------------------------------------
        public cArbolE Padre(Object Hijo)
        {
            if (EstaVacio())
                return null;
            else
                /* -----Verifica es hijo de la raiz actual */
                if (EsHijo(Hijo))
                return this;
            else
            {
                /* ---- Buscar en el primer hijo (si existe) */
                cArbolE ArbolAux = null;
                if (aPrimerHijo != null)
                    ArbolAux = aPrimerHijo.Padre(Hijo);
                /* ---- Si no existe en primer hijo, buscar en siguiente hermano (si existe) */
                if ((ArbolAux == null) && (aSgteHermano != null))
                    ArbolAux = aSgteHermano.Padre(Hijo);
                return ArbolAux;
            }
        }
        // -----------------------------------------------------------------
        public bool EsHijo(Object Hijo)
        {
            if ((EstaVacio()) || (aPrimerHijo == null))
                return false;
            else
                return (aPrimerHijo.Raiz.Equals(Hijo)) ? true : aPrimerHijo.EsHermano(Hijo);
        }
        // -----------------------------------------------------------------
        public bool EsHermano(Object Hermano)
        {
            if ((EstaVacio()) || (aSgteHermano == null))
                return false;
            else
                return (aSgteHermano.Raiz.Equals(Hermano)) ? true : aSgteHermano.EsHermano(Hermano);
        }
        // -----------------------------------------------------------------
        public void Eliminar(cArbolE pArbol)
        {
            /* ------ Verificar que pArbol es parte del arbol */
            if ((pArbol != null) && (pArbol == SubArbol(pArbol.Raiz)))
            {
                /* --- Recuperar padre */
                cArbolE ArbolPadre = Padre(pArbol.Raiz);
                /* ----- Si no existe padre, pRaiz es la raiz del arbol */
                if (ArbolPadre == null)
                {
                    /* ---- Eliminar todo el árbol */
                    aRaiz = null;
                    aPrimerHijo = null;
                    aSgteHermano = null;
                }
                else /* ----- Eliminar un subarbol */
                    /* ----- Verificar si pArbol a eliminar es primer hijo */
                    if (pArbol == ArbolPadre.PrimerHijo)
                {
                    cArbolE ArbolAux = ArbolPadre.PrimerHijo.SgteHermano;
                    PrimerHijo = ArbolAux;
                }
                else /* ---- Objeto a eliminar no es primer hijo */
                    ArbolPadre.PrimerHijo.EliminarHermano(pArbol);
            }
        }
        // -----------------------------------------------------------------
        protected void EliminarHermano(cArbolE pArbol)
        {
            if (pArbol == aSgteHermano)
                SgteHermano = aSgteHermano.SgteHermano;
            else
                aSgteHermano.EliminarHermano(pArbol);
        }
        // -----------------------------------------------------------------
        public void Procesar()
        {
            if (!EstaVacio())
                Console.WriteLine(Raiz);
        }
        // -----------------------------------------------------------------
        public void PreOrden()
        {
            if (!EstaVacio())
            {
                Procesar();
                if (aPrimerHijo != null)
                {
                    aPrimerHijo.PreOrden();
                    aPrimerHijo.RecorrerHermanoPreOrden();
                }
            }
        }
        // -----------------------------------------------------------------
        protected void RecorrerHermanoPreOrden()
        {
            if (aSgteHermano != null)
            {
                aSgteHermano.PreOrden();
                aSgteHermano.RecorrerHermanoPreOrden();
            }
        }
        // -----------------------------------------------------------------
        public void PosOrden()
        {
            if (aPrimerHijo != null)
            {
                aPrimerHijo.PosOrden();
                aPrimerHijo.RecorrerHermanoPosOrden();
            }
            Procesar();
        }
        // -----------------------------------------------------------------
        protected void RecorrerHermanoPosOrden()
        {
            if (aSgteHermano != null)
            {
                aSgteHermano.PosOrden();
                aSgteHermano.RecorrerHermanoPosOrden();
            }
        }
        // -----------------------------------------------------------------
        public void InOrden()
        {
            if (aPrimerHijo != null)
            {
                aPrimerHijo.InOrden();
            }
            Procesar();
            if (aPrimerHijo != null)
            {
                aPrimerHijo.RecorrerHermanoInOrden();
            }
        }
        // -----------------------------------------------------------------
        protected void RecorrerHermanoInOrden()
        {
            if (aSgteHermano != null)
            {
                aSgteHermano.InOrden();
                aSgteHermano.RecorrerHermanoInOrden();
            }
        }
        // -----------------------------------------------------------------
        public int Altura()
        {
            if (EstaVacio())
                return 0;
            else
                if (aPrimerHijo != null)
            {
                int Altura1 = 1 + aPrimerHijo.Altura();
                int Altura2 = 1 + aPrimerHijo.AlturaHermanos();
                return (Altura1 > Altura2 ? Altura1 : Altura2);
            }
            else // Arbol es una hoja
                return 0;
        }
        // -----------------------------------------------------------------
        protected int AlturaHermanos()
        {
            if (aSgteHermano == null)
                return 0;
            else
            {
                int Altura1 = aSgteHermano.Altura();
                int Altura2 = aSgteHermano.AlturaHermanos();
                return (Altura1 > Altura2 ? Altura1 : Altura2);
            }
        }
        #endregion ==================== MÉTODOS DE PROCESO =======================
    }
}