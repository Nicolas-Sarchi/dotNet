Console.Write("\nIngrese un número: ");
int numero = int.TryParse(Console.ReadLine(), out int numero1) ? numero1 : 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"\n{numero} x {i} = {numero * i}");
}
