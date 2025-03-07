
using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Digite o número de elementos (N): ");
        int N = int.Parse(Console.ReadLine());

        
        int[] numeros = new int[N];

        
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        
        int somaPares = 0;
        int contadorPares = 0;

        for (int i = 0; i < N; i++)
        {
            if (numeros[i] % 2 == 0) 
            {
                somaPares += numeros[i];
                contadorPares++;
            }
        }

       
        if (contadorPares > 0)
        {
            double mediaPares = (double)somaPares / contadorPares;
            Console.WriteLine($"\nMédia dos números pares: {mediaPares}");
        }
        else
        {
            Console.WriteLine("\nNão foram encontrados números pares.");
        }
    }
}
