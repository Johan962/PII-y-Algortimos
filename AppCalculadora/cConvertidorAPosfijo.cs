using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadora
{
    internal class cConvertidorAPosfijo
    {
        //Attributes

        private string aExpresion;

        //Constructors

        public cConvertidorAPosfijo()
        {
            aExpresion = string.Empty;
        }

        public cConvertidorAPosfijo(string pExpresion)
        {
            aExpresion = pExpresion;
        }

        public static cConvertidorAPosfijo Crear(string pExpresion)
        {
            return new cConvertidorAPosfijo(pExpresion);
        }

        //Properties

        public string Expresion
        {
            get { return aExpresion; }
            set { aExpresion = value; }
        }

        //Metods

        public bool okPrecedencia(string Token1,string Token2)
        {
            return false;
        }
    }
}
