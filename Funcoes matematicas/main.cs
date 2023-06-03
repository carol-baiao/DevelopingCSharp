// Carolina Alves Baião Pessoa 

using System;

class Program
{
    // função menu
    static int Menu()
    {
        string entrada;
        int op = 0;
        do
        {
            Console.WriteLine("Selecione a opção desejada: ");
            Console.WriteLine("1 - Calcula Media entre dois números.");
            Console.WriteLine("2 - Calcula Fatorial de um número.");
            Console.WriteLine("3 - Calcula o Exponencial.");
            Console.WriteLine("4 - Calcula o Seno.");
            Console.WriteLine("5 - Calcula o Coseno.");
            Console.WriteLine("6 - Calcula a Raiz quadrada.");
            Console.WriteLine("7 - Calcula o logaritmo.");
            Console.WriteLine("x - Sair.");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out op);
        } while (entrada[0] != 'x' && (op < 1 || op > 7));
        return op;
    }

    // calculando media (número 1)
    static double media(int n1, int n2)
    {
        int s = n1 + n2;
        double media = s / 2.0;
        return media;
    }

    // calculando fatorial (número 2)
    static int fatorial(int n)
    {
        int fat = 1;
        for (int i = 2; i <= n; i++)
            fat *= i;
        return fat;
    }

    // calculando exponencial (número 3)
    static double exponencial(double n1, double n2)
    {
        double resposta = Math.Pow(n1, n2);
        return resposta;
    }

    // calculando seno 
    static double seno(double n1)
    {
        double resposta = Math.Sin(n1);
        return resposta;
    }

    // calculando cosseno
    static double cosseno(double n1)
    {
        double resposta = Math.Cos(n1);
        return resposta;
    }

    // calculando raiz quadrada
    static double raizQuadrada(double n1)
    {
        double resposta = Math.Sqrt(n1);
        return resposta;
    }

    public static double logaritmo(double s)
    {
        double resposta = Math.Log(Math.E, s);
        return resposta;
    }

    public static void Main(string[] args)
    {
        string entrada;
        int opcao = 0, numA = 0, numB = 0;
        double total = 0;

        do
        {
            opcao = Menu();
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite 2 nº, separando-os por vírgula: ");
                    entrada = Console.ReadLine();
                    string[] nums = entrada.Split(",");
                    numA = int.Parse(nums[0]);
                    numB = int.Parse(nums[1]);
                    total = media(numA, numB);
                    Console.WriteLine($"A média dos números é: {total}");
                    break;

                case 2:
                    Console.Write("Digite o número: ");
                    numA = int.Parse(Console.ReadLine());
                    total = fatorial(numA);
                    Console.WriteLine($"O fatorial do número é: {total}");
                    break;

                case 3:
                    Console.Write("Digite a base: ");
                    numA = int.Parse(Console.ReadLine());
                    Console.Write("Digite o expoente: ");
                    numB = int.Parse(Console.ReadLine());
                    total = exponencial(numA, numB);
                    Console.WriteLine($"O exponencial do número é: {total}");
                    break;
                case 4:
                    Console.Write("Digite o número: ");
                    numA = int.Parse(Console.ReadLine());
                    total = seno(numA);
                    Console.WriteLine($"O seno do número é {total}.");
                    break;

                case 5:
                    Console.Write("Digite o número: ");
                    numA = int.Parse(Console.ReadLine());
                    total = cosseno(numA);
                    Console.WriteLine($"O cosseno do número é {total}.");
                    break;

                case 6:
                    Console.Write("Digite o número: ");
                    numA = int.Parse(Console.ReadLine());
                    total = raizQuadrada(numA);
                    Console.WriteLine($"A raiz quadrada do número é {total}.");
                    break;

                case 7:
                    Console.Write("Digite o número: ");
                    numA = int.Parse(Console.ReadLine());
                    total = logaritmo(numA);
                    Console.WriteLine($"O logaritmo do número é {total}.");
                    break;
            }
        } while (opcao != 0);
    }
}
