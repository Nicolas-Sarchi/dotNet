// Crea un programa que solicite al usuario ingresar una serie de números enteros separados por espacios. Luego, almacena esos números en un array y muestra el número mayor y el número menor entre ellos.

Console.WriteLine("\nIngrese una serie de números separados por espacio, cuando termine presione enter:");

string numeros = Console.ReadLine();

string[] arrayStr = numeros.Split(' ');

int[] arrayNum = new int[arrayStr.Length];

int numMayor = new int();
int numMenor = new int();


for (int i = 0; i < arrayStr.Length; i++)
{
    arrayNum[i] = int.Parse(arrayStr[i]);

    numMenor = arrayNum[0];

    if (arrayNum[i] < numMenor)
    {
        numMenor = arrayNum[i]; 
    } else if (arrayNum[i] > numMayor)
    {
        numMayor = arrayNum[i];
    }
}

Console.WriteLine($"Numero Mayor: {numMayor}, Numero Menor: {numMenor}");