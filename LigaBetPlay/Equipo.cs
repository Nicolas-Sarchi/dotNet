public class Equipo : Federacion
{
    int añoDeFundacion { get; set; }
    string propietario { get; set; }

    public Equipo(int id, string nombre, int edad, string ciudadOrigen, int añoDeFundacion, string propietario) : base(id, nombre, edad, ciudadOrigen){
        this.añoDeFundacion = añoDeFundacion;
        this.propietario = propietario;
    }
}
