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
catch (FileNotFoundException ex) //Se arquivo não achado, armazena exceção na variavel ex
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch (Exception ex) //Se houver exceção, armazena na variavel ex
{
    Console.WriteLine($"Ocorreu uma exceção generica. {ex.Message}");
}