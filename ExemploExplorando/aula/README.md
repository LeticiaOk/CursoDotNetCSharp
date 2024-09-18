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

* O arquivo.cs representa uma classe.

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
// Formatação com traço
DateTime dataAtual =  DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd-MM-yyyy MM:mm"));
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

## 🚀``Operadores Aritméticos em C#:``

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

#### 📍 Introdução ao DO WHILE

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

## 🚀``Conhecendo a organização de um programa C#:``
### 1️⃣ Estrutura de um programa E método principal
#### 📍 Estrutura deum programa C#:

* csproj: Contém informações referente a um projeto (build, debug, versão), cada projeto deverá ter um arquivo csproj.

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

* Dessa maneira podeos utilizar uma classe pertencente a outro projeto em projetos diferentes

#### 📍Criando um projeto em NET5 e NET6:

> [!WARNING]  
> **Atenção:** Atualmente a versão 5 do .NET não é mais suportada.

* Nas versões a partir da .NET 6 o método main fica escondido.

* Pra criar um projeto com a versão 5 do dotnet, criamos um arquivo.NET5, entramos dentro dele e damos o seguinte comando no terminal: dotnet ``new console --framework net5.0``.

* Criar uma pasta dio-dotnet.NET6, entramos dentro dele e damos o seguinte comando no terminal: dotnet ``new console --framework net6.0``.

#### 📍 Comparano NET5 e NET6:

* Na versão 5 temos uma estrutura diferente no program.

## 🚀``Arrays e Listas em C#``
### 1️⃣ Arrays e Listas
#### 📍 Introdução Array:

**Estrutura:**

Declaração de um array com até 4 valores: ``int[] array = new int[4]``

* ``int[]``: tipo
* ``array``: nomedo array
* ``new int[4]``: declaração

Declaração de um array passando os valores diretamente: ``int[] array = new int[] {42, 75, 74, 61};``

> Nesse caso podemos omitir o tamanho.

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

// Removendo elementos da lista, os outros elementos passam a ocupar o lugar do que foi removido. A capacidade continua sendo 8.
listaString.Remove("MG");

System.Console.WriteLine($"Ites na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
~~~~

# ⭐ Dados e Listas com .NET C#
## 🚀``Propeiedades, Métodos e Construtores com C#``
### 1️⃣ Properiedades, métodos e construtores
#### 📍 Introdução Propriedades:

* Uma propriedade é um membro que oferece um mecanismo flexível (colocar validações) para ler, gravar ou calcular o valor de umcampo particular.

#### 📍 Validações no GET e SET:

* Podemos validar os valores passados para as propriedades com condicionais e exceções.

~~~~C#
namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome; // Campo que armazena o Nome.
        public string Nome // Propriedade
        {
             get
             {
                return _nome.ToUpper(); // Retorna o valor de _nome em maíusculas.
             }
             set{
                if (value == "") //value é o argumento que está recebendo a propriedade nome.
                {
                    // Criando excessão caso o valor de nome seja vazio.
                    // Encerra o programa.
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value; // Passando o valor para _nome caso a condicional não seja executada.
             }
        } // Propriedade
        public int Idade { get; set; } // Propriedade

        public void Apresentar() // Método
        {
            System.Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}
~~~~

#### 📍 Body Expressions:

~~~~C#
...

 public string Nome
        {
            get => _nome.ToUpper(); // Retorna o valor de _nome em maíusculas de forma simplificada.
        }

...
~~~~

#### 📍 Validando a propriedade idade:

~~~~C#
namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome; // Campo que rmazena o Nome.
        private int _idade; // Campo que rmazena a Idade
        public string Nome //Prorpriedade
        {
            get => _nome.ToUpper(); // Retorna o valor de _nome em maíusculas de forma simplificada.

            set
            {
                if (value == "") //value é o argumento que está recebendo a propriedade nome.
                {
                    // Criando execessão caso o valor de nome seja vazio.
                    // Encerra o programa.
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value; // Passando o valor para _nome caso a condicional não seja executada.
            }
        } // Propriedade
        public int Idade // propriedad
        { 
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menos que 0");
                }

                _idade = value;
            }
        } // Propriedade

        public void Apresentar() // Método
        {
            System.Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}
~~~~

#### 📍Modificadores de acesso:

* ``public`` significa que qualquer um pode acessar a classe ou a propriedade.
* ``private`` significa que só pode ser acessado dentro da classe em que está inserido.

#### 📍Propriedas somente leitura:
* Essas propriedades não utilizam o 'set' apenas o 'get'.
~~~~C#
namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome; // Armazena o Nome.
        private int _idade; // Armazena a Idade
        public string Nome
        {
            get => _nome.ToUpper(); // Retorna o valor de _nome em maíusculas de forma simplificada.

            set
            {
                if (value == "") //value é o argumento que está recebendo a propriedade nome.
                {
                    // Criando execessão caso o valor de nome seja vazio.
                    // Encerra o programa.
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value; // Passando o valor para _nome caso a condicional não seja executada.
            }
        } // Propriedade

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // Esta é uma propriedade só de 'get' que vai armazenar os valores de Nome e Sobrenome. Além de tranforma-los em maiúsculas.
        public int Idade 
        { 
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menos que 0");
                }

                _idade = value;
            }
        } // Propriedade

        public void Apresentar() // Método
        {
            System.Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}
