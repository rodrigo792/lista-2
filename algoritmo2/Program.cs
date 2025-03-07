
using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Digite o número de elementos: ");
        int N = int.Parse(Console.ReadLine());

       
        int[] numeros = new int[N];

   
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        
        int contadorPares = 0;

        
        Console.WriteLine("\nNúmeros pares:");
        for (int i = 0; i < N; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                Console.WriteLine(numeros[i]);
                contadorPares++;
            }
        }

        
        Console.WriteLine($"\nQuantidade de números pares: {contadorPares}");
    }
}
