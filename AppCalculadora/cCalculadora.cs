using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BibliotecaTDA;

namespace AppCalculadora
{
    internal class cCalculadora
    {
        //Attributes
        private string aExpresion;

        //Constructors

        public cCalculadora()
        {
            aExpresion = "";
        }

        public cCalculadora(string pExpresion)
        {
            aExpresion = pExpresion;
        }

        //Properties
        public string Expresion
        {
            get { return aExpresion; }
            set { aExpresion = value; } 
        }

        //Metods

        public double Evaluar()
        {
            string ExpresionPosfija;

            cConvertidorAPosfijo ConvertidorAPosfijo = new cConvertidorAPosfijo();
            ExpresionPosfija = ConvertidorAPosfijo.Convertir(aExpresion);
            Console.WriteLine($"evaluar   {ExpresionPosfija}");

            cEvaluadorPosfijo EvaluadorPosfijo = new cEvaluadorPosfijo();
            return EvaluadorPosfijo.Evaluar(ExpresionPosfija);
        }

        public double Evaluar(string pExpresion)
        {
            aExpresion = pExpresion;
            return Evaluar();
        }
    }
}
