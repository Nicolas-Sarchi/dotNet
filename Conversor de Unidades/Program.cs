static double convertiraFahrenheit (double celcius)
{
    return celcius * 1.8 + 32;
}

static double convertiraCelsius (double fahrenheit)
{
    return (fahrenheit - 32) / 1.8;
}

static double convertiraPies (double metros)
{
    return metros * 3.2808399;
}

static double convertiraMetros (double pies)
{
    return pies / 3.2808399;
}

int opcion;
do
{
    Console.WriteLine("\nMenú de opciones:");
    Console.WriteLine("1. Convertir Celcius a Fahrenheit");
    Console.WriteLine("2. Convertir Fahrenheit a Celcius");
    Console.WriteLine("3. Convertir Pies a Metros");
    Console.WriteLine("4. Convertir Metros a Pies");
    Console.WriteLine("5. Salir");
    Console.Write("Elige una opción: ");
    opcion = int.TryParse(Console.ReadLine(), out int opcion1) ? opcion1 : 0;

    switch (opcion)
    {
        case 1:
            Console.Write("\nIngrese la temperatura en grados Celsius:");
            double celcius = double.TryParse(Console.ReadLine(), out double celcius1) ? celcius1 : 0;
            Console.WriteLine($"{celcius} grados Celsius son: {convertiraFahrenheit(celcius)} grados Fahrenheit");
            break;
        case 2:
            Console.Write("\nIngrese la temperatura en grados Fahrenheit:");
            double fahrenheit = double.TryParse(Console.ReadLine(), out double fahrenheit1) ? fahrenheit1 : 0;
            Console.WriteLine($"{fahrenheit} grados Fahrenheit son: {convertiraCelsius(fahrenheit)} grados Celsius");
            break;
        case 3:
            Console.Write("\nIngrese la longitud en Pies:");
            double pies = double.TryParse(Console.ReadLine(), out double pies1) ? pies1 : 0;
            Console.WriteLine($"{pies} pies son: {convertiraMetros(pies)} metros");
            break;
        case 4:
            Console.Write("\nIngrese la longitud en Metros:");
            double metros = double.TryParse(Console.ReadLine(), out double metros1) ? metros1 : 0;
            Console.WriteLine($"{metros} metros son: {convertiraPies(metros)} pies");
            break;
        case 5:
            Console.WriteLine("\n¡Hasta luego!");
            break;
        default:
            Console.WriteLine("\nOpción inválida. Inténtalo de nuevo.");
            break;
    }
} while (opcion != 5);
