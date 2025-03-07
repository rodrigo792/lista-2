
using System;

class Program
{
    static void Main()
    {
        // Solicitar ao usuário o número de pessoas
        Console.Write("Digite o número de pessoas: ");
        int N = int.Parse(Console.ReadLine());

        // Criar arrays para armazenar os nomes e idades
        string[] nomes = new string[N];
        int[] idades = new int[N];

      
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o nome da {i + 1}ª pessoa: ");
            nomes[i] = Console.ReadLine();

            Console.Write($"Digite a idade de {nomes[i]}: ");
            idades[i] = int.Parse(Console.ReadLine());
        }

        
        int maiorIdade = idades[0];
        string pessoaMaisVelha = nomes[0];

        for (int i = 1; i < N; i++)
        {
            if (idades[i] > maiorIdade)
            {
                maiorIdade = idades[i];
                pessoaMaisVelha = nomes[i];
            }
        }

       
        Console.WriteLine($"\nA pessoa mais velha é: {pessoaMaisVelha} com {maiorIdade} anos.");
    }
}
