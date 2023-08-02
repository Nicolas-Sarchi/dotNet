namespace LigaBetPlay.Classes;

public class Persona
{
    public string Nombre {get; set;}
    public int Edad {get; set;}
    public int Id {get; set;}
    public Persona (string nombre, int edad, int id)
    {
        this.Nombre = nombre;
        this.Edad = edad;
        this.Id = id;
    }

}
