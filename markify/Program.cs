

static string Maskify(string cc)
{

    char[] palabra = new char[cc.Length];
    for (int i = 0; i < cc.Length; i++)
    {
        palabra[i] = cc[i];

    }
    
    for (int i = 0; i < palabra.Length -4; i++)
    {
        palabra[i] = char.Parse("#");
        
    }

   return String.Concat(palabra);

}

Console.WriteLine(Maskify("aeio"));