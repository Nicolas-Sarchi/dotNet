
namespace LigaBetPlay.Classes;

public class Jugador : Persona
{
    int Dorsal {get;set;}
    string Posicion {get;set;}
    int NivelHabilidad {get;set;}
    string PiernaHabil {get;set;}

    public Jugador (string nombre, int edad, int id, int dorsal, string posicion, int nivelHabilidad, string PiernaHabil): base(nombre,edad,id)
    {
        this.Dorsal = dorsal;
        this.Posicion =posicion;
        this.NivelHabilidad = nivelHabilidad;
        this.PiernaHabil = PiernaHabil;
    }
    
}
