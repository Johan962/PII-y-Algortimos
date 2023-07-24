using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaTDA;

namespace AppCalculadora
{
    internal class cConvertidorAPosfijo
    {
        //Attributes

        private string aExpresion;

        //Constructors

        public cConvertidorAPosfijo()
        {
            aExpresion = string.Empty;
        }

        public cConvertidorAPosfijo(string pExpresion)
        {
            aExpresion = pExpresion;
        }

        public static cConvertidorAPosfijo Crear(string pExpresion)
        {
            return new cConvertidorAPosfijo(pExpresion);
        }

        //Properties

        public string Expresion
        {
            get { return aExpresion; }
            set { aExpresion = value; }
        }

        //Metods

        public bool okPrecedencia(string Token1,string Token2)
        {
            if (Token1.Equals("+") || Token1.Equals("-"))
                return (!Token2.Equals("("));
            else
                if ((Token1).Equals("*") || Token1.Equals("/") && (Token2.Equals("*")) || (Token2.Equals("/") && (Token2.Equals("^"))))
                    return true;
            else 
                return false;
        }

        public string ProcesartToken(string Token, cPila Pila, string ExpresionAPosfija)
        {
            if (Token.Equals(")"))
            {
                while ((!Pila.EsVacio()) && (!((string)Pila.Cima()).Equals("(")))
                {
                    ExpresionAPosfija = ExpresionAPosfija + (string)Pila.Cima();
                    Pila.Desapilar();
                }

                if (!Pila.EsVacio())
                {
                    Pila.Desapilar();
                }
            }
            else
                if (Token.Equals("+") || Token.Equals("-") || Token.Equals("*") || Token.Equals("/") || Token.Equals("^"))
            {
                while ((!Pila.EsVacio()) && okPrecedencia(Token, (string)Pila.Cima()))
                {
                    ExpresionAPosfija = ExpresionAPosfija + (string)Pila.Cima();
                    Pila.Desapilar();
                }
                Pila.Apilar(Token);
            }
            else
                if (Token.Equals("("))
                Pila.Apilar(Token);
            else
                if (Token.Equals(" "))
                ExpresionAPosfija = ExpresionAPosfija + " " + Token;
            return ExpresionAPosfija;
        }

        public string Convertir()
        {
            cPila Pila = new cPila();
            cStringTokenizer ST = new cStringTokenizer(aExpresion, "+-*/() ", true);
            string Token;
            string ExpresionPosFijo = "";

            if (ST.CountTokens() > 0)
                do
                {
                    Token = ST.NextToken();
                    Console.WriteLine(Token);
                    ExpresionPosFijo = ProcesartToken(Token, Pila, ExpresionPosFijo);
                } while (ST.HasMoreTokens());

            while (!Pila.EsVacio())
            {
                ExpresionPosFijo = ExpresionPosFijo + (String)Pila.Cima();
                Pila.Desapilar();

            }
            Console.WriteLine($"Expresion: -{ExpresionPosFijo}-");
            return ExpresionPosFijo;
        }

        public String Convertir(String TextoExpresion)
        {
            aExpresion = TextoExpresion;
            return Convertir();
        }
    }
}
