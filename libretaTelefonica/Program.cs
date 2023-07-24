using System;
using System.Collections;
class Program
{
    public static Dictionary<string, double> AgendaTelefonica = new Dictionary<string, double> ();

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
                    AgregarContacto();
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
        string? nombreContacto = Console.ReadLine() ;
        Console.Write("Ingrese el Telèfono del contacto: ");
        double telContacto = double.Parse(Console.ReadLine());
        AgendaTelefonica.Add(nombreContacto, telContacto);
    }

    static void MostrarContactos()
    {
        Console.WriteLine($"\nNombre\tTelefono");

        foreach (KeyValuePair<string,double> contacto in AgendaTelefonica)
        {
            Console.WriteLine("\n"+contacto.Key + "\t" + contacto.Value);

        }
    }

    static void MarcarFavorito()
    {
        Console.Write("Ingresa el Nùmero de Telèfono del contacto que quiere marcar como favorito: ");
        double numFavorito = double.Parse(Console.ReadLine());
        int contactoFav = AgendaTelefonica.Values.ToList().Contains(numFavorito);

        KeyValuePair<string, double> resultado = AgendaTelefonica.ElementAt(contactoFav);
        Console.WriteLine(resultado.Key + "🌟"); 
    }
}
