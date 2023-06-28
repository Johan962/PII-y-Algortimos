using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3
{
    public class C_CuentaCorriente: C_Cuenta
    {
        //Attributes

        private int a_RUC;
        private int a_Tiempo;

        //Constructors

        public C_CuentaCorriente():base()
        {
            a_RUC = 0;
            a_Tiempo = 0;
        }

        public C_CuentaCorriente(int p_NroCuenta, int p_TasaInteres, int p_Saldo, int p_RUC, int p_Tiempo): base(p_NroCuenta,p_TasaInteres,p_Saldo)
        {
            a_RUC = p_RUC;
            a_Tiempo = p_Tiempo;
        }
        //Properties

        public int RUC
        {
            get { return a_RUC; }
            set { a_RUC = value; }
        }

        public int Tiempo
        {
            get { return a_Tiempo;}
            set { a_Tiempo = value;}
        }

        //Metods

        public override int CalcularInteres()
        {
            return ((a_TasaInteres / 100) / 12)*a_Saldo ;
        }
    }
}
