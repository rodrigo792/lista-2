
using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Digite o número de mercadorias: ");
        int N = int.Parse(Console.ReadLine());

       
        int lucroMenorQue10 = 0;
        int lucroEntre10e20 = 0;
        int lucroMaiorQue20 = 0;

        double totalCompra = 0;
        double totalVenda = 0;
        double totalLucro = 0;

       
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"\nMercadoria {i + 1}:");

            Console.Write("Digite o nome da mercadoria: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço de compra: ");
            double precoCompra = double.Parse(Console.ReadLine());

            Console.Write("Digite o preço de venda: ");
            double precoVenda = double.Parse(Console.ReadLine());

            
            double lucro = precoVenda - precoCompra;
            double percentualLucro = (lucro / precoCompra) * 100;

            
            if (percentualLucro < 10)
            {
                lucroMenorQue10++;
            }
            else if (percentualLucro >= 10 && percentualLucro <= 20)
            {
                lucroEntre10e20++;
            }
            else
            {
                lucroMaiorQue20++;
            }

            // Atualizar os totais
            totalCompra += precoCompra;
            totalVenda += precoVenda;
            totalLucro += lucro;
        }

        // Exibir os resultados
        Console.WriteLine("\nResumo do levantamento:");

        Console.WriteLine($"Mercadorias com lucro < 10%: {lucroMenorQue10}");
        Console.WriteLine($"Mercadorias com lucro entre 10% e 20%: {lucroEntre10e20}");
        Console.WriteLine($"Mercadorias com lucro > 20%: {lucroMaiorQue20}");

        Console.WriteLine($"\nValor total de compra: R$ {totalCompra:F2}");
        Console.WriteLine($"Valor total de venda: R$ {totalVenda:F2}");
        Console.WriteLine($"Lucro total: R$ {totalLucro:F2}");
    }
}
