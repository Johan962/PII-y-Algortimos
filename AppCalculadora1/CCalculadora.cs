using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadora1
{
    internal class CCalculadora
    {
        #region ***************** ATRIBUTOS ******************
        private string aExpresion;
        #endregion ATRIBUTOS
        #region ***************** CONSTRUCTORES ******************
        /* ---------------------------------------------- */
        public CCalculadora()
        {
            aExpresion = "";
        }
        /* -------------------------------------------------*/
        public CCalculadora(string pExpresion)
        {
            aExpresion = pExpresion;
        }
        /* ---------------------------------------------- */
        public CCalculadora Crear()
        {
            return new CCalculadora();
        }
        /* -------------------------------------------------*/
        public CCalculadora Crear(string pExpresion)
        {
            return new CCalculadora(pExpresion);
        }
        #endregion CONSTRUCTORES
        #region ***************** PROPIEDADES ******************
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
        #region ***************** METODOS ******************
        /* -------------------------------------------------*/
        public double Evaluar()
        {
            string ExpresionPosFijo;
            // ----- Convertir expresion InFija a PosFija
            CConvertidorAPosFijo ConvertidorAPosFijo = new CConvertidorAPosFijo();
            ExpresionPosFijo = ConvertidorAPosFijo.Convertir(aExpresion);
            Console.WriteLine(ExpresionPosFijo.ToString());
            // ----- Evaluar expresion PosFija
            CEvaluadorPosFijo EvaluadorPosFijo = new CEvaluadorPosFijo();
            return EvaluadorPosFijo.Evaluar(ExpresionPosFijo);
        }
        /* -------------------------------------------------*/
        public double Evaluar(string pExpresion)
        {
            aExpresion = pExpresion;
            return Evaluar();
        }
        #endregion METODOS
    }
}
