using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palabras
{
    internal class cNodo
    {
        //Attributes

        private object aObjeto;
        private cNodo aNext;

        //Constructors

        public cNodo()
        {
            aObjeto = null;
            aNext = null;
        }

        public cNodo(object aObjeto, cNodo aNext)
        {
            this.aObjeto = aObjeto;
            this.aNext = aNext;
        }

        //Properties

        public object Objeto
        {
            get { return aObjeto; }
            set { aObjeto = value; }
        }

        public cNodo Next
        {
            get { return aNext; }
            set { aNext = value; }
        }
    }
}
