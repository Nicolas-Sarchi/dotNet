public class Federacion
{
    int Id { get; set; }
    string Nombre { get; set; }
    List<Equipo> Equipos {get; set;}


    public Federacion(int id,string patrocinador, string nombre ){
        this.Id = id;
        this.Nombre = nombre;
        this.Equipos = new List<Equipo>();
    }

    public Federacion (){}

    public Liga agregarLiga (List<Federacion> Ligas)
    {
        Console.WriteLine("Agregar Liga");
        Console.Write("Ingrese el Id de la Liga: ");
        int idLiga = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el Nombre de la Liga: ");
        string nombreLiga = Console.ReadLine();

        
    
    }


}