~~~~

* O program fica assim:
~~~~C#
using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(); // Instanciando classe Pessoa
p1.Nome = "Leonardo";
p1.Sobrenome = "Buta";
p1.Idade = 20;
p1.Apresentar();
~~~~

#### 📍Introdução métodos:

* Um método é um bloco de código que contém uma série de instruções.

#### 📍Implementando a classe curso:

~~~~C#
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
    }
}
~~~~

#### 📍Tipos de retorno:

~~~~C#

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
    }
}
~~~~

#### 📍Implementando o método remover:

* Quando um método é void não retornamos nada
* Quando um méotdo é diferente de void precisamos obrigatóriamente retornar um valor do tipo que foi declarado no método.

~~~~C#
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
    }
}
~~~~

#### 📍Implementando o método de listar alunos:
* Neste exemplo estamos trabalhando com duas classes: Pessoa e Curso.

**Program.cs:**
~~~~C#
using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(); // Instanciando classe Pessoa.
p1.Nome = "Leonardo";
p1.Sobrenome = "Buta";

Pessoa p2 = new Pessoa(); // Instanciando classe Pessoa.
p2.Nome = "Eduardo";
p2.Sobrenome = "Neves Queiroz";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>(); // Cria e recebe uma nova lista.

cursoDeIngles.AdicionarAluno(p1); // Passando valores adquiridos com a classe Pessoa como parâmetro para serem adicionados na lista.
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarALuos();
~~~~

> Quando temos uma lista como propriedade, precisamos isntanciar essa lista, se não ela vai se tornar nula.

**Pessoas.cs**

~~~~C#
namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome; // Armazena o Nome.
        private int _idade; // Armazena a Idade
        public string Nome
        {
            get => _nome.ToUpper(); // Retorna o valor de _nome em maíusculas de forma simplificada.

            set
            {
                if (value == "") //value é o argumento que está recebendo a propriedade nome.
                {
                    // Criando execessão caso o valor de nome seja vazio.
                    // Encerra o programa.
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value; // Passando o valor para _nome caso a condicional não seja executada.
            }
        } // Propriedade

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // Esta é uma propriedade só de 'get' que vai armazenar os valores de Nome e Sobrenome. Além de tranforma-los em maiúsculas.
        public int Idade 
        { 
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menos que 0");
                }

                _idade = value;
            }
        } // Propriedade

        public void Apresentar() // Método
        {
            System.Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}
~~~~

**Curso.cs:**

