using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Computador
    {
        // Sobrescrevendo método ToString que vem da classe Object.
        public override string ToString()
        {
            return "Método ToString sobrescrito";
        }
    }
}