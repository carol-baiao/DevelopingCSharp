//Aluna: Carolina Alves Baião Pessoa
// Curso: Sistemas de Informação - PUC Contagem

using System;

class Program
{
    public static void Main(string[] args)
    {
        //declaração de variáveis
        int golsAtl, golsCru, duelo = 0, vitAtl = 0, vitCru = 0, empate = 0, novo = 1;
        while (novo == 1)
        {
            // entrada de dados
            Console.WriteLine("Digite o número de gols marcados pelo Atletico: ");
            golsAtl = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de gols marcados pelo Cruzeiro: ");
            golsCru = int.Parse(Console.ReadLine());

            //processamento e saída
            if (golsAtl > golsCru)
            {
                vitAtl++;
                Console.WriteLine("Time vencedor: Atlético.");
            }
            else if (golsCru > golsAtl)
            {
                vitCru++;
                Console.WriteLine("Time vencedor: Cruzeiro");
            }
            else
            {
                empate++;
                Console.WriteLine("Empate.");
            }
            duelo++;
            Console.WriteLine("NOVO DUELO? 1. SIM // 2. NÃO");
            novo = int.Parse(Console.ReadLine());
        }
        if (novo == 2)
        {
            Console.WriteLine("{0} jogos fizeram parte da estatística.", duelo);
            Console.WriteLine("Vitórias Atlético: {0}", vitAtl);
            Console.WriteLine("Vitórias Cruzeiro: {0}", vitCru);
            Console.WriteLine("Número de empates: {0}", empate);
            if (vitAtl > vitCru)
            {
                Console.WriteLine("O time do Atlético venceu o maior número de duelos.");
            }
            else if (vitCru > vitAtl)
            {
                Console.WriteLine("O time do Cruzeiro venceu o maior número de duelos.");
            }
            else
            {
                Console.WriteLine("Não houve time com mais vitórias.");
            }
        }
    }
}