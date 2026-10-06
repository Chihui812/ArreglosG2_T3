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
            oMiArreglo.Agregar(10);
            oMiArreglo.Agregar(5);
            oMiArreglo.Agregar(-4);

            Console.WriteLine(oMiArreglo);
            Console.ReadKey();

            oMiArreglo.Insertar(200,1);

            // for (int i = 0; i < oMiArreglo.N; i++)
            // {
            //    oMiArreglo.Agregar(i * 3);
            //   }
        }

        catch (Exception ex)
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