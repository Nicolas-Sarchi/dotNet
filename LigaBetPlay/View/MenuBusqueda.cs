
namespace LigaBetPlay.View;

public class MenuBusqueda
{

    public MenuBusqueda() { }

    public int ConsultaDatos()
    {
        Console.Clear();
        Console.WriteLine("\n------------------- Consulta de Datos ------------------:");
        Console.WriteLine("1. Listar Jugadores por Equipo");
        Console.WriteLine("2. Buscar los delanteros de cada equipo");
        Console.WriteLine("3. Buscar cuerpo entrenadores por equipo");
        Console.WriteLine("4. Volver al Menù Principal");
        return Convert.ToInt32(Console.ReadLine()); 

    }
}
