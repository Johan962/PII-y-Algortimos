using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BibliotecaTDA;
namespace AppCalculadora
{
    internal class cEvaluadorPosfijo
    {
        //Attributes
        private String aExpresion;

        //Constructors

        public cEvaluadorPosfijo()
        {
            aExpresion = "";
        }

        public cEvaluadorPosfijo(String pExpresion)
        {
            aExpresion = pExpresion;
        }

        public cEvaluadorPosfijo Crear(String pExpresion)
        {
            return new cEvaluadorPosfijo( pExpresion);
        }

        //Properties
        public String Expresion
        {
            get { return aExpresion; }
            set { aExpresion = value; }
        }

        //Metods

        public double Potencia(double base_, double exponente)
        {
            return ( double)Math.Exp(exponente*Math.Log(base_));
        }

        public void ProcesarToken(String Token, cPila Pila)
        {
            if (Token.Equals("+") || Token.Equals("-") || Token.Equals("*") || Token.Equals("/") || Token.Equals("^"))
            {
                double OperandoDer = double.Parse(Pila.Cima().ToString());
                Pila.Desapilar();
                double OperandoIzq = double.Parse(Pila.Cima().ToString());
                Pila.Desapilar();

                if (Token.Equals("+"))
                    Pila.Apilar(OperandoIzq + OperandoDer);
                else if (Token.Equals("-"))
                    Pila.Apilar(OperandoIzq - OperandoDer);
                else if (Token.Equals("*"))
                    Pila.Apilar(OperandoIzq * OperandoDer);
                else if (Token.Equals("/"))
                    Pila.Apilar(OperandoIzq / OperandoDer);
                else if (Token.Equals("^"))
                    Pila.Apilar(Potencia(OperandoIzq,OperandoDer));

            }
            else 
                if (!Token.Equals(" "))
                    Pila.Apilar(Token);
        }

        public double Evaluar()
        {
            cPila Pila;
            cStringTokenizer ST;
            String Token;

            Pila = new cPila();

            ST = new cStringTokenizer(aExpresion, "+-*/^ ",true);

            if (ST.CountTokens() > 0)
            do
            {
                    Token = ST.NextToken();
                    ProcesarToken(Token, Pila);
            } while (ST.HasMoreTokens());

            return double.Parse(Pila.Cima().ToString()); 

        }

        public double Evaluar(String pExpresion)
        {
            aExpresion = pExpresion;
            return Evaluar();
        }

    }
}
