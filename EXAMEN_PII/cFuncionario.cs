using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PII
{
    internal class cFuncionario : cEmpleado
    {
        //Attributes

        private string aCargo;
        private double aSueldoBasico;
        private int aNroFaltas;

        //Constructors
        public cFuncionario():base()
        {
            aCargo = string.Empty;
            aSueldoBasico = 0;
            aNroFaltas = 0;
        }

        public cFuncionario(int pDNI, string pNombre, string pDireccion,string pCargo, int pSueldoBasico, int pNroFaltas): base(pDNI,pNombre,pDireccion)
        {
            aCargo = pCargo;
            aSueldoBasico = pSueldoBasico;
            aNroFaltas = pNroFaltas;
        }
        //Properties

        public string Cargo
        {
            get { return aCargo; }
            set { aCargo = value; }
        }

        public double SueldoBasico
        {
            get { return aSueldoBasico; }
            set { aSueldoBasico = value; }
        }

        public int NroFaltas
        {
            get { return aNroFaltas;}
            set { aNroFaltas = value; }   
        }
        
        //Metods
        public override void Leer()
        {
            base.Leer();
            Console.WriteLine("Ingrese el Cargo");
            aCargo = Console.ReadLine();
            Console.WriteLine("Ingrese el Sueldo Basico");
            aSueldoBasico = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Nro de Faltas");
            aNroFaltas = int.Parse(Console.ReadLine());

        }
        public override double SueldoTotal()
        {
            double Bonificacion = 0;
            if (Cargo == "Gerente")
            {
                Bonificacion = 0.5 * SueldoBasico;
            }
            else
            {
                if (Cargo == "Administrador")
                {
                    Bonificacion = 0.3 * SueldoBasico;
                }
                else
                {
                    //Esto no es necesario creo, pero lo pongo para que se entienda mejor
                    if(Cargo == " JefeArea ")
                    {
                        Bonificacion = 0.2 * SueldoBasico;
                    }
                }
            }
            return SueldoBasico + Bonificacion - SueldoBasico*(NroFaltas/30);
        }
    }
}
