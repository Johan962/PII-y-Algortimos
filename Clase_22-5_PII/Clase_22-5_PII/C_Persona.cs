using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_22_5_PII
{
    public class C_Persona
    {
        //Attributes

        public int a_DNI;
        public string a_Nombres;

        // Constructors

        public C_Persona()
        {
            a_DNI = 0;
            a_Nombres = string.Empty;
        }

        public C_Persona(int p_DNI, string p_Nombres)
        {
            a_DNI = p_DNI;
            a_Nombres = p_Nombres;
        }

        //Properties

        public int DNI
        {
            get { return a_DNI; }
            set { a_DNI = value; }
        }

        public string Nombres
        {
            get { return a_Nombres; }
            set { a_Nombres = value;}
        }

        public virtual bool Equals(Object p_Persona1)
        {
            if (p_Persona1.DNI == this.DNI)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void Leer()
        {
            Console.WriteLine("Ingrese el DNI:");
            DNI = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Nombre:");
            string Nombre = Console.ReadLine();
        }

        public virtual void Mostrar()
        {
            Console.WriteLine(this.DNI);
            Console.WriteLine(this.Nombres);
        }
    }
}
