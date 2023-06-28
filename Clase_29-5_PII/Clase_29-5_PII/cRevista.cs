using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_29_5_PII
{
    internal class cRevista : cPublicacion
    {
        //Attributes

        private int aNro;
        private int aAnio;

        //Constructors
        public cRevista() :base() 
        {
            aNro = 0;
            aAnio = 0;
        }

        public cRevista(int pCodigo, string pNombre, string pEditorial , int pNro, int pAnio) : base(pCodigo, pNombre, pEditorial)
        {
            aNro = pNro;
            aAnio = pAnio;
        }

        //Properties

        public int Nro
        {
            get { return aNro; }
            set { aNro = value; }
        }

        public int Anio
        {
            get { return aAnio; }
            set { aAnio = value; }
        }

        //Metods

        public override string ToString()
        {
            return base.ToString() + " " + Nro + " " + Anio;
        }

        public override void Leer()
        {
            base.Leer();
            Console.WriteLine("Ingrese el Nro de la revista");
            aNro = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Año de la revista");
            aAnio=int.Parse(Console.ReadLine());
        }
    }
}