~~~~C#
amespace ExemploExplorando.Models
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
        {   System.Console.WriteLine($"Alunos do curso de ");
            foreach(Pessoa aluno in Alunos)
            {
                System.Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}
~~~~


#### 📍Trabalhando com construtores:
* Construtores permitem que o programador defina valores padrão, limite a instanciação e grave códigos flexíveis e fáceis de ler

* Todo construtor tem o mesmo nome da sua classe e não tem retorno.

* A partir do momento que se cria um construtor exigindo uma determinada quantidade de parâmetros de determinados tipos, toda classe que instanciar a classe a qual ele está inserido precisa obrigatóriamente passar o mesmo número de parâmetros do mesmo tipo.

* Se pode ter quantos construtores quiser em uma classe.

~~~~C#
namespace ExemploExplorando.Models
{
    public class Pessoa
    {   public Pessoa() // Construtor que não recebe nada e vai servir como valor padrão para a classe
        {

        }
        public Pessoa(string nome, string Sobrenome) // Construtor que recebe dois valores do tipo string
        {

        }

        private string _nome; // Armazena o Nome.
        private int _idade; // Armazena a Idade
        public string Nome
        {
            get => _nome.ToUpper(); // Retorna o valor de _nome em maíusculas de forma simplificada.

            set
            {
                if (value == "") //value é o argumento que está recebendo a propriedade nome.
                {
                    // Criando execessão caso o valor de nome seja vazio.
                    // Encerra o programa.
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value; // Passando o valor para _nome caso a condicional não seja executada.
            }
        } // Propriedade

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // Esta é uma propriedade só de 'get' que vai armazenar os valores de Nome e Sobrenome. Além de tranforma-los em maiúsculas.
        public int Idade 
        { 
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menos que 0");
                }

                _idade = value;
            }
        } // Propriedade

        public void Apresentar() // Método
        {
            System.Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}
~~~~

#### 📍Implementando construtor:

* Atribuímos os valores dos parâmetros as propriedades.

~~~~C#
        public Pessoa() // Construtor que não recebe nada e vai servir como valor padrão para a classe
        {

        }
        public Pessoa(string nome, string sobrenome) // Construtor que recebe dois valores do tipo string
        {
            Nome = nome; // A propriedade nome recebe o valor do parâmetro nome
            Sobrenome = sobrenome; // A propriedade Sobrenome recebe o valor do parâmero sobrenome
        }

~~~~

* Podemos passar os nomes dos parâmetros no código para ficar mais claro:

~~~~C#
using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta"); // Instanciando classe Pessoa
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Queiroz"); // Instanciando classe Pessoa
~~~~

# ⭐ Dados e Listas com .NET C#
## 🚀``Manipulando Valores com C#``
### 1️⃣ Manipulando valores
#### 📍 Concatenando strings:

* Concatenação de strings usando "+":

~~~~C#
...

  public void ListarALuos()
        {
            System.Console.WriteLine($"Alunos do curso de {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
                System.Console.WriteLine(texto);
            }

        }
~~~~

#### 📍 Interpolação strings:
~~~~C#
  public void ListarALuos()
        {
            System.Console.WriteLine($"Alunos do curso de {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                // string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
                string texto = $"Nº {count} - {Alunos[count].NomeCompleto}";
                System.Console.WriteLine(texto);
            }

        }
~~~~

#### 📍 Ajusantando a numeração:

~~~~C#
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
~~~~

> Não podemos colocar 'count++' pois isso estaria modificando o valor da variável.

#### 📍 Concatenação de valores:

~~~~C#
using ExemploExplorando.Models;

string numero1 = "10";
int numero2 = 20;

string resultado = numero1 + numero2;

System.Console.WriteLine(resultado);
~~~~
* O resultado é uma string
> Console: 1020

#### 📍 Formatando valores monetários:

~~~~C#
using ExemploExplorando.Models;

decimal valorMonetario = 1572.40M;

System.Console.WriteLine($"{valorMonetario:C}");
~~~~
> Console: R$ 1.572,40

#### 📍 Alterando localização do código:

* Em qualquer lugar que o código for executado a moeda sempre vai ser a mesma:

~~~~C#
using ExemploExplorando.Models;

using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
decimal valorMonetario = 1572.40M;

System.Console.WriteLine($"{valorMonetario:C}");
~~~~

> Console: $1,572.40

#### 📍 Alterando localização da cultura:
~~~~C#
using ExemploExplorando.Models;

using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
decimal valorMonetario = 1572.40M;

// Expecificando cultura
System.Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
~~~~

#### 📍 Formatação personalizada:

~~~~C#
using ExemploExplorando.Models;

using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
decimal valorMonetario = 1572.40M;

// Formata o número de casas decimais ainda no currency
System.Console.WriteLine(valorMonetario.ToString("C3"));

// Formata o número de casas decimais sem o currency
System.Console.WriteLine(valorMonetario.ToString("N2"));

~~~~

#### 📍 Representando porcentagem:

~~~~C#
// Formatação com porcentagem
double porcentagem = .3421;
System.Console.WriteLine(porcentagem.ToString("P"));

// Formatação com traços
int numero = 123456;
System.Console.WriteLine(numero.ToString("##-##-##"));
~~~~

> Console:<br>
34,21%<br>
12-34-56

#### 📍 Formatando data e hora:

~~~~C#
using System.Globalization;

// Personalizando a data atual
DateTime dataAtual =  DateTime.Parse("17/04/2022 18:00");
// Exibindo somente a data
Console.WriteLine(dataAtual.ToShortDateString());

// Personalizando a data atual
DateTime horaAtual =  DateTime.Parse("17/04/2022 18:00");
// Exibindo somente a hora
Console.WriteLine(horaAtual.ToShortTimeString());
~~~~

#### 📍 DateTime com TryParse:

~~~~C#
using System.Globalization;

string dataString = "2022-13-17 18:00";

// Tenta converter a data passada para o tipo DateTime, se não conseguir converte  para a variável chamada data
DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// 1:data, 2:formato, 3:localização, 4:estilo, 5:saída

System.Console.WriteLine(data);
~~~~

> Console: 01/01/0001 00:00:00

#### 📍 Validando o retorno do TryParse:

* Já que o TryParse retorna true ou false podemos obeter um retorno do tipob bool e aderir a uma variável.

~~~~C#
using System.Globalization;

string dataString = "2022-04-17 18:00";

// Tenta converter a data passada para o tipo DateTime, se não conseguir converte  para a variável chamada data
bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
// 1:data, 2:formato, 3:localização, 4:estilo, 5:saída

if (sucesso)
{
    System.Console.WriteLine($"Conversão realizada com sucesso! Data: {data}");
}
else
{
    System.Console.WriteLine($"{dataString} não é uma data válida");
}
~~~~

## 🚀 ``Exeções e Coleções em C#``
### 1️⃣ Exceções e Coleções
#### 📍 Introdução Exceções:

**Exception:**

* Os recursos de manipulação de exceção da linaguagem C# ajudam você a lidar com quaisquer situações excepcionais ou inesperadas que ocorram quando um programa for executado.

#### 📍 Realizando a leitura de um arquivo:

* Criamos um arquivo txt na pasta arquivos.

~~~~C#
string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
// Cada linha é considerada uma string.
// File: classe utilizada para ler arquivo.
// ReadAllLine: método para ler todas as linhas.
// ("Arquivos/arquivoLeitura.txt");: localização do arquivo.
// Estamos retornando um array ou coleção de strings que representam o arquivo.

// Para cada elemento(linha) no array ele retorna uma linha do arquivo txt.
foreach(string linha in linhas)
{
    System.Console.WriteLine(linha);
}
~~~~

#### 📍 Tratando uma exceção:

* Para tratar uma exceção usamos o try e o catch:

~~~~C#

try{ // Tenta executar o código.
    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt"); // Passando nome do arquivo errado.

    foreach(string linha in linhas)
    {
        System.Console.WriteLine(linha);
    }
}catch(Exception ex) // Obtém a exceção caso o código não posssa ser executado. A variável 'ex' é a exceção que fo retornada.
{
    System.Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}"); // ex.Message: é a mensagem da exceção.
}

// O código é exebido mesmo após a exceção 
System.Console.WriteLine("Cehgou até aqui");
~~~~

#### 📍 Exceção genérica e específica:

* Podemos tratar as exceções de forma mais específica:

~~~~C#
using ExemploExplorando.Models;
using System.Globalization;

try{ // Tenta executar o código.
    string[] linhas = File.ReadAllLines("Arquivos/d/arquivo_Leitura.txt"); // Passando nome do arquivo errado.

    foreach(string linha in linhas)
    {
        System.Console.WriteLine(linha);
    }
}
catch(FileNotFoundException ex) // Exceção de arquivo não encontrado
{
    System.Console.WriteLine($"Ocorreu um erro na leiruta do arquivo. Arquivo não encontrado {ex.Message}");
}
catch(DirectoryNotFoundException ex) // Exceção de pasta não encontrada
{
    System.Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontradao {ex.Message}");
}
catch(Exception ex) // Obtém a exceção caso o código não posssa ser executado. A variável 'ex' é a exceção que fo retornada.
{
    System.Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}

// O código é exebido mesmo após a exceção 
System.Console.WriteLine("Cehgou até aqui");
~~~~

#### 📍 Entendendo o bloco finally:

* O bloco finally é executado independente de ter ocorrido uma exceção ou não

~~~~C#
try{ // Tenta executar o código.
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt"); // Passando nome do arquivo errado.

    foreach(string linha in linhas)
    {
        System.Console.WriteLine(linha);
    }
}
catch(FileNotFoundException ex) // Exceção de arquivo não encontrado
{
    System.Console.WriteLine($"Ocorreu um erro na leiruta do arquivo. Arquivo não encontrado {ex.Message}");
}
catch(DirectoryNotFoundException ex) // Exceção de pasta não encontrada
{
    System.Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontradao {ex.Message}");
}
catch(Exception ex) // Obtém a exceção caso o código não posssa ser executado. A variável 'ex' é a exceção que fo retornada.
{
    System.Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
    System.Console.WriteLine("Chegou até aqui");
}
~~~~

#### 📍 Usando o throw:

* O throw cria uma nova exceção e executa o caminho de volta até achar algum bloco 'catch' que trate essa exceção.

~~~~C#
namespace ExemploExplorando.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }catch(Exception ex) // Trata a exceção
            {
                System.Console.WriteLine("Exceção tratada" + ex.Message);
            }
    }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção"); // Cria uma nova exceção
        }

    }
}
~~~~

