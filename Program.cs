using dio_dotnet.Models;

string opcao;
bool exibirMenu = true;

while (exibirMenu)
{   Console.Clear();
    System.Console.WriteLine("Digite a sua opção");
    System.Console.WriteLine("1 - Cadastrar cliente");
    System.Console.WriteLine("2 - Buscar cliente");
    System.Console.WriteLine("3 - Buscar Apagar cliente");
    System.Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            System.Console.WriteLine("Cdastro do cliente");
            break;
        case "2":
            System.Console.WriteLine("Buscar de cliente");
            break;
        case "3":
            System.Console.WriteLine("Apagar cliente");
            break;
        case "4":
            System.Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;
        default:
            System.Console.WriteLine("Opção inválida");
            break;
    }
}

System.Console.WriteLine("O programa encerrou");