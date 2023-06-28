using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3
{
    public abstract class C_Cuenta
    {
        //Attributes

        public int a_NroCuenta;
        public int a_TasaInteres;
        public int a_Saldo;
        // Constructors

        public C_Cuenta()
        {
            a_NroCuenta = 0;
            a_TasaInteres = 0;
            a_Saldo = 0;
        }

        public C_Cuenta(int p_NroCuenta, int p_TasaInteres, int p_Saldo)
        {
            a_NroCuenta = p_NroCuenta;
            a_NroCuenta += p_TasaInteres;
            a_Saldo = p_Saldo;    
        }

        //Properties

        public int NroCuenta
        {
            get { return a_NroCuenta; }
            set { a_NroCuenta = value; }
        }

        public int TasaInteres
        {
            get { return a_TasaInteres ; }
            set { a_TasaInteres =value; }
        }

        public int Saldo
        {
            get { return a_Saldo; }
            set { a_Saldo = value; }
        }

        //Metods

        public abstract int CalcularInteres();
        
    }
}
