// Carolina Alves Baião Pessoa 
// Faça um programa que contenha um menu com as seguintes opções:
// (a) Ler uma string S1 (tamanho máximo 20 caracteres);
// (b) Imprimir o tamanho da string S1;
// (c) Comparar a string S1 com uma nova string S2 fornecida pelo usuário e imprimir o resultado da comparação;
// (d) Concatenar a string S1 com uma nova string S2 e imprimir na tela o resultado da concatenação;
// (e) Imprimir a string S1 de forma reversa;
// (f) Contar quantas vezes um dado caractere aparece na string S1. Esse caractere desse ser informado pelo usuário;
// (g) Substituir a primeira ocorrência do caractere C1 da string S1 pelo caractere C2. Os caracteres C1 e C2 serão lidos pelo usuário;
// (h) Verificar se uma string S2 é substring de S1. A string S2 deve ser informada pelo usuário;
// (i) Retornar uma substring da string S1. Para isso o usuário deve informar a partir de qual posição deve ser criada a substring e qual é o tamanho da substring.

using System;
using System.Linq;

class Program
{

    // função comparação strings (letra C)
    static bool ehIgual(string S1, string S2)
    {
        if (S1 == S2) return true;
        else return false;
    }

    // função substituir C1 por C2 (letra G)
    public static string SubstituirCaractere(string texto, char C1, char C2)
    {
        int index = texto.IndexOf(C1);

        if (index == -1)
        {
            return null;
        }
        else
        {
            return texto.Substring(0, index) + C2 + texto.Substring(index + 1);
        }
    }

    // função substring (letra I)
    static string Substring(string S1, int inicio, int tamanho)
    {
        return S1.Substring(inicio, tamanho);
    }


    public static void Main(string[] args)
    {
        string texto, texto1, S2;
        char caractere, C1, C2;
        int contChar = 0, opcao = 0;

        // letra A
        do
        {
            Console.Write("Digite uma palavra (até 20 caracteres): ");
            texto = Console.ReadLine();
        } while (texto.Length > 20);

        // criando menu
        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("(1) Imprimir o tamanho da string S1");
            Console.WriteLine("(2) Comparar a string S1 com uma nova string S2");
            Console.WriteLine("(3) Concatenar a string S1 com uma nova string S2");
            Console.WriteLine("(4) Imprimir a string S1 de forma reversa");
            Console.WriteLine("(5) Contar quantas vezes um dado caractere aparece na string S1");
            Console.WriteLine("(6) Substituir a primeira ocorrência do caractere C1 da string S1 pelo caractere C2");
            Console.WriteLine("(7) Verificar se uma string S2 é substring de S1");
            Console.WriteLine("(8) Retornar uma substring da string S1");
            Console.WriteLine("(-1) Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {

                // letra B
                case 1:
                    Console.WriteLine($"A palavra possui: {texto.Length} letras.");
                    break;

                // letra C
                case 2:
                    Console.Write("Digite novamente uma palavra (até 20 char): ");
                    texto1 = Console.ReadLine();
                    if (ehIgual(texto, texto1))
                    {
                        Console.Write("As palavras são iguais.");
                    }
                    else
                    {
                        Console.Write("As palavras não são iguais.");
                    }
                    break;

                // letra D
                case 3:
                    Console.Write("Digite novamente uma palavra (até 20 char): ");
                    texto1 = Console.ReadLine();
                    Console.Write("\n" + texto + texto1);
                    break;

                // letra E
                case 4:
                    string textoInvertido = new string(texto.Reverse().ToArray());
                    Console.WriteLine($"\nTexto invertido: {textoInvertido}");
                    break;

                // letra F
                case 5:
                    Console.Write("\nInforme um caractere: ");
                    caractere = Console.ReadLine()[0];
                    for (int i = 0; i < texto.Length; i++)
                    {
                        if (texto[i] == caractere || texto[i] == caractere)
                        {
                            contChar++;
                        }
                    }
                    Console.WriteLine($"Número de vezes que o caractere aparece na palavra: {contChar}");
                    break;

                // letra G
                case 6:
                    Console.Write("Informe o primeiro caractere: ");
                    C1 = Console.ReadLine()[0];
                    Console.Write("Informe o segundo caractere: ");
                    C2 = Console.ReadLine()[0];
                    bool encontrou = false;
                    for (int i = 0; i < texto.Length; i++)
                    {
                        if (texto[i] == C1)
                        {
                            encontrou = true;
                            break;
                        }
                    }
                    if (!encontrou)
                    {
                        Console.WriteLine($"O caractere {C1} não existe em {texto}.");
                    }

                    string novoTexto = SubstituirCaractere(texto, C1, C2);
                    Console.WriteLine($"Texto atualizado: {novoTexto}");
                    break;

                // letra H
                case 7:
                    Console.Write("Digite o texto: ");
                    S2 = Console.ReadLine();
                    if (texto.Contains(S2))
                    {
                        Console.WriteLine($"{S2} é uma substring de {texto}.");
                    }
                    else
                    {
                        Console.WriteLine($"{S2} não é uma substring de {texto}.");
                    }
                    break;

                // letra I 
                case 8:
                    Console.Write("Digite a posição incial da substring: ");
                    int inicio = int.Parse(Console.ReadLine());
                    Console.Write("Digite o tamanho da substring: ");
                    int tamanho = int.Parse(Console.ReadLine());
                    string substring = Substring(texto, inicio, tamanho);
                    Console.WriteLine($"Substring: {substring}");
                    break;

                case -1:
                    Console.WriteLine("Programa encerrado!.");
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }
        }
    }
}