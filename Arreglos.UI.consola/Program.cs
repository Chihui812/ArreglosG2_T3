using Arreglos.Logica;
using System.Collections.Specialized;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nArreglos");

        MiArreglo oMiArreglo = new MiArreglo(10);

        oMiArreglo.Llenar(5, 20);


        Console.WriteLine("\nDesordenado");
        Console.WriteLine(oMiArreglo);

        Console.WriteLine("\nordenado ascendente");
        oMiArreglo.Ordenar();
        Console.WriteLine(oMiArreglo);

        Console.WriteLine("\nordenado descendente");
        oMiArreglo.Ordenar(false);
        Console.WriteLine(oMiArreglo);


        Console.ReadKey();
    }
}