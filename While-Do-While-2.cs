using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro para ver a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            i++;
        }
    }
}
