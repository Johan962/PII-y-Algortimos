using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaTDA;

namespace Palabras
{
    internal class cPalabra
    {
        //Attributes

        private string aEspanol;
        private string aIngles;

        //Constructors

        public cPalabra()
        {
            aEspanol = "";
            aIngles = "";
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
        public override string ToString()
        {
            return $"{this.Espanol} : {this.Ingles} ";
        }

        public bool Equals(cPalabra pPalabra, int opcion)
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

        public bool EsPalindromo(string Palabra)
        {
            cPila Pila = new cPila();
            cCola Cola = new cCola();
            for(int i = 0; i < Palabra.Length; i++)
            {
                Pila.Apilar(Palabra[i]);
                Cola.Acolar(Palabra[i]);
            }
            for (int i = 0; i < Palabra.Length; i++)
            {
                if (Pila.Cima() == Cola.Cabeza())
                {
                    Pila.Desapilar();
                    Cola.Desacolar();
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
