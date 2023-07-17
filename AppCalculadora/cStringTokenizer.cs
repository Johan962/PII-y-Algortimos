using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaTDA;

namespace AppCalculadora
{
    internal class cStringTokenizer
    {
        //Attributes
        private string aTexto;
        private cListaRecursiva aLista;
        private int aIndice;

        //Constructors

        public cStringTokenizer(string pTexto)
        {
            aTexto = pTexto;
            GenerarListaTokens(" \n\r\t", true);
        }

        public cStringTokenizer(string pTexto, string pDelimitadores)
        {
            aTexto = pTexto;
            GenerarListaTokens(pDelimitadores, true);
        }

        public cStringTokenizer(string pTexto, string pDelimitadores, bool RetornaTokens )
        {
            aTexto = pTexto;
            GenerarListaTokens(pDelimitadores, RetornaTokens);

        }


        //Metods

        private void GenerarListaTokens(string Delimitadores, bool RetornaTokens)
        {
            aLista = new cListaRecursiva();

            char[] Caracteres = aTexto.ToCharArray();

            string Token = " ";

            for  (int k = 0; k < Caracteres.Length; k++)
            {
                if (Delimitadores.IndexOf(Caracteres[k]) == -1)
                {
                    Token = Token + Caracteres[k].ToString();
                }
                else
                {
                    if (!Token.Equals(""))
                    {
                        aLista.Agregar(Token);
                    }

                    if (RetornaTokens)
                    {
                        aLista.Agregar(Caracteres[k].ToString());
                    }
                    Token = "";
                }
            }
            if (!Token.Equals(""))
                aLista.Agregar(Token);

            aIndice = 0;
        }

        //Metods

        public int CountTokens()
        {
            return aLista.Longitud();
        }

        public bool HasMoreTokens()
        {
            return ( aIndice < aLista.Longitud()); 
        }

        public string NextToken()
        {
            if (aIndice < aLista.Longitud())
            {
                return aLista.Iesimo(aIndice++).ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
