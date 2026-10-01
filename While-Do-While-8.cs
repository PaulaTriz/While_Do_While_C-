using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número para ver na tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        int i = 1;

        do
        {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            i++;
        } while (i <= 10);
    }
}
