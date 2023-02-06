using System;

class Program {
  public static void Main (string[] args) {
    int idade1, idade2, soma;
    string  name = "Vanessa";

    Console.Write($"Calcule a soma das idade de Vitor e {name}. ");
    Console.WriteLine();
    Console.WriteLine("Digite a idade de Vanessa: ");
    idade1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a idade de Vitor: ");
    idade2 = int.Parse(Console.ReadLine());

    soma = idade1+idade2; 

    Console.WriteLine($"A soma das idades de Vitor e {name} é {soma}");
    
    Console.ReadKey();
  }
}