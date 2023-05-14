using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades_Metodos_Construtores.Model
{
    // Classe
    public class Pessoa
    {
        //Construtor padrao
        public Pessoa()
        { }

        //Construtor recebe nome e sobrenome
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // Atributos
        private string _nome, _sobrenome;
        private int _idade;

        public string Nome  // Validando GET e SET 
        {
            /* get // Obter valor
            {
                return _nome.ToUpper(); // Transforma o todo valor recebido em maiusculo 
            } */

            //Utilizando Body Expression
            get => _nome.ToUpper();

            // Caso meu SET não precisasse da validação, poderia utilizar Body Expression
            // set => _nome = value;

            set //Atribui valores
            {
                // Criando exceção
                if (value == "")
                {
                    // Caso se encaixe o codigo encerra aqui e mostra mensagem no console
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }


        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); //Propriedade somente de leitura

        public int Idade
        {

            get => -_idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não pode ser menor que zero");
                }
            }
        }

        // Métodos
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto}, e tenho {Idade} anos");
        }
    }
}