const int MaximoNumeros = 5;

List<int> numeros = LerNumeros(MaximoNumeros);
ImprimirQuantidades(numeros);

static List<int> LerNumeros(int maximo)
{
    List<int> numeros = new List<int>();

    while (numeros.Count < maximo)
    {
        Console.Write("Digite um número inteiro: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int numero))
        {
            numeros.Add(numero);
        }
        else if (string.IsNullOrWhiteSpace(entrada))
        {
            break;
        }
        else
        {
            throw new Exception("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }

    return numeros;
}

static void ImprimirQuantidades(List<int> numeros)
{
    int quantidadePares = 0;
    int quantidadeImpares = 0;
    int quantidadePositivos = 0;
    int quantidadeNegativos = 0;

    //TODO: Crie as condições necessárias para calcular cada uma das quantidades.
    //Observação: Caso queira usar um array uma lista para seus valores, fique à vontade...
    foreach (int numero in numeros)
    {
        if (numero % 2 == 0)
        {
            quantidadePares++;
        }
        else
        {
            quantidadeImpares++;
        }

        if (numero != 0)
        {
            if (numero > 0)
            {
                quantidadePositivos++;
            }
            else
            {
                quantidadeNegativos++;
            }
        }
    }

    Console.WriteLine("{0} par(es)", quantidadePares);
    //TODO: Imprima as outras linhas conforme o enunciado deste desafio.
    Console.WriteLine("{0} impar(es)", quantidadeImpares);
    Console.WriteLine("{0} positivo(s)", quantidadePositivos);
    Console.WriteLine("{0} negativo(s)", quantidadeNegativos);
}
