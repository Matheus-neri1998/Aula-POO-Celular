using System;
namespace Aula_POO_Celular.Classes
{

    public class celular
    {

        // Definir atributos
        public string cor; 
        public string modelo;
        public int tamanho;
        public bool ligado; 
        public void ligar(bool ligado1){
            Console.WriteLine($"O aparelho está {ligado1}? (S/N)");

            if (ligado1 == true){
                Console.WriteLine("O seu celular está ligado e pode ser usado");
                
            } else if (ligado1 == false)
            {
                Console.WriteLine("O seu celular está desligado meu amigo!");

            }
            

        }
        
           

    }
}