* Pograma que executa o código:
~~~~C#
using ExemploExplorando.Models;
using System.Globalization;

new ExemploExcecao().Metodo1();
~~~~

#### 📍Introdução a Filas:

* O primeiro a entrar na fila é o primeiro a sair (FIFO).
* Armazena apenas um tipo de valor.

#### 📍Fila na prática:

* Nas filas só se pode remover o primeiro elemento que entrou.
~~~~C#
// Cria uma nova fila
Queue<int> fila = new Queue<int>();

// Adiciona elementos na fila
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

// Percorrendo fila
foreach(int item in fila)
{
    System.Console.WriteLine(item);
}

// Remove um elemento da fila, no caso o '2' já que foi o primeiro valor a entrar.
System.Console.WriteLine($"Removendo o elemento {fila.Dequeue()}");
fila.Enqueue(10);

foreach(int item in fila)
{
    System.Console.WriteLine(item);
}
~~~~

#### 📍Introdução a Pilhas:

* Na pilha o último que entrou é o primeiro a sair. (LIFO)


#### 📍Pilha na pática:

* Nas pilhas só se pode remover o último elemento que entrou.

~~~~C#

// Criando pilha
Stack<int> pilha = new Stack<int>();

// Adicionando elementos na pilha
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

// Percorrendo pilha
foreach(int item in pilha)
{
    System.Console.WriteLine(item);
}

