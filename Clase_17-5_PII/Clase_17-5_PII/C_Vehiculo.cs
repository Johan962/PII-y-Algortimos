using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17_5_PII
{
    internal class C_Vehiculo
    {
        //Attributes
        public string a_placa;
        public string a_marca;
        public int a_Anio;

        //Constructor
        public C_Vehiculo()
        {
            a_placa = "POO-517";
            a_marca = "Toyota";
            a_Anio = 2018;
        }

        public C_Vehiculo(string p_placa, string p_marca, int p_Anio)
        {
            a_placa = p_placa;
            a_marca = p_marca;
            a_Anio = p_Anio;
        }

        //Properties

        public string Placa
        {
            get { return a_placa; }
            set { a_placa = value; }
        }

        public string Marca
        {
            get { return a_marca; }
            set { a_marca = value; }
        }

        public int Anio
        {
            get { return a_Anio; }
            set { a_Anio = value; }
        }

        //Metods

        public virtual int Peaje()
        {
            return 5;
        }


    }   
}
