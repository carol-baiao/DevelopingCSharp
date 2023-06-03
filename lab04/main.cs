// Pedra, papel e tesoura é um clássico, portanto imagino que você já deva ter jogado em algum momento. Mas não custa nada relembrar, a regra é simples: pedra ganha da tesoura, tesoura ganha do papel e papel ganha da pedra. Nesta atividade você deve criar um programa que jogue Pedra, Papel e Tesoura com o usuário. O jogador só pode digitar 0 (pedra), 1 (papel) ou 2 (tesoura). Imprima a mensagem “Opção inválida” se não for nenhuma dessas opções. Após receber um valor válido do usuário você deve gerar aleatoriamente uma opção para o computador e em seguida imprimir quem foi o vencedor da partida, ou se houve empate.
// Aluna: Carolina Alves Baião Pessoa 

using System;

class Program
{
    public static void Main(string[] args)
    {
        // declaração
        int maoCPU, maoUsuario;
        Random aleatorio = new Random();
        maoCPU = aleatorio.Next(3);
        // entrada de dados
        Console.WriteLine("====> PEDRA, PAPEL, TESOURA <====");
        Console.WriteLine("1 - Pedra");
        Console.WriteLine("2 - Papel");
        Console.WriteLine("3 - Tesoura");
        Console.WriteLine("Digite o número de sua escolha: ");
        maoUsuario = int.Parse(Console.ReadLine());
        String CPU = maoCPU == 0 ? "pedra"
        : maoCPU == 1 ? "papel"
        : "tesoura";

        String Usuario = maoUsuario == 1 ? "pedra"
      : maoUsuario == 2 ? "papel"
      : "tesoura";

        Console.WriteLine("Usuario = {0} - CPU = {1}", Usuario, CPU);
        // processamento
        switch (maoUsuario) {
          case 1:
           switch (maoCPU){
                    case 0:
                        Console.WriteLine("EMPATOU. :(");
                        break;
                    case 1:
                        Console.WriteLine("VOCÊ PERDEU. :( ");
                        break;
                    case 2:
                        Console.WriteLine("PARABÉNS, VOCÊ GANHOU! :)");
                        break;
                }
                break;
            case 2:
                switch (maoCPU)
                {
                    case 0:
                        Console.WriteLine("PARABÉNS, VOCÊ GANHOU!. :)");
                        break;
                    case 1:
                        Console.WriteLine("EMPATOU. :(");
                        break;
                    case 2:
                        Console.WriteLine("VOCÊ PERDEU. :(");
                        break;
                }
                break;
            case 3:
                switch (maoCPU)
                {
                    case 0:
                        Console.WriteLine("VOCÊ PERDEU. :(");
                        break;
                    case 1:
                        Console.WriteLine("PARABÉNS, VOCÊ GANHOU!. :)");
                        break;
                    case 2:
                        Console.WriteLine("EMPATOU. :(");
                        break;
                }
                break;
            default:
                Console.WriteLine("OPERAÇÃO INVÁLIDA.");
                break;
        }
    }
}