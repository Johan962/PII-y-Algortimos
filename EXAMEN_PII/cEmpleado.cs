using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PII
{
    public abstract class cEmpleado
    {
        //Attributes
        public int aDNI;
        public string aNombre;
        public string aDireccion;

        //Constructors
        public cEmpleado()
        {
            aDNI  = 0;
            aNombre = "";
            aDireccion = "";
        }

        public cEmpleado(int pDNI, string pNombre, string pDireccion)
        {
            aDNI = pDNI;
            aNombre = pNombre;
            aDireccion = pDireccion;
        }

        //Properties

        public int DNI
        {
            get { return aDNI; }
            set { aDNI = value; }
        }

        public string Nombre
        {
            get { return aNombre; }
            set { aNombre = value; }
        }

        public string Direccion
        {
            get { return aDireccion; }
            set{ aDireccion = value; }
        }

        //Metods

        public abstract double SueldoTotal();

        public virtual void Leer()
        {
            Console.WriteLine("Ingrese DNI");
            aDNI = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Nombre");
            aNombre = Console.ReadLine();
            Console.WriteLine("Ingrese Direccion");
            aDireccion = Console.ReadLine();
        }
    }
}
