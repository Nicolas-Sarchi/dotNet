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
                    RegistroPlantel();
                    break;
                case 2:
                    ConsultaDatos();
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
        Console.Clear();
        Console.WriteLine("\n--------------- Liga BetPlay ----------------");
        Console.WriteLine("1. Registrar Plantel");
        Console.WriteLine("2. Consulta de datos");
        Console.WriteLine("3. Salir");
    }

    static int PedirOpcion()
    {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void RegistroPlantel()
    {
        Console.Clear();
        Console.WriteLine("\n-----------------Registro de Plantel -----------------");
        Console.WriteLine("1. Registro Equipo");
        Console.WriteLine("2. Registrar Entrenador");
        Console.WriteLine("3. Registrar Masajista");
        Console.WriteLine("4. Registrar Jugador");
        Console.WriteLine("5. Venta Jugador");
        Console.WriteLine("0. Volver al Menù Principal");

        int opcion = PedirOpcion();
        switch (opcion)
        {
            case 1:
                Console.WriteLine("1. Aquí va el código para registrar equipo");
                break;
            case 2:
                Console.WriteLine("1. Aquí va el código para registrar entrenador");
                break;
            case 3:
                Console.WriteLine("1. Aquí va el código para registrar masajista");
                break;
            case 4:
                Console.WriteLine("1. Aquí va el código para registrar jugador");
                break;
            case 5:
                Console.WriteLine("1. Aquí va el código para venta jugador");
                break;
            default:
                Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                break;
        }
    }

    static void ConsultaDatos()
    {
        Console.Clear();
        Console.WriteLine("\n------------------- Consulta de Datos ------------------:");
        Console.WriteLine("1. Listar Jugadores por Equipo");
        Console.WriteLine("2. Buscar los delanteros de cada equipo");
        Console.WriteLine("3. Buscar cuerpo entrenadores por equipo");
        Console.WriteLine("4. Registrar Masajista");
        Console.WriteLine("5. Venta Jugador");
        Console.WriteLine("0. Volver al Menù Principal");

        int opcion = PedirOpcion();
        switch (opcion)
        {
            case 1:
                Console.WriteLine("1. Aquí va el código para listar jugadores por equipo");
                break;
            case 2:
                Console.WriteLine("1. Aquí va el código para buscar los delanteros de cada equipo");
                break;
            case 3:
                Console.WriteLine("1. Aquí va el código para buscar cuerpo entrenadores por equipo");
                break;
            case 4:
                Console.WriteLine("1. Aquí va el código para registrar masajista");
                break;
            default:
                Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                break;
        }
    }
}

