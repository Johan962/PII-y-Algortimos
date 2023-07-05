using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibreria
{
    public class cListaRecursiva
    {
        private cListaRecursiva aSublista;
        private object aObjeto;

        public cListaRecursiva()
        {
            aSublista = new cListaRecursiva();
            aObjeto = null;
        }

        public cListaRecursiva(cListaRecursiva pSublista, object pObjeto)
        {
            aSublista = pSublista;
            aObjeto = pObjeto;
        }

        public bool isEmpty()
        {
            return (aSublista == null);
        }

        public bool append(object pObjeto, cListaRecursiva pNext)
        {
            return aSublista.append(pObjeto, pNext);
        }
    }
}
