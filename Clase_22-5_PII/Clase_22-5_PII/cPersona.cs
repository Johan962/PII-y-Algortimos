using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_22_5_PII
{
    internal abstract class cPersona
    {
        //atributos
        private string aNombre;
        private string aPaterno;
        private string aMaterno;
        private string aDNI;
        //Metodos
        public cPersona()
        {
            aNombre = "";
            aPaterno = "";
            aMaterno = "";
            aDNI = "";
        }
        public cPersona(string pNombre, string pPaterno, string pMaterno, string pDNI)
        {
            aNombre = pNombre;
            aPaterno = pPaterno;
            aMaterno = pMaterno;
            aDNI = pDNI;
        }
        public string Nombre
        {
            get { return aNombre; }
            set { aNombre = value; }
        }
        public string Paterno
        {
            get { return aPaterno; }
            set { aPaterno = value; }
        }
        public string Materno
        {
            get { return aMaterno; }
            set { aMaterno = value; }
        }
        public string DNI
        {
            get { return aDNI; }
            set { aDNI = value; }
        }

        public override string ToString()
        {
            return aDNI + " " + aPaterno + " " + aMaterno + " " + aNombre;
        }
        public override bool Equals(object obj)//Invocar ObjAnfitrion.Equals(ObjParametro)
        {
            return this.ToString().Equals(obj.ToString());
        }
        public virtual void Leer()
        {
            Console.WriteLine("INGRESE DATOS");
            Console.WriteLine("=============");
            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Apellido Paterno: ");
            Paterno = Console.ReadLine();
            Console.Write("Apellido Materno: ");
            Materno = Console.ReadLine();
            Console.Write("DNI: ");
            DNI = Console.ReadLine();
        }
        public virtual void Mostrar()
        {
            Console.WriteLine("DATOS");
            Console.WriteLine("=====");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido Paterno: " + Paterno);
            Console.WriteLine("Apellido Materno: " + Materno);
            Console.WriteLine("DNI: " + DNI);
        }
        public abstract int Bonificacion(int pNroDias);

    }
}
