// Carolina Alves Baião Pessoa

using System;

class Program {
  // calculando a quant. de algarismos
  static int quantAlgarismos(int n){
    int cont=0;
    for(int i=0; i < n; i++){
      cont++;
    }
    return cont;
  }

  // retornando ordem inversa 
  static int inverte(int n1){
    int inv=0;
    while(n1 > 0) {
      inv = (inv * 10) + n1 % 10;
      n1 /= 10;
    }
    return inv;
  }

  // determinando capicua 
  static bool capicua(int n2){
    if (n2 == inverte(n2)) return true;
    else return false;
  }

  // determinando numero primo
  static bool primo(int n3){
    int cont=0;
    for(int i=2; i < n3; i++) {
      if(n3 % i == 0) cont++;
    }
    if(cont == 0) return true;
    else return false;
  }

  // void main
  public static void Main (string[] args) {
  //  determinando de 0 a 5000 os numeros inteiros, que são primos, // capicuas ou ambos
    for(int i=0; i <= 5000; i++){
      if(capicua(i) && primo(i)) {
        Console.WriteLine($"{i} é primo e capicua!");
      } 
      else if(capicua(i)) {
        Console.WriteLine($"{i} é apenas capicua!");
      } 
      else if(primo(i)) {
        Console.WriteLine($"{i} é apenas primo!");
      }
    }
  }
}