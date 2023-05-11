//Tratando Exceção
try
{
    //REALIZANDO LEITURA DE ARQUIVOS
    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (Exception ex) //Se houver exceção, armazena na variavel ex
{
    Console.WriteLine($"Ocorreu uma exceção generica. {ex.Message}");
}