using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantos números deseja somar? ");
        int quantidade = int.Parse(Console.ReadLine());

        int soma = 0;
        int i = 1;

        while (i <= quantidade)
        {
            Console.Write("Digite o " + i + " o número: ");
            int num = int.Parse(Console.ReadLine());
            soma += num;
            i++;
        }
        Console.Write("A soma total dos números e " + soma);

    }
}
