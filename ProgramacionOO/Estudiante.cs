
public class Estudiante : Usuario
{
    private string? codigoEstudiante;

    public Estudiante(string nombre, string documento) : base (nombre, documento)
    {
        this.codigoEstudiante = Guid.NewGuid().ToString();
        this.Nombre = nombre;
        this.Documento = documento;   
    }

}
