using System;

// uma string com os dois valores separados por espaço
string[] entrada = Console.ReadLine().Split();
int participantes = int.Parse(entrada[0]);
int cachorrosQuentes = int.Parse(entrada[1]);

//TODO: Calcular a média de cachorros-quentes consumidos pelos participantes.
double media = (double)participantes / cachorrosQuentes;

//TODO: Imprimir a média com duas casas decimais.
//Dica: Pesquise sobre o método "ToString".
Console.WriteLine(media.ToString("F2"));