using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PII
{
    internal class cObrero : cEmpleado
    {
        //Attributes
        private int aPagoHora;
        private int aNroHoras;
        private int aHorasExtras;
        
        //Constructors

        public cObrero():base()
        {
            aPagoHora = 0;
            aNroHoras = 0;
            aHorasExtras = 0;
        }

        public cObrero(int pDNI, string pNombre, string pDireccion, int pPagoHora, int pNroHoras, int pHorasExtras): base(pDNI,pNombre,pDireccion)
        {
            aPagoHora = pPagoHora;
            aNroHoras = pNroHoras;
            aHorasExtras = pHorasExtras;
        }
        
        //Properties

        public int PagoHora
        {
            get { return aPagoHora; }
            set { aPagoHora = value; }
        }

        public int NroHoras
        {
            get { return aNroHoras; }
            set { aNroHoras = value; }
        }

        public int HorasExtras
        {
            get { return aHorasExtras; }
            set { aHorasExtras = value; }
        }

        public override double SueldoTotal()
        {
            return (NroHoras * PagoHora) + (HorasExtras*1.5*PagoHora);
        }
        //Metods

        public override void Leer()
        {
            base.Leer();
            Console.WriteLine("Ingrese el Pago por Hora");
            aPagoHora = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Nro de Horas");
            aNroHoras = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las Horas Extras");
            aHorasExtras = int.Parse(Console.ReadLine());
        }

        
    }
}
