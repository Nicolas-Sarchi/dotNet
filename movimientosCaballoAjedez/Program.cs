int[] filas = {1,2,3,4,5,6,7,8}; 
string[] columnas = {"a","b","c","d","e","f","g","h"};

int[] movimientosX = {2,2,-2,-2,1,-1,1,-1};
int[] movimientosY = {1,-1,1,-1,2,2,-2,-2};

Console.Write("Ingrese la fila en la que se encuentra su caballo: ");
int fila = int.Parse(Console.ReadLine());

Console.Write("Ingrese la columna en la que se encuentra su caballo: ");
string? columna =Console.ReadLine();

int posicionFila = Array.IndexOf(filas,fila);
int posicionColumna = Array.IndexOf(columnas,$"{columna}");

Console.Write(posicionColumna + " " + posicionFila);

for (int i = 0; i < length; i++)
{
    
}
