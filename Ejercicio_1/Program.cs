Console.Write("\n\nIngresa el límite de la suma: ");
int limite = Convert.ToInt32(Console.ReadLine());
int suma = 0;
int numero;
Console.WriteLine("Ingresa números para sumar (ingresa 0 para terminar):");
           
do{
    numero = Convert.ToInt32(Console.ReadLine());
    suma += numero;
}
while (numero != 0 && suma < limite);

Console.WriteLine($"La suma total es: {suma}\n");