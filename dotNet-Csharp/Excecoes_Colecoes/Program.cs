using Excecoes_Colecoes.models;

//Testando o "throw new Exception"
new ExemploExcecao().Metodo1();



/* //Tratando Exceção
try
{
    //REALIZANDO LEITURA DE ARQUIVOS
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex) //Se arquivo não achado, armazena exceção na variavel ex
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex) //Se diretório não achado, armazena exceção na variavel ex
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch (Exception ex) //Se houver exceção, armazena na variavel ex
{
    Console.WriteLine($"Ocorreu uma exceção generica. {ex.Message}");
}
finally //Executado se ou não houver exceção
{
    Console.WriteLine("Chegou até aqui");
} */