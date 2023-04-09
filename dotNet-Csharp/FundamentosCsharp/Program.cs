/*
using FundamentosCsharp.Models;

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

// CONVERTENDO TIPOS DE VARIAVEIS (CAST/CASTING)
int a = Convert.ToInt32("5"); //Convert consegue tratar valores null
Console.WriteLine(a);
int b = int.Parse("5"); //Parse não consegue tratar valores null
Console.WriteLine(b);
int inteiro = 5;
string c = inteiro.ToString(); //ToString converte valores para string
