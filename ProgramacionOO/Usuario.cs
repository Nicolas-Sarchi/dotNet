

public class Usuario
{
    public string? nombre {get;set;}
    public string? documento {get;set;}

    public Usuario(string _nombre, string _documento)
    {
        this.documento = _documento;
        this.nombre = _nombre;
    }

}
