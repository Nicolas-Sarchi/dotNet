public class Federacion
{
    int id { get; set; }
    string nombre { get; set; }
    int edad { get; set; }
    string ciudadOrigen { get; set; }

    public Federacion(int id, string nombre, int edad, string ciudadOrigen){
        this.id = id;
        this.nombre = nombre;
        this.edad = edad;
        this.ciudadOrigen = ciudadOrigen;
    }
}
