internal class Program
{
    private static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante("Paco", "123");
        Console.WriteLine($"ID del alumno {estudiante.getCodigoEstudiante}");
        Console.WriteLine($"Nombre del alumno {estudiante.GetNombre}");
        Console.WriteLine($"documento del alumno {estudiante.GetDocumento}");
    }
}