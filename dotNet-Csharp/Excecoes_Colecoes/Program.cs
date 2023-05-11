using Excecoes_Colecoes.models;

//Criando Pilha (LIFO: Last-In, First-Out)
Stack<int> pilha = new Stack<int>();

//Inserir elemento na Pilha
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

//Percorrer pilha
foreach (int item in pilha)
{
    Console.WriteLine(item);
}

//Remover elemento do topo
Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

//Inserir elemento na Pilha
pilha.Push(20);

//Percorrer pilha
foreach (int item in pilha)
{
    Console.WriteLine(item);
}









/* 
//Criando Fila  (FIFO: First-In, First-Out)
Queue<int> fila = new Queue<int>();

//Inserindo valor no final da fila
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

//Percorrer Fila
foreach (int item in fila)
{
    Console.WriteLine(item);
}

//Retirar elemento da fila (Sempre o primeiro elemento)
Console.WriteLine($"Removendo o 1° elemento da fila: {fila.Dequeue()}");

//Percorrer Fila
foreach (int item in fila)
{
    Console.WriteLine(item);
}
*/








/* //Testando o "throw new Exception"
new ExemploExcecao().Metodo1(); */



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