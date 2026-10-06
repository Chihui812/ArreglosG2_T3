using Arreglos.Logica;
using System.Collections.Specialized;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nArreglos?\n");

        MiArreglo oMiArreglo = new MiArreglo(5);

        try
        {
            for (int i = 0; i < oMiArreglo.N; i++)
            {
                oMiArreglo.Agregar(i * 3);
            }
        }

        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine(oMiArreglo);

        // Console.WriteLine("\nDesordenado");
        //Console.WriteLine(oMiArreglo);

        //Console.WriteLine("\nordenado ascendente");
        //oMiArreglo.Ordenar();
        //Console.WriteLine(oMiArreglo);

        //Console.WriteLine("\nordenado descendente");
        //oMiArreglo.Ordenar(false);
        //Console.WriteLine(oMiArreglo);


        Console.ReadKey();
    }
}