using System;
namespace Aula_POO_Celular.Classes // Contexto na qual a pasta foi criada
{

    public class celular
    {

        // Definir atributos
        public string cor; 
        public string modelo;
        public int tamanho;
        public bool ligado; 
        
        public void ligarCelular (bool ligar) {
            Console.WriteLine ($"{ligar} o seu celular ");
        }    
        public void desligarCelular (bool desligar) {
            Console.WriteLine($"{desligar} o seu aparelho para atualização");
        }
        public void fazerLigacao (bool ligacao) {
            Console.WriteLine($"Seu aparelho está disponivel para fazer {ligacao}");
        }
        public void enviarMensagem (bool enviarmensagem1) {
            Console.WriteLine($"Seja bem vindo! {enviarmensagem1}");
        }
         

        } // fim de celular
        
           

    } // fim da Classe