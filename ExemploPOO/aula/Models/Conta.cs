using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    // Criando classe abstrata.
    public abstract class Conta
    {
        protected decimal Saldo { get; set; }
        // protected: protegido contra alterações externas com exceção das suas classes filhas.
        
        // Criando método abstrato
        public abstract void Creditar(decimal valor);
        // Quem herdar a classe Conta tem que obrigatóriamente implementar esse método.
        

        public void ExibirSaldo()
        {
            System.Console.WriteLine("O seu saldo é : " + Saldo);
        }
    }
}