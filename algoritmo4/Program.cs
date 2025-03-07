
using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Digite o número de elementos (N): ");
        int N = int.Parse(Console.ReadLine());

       
        double[] numeros = new double[N];

       
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = double.Parse(Console.ReadLine());
        }

        
        double soma = 0;
        for (int i = 0; i < N; i++)
        {
            soma += numeros[i];
        }
        double media = soma / N;

        
        Console.WriteLine($"\nMédia aritmética: {media}");

        
        Console.WriteLine("\nElementos abaixo da média:");
        bool encontrou = false;
        for (int i = 0; i < N; i++)
        {
            if (numeros[i] < media)
            {
                Console.WriteLine(numeros[i]);
                encontrou = true;
            }
        }

        if (!encontrou)
        {
            Console.WriteLine("Não há elementos abaixo da média.");
        }
    }
}
