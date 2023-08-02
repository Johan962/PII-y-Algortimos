using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaTDA;
using AppCalculadora1;

namespace AppCalculadora1
{
    internal class CConvertidorAPosFijo
    {
        #region /* ***************** Atributos ****************** */
        private string aExpresion;
        #endregion Atributos
        #region /* ***************** Constructores ****************** */
        /* ---------------------------------------------- */
        public CConvertidorAPosFijo()
        {
            aExpresion = "";
        }
        /* ---------------------------------------------- */
        public CConvertidorAPosFijo(string pExpresion)
        {
            aExpresion = pExpresion;
        }
        /* ---------------------------------------------- */
        public static CConvertidorAPosFijo Crear()
        {
            return new CConvertidorAPosFijo();
        }
        /* ---------------------------------------------- */
        public static CConvertidorAPosFijo Crear(string pExpresion)
        {
            return new CConvertidorAPosFijo(pExpresion);
        }
        #endregion Constructores
        #region /* ***************** Propiedades ****************** */
        public string Expresion
        {
            get
            {
                return aExpresion;
            }
            set
            {
                aExpresion = value;
            }
        }
        #endregion Propiedades
        #region /* ***************** METODOS ****************** */
        /* ---------------------------------------------- */
        public bool okPrecedencia(string Token1, string Token2)
        {
            if (Token1.Equals("+") || Token1.Equals("-"))
                return (!Token2.Equals("("));
            else
            if ((Token1.Equals("*") || Token1.Equals("/")) &&
            (Token2.Equals("*") || Token2.Equals("/") || Token2.Equals("^")))
                return true;
            else
                return false;

        }
        /* ---------------------------------------------- */
        public string ProcesarToken(string Token,

        cPila Pila,
        string ExpresionPosFijo)

        {
            // ----- Si Token = ")" Desapilar todos los operadores hasta encontrar "("
            if (Token.Equals(")"))
            {
                while ((!Pila.EsVacio()) && (!((string)Pila.Cima()).Equals("(")))
                {
                    ExpresionPosFijo = ExpresionPosFijo + (string)Pila.Cima();
                    // ----- Desapilar operador
                    Pila.Desapilar();
                }
                // ----- Quitar de la Pila el ")"
                if (!Pila.EsVacio())
                    Pila.Desapilar();

            }
            else
            if (Token.Equals("+") || Token.Equals("-") ||
            Token.Equals("*") || Token.Equals("/") ||
            Token.Equals("^"))
            {
                // ----- Desapilar operadores, si existen de acuerdo a su precedencia
                while ((!Pila.EsVacio()) && okPrecedencia(Token, (String)Pila.Cima()))
                {
                    // ----- Agregar operador a la expresion PosFijo
                    ExpresionPosFijo = ExpresionPosFijo + (String)Pila.Cima();
                    // ----- Desapilar operador
                    Pila.Desapilar();
                }
                // ----- Apilar nuevo operador
                Pila.Apilar(Token);
            }
            else
            // ----- Si es "(" Apilar
            if (Token.Equals("("))
                Pila.Apilar(Token);
            else
            // ----- Si no es " " agregar Token a ExpresionPosFijo, caso contrario ignorar Token.
            if (!Token.Equals(" "))
                ExpresionPosFijo = ExpresionPosFijo + " " + Token;
            // ----- Retornar valor de expresion posFijo
            return ExpresionPosFijo;
        }

        /* ---------------------------------------------- */
        public string Convertir()
        {
            // ----- Declarar objetos
            cPila Pila = new cPila();
            cStringTokenizer ST = new cStringTokenizer(aExpresion, "+-*/^() ", true);
            string Token;
            string ExpresionPosFijo = "";
            // ----- Convertir expresion, descomponiendo en Tokens
            if (ST.CountTokens() > 0)
                do
                {
                    Token = ST.NextToken();
                    ExpresionPosFijo = ProcesarToken(Token, Pila, ExpresionPosFijo);
                } while (ST.HasMoreTokens());
            // ----- Desapilar todos los operadores que quedan en la Pila
            while (!Pila.EsVacio())
            {
                // ----- Agregar operador a la expresion PosFijo
                ExpresionPosFijo = ExpresionPosFijo + (String)Pila.Cima();
                // ----- Desapilar operador
                Pila.Desapilar();
            }
            return ExpresionPosFijo;
        }
        /* ---------------------------------------------- */
        public String Convertir(String TextoExpresion)
        {
            aExpresion = TextoExpresion;
            return Convertir();
        }
        #endregion METODOS
    }    
}

