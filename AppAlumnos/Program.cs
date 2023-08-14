using AppAlumnos;
using BibliotecaTDA;
internal class Program

{
    private static void Main(string[] args)
    {
        int N;
        string NombreAlumno;
        int DNIAlumno;
        int CodigoAlumno;
        int OrdenMeritoAlumno;

        cListaOrdenada Lista = new cListaOrdenada();
        Console.Write("Ingrese el numero de alumnos a ingresar: ");
        N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.Write("Alumno " + (N + 1).ToString() + ": ");
            Console.WriteLine("Ingrese el Nombre del Alumno " + (N + 1).ToString() + " : ");
            NombreAlumno = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI del Alumno " + (N + 1).ToString() + " : ");
            DNIAlumno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Codigo del Alumno " + (N + 1).ToString() + " : ");
            CodigoAlumno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Orden de Merito del Alumno " + (N + 1).ToString() + " : ");
            OrdenMeritoAlumno = int.Parse(Console.ReadLine());

            Lista.Agregar(new cAlumno(NombreAlumno,DNIAlumno,CodigoAlumno,OrdenMeritoAlumno));
        }
    }

    public override cListaOrdenada Agregar()
    {

    }
}