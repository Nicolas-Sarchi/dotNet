using System;
using System.Collections.Generic;

public class Usuario
{
    public string Nombre { get; set; }
    public string[] Hobbies { get; set; }
    public int Edad {get; set;}
    public Usuario(string nombre, int edad, string[]  hobbies)
    {
        Nombre = nombre;
        Edad = edad;
        Hobbies = hobbies;
    }
}