// ALUNA: Carolina Alves Baião Pessoa
// Deseja-se fazer uma pesquisa a respeito do consumo mensal de energia elétrica em uma determinada cidade. Para isso, são fornecidos os seguintes dados:

// preço do kWh consumido;
// número do consumidor;
// quantidade de kWh consumidos durante o mês;
// código do tipo de consumidor (residencial, comercial, industrial).
// Faça um programa que leia as informações de 5.000 usuário e calcule e exiba:
// (a) para cada consumidor, o total a pagar,
// (b) o maior consumo verificado,
// (c) o menor consumo verificado,
// (d) o total do consumo para cada um dos três tipos de consumidores,
// (e) a média geral de consumo;

using System;

class Program
{
    public static void Main(string[] args)
    {
        // declaração de variáveis
        double precokwh, quantkwh, total, media, maior = -1, menor = double.MaxValue, totalresidencial = 0, totalcomercial = 0, totalindustrial = 0;
        int numCons, tipocons, i = 0, tipo = 0;
        //entrada de dados
        Console.Write("Digite o preço do kWh consumido: ");
        precokwh = double.Parse(Console.ReadLine());
        for (i = 0; i < 3; i++)
        {
            Console.WriteLine("1 - RESIDENCIAL; 2 - COMERCIAL; 3 - INDUSTRIAL: ");
            tipocons = int.Parse(Console.ReadLine());
            Console.Write("Digite o número do consumidor: ");
            numCons = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de kWh consumidos durante o mês: ");
            quantkwh = double.Parse(Console.ReadLine());
            // verificando maior e menor valor colocado
            total = precokwh * quantkwh;
            if (maior < total)
            {
                maior = total;
            }
            if (total < menor)
            {
                menor = total;
            }
            // contalizando o tipo do consumidor
            switch (tipocons)
            {
                case 1:
                    totalresidencial += quantkwh;
                    break;
                case 2:
                    totalcomercial += quantkwh;
                    break;
                case 3:
                    totalindustrial += quantkwh;
                    break;
                default:
                    Console.WriteLine("Número inválido.");
                    break;
            }
            // começo da saída de dados
            Console.WriteLine("Total a pagar: R${0}", total);

            // processamento da média
        }
        media = (totalresidencial + totalcomercial + totalindustrial) / 3;
        Console.WriteLine("Media de consumo verificado: {0}", media.ToString("0.00"));
        Console.WriteLine("Maior consumo verificado: {0}", maior.ToString("0.00"));
        Console.WriteLine("Menor consumo verificado: {0}", menor.ToString("0.00"));
        Console.WriteLine("Total consumo residencial: {0}", totalresidencial);
        Console.WriteLine("Total consumo comercial: {0}", totalcomercial);
        Console.WriteLine("Total consumo industrial: {0}", totalindustrial);
    }
}
