using Clase_22_5_PII;
using System.Collections;

public class Program
{
    private static void Main(string[] args)
    {
        ArrayList Dia1 = new ArrayList();
        ArrayList Dia2 = new ArrayList();

        C_Alumno o_Alumno1 = new C_Alumno();
        //o_Alumno1.Leer();


        Dia1.Add(new C_Alumno(12345678, "Joaquin", 212121, "INFORMATICA"));
        Dia1.Add(new C_Docente(12345679, "Oscar", 222222, "MATEMATICA", "Nombrado"));
        Dia1.Add(new C_Alumno(12345671, "Ramses", 232323, "INFORMATICA"));

        Dia2.Add(new C_Alumno(12345678, "Joaquin", 212121, "INFORMATICA"));
        Dia2.Add(new C_Docente(12345679, "Oscar", 222222, "MATEMATICA", "Nombrado"));
        Dia2.Add(new C_Alumno(12345672, "Mario", 242424, "ECONOMIA"));

        ArrayList ConCerti = new ArrayList();

        foreach (C_Persona Persona in Dia1)
        {
            for (int i = 0; i < Dia2.Count-1; i++)
            {
                //Console.WriteLine(Dia2[i]);
                if (Persona.Equals((C_Persona)Dia2[i]))
                {
                    Console.WriteLine(Persona);
                    ConCerti.Add(Persona);
                }
            }

        }
        //foreach (C_Docente Docente in Dia1)
        //{
        //    for (int i = 0; i < Dia2.Count; i++)
        //    {
        //        if (Docente == Dia2[i])
        //        {
        //            ConCerti.Add(Docente);
        //        }
        //    }

        //}

        for (int i = 0; i < ConCerti.Count; i++)
        {
            Console.WriteLine(ConCerti);
        }
    }
}