static double calcularAreaCirculo(double radio)
{
    return radio * radio * Math.PI;
}

static double calcularAreaCuadrado(double lado)
{
    return lado * lado;
}

static double calcularAreaTriangulo(double baset, double altura)
{
    return baset * altura / 2;
}

int opcion;
do
{
    Console.WriteLine("\nMenú de opciones:");
    Console.WriteLine("1. Calcular el área de un circulo");
    Console.WriteLine("2. Calcular el área de un cuadrado");
    Console.WriteLine("3. Calcular el área de un Triangulo");
    Console.WriteLine("4. Salir");
    Console.Write("Elige una opción: ");
    opcion = int.TryParse(Console.ReadLine(), out int opcion1) ? opcion1 : 0;

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el radio del círculo:");
            double radioCirculo = double.TryParse(Console.ReadLine(), out double radio1) ? radio1 : 0;
            Console.WriteLine($"El área del círculo es: {calcularAreaCirculo(radioCirculo)}");
            break;
        case 2:
            Console.WriteLine("Ingrese el lado del cuadrado:");
            double ladoCuadrado = double.TryParse(Console.ReadLine(), out double lado1) ? lado1 : 0;
            Console.WriteLine($"El área del cuadrado es: {calcularAreaCuadrado(ladoCuadrado)}");
            break;
        case 3:
            Console.WriteLine("Ingrese la base del triángulo:");
            double baseTriangulo = double.TryParse(Console.ReadLine(), out double base1) ? base1 : 0;
            Console.WriteLine("Ingrese la altura del triángulo:");
            double alturaTriangulo = double.TryParse(Console.ReadLine(), out double altura1) ? altura1 : 0;
            Console.WriteLine($"El área del triángulo es: {calcularAreaTriangulo(baseTriangulo, alturaTriangulo)}");
            break;
        case 4:
            Console.WriteLine("\n¡Hasta luego!");
            break;
        default:
            Console.WriteLine("\nOpción inválida. Inténtalo de nuevo.");
            break;
    }
} while (opcion != 4);