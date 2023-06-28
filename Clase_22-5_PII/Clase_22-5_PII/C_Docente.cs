using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_22_5_PII
{
    internal class C_Docente : C_Persona
    {
        //Attributes
        private int a_Codigo;
        private string a_DptoAcad;
        private string a_Condicion;

        //Constructors

        public C_Docente(): base()
        {
            a_Codigo = 0;
            a_DptoAcad = "";
            a_Condicion = "";
        }

        public C_Docente(int p_DNI, string p_Nombres, int p_Codigo, string p_DptoAcad, string p_Condicion): base(p_DNI,p_Nombres)
        {
            a_Codigo = p_Codigo;
            a_DptoAcad = p_DptoAcad;
            a_Condicion = p_Condicion;
        }

        //Properties
        
        public int Codigo
        {
            get { return a_Codigo; }
            set { a_Codigo = value; }
        }

        public string DptoAcad
        {
            get { return a_DptoAcad; }
            set { a_DptoAcad = value;}
        }

        public string Condicion
        {
            get { return a_Condicion; }
            set { a_Condicion = value; }
        }

        //Metods
        public override void Leer()
        {
            base.Leer();
            Console.WriteLine("Ingrese el Codigo:");
            string Codigo = Console.ReadLine();
            Console.WriteLine("Ingrese el Departamento Academico:");
            string DepAcade = Console.ReadLine();
            Console.WriteLine("Ingrese la condicion:");
            string condicion = Console.ReadLine();
        }


        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine(this.Codigo);
            Console.WriteLine(this.DptoAcad);
            Console.WriteLine(this.Condicion);
        }
    }
}
