using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; } // Propriedade de coleção do tipo Pessoa.

        public void AdicionarAluno(Pessoa aluno)
        // void: o método não está retornando nada.
        // AdicionarAluno: nome do método.
        // (Pessoa aluno): parâmetros ou argumentos. Recebe uma classe Pessoa chamada aluno (aluno poderia ser alterado para qualquer nome).
        {
            Alunos.Add(aluno); // Adiciona na lista o aluno passado como parâmetro.
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        // int: o método retorna um inteiro
        {
            int quantidade = Alunos.Count; // Armazeza a quantidade de elementos dentro da lista Alunos.
            return quantidade; // Retorna o valor da quantidade. Só pode retornar um inteiro já que estamos falando que o método retorna um inteiro.
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno); // Retorna true se o aluno for removido ou false caso não seja removido ou se o aluno não for encontrado na lista

        }


        public void ListarALuos()
        {
            System.Console.WriteLine($"Alunos do curso de {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                // string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
                string texto = $"Nº {count + 1} - {Alunos[count].NomeCompleto}";
                System.Console.WriteLine(texto);
            }

        }
    }
}