// string ? palabra;
// List<String> Dinosaurios = new List<String> ();

// String [] dinos = {"T-rex","Amargasaurus, Mamenchisaurus"};
// Dinosaurios.AddRange(dinos);

// Console.WriteLine("Ingrese el nombre del dinosaurio que quiere encontrar");
// palabra = Console.ReadLine();

// Console.WriteLine(Dinosaurios.Exists(item => item.Equals(palabra)) ? "SI" : "No");

string ? palabra = null;

List<String> Dinosaurios = new List<String> ();
List<String> Encontrados = new List<String> ();

String [] dinos = {"T-rex","Amargasaurus, Mamenchisaurus"};
Dinosaurios.AddRange(dinos);

Console.WriteLine("Bucar....");
palabra = Console.ReadLine();

Encontrados = Dinosaurios.FindAll(n => n.Contains(palabra ?? string.Empty));
foreach (string n in Encontrados)
{
    Console.WriteLine(n);
}


