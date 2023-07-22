Console.Write("Ingrese una serie de números enteros separados por espacios: ");
string input = Console.ReadLine();

string[] numerosComoTexto = input.Split(' ');

int[] numeros = new int[numerosComoTexto.Length];

for (int i = 0; i < numerosComoTexto.Length; i++)
{
    numeros[i] = int.Parse(numerosComoTexto[i]);
}

int n = numeros.Length;
int contador = 0;

for (int i = 0; i < n; i++)
{
    bool esDuplicado = false;

    for (int j = i + 1; j < n; j++)
    {
        if (numeros[i] == numeros[j])
        {
            esDuplicado = true;
            break;
        }
    }

    if (!esDuplicado)
    {
        numeros[contador] = numeros[i];
        contador++;
    }
}

int[] numerosSinDuplicados = new int[contador];
Array.Copy(numeros, numerosSinDuplicados, contador);

Console.WriteLine("Números sin duplicados:");

for (int i = 0; i < numerosSinDuplicados.Length; i++)
{
    Console.Write(numerosSinDuplicados[i] + " ");
}

Console.WriteLine();

