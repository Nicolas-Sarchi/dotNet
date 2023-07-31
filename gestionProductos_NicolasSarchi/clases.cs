using System;
using System.Collections.Generic;

public class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Inventario { get; set; }
    public List<string> Clientes { get; set; }

    public Producto(string nombre, double precio, int inventario, List<string> clientes)
    {
        Nombre = nombre;
        Precio = precio;
        Inventario = inventario;
        Clientes = clientes;
    }

    public void MostrarDetalles()
    {

        Console.WriteLine($"Nombre: {Nombre}\tPrecio: ${Precio}\tCant. Inventario: {Inventario}\n\nClientes:");

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

    public void AgregarNuevoCliente(string nuevoCliente)
    {
        Clientes.Add(nuevoCliente);
    }

    public void EliminarCliente(int indiceCliente)
    {
        Clientes.RemoveAt(indiceCliente);
    }
    public void ActualizarCliente(int indiceCliente, string nuevoCliente)
    {
        Clientes[indiceCliente] = nuevoCliente;
    }

    public void MostrarClientes()
    {
        for (int i = 0; i < Clientes.Count(); i++)
        {
            Console.WriteLine($"{i + 1}) {Clientes[i]}");
        }
    }               
}



