using System;

class Condicoes
{
  static void Main(string[] args)
  {

    int idadeJoao = 16;
    int quantidadePessoas = 2;

    bool acompanhamento = quantidadePessoas >= 2;

    if (idadeJoao >= 18 && acompanhamento == true)
    {
      Console.WriteLine("Pode entrar");
    }
    else
    {
      Console.WriteLine("Não pode entrar");
    }

  }
}