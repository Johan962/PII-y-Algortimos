using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_22_5_PII
{
    public class C_Alumno : C_Persona
    {
        //Attributes

        private int a_Codigo;
        private string a_EscProf;

        //Constructors
        
        public C_Alumno(): base()
        {
            a_Codigo = 0;
            a_EscProf = string.Empty;
        }

        public C_Alumno(int p_DNI, string p_Nombres, int p_Codigo, string p_EscProf): base(p_DNI,p_Nombres)
        {
            a_Codigo = p_Codigo;
            a_EscProf = p_EscProf;
        }

        //Properties

        public int Codigo
        {
            get { return a_Codigo; }
            set { a_Codigo = value; }
        }

        public string EscProf
        {
            get { return a_EscProf; }
            set
            {
                a_EscProf = value;
            }
        }

        //Metods
        public override void Leer()
        {
            base.Leer();
            Console.WriteLine("Ingrese el Codigo:");
            string Codigo = Console.ReadLine();
            Console.WriteLine("Ingrese la Escuela Profesional:");
            string EscProf = Console.ReadLine();
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine(this.Codigo);
            Console.WriteLine(this.EscProf);
        }
    }
}
