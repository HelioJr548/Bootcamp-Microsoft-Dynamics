using Propriedades_Metodos_Construtores.Model;

/* //Instancindo Classes atraves dos construtures
Pessoa p1 = new Pessoa(nome: "Helio", sobrenome: "Santos");
Pessoa p2 = new Pessoa(nome: "Joao", sobrenome: "Perez");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

//Utilizando metodos da Classe Curso
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos(); */

//Alterando localização do codigo (Sem o codigo, fica automatica)
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

//Formatando Valores Monetários
decimal valorMonetario = 82.40M;

Console.WriteLine($"{valorMonetario:C}"); // :C formata para a moeda da região (currency)
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); //formata para a moeda da região especificada