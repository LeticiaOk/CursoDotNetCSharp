using dio_dotnet.Common.Models;

List<string> listaString = new List<string>();
// ou: List<string> listaString = [];

/*
    List: classe
    <string>: tipo
*/

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

// Exibindo o total de intens na lista e sua capacidade
System.Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// Adicionando elementos na lista e aumentando a sua capacidade de 4 para 8 elementos
listaString.Add("SC");

System.Console.WriteLine($"Ites na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// Removendo elementos da lista, os outros elementos passam a ocupar o ligar do que foi removido. A capacidade continua sendo 8.
listaString.Remove("MG");

System.Console.WriteLine($"Ites na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
