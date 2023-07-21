// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un número entero positivo:");
int  numero = int.TryParse(Console.ReadLine(), out int numero1) ? numero1 : 0;

long factorial = CalcularFactorial(numero);

Console.WriteLine($"El factorial de {numero} es: {factorial}");


static long CalcularFactorial(int n)
{
    if (n == 0)
        return 1;
    else
    {
        long factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}


