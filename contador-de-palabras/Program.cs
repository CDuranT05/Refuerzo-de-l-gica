// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escribe el parrafo de tu preferencia ");
string parrafo= Console.ReadLine();

string[] cadena = parrafo.Split(" ");
int frecuencia = 0;
Dictionary<string, int> almacenamientoDeCadena = new Dictionary<string, int>() {};


foreach (var item in cadena)
{
    if (almacenamientoDeCadena.ContainsKey(item))
    {
        almacenamientoDeCadena[item]++;
        frecuencia++;
    }
    else{
        almacenamientoDeCadena[item] = 1;
    }
}

foreach (var i in almacenamientoDeCadena)
{
    Console.WriteLine($"la palabra: {i.Key}, y su frecuencia es:  {i.Value}");
}

