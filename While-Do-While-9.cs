using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantos números deseja somar? ");
        int quantidade = int.Parse(Console.ReadLine());

        int soma = 0;
        int i = 1;

        if ( quantidade > 0 )
        {
            do
            {
                Console.WriteLine("Digite o " + i + " número ");
                int num = int.Parse(Console.ReadLine());
                soma += num;
                i++;
            } while (i <= quantidade);
        }
        Console.WriteLine(" A soma total dos números é " + soma);
    }
}
