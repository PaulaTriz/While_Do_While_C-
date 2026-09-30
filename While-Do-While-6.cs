using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro positivo: ");
        int limite = int.Parse(Console.ReadLine());

        int i = 0;
        Console.WriteLine("Números pares entre 0 é " + limite + ":");

        if (limite >= 0)
        {
            do
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                }
                i++;
            } while (i <= limite);
        }
    }
}

