string numero = Console.ReadLine();
int num = Convert.ToInt32(numero);

//TODO: Descubra e imprima se o número é azarado.
//Dica: O método "Contains" pode ser útil neste desafio.

if (num >= 0)
{
    if (numero.Contains("13"))
    {
        Console.WriteLine($"{numero} es de Mala Suerte");
    }
    else
    {
        Console.WriteLine($"{numero} NO es de Mala Suerte");
    }
}