using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17_5_PII
{
    internal class C_Camion : C_Vehiculo
    {
        //Attributes

        private int a_NroEjes;
        private int a_Carga;

        //Constructors

        public C_Camion()
        {
            a_NroEjes = 4;
            a_Carga = 10;
        }

        public C_Camion(string p_placa, string p_marca , int p_anio, int p_NroEjes , int p_Carga) : base(p_placa,p_marca,p_anio)
        {
            a_NroEjes= p_NroEjes;
            a_Carga= p_Carga;
        }

        //Properties

        public int NroEjes
        {
            get { return a_NroEjes; }
            set { a_Carga = value; }
        }

        public int Carga
        {
            get { return a_Carga; }
            set { a_Carga = value;}
        }

        //Metods

        public override int Peaje()
        {
            return base.Peaje() + 5*a_Carga;
        }

    }
}
