using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_29_5_PII
{
    internal class cPublicacion
    {
        //Attributes

        public int aCodigo;
        public string aNombre;
        public string aEditorial;

        //Constructors
        public cPublicacion()
        {
            aCodigo = 0;
            aNombre = "";
            aEditorial = "";

        }

        public cPublicacion(int pCodigo, string pNombre, string pEditorial)
        {
            aCodigo = pCodigo;
            aNombre = pNombre;
            aEditorial = pEditorial;
        }

        //Properties

        public int Codigo
        {
            get { return aCodigo; }
            set { aCodigo = value; }
        }

        public string Nombre
        {
            get { return aNombre; }
            set { aNombre = value; }
        }

        public string Editorial
        {
            get { return aEditorial; }
            set { aEditorial = value; }
        }

        //Metods

        public virtual void Leer()
        {
            Console.WriteLine("Ingrese el codigo de la publicacion:");
            aCodigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Nombre de la publicacion:");
            aNombre = Console.ReadLine();
            Console.WriteLine("Ingrese la editorial:");
            aEditorial = Console.ReadLine();
        }

        public virtual string ToString()
        {
            return aCodigo + " " + aNombre + " " + aEditorial;
        }

        public override bool Equals(Object objCodigo)
        {
            return this.Codigo == ((cPublicacion)objCodigo).Codigo;
        }
    }
}
