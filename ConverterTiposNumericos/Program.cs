using System;

class ConverterTipoNumerico
{
  static void Main(string[] args)
  {
    Console.WriteLine("Executando conversão de tipos númericos");

    double salario;
    salario = 1200.50;

    //int é uma variável de 32bits
    int salarioInteiro;
    salarioInteiro = (int)salario;

    //long é uma variável de 64bits
    long idadeUniverso;
    idadeUniverso = 13000000000000;

    //short é uma variável de 16bits
    short quantidade;
    quantidade = 150;

    Console.WriteLine(salarioInteiro);

    //precisão pequena
    //precisa colocar o sufixo f no final
    float altura = 1.80f;

    //precisão grande
    double salarioNovo = 2000.00;




    Console.WriteLine("Finalizando conversão de tipos númericos");
  }
}