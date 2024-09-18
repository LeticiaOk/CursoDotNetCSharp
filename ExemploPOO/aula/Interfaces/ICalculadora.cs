using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        // Criando métodos da interface (as implementações são opcionais).
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Divirdir(int num1, int num2)
        {   // Retornando valor
            return num1 / num2;
        }
    }
}