using Propriedades_Metodos_Construtores.Model;

//Instancindo Classes
Pessoa p1 = new Pessoa();
p1.Nome = "Helio";
p1.Sobrenome = "Santos";

Pessoa p2 = new Pessoa();
p2.Nome = "Joao";
p2.Sobrenome = "Perez";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

//Utilizando metodos da Classe Curso
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();