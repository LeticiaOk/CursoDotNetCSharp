using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa // Herdando atributos da classe Pessoa.
    {   
        // Criando construtor que não solicita nenhum valor
        public Aluno()
        {

        }
        // Implementando construtor para nome
        public Aluno(string nome) : base(nome)
        // Dessa forma ao receber o parâmetro nome, ele é passado para a classe pai
        {

        }
        public double Nota { get; set; }

        public override void Apresentar()
        // Adicionando método e override para sobrescreve-lo.
        {
            System.Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos e sou uma aluno nota {Nota}");
        }
    }
}