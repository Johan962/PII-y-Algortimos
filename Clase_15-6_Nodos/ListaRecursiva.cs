using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_15_6_Nodos
{
    internal class cListaRecursiva
    {
        private cListaRecursiva aSublista;
        private cListaRecursiva aStart;

        public cListaRecursiva()
        {
            aSublista = new cListaRecursiva();
            aStart = null;
        }

        public cListaRecursiva(cListaRecursiva pSublista,cListaRecursiva pNext )
        {
            aSublista = pSublista;
            aStart = pNext;
        }

        public bool isEmpty()
        {
            return (aSublista==null);
        }

        public bool append(object pObjeto, cListaRecursiva pNext)
        {
            return true;
        }
    }
}
