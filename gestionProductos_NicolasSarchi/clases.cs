using System;
using System.Collections.Generic;

public class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Inventario { get; set; }
    public string[] Clientes { get; set; }

    public Producto(string nombre, double precio, int inventario, string[] clientes)
    {
        Nombre = nombre;
        Precio = precio;
        Inventario = inventario;
        Clientes = clientes;
    }

    public void MostrarDetalles()
    {

        Console.WriteLine($"Nombre: {Nombre}\tPrecio: {Precio}\tCant. Inventario: {Inventario}\n\nClientes:");
        
        foreach (var item in Clientes)
        {
            Console.WriteLine($"- {item}");
        }
    }

    public void ActualizarPrecio(double nuevoPrecio)
    {
        Precio = nuevoPrecio;
    }

    public void ActualizarInventario(int nuevoInventario)
    {
        Inventario = nuevoInventario;
    }

    public void ActualizarClientes(string[] nuevosClientes)
    {
        Clientes = nuevosClientes;
    }



}



