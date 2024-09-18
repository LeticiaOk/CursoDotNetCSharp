using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExemploPOO.Models
{
    public class Pessoa // Classe
    {
        // Criando construtor que não solicita nenhum valor
        public Pessoa()
        {

        }
        public Pessoa(string nome)
        {
            // O nome passa a ser obrigatório pelo construtor, o mesmo tem que se aplicar as classes filhas.
            Nome = nome;
        }  
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Ação
        public virtual void Apresentar()
        // Adicionamos "virtual" para permitir que o método possa ser alterado por uma classe filha.
        {
            System.Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}