using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_22_5_PII
{
    class cDocente : cPersona
    {
        private string aCategoria;
        private string aDA;
        public cDocente() : base()
        {
            aCategoria = "";
            aDA = "";
        }
        public cDocente(string pNombre, string pPaterno, string pMaterno, string pDNI, string pCategoria, string pDA)
            : base(pNombre, pPaterno, pMaterno, pDNI)
        {
            aCategoria = pCategoria;
            aDA = pDA;
        }
        public string Categoria
        {
            get { return aCategoria; }
            set { aCategoria = value; }
        }
        public string DA
        {
            get { return aDA; }
            set { aDA = value; }
        }
        public override string ToString()
        {
            return base.ToString() + " " + aCategoria + " " + aDA;
        }
        public override void Leer()
        {
            base.Leer();
            Console.Write("Categoria: ");
            Categoria = Console.ReadLine();
            Console.Write("Departamento Academico: ");
            DA = Console.ReadLine();
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Categoria: " + Categoria);
            Console.WriteLine("Departamento Academico: " + DA);
        }
        public override int Bonificacion(int pNroDias)
        {
            return 0;
        }

    }
}
