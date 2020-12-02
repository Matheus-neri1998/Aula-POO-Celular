using System;
using Aula_POO_Celular.Classes;

namespace Aula_POO_Celular
{
    class Program
    {
        static void Main(string[] args)
        { // Instanciando

          celular cell = new celular();
          Console.ForegroundColor = ConsoleColor.Blue;

          Console.Write("Digite a cor do celular: ");
          cell.cor = Console.ReadLine();

          Console.Write("Digite o modelo do celular: ");
          cell.modelo = Console.ReadLine();

          Console.Write("Insira o tamanho do celular: ");
          cell.tamanho = int.Parse(Console.ReadLine());

          Console.Write("O aparelho celular está ligado? (S/N)");
          string resposta = Console.ReadLine();

          if (resposta == "S"){
              cell.ligado = true;
              Console.WriteLine("Oi, boa noite cliente! Seu celular está disponível para fazer ligações e enviar mensagens. ");

          } else if (resposta == "N"){
              cell.ligado = false;
              Console.WriteLine("Sinto muito! Tente entrar em contato com a sua operadora. ");
          }
          
          Console.ResetColor();

          // Declarar métodos
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine(cell.cor);
          Console.WriteLine(cell.modelo);
          Console.WriteLine(cell.tamanho);
          Console.WriteLine(cell.ligado);

        //   celular.ligar(celular.ligado1);
        Console.ResetColor();
        } // fim de Main
    }
}
