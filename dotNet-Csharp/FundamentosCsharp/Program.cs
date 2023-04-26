using FundamentosCsharp.Models;

/*
// Instanciando Classe
Pessoa p = new Pessoa();

// Passando Dados para a instancia
p.Nome = "Helio";
p.Idade = 19;

// Chamando Método
p.Apresentar();
 */

/* 
// DECLARANDO VARIAVEIS: tipo nomeVariavel = valor

string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine($"Valor da variavel quantidade: {quantidade}");
Console.WriteLine($"Valor da variavel altura: {altura.ToString("0.00")}");
Console.WriteLine($"Valor da variavel preco: {preco}");
Console.WriteLine($"Valor da variavel condicao: {condicao}");
 */

/* 
// UTILIZANDO O DateTime para pegar data e horas atuais
DateTime dataHoraAtual = DateTime.Now;
Console.WriteLine($"Data e Hora atual: {dataHoraAtual}");

// UTILIZANDO O DateTime e adicionando dias
DateTime addDiasNaDataAtual = DateTime.Now.AddDays(5);
Console.WriteLine($"Data adicionada 5 dias e Hora atual : {addDiasNaDataAtual}");

// UTILIZANDO O DateTime e formatando saida
Console.WriteLine($"DateTime formatado p/ mostrar somente a data : {addDiasNaDataAtual.ToString("dd/MM/yyyy")}");
Console.WriteLine($"DateTime formatado p/ mostrar data e hora sem milissegundos : {addDiasNaDataAtual.ToString("dd/MM/yyyy HH:mm")}");
 */

/* 
// CONVERTENDO TIPOS DE VARIAVEIS (CAST/CASTING)
int a = Convert.ToInt32("5"); //Convert consegue tratar valores null
Console.WriteLine(a);
int b = int.Parse("5"); //Parse não consegue tratar valores null
Console.WriteLine(b);
int inteiro = 5;
string c = inteiro.ToString(); //ToString converte valores para string

// CONVERTENDO DE MANEIRA SEGURA
string texto = "15-";
int d;

int.TryParse(texto, out d);
// o método "int.TryParse()" tenta converter uma string em um valor do tipo inteiro. 
// Se bem-sucedida, retorna "true" e o valor inteiro convertido é armazenado na variável de saída.
// Se a conversão falhar, ele retorna "false" e a variável de saída é definida como 0.
Console.WriteLine(d);
 */

/* 
// OPERADORES CONDICIONAIS

// IF/IF-ELSE
int quantidadeEmEstoque = 10;
int quantidadeCompra = 1;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade na Compra: {quantidadeCompra}");
Console.WriteLine($"É possivel fazer a venda: {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade deseja em estoque.");
}


// SWITCH CASE
Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("vogal");
        break;
    default:
        Console.WriteLine("consoante");
        break;
}
*/

// OPERADORES LÓGICOS
/* 
//Operador OR (||)
bool ehMaiorDeIdade = false;
bool possuiAutorizacaoDoResponsavel = true;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada!");
}
else
{
    Console.WriteLine("Entrada não liberada.");
}

//Operador AND (&&) 
bool possuiPresencaMinima = true;
double media = 6.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}

//Operador NOT (!)
bool choveu = true;
bool estaTarde = true;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou Pedalar");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}
*/


// Criando Calculadora

// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

/* 
// Incremento de numero
int numero = 10;
Console.WriteLine($"Numero antes da incremento: {numero}");

Console.WriteLine("Incrementando o 10");
numero++;

Console.WriteLine($"Numero depois da incremento: {numero}");

// Decremento de numero
int numeroDecremento = 20;
Console.WriteLine($"Numero antes do Decremento: {numeroDecremento}");

Console.WriteLine("Decrementando o 10");
numeroDecremento--;

Console.WriteLine($"Numero depois da Decremento: {numeroDecremento}");
*/

// ESTRUTURAS DE REPETIÇÂO 

/* 
// FOR
int numero = 5;
for (int contador = 1; contador <= 10; contador++)
{
    Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
}
*/

/* 
// WHILE
int contador = 1;
while (contador <= 10)
{
    Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");

    // Interrompendo fluxo de execução com BREAK
    if (contador == 5)
    {
        break;
    }

    contador++;
}
*/

/* 
// DO WHILE
int soma = 0, numeroDigitado = 0;
do
{
    Console.WriteLine("Digite um numero (0 para parar)");
    numeroDigitado = Convert.ToInt32(Console.ReadLine());

    soma += numeroDigitado;
} while (numeroDigitado != 0);

Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");
*/

/* 
string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("[1] - Cadastrar cliente");
    Console.WriteLine("[2] - Buscar cliente");
    Console.WriteLine("[3] - Apagar cliente");
    Console.WriteLine("[4] - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro do cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            // Environment.Exit(0); // Ao executar este comando nada após a linha será executada
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }
}

Console.WriteLine("O programa encerrou...");
*/

// ARRAY e LISTAS
/* 
//FORMAS DE DECLARAÇÂO
int[] array = new int[4];   // Declarar array com tamanho fixo
int[] arrays = new int[] { 42, 75, 74, 61 };   // Declarar array, passando valores 
string[] meses = { "Jan", "Fev" };   // Declarar array, passando valores
 */

// IMPLEMENTANDO ARRAY

// declarando array
int[] arrayInteiros = new int[3];

// passando valores
arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 58;
// arrayInteiros[3] = 1;    //ocorre erro por ultrapassar tamnho do array

// Percorrendo arryay com FOR
Console.WriteLine("Percorrendo o Array com o FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição n°{contador} = {arrayInteiros[contador]}");
}

// Percorrendo arryay com FOREACH
Console.WriteLine("\nPercorrendo o Array com o FOREACH");
int contadorForeach = 0; // constador desnecessario para execução do codigo, utilizado apenas para mostrar posição 
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição n°{contadorForeach} = {valor}");
    contadorForeach++;
}