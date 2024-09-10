<h1>
    <a href="https://www.dio.me/">
     <img align="center" width="40px" src="https://hermes.digitalinnovation.one/assets/diome/logo-minimized.png"></a>
    <span> Curso oeferecido pela DIO XP Inc. - Full Stack Developer</span>
</h1>

> ## 📕 O repositório tem como objetivo armazenar resumos e o conteúdo passado em aula sobre .NET que utliza a linguagem C# .

# ⭐ Introduçaõ ao ambiente .NET e Projetos colaborativos

## 🚀 ``Introdução as IDEs e Configurações de Ambiente .NET:``

### 1️⃣ Configuração do Ambiente e IDEs:

#### 📍Criando nosso projeto:

* Comando para  criar um projeto do tipo "console": ``dotnet new console``.

* Comando para executar o projeto: ``dotnet run``.

# ⭐ Sintaxe Básica com .NET C#

## 🚀 ``Sintaxe e Tipos de Dados em C#:``

### 1️⃣ Sintaxe e Identação:

#### 📍Entendedo a estrutura de um proejeto:

* Compilar e gerar arquivos binários: ``dotnet build``.

* O arquivo.cs representa nossa classe.

* O arquivo.csproj representa a estrutura de um projeto.

* As pastas bin e obj são de arquivos binários e sempre irão aparecer ao darmos o comando ``dotnet build``.

#### 📍 O conceito de classe:

* A classe esta relacionada ao conceito de abstração na programação orientada a objetos.

* Abstração é pegar um objeto do mundo real e atranfoma-lo em um objeto na programção para que possamos trabalhar com ele e implementar as suas ações.

* Um método é a ação que a classe vai fazer. Um método sempre tem parênteses no  final.

* Uma classe primeiramente tem seus atributos e em seguida os seus métodos.

* Uma classe represnta a construção de um objeto.

#### 📍 Criando nossa classe no código:

* Todo nome de classe deve iniciar com letra maiúscula. 
> Exemplo: PessoaFisica.

* Ao iniciar uma propiedade digitamos: ``props`` e clicamos na tecla Tab. Assim a estrutura da propriedade já vai estar pronta.

**Código em C#**:

~~~~c#
namespace dio_dotnet.Models // Ciramos a pasta Models e colocamos a classe dentro dela
{
    public class Pessosa // Classe Pessoa
    {
        public string Nome { get; set; } // propriedade Nome do tipo string
        public int Idade { get; set; } // propriedade Idade do tipo int

        // Método Apresentar() (ação da classe Pessoa)
        public void Apresentar()
        {
            // Imprimindo mensagem no console
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}
~~~~

#### 📍 Entendendo a estrutura do código:


~~~~js
namespace dio_dotnet.Models // Name Space (Pode ser alterado, já que não reflete o caminho físico)
{
    public class Pessosa
    {
        public string Nome { get; set; } 
        // get: pega o valor
        // set: atribui o valor
        public int Idade { get; set; } /

       
        public void Apresentar()
        {
            
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
            // Classe: Console
            // Método ou função: WriteLine
            // Conteúdo: parâmetro
        }
    }
}
~~~~

* Quando queremos uitilizar uma palavra reservada podemos colocar o "@" antes dessa palavra. **Não recomendado!** .

> Exemplo: public void Apresentar(string @class)

#### 📍 Usando namespaces:

* O arquivo Program.cs é o ponto de entrada do programa, ou seja, quando o programa é executado, ele sempre começará lendo por esse arquivo.

Criando uma instância no arquivo Program.cs:
~~~~c#
// É através do namespace que o código vai reconhecer a classe Pessoa.
using dio_dotnet.Models; // namespace

Pessoa p = new Pessoa();
~~~~

* Podemos ter duas classes com o mesmo nome, desde que tenham namespaces diferentes.

#### 📍 Usando a classe pessoa:

~~~~c#
using dio_dotnet.Models;
Pessoa pessoa1 = new Pessoa();

// Pessoa pessoa1: representa que a classe é do tipo Pessoa e vamos chama-la pelo nome pessoa1.

// pessoa1: nome da variável.

// Passando valores
pessoa1.Nome = "Buta";
pessoa1.Idade = 26;

// Chamando método
pessoa1.Apresentar();
~~~~

* Ao rodarmos esse programa no terminal (dotnet run) a resposta será: ``Olá, meu nome é Buta, e tenho 26 anos``.

#### 📍 Explorando a sintaxe

* Dividindo a string:

~~~~c#
...

public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é " +
        $"{Nome}, e tenho {Idade} anos");
    }