// Removendo item da pilha, no caso o 10 já que foi o último a ser inserido.
System.Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}"); 

// Adicionando o número '20' que irá ocupar o lugar do 10 e ficar no topo da pilha
pilha.Push(20);
foreach(int item in pilha)
{
    System.Console.WriteLine(item);
}
~~~~

#### 📍Introdulão Dictionary
* Um dictionary é uma coleção de chave-valor para armazenar valores únicos sem uma ordem específica.
* Dessa forma não é permitido usar a mesma chave para mais de um valor.

~~~~C#
Dictionary<string, string> estados = new Dictionary<string, string>();
// Dictionary<string, string>: chave do tipo string e valor do tipo string.

// Adicionando valores
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

// Percorrendo dicionário
foreach(var item in estados)
{
    // Exibindo chave e valor
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
~~~~

#### 📍Removendo e alterando elementos:

~~~~C#
using ExemploExplorando.Models;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();
// Dictionary<string, string>: chave do tipo string e valor do tipo string.

// Adicionando valores
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

// Percorrendo dicionário
foreach(var item in estados)
{
    // Exibindo chave e valor
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
System.Console.WriteLine("-----------");

// Removendo item
estados.Remove("BA");

// Alterando valor pela chave
estados["SP"] = "São Paulo - valor alterado";

// Percorrendo dicionário
foreach(var item in estados)
{
    // Exibindo chave e valor
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// Veirifca se a chave existe
string chave = "BA";
System.Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    System.Console.WriteLine($"Valor existente {chave}");
}
else{
    System.Console.WriteLine($"Valor não existente. É seguro adicionar a chave: {chave}");
}

// Resgatando valor pela chave
System.Console.WriteLine(estados["MG"]);
~~~~


## 🚀 ``Tuplas, Operador Ternário e Descontrução de um Objeto com C#``
### 1️⃣ Tuplas, Operador Ternário e Descontrução de um Objeto 
#### 📍 Introdução:

* Tuplas fornecem uma sintaxe concisa para agrupar vários elementos de dados em uma estrutura de dados leve.

* Uma tupla não é cuma coleção, mas pode ter dentro de si uma coleção de diferentes tipos.

~~~~C#

// Criando tupla
(int, string, string, decimal) tupla = (1, "Leonardo", "Buta", 1.80M);

// Resgatando valor das tuplas e exibindo no console
System.Console.WriteLine($"Id: {tupla.Item1}");
System.Console.WriteLine($"Nome: {tupla.Item2}");
System.Console.WriteLine($"Sobrenome: {tupla.Item3}");
System.Console.WriteLine($"Altura: {tupla.Item4}");
~~~~

#### 📍 Outra sintaxe de tupla:

~~~~C#
// Criando tupla
(int, string, string, decimal) tupla = (1, "Leonardo", "Buta", 1.80M);

// Outras maneiras de representar tuplas
ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Leonardo", "Buta", 1.80M);
var outroExemploTuplaCreate = Tuple.Create(1, "Leonardo", "Buta", 1.80M);
~~~~

#### 📍 Tupla em métodos:

~~~~C#
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
~~~~

#### 📍Testando nosso método:

* Criamos a classse LeituraArquivo.cs e vamos usar o arquivoLeitura.txt novamente.

~~~~C#
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
~~~~

~~~~C#
using ExemploExplorando.Models;
using System.Globalization;

LeituraArquivo arquivo = new LeituraArquivo();

// Como o método LerArquivo retorna uma tupla, conseguimos criar uma nova tupla a partir do retorno desse método.
var (sucesso, linhasArquivo, QuantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// Caso try: var (sucesso, linhasArquivo, QuantidadeLinhas) =  (true, linhas, linhas.Count());
// Caso catch: var (sucesso, linhasArquivo, QuantidadeLinhas) =  (false, new string[0], 0);

if (sucesso)
{   System.Console.WriteLine("Quantidade linhas do arquivo: " + QuantidadeLinhas);
    foreach(string linha in linhasArquivo)
    {
        System.Console.WriteLine(linha);
    }
}
else{
    System.Console.WriteLine("Mão foi possível ler o arquivo");
}
~~~~

#### 📍Descartes:

* Utilizamos o '_' quando não iremos usar alguma informação da tupla.

~~~~C#
using ExemploExplorando.Models;
using System.Globalization;

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{   
    // System.Console.WriteLine("Quantidade linhas do arquivo: " + QuantidadeLinhas);
    foreach(string linha in linhasArquivo)
    {
        System.Console.WriteLine(linha);
    }
}
else{
    System.Console.WriteLine("Mão foi possível ler o arquivo");
}
~~~~

#### 📍Desconstrutor:

~~~~C#
namespace ExemploExplorando.Models
{
    public class Pessoa
    {   
        public Pessoa() // Construtor que não recebe nada e vai servir como valor padrão para a classe
        {

        }
        public Pessoa(string nome, string sobrenome) // Construtor que recebe dois valores do tipo string
        {
            Nome = nome; // A propriedade nome recebe o valor do parâmetro nome
            Sobrenome = sobrenome; // A propriedade Sobrenome recebe o valor do parâmero sobrenome
        }

        public void Deconstruct(out string nome, out string sobrenome)
        // Usamos o out antes de cada parâmetro
        {
            // inversão do construtor
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome; // Armazena o Nome.
        private int _idade; // Armazena a Idade
        public string Nome
        {
            get => _nome.ToUpper(); // Retorna o valor de _nome em maíusculas de forma simplificada.

            set
            {
                if (value == "") //value é o argumento que está recebendo a propriedade nome.
                {
                    // Criando execessão caso o valor de nome seja vazio.
                    // Encerra o programa.
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value; // Passando o valor para _nome caso a condicional não seja executada.
            }
        } // Propriedade

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // Esta é uma propriedade só de 'get' que vai armazenar os valores de Nome e Sobrenome. Além de tranforma-los em maiúsculas.
        public int Idade 
        { 
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menos que 0");
                }

                _idade = value;
            }
        } // Propriedade

        public void Apresentar() // Método
        {
            System.Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}
~~~~

~~~~C#
using ExemploExplorando.Models;
using System.Globalization;

// Utilizando construtor
Pessoa p1 = new Pessoa("Leonardo", "Buta");

// Utilizando desconstrutor
(string nome, string sobrenome) = p1;

System.Console.WriteLine($"{nome} {sobrenome}");
~~~~

#### 📍IF Ternário:

~~~~C#
int numero = 20;
bool ehPar = false;

ehPar = numero % 2 == 0;
System.Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));
~~~~

## 🚀 ``Nuget, Serializar e Atributos no C#``
### 1️⃣ Nuget, Serializar e Atributos no C# 
#### 📍 Introdução gereciardor de pacotes:

* Um pacote é um conjunto de códigos úteis, que possibilita o compartilhamento e reuso do código.
* Nuget é um gerenciador de pacotes, que permite desenvolvedores compartilharem códigos e bibliotecas.

#### 📍 Explorando o Nuget:

* Acessar o site: [Nuget](https://www.nuget.org/)

#### 📍 Instalando um pacote pelo VS Code:

* Copiar e colar o comando de instalação no terminal: ``dotnet add package Newtonsoft.Json --version 13.0.3``.
* O pacote ficará localizado no arquivo.csproj.

#### 📍 Introdução serialização:

* **Serialização e desserialização:** O processo de serializar consiste em tranaformar objetos em fluxo de bytes para seu armazenamento ou transmissão.

* **JSON:** Javasrcipt Notation Object é um formato de texto que segue a sintaxe Javascript, muito usado para trasmitir dados entre aplicações (representação de um objeto em um arquivo de texto).

#### 📍 Serialização na prática:
* Criamos uma classe chamada Vendas.cs:

~~~~C#
namespace ExemploExplorando.Models
{
    public class Venda
    {   
        public Venda(int id, string produto, decimal preco) // Construtor
        {
            Id = id;
            Produto = produto;
            Preco = preco;
        }
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
    }
}
~~~~


**Program.cs:**
~~~~C#
using ExemploExplorando.Models;

// Importando Json
using Newtonsoft.Json;

Venda v1 = new Venda(1, "Material de escritório", 25.00M);

// Serializando objeto
string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
// (v1, Formatting.Indented): Identa o texto para que fique mais claro de ler.


// Exibe o objeto em formato Json
System.Console.WriteLine(serializado);
~~~~

> Console: <br>
{<br>
    "Id": 1,<br>
  "Produto": "Katerial de escritório",<br>
  "Preco": 25.00<br>
}

#### 📍 Escrevendo um arquivo JSon:

~~~~C#
using ExemploExplorando.Models;
using Newtonsoft.Json;

Venda v1 = new Venda(1, "Katerial de escritório", 25.00M);

// Serializando objeto
string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
// (v1, Formatting.Indented): Identa o texto para que fique mais claro de ler.

// Criando arquivo json a partir do objeto serializado
File.WriteAllText("Arquivos/vendas.json", serializado);
// ("Arquivos/vendas.json", serializado): caminho onde arquivo irá ser criado e o objeto.

// Exibe o objeto em formato Json
System.Console.WriteLine(serializado);
~~~~

> A partir disso será criado um arquivo json com as informações do objeto serializado

#### 📍 Serializando uma coleção:

~~~~C#
using ExemploExplorando.Models;
using Newtonsoft.Json;

// Cria uma lista parar armazenar os valores das variáveis da classe 'Venda'.
List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M);
Venda v2 = new Venda(2, "Licença de Software", 110.00M);

// Adiciona os valores na lista
listaVendas.Add(v1);
listaVendas.Add(v2);

// Serializando objeto
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// (v1, Formatting.Indented): Identa o texto para que fique mais claro de ler.

// Criando arquivo json a partir do objeto serializado
File.WriteAllText("Arquivos/vendas.json", serializado);
// ("Arquivos/vendas.json", serializado): caminho onde arquivo irá ser criado e o objeto.

// Exibe o objeto em formato Json
System.Console.WriteLine(serializado);
~~~~

> Isso cria um arquivo JSON em formato de coleção onde teremos vários objetos dentro dela.

**vendas.json:**
~~~~JSON
[
  {
    "Id": 1,
    "Produto": "Material de escritório",
    "Preco": 25.00
  },
  {
    "Id": 2,
    "Produto": "Licença de Software",
    "Preco": 110.00
  }
]
~~~~

#### 📍JSON Viewer:

Acessar o site: **Code Beautify** para validar o arquivo JSON, diminuir o tamanho, converter para XML entre outras funcionalidades.

#### 📍DateTime com JSON:

* O JSON usa o formato 'ISO 8601' para padronizar data entre sistemas.

Criamos um novo atributo para data no Venda.cs:

~~~~C#
namespace ExemploExplorando.Models
{
    public class Venda
    {   
        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
~~~~

**Program.cs:**

~~~~C#
using ExemploExplorando.Models;
using Newtonsoft.Json;

// Cria uma lista parar armazenar os valores das variáveis da classe 'Venda'.
List<Venda> listaVendas = new List<Venda>();

// Retorna a data atual do sistema
DateTime dataAtual = DateTime.Now;

// Adiciona a dataAtual no objeto
Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// Adiciona os valores na lista
listaVendas.Add(v1);
listaVendas.Add(v2);

// Serializando objeto
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// (v1, Formatting.Indented): Identa o texto para que fique mais claro de ler.

// Criando arquivo json a partir do objeto serializado
File.WriteAllText("Arquivos/vendas.json", serializado);
// ("Arquivos/vendas.json", serializado): caminho onde arquivo irá ser criado e o objeto.

// Exibe o objeto em formato Json
System.Console.WriteLine(serializado);
~~~~

#### 📍Desserializando um objeto:

* Queremos tranformar o arquivo JSON em um objeto

~~~~C#
using ExemploExplorando.Models;
using Newtonsoft.Json;

// Lendo arquivo JSON
string conteudoArquivo = File.ReadAllText("arquivos/vendas.json");

// Desserializando o JSON e tranformando em objeto no formato de lista no C#
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// Percorrendo lista do objeto desserializado
foreach (Venda venda in listaVenda)
{
    System.Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}
~~~~

#### 📍 Atributos:

* Durante a desserialização o nome das chaves do arquivo json pode vir diferente do nome dos atributos.

~~~~C#
// Usando namespace
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class Venda
    {
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")] // Mapeia a chave "Nome_Produto" do JSON para a propriedade Produto durante a desserialização.
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
~~~~