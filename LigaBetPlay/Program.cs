internal partial class Program
{
    private static void Main(string[] args)
    {
        int opcion;

        do
        {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n:");
                    Console.WriteLine("1. Registro Equipo");
                    Console.WriteLine("2. Registrar Entrenador");
                    Console.WriteLine("3. Registrar Masajista");
                    Console.WriteLine("4. Registrar Masajista");
                    Console.WriteLine("5. Venta Jugador");
                    Console.WriteLine("0. Volver al Menù Principal");


                    break;
                case 2:
                    Console.WriteLine("\n:");
                    Console.WriteLine("1. Listar Jugadores por Equipo");
                    Console.WriteLine("2. Buscar los delanteros de cada equipo");
                    Console.WriteLine("3. Buscar cuerpo entrenadores por equipo");
                    Console.WriteLine("4. Registrar Masajista");
                    Console.WriteLine("5. Venta Jugador");
                    Console.WriteLine("0. Volver al Menù Principal");
                    break;
                case 3:
                    Console.WriteLine("Hasta luego.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 3);
    }
    static void MostrarMenu()
    {
        Console.WriteLine("\n--------------- Liga BetPlay ----------------");
        Console.WriteLine("1. Registrar Plantel");
        Console.WriteLine("2. consulta de datos");
        Console.WriteLine("3. Salir");
    }

    static int PedirOpcion()
    {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

}
