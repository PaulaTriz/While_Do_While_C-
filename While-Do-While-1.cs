using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro positivo: ");
        int limite = int.Parse(Console.ReadLine());

        int i = 0;
        Console.WriteLine("Números pares entre 0 e " + limite + ":");

        while (i <= limite)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }
}