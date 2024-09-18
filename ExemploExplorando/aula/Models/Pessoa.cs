using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {   
        public Pessoa() // Construtor que não recebe nada e vai servir como valor padrão para a classe
        {

        }
        public Pessoa(string nome, string sobrenome) // Construtor que recebe dois valores do tipo string
        {
            Nome = nome; // A propriedade nome recebe o valor do parâmetro nome
            Sobrenome = sobrenome; // A propriedade Sobrenome recebe o valor do parâmero sobrenome
        }

        public void Deconstruct(out string nome, out string sobrenome)
        // Usamos o out antes de cada parâmetro
        {
            // inversão do construtor
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome; // Armazena o Nome.
        private int _idade; // Armazena a Idade
        public string Nome
        {
            get => _nome.ToUpper(); // Retorna o valor de _nome em maíusculas de forma simplificada.

            set
            {
                if (value == "") //value é o argumento que está recebendo a propriedade nome.
                {
                    // Criando execessão caso o valor de nome seja vazio.
                    // Encerra o programa.
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value; // Passando o valor para _nome caso a condicional não seja executada.
            }
        } // Propriedade

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // Esta é uma propriedade só de 'get' que vai armazenar os valores de Nome e Sobrenome. Além de tranforma-los em maiúsculas.
        public int Idade 
        { 
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menos que 0");
                }

                _idade = value;
            }
        } // Propriedade

        public void Apresentar() // Método
        {
            System.Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}