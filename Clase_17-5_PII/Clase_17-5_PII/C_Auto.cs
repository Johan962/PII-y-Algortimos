using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17_5_PII
{
    internal class C_Auto : C_Vehiculo
    {
        //Attributes

        private string a_modelo;
        private int a_NroPasajeros;

        //Contructors

        public C_Auto()
        {
            a_modelo = "Auto pequeño";
            a_NroPasajeros = 5;
        }
        public C_Auto(string p_placa, string p_marca, int p_Anio, string p_modelo, int p_NroPasajeros): base (p_placa,p_marca,p_Anio)
        {
            a_modelo = p_modelo;
            a_NroPasajeros = p_NroPasajeros;
        }

        //Properties

        public string Modelo
        {
            get { return a_modelo; }
            set { a_modelo = value; }
        }

        public int NroPasajeros
        {
            get { return a_NroPasajeros; }
            set { a_NroPasajeros = value; }
        }

        //Metods

        public override int Peaje()
        {
            return base.Peaje() + 2 * (2023 - a_Anio);
        }
    }


}