~~~~

* Quabrando linha:

~~~~c#
...

public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} \n e tenho {Idade} anos");       
    }
~~~~

* Quebra de linha (Program.cs):

~~~~c#
using dio_dotnet.Models;
Pessoa pessoa1 = new Pessoa();

pessoa1
.Nome = "Buta";

pessoa1
.Idade = 26;

pessoa1.Apresentar();
~~~~

#### 📍 Covenções case:

* Case é um padrão de escrita para nomes.

> No C# usamos camelCase e o PascalCase.

#### 📍 Convenções case no código:

* PascalCase: classes, métodos propriedades.
* camelCase: variáveis.

#### 📍 Convenções de escrita de classe:

* Não é recomendado abreviar variáveis das classes.
* É recomendado que o nome da classe siga o arquivo.cs.

#### 📍 Convenção de nome de variável:

* Não ter caractere especial na variável, na classe ou na propriedade. Com exceção do underline.

## Tipos de dados

#### 📍 Introdução e tipos inteiros:

* Char: um único caractere
* int, long, uint, short, ulong: capacidades diferentes de armazenar números inteiros.

#### 📍 Números com casas decimais:

* Números decimais: double ou float.
* Valores monetários: decimal (já que sempre trabalha com 2 casas decimais).

## 📍 Declarando os tipos de variáveis:

~~~~C#
string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00")); // Tratamendo para imprimir o código com 2 cas decimais. 
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável considcao: " + condicao);
~~~~

#### 📍 O tipo DateTime:

* Imrpimindo data e horário atual:
~~~~C#
DateTime dataAtual =  DateTime.Now;
~~~~

> Console: 07/09/2024 18:00:07

* Adicionando dias:

~~~~C#
DateTime dataAtual =  DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual);
~~~~

> Console: 12/09/2024 18:02:07

* Imprimindo somente a data:

~~~~C#
DateTime dataAtual =  DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
~~~~

> Console: 12/09/2024 

* Imprimindo data com hora e minutos:

~~~~C#
DateTime dataAtual =  DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy MM:mm"));
~~~~

> Console: 12/09/2024 09:06

## 🚀 ``Tipos de operadores em C#:``

### 1️⃣ Operadores de atribuição

#### 📍Convertendo tipos de variáveis

* Aconversão de variáveis pode se chamar de cast ou casting.

~~~~C#
int a = Convert.ToInt32("5");
Console.WriteLine(a);

//Convert: classe
//ToInt32: Método que converte string para inteiro de até 2B (32 bits)
~~~~

* outra maneira de conversão:

~~~~C#
int a = int.Parse("5"); //Converte para inteiro de 32 bits
Console.WriteLine(a);
~~~~

#### 📍Diferença entre Convert e Parse:

* Quando o valor é "null" (nulo), o Convert converte para 0, já no Parse isso daria um erro.

~~~~C#
int a = Convert.ToInt32(null);
Console.WriteLine(a);
~~~~

> Console: 0


#### 📍Conversão para string:

~~~~C#
int inteiro = 5;
string a = inteiro.ToString();
Console.WriteLine(a);
~~~~

#### 📍Cast implícito:

* Cast Implícito faz a conversão de diferente tipos, não sendo necessário que fassamos.

~~~~C#
int a = 5;
double b = a;

Console.WriteLine(b);
~~~~

> Console: 5

* Isso se deve porque um inteiro cabe em um decimal, logo não é necessário realizar a conversão.

