using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNet_C_
{
    // Classe
    public class Pessoa
    {
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Métodos
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade}");
        }
    }
}