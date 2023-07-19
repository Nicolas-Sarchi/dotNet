// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un Numero: ");
string num = Console.ReadLine() ?? string.Empty;	

if(long.Parse(num) == 0)
{
    Console.WriteLine("El numero es 0");
}
else if (long.Parse(num) % 2 == 0)
{
    Console.WriteLine("Es par");
} 
else
{
    Console.WriteLine("Es impar");
}
