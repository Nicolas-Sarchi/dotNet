namespace CentroReparacionAutomotriz.view;
public class MainMenu
{
    public int MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("\n------- Centro De Reparacion Automotriz -------");
        Console.WriteLine($"1. Registrar");
        Console.WriteLine("2. Consulta de datos");
        Console.WriteLine("3. Salir");
        return Convert.ToInt32(Console.ReadLine());
    }
}
