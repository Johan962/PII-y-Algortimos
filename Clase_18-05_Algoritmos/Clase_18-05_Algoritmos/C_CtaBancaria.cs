using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Clase_18_05_Algoritmos
{
    internal class C_CtaBancaria
    {
        //Attributes
        public int a_NroCuenta;
        public string a_Nombre;
        public string a_Direccion;

        //Constructors

        public C_CtaBancaria()
        {
            a_NroCuenta = 0;
            a_Nombre = "";
            a_Direccion = "";
        }

        public C_CtaBancaria(int p_Numero , string p_Nombre , string p_Direccion)
        {
            a_NroCuenta= p_Numero;
            a_Nombre= p_Nombre;
            a_Direccion= p_Direccion;
        }

        //Properties

        public int NroCuenta
        {
            get { return a_NroCuenta; }
            set { a_NroCuenta = value; }
        }

        public string Nombre
        {
            get { return a_Nombre;}
            set { a_Nombre = value;}
        }

        public string Direccion
        {
            get { return a_Direccion; }
            set { a_Direccion = value; }
        }

        //Metods


    }
}
