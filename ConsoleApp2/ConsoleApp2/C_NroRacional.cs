using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class C_NroRacional
    {
        // Attributes
        private int a_Numerador;
        private int a_Denominador;

        // Constructors
        public C_NroRacional(int p_Numerador, int p_Denominador)
        {
            this.a_Numerador = p_Numerador;
            this.a_Denominador = p_Denominador;
        }

        //Properties
        public int Numerador
        {
            get
            {
                return a_Numerador;
            }
            set
            {
                a_Numerador = value;
            }

        }

        public int Denominador
        {
            get { return a_Denominador; }
            set
            {
                if (value != 0)
                    a_Denominador = value;
            }

        }

        //Metods

        public static C_NroRacional operator -(C_NroRacional p_fraccion1, C_NroRacional p_fraccion2)
        {
            int v_Numerador = (p_fraccion1.Numerador * p_fraccion2.Denominador) - (p_fraccion2.Numerador * p_fraccion1.Denominador);
            int v_Denominador = p_fraccion1.Denominador * p_fraccion2.Denominador;
            C_NroRacional Result = new C_NroRacional(v_Numerador, v_Denominador);
            return Result;
        }
        public static C_NroRacional operator +(C_NroRacional p_fraccion1, C_NroRacional p_fraccion2)
        {
            int v_Numerador = (p_fraccion1.Numerador * p_fraccion2.Denominador) + (p_fraccion2.Numerador * p_fraccion1.Denominador);
            int v_Denominador = p_fraccion1.Denominador * p_fraccion2.Denominador;
            C_NroRacional Result = new C_NroRacional(v_Numerador, v_Denominador);
            return Result;
        }

        public static C_NroRacional operator *(C_NroRacional p_fraccion1, C_NroRacional p_fraccion2)
        {
            int v_Numerador = p_fraccion1.Numerador * p_fraccion2.Numerador;
            int v_Denominador = p_fraccion1.Denominador * p_fraccion2.Denominador;
            C_NroRacional Result = new C_NroRacional(v_Numerador, v_Denominador);
            return Result;
        }

        public static C_NroRacional operator /(C_NroRacional p_fraccion1, C_NroRacional p_fraccion2)
        {
            int v_Numerador = p_fraccion1.Numerador * p_fraccion1.Denominador;
            int v_Denominador = p_fraccion1.Denominador * p_fraccion2.Numerador;
            C_NroRacional Result = new C_NroRacional(v_Numerador, v_Denominador);
            return Result;
        }

        // Class Metods

        public static C_NroRacional Suma(C_NroRacional p_fraccion1, C_NroRacional p_fraccion2)
        {
            int v_Numerador = (p_fraccion1.Numerador * p_fraccion2.Denominador) + (p_fraccion2.Numerador * p_fraccion1.Denominador);
            int v_Denominador = p_fraccion1.Denominador * p_fraccion2.Denominador;
            C_NroRacional Result = new C_NroRacional(v_Numerador, v_Denominador);

            return Result;
        }

        public static C_NroRacional Resta(C_NroRacional p_fraccion1, C_NroRacional p_fraccion2)
        {
            int v_Numerador = (p_fraccion1.Numerador * p_fraccion2.Denominador) - (p_fraccion2.Numerador * p_fraccion1.Denominador);
            int v_Denominador = p_fraccion1.Denominador * p_fraccion2.Denominador;
            C_NroRacional Result = new C_NroRacional(v_Numerador, v_Denominador);

            return Result;
        }

        public static C_NroRacional Multiplicacion(C_NroRacional p_fraccion1, C_NroRacional p_fraccion2)
        {
            int v_Numerador = p_fraccion1.Numerador * p_fraccion2.Numerador;
            int v_Denominador = p_fraccion1.Denominador * p_fraccion2.Denominador;
            C_NroRacional Result = new C_NroRacional(v_Numerador, v_Denominador);

            return Result;
        }

        public static C_NroRacional Division(C_NroRacional p_fraccion1, C_NroRacional p_fraccion2)
        {
            int v_Numerador = p_fraccion1.Numerador * p_fraccion1.Denominador;
            int v_Denominador = p_fraccion1.Denominador * p_fraccion2.Numerador;
            C_NroRacional Result = new C_NroRacional(v_Numerador, v_Denominador);

            return Result;
        }

        //  Instance Metods

        public C_NroRacional Suma(C_NroRacional frac2)
        {
            C_NroRacional Result = new C_NroRacional((this.Numerador * frac2.Denominador) + (frac2.Numerador * this.Denominador), this.Denominador * frac2.Denominador);
            int Divisor = C_NroRacional.MCD(Result.Numerador, Result.Denominador);

            return new C_NroRacional(Result.Numerador / Divisor, Result.Denominador / Divisor);
        }

        public C_NroRacional Resta(C_NroRacional frac2)
        {
            C_NroRacional Result = new C_NroRacional((this.Numerador * frac2.Denominador) - (frac2.Numerador * this.Denominador),this.Denominador * frac2.Denominador);
            int Divisor = C_NroRacional.MCD(Result.Numerador, Result.Denominador);

            return new C_NroRacional(Result.Numerador / Divisor, Result.Denominador / Divisor);
        }

        public C_NroRacional Multiplicacion(C_NroRacional frac2)
        {
            C_NroRacional Result = new C_NroRacional(this.Numerador * frac2.Numerador, frac2.Denominador * this.Denominador);
            int Divisor = C_NroRacional.MCD(Result.Numerador, Result.Denominador);

            return new C_NroRacional(Result.Numerador / Divisor, Result.Denominador / Divisor);
        }

        public C_NroRacional Division(C_NroRacional frac2)
        {
            C_NroRacional Result = new C_NroRacional(this.Numerador * frac2.Denominador, frac2.Numerador * this.Denominador);
            int Divisor = C_NroRacional.MCD(Result.Numerador, Result.Denominador);
            
            return new C_NroRacional(Result.Numerador / Divisor, Result.Denominador / Divisor);
        }
        // MCD Metod

        public static int MCD(int Numerador, int Denominador)
        {

            while (Denominador != 0)
            {
                int residuo = Numerador % Denominador;
                Numerador = Denominador;
                Denominador = residuo;
            }
            return Numerador;
        }
            public override string ToString()
        {
            return $"{Numerador}/{Denominador}";
        }
        
    }
}

