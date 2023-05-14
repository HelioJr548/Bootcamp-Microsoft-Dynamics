using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excecoes_Colecoes.models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exceção tratada. {ex.Message}"); //.Message retorna a exceção que ocorreu
                Console.WriteLine($"Exceção tratada. {ex.StackTrace}"); //.StackTrace retorna todo o caminho da exceção
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
            throw new Exception("Ocorreu uma exceção"); //Lança uma nova exceção
        }

    }

}