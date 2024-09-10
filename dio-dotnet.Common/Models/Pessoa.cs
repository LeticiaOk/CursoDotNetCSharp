using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_dotnet.Common.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } // propriedade Nome do tipo string
        public int Idade { get; set; } // propriedade Idade do tipo int


        // Método Apresentar() (ação da classe Pessoa)
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
       
        }
    }
}


