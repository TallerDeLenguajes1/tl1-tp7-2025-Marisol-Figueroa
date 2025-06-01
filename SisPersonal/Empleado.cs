namespace SisPersonal;

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador,
}

public class Empleado
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public char EstadoCivil { get; set; }
    public DateTime FechaIngreso { get; set; }
    public double SueldoBasico { get; set; }
    public Cargos Cargo { get; set; }

    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        EstadoCivil = estadoCivil;
        FechaIngreso = fechaIngreso;
        SueldoBasico = sueldoBasico;
        Cargo = cargo;
    }
    public int Antiguedad
    {
        get
        {
            var fecha = DateTime.Today;
            int antiguedad = fecha.Year - FechaIngreso.Year;
            if (FechaIngreso.Date > fecha.AddYears(-antiguedad)) antiguedad--;
            return antiguedad;
        }
    }

    public int Edad
    {
        get
        {
            var dia = DateTime.Today;
            int edad = dia.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > dia.AddYears(-edad)) edad--;
            return edad;
        }
    }

    public int AniosJubilarse
    {
        get
        {
            return Math.Max(0, 65 - Edad);
        }
    }

    public double CalcularSalario()
    {
        double adicional = 0;
        int antiguedad = Antiguedad;
        if (antiguedad <= 20)
            adicional = SueldoBasico * (0.01 * antiguedad);
        else
            adicional = SueldoBasico * 0.25;
        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
            adicional *= 1.5;

        if (EstadoCivil == 'C' || EstadoCivil == 'c')
            adicional += 150000;

        return SueldoBasico + adicional;
    }
    
     public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre} {Apellido}");
        Console.WriteLine($"Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}");
        Console.WriteLine($"Estado Civil: {EstadoCivil}");
        Console.WriteLine($"Fecha de Ingreso: {FechaIngreso.ToShortDateString()}");
        Console.WriteLine($"Sueldo Básico: {SueldoBasico}");
        Console.WriteLine($"Cargo: {Cargo}");
    }

    public void MostrarInformacionCompleta()
    {
        MostrarInformacion();
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Antigüedad: {Antiguedad}");
        Console.WriteLine($"Años para jubilarse: {AniosJubilarse}");
        Console.WriteLine($"Salario total: {CalcularSalario()}");
    }
}