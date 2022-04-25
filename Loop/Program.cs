using System;

class ProgramaLoop
{
  static void Main(string[] args)
  {
    Console.WriteLine("Calcula poupança");

    double valorInvestido = 1000;

    // int contadorMes = 1;
    // while (contadorMes <= 12)
    // {
    //   valorInvestido = valorInvestido * 1.0036;
    //   Console.WriteLine("O mês " + contadorMes + " está com o valor de investimento igual a " + valorInvestido);
    //   contadorMes++;
    // }

    for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
    {
      valorInvestido = valorInvestido * 1.0036;
      Console.WriteLine("O mês " + contadorMes + " está com o valor de investimento igual a " + valorInvestido);
    }


    Console.WriteLine("Final de calcula poupança");
  }
}