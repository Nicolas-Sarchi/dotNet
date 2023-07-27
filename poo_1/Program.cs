public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Direccion { get; set; }

    public Persona(string nombre, int edad, string direccion)
    {
        Nombre = nombre;
        Edad = edad;
        Direccion = direccion;
    }

    public void MostrarNombre(){
        Console.WriteLine(Nombre);
    }

    public void MostrarEdad(){
        Console.WriteLine(Edad);
    }

    public void doxear (){
        Console.WriteLine($"Cuidese loko {Nombre}, {Direccion}");
    }
}

public class Reactangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Reactangulo(double basex, double altura){
        Base = basex;
        Altura = altura;
    }

    public double CalcularArea(){
        return Base * Altura;
    }

    public double CalcularPerimetro(){
        return 2 * Base + 2 * Altura;
    }
}

class Program
{
    static void Main() {
        Persona persona = new Persona("Nicolas", 25, "Calle 2 #14-10");

        persona.MostrarNombre();
        persona.MostrarEdad();
        persona.doxear();


        Console.WriteLine("\n\n");

        Reactangulo rectangulo = new Reactangulo(10, 20);

        Console.WriteLine(rectangulo.CalcularArea());
        Console.WriteLine(rectangulo.CalcularPerimetro());
    }
}

