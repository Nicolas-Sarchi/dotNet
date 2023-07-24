// Complete el método/función para que convierta las palabras delimitadas por guiones/guiones bajos en mayúsculas y minúsculas. La primera palabra de la salida debe ir en mayúsculas sólo si la palabra original iba en mayúsculas (lo que se conoce como Mayúsculas Camel Case, también conocido como Pascal case). Las palabras siguientes deben ir siempre en mayúsculas.

// string ToCamelCase(string str)
// {
//     string[] words = str.Split('-','_');

//     if (char.IsUpper(words[0][0]))
//     {
//         for (int i = 1; i < words.Length; i++)
//         {
//            words[i][0] = char.ToUpper(words[i][0]);
//         }
//     }


//     return string.Join("", words);
// }

// Console.WriteLine(ToCamelCase("Hola-mundo_clo"));

string ToCamelCase(string str)
{
    string[] words = str.Split('-', '_');

    for (int i = 0; i < words.Length; i++)
    {
        if (i == 0 && char.IsUpper(words[i][0])== false)
        {
            words[i] = words[i].ToLower();
        }
        else
        {
            words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
        }
    }

    return string.Join("", words);
}

Console.WriteLine(ToCamelCase("The_Stealth_Warrior"));

