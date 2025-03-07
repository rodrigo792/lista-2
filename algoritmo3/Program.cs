
using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Digite o número de elementos (N) para os vetores: ");
        int N = int.Parse(Console.ReadLine());

        // Criar os vetores A, B e C
        int[] A = new int[N];
        int[] B = new int[N];
        int[] C = new int[N];

        // Ler os elementos do vetor A
        Console.WriteLine("Digite os elementos do vetor A:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Elemento A[{i}]: ");
            A[i] = int.Parse(Console.ReadLine());
        }

        // Ler os elementos do vetor B
        Console.WriteLine("Digite os elementos do vetor B:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Elemento B[{i}]: ");
            B[i] = int.Parse(Console.ReadLine());
        }

        // Gerar o vetor C com a soma dos elementos correspondentes de A e B
        for (int i = 0; i < N; i++)
        {
            C[i] = A[i] + B[i];
        }

        // Exibir o vetor C
        Console.WriteLine("\nVetor C (soma dos elementos de A e B):");
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"C[{i}] = {C[i]}");
        }
    }
}
