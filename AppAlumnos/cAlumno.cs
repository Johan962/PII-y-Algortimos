using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAlumnos
{
    internal class cAlumno
    {
        private string aNombre;
        private int aDNI;
        private int aCodigo;
        private int aOrdenMerito;

        public cAlumno()
        {
            aNombre = string.Empty;
            aDNI = 0;
            aCodigo = 0;
            aOrdenMerito = 0;
        }
        public cAlumno(string aNombre, int aDNI, int aCodigo, int aOrdenMerito)
        {
            this.aNombre = aNombre;
            this.aDNI = aDNI;
            this.aCodigo = aCodigo;
            this.aOrdenMerito = aOrdenMerito;
        }

        public string Nombre
        {
            get { return aNombre; }
            set { aNombre = value;  }
        }

        public int DNI
        {
            get { return aDNI; }
            set { aDNI = value; }
        }

        public int Codigo
        {
            get { return aCodigo; }
            set { aCodigo = value; }
        }

        public int OrdenMerito
        {
            get { return aOrdenMerito; }
            set
            {
                aOrdenMerito = value;
            }
        }

        //Metods
    }
}
