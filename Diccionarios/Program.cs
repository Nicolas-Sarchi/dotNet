// Declaración e inicialización de un diccionario:

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Declarar e inicializar un diccionario con clave de tipo string y valor de tipo int
        Dictionary<string, int> miDiccionario = new Dictionary<string, int>();

        // También puedes inicializar el diccionario con valores iniciales
        Dictionary<string, string> paises = new Dictionary<string, string>
        {
            { "MX", "México" },
            { "US", "Estados Unidos" },
            { "CA", "Canadá" }
        };
        // Agregar elementos al diccionario:

        miDiccionario.Add("uno", 1);
        miDiccionario["dos"] = 2;

        // Acceder y modificar elementos del diccionario:
        int valorUno = miDiccionario["uno"];
        Console.WriteLine("Valor de 'uno': " + valorUno); // Salida: Valor de 'uno': 1


        // Verificar si una clave existe en el diccionario:
        if (miDiccionario.ContainsKey("uno"))
        {
            // La clave "uno" existe en el diccionario
        }

        // Recorrer el diccionario:
        foreach (var clave in miDiccionario.Keys)
        {
            Console.WriteLine("Clave: " + clave + ", Valor: " + miDiccionario[clave]);
        }

        // Eliminar elementos del diccionario:
        miDiccionario.Remove("dos");

    }




}

