using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_23_5_Algoritmos
{
    internal class cPalabra
    {
        //Attributes

        private string aEspanol;
        private string aIngles;

        //Constructors

        public cPalabra()
        {
            aEspanol = string.Empty;
            aIngles = string.Empty;
        }

        public cPalabra(string pEspanol, string pIngles)
        {
            aEspanol = pEspanol;
            aIngles = pIngles;
        }

        //Properties

        public string Espanol
        {
            get { return aEspanol; }
            set { aEspanol = value; }
        }

        public string Ingles
        {
            get { return aIngles; }
            set { aIngles = value; }
        }

        //Metods
        public string ToString(cPalabra Palabra)
        {
            return "Palabra en espanol es:" + Palabra.Espanol + "Palabra en ingles es: " + Palabra.Ingles;
        }

        public bool Equals(cPalabra pPalabra,int opcion)
        {
            if (opcion == 1)
            {
                return pPalabra.Espanol == aEspanol;
            }
            else if (opcion == 2) 
            {
                return pPalabra.Ingles == aIngles;
            }
            return false;
        }
    }
}
