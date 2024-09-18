using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    // Adicionamos a palavra sealed para selar a classe
    public class Professor : Pessoa
    {
        // Implementando constritor que não solicita nenhum valor.
        public Professor()
        {
            
        }

        // Implementando construtor para nome
        public Professor(string nome) : base(nome)
        // Dessa forma ao receber o parâmetro nome, ele é passado para a classe pai
        {

        }
        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario}");
        }
    }
}