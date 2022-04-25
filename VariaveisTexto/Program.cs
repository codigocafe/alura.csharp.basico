using System;

class Texto
{
  static void Main(string[] args)
  {
    char caracteres;
    caracteres = 's';

    string texto = "O char serve somente para textos pequenos";

    string textoQuebraLinha = @"
    - PHP
    - WordPress
    - JavaScript
    - HTML
    - CSS
    - C#
    ";

    Console.WriteLine(caracteres);
    Console.WriteLine(texto);
    Console.WriteLine(textoQuebraLinha);
  }
}