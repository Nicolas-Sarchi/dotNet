using System;
using System.Collections.Generic;
class Program
{
    public static Dictionary<double, Usuario> Usuarios = new Dictionary<double, Usuario>();

    static void Main()
    {
    
 int opcion;

        do
        {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion)
            {
                case 1:
                    AgregarUsuario();
                    break;
                case 2:
                    MostrarUsuarioPorId();
                    break;
                case 3:
                    MostrarTodosLosUsers();
                    break;
                case 4:
                    EliminarUsuario();
                    break;
                case 5:
                    Console.WriteLine("Hasta luego.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 5);
    }
 static void MostrarMenu()
    {
        Console.WriteLine("\n***********************HOBBIES*************************");
        Console.WriteLine("1. Agregar Usuario");
        Console.WriteLine("2. Mostrar Datos de un usuario");
        Console.WriteLine("3. Mostrar usuarios");
        Console.WriteLine("4. Eliminar Usuario");
        Console.WriteLine("5. Salir");
    }

    static int PedirOpcion()
    {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void AgregarUsuario()
    {
         Console.Write("Ingrese el nùmero de documento del Usuario ");
        double idUsuario = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el Nombre del Usuario: ");
        string? nombreUsuario = Console.ReadLine();
        Console.Write("Ingrese la Edad del Usuario: ");
        int edadUsuario = int.Parse(Console.ReadLine());
        Console.Write("Ingrese los Hobbies del Usuario separados por un guion (-): ");
        string? hobbiesStr = Console.ReadLine();

        string[] Hobbies = hobbiesStr.Split("-");

        Usuario usuario  = new Usuario(nombreUsuario, edadUsuario, Hobbies);

        Usuarios.Add(idUsuario,usuario);

        
    }

    static void MostrarUsuarioPorId()
    {
        Console.Write("\nIngrese el numero de documento del Usuario: ");
        double idUsuario = double.Parse(Console.ReadLine());

        if (Usuarios.ContainsKey(idUsuario))
        {
            var usuario = Usuarios[idUsuario];

            string hobies = string.Join(" ", usuario.Hobbies);
            
        Console.WriteLine($"\nNombre\t\tEdad\t\t\tHobbies");

        Console.WriteLine($"\n{usuario.Nombre}\t\t{usuario.Edad}\t\t\t{hobies}");
        }
        
        else
        {
            Console.WriteLine("\nUsuario no encontrado.");
        }
    }
    static void MostrarTodosLosUsers()
    {
        Console.WriteLine("\nNombre\t\tEdad\t\t\tHobbies");

        foreach (var usuario in Usuarios)
        {
            string hobies = string.Join(" ",usuario.Value.Hobbies);
            
        Console.WriteLine($"\n{usuario.Value.Nombre}\t\t{usuario.Value.Edad}\t\t\t{hobies}");
        }
    }

    static void EliminarUsuario()
    {
        Console.Write("\nIngrese el Numero de documento del Usuario a eliminar: ");
        double idUsuario = double.Parse(Console.ReadLine());

        if (Usuarios.ContainsKey(idUsuario))
        {
            Usuarios.Remove(idUsuario);
            Console.WriteLine("\n*Usuario eliminado correctamente.*");
        }
        else
        {
            Console.WriteLine("\nUsuario no encontrado.");
        }
    }
}
