int[] filas = { 1, 2, 3, 4, 5, 6, 7, 8 };
string[] columnas = { "a", "b", "c", "d", "e", "f", "g", "h" };

int[] movimientosX = { 2, 2, -2, -2, 1, -1, 1, -1 };
int[] movimientosY = { 1, -1, 1, -1, 2, 2, -2, -2 };

Console.Write("\nIngrese la fila en la que se encuentra su caballo: ");
int fila = int.TryParse(Console.ReadLine(), out int fila1) ? fila1 : 0;

Console.Write("\nIngrese la columna en la que se encuentra su caballo: ");
string? columna = Console.ReadLine();

int posicionFila = Array.IndexOf(filas, fila);
int posicionColumna = Array.IndexOf(columnas, $"{columna}");

Console.Write(posicionColumna + " " + posicionFila);

Console.WriteLine("\nLas posiciones a las que puede acceder el caballo son:");

for (int i = 0; i < 8; i++)
{
    int nuevaFila = posicionFila + movimientosY[i];
    int nuevaColumna = posicionColumna + movimientosX[i];

    if (nuevaFila >= 0 && nuevaFila < 8 && nuevaColumna >= 0 && nuevaColumna < 8)
    {
        Console.WriteLine($"\nFila: {filas[nuevaFila]}, Columna: {columnas[nuevaColumna]}");
    }
}

