using System;

class Program
{
    static void Main(string[] args)
    {
        int limite;

        Console.Write("Digite um número inteiro positivo: ");
        limite = int.Parse(Console.ReadLine());

        while (limite < 0) ;

        int i = 0;
        Console.WriteLine("Números pares entre 0 e " + limite + ":");

        do
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        } while (i <= limite);
    }
}

