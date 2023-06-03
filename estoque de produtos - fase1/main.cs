// Carolina Alves Baião Pessoa

using System;

class Program {
  // variaveis globais
  static string[] Estoque = new string[100];
  static int N = 0;

  // cadastro de novo produto (1)
  static void AdicionarProduto(){
      Console.WriteLine("Digite o nome do produto: ");
      Estoque[N] = Console.ReadLine();
      N++;
      Console.WriteLine("Produto cadastrado!");
  }

  // lista de produtos cadastrados (2)
  static void ListarProdutos(){
      Console.WriteLine($"Quantidade de Produtos: {N}");
      for(int i=0; i<N;i++){
         Console.WriteLine($"{i+1} - {Estoque[i]}");
      }
  }

  // editando dados do produto (3)
  static void EditandoDados(){
    Console.WriteLine("Digite o código do produto: ");
    int cod = int.Parse(Console.ReadLine());
    if(cod > N || cod < 1) {
      Console.WriteLine("Código inválido!");
    } else {
      Console.WriteLine($"Produto encontrado: {Estoque[cod-1]} \n Digite o novo produto: ");
      string nome = Console.ReadLine();
      Estoque[cod-1] = nome;
    }
  }

  // pesquisar produtos por nome(4)
  static void PesquisarProdutoNome(){
    Console.WriteLine("Digite o nome do produto que deseja pesquisar: ");
    string nome = Console.ReadLine();
    for(int i=0; i<N; i++){
      if(Estoque[i] == nome){
        Console.WriteLine($"O produto foi encontrado, e está na posição {i+1}");
      } else {
        Console.WriteLine($"Produto não encontrado!");
      }
    }
  }

  // pesquisando produtos por código (5)
  static void PesquisarProdutoCod(){
    Console.WriteLine("Digite o código do produto que deseja pesquisar: ");
    string nome = Console.ReadLine();
    int cod = int.Parse(Console.ReadLine());
      if(cod > N || cod < 1) {
      Console.WriteLine("Código inválido!");
    } else {
      Estoque[cod -1] = nome;
      Console.WriteLine($"Nome do produto: {nome}");
    }
  }

  // apagando produto (6)
  static void ApagarProduto(){
    Console.WriteLine("Digite o código do produto: ");
    int cod = int.Parse(Console.ReadLine());
    if(cod > N || cod < 1){
      Console.WriteLine("Código inválido!");
    } else {
      for(int i=cod-1; i < N-1; i++){
        Estoque[i] = Estoque[i + 1];
      }
      N--;
    }
  }

  // saindo do programa 

  // menu de opções 
  static int Menu(){
    Console.WriteLine(" =====> ESTOQUE DE PRODUTOS <=====");
    Console.WriteLine("1 - Cadastrar um novo Produto");
    Console.WriteLine("2 - Lista de produtos");
    Console.WriteLine("3 - Editar dados de um produto");
    Console.WriteLine("4 - Pesquisar um produto por nome");
    Console.WriteLine("5 - Pesquisar um produto por código");
    Console.WriteLine("6 - Apagar um produto");
    Console.WriteLine("7 - Sair do programa");
    int opcao = int.Parse(Console.ReadLine());
    return opcao;    
  }
  
  public static void Main (string[] args) {
    int op;
    do{
      Console.Clear();
      op = Menu();
      switch(op){
      case 1: AdicionarProduto();
        break;
      case 2: ListarProdutos();
        Console.ReadKey();
        break;
      case 3: EditandoDados();
        break; 
      case 4: PesquisarProdutoNome();
        break;
      case 5: PesquisarProdutoCod();
        break;
      case 6: ApagarProduto();
        break;
      }
    }while(op != 0);
  }
}