using System;
using System.Collections.Generic;
class Program
{
    public static Dictionary<double, Producto> Productos = new Dictionary<double, Producto>();

    static void Main()
    {
        Console.Clear();
        int opcion;

        do
        {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion)
            {
                case 1:
                    AgregarProducto();
                    break;
                case 2:
                    MostrarProductoPorId();
                    break;
                case 3:
                    MostrarTodosLosProductos();
                    break;
                case 4:
                    ActualizarPrecioProducto();
                    break;
                case 5:
                    ActualizarInventarioProducto();
                    break;
                // case 6:
                //     ActualizarClientesProducto();
                //     break;
                case 0:
                    Console.WriteLine("Hasta luego.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 0);
    }
    static void MostrarMenu()
    {
        Console.WriteLine("\n***********************Clientes*************************");
        Console.WriteLine("1. Agregar Producto");
        Console.WriteLine("2. Mostrar Datos de un Producto");
        Console.WriteLine("3. Mostrar Productos");
        Console.WriteLine("4. Actualizar el precio de un Producto");
        Console.WriteLine("5. Actualizar el precio de un Producto");
        Console.WriteLine("6. Actualizar el precio de un Producto");
        Console.WriteLine("0. Salir");
    }

    static int PedirOpcion()
    {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void AgregarProducto()
    {
        Console.Write("Ingrese el còdigo del Producto ");
        double idProducto = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el Nombre del Producto: ");
        string? nombreProducto = Console.ReadLine();
        Console.Write("Ingrese el precio del Producto ");
        double precioProducto = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la cantidad en inventario del Producto: ");
        int inventarioProducto = int.Parse(Console.ReadLine());
        Console.Write("Ingrese los Clientes del Producto separados por un guion (-): ");
        string? clientesStr = Console.ReadLine();

        string[] Clientes = clientesStr.Split("-");

        Producto Producto = new Producto(nombreProducto, precioProducto, inventarioProducto, Clientes);

        Productos.Add(idProducto, Producto);


    }

    static void MostrarProductoPorId()
    {
        Console.Write("\nIngrese el numero de documento del Producto: ");
        double idProducto = double.Parse(Console.ReadLine());

        if (Productos.ContainsKey(idProducto))
        {
            Productos[idProducto].MostrarDetalles();
        }

        else
        {
            Console.WriteLine("\nProducto no encontrado.");
        }
    }
    static void MostrarTodosLosProductos()
    {
        Console.WriteLine("\nNombre\t\tPrecio\t\tInventario\t\t\tClientes");

        foreach (var Producto in Productos)
        {
            string clientes = string.Join(",", Producto.Value.Clientes);

            Console.WriteLine($"\n{Producto.Value.Nombre}\t\t{Producto.Value.Precio}\t\t{Producto.Value.Inventario}\t\t\t{clientes}");
        }
    }

    static void ActualizarPrecioProducto()
    {
        Console.Write("\nIngrese el còdigo del Producto que quiere editar: ");
        double idProducto = double.Parse(Console.ReadLine());

        if (Productos.ContainsKey(idProducto))
        {
            Console.Write("Ingrese El Nuevo precio del producto: ");
            double nuevoPrecio = double.Parse(Console.ReadLine());
            Productos[idProducto].ActualizarPrecio(nuevoPrecio);
            Console.WriteLine("\nEl precio del producto se actualizò correctamente");

        }
        else
        {
            Console.WriteLine("\nProducto no encontrado.");
        }
    }
    static void ActualizarInventarioProducto()
    {
        Console.Write("\nIngrese el còdigo del Producto que quiere editar: ");
        double idProducto = double.Parse(Console.ReadLine());

        if (Productos.ContainsKey(idProducto))
        {
            Console.Write("Ingrese la nueva cantidad en inventario del producto: ");
            int nuevoInventario = int.Parse(Console.ReadLine());
            Productos[idProducto].ActualizarInventario(nuevoInventario);
            Console.WriteLine("\nEl Inventario del producto se actualizò correctamente");

        }
        else
        {
            Console.WriteLine("\nProducto no encontrado.");
        }
    }

    static void ActualizarClientesProducto()
    {
        Console.Write("\nIngrese el còdigo del Producto que quiere editar: ");
        double idProducto = double.Parse(Console.ReadLine());

        if (Productos.ContainsKey(idProducto))
        {
            Console.Write("Ingrese los nuevos clientes del producto separados por guiòn (-) ");
            string? clientes = Console.ReadLine();
            string[] nuevosClientes = clientes.Split("-");
            Productos[idProducto].ActualizarClientes(nuevosClientes);
            Console.WriteLine("\nLos Clientes del producto se actualizaron correctamente");

        }
        else
        {
            Console.WriteLine("\nProducto no encontrado.");
        }
    }
}

