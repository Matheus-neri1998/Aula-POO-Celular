using System;
using Aula_POO_Celular.Classes; // Importando da classe definida

namespace Aula_POO_Celular
{
    class Program
    {
        static void Main(string[] args)
        { // Instanciar objeto

          celular cell = new celular();
          Console.ForegroundColor = ConsoleColor.Blue;

          Console.Write("Insira a cor do celular: ");
          cell.cor = Console.ReadLine();

          Console.Write("Insira o modelo do celular: ");
          cell.modelo = Console.ReadLine();

          Console.Write("Insira o tamanho do celular: ");
          cell.tamanho = int.Parse(Console.ReadLine()); 

          Console.Write("O aparelho celular está ligado? (S/N)");
          string resposta = Console.ReadLine();

          if (resposta == "S"){
                cell.ligado = true;
            //   Console.WriteLine("Oi, boa noite cliente! Seu celular está disponível para fazer ligações e enviar mensagens. ");

          } else if (resposta == "N"){
              cell.ligado = false;
            //   Console.WriteLine("Sinto muito! Tente entrar em contato com a sua operadora. ");
          }
          
        
          Console.ResetColor();

          // Mostrar atributos
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine(cell.cor);
          Console.WriteLine(cell.modelo);
          Console.WriteLine(cell.tamanho);
          Console.WriteLine(cell.ligado);
          
          // Declarar métodos
          cell.ligarCelular(cell.ligado);
          cell.desligarCelular(cell.ligado);
          cell.fazerLigacao(cell.ligado);
          cell.enviarMensagem(cell.ligado);

          Console.ResetColor();
        } // fim de Main
    }
}
