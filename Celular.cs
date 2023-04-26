using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace objetos_celular
{
    public class Celular
    {
        //propriedades 
        public string Cor = "";
        public string Modelo = "";
        public float Tamanho;
        public bool Ligado;

        //metodos
        public void Ligar()
        {
            Ligado = true;
            Console.WriteLine($"Ligando.........");
            
        }
        public void Desligar()
        {
            Ligado = false;
            Console.WriteLine($"Desligando.......");
            
        }
        public void Fazerligacao()
        {
            Console.WriteLine(@$"
            ===================================
            | Voce nao tem contatos para liga |
            ===================================
            ");
            
        }
        public void EnviarMensagem()
        {
            Console.WriteLine(@$"
            ======================================
            | Sem contatos para enviar mensagens |
            ======================================
            ");
            
        }
    }
}