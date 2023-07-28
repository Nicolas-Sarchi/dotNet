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
                case 6:
                    ActualizarClientesProducto();
                    break;
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
        System.Threading.Thread.Sleep(700);
        Console.Clear();


        Console.WriteLine("\n***********************Productos*************************");
        Console.WriteLine("1. Agregar Producto");
        Console.WriteLine("2. Mostrar Datos de un Producto");
        Console.WriteLine("3. Mostrar Productos");
        Console.WriteLine("4. Actualizar el precio de un Producto");
        Console.WriteLine("5. Actualizar el Inventario de un Producto");
        Console.WriteLine("6. Actualizar los Clientes de un Producto");
        Console.WriteLine("0. Salir");
    }

    static int PedirOpcion()
    {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void AgregarProducto()
    {
        Console.Clear();
        Console.WriteLine("\n*********************** Agregar un Producto *************************");

        Console.Write("\nIngrese el còdigo del Producto: ");
        double idProducto = double.TryParse(Console.ReadLine(), out double idProducto1) ? idProducto1 : 0;

        if (Productos.ContainsKey(idProducto))
        {
            Console.WriteLine("Ya existe un producto con ese código\n\nPresione una tecla para volver al menú");
            Console.ReadKey();
        }

        else
        {
            Console.Write("Ingrese el Nombre del Producto: ");
            string nombreProducto = Console.ReadLine() ?? " ";
            Console.Write("Ingrese el precio del Producto ");
            double precioProducto = double.TryParse(Console.ReadLine(), out double precioProducto1) ? precioProducto1 : 0;
            Console.Write("Ingrese la cantidad en inventario del Producto: ");
            int inventarioProducto = int.TryParse(Console.ReadLine(), out int inventarioProducto1) ? inventarioProducto1 : 0;
            Console.Write("Ingrese los Clientes del Producto separados por un guion (-): ");
            string clientesStr = Console.ReadLine() ?? "";

            List<string> Clientes = clientesStr.Split("-").ToList();

            Producto Producto = new Producto(nombreProducto, precioProducto, inventarioProducto, Clientes);

            Productos.Add(idProducto, Producto);

            Console.WriteLine("\nProducto agregado exitosamente.");
        }


    }

    static void MostrarProductoPorId()
    {
        Console.Clear();
        Console.WriteLine("\n*********************** Buscar datos de un producto *************************");

        Console.Write("\nIngrese el codigodel Producto: ");
        double idProducto = double.TryParse(Console.ReadLine(), out double idProducto1) ? idProducto1 : 0;

        if (Productos.ContainsKey(idProducto))
        {
            Productos[idProducto].MostrarDetalles();
            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();


        }

        else
        {
            Console.WriteLine("\nProducto no encontrado.");
        }
    }
    static void MostrarTodosLosProductos()
    {
        Console.Clear();
        Console.WriteLine("\n*********************** Productos Disponibles *************************");

        Console.WriteLine("\nId\t\tNombre\t\tPrecio\t\tInventario\t\tClientes");

        foreach (var Producto in Productos)
        {
            string clientes = string.Join(",", Producto.Value.Clientes);

            Console.WriteLine($"\n{Producto.Key}\t\t{Producto.Value.Nombre}\t\t${Producto.Value.Precio}\t\t{Producto.Value.Inventario}\t\t\t{clientes}");
        }
        Console.WriteLine("\n\nPresione cualquier tecla para volver al menú.");
        Console.ReadKey();
    }

    static void ActualizarPrecioProducto()
    {
        Console.Clear();
        Console.WriteLine("\n*********************** Actualizar el precio de un producto *************************");

        Console.Write("\nIngrese el còdigo del Producto que quiere editar: ");
        double idProducto = double.TryParse(Console.ReadLine(), out double idProducto1) ? idProducto1 : 0;

        if (Productos.ContainsKey(idProducto))
        {
            Console.Write("Ingrese El Nuevo precio del producto: ");
            double nuevoPrecio = double.TryParse(Console.ReadLine(), out double nuevoPrecio1) ? nuevoPrecio1 : 0;
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
        Console.Clear();
        Console.WriteLine("\n*********************** Actualizar el Inventario de un producto *************************");

        Console.Write("\nIngrese el còdigo del Producto que quiere editar: ");
        double idProducto = double.TryParse(Console.ReadLine(), out double idProducto1) ? idProducto1 : 0;

        if (Productos.ContainsKey(idProducto))
        {
            Console.Write("Ingrese la nueva cantidad en inventario del producto: ");
            int nuevoInventario = int.TryParse(Console.ReadLine(), out int nuevoInventario1) ? nuevoInventario1 : 0;
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
        Console.Clear();
        Console.WriteLine("\n*********************** Gestionar los Clientes de un producto *************************");

        Console.Write("\nIngrese el còdigo del Producto que quiere editar: ");
        double idProducto = double.TryParse(Console.ReadLine(), out double idProducto1) ? idProducto1 : 0;

        if (Productos.ContainsKey(idProducto))
        {

            Console.WriteLine("\nQuè desea Hacer");
            Console.WriteLine("1. Agregar un Nuevo Cliente");
            Console.WriteLine("2. Eliminar un Cliente");
            Console.WriteLine("3. Actualizar datos de un Cliente");
            Console.WriteLine("0. Salir");

            Console.Write("\nElige una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Productos[idProducto].MostrarClientes();
                    Console.Write("Ingrese el nombre del nuevo cliente: ");
                    string nuevoCliente = Console.ReadLine() ?? " ";
                    Productos[idProducto].AgregarNuevoCliente(nuevoCliente);
                    break;
                case 2:
                    Productos[idProducto].MostrarClientes();
                    Console.Write("Ingrese el Id del cliente que quiere eliminar: ");
                    int id = int.TryParse(Console.ReadLine(), out id) ? id : 0;
                    Productos[idProducto].EliminarCliente(id-1);
                    break;
                case 3:
                    Productos[idProducto].MostrarClientes();
                    break;
                case 0:
                    Console.WriteLine("Hasta luego.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }


        }
        else
        {
            Console.WriteLine("\nProducto no encontrado.");
        }
    }
}

