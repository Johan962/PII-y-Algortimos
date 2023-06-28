using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_29_5_PII
{
    internal class cLibro : cPublicacion
    {
        //Attributes
        private string aAutor;

        //Contructor
        public cLibro() : base()
        { 
            aAutor = string.Empty;
        }

        public cLibro(int pCodigo, string pNombre, string pEditorial, string pAutor): base(pCodigo,pNombre,pEditorial)
        {
            aAutor = pAutor;
        }

        //Properties

        public string Autor
        {
            get { return aAutor; }  
            set { aAutor = value; }
        }

        //MEtods

        public override void Leer()
        {
            base.Leer();
            Console.WriteLine("Ingrese el nombre de Autor:");
            aAutor = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + " " + aAutor;
        }
    }
}
