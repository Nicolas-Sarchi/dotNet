using System;
using System.Collections.Generic;

class Program
{
    public static Dictionary<string, (double, bool)> AgendaTelefonica = new Dictionary<string, (double, bool)>();

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
                    AgregarContacto();
                    break;
                case 2:
                    MostrarContactos();
                    break;
                case 3:
                    MarcarFavorito();
                    break;
                case 4:
                    EliminarContacto();
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
        Console.WriteLine("\nMenú de opciones:");
        Console.WriteLine("1. Agregar Contacto");
        Console.WriteLine("2. Mostrar todos los Contactos");
        Console.WriteLine("3. Marcar Contacto como importante");
        Console.WriteLine("4. Eliminar Contacto");
        Console.WriteLine("5. Salir");
    }

    static int PedirOpcion()
    {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void AgregarContacto()
    {
        Console.Write("Ingrese el nombre del contacto: ");
        string? nombreContacto = Console.ReadLine();
        Console.Write("Ingrese el Telèfono del contacto: ");
        double telContacto = double.TryParse(Console.ReadLine(), out telContacto) ? telContacto : 0;
        AgendaTelefonica.Add(nombreContacto, (telContacto, false));
    }

    static void MostrarContactos()
    {
        Console.WriteLine($"\nNombre\t\tTelefono\tFavorito");

        foreach (KeyValuePair<string, (double, bool)> contacto in AgendaTelefonica)
        {
            Console.WriteLine($"\n{contacto.Key}\t\t{contacto.Value.Item1}\t\t{(contacto.Value.Item2 ? "Si" : "No")}");
        }
    }

    static void MarcarFavorito()
    {
        Console.Write("Ingrese el nombre del contacto a marcar como favorito: ");
        string? nombreContacto = Console.ReadLine();

        if (AgendaTelefonica.ContainsKey(nombreContacto))
        {
            var contact = AgendaTelefonica[nombreContacto];
            AgendaTelefonica[nombreContacto] = (contact.Item1, true);
            Console.WriteLine("\nContacto marcado como favorito.");
        }
        else
        {
            Console.WriteLine("\nContacto no encontrado.");
        }
    }

    static void EliminarContacto()
    {
        Console.Write("Ingrese el nombre del contacto a eliminar: ");
        string? nombreContacto = Console.ReadLine();

        if (AgendaTelefonica.ContainsKey(nombreContacto))
        {
            AgendaTelefonica.Remove(nombreContacto);
            Console.WriteLine("Contacto eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }
}