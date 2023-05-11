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
//Ao colocar um numero apos o C, formata a quantidade de decimais (serve para as duas formas acima)
Console.WriteLine($"{valorMonetario:C20}"); //mostra 20 casas decimais

//Formatação para porcentagem
double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

//Formatação livre
double numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));

//Formatação do DateTime
DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());    //Exibe só data
Console.WriteLine(data.ToShortTimeString());    //Exibe só horário

string dataString = "32/04/2023 10:00";

DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, out DateTime dataValidada);

Console.WriteLine(dataValidada); //Se data valida exibe data, se não exibe valor padrao