using System.Collections;
using System.Security.Cryptography.X509Certificates;
using EXAMEN_PII;

internal class Program
{
    private static void Main(string[] args)
    {
        //Arraylist usada para comprobar el codigo
        ArrayList list = new ArrayList();
        list.Add(new cFuncionario(12345678, "Johan Conde Sallo", "XXXX-XXXX", "Gerente", 2000, 1));
        list.Add(new cFuncionario(12345679, "Mihail Sallo Conde", "XXXX-YYYY", "Administrador", 1800, 6));
        list.Add(new cFuncionario(12345680, "Oscar Barrientos Huillca", "XXXX-ZZZZ", "JefeArea", 1500, 5));
        list.Add(new cObrero(12345681, "Pavel Chevarria Rodriguez", "XXXX-XXXX", 10, 40, 5));
        list.Add(new cObrero(12345682, "Denis Choque", "XXXX-XXXX", 10, 40, 10));

        //Calcular el PagoTotal por HorasExtra
        double PagoTotal = 0;
        foreach (cEmpleado Empleado in list)
        {
            if (Empleado is cObrero)
            {
                PagoTotal += Empleado.PagosHoras * 1.5 * Empleado.PagoHora;
            }
        }
        Console.WriteLine("El Pago total por horas extra es " + PagoTotal.ToString());

        //Mostrar el nombre del empleado con mayor sueldo
        cEmpleado Mayor = (cEmpleado)list[0];
        foreach (cEmpleado empleado in list)
        {
            if (empleado.SueldoTotal() > Mayor.SueldoTotal())
            {
                Mayor = empleado;
            }
        }
        Console.WriteLine("El empleado con el mayor sueldo es " + Mayor.Nombre.ToString());

    }
}