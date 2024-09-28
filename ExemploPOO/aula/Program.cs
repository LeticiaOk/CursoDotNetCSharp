using ExemploPOO.Interfaces;
using ExemploPOO.Models;

// O objeto da interface calculadora recebe a classe calculadora que implementa essa interface.
ICalculadora calc = new Calculadora();
System.Console.WriteLine(calc.Multiplicar(3, 9));