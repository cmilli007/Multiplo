Console.WriteLine("________");
Console.WriteLine("MULTIPLO");
Console.WriteLine("Digite um número:");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Esse numero é multiplo de: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

if (numero1 % numero2 == 0)
{
    Console.WriteLine($"{numero1} é múltiplo de {numero2}");
}
    else
    {
    Console.WriteLine($"{numero1} não é múltiplo de {numero2}");
    }