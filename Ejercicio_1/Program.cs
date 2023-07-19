// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un número: ");
string num = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Ingrese un número: ");
string num2 = Console.ReadLine() ?? string.Empty;

double suma = double.Parse(num) + double.Parse(num2);
double resta = double.Parse(num) - double.Parse(num2);
double multiplicacion = double.Parse(num) * double.Parse(num2);
double division = double.Parse(num) / double.Parse(num2);

Console.WriteLine($"Suma: {suma}" + " " + $"Resta: {resta}" + " " + $"Multiplicacion: {multiplicacion}" + " " + $"Division: {division}");


