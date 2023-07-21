// See https://aka.ms/new-console-template for more information
int opcion;
do {
    Console.WriteLine("Menú de opciones:");
    Console.WriteLine("1. Opción 1");
    Console.WriteLine("2. Opción 2");
    Console.WriteLine("3. Salir");
    Console.Write("Elige una opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion) {
        case 1:
            Console.WriteLine("Seleccionaste Opción 1.");
            break;
        case 2:
            Console.WriteLine("Seleccionaste Opción 2.");
            break;
        case 3:
            Console.WriteLine("¡Hasta luego!");
            break;
        default:
            Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
            break;
    }
} while (opcion != 3);



