using SisPersonal;


class Informacion
{
    static void Main(string[] args)
    {
        Empleado[] empleados = new Empleado[3];

        empleados[0] = new Empleado("Maria", "López", new DateTime(1985, 3, 10), 'C', new DateTime(2005, 6, 1), 700000, Cargos.Especialista);
        empleados[1] = new Empleado("Carlos", "Ramírez", new DateTime(1990, 8, 15), 'S', new DateTime(2012, 9, 5), 650000, Cargos.Ingeniero);
        empleados[2] = new Empleado("Lucía", "Martínez", new DateTime(1970, 11, 25), 'C', new DateTime(2000, 1, 20), 800000, Cargos.Administrativo);

        Console.WriteLine("INFORMACIÓN DE EMPLEADOS \n");
        foreach (var emp in empleados)
        {
            emp.MostrarInformacionCompleta();
            Console.WriteLine("----------------------------------");
        }

        // Monto total de salarios
        double totalSalarios = empleados.Sum(e => e.CalcularSalario());
        Console.WriteLine($"\nMonto total en salarios: {totalSalarios}");

        // Empleado más próximo a jubilarse
        var proximoAJubilarse = empleados.OrderBy(e => e.AniosJubilarse).First();

        Console.WriteLine("\nEMPLEADO MÁS PRÓXIMO A JUBILARSE ");
        proximoAJubilarse.MostrarInformacionCompleta();
    }
}

