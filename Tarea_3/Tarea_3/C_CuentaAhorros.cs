using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3
{
    public class C_CuentaAhorros: C_Cuenta
    {
        //Atributes

        private int a_DNI;
        private int a_Tiempo;

        //Constructors

        public C_CuentaAhorros() : base() 
        {
            a_DNI = 0;
            a_Tiempo = 0;
        }

        public C_CuentaAhorros(int p_NroCuenta, int p_TasaInteres, int p_Saldo, int p_DNI, int p_Tiempo): base(p_NroCuenta,p_TasaInteres,p_Saldo)
        {
            a_DNI = p_DNI;
            a_Tiempo = p_Tiempo;
        }

        //Properties

        public int DNI
        {
            get { return a_DNI; }
            set { a_DNI = value; }

        }

        public int Tiempo
        {
            get { return a_Tiempo; }
            set { a_Tiempo = value;}
        }
        //Metods

        public override int CalcularInteres()
        {
            return a_TasaInteres * a_Tiempo * a_Saldo;
        }
    }
}