* Um int também cabe em um long, mas um long não cabe dentro de um int, porque long pode armazenar até 2T e um int até 2B, então o código daria erro.

#### 📍Convertendo de forma segura

* Podemos usar um TryParse para caso a conversão de erro, ele possa imprimir outro valor sem dar erro no programa. 

~~~~C#
string a = "15-";

// int b = 0;

int.TryParse(a, out int b);

Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso!");
~~~~

> Console: 0

### 2️⃣ Operadores condicionais

#### 📍Operador condicional na prática:

* Estrutura:

~~~~js
using dio_dotnet.Models;

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >=  quantidadeCompra; // A quantidade em estoque é maior que a quantidade de compra?

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if(possivelVenda) // Caso a variável seja true
{
    Console.WriteLine("Venda realizada.");
}
else // Caso a variável seja false
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
}
~~~~

#### 📍IF aninhado:

* Estrutura:

~~~~C#
using dio_dotnet.Models;

int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >=  quantidadeCompra; // A quantidade de compra é maior que 0 e a quantidade em estoque é maior que a quantidade de compra?

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if(quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida.");
}
else if(possivelVenda)
{
    Console.WriteLine("venda realizada");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
}
~~~~

#### 📍Aprendendo o switch case:

* Estrutura do Switch

~~~~C#
Console.WriteLine("Digie uma letra: ");
string letra = Console.ReadLine(); // Espera uma resposta do usuário.

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Volgal");
        break;

    default:
        Console.WriteLine("Não é uma vogal");
        break;
}
~~~~

## 🚀```Operadores Aritméticos em C#:``

### 1️⃣ Operadores aritméticos e a classe Math

#### 📍Criando nossa classe Claculadora:

* Criando classe Calculadora:

~~~~C#

namespace dio_dotnet.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            System.Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            System.Console.WriteLine($"{x} x {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            System.Console.WriteLine($"{x} / {y} = {x / y}");
        }
    }
}
~~~~

* Criando instância:

~~~~C#
using dio_dotnet.Models;

Calculadora calc = new Calculadora(); 

calc.Somar(10, 30); // Passando valores para o método
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2);
~~~~

#### 📍Usando potência:

* Utilizando o Math:

~~~~C#
namespace dio_dotnet.Models
{
    public class Calculadora
    {   ...
        public void Potencia(int x, int y)
        {   
            double pot = Math.Pow(x, y);
            System.Console.WriteLine($"{x} ^ {y} = {pot}");
        }
    }
}
~~~~

* Criando instância:
~~~~C#
using dio_dotnet.Models;

Calculadora calc = new Calculadora();

calc.Potencia(3, 3);
~~~~

#### 📍Funções Trigonométricas:

* Calculando Seno, Coseno e Tangente:

~~~~C#
namespace dio_dotnet.Models
{
    public class Calculadora
    {
         public void Seno(double angulo)
        {       
            double radiano =  angulo * Math.PI / 180; // Calculando radiano primeiro, para calcularmos o Seno
            double seno = Math.Sin(radiano); // Utilizando a classe Math para calcular o Seno e passando o radiano como parâmetro para o méetodo Sin
            System.Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}"); // Utilizando o método Round de Math para mostrar no máximo 4 casas decimais
        }
         public void Coseno(double angulo)
        {       
            double radiano =  angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            System.Console.WriteLine($"Coseno de {angulo} = {Math.Round(coseno, 4)}");
        }
         public void Tangente(double angulo)
        {       
            double radiano =  angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            System.Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 4)}");
        }
    }
}
~~~~

* Criando instância:

~~~~C#
using dio_dotnet.Models;

Calculadora calc = new Calculadora();
calc.Seno(30); // Passando parâmetro
calc.Coseno(30);
calc.Tangente(30);
~~~~

#### 📍Calculando raiz quadrada:

