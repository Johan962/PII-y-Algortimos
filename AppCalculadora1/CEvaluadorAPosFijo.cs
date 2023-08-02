using BibliotecaTDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AppCalculadora1.cStringTokenizer;

namespace AppCalculadora1
{
    internal class CEvaluadorPosFijo
    {
        #region ***************** ATRIBUTOS *******************
        private String aExpresion;
        #endregion ATRIBUTOS
        #region ***************** CONSTRUCTORES *******************
        /* ---------------------------------------------- */
        public CEvaluadorPosFijo()
        {
            aExpresion = "";
        }
        /* ---------------------------------------------- */
        public CEvaluadorPosFijo(String pExpresion)
        {
            aExpresion = pExpresion;
        }
        /* ---------------------------------------------- */
        public CEvaluadorPosFijo Crear()
        {
            return new CEvaluadorPosFijo();
        }
        /* ---------------------------------------------- */
        public CEvaluadorPosFijo Crear(String pExpresion)
        {
            return new CEvaluadorPosFijo(pExpresion);
        }
        #endregion CONSTRUCTORES
        #region ***************** PROPIEDADES *******************
        /* ---------------------------------------------- */
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
        #endregion PROPIEDADES
        #region ***************** METODOS *******************
        /* ---------------------------------------------- */
        public double Potencia(double base_, double exponente)
        {
            return (double)Math.Exp(exponente * Math.Log(base_));
        }
        /* ---------------------------------------------- */
        public void ProcesarToken(String Token, cPila Pila)
        { // Este metodo procesa un Token, considerando tres casos:
          // a) Si Token es un operador (+,-,*,/,^) desaPila dos
          // Operandos de la Pila, efectua la operacion y aPila
          // el resultado
          // b) Si Token es un operaando, simplemente aPila en la Pila
          // c) Si Token es un blanco, simplemente se ignora
            if (Token.Equals("+") || Token.Equals("-") || Token.Equals("*") ||
            Token.Equals("/") || Token.Equals("^"))
            {
                // Recuperar Operandos. Notar que el metodo Cima() de la
                // Pila devuelve un Objeto, por tanto es necesario
                // convertirlo en un double mediante un casting
                double OperandoDer = double.Parse(Pila.Cima().ToString());
                Pila.Desapilar();
                double OperandoIzq = double.Parse(Pila.Cima().ToString());
                Pila.Desapilar();
                // ----- Efectuar operacion y Apilar el resultado
                // Notar que el resultado de cada operacion
                // se debe Apilar como un objeto de tipo double
                if (Token.Equals("+"))
                    Pila.Apilar(OperandoIzq + OperandoDer);
                else if (Token.Equals("-"))
                    Pila.Apilar(OperandoIzq - OperandoDer);
                else if (Token.Equals("*"))
                    Pila.Apilar(OperandoIzq * OperandoDer);
                else if (Token.Equals("/"))
                    Pila.Apilar(OperandoIzq / OperandoDer);
                else if (Token.Equals("^"))
                    Pila.Apilar(Potencia(OperandoIzq, OperandoDer));

            }
            else
            if (!Token.Equals(" ")) // ----- Token es un Operando
                Pila.Apilar(Token);

        }
        /* ---------------------------------------------- */
        public double Evaluar()
        {
            // ----- Declarar objetos
            cPila Pila;
            cStringTokenizer ST;
            String Token;
            // ----- Crear un objeto Pila
            Pila = new cPila();
            // ----- Crear un objeto Tokenizer
            ST = new cStringTokenizer(aExpresion, "+-*/^ ", true);

            // ----- Evaluar expresion, descomponiendo en Tokens
            if (ST.CountTokens() > 0)
                do
                {
                    Token = ST.NextToken();
                    ProcesarToken(Token, Pila);
                } while (ST.HasMoreTokens());
            // ----- Obtener el resultado de la Pila
            return double.Parse(Pila.Cima().ToString());
        }
        /* ---------------------------------------------- */
        public double Evaluar(String pExpresion)
        {
            aExpresion = pExpresion;
            return Evaluar();
        }
        #endregion METODOS
    }
}
