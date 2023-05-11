using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades_Metodos_Construtores.Model
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        /* TIPOS DE METODOS
        Void representa metodo sem retorno
        Qualquer outro tipo precisa de um retorno do mesmo tipo declarado
        */

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAlunos(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                // string texto = "N° " + count + " " + Alunos[count].NomeCompleto; // Concatenação de String
                string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}"; // Interpolação de String
                Console.WriteLine(texto);
            }
        }
    }
}