using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades_Metodos_Construtores.Model
{
    // Classe
    public class Pessoa
    {
        // Atributos
        private string _nome;

        public string Nome  // Validando GET e SET 
        {
            get // Obter valor
            {
                return _nome.ToUpper(); // Transforma o todo valor recebido em maiusculo 
            }

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

        public int Idade { get; set; }

        // Métodos
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}