~~~~C#
namespace dio_dotnet.Models
{
    public class Calculadora
    {
         public void RaizQuadrada(double x)
        {       
            double raiz = Math.Sqrt(x);
            System.Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}
~~~~

* Criando instância:

~~~~C#
using dio_dotnet.Models;

Calculadora calc = new Calculadora();

calc.RaizQuadrada(9);
~~~~

## 🚀 ``Conhecendo as estruturas de Repetição em C#:``

### 1️⃣ Estruturas de repetição

#### 📍Introdução ao FOR

* Estrutura:

~~~~C#
int numero = 5;

for(int contador = 0; contador <= 10; contador++)
// int contador = 0: Declaração da variável
// Contador <= 10: Condição de parada
// Contador ++: incremento
{
    System.Console.WriteLine($"{numero} x {contador}  =  {numero * contador}");
}
~~~~

#### 📍 Introdução ao WHILE

* Etrutura:

~~~~C#
using dio_dotnet.Models;

int numero = 5;
int contador = 0;

while(contador <= 10)
{
    System.Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}
~~~~

#### 📍 Introdução ao WHILE

* Etrutura:


~~~~C#
using dio_dotnet.Models;

int soma = 0, numero = 0;

do
{
    System.Console.WriteLine("Digite um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while (numero != 0);

System.Console.WriteLine($"Total da soma dos números digitados é {soma}");
~~~~

#### 📍 Construindo um menu interativo:

~~~~C#
using dio_dotnet.Models;

string opcao;

while (true)
{   Console.Clear(); // Limpa o console a cada loop
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
            Environment.Exit(0); // Encerrar o programa
            break;
        default:
            System.Console.WriteLine("Opção inválida");
            break;
    }
}

System.Console.WriteLine("O programa encerrou"); // Essa linha não será executada já que utilizados o "Environment.Exit(0);".
~~~~

#### 📍 Refatorando o menu:

~~~~C#

endregionusing dio_dotnet.Models;

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
~~~~

## 🚀```Conhecendo a organização de um programada C#:``
### 1️⃣ Estrutura de um programa E método principal
#### 📍 Estrutura deum programa C#:

* csproj: Contém informações referente a um projeto (build, debug, versão), cada projeto deverá ter um arquivo cdproj.

* sln: Contém informações que carregam um agrupamento de projetos (melhora a organização dos projetos), .

* Quando mais de um projeto utiliza a mesma classe, colocamos essa classe em um projeto Common que vai ser a referência para todos os projetos, assim todos os projetos podem consultar essa mesma classe. A sln vai servir para referenciar esses perojetos e como eles se relacionam entre si (fazem parte de uma solution)

#### 📍Criando nosso novo projeto:

* Instalar extensão vscode solution explorer.

* Criar nova soulion (isso vai adicionar um arquivo sln).
* Adicionar um projeto existente na solution, isso vai criar uma ligação no arquivo sln com o projeto.

* Adicionar um novo projeto -> biblioteca de classes -> C# -> dio-dotnet.Common -> Enter (vai conter apenas as classes modelo). Isso também vai criar uma ligação do arquivo sln com o projeto. Dessa forma no arquivo sln teremos a referência do projeto principal e do Common.

* Criar pasta dio-dotnet -> mover arquivos para dentro dela exceto o sln e o Common.

* Se necessário apagar as pastas bin e project e reiniciar o VsCode.

* Mover a pasta models para a pasta Common, já que é nesse projeto que vão ficar as classes.

* Referenciar as classes dentro de Models e o program.cs para: ``namespace dio_dotnet.Common.Models`` e ``using dio_dotnet.Common.Models;``

* Como adicionamos o arquivo.csproj dentro da pasta dio-dotnet teremos que referenciar este arquivo no sln: ``Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "dio-dotnet", "dio-dotnet.csproj", "{472056B7-2755-4C4A-BCCB-00526BE51ADC}" EndProject`` para: ``Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "dio-dotnet", "dio-dotnet\dio-dotnet.csproj", "{472056B7-2755-4C4A-BCCB-00526BE51ADC}" EndProject``.

 * Criar referência nos arquivos.csproj no arquivo principal em solution.

* Dessa maneira podeos utilizar uma classe peeertencente a outro projeto em projetos diferentes

#### 📍Criando um projeto em NET5 e NET6:

> [!WARNING]  
> **Atenção:** Atualmente a versão 5 do .NET não é mais suportada.

* Nas versões a partir da .NET 6 o método main fica escondido.

* Pra criar um projeto com a versão 5 do dotnet, criamos um arquivo.NET5, entramos dentro dele e damos o seguinte comando no terminal: dotnet ``new console --framework net5.0``.

* Criar uma pasta dio-dotnet.NET6, entramos dentro dele e damos o seguinte comando no terminal: dotnet ``new console --framework net6.0``.

#### 📍 Comparano NET5 e NET6:

* Na versão 5 temos uma estrutura diferente no program.

## 🚀```Arrays e Listas em C#``
### 1️⃣ Arrays e Listas
#### 📍 Introdução Array:

**Estrutura:**

Declaração de um array com até 4 valores: ``int[] array = new int[4]``

* ``int[]``: tipo
* ``array``: nomedo array
* ``new int[4]``: declaração

Declaração de um array passando os valores diretamente: ``int[] array = new int[] {42, 75, 74, 61};``

> Nesse caso podemos omitir o tamnho.

Resgatando o valor na posição 0 de um array: ``int elemento = array[0];``

Atribuindo o valor 42 no array na posição 0: ``array[0] = 42``

#### 📍 Implementando um array de inteiros:

~~~~C#
using dio_dotnet.Common.Models;

int[] arrayInteiros = new int[3]; // Declarando array com 3 posições

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
// arrayInteiros[3]= 1;

// Exibindo valores do array
for (int contador = 0; contador < arrayInteiros.Length; contador++)
// Usando Length para capacidade máxima do array
{
    System.Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
    /*
        Exibe:
        Posição Nº 0 - 72
        Posição Nº 1 - 64
        Posição Nº 2 - 50
    */
}
~~~~

#### 📍 Percorrendo um array com FOREACH:

~~~~C#
// Percorrendo Array com FOREACH
int contadorForeach = 0;
foreach(int valor in arrayInteiros)
// Para cada elemento no arrayInteiros joga-se o valor na variável 'valor'.
{
    System.Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
    contadorForeach++;
    /*
        Exibe:
        Posição Nº 0 - 72
        Posição Nº 1 - 64
        Posição Nº 2 - 50
    */
}
~~~~

#### 📍 Redimensionando um array:

~~~~C#
using dio_dotnet.Common.Models;

int[] arrayInteiros = new int[4]; // Declarando array com 4 posições

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3]= 1;

// Aumentando o valor do array com o método Resize
// O Resize cria um novo array com a cópia dos valores do array antigo
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
/*
    ref arrayInteiros: referência do array
    arrayInteiros.Length * 2: Nova capacidade máxima do array 
*/
~~~~

#### 📍 Copiando um array para outro:

~~~~C#
using dio_dotnet.Common.Models;

int[] arrayInteiros = new int[4]; // Declarando array com 3 posições

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3]= 1;

// Declarando array e seu tamanho máximo (8 elementos).
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];

// Copiano array Inteiros para arrayInteirosDobrado com todos os valores (4 elementos).
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.LongLength)
~~~~

#### 📍 trabalhando com listas:

* Não precisamos declarar uma capacidade máxima

~~~~C#
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

// Usando Count para retornar a capacidade máxima da lista
for(int contador = 0; contador < listaString.Count; contador++)
{
    System.Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");

    /*
        Posição Nº 0 - SP
        Posição Nº 1 - BA
        Posição Nº 2 - MG
    */
}

int contadorForeach = 0;
foreach(string item in listaString)
{
    System.Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
    contadorForeach++;
     /*
        Posição Nº 0 - SP
        Posição Nº 1 - BA
        Posição Nº 2 - MG
    */

}
~~~~

* Nas listas ela tem a capacidade de se redimensionar

~~~~C#
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
~~~~

## 🚀```Construindo um Sistema para um Estacionamento com C#``
