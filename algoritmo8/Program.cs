
using System;

class Program
{
    static void Main()
    {
        // Solicitar o número de pessoas
        Console.Write("Digite o número de pessoas: ");
        int N = int.Parse(Console.ReadLine());

        // Inicializar variáveis
        double maiorAltura = double.MinValue;
        double menorAltura = double.MaxValue;
        double somaMulheres = 0;
        int contadorMulheres = 0;
        int contadorHomens = 0;

        // Ler os dados de altura e sexo
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite a altura da {i + 1}ª pessoa: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write($"Digite o sexo da {i + 1}ª pessoa (M para masculino, F para feminino): ");
            char sexo = char.ToUpper(Console.ReadLine()[0]);

            // Atualizar a maior e menor altura
            if (altura > maiorAltura)
            {
                maiorAltura = altura;
            }

            if (altura < menorAltura)
            {
                menorAltura = altura;
            }

            // Somar a altura das mulheres e contar as mulheres
            if (sexo == 'F')
            {
                somaMulheres += altura;
                contadorMulheres++;
            }

            // Contar o número de homens
            if (sexo == 'M')
            {
                contadorHomens++;
            }
        }

        // Exibir os resultados
        Console.WriteLine($"\nA maior altura do grupo é: {maiorAltura} metros.");
        Console.WriteLine($"A menor altura do grupo é: {menorAltura} metros.");

        if (contadorMulheres > 0)
        {
            double mediaMulheres = somaMulheres / contadorMulheres;
            Console.WriteLine($"A média de altura das mulheres é: {mediaMulheres} metros.");
        }
        else
        {
            Console.WriteLine("Não há mulheres no grupo.");
        }

        Console.WriteLine($"O número de homens no grupo é: {contadorHomens}.");
    }
}
