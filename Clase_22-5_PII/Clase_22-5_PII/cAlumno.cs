using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_22_5_PII
{
    internal class cAlumno:cPersona
    { 
        private string aCodigo;
        private string aEP;
    public cAlumno() : base()
    {
        aCodigo = "";
        aEP = "";
    }
    public cAlumno(string pNombre, string pPaterno, string pMaterno, string pDNI, string pCodigo, string pEP)
        : base(pNombre, pPaterno, pMaterno, pDNI)
    {
        aCodigo = pCodigo;
        aEP = pEP;
    }
    public string Codigo
    {
        get { return aCodigo; }
        set { aCodigo = value; }
    }
    public string EP
    {
        get { return aEP; }
        set { aEP = value; }
    }

    public override string ToString()
    {
        return base.ToString() + " " + aCodigo + " " + aEP;
    }
    public override void Leer()
    {
        base.Leer();
        Console.Write("Codigo: ");
        Codigo = Console.ReadLine();
        Console.Write("Escuela Profesional: ");
        EP = Console.ReadLine();
    }
    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine("Codigo: " + Codigo);
        Console.WriteLine("Escuela Profesional: " + EP);
    }
    public override int Bonificacion(int pNroDias)
    {
        if (pNroDias == 2)
            return 5;
        else
            return 2;
    }
    }
}
