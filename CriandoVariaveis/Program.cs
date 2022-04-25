using System;

class CriarVariavel
{
  static void Main(string[] args)
  {
    Console.WriteLine("Criando variaveis");

    int idade;

    idade = 10 + 5;
    Console.WriteLine(idade);

    idade = 10 + 5 * 2;
    Console.WriteLine(idade);

    idade = (10 + 5) * 2;
    Console.WriteLine(idade);

    Console.WriteLine("Finalização do programa.");
    Console.ReadLine();
  }
}