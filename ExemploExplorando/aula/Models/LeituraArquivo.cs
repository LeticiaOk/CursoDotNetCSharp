using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        // Estamos dizendo que o método retorna uma tupla com três tipos de valores diferentes.
        {
            try // Tenta executar o código
            {   
                // Recebe o valor do parâmetro 'caminho' que é passado chamar o método e lê o arquivo.
                string[] linhas = File.ReadAllLines(caminho);

                // Caso o arquivo seja lido retorna os valores correspondentes.
                return (true, linhas, linhas.Count());
            }
            catch (Exception) // Exceção
            {
                // Caso o arquivo não seja lido retorna os valores zerados
                return (false, new string[0], 0);
            }

        }
    }
}